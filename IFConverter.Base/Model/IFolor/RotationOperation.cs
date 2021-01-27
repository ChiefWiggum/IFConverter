using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "RotationOperation")]
    public class RotationOperation
    {
        [XmlAttribute(AttributeName = "degree")]
        public int Degree { get; set; }
    }
}