using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

// Namespace needs to be automatically picked up by classes in .Api and .Model
// ReSharper disable once CheckNamespace
namespace Lusid.Sdk
{
    /// <summary>
    /// Entity for specifying a date or a cut label to LUSID.
    /// Dates are serialised in the standard round-trip format - see https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings#Roundtrip
    /// Cut labels are serialised using the format [YYYY-MM-DD]N[cut label] - see https://support.lusid.com/what-are-cutlabels
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(CutLabelJsonConverter))]
    public class DateTimeOrCutLabel
    {
        internal string Parameter { get; }

        internal DateTimeOrCutLabel(string parameter)
        {
            Parameter = parameter;
        }

        /// <summary>
        /// Create a DateOrCutLabel for the specified date
        /// </summary>
        public DateTimeOrCutLabel(DateTimeOffset datetime)
        : this(datetime.ToString("o"))
        { }

        /// <summary>
        /// Create a DateOrCutLabel for the specified cutlabel on the specified date.
        /// Note that if the date contains any time portion this will cause an exception
        /// </summary>
        /// <param name="date"></param>
        /// <param name="cutLabel"></param>
        public DateTimeOrCutLabel(DateTimeOffset date, string cutLabel)
            : this($"{date:yyyy-MM-dd}N{cutLabel}")
        {
            if ((date.TimeOfDay != TimeSpan.Zero) || (date.Offset != TimeSpan.Zero))
            {
                throw new ArgumentException($"The date for a cut label should not have a time component, but was {date:o}");
            }
        }

        /// <summary>
        /// Conversion from a DateTimeOffset to a DateOrCutLabel
        /// </summary>
        public static implicit operator DateTimeOrCutLabel(DateTimeOffset date)
        {
            return new DateTimeOrCutLabel(date);
        }

        /// <summary>
        /// Conversion from a string to a DateOrCutLabel.  This string is assumed to already be in a valid format for LUSID
        /// </summary>
        public static implicit operator DateTimeOrCutLabel(string cutLabel)
        {
            return new DateTimeOrCutLabel(cutLabel);
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return Parameter;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj is DateTimeOrCutLabel rhsDateTimeOrCutLabel)
            {
                return Parameter.Equals(rhsDateTimeOrCutLabel.Parameter);
            }

            return false;
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Parameter.GetHashCode();
        }
    }

    /// <inheritdoc />
    public class CutLabelJsonConverter : JsonConverter
    {
        /// <inheritdoc />
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            DateTimeOrCutLabel dateTimeOrCutLabel = value as DateTimeOrCutLabel;

            if (dateTimeOrCutLabel != null)
            {
                writer.WriteValue(dateTimeOrCutLabel.Parameter);
            }
        }

        /// <inheritdoc />
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var o = reader.Value;

            switch (o)
            {
                case DateTime dt:
                    return new DateTimeOrCutLabel(dt.ToUniversalTime());

                case DateTimeOffset dto:
                    return new DateTimeOrCutLabel(dto);

                default:
                    return new DateTimeOrCutLabel(o.ToString());
            }
        }

        /// <inheritdoc />
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTimeOrCutLabel);
        }
    }
}
