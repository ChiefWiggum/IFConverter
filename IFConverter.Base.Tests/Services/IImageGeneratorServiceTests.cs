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
            _imageService.GenerateImage(project.Cover, "../../../Data/Test1/");
            foreach (var page in project.Pages)
            {
                _imageService.GenerateImage(page, "../../../Data/Test1/");
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