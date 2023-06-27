using System.Xml.Serialization;

namespace BggSharp.Queries.Forum;

[XmlRoot(ElementName = "ranks")]
public class RankItems
{
    [XmlElement(ElementName = "rank")] public List<Rank> Rank { get; set; }
}
