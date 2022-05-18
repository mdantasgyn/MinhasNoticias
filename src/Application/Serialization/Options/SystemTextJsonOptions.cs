using System.Text.Json;
using MinhasNoticias.Application.Interfaces.Serialization.Options;

namespace MinhasNoticias.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}