using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "Processing")]
    public class Processing
    {
        [XmlElement(ElementName = "ToApply")]
        public ToApply ToApply { get; set; }
    }
}