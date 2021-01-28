using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "UsedFont")]
    public class Font
    {
        [XmlAttribute(AttributeName = "familyName")]
        public string FamilyName { get; set; }
        [XmlAttribute(AttributeName = "style")]
        public string Style { get; set; }
    }
}