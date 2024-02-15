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
    /// Defines InstrumentType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InstrumentType
    {
        /// <summary>
        /// Enum QuotedSecurity for value: QuotedSecurity
        /// </summary>
        [EnumMember(Value = "QuotedSecurity")]
        QuotedSecurity = 1,

        /// <summary>
        /// Enum InterestRateSwap for value: InterestRateSwap
        /// </summary>
        [EnumMember(Value = "InterestRateSwap")]
        InterestRateSwap = 2,

        /// <summary>
        /// Enum FxForward for value: FxForward
        /// </summary>
        [EnumMember(Value = "FxForward")]
        FxForward = 3,

        /// <summary>
        /// Enum Future for value: Future
        /// </summary>
        [EnumMember(Value = "Future")]
        Future = 4,

        /// <summary>
        /// Enum ExoticInstrument for value: ExoticInstrument
        /// </summary>
        [EnumMember(Value = "ExoticInstrument")]
        ExoticInstrument = 5,

        /// <summary>
        /// Enum FxOption for value: FxOption
        /// </summary>
        [EnumMember(Value = "FxOption")]
        FxOption = 6,

        /// <summary>
        /// Enum CreditDefaultSwap for value: CreditDefaultSwap
        /// </summary>
        [EnumMember(Value = "CreditDefaultSwap")]
        CreditDefaultSwap = 7,

        /// <summary>
        /// Enum InterestRateSwaption for value: InterestRateSwaption
        /// </summary>
        [EnumMember(Value = "InterestRateSwaption")]
        InterestRateSwaption = 8,

        /// <summary>
        /// Enum Bond for value: Bond
        /// </summary>
        [EnumMember(Value = "Bond")]
        Bond = 9,

        /// <summary>
        /// Enum EquityOption for value: EquityOption
        /// </summary>
        [EnumMember(Value = "EquityOption")]
        EquityOption = 10,

        /// <summary>
        /// Enum FixedLeg for value: FixedLeg
        /// </summary>
        [EnumMember(Value = "FixedLeg")]
        FixedLeg = 11,

        /// <summary>
        /// Enum FloatingLeg for value: FloatingLeg
        /// </summary>
        [EnumMember(Value = "FloatingLeg")]
        FloatingLeg = 12,

        /// <summary>
        /// Enum BespokeCashFlowsLeg for value: BespokeCashFlowsLeg
        /// </summary>
        [EnumMember(Value = "BespokeCashFlowsLeg")]
        BespokeCashFlowsLeg = 13,

        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 14,

        /// <summary>
        /// Enum TermDeposit for value: TermDeposit
        /// </summary>
        [EnumMember(Value = "TermDeposit")]
        TermDeposit = 15,

        /// <summary>
        /// Enum ContractForDifference for value: ContractForDifference
        /// </summary>
        [EnumMember(Value = "ContractForDifference")]
        ContractForDifference = 16,

        /// <summary>
        /// Enum EquitySwap for value: EquitySwap
        /// </summary>
        [EnumMember(Value = "EquitySwap")]
        EquitySwap = 17,

        /// <summary>
        /// Enum CashPerpetual for value: CashPerpetual
        /// </summary>
        [EnumMember(Value = "CashPerpetual")]
        CashPerpetual = 18,

        /// <summary>
        /// Enum CapFloor for value: CapFloor
        /// </summary>
        [EnumMember(Value = "CapFloor")]
        CapFloor = 19,

        /// <summary>
        /// Enum CashSettled for value: CashSettled
        /// </summary>
        [EnumMember(Value = "CashSettled")]
        CashSettled = 20,

        /// <summary>
        /// Enum CdsIndex for value: CdsIndex
        /// </summary>
        [EnumMember(Value = "CdsIndex")]
        CdsIndex = 21,

        /// <summary>
        /// Enum Basket for value: Basket
        /// </summary>
        [EnumMember(Value = "Basket")]
        Basket = 22,

        /// <summary>
        /// Enum FundingLeg for value: FundingLeg
        /// </summary>
        [EnumMember(Value = "FundingLeg")]
        FundingLeg = 23,

        /// <summary>
        /// Enum FxSwap for value: FxSwap
        /// </summary>
        [EnumMember(Value = "FxSwap")]
        FxSwap = 24,

        /// <summary>
        /// Enum ForwardRateAgreement for value: ForwardRateAgreement
        /// </summary>
        [EnumMember(Value = "ForwardRateAgreement")]
        ForwardRateAgreement = 25,

        /// <summary>
        /// Enum SimpleInstrument for value: SimpleInstrument
        /// </summary>
        [EnumMember(Value = "SimpleInstrument")]
        SimpleInstrument = 26,

        /// <summary>
        /// Enum Repo for value: Repo
        /// </summary>
        [EnumMember(Value = "Repo")]
        Repo = 27,

        /// <summary>
        /// Enum Equity for value: Equity
        /// </summary>
        [EnumMember(Value = "Equity")]
        Equity = 28,

        /// <summary>
        /// Enum ExchangeTradedOption for value: ExchangeTradedOption
        /// </summary>
        [EnumMember(Value = "ExchangeTradedOption")]
        ExchangeTradedOption = 29,

        /// <summary>
        /// Enum ReferenceInstrument for value: ReferenceInstrument
        /// </summary>
        [EnumMember(Value = "ReferenceInstrument")]
        ReferenceInstrument = 30,

        /// <summary>
        /// Enum ComplexBond for value: ComplexBond
        /// </summary>
        [EnumMember(Value = "ComplexBond")]
        ComplexBond = 31,

        /// <summary>
        /// Enum InflationLinkedBond for value: InflationLinkedBond
        /// </summary>
        [EnumMember(Value = "InflationLinkedBond")]
        InflationLinkedBond = 32,

        /// <summary>
        /// Enum InflationSwap for value: InflationSwap
        /// </summary>
        [EnumMember(Value = "InflationSwap")]
        InflationSwap = 33,

        /// <summary>
        /// Enum SimpleCashFlowLoan for value: SimpleCashFlowLoan
        /// </summary>
        [EnumMember(Value = "SimpleCashFlowLoan")]
        SimpleCashFlowLoan = 34,

        /// <summary>
        /// Enum TotalReturnSwap for value: TotalReturnSwap
        /// </summary>
        [EnumMember(Value = "TotalReturnSwap")]
        TotalReturnSwap = 35,

        /// <summary>
        /// Enum InflationLeg for value: InflationLeg
        /// </summary>
        [EnumMember(Value = "InflationLeg")]
        InflationLeg = 36,

        /// <summary>
        /// Enum FundShareClass for value: FundShareClass
        /// </summary>
        [EnumMember(Value = "FundShareClass")]
        FundShareClass = 37

    }

}
