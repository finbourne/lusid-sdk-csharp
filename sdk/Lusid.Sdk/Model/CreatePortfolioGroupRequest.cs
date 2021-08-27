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
    /// CreatePortfolioGroupRequest
    /// </summary>
    [DataContract]
    public partial class CreatePortfolioGroupRequest :  IEquatable<CreatePortfolioGroupRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePortfolioGroupRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreatePortfolioGroupRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePortfolioGroupRequest" /> class.
        /// </summary>
        /// <param name="code">The code that the portfolio group will be created with. Together with the scope this uniquely identifies the portfolio group. (required).</param>
        /// <param name="created">The effective datetime at which the portfolio group was created. Defaults to the current LUSID system datetime if not specified..</param>
        /// <param name="values">The resource identifiers of the portfolios to be contained within the portfolio group..</param>
        /// <param name="subGroups">The resource identifiers of the portfolio groups to be contained within the portfolio group as sub groups..</param>
        /// <param name="properties">A set of unique group properties to add to the portfolio group. Each property must be from the &#39;PortfolioGroup&#39; domain and should be identified by its key which has the format {domain}/{scope}/{code}, e.g. &#39;PortfolioGroup/Manager/Id&#39;. These properties must be pre-defined..</param>
        /// <param name="displayName">The name of the portfolio group. (required).</param>
        /// <param name="description">A long form description of the portfolio group..</param>
        public CreatePortfolioGroupRequest(string code = default(string), DateTimeOffset? created = default(DateTimeOffset?), List<ResourceId> values = default(List<ResourceId>), List<ResourceId> subGroups = default(List<ResourceId>), Dictionary<string, Property> properties = default(Dictionary<string, Property>), string displayName = default(string), string description = default(string))
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for CreatePortfolioGroupRequest and cannot be null");
            }
            else
            {
                this.Code = code;
            }
            
            this.Created = created;
            this.Values = values;
            this.SubGroups = subGroups;
            this.Properties = properties;
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for CreatePortfolioGroupRequest and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }
            
            this.Description = description;
            this.Created = created;
            this.Values = values;
            this.SubGroups = subGroups;
            this.Properties = properties;
            this.Description = description;
        }
        
        /// <summary>
        /// The code that the portfolio group will be created with. Together with the scope this uniquely identifies the portfolio group.
        /// </summary>
        /// <value>The code that the portfolio group will be created with. Together with the scope this uniquely identifies the portfolio group.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The effective datetime at which the portfolio group was created. Defaults to the current LUSID system datetime if not specified.
        /// </summary>
        /// <value>The effective datetime at which the portfolio group was created. Defaults to the current LUSID system datetime if not specified.</value>
        [DataMember(Name="created", EmitDefaultValue=true)]
        public DateTimeOffset? Created { get; set; }

        /// <summary>
        /// The resource identifiers of the portfolios to be contained within the portfolio group.
        /// </summary>
        /// <value>The resource identifiers of the portfolios to be contained within the portfolio group.</value>
        [DataMember(Name="values", EmitDefaultValue=true)]
        public List<ResourceId> Values { get; set; }

        /// <summary>
        /// The resource identifiers of the portfolio groups to be contained within the portfolio group as sub groups.
        /// </summary>
        /// <value>The resource identifiers of the portfolio groups to be contained within the portfolio group as sub groups.</value>
        [DataMember(Name="subGroups", EmitDefaultValue=true)]
        public List<ResourceId> SubGroups { get; set; }

        /// <summary>
        /// A set of unique group properties to add to the portfolio group. Each property must be from the &#39;PortfolioGroup&#39; domain and should be identified by its key which has the format {domain}/{scope}/{code}, e.g. &#39;PortfolioGroup/Manager/Id&#39;. These properties must be pre-defined.
        /// </summary>
        /// <value>A set of unique group properties to add to the portfolio group. Each property must be from the &#39;PortfolioGroup&#39; domain and should be identified by its key which has the format {domain}/{scope}/{code}, e.g. &#39;PortfolioGroup/Manager/Id&#39;. These properties must be pre-defined.</value>
        [DataMember(Name="properties", EmitDefaultValue=true)]
        public Dictionary<string, Property> Properties { get; set; }

        /// <summary>
        /// The name of the portfolio group.
        /// </summary>
        /// <value>The name of the portfolio group.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// A long form description of the portfolio group.
        /// </summary>
        /// <value>A long form description of the portfolio group.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePortfolioGroupRequest {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  SubGroups: ").Append(SubGroups).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as CreatePortfolioGroupRequest);
        }

        /// <summary>
        /// Returns true if CreatePortfolioGroupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePortfolioGroupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePortfolioGroupRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.SubGroups == input.SubGroups ||
                    this.SubGroups != null &&
                    input.SubGroups != null &&
                    this.SubGroups.SequenceEqual(input.SubGroups)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.SubGroups != null)
                    hashCode = hashCode * 59 + this.SubGroups.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }

}
