using System.Xml.Serialization;

namespace BggSharp.Queries.Things;

[XmlRoot(ElementName = "maxplayers")]
public class MaxPlayers
{
    [XmlAttribute(AttributeName = "value")] public string Value { get; set; }
}