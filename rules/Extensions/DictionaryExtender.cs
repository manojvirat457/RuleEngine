using System.Text.Json.Serialization;
using System.Text.Json;

namespace Core.Extensions
{
    public class DictionaryExtender : JsonConverter<Dictionary<string, object>>
    {
        public override Dictionary<string, object>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.StartObject)
            {
                var inputDict = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(ref reader, options);

                if (inputDict != null)
                {
                    var convertedDict = new Dictionary<string, object>();

                    foreach (var kvp in inputDict)
                    {
                        if (kvp.Value.ValueKind == JsonValueKind.Number)
                        {
                            if (kvp.Value.TryGetInt32(out int intValue))
                            {
                                convertedDict.Add(kvp.Key, intValue);
                            }
                            else if (kvp.Value.TryGetInt64(out long longValue))
                            {
                                convertedDict.Add(kvp.Key, longValue);
                            }
                            else if (kvp.Value.TryGetDouble(out double doubleValue))
                            {
                                convertedDict.Add(kvp.Key, doubleValue);
                            }
                        }
                        else if (kvp.Value.ValueKind == JsonValueKind.String)
                        {
                            convertedDict.Add(kvp.Key, kvp.Value.GetString());
                        }
                        else if (kvp.Value.ValueKind == JsonValueKind.True || kvp.Value.ValueKind == JsonValueKind.False)
                        {
                            convertedDict.Add(kvp.Key, kvp.Value.GetBoolean());
                        }
                        // Add other type conversions as needed
                        else
                        {
                            convertedDict.Add(kvp.Key, kvp.Value.ToString());
                        }
                    }

                    return convertedDict;
                }
            }

            return null;
        }

        public override void Write(Utf8JsonWriter writer, Dictionary<string, object> value, JsonSerializerOptions options)
        {
            // Implement if needed
            throw new NotImplementedException();
        }
    }


}
