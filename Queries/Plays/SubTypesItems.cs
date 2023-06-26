using System.Xml.Serialization;

namespace BggSharp.Queries.Plays;

[XmlRoot(ElementName = "subtypes")]
public class SubTypesItems
{
    [XmlElement(ElementName = "subtype")] public List<SubType> SubTypes { get; set; }
}
