using System.Xml.Serialization;

namespace BggSharp.Queries.Hotness;

[XmlRoot(ElementName = "name")]
public class Name
{
    [XmlAttribute(AttributeName = "value")] public string Value { get; set; }
}
