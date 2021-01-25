using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "PageBackground")]
    public class PageBackground
    {
        [XmlAttribute(AttributeName = "order")]
        public string Order { get; set; }
        [XmlAttribute(AttributeName = "acceptsNewPageObjects")]
        public string AcceptsNewPageObjects { get; set; }
        [XmlElement(ElementName = "PageObjects")]
        public PageObjects PageObjects { get; set; }
    }
}