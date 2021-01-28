using System.Collections.Generic;
using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{
    [XmlRoot(ElementName = "Foreground")]
    public class Foreground
    {
        // 2021 Properties
        [XmlElement(ElementName = "PageObjectImageContent")]
        public PageObjectImageContent PageObjectImageContent { get; set; }
        [XmlElement(ElementName = "PageObjectTextContent")]
        public PageObjectTextContent PageObjectTextContent { get; set; }
        [XmlElement(ElementName = "PageObjectColorContent")]
        public PageObjectColorContent PageObjectColorContent { get; set; }

        // Legacy Properties
        [XmlElement(ElementName = "Id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "Processing")]
        public Processing Processing { get; set; }
        [XmlAttribute(AttributeName = "contentType")]
        public ContentType ContentType { get; set; }
        [XmlAttribute(AttributeName = "isColorized")]
        public bool IsColorized { get; set; }
        [XmlAttribute(AttributeName = "imageQuality")]
        public string ImageQuality { get; set; }
        [XmlAttribute(AttributeName = "imageType")]
        public ImageType ImageType { get; set; }
        [XmlAttribute(AttributeName = "imagePixelWidth")]
        public int ImagePixelWidth { get; set; }
        [XmlAttribute(AttributeName = "imagePixelHeight")]
        public int ImagePixelHeight { get; set; }
        [XmlAttribute(AttributeName = "isFormerRtfText")]
        public bool IsFormerRtfText { get; set; }
        [XmlElement(ElementName = "Margin")]
        public Margin Margin { get; set; }
        [XmlArray("UsedFonts")]
        public List<Font> UsedFonts { get; set; }
        [XmlAttribute(AttributeName = "textId")]
        public string TextId { get; set; }
        [XmlAttribute(AttributeName = "verticalTextAlign")]
        public Align VerticalTextAlign { get; set; }
    }
}