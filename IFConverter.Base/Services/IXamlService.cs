using System.IO;

namespace IFConverter.Base.Services
{
    public interface IXamlService
    {
        void GetTextImage(Stream xamlInput, Stream pngOutput, int dpi, int width, int height);
    }

}