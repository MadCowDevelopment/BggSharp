using System.Xml.Serialization;

namespace BggSharp.Queries.Families;

[XmlRoot(ElementName = "items")]
public class FamilyItems
{
    [XmlElement(ElementName = "item")] public List<Item> Items { get; set; }
    [XmlAttribute(AttributeName = "termsofuse")] public string TermsOfUse { get; set; }
}