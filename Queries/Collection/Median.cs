using System.Xml.Serialization;

namespace BggSharp.Queries.Forum;

[XmlRoot(ElementName = "median")]
public class Median
{
    [XmlAttribute(AttributeName = "value")] public string Value { get; set; }
}
