using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "Foreground")]
    public class Foreground
    {
        [XmlElement(ElementName = "PageObjectImageContent")]
        public PageObjectImageContent PageObjectImageContent { get; set; }
        [XmlElement(ElementName = "PageObjectTextContent")]
        public PageObjectTextContent PageObjectTextContent { get; set; }
        [XmlElement(ElementName = "PageObjectColorContent")]
        public PageObjectColorContent PageObjectColorContent { get; set; }
    }
}