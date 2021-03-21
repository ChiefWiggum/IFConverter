using IFConverter.Base.Model.IFolor;
using IFConverter.Base.Model.Xaml;
using System;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Drawing.Processing;
// using SixLabors.ImageSharp.Processing.Transforms;
// using SixLabors.ImageSharp.Processing.Drawing;
using SixLabors.ImageSharp.PixelFormats;
using System.Linq;
using System.IO;
using SixLabors.Fonts;
using System.Windows.Controls;
using FontStyle = SixLabors.Fonts.FontStyle;
using HorizontalAlignment = SixLabors.Fonts.HorizontalAlignment;
using Page = IFConverter.Base.Model.IFolor.Page;

// using SixLabors.Primitives;

namespace IFConverter.Base.Services
{
    public class ImageGeneratorService : IImageGeneratorService
    {
        private const string leadingZeros = "000";
        private readonly IIFolorService _iFolorService;
        private readonly IXamlService _xamlService;

        public ImageGeneratorService()
        {
            _iFolorService = new IFolorService();
            _xamlService = new XamlService();
        }
        public void GenerateImage(PhotobookProject project, Page page, string photobookDirectory)
        {
            if (page is null)
            {
                throw new ArgumentNullException(nameof(page));
            }

            var fileName = page.PageDescription.FirstSidePageNumber == -1 && page.PageDescription.SecondSidePageNumber == -1
            ? $"{leadingZeros}-cover"
            : page.PageDescription.FirstSidePageNumber == -1
            ? page.PageDescription.SecondSidePageNumber.ToString(leadingZeros)
            : page.PageDescription.SecondSidePageNumber == -1
            ? page.PageDescription.FirstSidePageNumber.ToString(leadingZeros)
            : $"{page.PageDescription.FirstSidePageNumber.ToString(leadingZeros)}-{page.PageDescription.SecondSidePageNumber.ToString(leadingZeros)}";

            using (Image<Rgba32> outputImage = new Image<Rgba32>(page.PageDescription.Width, page.PageDescription.Height))
            {
                foreach (var obj in page.PageBackground.PageObjects.OrderBy(o => o.Order))
                {
                    DrawPageObject(project, outputImage, obj, photobookDirectory);
                }
                foreach (var layer in page.PageLayers.OrderBy(l => l.Order))
                {
                    foreach (var obj in layer.PageObjects.OrderBy(o => o.Order))
                    {
                        DrawPageObject(project, outputImage, obj, photobookDirectory);
                    }
                }

                var outputDirectory = Path.Join(photobookDirectory, "Export");
                DirectoryInfo dirInfo = new DirectoryInfo(outputDirectory);
                if (!dirInfo.Exists) dirInfo.Create();

                var outputPath = Path.Join(outputDirectory, $"{fileName}.png");
                outputImage.Save(outputPath);
            }
        }

        private void DrawPageObject(PhotobookProject project, Image<Rgba32> outputImage, PageObject obj, string photobookDirectory)
        {
            switch (obj.DefaultContentType)
            {
                // Migrated Model?
                case ContentType.Image when obj.Foreground != null && obj.Foreground?.PageObjectImageContent != null:
                    DrawImage(project, outputImage, obj, photobookDirectory, obj.Foreground.PageObjectImageContent.Id.Split('|').First());
                    break;

                //2021 Model
                case ContentType.Image when obj.Foreground != null && obj.Foreground.ContentType == ContentType.Image && obj.Foreground?.PageObjectImageContent != null:
                    DrawImage(project, outputImage, obj, photobookDirectory, obj.Foreground.PageObjectImageContent.Id.Split('|').First());
                    break;

                // Legacy Model
                case ContentType.Image when obj.Foreground != null && obj.Foreground.ContentType == ContentType.PageObjectImageContent && obj.Foreground?.Id != null:
                    DrawImage(project, outputImage, obj, photobookDirectory, obj.Foreground.Id.Split('|').First());
                    break;
                //2021 Model

                case ContentType.Text when obj.Foreground != null && obj.Foreground?.PageObjectTextContent?.TextId != null:
                    DrawText(outputImage, obj, photobookDirectory, obj.Foreground.PageObjectTextContent.TextId);
                    break;

                //Legacy Model
                case ContentType.Text when obj.Foreground != null && obj.Foreground.ContentType == ContentType.PageObjectTextContent && obj.Foreground?.TextId != null:
                    DrawText(outputImage, obj, photobookDirectory, obj.Foreground.TextId);

                    break;
            }
        }


