using System.Xml.Serialization;

namespace BggSharp.Queries.Search;

[XmlRoot(ElementName = "name")]
public class Name
{
    [XmlAttribute(AttributeName = "type")] public string Type { get; set; }
    [XmlAttribute(AttributeName = "value")] public string Value { get; set; }
}
