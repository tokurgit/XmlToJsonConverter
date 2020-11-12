using Core.Interfaces;
using Newtonsoft.Json;

namespace Core.Implementations
{
    public class Item : IElement
    {
        [JsonProperty("multiplied")]
        public double Multiplied { get; set; }

        [JsonProperty("divided")]
        public double Divided { get; set; }
    }
}
