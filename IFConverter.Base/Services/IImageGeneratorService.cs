using IFConverter.Base.Model.IFolor;

namespace IFConverter.Base.Services
{
    public interface IImageGeneratorService
    {
        void GenerateImage(PhotobookProject project, Page page, string photobookDirectory);
    }
}