using System.Xml.Serialization;

namespace BggSharp.Queries.Forum;

[XmlRoot(ElementName = "usersrated")]
public class UsersRated
{
    [XmlAttribute(AttributeName = "value")] public int Value { get; set; }
}
