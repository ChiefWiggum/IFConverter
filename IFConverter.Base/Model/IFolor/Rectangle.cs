using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "Rectangle")]
    public class Rectangle
    {
        [XmlAttribute(AttributeName = "x")]
        public double X { get; set; }
        [XmlAttribute(AttributeName = "y")]
        public double Y { get; set; }
        [XmlAttribute(AttributeName = "width")]
        public double Width { get; set; }
        [XmlAttribute(AttributeName = "height")]
        public double Height { get; set; }
    }
}