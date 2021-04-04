using IFConverter.Base.Model.IFolor;

namespace IFConverter.Base.Services
{
    public interface IImageGeneratorService
    {
        void RenderPage(PhotobookProject project, Page page, string photobookDirectory, string exportDirectory);
        void RenderAllPages(PhotobookProject project, string photobookDirectory, string exportDirectory);
    }
}