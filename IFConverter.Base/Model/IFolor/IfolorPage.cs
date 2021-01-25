using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "IfolorPage")]
    public class IfolorPage
    {
        [XmlElement(ElementName = "PageDescription")]
        public PageDescription PageDescription { get; set; }
        [XmlElement(ElementName = "PageBackground")]
        public PageBackground PageBackground { get; set; }
        [XmlElement(ElementName = "PreviewId")]
        public string PreviewId { get; set; }
        [XmlElement(ElementName = "PageLayers")]
        public PageLayers PageLayers { get; set; }
    }
}