using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    //TODO Validate values
    public enum Rotation
    {
        Undefined = 0,
        Rotate90 = 90,
        Rotate180 = 180,
        Rotate270 = 270,
    }

    [XmlRoot(ElementName = "OrthogonalRotationOperation")]
    public class OrthogonalRotationOperation
    {
        [XmlAttribute(AttributeName = "rotation")]
        public Rotation Rotation { get; set; }
    }
}