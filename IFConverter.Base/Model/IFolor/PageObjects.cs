using System.Xml.Serialization;
using System.Collections.Generic;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "PageObjects")]
    public class PageObjects
    {
        [XmlElement(ElementName = "PageObject")]
        public List<PageObject> PageObject { get; set; }
    }
}