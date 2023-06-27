using System.Xml.Serialization;

namespace BggSharp.Queries.Search;

[XmlRoot(ElementName = "yearpublished")]
public class YearPublished
{
    [XmlAttribute(AttributeName = "value")] public int Value { get; set; }
}
