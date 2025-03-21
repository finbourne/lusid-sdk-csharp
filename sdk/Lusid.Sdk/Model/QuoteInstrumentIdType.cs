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
    /// Defines QuoteInstrumentIdType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QuoteInstrumentIdType
    {
        /// <summary>
        /// Enum LusidInstrumentId for value: LusidInstrumentId
        /// </summary>
        [EnumMember(Value = "LusidInstrumentId")]
        LusidInstrumentId = 1,

        /// <summary>
        /// Enum Figi for value: Figi
        /// </summary>
        [EnumMember(Value = "Figi")]
        Figi = 2,

        /// <summary>
        /// Enum RIC for value: RIC
        /// </summary>
        [EnumMember(Value = "RIC")]
        RIC = 3,

        /// <summary>
        /// Enum QuotePermId for value: QuotePermId
        /// </summary>
        [EnumMember(Value = "QuotePermId")]
        QuotePermId = 4,

        /// <summary>
        /// Enum Isin for value: Isin
        /// </summary>
        [EnumMember(Value = "Isin")]
        Isin = 5,

        /// <summary>
        /// Enum CurrencyPair for value: CurrencyPair
        /// </summary>
        [EnumMember(Value = "CurrencyPair")]
        CurrencyPair = 6,

        /// <summary>
        /// Enum ClientInternal for value: ClientInternal
        /// </summary>
        [EnumMember(Value = "ClientInternal")]
        ClientInternal = 7,

        /// <summary>
        /// Enum Sedol for value: Sedol
        /// </summary>
        [EnumMember(Value = "Sedol")]
        Sedol = 8,

        /// <summary>
        /// Enum Cusip for value: Cusip
        /// </summary>
        [EnumMember(Value = "Cusip")]
        Cusip = 9
    }

}
