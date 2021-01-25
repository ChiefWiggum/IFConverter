using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "UsedFonts")]
    public class UsedFonts
    {
        [XmlElement(ElementName = "UsedFont")]
        public UsedFont UsedFont { get; set; }
    }
}