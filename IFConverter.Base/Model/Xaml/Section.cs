using System.Xml.Serialization;

namespace IFConverter.Base.Model.Xaml
{
    [XmlRoot(ElementName = "Section", Namespace = "http://schemas.microsoft.com/winfx/2006/xaml/presentation")]
    public class Section
    {
        [XmlElement(ElementName = "Paragraph", Namespace = "http://schemas.microsoft.com/winfx/2006/xaml/presentation")]
        public Paragraph Paragraph { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlAttribute(AttributeName = "space", Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string Space { get; set; }
        [XmlAttribute(AttributeName = "TextAlignment")]
        public string TextAlignment { get; set; }
        [XmlAttribute(AttributeName = "LineHeight")]
        public string LineHeight { get; set; }
        [XmlAttribute(AttributeName = "IsHyphenationEnabled")]
        public string IsHyphenationEnabled { get; set; }
        [XmlAttribute(AttributeName = "lang", Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string Lang { get; set; }
        [XmlAttribute(AttributeName = "FlowDirection")]
        public string FlowDirection { get; set; }
        [XmlAttribute(AttributeName = "NumberSubstitution.CultureSource")]
        public string NumberSubstitutionCultureSource { get; set; }
        [XmlAttribute(AttributeName = "NumberSubstitution.Substitution")]
        public string NumberSubstitutionSubstitution { get; set; }
        [XmlAttribute(AttributeName = "FontFamily")]
        public string FontFamily { get; set; }
        [XmlAttribute(AttributeName = "FontStyle")]
        public string FontStyle { get; set; }
        [XmlAttribute(AttributeName = "FontWeight")]
        public string FontWeight { get; set; }
        [XmlAttribute(AttributeName = "FontStretch")]
        public string FontStretch { get; set; }
        [XmlAttribute(AttributeName = "FontSize")]
        public string FontSize { get; set; }
        [XmlAttribute(AttributeName = "Foreground")]
        public string Foreground { get; set; }
        [XmlAttribute(AttributeName = "Typography.StandardLigatures")]
        public string TypographyStandardLigatures { get; set; }
        [XmlAttribute(AttributeName = "Typography.ContextualLigatures")]
        public string TypographyContextualLigatures { get; set; }
        [XmlAttribute(AttributeName = "Typography.DiscretionaryLigatures")]
        public string TypographyDiscretionaryLigatures { get; set; }
        [XmlAttribute(AttributeName = "Typography.HistoricalLigatures")]
        public string TypographyHistoricalLigatures { get; set; }
        [XmlAttribute(AttributeName = "Typography.AnnotationAlternates")]
        public string TypographyAnnotationAlternates { get; set; }
        [XmlAttribute(AttributeName = "Typography.ContextualAlternates")]
        public string TypographyContextualAlternates { get; set; }
        [XmlAttribute(AttributeName = "Typography.HistoricalForms")]
        public string TypographyHistoricalForms { get; set; }
        [XmlAttribute(AttributeName = "Typography.Kerning")]
        public string TypographyKerning { get; set; }
        [XmlAttribute(AttributeName = "Typography.CapitalSpacing")]
        public string TypographyCapitalSpacing { get; set; }
        [XmlAttribute(AttributeName = "Typography.CaseSensitiveForms")]
        public string TypographyCaseSensitiveForms { get; set; }
        [XmlAttribute(AttributeName = "Typography.StylisticSet1")]
        public string TypographyStylisticSet1 { get; set; }
        [XmlAttribute(AttributeName = "Typography.StylisticSet2")]
        public string TypographyStylisticSet2 { get; set; }
        [XmlAttribute(AttributeName = "Typography.StylisticSet3")]
        public string TypographyStylisticSet3 { get; set; }
        [XmlAttribute(AttributeName = "Typography.StylisticSet4")]
        public string TypographyStylisticSet4 { get; set; }
        [XmlAttribute(AttributeName = "Typography.StylisticSet5")]
        public string TypographyStylisticSet5 { get; set; }
        [XmlAttribute(AttributeName = "Typography.StylisticSet6")]
        public string TypographyStylisticSet6 { get; set; }
        [XmlAttribute(AttributeName = "Typography.StylisticSet7")]
        public string TypographyStylisticSet7 { get; set; }
        [XmlAttribute(AttributeName = "Typography.StylisticSet8")]
        public string TypographyStylisticSet8 { get; set; }
        [XmlAttribute(AttributeName = "Typography.StylisticSet9")]
        public string TypographyStylisticSet9 { get; set; }
        [XmlAttribute(AttributeName = "Typography.StylisticSet10")]
        public string TypographyStylisticSet10 { get; set; }
        [XmlAttribute(AttributeName = "Typography.StylisticSet11")]
        public string TypographyStylisticSet11 { get; set; }
        [XmlAttribute(AttributeName = "Typography.StylisticSet12")]
        public string TypographyStylisticSet12 { get; set; }
        [XmlAttribute(AttributeName = "Typography.StylisticSet13")]
        public string TypographyStylisticSet13 { get; set; }
        [XmlAttribute(AttributeName = "Typography.StylisticSet14")]
        public string TypographyStylisticSet14 { get; set; }
        [XmlAttribute(AttributeName = "Typography.StylisticSet15")]
        public string TypographyStylisticSet15 { get; set; }
        [XmlAttribute(AttributeName = "Typography.StylisticSet16")]
        public string TypographyStylisticSet16 { get; set; }
        [XmlAttribute(AttributeName = "Typography.StylisticSet17")]
        public string TypographyStylisticSet17 { get; set; }
        [XmlAttribute(AttributeName = "Typography.StylisticSet18")]
        public string TypographyStylisticSet18 { get; set; }
        [XmlAttribute(AttributeName = "Typography.StylisticSet19")]
        public string TypographyStylisticSet19 { get; set; }
        [XmlAttribute(AttributeName = "Typography.StylisticSet20")]
        public string TypographyStylisticSet20 { get; set; }
        [XmlAttribute(AttributeName = "Typography.Fraction")]
        public string TypographyFraction { get; set; }
        [XmlAttribute(AttributeName = "Typography.SlashedZero")]
        public string TypographySlashedZero { get; set; }
        [XmlAttribute(AttributeName = "Typography.MathematicalGreek")]
        public string TypographyMathematicalGreek { get; set; }
        [XmlAttribute(AttributeName = "Typography.EastAsianExpertForms")]
        public string TypographyEastAsianExpertForms { get; set; }
        [XmlAttribute(AttributeName = "Typography.Variants")]
        public string TypographyVariants { get; set; }
        [XmlAttribute(AttributeName = "Typography.Capitals")]
        public string TypographyCapitals { get; set; }
        [XmlAttribute(AttributeName = "Typography.NumeralStyle")]
        public string TypographyNumeralStyle { get; set; }
        [XmlAttribute(AttributeName = "Typography.NumeralAlignment")]
        public string TypographyNumeralAlignment { get; set; }
        [XmlAttribute(AttributeName = "Typography.EastAsianWidths")]
        public string TypographyEastAsianWidths { get; set; }
        [XmlAttribute(AttributeName = "Typography.EastAsianLanguage")]
        public string TypographyEastAsianLanguage { get; set; }
        [XmlAttribute(AttributeName = "Typography.StandardSwashes")]
        public string TypographyStandardSwashes { get; set; }
        [XmlAttribute(AttributeName = "Typography.ContextualSwashes")]
        public string TypographyContextualSwashes { get; set; }
        [XmlAttribute(AttributeName = "Typography.StylisticAlternates")]
        public string TypographyStylisticAlternates { get; set; }
    }
}