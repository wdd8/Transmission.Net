using System.Text.Json;
using System.Text.Json.Serialization;

namespace Transmission.Net.Core.Util;

internal class UnixDateTimeConverter : JsonConverter<DateTime?>
{
    public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        DateTime.UnixEpoch.AddSeconds(reader.GetInt64());

    public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options) =>
        writer.WriteNumberValue(new DateTimeOffset(value!.Value).ToUnixTimeSeconds());
}
