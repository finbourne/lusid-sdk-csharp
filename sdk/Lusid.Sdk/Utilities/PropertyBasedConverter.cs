using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using Lusid.Sdk.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Lusid.Sdk.Utilities
{
    /// <summary>
    /// Deserialize JSON by setting property values. This is used to set property values when the
    /// object is an instance of a dictionary e.g. ProblemDetails. JSON values will not be added
    /// to the dictionary. 
    ///
    /// Requires a parameterless constructor and will attempt to set properties with a [DataMember]
    /// </summary>
    public class PropertyBasedConverter : JsonConverter
    {
        /// <inheritdoc />
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);

            //    get the non-default constructor with arguments
            var ctor = objectType
                .GetConstructors(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                .FirstOrDefault(c => c.GetParameters().Length == 0);

            if (ctor == null)
            {
                throw new InvalidOperationException("Parameterless constructor required");
            }

            //    create the instance using the parameterless constructor
            var problemDetails = ctor.Invoke(new object[] {});
            
            //    get properties with [DataMember] 
            var properties = objectType
                .GetProperties()
                .Where(prop => prop.IsDefined(typeof(DataMemberAttribute), false));
            
            //    set the property values, converting the values in the JSON
            //    from the type of the property
            foreach (var property in properties)
            {
                var attr = property
                    .GetCustomAttributes(typeof(DataMemberAttribute))
                    .Cast<DataMemberAttribute>()
                    .SingleOrDefault();

                if (jObject.TryGetValue(attr.Name, out var jsonValue))
                {
                    property.SetValue(problemDetails, jsonValue.ToObject(property.PropertyType));
                }
            }
            
            return problemDetails;
        }

        /// <inheritdoc />
        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}