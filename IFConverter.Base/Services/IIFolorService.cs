using IFConverter.Base.Model.IFolor;
using IFConverter.Base.Model.Xaml;

namespace IFConverter.Base.Services
{
    public interface IIFolorService
    {
        PhotobookProject LoadPhotobook(string filePath);
        Section GetTextSection(string filePath);
    }
}