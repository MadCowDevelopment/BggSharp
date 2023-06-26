using System.Xml.Serialization;

namespace BggSharp.Queries.Guild;

[XmlRoot(ElementName = "member")]
public class Member
{
    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }
    [XmlAttribute(AttributeName = "date")] public string Date { get; set; }
}
