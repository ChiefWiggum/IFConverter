using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "PageObjectColorContent")]
    public class PageObjectColorContent
    {
        [XmlElement(ElementName = "Color")]
        public Color Color { get; set; }
        [XmlAttribute(AttributeName = "isColorized")]
        public bool IsColorized { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }
}