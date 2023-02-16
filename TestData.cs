using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace AbodWebAPI
{
    public class TestData
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "first_name")]
        public string? FirstName { get; set; }
        [JsonProperty(PropertyName = "last_name")]
        public string? LastName { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string? Email { get; set; }
        [JsonProperty(PropertyName = "gender")]
        public string? Gender { get; set; }
        [JsonProperty(PropertyName = "current_car")]
        public string? CurrentCar { get; set; }
    }
}