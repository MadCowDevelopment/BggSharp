using System.Xml.Serialization;

namespace BggSharp.Queries.Families;

[XmlRoot(ElementName = "name")]
public class Name
{
    [XmlAttribute(AttributeName = "type")]
    public string Type { get; set; }
    [XmlAttribute(AttributeName = "sortindex")]
    public string SortIndex { get; set; }
    [XmlAttribute(AttributeName = "value")]
    public string Value { get; set; }
}