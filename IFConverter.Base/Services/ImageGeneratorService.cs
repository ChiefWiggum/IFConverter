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
        public void GenerateImage(Page page, string photobookDirectory)
        {
            if (page is null)
            {
                throw new ArgumentNullException(nameof(page));
            }

            var fileName = page.PageDescription.FirstSidePageNumber == -1 ? "cover" : $"{page.PageDescription.FirstSidePageNumber}-{page.PageDescription.SecondSidePageNumber}";

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
                if(!dirInfo.Exists)dirInfo.Create();
                
                var outputPath = Path.Join(outputDirectory,$"{fileName}.png");
                outputImage.Save(outputPath);
            }
        }

        private static void DrawPageObject(Image<Rgba32> outputImage, PageObject obj, string photobookDirectory)
        {
            switch (obj.DefaultContentType)
            {
                case ContentType.Image:
                    if (obj.Foreground == null || obj.Foreground.PageObjectImageContent == null) return;
                    var objFileName = obj.Foreground.PageObjectImageContent.Id.Split('|').First();
                    var objFilePath = Path.Join(photobookDirectory, "Photos", objFileName);

                    using (Image<Rgba32> img = Image.Load<Rgba32>(objFilePath))
                    {
                        img.Mutate(o => o.Resize(new Size(Convert.ToInt32(obj.Rectangle.Width), Convert.ToInt32(obj.Rectangle.Height))));
                        outputImage.Mutate(o => o.DrawImage(img, new Point(Convert.ToInt32(obj.Rectangle.X), Convert.ToInt32(obj.Rectangle.Y)), 1f));
                    }

                    break;

                case ContentType.Text:

                    break;
            }
        }
    }
}