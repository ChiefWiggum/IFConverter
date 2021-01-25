using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "PageLayer")]
    public class PageLayer
    {
        [XmlElement(ElementName = "PageObjects")]
        public PageObjects PageObjects { get; set; }
        [XmlAttribute(AttributeName = "order")]
        public string Order { get; set; }
        [XmlAttribute(AttributeName = "acceptsNewPageObjects")]
        public string AcceptsNewPageObjects { get; set; }
    }
}