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
    /// Defines QuoteType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QuoteType
    {
        /// <summary>
        /// Enum Price for value: Price
        /// </summary>
        [EnumMember(Value = "Price")]
        Price = 1,

        /// <summary>
        /// Enum Spread for value: Spread
        /// </summary>
        [EnumMember(Value = "Spread")]
        Spread = 2,

        /// <summary>
        /// Enum Rate for value: Rate
        /// </summary>
        [EnumMember(Value = "Rate")]
        Rate = 3,

        /// <summary>
        /// Enum LogNormalVol for value: LogNormalVol
        /// </summary>
        [EnumMember(Value = "LogNormalVol")]
        LogNormalVol = 4,

        /// <summary>
        /// Enum NormalVol for value: NormalVol
        /// </summary>
        [EnumMember(Value = "NormalVol")]
        NormalVol = 5,

        /// <summary>
        /// Enum ParSpread for value: ParSpread
        /// </summary>
        [EnumMember(Value = "ParSpread")]
        ParSpread = 6,

        /// <summary>
        /// Enum IsdaSpread for value: IsdaSpread
        /// </summary>
        [EnumMember(Value = "IsdaSpread")]
        IsdaSpread = 7,

        /// <summary>
        /// Enum Upfront for value: Upfront
        /// </summary>
        [EnumMember(Value = "Upfront")]
        Upfront = 8,

        /// <summary>
        /// Enum Index for value: Index
        /// </summary>
        [EnumMember(Value = "Index")]
        Index = 9,

        /// <summary>
        /// Enum Ratio for value: Ratio
        /// </summary>
        [EnumMember(Value = "Ratio")]
        Ratio = 10,

        /// <summary>
        /// Enum Delta for value: Delta
        /// </summary>
        [EnumMember(Value = "Delta")]
        Delta = 11,

        /// <summary>
        /// Enum PoolFactor for value: PoolFactor
        /// </summary>
        [EnumMember(Value = "PoolFactor")]
        PoolFactor = 12,

        /// <summary>
        /// Enum InflationAssumption for value: InflationAssumption
        /// </summary>
        [EnumMember(Value = "InflationAssumption")]
        InflationAssumption = 13,

        /// <summary>
        /// Enum DirtyPrice for value: DirtyPrice
        /// </summary>
        [EnumMember(Value = "DirtyPrice")]
        DirtyPrice = 14,

        /// <summary>
        /// Enum PrincipalWriteOff for value: PrincipalWriteOff
        /// </summary>
        [EnumMember(Value = "PrincipalWriteOff")]
        PrincipalWriteOff = 15,

        /// <summary>
        /// Enum InterestDeferred for value: InterestDeferred
        /// </summary>
        [EnumMember(Value = "InterestDeferred")]
        InterestDeferred = 16,

        /// <summary>
        /// Enum InterestShortfall for value: InterestShortfall
        /// </summary>
        [EnumMember(Value = "InterestShortfall")]
        InterestShortfall = 17,

        /// <summary>
        /// Enum ConstituentWeightFactor for value: ConstituentWeightFactor
        /// </summary>
        [EnumMember(Value = "ConstituentWeightFactor")]
        ConstituentWeightFactor = 18
    }

}
