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
    /// Defines AccountingMethod
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountingMethod
    {
        /// <summary>
        /// Enum Default for value: Default
        /// </summary>
        [EnumMember(Value = "Default")]
        Default = 1,

        /// <summary>
        /// Enum AverageCost for value: AverageCost
        /// </summary>
        [EnumMember(Value = "AverageCost")]
        AverageCost = 2,

        /// <summary>
        /// Enum FirstInFirstOut for value: FirstInFirstOut
        /// </summary>
        [EnumMember(Value = "FirstInFirstOut")]
        FirstInFirstOut = 3,

        /// <summary>
        /// Enum LastInFirstOut for value: LastInFirstOut
        /// </summary>
        [EnumMember(Value = "LastInFirstOut")]
        LastInFirstOut = 4,

        /// <summary>
        /// Enum HighestCostFirst for value: HighestCostFirst
        /// </summary>
        [EnumMember(Value = "HighestCostFirst")]
        HighestCostFirst = 5,

        /// <summary>
        /// Enum LowestCostFirst for value: LowestCostFirst
        /// </summary>
        [EnumMember(Value = "LowestCostFirst")]
        LowestCostFirst = 6,

        /// <summary>
        /// Enum ProRateByUnits for value: ProRateByUnits
        /// </summary>
        [EnumMember(Value = "ProRateByUnits")]
        ProRateByUnits = 7,

        /// <summary>
        /// Enum ProRateByCost for value: ProRateByCost
        /// </summary>
        [EnumMember(Value = "ProRateByCost")]
        ProRateByCost = 8,

        /// <summary>
        /// Enum ProRateByCostPortfolioCurrency for value: ProRateByCostPortfolioCurrency
        /// </summary>
        [EnumMember(Value = "ProRateByCostPortfolioCurrency")]
        ProRateByCostPortfolioCurrency = 9,

        /// <summary>
        /// Enum IntraDayThenFirstInFirstOut for value: IntraDayThenFirstInFirstOut
        /// </summary>
        [EnumMember(Value = "IntraDayThenFirstInFirstOut")]
        IntraDayThenFirstInFirstOut = 10,

        /// <summary>
        /// Enum LongTermHighestCostFirst for value: LongTermHighestCostFirst
        /// </summary>
        [EnumMember(Value = "LongTermHighestCostFirst")]
        LongTermHighestCostFirst = 11,

        /// <summary>
        /// Enum LongTermHighestCostFirstPortfolioCurrency for value: LongTermHighestCostFirstPortfolioCurrency
        /// </summary>
        [EnumMember(Value = "LongTermHighestCostFirstPortfolioCurrency")]
        LongTermHighestCostFirstPortfolioCurrency = 12,

        /// <summary>
        /// Enum HighestCostFirstPortfolioCurrency for value: HighestCostFirstPortfolioCurrency
        /// </summary>
        [EnumMember(Value = "HighestCostFirstPortfolioCurrency")]
        HighestCostFirstPortfolioCurrency = 13,

        /// <summary>
        /// Enum LowestCostFirstPortfolioCurrency for value: LowestCostFirstPortfolioCurrency
        /// </summary>
        [EnumMember(Value = "LowestCostFirstPortfolioCurrency")]
        LowestCostFirstPortfolioCurrency = 14,

        /// <summary>
        /// Enum MaximumLossMinimumGain for value: MaximumLossMinimumGain
        /// </summary>
        [EnumMember(Value = "MaximumLossMinimumGain")]
        MaximumLossMinimumGain = 15,

        /// <summary>
        /// Enum MaximumLossMinimumGainPortfolioCurrency for value: MaximumLossMinimumGainPortfolioCurrency
        /// </summary>
        [EnumMember(Value = "MaximumLossMinimumGainPortfolioCurrency")]
        MaximumLossMinimumGainPortfolioCurrency = 16
    }

}
