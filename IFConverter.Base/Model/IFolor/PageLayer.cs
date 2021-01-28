using System.Collections.Generic;
using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "PageLayer")]
    public class PageLayer
    {
        [XmlArray("PageObjects")]
        public List<PageObject> PageObjects { get; set; }
        [XmlAttribute(AttributeName = "order")]
        public int Order { get; set; }
        [XmlAttribute(AttributeName = "acceptsNewPageObjects")]
        public bool AcceptsNewPageObjects { get; set; }
    }
}