using System.Windows.Media;
using System.Windows.Controls;
using System.IO;
using System.Windows.Markup;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Documents;

namespace IFConverter.Base.Services
{
    public class XamlService : IXamlService
    {

        // Inspired by https://stackoverflow.com/questions/11630071/convert-an-xaml-file-to-a-bitmapimage
        public void GetTextImage(Stream xamlInput, Stream pngOutput, int dpi, int width, int height)
        {
            //Stream xamlFileStream = File.OpenRead(filePath);
            //Control control = (Control)XamlReader.Load(xamlInput);
            Section section = (Section)XamlReader.Load(xamlInput);

            GenerateImage(section, pngOutput, dpi, width, height);
        }

        private void GenerateImage(Section section, Stream result, int dpi, int width, int height)
        {
            var flowDoc = new FlowDocument(section);
            var paginator = ((IDocumentPaginatorSource)flowDoc).DocumentPaginator;
            paginator.PageSize = new Size(width, height);

            var visual = new DrawingVisual();
            // using (var drawingContext = visual.RenderOpen())
            // {
            //     // draw white background
            //     //drawingContext.DrawRectangle(Brushes.White, null, new Rect(size));
            // }
            visual.Children.Add(paginator.GetPage(0).Visual);

            RenderTargetBitmap rtb = new RenderTargetBitmap(width, height, dpi, dpi, PixelFormats.Pbgra32);

            rtb.Render(visual);
            var encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(rtb));
            encoder.Save(result);
        }

        // private void GenerateImage(Control control, Stream result, int dpi)
        // {
        //     Size controlSize = RetrieveDesiredSize(control);
        //     Rect rect = new Rect(0, 0, controlSize.Width, controlSize.Height);

        //     RenderTargetBitmap rtb = new RenderTargetBitmap((int)controlSize.Width, (int)controlSize.Height, dpi, dpi, PixelFormats.Pbgra32);

        //     control.Arrange(rect);
        //     rtb.Render(control);

        //     PngBitmapEncoder png = new PngBitmapEncoder();
        //     png.Frames.Add(BitmapFrame.Create(rtb));
        //     png.Save(result);
        // }

        private static Size RetrieveDesiredSize(Control control)
        {
            control.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
            return control.DesiredSize;
        }
    }
}