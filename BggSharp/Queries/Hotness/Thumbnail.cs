using System.Xml.Serialization;

namespace BggSharp.Queries.Hotness;

[XmlRoot(ElementName = "thumbnail")]
public class Thumbnail
{
    [XmlAttribute(AttributeName = "value")] public string Value { get; set; }
}
