using IFConverter.Base.Model.IFolor;
using System;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Drawing.Processing;
// using SixLabors.ImageSharp.Processing.Transforms;
using SixLabors.ImageSharp;
// using SixLabors.ImageSharp.Processing.Drawing;
using SixLabors.ImageSharp.PixelFormats;
using System.Linq;
using System.IO;
// using SixLabors.Primitives;

namespace IFConverter.Base.Services
{
    public class ImageGeneratorService : IImageGeneratorService
    {
        private const string leadingZeros = "000";
        public void GenerateImage(Page page, string photobookDirectory)
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
                    DrawPageObject(outputImage, obj, photobookDirectory);
                }
                foreach (var layer in page.PageLayers.OrderBy(l => l.Order))
                {
                    foreach (var obj in layer.PageObjects.OrderBy(o => o.Order))
                    {
                        DrawPageObject(outputImage, obj, photobookDirectory);
                    }
                }

                var outputDirectory = Path.Join(photobookDirectory, "Export");
                DirectoryInfo dirInfo = new DirectoryInfo(outputDirectory);
                if (!dirInfo.Exists) dirInfo.Create();

                var outputPath = Path.Join(outputDirectory, $"{fileName}.png");
                outputImage.Save(outputPath);
            }
        }

        private static void DrawPageObject(Image<Rgba32> outputImage, PageObject obj, string photobookDirectory)
        {
            switch (obj.DefaultContentType)
            {
                //2021 Model
                case ContentType.Image when obj.Foreground != null && obj.Foreground.ContentType == ContentType.Image && obj.Foreground?.PageObjectImageContent != null:
                    DrawImage(outputImage, obj, photobookDirectory, obj.Foreground.PageObjectImageContent.Id.Split('|').First());
                    break;

                // Legacy Model
                case ContentType.Image when obj.Foreground != null && obj.Foreground.ContentType == ContentType.PageObjectImageContent && obj.Foreground?.Id != null:
                    DrawImage(outputImage, obj, photobookDirectory, obj.Foreground.Id.Split('|').First());
                    break;

                case ContentType.Text:
                case ContentType.PageObjectTextContent:

                    break;
            }
        }

        private static void DrawImage(Image<Rgba32> outputImage, PageObject obj, string photobookDirectory, string fileName)
        {
            if (fileName != null)
            {
                var filePath = Path.Join(photobookDirectory, "Photos", fileName);

                using (Image<Rgba32> img = Image.Load<Rgba32>(filePath))
                {
                    img.Mutate(o => o.Resize(new Size(Convert.ToInt32(obj.Rectangle.Width), Convert.ToInt32(obj.Rectangle.Height))));
                    outputImage.Mutate(o => o.DrawImage(img, new Point(Convert.ToInt32(obj.Rectangle.X), Convert.ToInt32(obj.Rectangle.Y)), 1f));
                }
            }
        }
    }
}