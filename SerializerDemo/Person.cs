using System;
using System.Xml.Serialization;

namespace SerializerDemo
{
    [XmlType("person")]
    public class Person
    {
        [XmlAttribute("dateadded")]
        public DateTime DateAdded { get; set; }

        [XmlElement("firstname")]
        public string FirstName { get; set; }

        [XmlElement("surname")]
        public string LastName { get; set; }

        [XmlElement("address")]
        public Address Address { get; set; }          
    }
}
