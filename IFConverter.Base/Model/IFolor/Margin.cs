using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "Margin")]
    public class Margin
    {
        [XmlAttribute(AttributeName = "left")]
        public string Left { get; set; }
        [XmlAttribute(AttributeName = "top")]
        public string Top { get; set; }
        [XmlAttribute(AttributeName = "right")]
        public string Right { get; set; }
        [XmlAttribute(AttributeName = "bottom")]
        public string Bottom { get; set; }
    }
}