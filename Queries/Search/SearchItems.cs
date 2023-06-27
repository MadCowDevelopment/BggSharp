using System.Xml.Serialization;

namespace BggSharp.Queries.Search;

[XmlRoot(ElementName = "items")]
public class SearchItems
{
    [XmlAttribute(AttributeName = "total")] public int Total { get; set; }
    [XmlAttribute(AttributeName = "termsofuse")] public string TermsOfUse { get; set; }
    [XmlElement(ElementName = "item")] public List<Item> Items { get; set; }
}
