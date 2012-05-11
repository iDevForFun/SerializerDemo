using System.Collections.Generic;
using System.Xml.Serialization;

namespace SerializerDemo
{
    [XmlRoot("people")]
    public class PeopleCollection
    {
        public PeopleCollection()
        {
            People = new List<Person>();
        }

        [XmlElement("person")]
        public List<Person> People { get; set; }
    }
}
