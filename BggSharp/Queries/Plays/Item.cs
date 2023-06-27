using System.Xml.Serialization;

namespace BggSharp.Queries.Plays;

[XmlRoot(ElementName = "item")]
public class Item
{
    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }
    [XmlAttribute(AttributeName = "objecttype")] public string ObjectType { get; set; }
    [XmlAttribute(AttributeName = "objectid")] public int ObjectId { get; set; }
    [XmlElement(ElementName = "subtypes")] public SubTypesItems SubTypes { get; set; }
}
