using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    public enum PictureOrientation
    {
        Undefined = 0,
        Rotated90 = 90,
        Rotated180 = 180,
        Rotated270 = 270,
    }

    [XmlRoot(ElementName = "PhotoInformation")]
    public class PhotoInformation
    {
        [XmlElement(ElementName = "FileName")]
        public string FileName { get; set; }
        [XmlElement(ElementName = "Md5Hash")]
        public string Md5Hash { get; set; }
        [XmlElement(ElementName = "OriginFilePath")]
        public string OriginFilePath { get; set; }
        [XmlAttribute(AttributeName = "isJpeg")]
        public bool IsJpeg { get; set; }
        [XmlAttribute(AttributeName = "pictureOrientation")]
        public PictureOrientation PictureOrientation { get; set; }
    }
}