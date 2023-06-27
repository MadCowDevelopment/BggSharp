using System.Xml.Serialization;

namespace BggSharp.Queries.Forums;

[XmlRoot(ElementName = "forums")]
public class ForumListItems
{
    [XmlElement(ElementName = "forum")] public List<Forum> Forums { get; set; }
    [XmlAttribute(AttributeName = "termsofuse")] public string TermsOfUse { get; set; }
    [XmlAttribute(AttributeName = "type")] public string Type { get; set; }
    [XmlAttribute(AttributeName = "id")] public int Id { get; set; }
}