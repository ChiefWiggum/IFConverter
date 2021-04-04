using Xunit;
using IFConverter.Base.Services;
using System.Linq;

namespace IFConverter.Base.Tests.Services
{
    public class IImageGeneratorServiceTests
    {
        private IIFolorService _ifolorService;
        private IImageGeneratorService _imageService;


        [Fact]
        public void TestLoadPhotobook()
        {
            //Given
            var file = "../../../Data/Test1/Project.ipp";
            var project = _ifolorService.LoadPhotobook(file);

            //When
            _imageService.RenderPage(project, project.Cover, "../../../Data/Test1/", "Export");
            foreach (var page in project.Pages)
            {
                _imageService.RenderPage(project, page, "../../../Data/Test1/", "Export");
            }
            

            //Then
        }
        
        // Private photo book with more complex layout. Use your own :-)
        [Fact]
        public void TestLoadPhotobook_CooksIslands()
        {
            //Given
            var file = @"D:\Documents\ifolor\Photobooks\Cook Islands 2014\Project.ipp";
            var project = _ifolorService.LoadPhotobook(file);

            //When
            //_imageService.GenerateImage(project, project.Pages[2], @"D:\Documents\ifolor\Photobooks\Cook Islands 2014\");
            _imageService.RenderPage(project, project.Cover, @"D:\Documents\ifolor\Photobooks\Cook Islands 2014\", "Export");
            foreach (var page in project.Pages)
            {
                _imageService.RenderPage(project, page, @"D:\Documents\ifolor\Photobooks\Cook Islands 2014\", "Export");
            }
            

            //Then
        }

        public IImageGeneratorServiceTests()
        {
            _ifolorService = new IFolorService();
            _imageService = new ImageGeneratorService();
        }
    }
}