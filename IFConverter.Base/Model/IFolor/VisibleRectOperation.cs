using System.Xml.Serialization;

namespace IFConverter.Base.Model.IFolor
{

    [XmlRoot(ElementName = "VisibleRectOperation")]
    public class VisibleRectOperation
    {
        [XmlAttribute(AttributeName = "x")]
        public double X { get; set; }
        [XmlAttribute(AttributeName = "y")]
        public double Y { get; set; }
        [XmlAttribute(AttributeName = "scaleFactor")]
        public double ScaleFactor { get; set; }
        [XmlAttribute(AttributeName = "levelingAngle")]
        public double LevelingAngle { get; set; }
    }

}