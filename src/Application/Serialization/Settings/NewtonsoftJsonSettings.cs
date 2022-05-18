
using MinhasNoticias.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace MinhasNoticias.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}