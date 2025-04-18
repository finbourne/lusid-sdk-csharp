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
    /// Defines ComplianceParameterType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ComplianceParameterType
    {
        /// <summary>
        /// Enum BoolComplianceParameter for value: BoolComplianceParameter
        /// </summary>
        [EnumMember(Value = "BoolComplianceParameter")]
        BoolComplianceParameter = 1,

        /// <summary>
        /// Enum StringComplianceParameter for value: StringComplianceParameter
        /// </summary>
        [EnumMember(Value = "StringComplianceParameter")]
        StringComplianceParameter = 2,

        /// <summary>
        /// Enum DecimalComplianceParameter for value: DecimalComplianceParameter
        /// </summary>
        [EnumMember(Value = "DecimalComplianceParameter")]
        DecimalComplianceParameter = 3,

        /// <summary>
        /// Enum DateTimeComplianceParameter for value: DateTimeComplianceParameter
        /// </summary>
        [EnumMember(Value = "DateTimeComplianceParameter")]
        DateTimeComplianceParameter = 4,

        /// <summary>
        /// Enum PropertyKeyComplianceParameter for value: PropertyKeyComplianceParameter
        /// </summary>
        [EnumMember(Value = "PropertyKeyComplianceParameter")]
        PropertyKeyComplianceParameter = 5,

        /// <summary>
        /// Enum AddressKeyComplianceParameter for value: AddressKeyComplianceParameter
        /// </summary>
        [EnumMember(Value = "AddressKeyComplianceParameter")]
        AddressKeyComplianceParameter = 6,

        /// <summary>
        /// Enum PortfolioIdComplianceParameter for value: PortfolioIdComplianceParameter
        /// </summary>
        [EnumMember(Value = "PortfolioIdComplianceParameter")]
        PortfolioIdComplianceParameter = 7,

        /// <summary>
        /// Enum PortfolioGroupIdComplianceParameter for value: PortfolioGroupIdComplianceParameter
        /// </summary>
        [EnumMember(Value = "PortfolioGroupIdComplianceParameter")]
        PortfolioGroupIdComplianceParameter = 8,

        /// <summary>
        /// Enum StringListComplianceParameter for value: StringListComplianceParameter
        /// </summary>
        [EnumMember(Value = "StringListComplianceParameter")]
        StringListComplianceParameter = 9,

        /// <summary>
        /// Enum BoolListComplianceParameter for value: BoolListComplianceParameter
        /// </summary>
        [EnumMember(Value = "BoolListComplianceParameter")]
        BoolListComplianceParameter = 10,

        /// <summary>
        /// Enum DateTimeListComplianceParameter for value: DateTimeListComplianceParameter
        /// </summary>
        [EnumMember(Value = "DateTimeListComplianceParameter")]
        DateTimeListComplianceParameter = 11,

        /// <summary>
        /// Enum DecimalListComplianceParameter for value: DecimalListComplianceParameter
        /// </summary>
        [EnumMember(Value = "DecimalListComplianceParameter")]
        DecimalListComplianceParameter = 12,

        /// <summary>
        /// Enum PropertyKeyListComplianceParameter for value: PropertyKeyListComplianceParameter
        /// </summary>
        [EnumMember(Value = "PropertyKeyListComplianceParameter")]
        PropertyKeyListComplianceParameter = 13,

        /// <summary>
        /// Enum AddressKeyListComplianceParameter for value: AddressKeyListComplianceParameter
        /// </summary>
        [EnumMember(Value = "AddressKeyListComplianceParameter")]
        AddressKeyListComplianceParameter = 14,

        /// <summary>
        /// Enum PortfolioIdListComplianceParameter for value: PortfolioIdListComplianceParameter
        /// </summary>
        [EnumMember(Value = "PortfolioIdListComplianceParameter")]
        PortfolioIdListComplianceParameter = 15,

        /// <summary>
        /// Enum PortfolioGroupIdListComplianceParameter for value: PortfolioGroupIdListComplianceParameter
        /// </summary>
        [EnumMember(Value = "PortfolioGroupIdListComplianceParameter")]
        PortfolioGroupIdListComplianceParameter = 16,

        /// <summary>
        /// Enum InstrumentListComplianceParameter for value: InstrumentListComplianceParameter
        /// </summary>
        [EnumMember(Value = "InstrumentListComplianceParameter")]
        InstrumentListComplianceParameter = 17,

        /// <summary>
        /// Enum FilterPredicateComplianceParameter for value: FilterPredicateComplianceParameter
        /// </summary>
        [EnumMember(Value = "FilterPredicateComplianceParameter")]
        FilterPredicateComplianceParameter = 18,

        /// <summary>
        /// Enum GroupFilterPredicateComplianceParameter for value: GroupFilterPredicateComplianceParameter
        /// </summary>
        [EnumMember(Value = "GroupFilterPredicateComplianceParameter")]
        GroupFilterPredicateComplianceParameter = 19,

        /// <summary>
        /// Enum GroupBySelectorComplianceParameter for value: GroupBySelectorComplianceParameter
        /// </summary>
        [EnumMember(Value = "GroupBySelectorComplianceParameter")]
        GroupBySelectorComplianceParameter = 20,

        /// <summary>
        /// Enum PropertyListComplianceParameter for value: PropertyListComplianceParameter
        /// </summary>
        [EnumMember(Value = "PropertyListComplianceParameter")]
        PropertyListComplianceParameter = 21,

        /// <summary>
        /// Enum GroupCalculationComplianceParameter for value: GroupCalculationComplianceParameter
        /// </summary>
        [EnumMember(Value = "GroupCalculationComplianceParameter")]
        GroupCalculationComplianceParameter = 22
    }

}
