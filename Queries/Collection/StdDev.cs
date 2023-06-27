using System.Xml.Serialization;

namespace BggSharp.Queries.Forum;

[XmlRoot(ElementName = "stddev")]
public class StdDev
{
    [XmlAttribute(AttributeName = "value")] public string Value { get; set; }
}
