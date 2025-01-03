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
    /// Discriminator for EconomicDependency.
    /// </summary>
    /// <value>Discriminator for EconomicDependency.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EconomicDependencyType
    {
        /// <summary>
        /// Enum OpaqueDependency for value: OpaqueDependency
        /// </summary>
        [EnumMember(Value = "OpaqueDependency")]
        OpaqueDependency = 1,

        /// <summary>
        /// Enum CashDependency for value: CashDependency
        /// </summary>
        [EnumMember(Value = "CashDependency")]
        CashDependency = 2,

        /// <summary>
        /// Enum DiscountingDependency for value: DiscountingDependency
        /// </summary>
        [EnumMember(Value = "DiscountingDependency")]
        DiscountingDependency = 3,

        /// <summary>
        /// Enum EquityCurveDependency for value: EquityCurveDependency
        /// </summary>
        [EnumMember(Value = "EquityCurveDependency")]
        EquityCurveDependency = 4,

        /// <summary>
        /// Enum EquityVolDependency for value: EquityVolDependency
        /// </summary>
        [EnumMember(Value = "EquityVolDependency")]
        EquityVolDependency = 5,

        /// <summary>
        /// Enum FxDependency for value: FxDependency
        /// </summary>
        [EnumMember(Value = "FxDependency")]
        FxDependency = 6,

        /// <summary>
        /// Enum FxForwardsDependency for value: FxForwardsDependency
        /// </summary>
        [EnumMember(Value = "FxForwardsDependency")]
        FxForwardsDependency = 7,

        /// <summary>
        /// Enum FxVolDependency for value: FxVolDependency
        /// </summary>
        [EnumMember(Value = "FxVolDependency")]
        FxVolDependency = 8,

        /// <summary>
        /// Enum IndexProjectionDependency for value: IndexProjectionDependency
        /// </summary>
        [EnumMember(Value = "IndexProjectionDependency")]
        IndexProjectionDependency = 9,

        /// <summary>
        /// Enum IrVolDependency for value: IrVolDependency
        /// </summary>
        [EnumMember(Value = "IrVolDependency")]
        IrVolDependency = 10,

        /// <summary>
        /// Enum QuoteDependency for value: QuoteDependency
        /// </summary>
        [EnumMember(Value = "QuoteDependency")]
        QuoteDependency = 11,

        /// <summary>
        /// Enum Vendor for value: Vendor
        /// </summary>
        [EnumMember(Value = "Vendor")]
        Vendor = 12,

        /// <summary>
        /// Enum CalendarDependency for value: CalendarDependency
        /// </summary>
        [EnumMember(Value = "CalendarDependency")]
        CalendarDependency = 13,

        /// <summary>
        /// Enum InflationFixingDependency for value: InflationFixingDependency
        /// </summary>
        [EnumMember(Value = "InflationFixingDependency")]
        InflationFixingDependency = 14
    }

}
