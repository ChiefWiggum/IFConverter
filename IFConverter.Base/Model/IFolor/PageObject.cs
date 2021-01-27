using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    public enum ContentType
    {
        Undefined,
        Image,
        Text
    }

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
        public bool EditingIsAllowed { get; set; }
        [XmlAttribute(AttributeName = "editingContentIsAllowed")]
        public bool EditingContentIsAllowed { get; set; }
        [XmlAttribute(AttributeName = "sizingIsAllowed")]
        public bool SizingIsAllowed { get; set; }
        [XmlAttribute(AttributeName = "ratioIsFixed")]
        public bool RatioIsFixed { get; set; }
        [XmlAttribute(AttributeName = "movingIsAllowed")]
        public bool MovingIsAllowed { get; set; }
        [XmlAttribute(AttributeName = "rotationIsAllowed")]
        public bool RotationIsAllowed { get; set; }
        [XmlAttribute(AttributeName = "changingZOrderIsAllowed")]
        public bool ChangingZOrderIsAllowed { get; set; }
        [XmlAttribute(AttributeName = "deletingIsAllowed")]
        public bool DeletingIsAllowed { get; set; }
        [XmlAttribute(AttributeName = "editingDecorationIsAllowed")]
        public bool EditingDecorationIsAllowed { get; set; }
        [XmlAttribute(AttributeName = "order")]
        public int Order { get; set; }
        [XmlAttribute(AttributeName = "backgroundOpacity")]
        public string BackgroundOpacity { get; set; }
        [XmlAttribute(AttributeName = "foregroundOpacity")]
        public string ForegroundOpacity { get; set; }
        [XmlAttribute(AttributeName = "defaultContentType")]
        public ContentType DefaultContentType { get; set; }
        [XmlAttribute(AttributeName = "shadow")]
        public string Shadow { get; set; }
        [XmlElement(ElementName = "TextStyle")]
        public TextStyle TextStyle { get; set; }
        [XmlElement(ElementName = "Processing")]
        public Processing Processing { get; set; }
    }
}