/*
 * LUSID API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// When holdings adjustments are specified for a single effective date,  any holdings for the portfolio not included in the adjustments are  adjusted according to this value.
    /// </summary>
    /// <value>When holdings adjustments are specified for a single effective date,  any holdings for the portfolio not included in the adjustments are  adjusted according to this value.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UnmatchedHoldingMethod
    {
        /// <summary>
        /// Enum PositionToZero for value: PositionToZero
        /// </summary>
        [EnumMember(Value = "PositionToZero")]
        PositionToZero = 1,

        /// <summary>
        /// Enum KeepTheSame for value: KeepTheSame
        /// </summary>
        [EnumMember(Value = "KeepTheSame")]
        KeepTheSame = 2

    }

}
