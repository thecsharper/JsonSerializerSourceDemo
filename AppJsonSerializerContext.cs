using System.Text.Json.Serialization;

namespace JsonSerializerSourceDemo
{
    [JsonSourceGenerationOptions(
        PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
        WriteIndented = false)]
    [JsonSerializable(typeof(Customer))]
    [JsonSerializable(typeof(List<Customer>))]
    internal partial class AppJsonSerializerContext : JsonSerializerContext
    {
    }
}