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
    /// Defines ChangeHistoryAction
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChangeHistoryAction
    {
        /// <summary>
        /// Enum Create for value: Create
        /// </summary>
        [EnumMember(Value = "Create")]
        Create = 1,

        /// <summary>
        /// Enum Update for value: Update
        /// </summary>
        [EnumMember(Value = "Update")]
        Update = 2,

        /// <summary>
        /// Enum Delete for value: Delete
        /// </summary>
        [EnumMember(Value = "Delete")]
        Delete = 3

    }

}