using System.Xml.Serialization;

namespace BggSharp.Queries.Collection;

[XmlRoot(ElementName = "median")]
public class Median
{
    [XmlAttribute(AttributeName = "value")] public string Value { get; set; }
}