        private void DrawText(Image<Rgba32> outputImage, PageObject obj, string photobookDirectory, string fileName)
        {
            var filePath = Path.Join(photobookDirectory, "Texts", fileName);

            using (var textPngStream = new MemoryStream())
            {
                _xamlService.GetTextImage(_iFolorService.GetXaml(filePath), textPngStream, 300, Convert.ToInt32(obj.Rectangle.Width), Convert.ToInt32(obj.Rectangle.Height)); //TODO DPI
                textPngStream.Position = 0;
                using (Image<Rgba32> textPng = SixLabors.ImageSharp.Image.Load<Rgba32>(textPngStream))
                {
                    // Apply rotation from iFolor Designer #1
                    var rotateMode = RotateMode.None;
                    var orthoRotOp = obj.Processing?.ToApply?.OrthogonalRotationOperation;
                    if (orthoRotOp != null && orthoRotOp.Rotation != Rotation.Undefined)
                    {
                        rotateMode = ApplyOrthogonalRotationOperation(rotateMode, orthoRotOp.Rotation);
                    }
                    if (rotateMode != RotateMode.None)
                    {
                        textPng.Mutate(o => o.Rotate(rotateMode));
                    }

                    // Apple rotation from iFolor Designer #2
                    var rotOp = obj.Processing?.ToApply?.RotationOperation;
                    if (rotOp != null && rotOp.Degree != 0) // TODO Diff of abs
                    {
                        textPng.Mutate(o => o.Rotate(rotOp.Degree));
                    }

                    outputImage.Mutate(o => o.DrawImage(textPng, new SixLabors.ImageSharp.Point(Convert.ToInt32(obj.Rectangle.X), Convert.ToInt32(obj.Rectangle.Y)), 1f));
                }
            }

        }
        // private void DrawText(Image<Rgba32> outputImage, PageObject obj, string photobookDirectory, string fileName)
        // {
        //     FontFamily fontFamily = SixLabors.Fonts.SystemFonts.Find(obj.TextStyle.FontName);

        //     var font = new SixLabors.Fonts.Font(fontFamily, obj.TextStyle.FontSize, GetFontStyle(obj.TextStyle));

        //     // The options are optional
        //     TextGraphicsOptions options = new TextGraphicsOptions()
        //     {
        //         TextOptions = new TextOptions
        //         {
        //             ApplyKerning = true,
        //             TabWidth = 8, // a tab renders as 8 spaces wide
        //             WrapTextWidth = 100, //TODO // greater than zero so we will word wrap at 100 pixels wide
        //             HorizontalAlignment = GetHorizontalAlignment(obj.TextStyle.HorizontalAlign)
        //         }
        //     };

        //     var color = GetColor(obj.TextStyle.Color);

        //     string text = GetText(obj, photobookDirectory, fileName);

        //     outputImage.Mutate(x => x.DrawText(options, text, font, color, new PointF(Convert.ToInt32(obj.Rectangle.X), Convert.ToInt32(obj.Rectangle.Y))));
        // }

        private string GetText(PageObject obj, string photobookDirectory, string fileName)
        {
            var filePath = Path.Join(photobookDirectory, "Texts", fileName);

            var section = _iFolorService.GetTextSection(filePath);

            return section.Paragraph.Run.Text;
        }

        private SixLabors.ImageSharp.Color GetColor(Model.IFolor.Color color)
        {
            return new SixLabors.ImageSharp.Color(new Rgba32(color.ColorR, color.ColorG, color.ColorB, color.ColorA));
        }

