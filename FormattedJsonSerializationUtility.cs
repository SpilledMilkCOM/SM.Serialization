using Newtonsoft.Json;

namespace SM.Serialization
{
    /// <summary>
    /// A standard utility for formatted JSON.
    /// </summary>
    public class FormattedJsonSerializationUtility : JsonSerializationUtility
    {
        /// <summary>
        /// Construct the utility with standard options.
        /// </summary>
        public FormattedJsonSerializationUtility()
            : base(new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                PreserveReferencesHandling = PreserveReferencesHandling.All,
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented
            })
        {
        }
    }
}