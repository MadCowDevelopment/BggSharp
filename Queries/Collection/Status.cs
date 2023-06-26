using System.Xml.Serialization;

namespace BggSharp.Queries.Forum;

[XmlRoot(ElementName = "status")]
public class Status
{
    [XmlAttribute(AttributeName = "own")]
    public bool Own { get; set; }
    [XmlAttribute(AttributeName = "prevowned")]
    public bool PrevOwned { get; set; }
    [XmlAttribute(AttributeName = "fortrade")]
    public bool ForTrade { get; set; }
    [XmlAttribute(AttributeName = "want")]
    public bool Want { get; set; }
    [XmlAttribute(AttributeName = "wanttoplay")]
    public bool WantToPlay { get; set; }
    [XmlAttribute(AttributeName = "wanttobuy")]
    public bool WantToBuy { get; set; }
    [XmlAttribute(AttributeName = "wishlist")]
    public bool Wishlist { get; set; }
    [XmlAttribute(AttributeName = "preordered")]
    public bool Preordered { get; set; }
    [XmlAttribute(AttributeName = "lastmodified")]
    public string LastModified { get; set; }
}