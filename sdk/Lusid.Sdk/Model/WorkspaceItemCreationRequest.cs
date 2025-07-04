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
    /// A request to create an item in a workspace.
    /// </summary>
    [DataContract(Name = "WorkspaceItemCreationRequest")]
    public partial class WorkspaceItemCreationRequest : IEquatable<WorkspaceItemCreationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceItemCreationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkspaceItemCreationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceItemCreationRequest" /> class.
        /// </summary>
        /// <param name="format">A simple integer format identifier. (required).</param>
        /// <param name="name">A workspace item&#39;s name. (required).</param>
        /// <param name="group">The group containing a workspace item. (required).</param>
        /// <param name="description">The description of a workspace item. (required).</param>
        /// <param name="content">The content associated with a workspace item. (required).</param>
        /// <param name="type">The type of the workspace item. (required).</param>
        public WorkspaceItemCreationRequest(int format = default(int), string name = default(string), string group = default(string), string description = default(string), Object content = default(Object), string type = default(string))
        {
            this.Format = format;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for WorkspaceItemCreationRequest and cannot be null");
            }
            this.Name = name;
            // to ensure "group" is required (not null)
            if (group == null)
            {
                throw new ArgumentNullException("group is a required property for WorkspaceItemCreationRequest and cannot be null");
            }
            this.Group = group;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for WorkspaceItemCreationRequest and cannot be null");
            }
            this.Description = description;
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new ArgumentNullException("content is a required property for WorkspaceItemCreationRequest and cannot be null");
            }
            this.Content = content;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for WorkspaceItemCreationRequest and cannot be null");
            }
            this.Type = type;
        }

        /// <summary>
        /// A simple integer format identifier.
        /// </summary>
        /// <value>A simple integer format identifier.</value>
        [DataMember(Name = "format", IsRequired = true, EmitDefaultValue = true)]
        public int Format { get; set; }

        /// <summary>
        /// A workspace item&#39;s name.
        /// </summary>
        /// <value>A workspace item&#39;s name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The group containing a workspace item.
        /// </summary>
        /// <value>The group containing a workspace item.</value>
        [DataMember(Name = "group", IsRequired = true, EmitDefaultValue = true)]
        public string Group { get; set; }

        /// <summary>
        /// The description of a workspace item.
        /// </summary>
        /// <value>The description of a workspace item.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The content associated with a workspace item.
        /// </summary>
        /// <value>The content associated with a workspace item.</value>
        [DataMember(Name = "content", IsRequired = true, EmitDefaultValue = true)]
        public Object Content { get; set; }

        /// <summary>
        /// The type of the workspace item.
        /// </summary>
        /// <value>The type of the workspace item.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkspaceItemCreationRequest {\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as WorkspaceItemCreationRequest);
        }

        /// <summary>
        /// Returns true if WorkspaceItemCreationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkspaceItemCreationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceItemCreationRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Format == input.Format ||
                    this.Format.Equals(input.Format)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                hashCode = (hashCode * 59) + this.Format.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Group != null)
                {
                    hashCode = (hashCode * 59) + this.Group.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 64.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Name (string) pattern
            Regex regexName = new Regex(@"^[^/]+$", RegexOptions.CultureInvariant);
            if (false == regexName.Match(this.Name).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
            }

            // Group (string) maxLength
            if (this.Group != null && this.Group.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Group, length must be less than 64.", new [] { "Group" });
            }

            // Group (string) minLength
            if (this.Group != null && this.Group.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Group, length must be greater than 1.", new [] { "Group" });
            }

            // Group (string) pattern
            Regex regexGroup = new Regex(@"^[a-zA-Z0-9\-_]+$", RegexOptions.CultureInvariant);
            if (false == regexGroup.Match(this.Group).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Group, must match a pattern of " + regexGroup, new [] { "Group" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 1024.", new [] { "Description" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
            }

            // Description (string) pattern
            Regex regexDescription = new Regex(@"^[\s\S]*$", RegexOptions.CultureInvariant);
            if (false == regexDescription.Match(this.Description).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, must match a pattern of " + regexDescription, new [] { "Description" });
            }

            // Type (string) minLength
            if (this.Type != null && this.Type.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, length must be greater than 1.", new [] { "Type" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^(luminesce-saved-query|lusid-web-dashboard|lusid-web-dashboard-set|mesa-dashboard|lusid-web-favourites)$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
