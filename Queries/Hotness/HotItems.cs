using BggSharp.Queries.User;
using System.Xml.Serialization;

namespace BggSharp.Queries.Hotness;

[XmlRoot(ElementName = "items")]
public class HotItems
{
    [XmlElement(ElementName = "item")]
    public List<Item> Items { get; set; }
    [XmlAttribute(AttributeName = "domain")]
    public UserDomain Domain { get; set; }
}
