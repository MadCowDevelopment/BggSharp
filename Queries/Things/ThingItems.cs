using System.Xml.Serialization;

namespace BggSharp.Queries.Things;

[XmlRoot(ElementName = "items")]
public class ThingItems
{
    [XmlElement(ElementName = "item")]
    public List<Item> Items { get; set; }
    [XmlAttribute(AttributeName = "termsofuse")]
    public string TermsOfUse { get; set; }
}