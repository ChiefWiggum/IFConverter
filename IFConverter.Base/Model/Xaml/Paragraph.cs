using System.Xml.Serialization;

namespace IFConverter.Base.Model.Xaml
{
    [XmlRoot(ElementName = "Paragraph", Namespace = "http://schemas.microsoft.com/winfx/2006/xaml/presentation")]
    public class Paragraph
    {
        [XmlElement(ElementName = "Run", Namespace = "http://schemas.microsoft.com/winfx/2006/xaml/presentation")]
        public Run Run { get; set; }
        [XmlAttribute(AttributeName = "TextAlignment")]
        public string TextAlignment { get; set; }
        [XmlAttribute(AttributeName = "lang", Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string Lang { get; set; }
        [XmlAttribute(AttributeName = "NumberSubstitution.CultureSource")]
        public string NumberSubstitutionCultureSource { get; set; }
    }
}