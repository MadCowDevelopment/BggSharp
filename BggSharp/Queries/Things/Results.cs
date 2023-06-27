using System.Xml.Serialization;

namespace BggSharp.Queries.Things;

[XmlRoot(ElementName = "results")]
public class Results
{
    [XmlElement(ElementName = "result")] public List<Result> ResultItems { get; set; }
    [XmlAttribute(AttributeName = "numplayers")] public string NumPlayers { get; set; }
}