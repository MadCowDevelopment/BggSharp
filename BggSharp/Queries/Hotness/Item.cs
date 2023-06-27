using System.Xml.Serialization;

namespace BggSharp.Queries.Hotness;

[XmlRoot(ElementName = "item")]
public class Item
{
    [XmlAttribute(AttributeName = "id")] public int Id { get; set; }
    [XmlAttribute(AttributeName = "rank")] public int Rank { get; set; }
    [XmlElement(ElementName = "thumbnail")] public Thumbnail Thumbnail { get; set; }
    [XmlElement(ElementName = "name")] public Name Name { get; set; }
    [XmlElement(ElementName = "yearpublished")] public YearPublished YearPublished { get; set; }
}
