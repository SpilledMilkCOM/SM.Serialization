using Newtonsoft.Json;
using System;
using System.IO;

namespace SM.Serialization
{
    /// <summary>S
    /// A standard class for typical serialization operations.
    /// </summary>
    public class JsonSerializationUtility : ISerializationUtility
    {
        private readonly JsonSerializerSettings _settings;

        public JsonSerializationUtility()
        {
            _settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                PreserveReferencesHandling = PreserveReferencesHandling.All,
                TypeNameHandling = TypeNameHandling.Auto
            };
        }

        public JsonSerializationUtility(JsonSerializerSettings settings)
        {
            _settings = settings;
        }

        public TType Deserialize<TType>(string jsonData)
        {
            return (TType)Deserialize(new StringReader(jsonData), typeof(TType));
        }

        public object Deserialize(string jsonData, Type type)
        {
            return Deserialize(new StringReader(jsonData), type);
        }

        public TType Deserialize<TType>(TextReader streamReader)
        {
            return (TType)Deserialize(streamReader, typeof(TType));
        }

        public object Deserialize(TextReader streamReader, Type type)
        {
            object deserializedObject;

            using (JsonReader reader = new JsonTextReader(streamReader))
            {
                JsonSerializer jsonSerializer = JsonSerializer.Create(_settings);
                deserializedObject = jsonSerializer.Deserialize(reader, type);
            }
            return deserializedObject;
        }

        public string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj, _settings);
        }

        public void Serialize(StreamWriter streamWriter, object obj)
        {
            using (JsonTextWriter writer = new JsonTextWriter(streamWriter))
            {
                JsonSerializer jsonSerializer = JsonSerializer.Create(_settings);
                jsonSerializer.Serialize(writer, obj);
            }
        }
    }
}