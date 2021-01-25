using System.Xml.Serialization;
using System.Collections.Generic;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "PageLayers")]
    public class PageLayers
    {
        [XmlElement(ElementName = "PageLayer")]
        public List<PageLayer> PageLayer { get; set; }
    }
}