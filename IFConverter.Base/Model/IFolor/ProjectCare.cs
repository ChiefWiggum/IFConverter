using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "ProjectCare")]
    public class ProjectCare
    {
        [XmlAttribute(AttributeName = "plugInClipartsAdjusted")]
        public bool PlugInClipartsAdjusted { get; set; }
        [XmlAttribute(AttributeName = "cuttingToleranceAdjusted")]
        public bool CuttingToleranceAdjusted { get; set; }
        [XmlAttribute(AttributeName = "imageOrientationAdjusted")]
        public bool ImageOrientationAdjusted { get; set; }
    }
}