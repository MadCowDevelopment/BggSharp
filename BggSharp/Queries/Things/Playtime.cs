using System.Xml.Serialization;

namespace BggSharp.Queries.Things;

[XmlRoot(ElementName = "playingtime")]
public class Playtime
{
    [XmlAttribute(AttributeName = "value")] public string Value { get; set; }
}