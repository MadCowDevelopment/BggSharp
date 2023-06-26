using System.Xml.Serialization;

namespace BggSharp.Queries.Forum;

[XmlRoot(ElementName = "item")]
public class Item
{
    [XmlAttribute(AttributeName = "objecttype")]
    public string ObjectType { get; set; }
    [XmlAttribute(AttributeName = "objectid")]
    public int ObjectId { get; set; }
    [XmlAttribute(AttributeName = "subtype")]
    public SubType SubType { get; set; }
    [XmlAttribute(AttributeName = "collid")]
    public int CollId { get; set; }
    [XmlElement(ElementName = "yearpublished")]
    public int YearPublished { get; set; }
    [XmlElement(ElementName = "image")]
    public string Image { get; set; }
    [XmlElement(ElementName = "thumbnail")]
    public string Thumbnail { get; set; }
    [XmlElement(ElementName = "status")]
    public Status Status { get; set; }
    [XmlElement(ElementName = "numplays")]
    public int NumPlays { get; set; }
    [XmlElement(ElementName = "name")]
    public string Name { get; set; }
}
