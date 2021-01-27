using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    public enum Align
    {
        Undefined,
        Left,
        Center,
        Right,
        Top,
        Bottom
    }

    [XmlRoot(ElementName = "TextStyle")]
    public class TextStyle
    {
        [XmlElement(ElementName = "Color")]
        public Color Color { get; set; }
        [XmlAttribute(AttributeName = "fontName")]
        public string FontName { get; set; }
        [XmlAttribute(AttributeName = "fontSize")]
        public int FontSize { get; set; }
        [XmlAttribute(AttributeName = "bold")]
        public bool Bold { get; set; }
        [XmlAttribute(AttributeName = "italic")]
        public bool Italic { get; set; }
        [XmlAttribute(AttributeName = "underline")]
        public bool Underline { get; set; }
        [XmlAttribute(AttributeName = "horizontalAlign")]
        public Align HorizontalAlign { get; set; }
        [XmlAttribute(AttributeName = "verticalAlign")]
        public Align VerticalAlign { get; set; }
    }
}