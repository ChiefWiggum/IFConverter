using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "PageDescription")]
    public class PageDescription
    {
        [XmlElement(ElementName = "PageSpine")]
        public PageSpine PageSpine { get; set; }
        [XmlElement(ElementName = "PageCutting")]
        public PageCutting PageCutting { get; set; }
        [XmlElement(ElementName = "ProductionObjects")]
        public ProductionObjects ProductionObjects { get; set; }
        [XmlAttribute(AttributeName = "width")]
        public string Width { get; set; }
        [XmlAttribute(AttributeName = "height")]
        public string Height { get; set; }
        [XmlAttribute(AttributeName = "dpi")]
        public string Dpi { get; set; }
        [XmlAttribute(AttributeName = "pageNumberHorizontalOffset")]
        public string PageNumberHorizontalOffset { get; set; }
        [XmlAttribute(AttributeName = "pageNumberVerticalOffset")]
        public string PageNumberVerticalOffset { get; set; }
        [XmlAttribute(AttributeName = "arrangement")]
        public string Arrangement { get; set; }
        [XmlAttribute(AttributeName = "editingBackgroundIsAllowed")]
        public string EditingBackgroundIsAllowed { get; set; }
        [XmlAttribute(AttributeName = "firstSideIsPrintable")]
        public string FirstSideIsPrintable { get; set; }
        [XmlAttribute(AttributeName = "secondSideIsPrintable")]
        public string SecondSideIsPrintable { get; set; }
        [XmlAttribute(AttributeName = "firstSidePageNumber")]
        public string FirstSidePageNumber { get; set; }
        [XmlAttribute(AttributeName = "secondSidePageNumber")]
        public string SecondSidePageNumber { get; set; }
        [XmlAttribute(AttributeName = "hasPageNumbers")]
        public string HasPageNumbers { get; set; }
        [XmlElement(ElementName = "PageBinding")]
        public PageBinding PageBinding { get; set; }
    }
}