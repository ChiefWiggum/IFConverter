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
        public int Width { get; set; }
        [XmlAttribute(AttributeName = "height")]
        public int Height { get; set; }
        [XmlAttribute(AttributeName = "dpi")]
        public int Dpi { get; set; }
        [XmlAttribute(AttributeName = "pageNumberHorizontalOffset")]
        public int PageNumberHorizontalOffset { get; set; }
        [XmlAttribute(AttributeName = "pageNumberVerticalOffset")]
        public int PageNumberVerticalOffset { get; set; }
        [XmlAttribute(AttributeName = "arrangement")]
        public string Arrangement { get; set; }
        [XmlAttribute(AttributeName = "editingBackgroundIsAllowed")]
        public bool EditingBackgroundIsAllowed { get; set; }
        [XmlAttribute(AttributeName = "firstSideIsPrintable")]
        public bool FirstSideIsPrintable { get; set; }
        [XmlAttribute(AttributeName = "secondSideIsPrintable")]
        public int SecondSideIsPrintable { get; set; }
        [XmlAttribute(AttributeName = "firstSidePageNumber")]
        public int FirstSidePageNumber { get; set; }
        [XmlAttribute(AttributeName = "secondSidePageNumber")]
        public int SecondSidePageNumber { get; set; }
        [XmlAttribute(AttributeName = "hasPageNumbers")]
        public bool HasPageNumbers { get; set; }
        [XmlElement(ElementName = "PageBinding")]
        public PageBinding PageBinding { get; set; }
    }
}