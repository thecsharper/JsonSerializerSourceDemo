// From: https://isitvritra101.medium.com/10x-faster-json-serialization-the-overlooked-net-feature-senior-developers-miss-fa578dc3828f

using JsonSerializerSourceDemo;
using System.Text.Json;
using System.Text.Json.Serialization;

var options = new JsonSerializerOptions
{
    DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
    IncludeFields = false,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
};

var customer = new Customer
{
    Name = "Test",
    Description = "Test"
};

// Step 3: Use the context for serialization
var context = new AppJsonSerializerContext(options);
var json = JsonSerializer.Serialize(customer, typeof(Customer), context);

Console.WriteLine(json);