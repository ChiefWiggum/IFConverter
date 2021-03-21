using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "ToApply")]
    public class ToApply
    {
        [XmlElement(ElementName = "RotationOperation")]
        public RotationOperation RotationOperation { get; set; }
        [XmlElement(ElementName = "OrthogonalRotationOperation")]
        public OrthogonalRotationOperation OrthogonalRotationOperation { get; set; }

        
    
        [XmlElement(ElementName = "VisibleRectOperation")]
        public VisibleRectOperation VisibleRectOperation { get; set; }
    }
}