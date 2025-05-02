using System.Xml.Serialization;
using DataPresentation.Entities;
using Newtonsoft.Json;

namespace DataPresentation
{
    /// <summary>
    /// Класс для представления данных о коровах, стойлах и сотрудниках.
    /// </summary>
    [XmlRoot("Barn")]
    public class Barn
    {
        [XmlElement("cows")]
        [JsonProperty("Cows")] 
        public Cows Cows { get; set; }

        [XmlElement("stalls")]
        [JsonProperty("Stalls")]
        public Stalls Stalls { get; set; }

        [XmlElement("employees")]
        [JsonProperty("Employees")]
        public Employees Employees { get; set; }
    }
}
