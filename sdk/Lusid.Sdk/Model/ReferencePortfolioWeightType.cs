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
    /// Defines ReferencePortfolioWeightType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReferencePortfolioWeightType
    {
        /// <summary>
        /// Enum Static for value: Static
        /// </summary>
        [EnumMember(Value = "Static")]
        Static = 1,

        /// <summary>
        /// Enum Floating for value: Floating
        /// </summary>
        [EnumMember(Value = "Floating")]
        Floating = 2,

        /// <summary>
        /// Enum Periodical for value: Periodical
        /// </summary>
        [EnumMember(Value = "Periodical")]
        Periodical = 3
    }

}
