using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "Margin")]
    public class Margin
    {
        [XmlAttribute(AttributeName = "left")]
        public int Left { get; set; }
        [XmlAttribute(AttributeName = "top")]
        public int Top { get; set; }
        [XmlAttribute(AttributeName = "right")]
        public int Right { get; set; }
        [XmlAttribute(AttributeName = "bottom")]
        public int Bottom { get; set; }
    }
}