        private FontStyle GetFontStyle(TextStyle textStyle)
        {
            if (textStyle.Bold && textStyle.Italic) return FontStyle.BoldItalic;
            if (textStyle.Bold) return FontStyle.Bold;
            if (textStyle.Italic) return FontStyle.Italic;

            return FontStyle.Regular;
        }
        private HorizontalAlignment GetHorizontalAlignment(Align horizontalAlign)
        {
            switch (horizontalAlign)
            {
                case Align.Left:
                    return HorizontalAlignment.Left;
                case Align.Center:
                    return HorizontalAlignment.Center;

                default:
                    return HorizontalAlignment.Right;
            }
        }

        private void DrawImage(PhotobookProject project, Image<Rgba32> outputImage, PageObject obj, string photobookDirectory, string fileName)
        {
            if (fileName != null)
            {
                var photoInfo = project.PhotoInformations.PhotoInformation.FirstOrDefault(p => p.FileName == fileName);
                if (photoInfo == null) throw new Exception($"Missing PhotoInfo for {fileName}");

                var filePath = Path.Join(photobookDirectory, "Photos", fileName);

                using (Image<Rgba32> img = SixLabors.ImageSharp.Image.Load<Rgba32>(filePath))
                {
                    var rotateMode = RotateMode.None;
                    if (photoInfo.PictureOrientation != PictureOrientation.Undefined)
                    {
                        // Image Rotation (probably from exif?)
                        rotateMode = GetRotateMode(photoInfo.PictureOrientation);
                    }

                    // Apply rotation from iFolor Designer #1
                    var orthoRotOp = obj.Foreground?.PageObjectImageContent?.Processing?.ToApply?.OrthogonalRotationOperation;
                    if (orthoRotOp != null && orthoRotOp.Rotation != Rotation.Undefined)
                    {
                        rotateMode = ApplyOrthogonalRotationOperation(rotateMode, orthoRotOp.Rotation);
                    }

                    if (rotateMode != RotateMode.None)
                    {
                        img.Mutate(o => o.Rotate(rotateMode));
                    }

                    // Apple rotation from iFolor Designer #2
                    var rotOp = obj.Processing?.ToApply?.RotationOperation;
                    if (rotOp != null && rotOp.Degree != 0) //TODO abs diff
                    {
                        img.Mutate(o => o.Rotate(rotOp.Degree));
                    }

                    // Apply Visible Rect Operation
                    var visRectOp = obj.Foreground?.PageObjectImageContent?.Processing?.ToApply?.VisibleRectOperation;
                    if (visRectOp != null)
                    {
                        // Apply leveling angle
                        if (visRectOp.LevelingAngle != 0)//TODO Check ABS of Diff gt 0.01
                        {
                            //Zoom, rotate, cut
                            //TODO
                        }

                        // Apply scale factor
                        if (visRectOp.ScaleFactor != 1.0)//TODO Check ABS of Diff gt 0.01
                        {

                        }

                    }

                    img.Mutate(o => o.Resize(new SixLabors.ImageSharp.Size(Convert.ToInt32(obj.Rectangle.Width), Convert.ToInt32(obj.Rectangle.Height))));
                    outputImage.Mutate(o => o.DrawImage(img, new SixLabors.ImageSharp.Point(Convert.ToInt32(obj.Rectangle.X), Convert.ToInt32(obj.Rectangle.Y)), 1f));
                }
            }
        }

        private RotateMode ApplyOrthogonalRotationOperation(RotateMode rotateMode, Rotation rotation)
        {
            var r = ((int)rotateMode + (int)rotation) % 360;

            return (RotateMode)r;
        }

        private static RotateMode GetRotateMode(PictureOrientation pictureOrientation)
        {
            switch (pictureOrientation)
            {
                case PictureOrientation.Rotated90:
                    return RotateMode.Rotate270;

                case PictureOrientation.Rotated180:
                    return RotateMode.Rotate180;

                case PictureOrientation.Rotated270:
                    return RotateMode.Rotate90;

                default:
                    return RotateMode.None;
            }
        }
    }
}