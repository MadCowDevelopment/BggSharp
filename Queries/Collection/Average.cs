using System.Xml.Serialization;

namespace BggSharp.Queries.Collection;

[XmlRoot(ElementName = "average")]
public class Average
{
    [XmlAttribute(AttributeName = "value")] public string Value { get; set; }
}
