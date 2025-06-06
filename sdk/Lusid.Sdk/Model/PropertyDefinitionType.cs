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
    /// Defines PropertyDefinitionType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PropertyDefinitionType
    {
        /// <summary>
        /// Enum ValueProperty for value: ValueProperty
        /// </summary>
        [EnumMember(Value = "ValueProperty")]
        ValueProperty = 1,

        /// <summary>
        /// Enum DerivedDefinition for value: DerivedDefinition
        /// </summary>
        [EnumMember(Value = "DerivedDefinition")]
        DerivedDefinition = 2
    }

}
