using System.Collections.Generic;
using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "PageBackground")]
    public class PageBackground
    {
        [XmlAttribute(AttributeName = "order")]
        public int Order { get; set; }
        [XmlAttribute(AttributeName = "acceptsNewPageObjects")]
        public bool AcceptsNewPageObjects { get; set; }
        [XmlElement(ElementName = "PageObjects")]
        public List<PageObject> PageObjects { get; set; }
    }
}