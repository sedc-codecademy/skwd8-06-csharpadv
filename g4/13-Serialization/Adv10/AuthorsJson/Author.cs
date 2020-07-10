using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using System.Collections.Generic;

namespace AuthorsJson
{
    public class Author
    {
        [JsonProperty(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
        public int ID { get; internal set; }

        [JsonProperty("name")]
        public string Name { get; internal set; }

        [JsonProperty("nominations")]
        public int Nominations { get; internal set; }

        [JsonProperty("wins")]
        public int Wins { get; internal set; }

        [JsonProperty("books")]
        public List<Book> Books { get; set; }

        public override string ToString()
        {
            return $"#{ID}: {Name}";
        }
    }
}