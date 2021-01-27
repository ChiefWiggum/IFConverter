using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "Color")]
    public class Color
    {
        [XmlAttribute(AttributeName = "colorA")]
        public int ColorA { get; set; }
        [XmlAttribute(AttributeName = "colorR")]
        public int ColorR { get; set; }
        [XmlAttribute(AttributeName = "colorG")]
        public int ColorG { get; set; }
        [XmlAttribute(AttributeName = "colorB")]
        public int ColorB { get; set; }
    }
}