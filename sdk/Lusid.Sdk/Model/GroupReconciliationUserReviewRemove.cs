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
    /// GroupReconciliationUserReviewRemove
    /// </summary>
    [DataContract(Name = "GroupReconciliationUserReviewRemove")]
    public partial class GroupReconciliationUserReviewRemove : IEquatable<GroupReconciliationUserReviewRemove>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupReconciliationUserReviewRemove" /> class.
        /// </summary>
        /// <param name="breakCodeAsAtAdded">The timestamp of the added User Review input..</param>
        /// <param name="matchKeyAsAtAdded">The timestamp of the added User Review input..</param>
        /// <param name="commentTextAsAtAdded">The timestamp of the added User Review input..</param>
        public GroupReconciliationUserReviewRemove(DateTimeOffset? breakCodeAsAtAdded = default(DateTimeOffset?), DateTimeOffset? matchKeyAsAtAdded = default(DateTimeOffset?), DateTimeOffset? commentTextAsAtAdded = default(DateTimeOffset?))
        {
            this.BreakCodeAsAtAdded = breakCodeAsAtAdded;
            this.MatchKeyAsAtAdded = matchKeyAsAtAdded;
            this.CommentTextAsAtAdded = commentTextAsAtAdded;
        }

        /// <summary>
        /// The timestamp of the added User Review input.
        /// </summary>
        /// <value>The timestamp of the added User Review input.</value>
        [DataMember(Name = "breakCodeAsAtAdded", EmitDefaultValue = true)]
        public DateTimeOffset? BreakCodeAsAtAdded { get; set; }

        /// <summary>
        /// The timestamp of the added User Review input.
        /// </summary>
        /// <value>The timestamp of the added User Review input.</value>
        [DataMember(Name = "matchKeyAsAtAdded", EmitDefaultValue = true)]
        public DateTimeOffset? MatchKeyAsAtAdded { get; set; }

        /// <summary>
        /// The timestamp of the added User Review input.
        /// </summary>
        /// <value>The timestamp of the added User Review input.</value>
        [DataMember(Name = "commentTextAsAtAdded", EmitDefaultValue = true)]
        public DateTimeOffset? CommentTextAsAtAdded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupReconciliationUserReviewRemove {\n");
            sb.Append("  BreakCodeAsAtAdded: ").Append(BreakCodeAsAtAdded).Append("\n");
            sb.Append("  MatchKeyAsAtAdded: ").Append(MatchKeyAsAtAdded).Append("\n");
            sb.Append("  CommentTextAsAtAdded: ").Append(CommentTextAsAtAdded).Append("\n");
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
            return this.Equals(input as GroupReconciliationUserReviewRemove);
        }

        /// <summary>
        /// Returns true if GroupReconciliationUserReviewRemove instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupReconciliationUserReviewRemove to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupReconciliationUserReviewRemove input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BreakCodeAsAtAdded == input.BreakCodeAsAtAdded ||
                    (this.BreakCodeAsAtAdded != null &&
                    this.BreakCodeAsAtAdded.Equals(input.BreakCodeAsAtAdded))
                ) && 
                (
                    this.MatchKeyAsAtAdded == input.MatchKeyAsAtAdded ||
                    (this.MatchKeyAsAtAdded != null &&
                    this.MatchKeyAsAtAdded.Equals(input.MatchKeyAsAtAdded))
                ) && 
                (
                    this.CommentTextAsAtAdded == input.CommentTextAsAtAdded ||
                    (this.CommentTextAsAtAdded != null &&
                    this.CommentTextAsAtAdded.Equals(input.CommentTextAsAtAdded))
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
                if (this.BreakCodeAsAtAdded != null)
                {
                    hashCode = (hashCode * 59) + this.BreakCodeAsAtAdded.GetHashCode();
                }
                if (this.MatchKeyAsAtAdded != null)
                {
                    hashCode = (hashCode * 59) + this.MatchKeyAsAtAdded.GetHashCode();
                }
                if (this.CommentTextAsAtAdded != null)
                {
                    hashCode = (hashCode * 59) + this.CommentTextAsAtAdded.GetHashCode();
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
