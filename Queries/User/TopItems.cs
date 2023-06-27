using System.Xml.Serialization;

namespace BggSharp.Queries.User;

[XmlRoot(ElementName = "top")]
public class TopItems
{
    [XmlAttribute(AttributeName = "termsofuse")]
    public string TermsOfUse { get; set; }
    [XmlElement(ElementName = "item")]
    public List<Item> Items { get; set; }
}
