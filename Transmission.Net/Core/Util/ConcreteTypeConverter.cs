using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Transmission.Net.Core.Util;

/// <summary>
/// (De)serializes <typeparamref name="TInterface"/> as <typeparamref name="TConcrete"/>
/// </summary>
internal class ConcreteTypeConverter<TInterface, TConcrete> : JsonConverter<TInterface> where TConcrete : TInterface
{
    public override TInterface? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        JsonSerializer.Deserialize(ref reader, (JsonTypeInfo<TConcrete>)options.GetTypeInfo(typeof(TConcrete)));

    public override void Write(Utf8JsonWriter writer, TInterface value, JsonSerializerOptions options) =>
        JsonSerializer.Serialize(writer, (TConcrete)value!, (JsonTypeInfo<TConcrete>)options.GetTypeInfo(typeof(TConcrete)));
}
