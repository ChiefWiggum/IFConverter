using System.Collections.Generic;
using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "Cover")]

    public class Page
    {
        [XmlElement(ElementName = "PageDescription")]
        public PageDescription PageDescription { get; set; }
        [XmlElement(ElementName = "PageBackground")]
        public PageBackground PageBackground { get; set; }
        [XmlElement(ElementName = "PreviewId")]
        public string PreviewId { get; set; }
        [XmlArray("PageLayers")]
        public List<PageLayer> PageLayers { get; set; }
    }
}