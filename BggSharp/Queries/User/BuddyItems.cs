using System.Xml.Serialization;

namespace BggSharp.Queries.User;

[XmlRoot(ElementName = "buddies")]
public class BuddyItems
{
    [XmlElement(ElementName = "buddy")] public List<Buddy> Buddies { get; set; }
    [XmlAttribute(AttributeName = "total")] public int Total { get; set; }
    [XmlAttribute(AttributeName = "page")] public int Page { get; set; }
}
