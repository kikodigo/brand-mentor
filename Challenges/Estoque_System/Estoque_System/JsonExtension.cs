using System.Text.Json;
using System.Text.Json.Serialization;

namespace Estoque_System
{
    public static class JsonExtension
    {
        private static readonly JsonSerializerOptions _jsonSerializerOptions;

        static JsonExtension()
        {
            _jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                IgnoreNullValues = true,
                AllowTrailingCommas = true
            };
            if (_jsonSerializerOptions.Converters.Count == 0)
            {
                _jsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            }
        }

        public static T JsonToObject<T>(string data)
        {
            return JsonSerializer.Deserialize<T>(data, _jsonSerializerOptions);
        }

        public static string ObjectToJson<T>(T @object)
        {
            return JsonSerializer.Serialize(@object, _jsonSerializerOptions);
        }

        public static T JsonToObject<T>(string data, JsonSerializerOptions jsonSerializerOptions)
        {
            return JsonSerializer.Deserialize<T>(data, jsonSerializerOptions);
        }

        public static string ObjectToJson<T>(T @object, JsonSerializerOptions jsonSerializerOptions)
        {
            return JsonSerializer.Serialize(@object, jsonSerializerOptions);
        }
    }
}
