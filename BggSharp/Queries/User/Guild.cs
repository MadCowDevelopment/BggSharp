using System.Xml.Serialization;

namespace BggSharp.Queries.User;

[XmlRoot(ElementName = "guild")]
public class Guild
{
    [XmlAttribute(AttributeName = "id")] public int Id { get; set; }
    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }
}
