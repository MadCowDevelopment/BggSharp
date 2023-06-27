using System.Xml.Serialization;

namespace BggSharp.Queries.Hotness;

[XmlRoot(ElementName = "yearpublished")]
public class YearPublished
{
    [XmlAttribute(AttributeName = "value")] public int Value { get; set; }
}
