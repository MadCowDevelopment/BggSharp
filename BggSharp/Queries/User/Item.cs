using System.Xml.Serialization;

namespace BggSharp.Queries.User;

[XmlRoot(ElementName = "item")]
public class Item
{
    [XmlAttribute(AttributeName = "id")] public int Id { get; set; }
    [XmlAttribute(AttributeName = "rank")] public int Rank { get; set; }
    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }
    [XmlAttribute(AttributeName = "type")] public string Type { get; set; }
}
