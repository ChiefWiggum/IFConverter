using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "ProjectCare")]
    public class ProjectCare
    {
        [XmlAttribute(AttributeName = "plugInClipartsAdjusted")]
        public string PlugInClipartsAdjusted { get; set; }
        [XmlAttribute(AttributeName = "cuttingToleranceAdjusted")]
        public string CuttingToleranceAdjusted { get; set; }
        [XmlAttribute(AttributeName = "imageOrientationAdjusted")]
        public string ImageOrientationAdjusted { get; set; }
    }
}