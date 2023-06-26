using System.Xml.Serialization;

namespace BggSharp.Queries.Users;

[XmlRoot(ElementName = "top")]
public class TopItems
{
    [XmlElement(ElementName = "item")]
    public List<Item> Items { get; set; }
    [XmlAttribute(AttributeName = "domain")]
    public UserDomain Domain { get; set; }
}
