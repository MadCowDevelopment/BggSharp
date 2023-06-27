using System.Xml.Serialization;

namespace BggSharp.Queries.Families;

[XmlRoot(ElementName = "item")]
public class Item
{
    [XmlElement(ElementName = "thumbnail")] public string Thumbnail { get; set; }
    [XmlElement(ElementName = "image")] public string Image { get; set; }
    [XmlElement(ElementName = "name")] public List<Name> Names { get; set; }
    [XmlElement(ElementName = "description")] public string Description { get; set; }
    [XmlElement(ElementName = "link")] public List<Link> Links { get; set; }
    [XmlAttribute(AttributeName = "type")] public string Type { get; set; }
    [XmlAttribute(AttributeName = "id")] public int Id { get; set; }
}