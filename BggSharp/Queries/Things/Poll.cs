using System.Xml.Serialization;

namespace BggSharp.Queries.Things;

[XmlRoot(ElementName = "poll")]
public class Poll
{
    [XmlElement(ElementName = "results")] public List<Results> Results { get; set; }
    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }
    [XmlAttribute(AttributeName = "title")] public string Title { get; set; }
    [XmlAttribute(AttributeName = "totalvotes")] public string TotalVotes { get; set; }
}