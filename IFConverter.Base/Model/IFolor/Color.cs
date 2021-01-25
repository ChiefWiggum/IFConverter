using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "Color")]
    public class Color
    {
        [XmlAttribute(AttributeName = "colorA")]
        public string ColorA { get; set; }
        [XmlAttribute(AttributeName = "colorR")]
        public string ColorR { get; set; }
        [XmlAttribute(AttributeName = "colorG")]
        public string ColorG { get; set; }
        [XmlAttribute(AttributeName = "colorB")]
        public string ColorB { get; set; }
    }
}