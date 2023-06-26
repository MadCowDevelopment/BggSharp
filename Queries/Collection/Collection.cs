using System.Xml.Serialization;

namespace BggSharp.Queries.Forum;


[XmlRoot(ElementName = "items")]
public class Collection
{
    [XmlAttribute(AttributeName = "totalitems")]
    public int TotalItems { get; set; }
    [XmlAttribute(AttributeName = "pubdate")]
    public string PubDate { get; set; }
    [XmlAttribute(AttributeName = "termsofuse")]
    public string TermsOfUse { get; set; }
    [XmlElement(ElementName = "item")]
    public List<Item> Item { get; set; }
}