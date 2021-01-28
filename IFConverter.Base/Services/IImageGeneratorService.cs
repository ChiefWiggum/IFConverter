using IFConverter.Base.Model.IFolor;

namespace IFConverter.Base.Services
{
    public interface IImageGeneratorService
    {
        void GenerateImage(Page page, string photobookDirectory);
    }
}