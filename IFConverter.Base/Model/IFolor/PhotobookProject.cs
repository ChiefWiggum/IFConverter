using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "PhotobookProject")]
    public class PhotobookProject
    {
        [XmlElement(ElementName = "ProductId")]
        public string ProductId { get; set; }
        [XmlElement(ElementName = "ProjectId")]
        public string ProjectId { get; set; }
        [XmlElement(ElementName = "ProjectCare")]
        public ProjectCare ProjectCare { get; set; }
        [XmlElement(ElementName = "PhotoInformations")]
        public PhotoInformations PhotoInformations { get; set; }
        [XmlElement(ElementName = "Cover")]
        public Cover Cover { get; set; }
        [XmlElement(ElementName = "Pages")]
        public Pages Pages { get; set; }
        [XmlAttribute(AttributeName = "designCenterVersion")]
        public string DesignCenterVersion { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
        [XmlAttribute(AttributeName = "created")]
        public string Created { get; set; }
    }
}