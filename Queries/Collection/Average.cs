using System.Xml.Serialization;

namespace BggSharp.Queries.Forum;

[XmlRoot(ElementName = "average")]
public class Average
{
    [XmlAttribute(AttributeName = "value")] public string Value { get; set; }
}
