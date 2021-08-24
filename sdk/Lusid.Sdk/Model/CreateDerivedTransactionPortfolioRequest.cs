/* 
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3419
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
    /// CreateDerivedTransactionPortfolioRequest
    /// </summary>
    [DataContract]
    public partial class CreateDerivedTransactionPortfolioRequest :  IEquatable<CreateDerivedTransactionPortfolioRequest>
    {
        /// <summary>
        /// The available values are: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst
        /// </summary>
        /// <value>The available values are: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountingMethodEnum
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
            LowestCostFirst = 6

        }

        /// <summary>
        /// The available values are: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst
        /// </summary>
        /// <value>The available values are: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst</value>
        [DataMember(Name="accountingMethod", EmitDefaultValue=false)]
        public AccountingMethodEnum? AccountingMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDerivedTransactionPortfolioRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateDerivedTransactionPortfolioRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDerivedTransactionPortfolioRequest" /> class.
        /// </summary>
        /// <param name="displayName">displayName (required).</param>
        /// <param name="description">description.</param>
        /// <param name="code">code (required).</param>
        /// <param name="parentPortfolioId">parentPortfolioId (required).</param>
        /// <param name="created">created.</param>
        /// <param name="corporateActionSourceId">corporateActionSourceId.</param>
        /// <param name="accountingMethod">The available values are: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst.</param>
        /// <param name="subHoldingKeys">subHoldingKeys.</param>
        public CreateDerivedTransactionPortfolioRequest(string displayName = default(string), string description = default(string), string code = default(string), ResourceId parentPortfolioId = default(ResourceId), DateTimeOffset? created = default(DateTimeOffset?), ResourceId corporateActionSourceId = default(ResourceId), AccountingMethodEnum? accountingMethod = default(AccountingMethodEnum?), List<string> subHoldingKeys = default(List<string>))
        {
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for CreateDerivedTransactionPortfolioRequest and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }
            
            this.Description = description;
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for CreateDerivedTransactionPortfolioRequest and cannot be null");
            }
            else
            {
                this.Code = code;
            }
            
            // to ensure "parentPortfolioId" is required (not null)
            if (parentPortfolioId == null)
            {
                throw new InvalidDataException("parentPortfolioId is a required property for CreateDerivedTransactionPortfolioRequest and cannot be null");
            }
            else
            {
                this.ParentPortfolioId = parentPortfolioId;
            }
            
            this.Created = created;
            this.SubHoldingKeys = subHoldingKeys;
            this.Description = description;
            this.Created = created;
            this.CorporateActionSourceId = corporateActionSourceId;
            this.AccountingMethod = accountingMethod;
            this.SubHoldingKeys = subHoldingKeys;
        }
        
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets ParentPortfolioId
        /// </summary>
        [DataMember(Name="parentPortfolioId", EmitDefaultValue=false)]
        public ResourceId ParentPortfolioId { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=true)]
        public DateTimeOffset? Created { get; set; }

        /// <summary>
        /// Gets or Sets CorporateActionSourceId
        /// </summary>
        [DataMember(Name="corporateActionSourceId", EmitDefaultValue=false)]
        public ResourceId CorporateActionSourceId { get; set; }


        /// <summary>
        /// Gets or Sets SubHoldingKeys
        /// </summary>
        [DataMember(Name="subHoldingKeys", EmitDefaultValue=true)]
        public List<string> SubHoldingKeys { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDerivedTransactionPortfolioRequest {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  ParentPortfolioId: ").Append(ParentPortfolioId).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CorporateActionSourceId: ").Append(CorporateActionSourceId).Append("\n");
            sb.Append("  AccountingMethod: ").Append(AccountingMethod).Append("\n");
            sb.Append("  SubHoldingKeys: ").Append(SubHoldingKeys).Append("\n");
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
            return this.Equals(input as CreateDerivedTransactionPortfolioRequest);
        }

        /// <summary>
        /// Returns true if CreateDerivedTransactionPortfolioRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateDerivedTransactionPortfolioRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDerivedTransactionPortfolioRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.ParentPortfolioId == input.ParentPortfolioId ||
                    (this.ParentPortfolioId != null &&
                    this.ParentPortfolioId.Equals(input.ParentPortfolioId))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.CorporateActionSourceId == input.CorporateActionSourceId ||
                    (this.CorporateActionSourceId != null &&
                    this.CorporateActionSourceId.Equals(input.CorporateActionSourceId))
                ) && 
                (
                    this.AccountingMethod == input.AccountingMethod ||
                    (this.AccountingMethod != null &&
                    this.AccountingMethod.Equals(input.AccountingMethod))
                ) && 
                (
                    this.SubHoldingKeys == input.SubHoldingKeys ||
                    this.SubHoldingKeys != null &&
                    input.SubHoldingKeys != null &&
                    this.SubHoldingKeys.SequenceEqual(input.SubHoldingKeys)
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.ParentPortfolioId != null)
                    hashCode = hashCode * 59 + this.ParentPortfolioId.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.CorporateActionSourceId != null)
                    hashCode = hashCode * 59 + this.CorporateActionSourceId.GetHashCode();
                if (this.AccountingMethod != null)
                    hashCode = hashCode * 59 + this.AccountingMethod.GetHashCode();
                if (this.SubHoldingKeys != null)
                    hashCode = hashCode * 59 + this.SubHoldingKeys.GetHashCode();
                return hashCode;
            }
        }
    }

}
