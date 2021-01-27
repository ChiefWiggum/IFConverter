using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "PageBinding")]
    public class PageBinding
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "firstPartSpiralsCount")]
        public int FirstPartSpiralsCount { get; set; }
        [XmlAttribute(AttributeName = "secondPartSpiralsCount")]
        public int SecondPartSpiralsCount { get; set; }
        [XmlAttribute(AttributeName = "bindingShadowWidth")]
        public int BindingShadowWidth { get; set; }
        [XmlAttribute(AttributeName = "holderWidth")]
        public int HolderWidth { get; set; }
        [XmlAttribute(AttributeName = "holderHeight")]
        public int HolderHeight { get; set; }
    }
}