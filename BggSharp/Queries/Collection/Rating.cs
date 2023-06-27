using System.Xml.Serialization;

namespace BggSharp.Queries.Collection;

[XmlRoot(ElementName = "rating")]
public class Rating
{
    [XmlAttribute(AttributeName = "value")] public string Value { get; set; }
    [XmlElement(ElementName = "usersrated")] public UsersRated UsersRated { get; set; }
    [XmlElement(ElementName = "average")] public Average Average { get; set; }
    [XmlElement(ElementName = "bayesaverage")] public BayesAverage BayesAverage { get; set; }
    [XmlElement(ElementName = "stddev")] public StdDev StandardDeviations { get; set; }
    [XmlElement(ElementName = "median")] public Median Median { get; set; }
    [XmlElement(ElementName = "ranks")] public RankItems Ranks { get; set; }
}