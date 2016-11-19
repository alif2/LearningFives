using Newtonsoft.Json;

namespace RiotAPI.Models
{
    public class RiotApiObject
    {
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}