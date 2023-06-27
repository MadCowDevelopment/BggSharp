using System.Xml.Serialization;

namespace BggSharp.Queries.User;

[XmlRoot(ElementName = "guilds")]
public class GuildItems
{
    [XmlElement(ElementName = "guild")] public List<Guild> Guilds { get; set; }
    [XmlAttribute(AttributeName = "total")] public int Total { get; set; }
    [XmlAttribute(AttributeName = "page")] public int Page { get; set; }
}
