using Newtonsoft.Json;
using System.Xml.Serialization;

namespace DataPresentation.Entities
{
    /// <summary>
    /// Класс для представления данных о стойлах
    /// </summary>
    public class Stalls
    {
        [XmlElement("stall")]
        [JsonProperty("stall")]  
        public Stall[] Items { get; set; }
    }

    public class Stall
    {
        [XmlAttribute("id")]
        [JsonProperty("id")] 
        public int Id { get; set; }

        [XmlElement("location")]
        [JsonProperty("location")]  
        public string Location { get; set; }

        [XmlElement("capacity")]
        [JsonProperty("capacity")]  
        public int Capacity { get; set; }

        [XmlElement("size")]
        [JsonProperty("size")]  
        public Dimensions Size { get; set; }

        [XmlElement("type")]
        [JsonProperty("type")]  
        public string Type { get; set; }
    }

    public class Dimensions
    {
        [XmlElement("width")]
        [JsonProperty("width")]  
        public double Width { get; set; }

        [XmlElement("length")]
        [JsonProperty("length")]  
        public double Length { get; set; }
    }
}
