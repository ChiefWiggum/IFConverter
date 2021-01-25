using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "TextStyle")]
    public class TextStyle
    {
        [XmlElement(ElementName = "Color")]
        public Color Color { get; set; }
        [XmlAttribute(AttributeName = "fontName")]
        public string FontName { get; set; }
        [XmlAttribute(AttributeName = "fontSize")]
        public string FontSize { get; set; }
        [XmlAttribute(AttributeName = "bold")]
        public string Bold { get; set; }
        [XmlAttribute(AttributeName = "italic")]
        public string Italic { get; set; }
        [XmlAttribute(AttributeName = "underline")]
        public string Underline { get; set; }
        [XmlAttribute(AttributeName = "horizontalAlign")]
        public string HorizontalAlign { get; set; }
        [XmlAttribute(AttributeName = "verticalAlign")]
        public string VerticalAlign { get; set; }
    }
}