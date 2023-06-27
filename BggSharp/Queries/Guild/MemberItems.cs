using System.Xml.Serialization;

namespace BggSharp.Queries.Guild;

[XmlRoot(ElementName = "members")]
public class MemberItems
{
    [XmlAttribute(AttributeName = "count")] public int Count { get; set; }
    [XmlAttribute(AttributeName = "page")] public int Page { get; set; }
    [XmlElement(ElementName = "member")] public List<Member> Members { get; set; }
}
