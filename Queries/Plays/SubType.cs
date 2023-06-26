using System.Xml.Serialization;

namespace BggSharp.Queries.Plays;

[XmlRoot(ElementName = "subtype")]
public class SubType
{
    [XmlAttribute(AttributeName = "value")] public string Value { get; set; }
}