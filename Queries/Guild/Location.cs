using System.Xml.Serialization;

namespace BggSharp.Queries.Guild;

[XmlRoot(ElementName = "location")]
public class Location
{
    [XmlElement(ElementName = "addr1")] public string Address1 { get; set; }
    [XmlElement(ElementName = "addr2")] public string Address2 { get; set; }
    [XmlElement(ElementName = "city")] public string City { get; set; }
    [XmlElement(ElementName = "stateorprovince")] public string StateOrProvince { get; set; }
    [XmlElement(ElementName = "postalcode")] public string PostalCode { get; set; }
    [XmlElement(ElementName = "country")] public string Country { get; set; }
}
