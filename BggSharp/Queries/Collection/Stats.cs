using System.Xml.Serialization;

namespace BggSharp.Queries.Collection;

[XmlRoot(ElementName = "stats")]
public class Stats
{
    [XmlAttribute(AttributeName = "minplayers")] public int MinimumPlayers { get; set; }
    [XmlAttribute(AttributeName = "maxplayers")] public int MaximumPlayers { get; set; }
    [XmlAttribute(AttributeName = "minplaytime")] public int MinimumPlaytime { get; set; }
    [XmlAttribute(AttributeName = "maxplaytime")] public int MaximumPlaytime { get; set; }
    [XmlAttribute(AttributeName = "playingtime")] public int Playtime { get; set; }
    [XmlAttribute(AttributeName = "numowned")] public int NumberOwned { get; set; }
    [XmlElement(ElementName = "rating")] public Rating Rating { get; set; }
}
