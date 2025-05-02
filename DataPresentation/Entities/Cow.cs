using Newtonsoft.Json;
using System.Xml.Serialization;

namespace DataPresentation.Entities
{
    /// <summary>
    /// Класс для представления данных о коровах
    /// </summary>
    public class Cows
    {
        [XmlElement("cow")]
        [JsonProperty("cow")] 
        public Cow[] Items { get; set; }
    }

    public class Cow
    {
        [XmlAttribute("id")]
        [JsonProperty("id")]
        public int Id { get; set; }

        [XmlElement("name")]
        [JsonProperty("name")]
        public string Name { get; set; }

        [XmlElement("breed")]
        [JsonProperty("breed")]
        public string Breed { get; set; }

        [XmlElement("age")]
        [JsonProperty("age")]
        public int Age { get; set; }

        [XmlElement("health")]
        [JsonProperty("health")]
        public HealthInfo Health { get; set; }

        [XmlElement("notes")]
        [JsonProperty("notes")]
        public string Notes { get; set; } = string.Empty;

        [XmlElement("FeedingSchedules")]
        [JsonProperty("FeedingSchedules")]
        public FeedingSchedules FeedingSchedulesWrapper { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        public List<FeedingSchedule> FeedingSchedules
        {
            get
            {
                if (FeedingSchedulesWrapper?.Items != null)
                    return new List<FeedingSchedule>(FeedingSchedulesWrapper.Items);
                else
                    return new List<FeedingSchedule>();
            }
            set
            {
                FeedingSchedulesWrapper = new FeedingSchedules();
                FeedingSchedulesWrapper.Items = value.ToArray();
            }
        }
    }

    public class HealthInfo
    {
        [XmlElement("temperature")]
        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [XmlElement("condition")]
        [JsonProperty("condition")]
        public string Condition { get; set; }
    }

    public class FeedingSchedules
    {
        [XmlElement("FeedingSchedule")]
        [JsonProperty("FeedingSchedule")]
        public FeedingSchedule[] Items { get; set; }
    }
}
