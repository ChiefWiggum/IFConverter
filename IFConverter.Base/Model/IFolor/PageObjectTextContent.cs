using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "PageObjectTextContent")]
    public class PageObjectTextContent
    {
        [XmlAttribute(AttributeName = "isColorized")]
        public bool IsColorized { get; set; }
        [XmlAttribute(AttributeName = "textId")]
        public string TextId { get; set; }
        [XmlAttribute(AttributeName = "verticalTextAlign")]
        public string VerticalTextAlign { get; set; }
        [XmlElement(ElementName = "Margin")]
        public Margin Margin { get; set; }
        [XmlElement(ElementName = "UsedFonts")]
        public UsedFonts UsedFonts { get; set; }
    }
}