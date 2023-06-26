using System.Xml.Serialization;

namespace BggSharp.Queries.User;

[XmlRoot(ElementName = "hot")]
public class HotItems
{
    [XmlElement(ElementName = "item")]
    public List<Item> Items { get; set; }
    [XmlAttribute(AttributeName = "domain")]
    public UserDomain Domain { get; set; }
}
