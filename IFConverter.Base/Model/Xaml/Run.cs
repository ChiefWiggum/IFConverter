using System.Xml.Serialization;

namespace IFConverter.Base.Model.Xaml
{
    [XmlRoot(ElementName = "Run", Namespace = "http://schemas.microsoft.com/winfx/2006/xaml/presentation")]
    public class Run
    {
        [XmlAttribute(AttributeName = "lang", Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string Lang { get; set; }
        [XmlAttribute(AttributeName = "FontFamily")]
        public string FontFamily { get; set; }
        [XmlAttribute(AttributeName = "FontSize")]
        public string FontSize { get; set; }
        [XmlAttribute(AttributeName = "TextDecorations")]
        public string TextDecorations { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}