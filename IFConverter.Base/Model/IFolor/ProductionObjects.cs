using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "ProductionObjects")]
    public class ProductionObjects
    {
        [XmlElement(ElementName = "PageProductionObject")]
        public PageProductionObject PageProductionObject { get; set; }
    }
}