using System.Xml.Serialization;

namespace BggSharp.Queries.Forum;

[XmlRoot(ElementName = "thread")]
public class Thread
{
    [XmlAttribute(AttributeName = "id")] public int Id { get; set; }
    [XmlAttribute(AttributeName = "subject")] public string Subject { get; set; }
    [XmlAttribute(AttributeName = "author")] public string Author { get; set; }
    [XmlAttribute(AttributeName = "numarticles")] public int NumberOfArticles { get; set; }
    [XmlAttribute(AttributeName = "postdate")] public string PostDate { get; set; }
    [XmlAttribute(AttributeName = "lastpostdate")] public string LastPostDate { get; set; }
}