using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "PageProductionObject")]
    public class ProductionObject
    {
        [XmlElement(ElementName = "Rectangle")]
        public Rectangle Rectangle { get; set; }
        [XmlElement(ElementName = "ImageId")]
        public string ImageId { get; set; }
    }
}