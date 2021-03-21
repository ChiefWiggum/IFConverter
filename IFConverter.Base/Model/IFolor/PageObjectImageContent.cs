using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    public enum ImageType
    {
        Undefined,
        User,
        PluginClipart
    }

    [XmlRoot(ElementName = "PageObjectImageContent")]
    public class PageObjectImageContent
    {
        [XmlElement(ElementName = "Id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "isColorized")]
        public bool IsColorized { get; set; }
        [XmlAttribute(AttributeName = "imageQuality")]
        public string ImageQuality { get; set; }
        [XmlAttribute(AttributeName = "imageType")]
        public ImageType ImageType { get; set; }
        [XmlAttribute(AttributeName = "imagePixelWidth")]
        public int ImagePixelWidth { get; set; }
        [XmlAttribute(AttributeName = "imagePixelHeight")]
        public int ImagePixelHeight { get; set; }
        [XmlAttribute(AttributeName = "isFormerRtfText")]
        public bool IsFormerRtfText { get; set; }
        [XmlAttribute(AttributeName = "enhancement")]
        public string Enhancement { get; set; }

        [XmlElement(ElementName = "Processing")]
        public Processing Processing { get; set; }
    }
}