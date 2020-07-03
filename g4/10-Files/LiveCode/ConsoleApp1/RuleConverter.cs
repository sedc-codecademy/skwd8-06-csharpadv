using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{

    public static class RuleSetup
    {
        private static Dictionary<Type, string> toJson = new Dictionary<Type, string>();
        private static Dictionary<string, Type> fromJson = new Dictionary<string, Type>();

        public static IDictionary<Type, string> DescendantsToJson => toJson.ToImmutableDictionary();
        public static IDictionary<string, Type> DescendantsFromJson => fromJson.ToImmutableDictionary();

        public static void RegisterSubtype<T>(string name) where T : Rule
        {
            toJson.Add(typeof(T), name);
            fromJson.Add(name, typeof(T));
        }
    }

    public class LowercaseContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            return propertyName.ToLower();
        }
    }

    public class RuleConverter : JsonConverter
    {
        public override bool CanRead => true;
        public override bool CanWrite => true;

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(Rule).IsAssignableFrom(typeToConvert);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var token = JToken.ReadFrom(reader);
            var jtype = token["type"].ToString();
            var type = RuleSetup.DescendantsFromJson[jtype];
            return token.ToObject(type);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var result = JToken.FromObject(value, new JsonSerializer { ContractResolver = serializer.ContractResolver }) as JObject;
            result.AddFirst(new JProperty("type", RuleSetup.DescendantsToJson[value.GetType()]));
            result.WriteTo(writer);
        }
    }
}
