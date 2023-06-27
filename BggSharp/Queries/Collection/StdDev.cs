using System.Xml.Serialization;

namespace BggSharp.Queries.Collection;

[XmlRoot(ElementName = "stddev")]
public class StdDev
{
    [XmlAttribute(AttributeName = "value")] public string Value { get; set; }
}
