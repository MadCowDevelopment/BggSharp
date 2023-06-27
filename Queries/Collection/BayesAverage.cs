using System.Xml.Serialization;

namespace BggSharp.Queries.Forum;

[XmlRoot(ElementName = "bayesaverage")]
public class BayesAverage
{
    [XmlAttribute(AttributeName = "value")] public string Value { get; set; }
}
