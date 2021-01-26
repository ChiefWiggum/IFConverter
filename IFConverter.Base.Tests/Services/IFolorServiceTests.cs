using Xunit;
using IFConverter.Base.Services;

namespace IFConverter.Base.Tests.Services
{
    public class IFolorServiceTests
    {
        private IIFolorService _service;


        [Fact]
        public void TestLoadPhotobook()
        {
            //Given
            var file = "../../../Data/Test1/Project.ipp";

            //When
            var project = _service.LoadPhotobook(file);

            //Then
            Assert.NotNull(project);

        }

        public IFolorServiceTests()
        {
            _service = new IFolorService();
        }
    }
}