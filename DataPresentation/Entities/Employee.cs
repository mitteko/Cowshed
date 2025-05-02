using Newtonsoft.Json;
using System.Xml.Serialization;

namespace DataPresentation.Entities
{
    /// <summary>
    /// Класс для представления данных о сотрудниках
    /// </summary>
    public class Employees
    {
        [XmlElement("employee")]
        [JsonProperty("employee")]
        public Employee[] Items { get; set; }
    }

    public class Employee
    {
        [XmlAttribute("id")]
        [JsonProperty("id")]
        public int Id { get; set; }

        [XmlElement("name")]
        [JsonProperty("name")]
        public string Name { get; set; }

        [XmlElement("role")]
        [JsonProperty("role")]
        public string Role { get; set; }

        [XmlElement("contact")]
        [JsonProperty("contact")]
        public ContactInfo Contact { get; set; }

        [XmlElement("city")]
        [JsonProperty("city")]
        public string City { get; set; }
    }

    public class ContactInfo
    {
        [XmlElement("phone")]
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [XmlElement("email")]
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
