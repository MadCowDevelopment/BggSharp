using System.Xml.Serialization;

namespace BggSharp.Queries.Plays;

[XmlRoot(ElementName = "plays")]
public class PlayItems
{
    [XmlAttribute(AttributeName = "username")] public string Username { get; set; }
    [XmlAttribute(AttributeName = "userid")] public int UserId { get; set; }
    [XmlAttribute(AttributeName = "total")] public int Total { get; set; }
    [XmlAttribute(AttributeName = "page")] public int Page { get; set; }
    [XmlAttribute(AttributeName = "termsofuse")] public string TermsOfUse { get; set; }
    [XmlElement(ElementName = "play")] public List<Play> Plays { get; set; }
}
