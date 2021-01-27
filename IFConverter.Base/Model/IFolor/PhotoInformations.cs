using System.Xml.Serialization;
using System.Collections.Generic;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "PhotoInformations")]
    public class PhotoInformations
    {
        [XmlElement(ElementName = "PhotoInformation")]
        public List<PhotoInformation> PhotoInformation { get; set; }
        [XmlAttribute(AttributeName = "imageOrientationsAreEffective")]
        public bool ImageOrientationsAreEffective { get; set; }
        [XmlAttribute(AttributeName = "imageIsJpegUpdated")]
        public bool ImageIsJpegUpdated { get; set; }
    }
}