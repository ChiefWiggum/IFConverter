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
        public string ImageOrientationsAreEffective { get; set; }
        [XmlAttribute(AttributeName = "imageIsJpegUpdated")]
        public string ImageIsJpegUpdated { get; set; }
    }
}