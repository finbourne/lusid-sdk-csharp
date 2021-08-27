/* 
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3438
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// The target holdings.
    /// </summary>
    [DataContract]
    public partial class HoldingAdjustment :  IEquatable<HoldingAdjustment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HoldingAdjustment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HoldingAdjustment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HoldingAdjustment" /> class.
        /// </summary>
        /// <param name="instrumentIdentifiers">A set of instrument identifiers that can resolve the holding adjustment to a unique instrument..</param>
        /// <param name="instrumentUid">The unqiue Lusid Instrument Id (LUID) of the instrument that the holding adjustment is in. (required).</param>
        /// <param name="subHoldingKeys">The set of unique transaction properties and associated values stored with the holding adjustment transactions automatically created by LUSID. Each property will be from the &#39;Transaction&#39; domain..</param>
        /// <param name="properties">The set of unique holding properties and associated values stored with the target holding. Each property will be from the &#39;Holding&#39; domain..</param>
        /// <param name="taxLots">The tax-lots that together make up the target holding. (required).</param>
        /// <param name="currency">The Holding currency..</param>
        public HoldingAdjustment(Dictionary<string, string> instrumentIdentifiers = default(Dictionary<string, string>), string instrumentUid = default(string), Dictionary<string, PerpetualProperty> subHoldingKeys = default(Dictionary<string, PerpetualProperty>), Dictionary<string, PerpetualProperty> properties = default(Dictionary<string, PerpetualProperty>), List<TargetTaxLot> taxLots = default(List<TargetTaxLot>), string currency = default(string))
        {
            this.InstrumentIdentifiers = instrumentIdentifiers;
            // to ensure "instrumentUid" is required (not null)
            if (instrumentUid == null)
            {
                throw new InvalidDataException("instrumentUid is a required property for HoldingAdjustment and cannot be null");
            }
            else
            {
                this.InstrumentUid = instrumentUid;
            }
            
            this.SubHoldingKeys = subHoldingKeys;
            this.Properties = properties;
            // to ensure "taxLots" is required (not null)
            if (taxLots == null)
            {
                throw new InvalidDataException("taxLots is a required property for HoldingAdjustment and cannot be null");
            }
            else
            {
                this.TaxLots = taxLots;
            }
            
            this.Currency = currency;
            this.InstrumentIdentifiers = instrumentIdentifiers;
            this.SubHoldingKeys = subHoldingKeys;
            this.Properties = properties;
            this.Currency = currency;
        }
        
        /// <summary>
        /// A set of instrument identifiers that can resolve the holding adjustment to a unique instrument.
        /// </summary>
        /// <value>A set of instrument identifiers that can resolve the holding adjustment to a unique instrument.</value>
        [DataMember(Name="instrumentIdentifiers", EmitDefaultValue=true)]
        public Dictionary<string, string> InstrumentIdentifiers { get; set; }

        /// <summary>
        /// The unqiue Lusid Instrument Id (LUID) of the instrument that the holding adjustment is in.
        /// </summary>
        /// <value>The unqiue Lusid Instrument Id (LUID) of the instrument that the holding adjustment is in.</value>
        [DataMember(Name="instrumentUid", EmitDefaultValue=false)]
        public string InstrumentUid { get; set; }

        /// <summary>
        /// The set of unique transaction properties and associated values stored with the holding adjustment transactions automatically created by LUSID. Each property will be from the &#39;Transaction&#39; domain.
        /// </summary>
        /// <value>The set of unique transaction properties and associated values stored with the holding adjustment transactions automatically created by LUSID. Each property will be from the &#39;Transaction&#39; domain.</value>
        [DataMember(Name="subHoldingKeys", EmitDefaultValue=true)]
        public Dictionary<string, PerpetualProperty> SubHoldingKeys { get; set; }

        /// <summary>
        /// The set of unique holding properties and associated values stored with the target holding. Each property will be from the &#39;Holding&#39; domain.
        /// </summary>
        /// <value>The set of unique holding properties and associated values stored with the target holding. Each property will be from the &#39;Holding&#39; domain.</value>
        [DataMember(Name="properties", EmitDefaultValue=true)]
        public Dictionary<string, PerpetualProperty> Properties { get; set; }

        /// <summary>
        /// The tax-lots that together make up the target holding.
        /// </summary>
        /// <value>The tax-lots that together make up the target holding.</value>
        [DataMember(Name="taxLots", EmitDefaultValue=false)]
        public List<TargetTaxLot> TaxLots { get; set; }

        /// <summary>
        /// The Holding currency.
        /// </summary>
        /// <value>The Holding currency.</value>
        [DataMember(Name="currency", EmitDefaultValue=true)]
        public string Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HoldingAdjustment {\n");
            sb.Append("  InstrumentIdentifiers: ").Append(InstrumentIdentifiers).Append("\n");
            sb.Append("  InstrumentUid: ").Append(InstrumentUid).Append("\n");
            sb.Append("  SubHoldingKeys: ").Append(SubHoldingKeys).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  TaxLots: ").Append(TaxLots).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as HoldingAdjustment);
        }

        /// <summary>
        /// Returns true if HoldingAdjustment instances are equal
        /// </summary>
        /// <param name="input">Instance of HoldingAdjustment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HoldingAdjustment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstrumentIdentifiers == input.InstrumentIdentifiers ||
                    this.InstrumentIdentifiers != null &&
                    input.InstrumentIdentifiers != null &&
                    this.InstrumentIdentifiers.SequenceEqual(input.InstrumentIdentifiers)
                ) && 
                (
                    this.InstrumentUid == input.InstrumentUid ||
                    (this.InstrumentUid != null &&
                    this.InstrumentUid.Equals(input.InstrumentUid))
                ) && 
                (
                    this.SubHoldingKeys == input.SubHoldingKeys ||
                    this.SubHoldingKeys != null &&
                    input.SubHoldingKeys != null &&
                    this.SubHoldingKeys.SequenceEqual(input.SubHoldingKeys)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.TaxLots == input.TaxLots ||
                    this.TaxLots != null &&
                    input.TaxLots != null &&
                    this.TaxLots.SequenceEqual(input.TaxLots)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
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
                if (this.InstrumentIdentifiers != null)
                    hashCode = hashCode * 59 + this.InstrumentIdentifiers.GetHashCode();
                if (this.InstrumentUid != null)
                    hashCode = hashCode * 59 + this.InstrumentUid.GetHashCode();
                if (this.SubHoldingKeys != null)
                    hashCode = hashCode * 59 + this.SubHoldingKeys.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.TaxLots != null)
                    hashCode = hashCode * 59 + this.TaxLots.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                return hashCode;
            }
        }
    }

}
