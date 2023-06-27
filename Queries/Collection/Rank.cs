using System.Xml.Serialization;

namespace BggSharp.Queries.Forum;

[XmlRoot(ElementName = "rank")]
public class Rank
{
    [XmlAttribute(AttributeName = "type")] public string Type { get; set; }
    [XmlAttribute(AttributeName = "id")] public int Id { get; set; }
    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }
    [XmlAttribute(AttributeName = "friendlyname")] public string FriendlyName { get; set; }
    [XmlAttribute(AttributeName = "value")] public string Value { get; set; }
    [XmlAttribute(AttributeName = "bayesaverage")] public string BayesAverage { get; set; }
}
