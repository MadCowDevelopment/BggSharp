using System.Xml.Serialization;

namespace BggSharp.Queries.Collection;

[XmlRoot(ElementName = "ranks")]
public class RankItems
{
    [XmlElement(ElementName = "rank")] public List<Rank> Rank { get; set; }
}
