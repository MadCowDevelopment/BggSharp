using System.Xml.Serialization;

namespace BggSharp.Queries.Threads;

[XmlRoot(ElementName = "article")]
public class Article
{
    [XmlElement(ElementName = "subject")]
    public string Subject { get; set; }
    [XmlElement(ElementName = "body")]
    public string Body { get; set; }
    [XmlAttribute(AttributeName = "id")]
    public int Id { get; set; }
    [XmlAttribute(AttributeName = "username")]
    public string Username { get; set; }
    [XmlAttribute(AttributeName = "link")]
    public string Link { get; set; }
    [XmlAttribute(AttributeName = "postdate")]
    public string PostDate { get; set; }
    [XmlAttribute(AttributeName = "editdate")]
    public string EditDate { get; set; }
    [XmlAttribute(AttributeName = "numedits")]
    public int NumberOfEdits { get; set; }
}
