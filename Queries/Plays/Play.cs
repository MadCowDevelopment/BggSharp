using System.Xml.Serialization;

namespace BggSharp.Queries.Plays;

[XmlRoot(ElementName = "play")]
public class Play
{
    [XmlAttribute(AttributeName = "id")] public int Id { get; set; }
    [XmlAttribute(AttributeName = "date")] public string Date { get; set; }
    [XmlAttribute(AttributeName = "quantity")] public int Quantity { get; set; }
    [XmlAttribute(AttributeName = "length")] public int Length { get; set; }
    [XmlAttribute(AttributeName = "incomplete")] public bool IsIncomplete { get; set; }
    [XmlAttribute(AttributeName = "nowinstats")] public bool IsNowInStats { get; set; }
    [XmlAttribute(AttributeName = "location")] public string Location { get; set; }
    [XmlElement(ElementName = "item")] public Item Item { get; set; }
}
