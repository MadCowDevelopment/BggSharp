using System.Xml.Serialization;

namespace BggSharp.Queries.Guild;

[XmlRoot(ElementName = "guild")]
public class Guild
{
    [XmlAttribute(AttributeName = "id")]
    public int Id { get; set; }
    [XmlAttribute(AttributeName = "name")]
    public string Name { get; set; }
    [XmlAttribute(AttributeName = "created")]
    public string Created { get; set; }
    [XmlAttribute(AttributeName = "termsofuse")]
    public string TermsOfUse { get; set; }
    [XmlElement(ElementName = "category")]
    public string Category { get; set; }
    [XmlElement(ElementName = "website")]
    public string Website { get; set; }
    [XmlElement(ElementName = "manager")]
    public string Manager { get; set; }
    [XmlElement(ElementName = "description")]
    public string Description { get; set; }
    [XmlElement(ElementName = "location")]
    public Location Location { get; set; }
    [XmlElement(ElementName = "members")]
    public MemberItems Members { get; set; }
}