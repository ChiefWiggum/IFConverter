using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "PageObject")]
    public class PageObject
    {
        [XmlElement(ElementName = "Rectangle")]
        public Rectangle Rectangle { get; set; }
        [XmlElement(ElementName = "Foreground")]
        public Foreground Foreground { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "role")]
        public string Role { get; set; }
        [XmlAttribute(AttributeName = "anchor")]
        public string Anchor { get; set; }
        [XmlAttribute(AttributeName = "editingIsAllowed")]
        public string EditingIsAllowed { get; set; }
        [XmlAttribute(AttributeName = "editingContentIsAllowed")]
        public string EditingContentIsAllowed { get; set; }
        [XmlAttribute(AttributeName = "sizingIsAllowed")]
        public string SizingIsAllowed { get; set; }
        [XmlAttribute(AttributeName = "ratioIsFixed")]
        public string RatioIsFixed { get; set; }
        [XmlAttribute(AttributeName = "movingIsAllowed")]
        public string MovingIsAllowed { get; set; }
        [XmlAttribute(AttributeName = "rotationIsAllowed")]
        public string RotationIsAllowed { get; set; }
        [XmlAttribute(AttributeName = "changingZOrderIsAllowed")]
        public string ChangingZOrderIsAllowed { get; set; }
        [XmlAttribute(AttributeName = "deletingIsAllowed")]
        public string DeletingIsAllowed { get; set; }
        [XmlAttribute(AttributeName = "editingDecorationIsAllowed")]
        public string EditingDecorationIsAllowed { get; set; }
        [XmlAttribute(AttributeName = "order")]
        public string Order { get; set; }
        [XmlAttribute(AttributeName = "backgroundOpacity")]
        public string BackgroundOpacity { get; set; }
        [XmlAttribute(AttributeName = "foregroundOpacity")]
        public string ForegroundOpacity { get; set; }
        [XmlAttribute(AttributeName = "defaultContentType")]
        public string DefaultContentType { get; set; }
        [XmlAttribute(AttributeName = "shadow")]
        public string Shadow { get; set; }
        [XmlElement(ElementName = "TextStyle")]
        public TextStyle TextStyle { get; set; }
        [XmlElement(ElementName = "Processing")]
        public Processing Processing { get; set; }
    }
}