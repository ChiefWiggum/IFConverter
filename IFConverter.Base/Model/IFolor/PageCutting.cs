using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "PageCutting")]
    public class PageCutting
    {
        [XmlElement(ElementName = "Rectangle")]
        public Rectangle Rectangle { get; set; }
        [XmlAttribute(AttributeName = "isFolded")]
        public string IsFolded { get; set; }
    }
}