using System.Xml.Serialization;

namespace BggSharp.Queries.Things;

[XmlRoot(ElementName = "maxplaytime")]
public class MaxPlaytime
{
    [XmlAttribute(AttributeName = "value")] public int Value { get; set; }
}