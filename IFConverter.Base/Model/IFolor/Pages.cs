using System.Xml.Serialization;
using System.Collections.Generic;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "Pages")]
    public class Pages
    {
        [XmlElement(ElementName = "IfolorPage")]
        public List<IfolorPage> IfolorPage { get; set; }
    }
}