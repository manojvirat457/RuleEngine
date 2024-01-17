using System.Text.Json.Serialization;

namespace Core.Models
{
    public class BaseRule
    {
        [JsonConverter(typeof(Extensions.DictionaryExtender))]
        public Dictionary<string, object>? Input { get; set; }
    }
}
