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
    /// Defines TransactionRoles
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionRoles
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        /// Enum LongLonger for value: LongLonger
        /// </summary>
        [EnumMember(Value = "LongLonger")]
        LongLonger = 2,

        /// <summary>
        /// Enum LongShorter for value: LongShorter
        /// </summary>
        [EnumMember(Value = "LongShorter")]
        LongShorter = 3,

        /// <summary>
        /// Enum ShortShorter for value: ShortShorter
        /// </summary>
        [EnumMember(Value = "ShortShorter")]
        ShortShorter = 4,

        /// <summary>
        /// Enum Shorter for value: Shorter
        /// </summary>
        [EnumMember(Value = "Shorter")]
        Shorter = 5,

        /// <summary>
        /// Enum ShortLonger for value: ShortLonger
        /// </summary>
        [EnumMember(Value = "ShortLonger")]
        ShortLonger = 6,

        /// <summary>
        /// Enum Longer for value: Longer
        /// </summary>
        [EnumMember(Value = "Longer")]
        Longer = 7,

        /// <summary>
        /// Enum AllRoles for value: AllRoles
        /// </summary>
        [EnumMember(Value = "AllRoles")]
        AllRoles = 8

    }

}
