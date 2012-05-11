using System.Linq;
using NUnit.Framework;

namespace SerializerDemo
{
    [TestFixture]
    public class TestRunner
    {
        private const string xml =  "<?xml version=\"1.0\" encoding=\"utf-16\"?>" +
                                    "<people>" +
                                      "<person dateadded=\"2007-09-24T08:00:00+02:00\">" +
                                        "<firstname>Leonard</firstname>" +
                                        "<surname>Hofstadter</surname>" + 
                                        "<address>" + 
                                         "<housenumber>12</housenumber>" + 
                                          "<street>Some Street</street>" +
                                          "<suburb>Los Angeles</suburb>" +
                                          "<state>California</state>" +
                                        "</address>" +
                                      "</person>" +
                                      "<person dateadded=\"2007-09-24T07:00:00+02:00\">" +
                                        "<firstname>Sheldon</firstname>" +
                                        "<surname>Cooper</surname>" + 
                                        "<address>" +
                                          "<housenumber>12-B</housenumber>" + 
                                          "<street>With Leonard</street>" +
                                          "<suburb>Los Angeles</suburb>" +
                                          "<state>California</state>" +
                                        "</address>" +
                                      "</person>" +
                                    "</people>";

        [Test]
        public void TestDeserilizer()
        {
            var serializer = new Serializer<PeopleCollection>();
            
            var obj = serializer.Deserialise(xml);

            Assert.IsNotNull(obj);
            Assert.IsTrue(obj.People.Count == 2);

            var leonard = obj.People.First();
            Assert.AreEqual(leonard.FirstName, "Leonard");
            Assert.AreEqual(leonard.LastName, "Hofstadter");
            Assert.AreEqual(leonard.Address.HouseNumber, "12");
            Assert.AreEqual(leonard.Address.Street, "Some Street");
            Assert.AreEqual(leonard.Address.Suburb, "Los Angeles");
            Assert.AreEqual(leonard.Address.State, "California");

            var serialized = serializer.Serialize(obj);

            Assert.AreEqual(xml, serialized);

        }
    }
}
