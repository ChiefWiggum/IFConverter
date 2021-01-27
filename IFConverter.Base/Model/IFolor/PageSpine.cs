using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "PageSpine")]
    public class PageSpine
    {
        [XmlAttribute(AttributeName = "vertical")]
        public string Vertical { get; set; }
        [XmlAttribute(AttributeName = "pos1")]
        public int Pos1 { get; set; }
        [XmlAttribute(AttributeName = "pos2")]
        public int Pos2 { get; set; }
    }
}