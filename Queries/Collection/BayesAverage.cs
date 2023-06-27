using System.Xml.Serialization;

namespace BggSharp.Queries.Collection;

[XmlRoot(ElementName = "bayesaverage")]
public class BayesAverage
{
    [XmlAttribute(AttributeName = "value")] public string Value { get; set; }
}
