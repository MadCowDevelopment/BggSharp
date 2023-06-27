using System.Xml.Serialization;

namespace BggSharp.Queries.User;

[XmlRoot(ElementName = "buddy")]
public class Buddy
{
    [XmlAttribute(AttributeName = "id")]
    public int Id { get; set; }
    [XmlAttribute(AttributeName = "name")]
    public string Name { get; set; }
}
