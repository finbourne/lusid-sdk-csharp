using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

// Namespace needs to be automatically picked up by classes in .Api and .Model
// ReSharper disable once CheckNamespace
namespace Lusid.Sdk
{
    /// <summary>
    /// Helper class to convert DateTimeOffsets to the format needed for sending to LUSID
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(CutLabelJsonConverter))]
    public class DateOrCutLabel
    {
        internal string Parameter { get; }

        internal DateOrCutLabel(string parameter)
        {
            Parameter = parameter;
        }

        public static implicit operator DateOrCutLabel(DateTimeOffset date)
        {
            return new DateOrCutLabel(date.ToString("o"));
        }

        public static implicit operator DateOrCutLabel(string cutLabel)
        {
            return new DateOrCutLabel(cutLabel);
        }

        public override string ToString()
        {
            return Parameter;
        }
    }

    public class CutLabelJsonConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            DateOrCutLabel dateOrCutLabel = value as DateOrCutLabel;

            writer.WriteValue(dateOrCutLabel.Parameter);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateOrCutLabel);
        }
    }

    /// <summary>
    /// Utility functions
    /// </summary>
    public static class CutLabelUtils
    {
        /// <summary>
        /// Convert a DateTimeOffset to a string in the format that LUSID requires
        /// </summary>
        public static string ToLUSIDDate(this DateTimeOffset date)
        {
            return ((DateOrCutLabel)date).ToString();
        }

        /// <summary>
        /// Convert a DateTimeOffset to a string in the format that LUSID requires
        /// </summary>
        public static string ToLUSIDDate(this DateTimeOffset? date)
        {
            if (date != null)
            {
                return ((DateOrCutLabel) date).ToString();
            }

            return null;
        }
    }
}
