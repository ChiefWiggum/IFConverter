using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "PageBinding")]
    public class PageBinding
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "firstPartSpiralsCount")]
        public string FirstPartSpiralsCount { get; set; }
        [XmlAttribute(AttributeName = "secondPartSpiralsCount")]
        public string SecondPartSpiralsCount { get; set; }
        [XmlAttribute(AttributeName = "bindingShadowWidth")]
        public string BindingShadowWidth { get; set; }
        [XmlAttribute(AttributeName = "holderWidth")]
        public string HolderWidth { get; set; }
        [XmlAttribute(AttributeName = "holderHeight")]
        public string HolderHeight { get; set; }
    }
}