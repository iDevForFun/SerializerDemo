using System.Xml.Serialization;

namespace SerializerDemo
{
    [XmlType("address")]
    public class Address
    {
        [XmlElement("housenumber")]
        public string HouseNumber { get; set; }

        [XmlElement("street")]
        public string Street { get; set; }

        [XmlElement("suburb")]
        public string Suburb { get; set; }

        [XmlElement("state")]
        public string State { get; set; }
    }
}
