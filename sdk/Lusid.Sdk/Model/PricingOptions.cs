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
    /// Options for controlling the default aspects and behaviour of the pricing engine.
    /// </summary>
    [DataContract(Name = "PricingOptions")]
    public partial class PricingOptions : IEquatable<PricingOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PricingOptions" /> class.
        /// </summary>
        /// <param name="modelSelection">modelSelection.</param>
        /// <param name="useInstrumentTypeToDeterminePricer">If true then use the instrument type to set the default instrument pricer  This applies where no more specific set of overrides are provided on a per-vendor and instrument basis..</param>
        /// <param name="allowAnyInstrumentsWithSecUidToPriceOffLookup">By default, one would not expect to price and exotic instrument, i.e. an instrument with a complicated  instrument definition simply through looking up a price as there should be a better way of evaluating it.  To override that behaviour and allow lookup for a price from the instrument identifier(s), set this to true..</param>
        /// <param name="allowPartiallySuccessfulEvaluation">If true then a failure in task evaluation doesn&#39;t cause overall failure.  results will be returned where they succeeded and annotation elsewhere.</param>
        /// <param name="produceSeparateResultForLinearOtcLegs">If true (default), when pricing an Fx-Forward or Interest Rate Swap, Future and other linearly separable products, product two results, one for each leg  rather than a single line result with the amalgamated/summed pv from both legs..</param>
        /// <param name="enableUseOfCachedUnitResults">If true, when pricing using a model or for an instrument that supports use of intermediate cached-results, use them.  Default is that this caching is turned off..</param>
        /// <param name="windowValuationOnInstrumentStartEnd">If true, when valuing an instrument outside the period where it is &#39;alive&#39; (the start-maturity window) it will return a valuation of zero.</param>
        /// <param name="removeContingentCashflowsInPaymentDiary">When creating a payment diary, should contingent cash payments (e.g. from exercise of a swaption into a swap) be included or not.  i.e. Is exercise or default being assumed to happen or not..</param>
        /// <param name="useChildSubHoldingKeysForPortfolioExpansion">Should fund constituents inherit subholding keys from the parent subholding keyb.</param>
        /// <param name="validateDomesticAndQuoteCurrenciesAreConsistent">Do we validate that the instrument domestic currency matches the quote currency (unless unknown/zzz) when using lookup pricing..</param>
        /// <param name="conservedQuantityForLookthroughExpansion">When performing lookthrough portfolio expansion with ScalingMethodology set to \&quot;Sum\&quot; or \&quot;AbsoluteSum\&quot;,  the quantity specified here will be conserved and apportioned to lookthrough constituents.  For example, an equal-weighting index with 100 constituents can be modelled as a reference portfolio with 1% weights on each equity.  When expanding a $9000 holding of that index into its constituents while conserving PV, we end up with $90 of each equity.  The number of units of each equity held is then implied.  Note that conservation of one quantity may imply non-conservation of others, especially when some constituents are OTCs.                Allowed values are: \&quot;PV\&quot; (default), \&quot;Exposure\&quot;..</param>
        /// <param name="returnZeroPv">returnZeroPv.</param>
        public PricingOptions(ModelSelection modelSelection = default(ModelSelection), bool useInstrumentTypeToDeterminePricer = default(bool), bool allowAnyInstrumentsWithSecUidToPriceOffLookup = default(bool), bool allowPartiallySuccessfulEvaluation = default(bool), bool produceSeparateResultForLinearOtcLegs = default(bool), bool enableUseOfCachedUnitResults = default(bool), bool windowValuationOnInstrumentStartEnd = default(bool), bool removeContingentCashflowsInPaymentDiary = default(bool), bool useChildSubHoldingKeysForPortfolioExpansion = default(bool), bool validateDomesticAndQuoteCurrenciesAreConsistent = default(bool), string conservedQuantityForLookthroughExpansion = default(string), ReturnZeroPvOptions returnZeroPv = default(ReturnZeroPvOptions))
        {
            this.ModelSelection = modelSelection;
            this.UseInstrumentTypeToDeterminePricer = useInstrumentTypeToDeterminePricer;
            this.AllowAnyInstrumentsWithSecUidToPriceOffLookup = allowAnyInstrumentsWithSecUidToPriceOffLookup;
            this.AllowPartiallySuccessfulEvaluation = allowPartiallySuccessfulEvaluation;
            this.ProduceSeparateResultForLinearOtcLegs = produceSeparateResultForLinearOtcLegs;
            this.EnableUseOfCachedUnitResults = enableUseOfCachedUnitResults;
            this.WindowValuationOnInstrumentStartEnd = windowValuationOnInstrumentStartEnd;
            this.RemoveContingentCashflowsInPaymentDiary = removeContingentCashflowsInPaymentDiary;
            this.UseChildSubHoldingKeysForPortfolioExpansion = useChildSubHoldingKeysForPortfolioExpansion;
            this.ValidateDomesticAndQuoteCurrenciesAreConsistent = validateDomesticAndQuoteCurrenciesAreConsistent;
            this.ConservedQuantityForLookthroughExpansion = conservedQuantityForLookthroughExpansion;
            this.ReturnZeroPv = returnZeroPv;
        }

        /// <summary>
        /// Gets or Sets ModelSelection
        /// </summary>
        [DataMember(Name = "modelSelection", EmitDefaultValue = false)]
        public ModelSelection ModelSelection { get; set; }

        /// <summary>
        /// If true then use the instrument type to set the default instrument pricer  This applies where no more specific set of overrides are provided on a per-vendor and instrument basis.
        /// </summary>
        /// <value>If true then use the instrument type to set the default instrument pricer  This applies where no more specific set of overrides are provided on a per-vendor and instrument basis.</value>
        [DataMember(Name = "useInstrumentTypeToDeterminePricer", EmitDefaultValue = true)]
        public bool UseInstrumentTypeToDeterminePricer { get; set; }

        /// <summary>
        /// By default, one would not expect to price and exotic instrument, i.e. an instrument with a complicated  instrument definition simply through looking up a price as there should be a better way of evaluating it.  To override that behaviour and allow lookup for a price from the instrument identifier(s), set this to true.
        /// </summary>
        /// <value>By default, one would not expect to price and exotic instrument, i.e. an instrument with a complicated  instrument definition simply through looking up a price as there should be a better way of evaluating it.  To override that behaviour and allow lookup for a price from the instrument identifier(s), set this to true.</value>
        [DataMember(Name = "allowAnyInstrumentsWithSecUidToPriceOffLookup", EmitDefaultValue = true)]
        public bool AllowAnyInstrumentsWithSecUidToPriceOffLookup { get; set; }

        /// <summary>
        /// If true then a failure in task evaluation doesn&#39;t cause overall failure.  results will be returned where they succeeded and annotation elsewhere
        /// </summary>
        /// <value>If true then a failure in task evaluation doesn&#39;t cause overall failure.  results will be returned where they succeeded and annotation elsewhere</value>
        [DataMember(Name = "allowPartiallySuccessfulEvaluation", EmitDefaultValue = true)]
        public bool AllowPartiallySuccessfulEvaluation { get; set; }

        /// <summary>
        /// If true (default), when pricing an Fx-Forward or Interest Rate Swap, Future and other linearly separable products, product two results, one for each leg  rather than a single line result with the amalgamated/summed pv from both legs.
        /// </summary>
        /// <value>If true (default), when pricing an Fx-Forward or Interest Rate Swap, Future and other linearly separable products, product two results, one for each leg  rather than a single line result with the amalgamated/summed pv from both legs.</value>
        [DataMember(Name = "produceSeparateResultForLinearOtcLegs", EmitDefaultValue = true)]
        public bool ProduceSeparateResultForLinearOtcLegs { get; set; }

        /// <summary>
        /// If true, when pricing using a model or for an instrument that supports use of intermediate cached-results, use them.  Default is that this caching is turned off.
        /// </summary>
        /// <value>If true, when pricing using a model or for an instrument that supports use of intermediate cached-results, use them.  Default is that this caching is turned off.</value>
        [DataMember(Name = "enableUseOfCachedUnitResults", EmitDefaultValue = true)]
        public bool EnableUseOfCachedUnitResults { get; set; }

        /// <summary>
        /// If true, when valuing an instrument outside the period where it is &#39;alive&#39; (the start-maturity window) it will return a valuation of zero
        /// </summary>
        /// <value>If true, when valuing an instrument outside the period where it is &#39;alive&#39; (the start-maturity window) it will return a valuation of zero</value>
        [DataMember(Name = "windowValuationOnInstrumentStartEnd", EmitDefaultValue = true)]
        public bool WindowValuationOnInstrumentStartEnd { get; set; }

        /// <summary>
        /// When creating a payment diary, should contingent cash payments (e.g. from exercise of a swaption into a swap) be included or not.  i.e. Is exercise or default being assumed to happen or not.
        /// </summary>
        /// <value>When creating a payment diary, should contingent cash payments (e.g. from exercise of a swaption into a swap) be included or not.  i.e. Is exercise or default being assumed to happen or not.</value>
        [DataMember(Name = "removeContingentCashflowsInPaymentDiary", EmitDefaultValue = true)]
        public bool RemoveContingentCashflowsInPaymentDiary { get; set; }

        /// <summary>
        /// Should fund constituents inherit subholding keys from the parent subholding keyb
        /// </summary>
        /// <value>Should fund constituents inherit subholding keys from the parent subholding keyb</value>
        [DataMember(Name = "useChildSubHoldingKeysForPortfolioExpansion", EmitDefaultValue = true)]
        public bool UseChildSubHoldingKeysForPortfolioExpansion { get; set; }

        /// <summary>
        /// Do we validate that the instrument domestic currency matches the quote currency (unless unknown/zzz) when using lookup pricing.
        /// </summary>
        /// <value>Do we validate that the instrument domestic currency matches the quote currency (unless unknown/zzz) when using lookup pricing.</value>
        [DataMember(Name = "validateDomesticAndQuoteCurrenciesAreConsistent", EmitDefaultValue = true)]
        public bool ValidateDomesticAndQuoteCurrenciesAreConsistent { get; set; }

        /// <summary>
        /// When performing lookthrough portfolio expansion with ScalingMethodology set to \&quot;Sum\&quot; or \&quot;AbsoluteSum\&quot;,  the quantity specified here will be conserved and apportioned to lookthrough constituents.  For example, an equal-weighting index with 100 constituents can be modelled as a reference portfolio with 1% weights on each equity.  When expanding a $9000 holding of that index into its constituents while conserving PV, we end up with $90 of each equity.  The number of units of each equity held is then implied.  Note that conservation of one quantity may imply non-conservation of others, especially when some constituents are OTCs.                Allowed values are: \&quot;PV\&quot; (default), \&quot;Exposure\&quot;.
        /// </summary>
        /// <value>When performing lookthrough portfolio expansion with ScalingMethodology set to \&quot;Sum\&quot; or \&quot;AbsoluteSum\&quot;,  the quantity specified here will be conserved and apportioned to lookthrough constituents.  For example, an equal-weighting index with 100 constituents can be modelled as a reference portfolio with 1% weights on each equity.  When expanding a $9000 holding of that index into its constituents while conserving PV, we end up with $90 of each equity.  The number of units of each equity held is then implied.  Note that conservation of one quantity may imply non-conservation of others, especially when some constituents are OTCs.                Allowed values are: \&quot;PV\&quot; (default), \&quot;Exposure\&quot;.</value>
        [DataMember(Name = "conservedQuantityForLookthroughExpansion", EmitDefaultValue = true)]
        public string ConservedQuantityForLookthroughExpansion { get; set; }

        /// <summary>
        /// Gets or Sets ReturnZeroPv
        /// </summary>
        [DataMember(Name = "returnZeroPv", EmitDefaultValue = false)]
        public ReturnZeroPvOptions ReturnZeroPv { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PricingOptions {\n");
            sb.Append("  ModelSelection: ").Append(ModelSelection).Append("\n");
            sb.Append("  UseInstrumentTypeToDeterminePricer: ").Append(UseInstrumentTypeToDeterminePricer).Append("\n");
            sb.Append("  AllowAnyInstrumentsWithSecUidToPriceOffLookup: ").Append(AllowAnyInstrumentsWithSecUidToPriceOffLookup).Append("\n");
            sb.Append("  AllowPartiallySuccessfulEvaluation: ").Append(AllowPartiallySuccessfulEvaluation).Append("\n");
            sb.Append("  ProduceSeparateResultForLinearOtcLegs: ").Append(ProduceSeparateResultForLinearOtcLegs).Append("\n");
            sb.Append("  EnableUseOfCachedUnitResults: ").Append(EnableUseOfCachedUnitResults).Append("\n");
            sb.Append("  WindowValuationOnInstrumentStartEnd: ").Append(WindowValuationOnInstrumentStartEnd).Append("\n");
            sb.Append("  RemoveContingentCashflowsInPaymentDiary: ").Append(RemoveContingentCashflowsInPaymentDiary).Append("\n");
            sb.Append("  UseChildSubHoldingKeysForPortfolioExpansion: ").Append(UseChildSubHoldingKeysForPortfolioExpansion).Append("\n");
            sb.Append("  ValidateDomesticAndQuoteCurrenciesAreConsistent: ").Append(ValidateDomesticAndQuoteCurrenciesAreConsistent).Append("\n");
            sb.Append("  ConservedQuantityForLookthroughExpansion: ").Append(ConservedQuantityForLookthroughExpansion).Append("\n");
            sb.Append("  ReturnZeroPv: ").Append(ReturnZeroPv).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PricingOptions);
        }

        /// <summary>
        /// Returns true if PricingOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of PricingOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PricingOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ModelSelection == input.ModelSelection ||
                    (this.ModelSelection != null &&
                    this.ModelSelection.Equals(input.ModelSelection))
                ) && 
                (
                    this.UseInstrumentTypeToDeterminePricer == input.UseInstrumentTypeToDeterminePricer ||
                    this.UseInstrumentTypeToDeterminePricer.Equals(input.UseInstrumentTypeToDeterminePricer)
                ) && 
                (
                    this.AllowAnyInstrumentsWithSecUidToPriceOffLookup == input.AllowAnyInstrumentsWithSecUidToPriceOffLookup ||
                    this.AllowAnyInstrumentsWithSecUidToPriceOffLookup.Equals(input.AllowAnyInstrumentsWithSecUidToPriceOffLookup)
                ) && 
                (
                    this.AllowPartiallySuccessfulEvaluation == input.AllowPartiallySuccessfulEvaluation ||
                    this.AllowPartiallySuccessfulEvaluation.Equals(input.AllowPartiallySuccessfulEvaluation)
                ) && 
                (
                    this.ProduceSeparateResultForLinearOtcLegs == input.ProduceSeparateResultForLinearOtcLegs ||
                    this.ProduceSeparateResultForLinearOtcLegs.Equals(input.ProduceSeparateResultForLinearOtcLegs)
                ) && 
                (
                    this.EnableUseOfCachedUnitResults == input.EnableUseOfCachedUnitResults ||
                    this.EnableUseOfCachedUnitResults.Equals(input.EnableUseOfCachedUnitResults)
                ) && 
                (
                    this.WindowValuationOnInstrumentStartEnd == input.WindowValuationOnInstrumentStartEnd ||
                    this.WindowValuationOnInstrumentStartEnd.Equals(input.WindowValuationOnInstrumentStartEnd)
                ) && 
                (
                    this.RemoveContingentCashflowsInPaymentDiary == input.RemoveContingentCashflowsInPaymentDiary ||
                    this.RemoveContingentCashflowsInPaymentDiary.Equals(input.RemoveContingentCashflowsInPaymentDiary)
                ) && 
                (
                    this.UseChildSubHoldingKeysForPortfolioExpansion == input.UseChildSubHoldingKeysForPortfolioExpansion ||
                    this.UseChildSubHoldingKeysForPortfolioExpansion.Equals(input.UseChildSubHoldingKeysForPortfolioExpansion)
                ) && 
                (
                    this.ValidateDomesticAndQuoteCurrenciesAreConsistent == input.ValidateDomesticAndQuoteCurrenciesAreConsistent ||
                    this.ValidateDomesticAndQuoteCurrenciesAreConsistent.Equals(input.ValidateDomesticAndQuoteCurrenciesAreConsistent)
                ) && 
                (
                    this.ConservedQuantityForLookthroughExpansion == input.ConservedQuantityForLookthroughExpansion ||
                    (this.ConservedQuantityForLookthroughExpansion != null &&
                    this.ConservedQuantityForLookthroughExpansion.Equals(input.ConservedQuantityForLookthroughExpansion))
                ) && 
                (
                    this.ReturnZeroPv == input.ReturnZeroPv ||
                    (this.ReturnZeroPv != null &&
                    this.ReturnZeroPv.Equals(input.ReturnZeroPv))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ModelSelection != null)
                {
                    hashCode = (hashCode * 59) + this.ModelSelection.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UseInstrumentTypeToDeterminePricer.GetHashCode();
                hashCode = (hashCode * 59) + this.AllowAnyInstrumentsWithSecUidToPriceOffLookup.GetHashCode();
                hashCode = (hashCode * 59) + this.AllowPartiallySuccessfulEvaluation.GetHashCode();
                hashCode = (hashCode * 59) + this.ProduceSeparateResultForLinearOtcLegs.GetHashCode();
                hashCode = (hashCode * 59) + this.EnableUseOfCachedUnitResults.GetHashCode();
                hashCode = (hashCode * 59) + this.WindowValuationOnInstrumentStartEnd.GetHashCode();
                hashCode = (hashCode * 59) + this.RemoveContingentCashflowsInPaymentDiary.GetHashCode();
                hashCode = (hashCode * 59) + this.UseChildSubHoldingKeysForPortfolioExpansion.GetHashCode();
                hashCode = (hashCode * 59) + this.ValidateDomesticAndQuoteCurrenciesAreConsistent.GetHashCode();
                if (this.ConservedQuantityForLookthroughExpansion != null)
                {
                    hashCode = (hashCode * 59) + this.ConservedQuantityForLookthroughExpansion.GetHashCode();
                }
                if (this.ReturnZeroPv != null)
                {
                    hashCode = (hashCode * 59) + this.ReturnZeroPv.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
