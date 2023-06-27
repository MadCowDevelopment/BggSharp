using System.Xml.Serialization;

namespace BggSharp.Queries.Search;

[XmlRoot(ElementName = "item")]
public class Item
{
    [XmlAttribute(AttributeName = "type")] public string Type { get; set; }
    [XmlAttribute(AttributeName = "id")] public int Id { get; set; }
    [XmlElement(ElementName = "name")] public Name Name { get; set; }
    [XmlElement(ElementName = "yearpublished")] public YearPublished YearPublished { get; set; }
}