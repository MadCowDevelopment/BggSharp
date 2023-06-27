using System.Xml.Serialization;

namespace BggSharp.Queries.Thread;

[XmlRoot(ElementName = "thread")]
public class Thread
{
    [XmlElement(ElementName = "articles")] public ArticleItems Articles { get; set; }
    [XmlElement(ElementName = "subject")] public string Subject { get; set; }
    [XmlAttribute(AttributeName = "id")] public int Id { get; set; }
    [XmlAttribute(AttributeName = "numarticles")] public int NumberOfArticles { get; set; }
    [XmlAttribute(AttributeName = "link")] public string Link { get; set; }
    [XmlAttribute(AttributeName = "termsofuse")] public string TermsOfUse { get; set; }
}
