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
    /// When importing data from an external data source, in order for it to be reliable queryable, LUSID needs to know something about it.  A data definition tells LUSID, what a given external data item is, what type it is and whether it in some way identifies items of data.  Consider presenting LUSID with a list of dictionaries where each dictionary contains the same set of keys (names). Each data item pointed to by  a key would be expected to be of the same type (integer, string, decimal etc.). To identify a particular dictionary from the list, a tuple of  one or more of the items in the dictionary would make it unique. If only a single item is required then the
    /// </summary>
    [DataContract(Name = "DataDefinition")]
    public partial class DataDefinition : IEquatable<DataDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DataDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataDefinition" /> class.
        /// </summary>
        /// <param name="address">The internal address (LUSID native) of the unit in the provided data itself and corresponds to the external name of the data item (required).</param>
        /// <param name="name">The name of the data item. This is the name that will appear.</param>
        /// <param name="dataType">A member of the set of possible data types, that all data passed under that key is expected to be of.  Currently limited to one of [string, integer, decimal, result0d]..</param>
        /// <param name="keyType">Is the item either a unique key for the dictionary, i.e. does it identify a unique index or conceptual &#39;row&#39; within the list of dictionaries,  or a partial key or is it simply a data item within that dictionary. Must be one of [Unique,PartOfUnique,Leaf, CompositeLeaf].</param>
        /// <param name="allowNull">The path to the field must exist (unless AllowMissing is true) but the actual value is allowed to be null..</param>
        /// <param name="allowMissing">The path (or column) is allowed to be missing but if it is present it is not allowed to be null unless AllowNull is true..</param>
        public DataDefinition(string address = default(string), string name = default(string), string dataType = default(string), string keyType = default(string), bool allowNull = default(bool), bool allowMissing = default(bool))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for DataDefinition and cannot be null");
            }
            this.Address = address;
            this.Name = name;
            this.DataType = dataType;
            this.KeyType = keyType;
            this.AllowNull = allowNull;
            this.AllowMissing = allowMissing;
        }

        /// <summary>
        /// The internal address (LUSID native) of the unit in the provided data itself and corresponds to the external name of the data item
        /// </summary>
        /// <value>The internal address (LUSID native) of the unit in the provided data itself and corresponds to the external name of the data item</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// The name of the data item. This is the name that will appear
        /// </summary>
        /// <value>The name of the data item. This is the name that will appear</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// A member of the set of possible data types, that all data passed under that key is expected to be of.  Currently limited to one of [string, integer, decimal, result0d].
        /// </summary>
        /// <value>A member of the set of possible data types, that all data passed under that key is expected to be of.  Currently limited to one of [string, integer, decimal, result0d].</value>
        [DataMember(Name = "dataType", EmitDefaultValue = true)]
        public string DataType { get; set; }

        /// <summary>
        /// Is the item either a unique key for the dictionary, i.e. does it identify a unique index or conceptual &#39;row&#39; within the list of dictionaries,  or a partial key or is it simply a data item within that dictionary. Must be one of [Unique,PartOfUnique,Leaf, CompositeLeaf]
        /// </summary>
        /// <value>Is the item either a unique key for the dictionary, i.e. does it identify a unique index or conceptual &#39;row&#39; within the list of dictionaries,  or a partial key or is it simply a data item within that dictionary. Must be one of [Unique,PartOfUnique,Leaf, CompositeLeaf]</value>
        [DataMember(Name = "keyType", EmitDefaultValue = true)]
        public string KeyType { get; set; }

        /// <summary>
        /// The path to the field must exist (unless AllowMissing is true) but the actual value is allowed to be null.
        /// </summary>
        /// <value>The path to the field must exist (unless AllowMissing is true) but the actual value is allowed to be null.</value>
        [DataMember(Name = "allowNull", EmitDefaultValue = true)]
        public bool AllowNull { get; set; }

        /// <summary>
        /// The path (or column) is allowed to be missing but if it is present it is not allowed to be null unless AllowNull is true.
        /// </summary>
        /// <value>The path (or column) is allowed to be missing but if it is present it is not allowed to be null unless AllowNull is true.</value>
        [DataMember(Name = "allowMissing", EmitDefaultValue = true)]
        public bool AllowMissing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataDefinition {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  KeyType: ").Append(KeyType).Append("\n");
            sb.Append("  AllowNull: ").Append(AllowNull).Append("\n");
            sb.Append("  AllowMissing: ").Append(AllowMissing).Append("\n");
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
            return this.Equals(input as DataDefinition);
        }

        /// <summary>
        /// Returns true if DataDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DataDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) && 
                (
                    this.KeyType == input.KeyType ||
                    (this.KeyType != null &&
                    this.KeyType.Equals(input.KeyType))
                ) && 
                (
                    this.AllowNull == input.AllowNull ||
                    this.AllowNull.Equals(input.AllowNull)
                ) && 
                (
                    this.AllowMissing == input.AllowMissing ||
                    this.AllowMissing.Equals(input.AllowMissing)
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.DataType != null)
                {
                    hashCode = (hashCode * 59) + this.DataType.GetHashCode();
                }
                if (this.KeyType != null)
                {
                    hashCode = (hashCode * 59) + this.KeyType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AllowNull.GetHashCode();
                hashCode = (hashCode * 59) + this.AllowMissing.GetHashCode();
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
            if (this.Name != null && this.Name.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 256.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Name (string) pattern
            Regex regexName = new Regex(@"^[a-zA-Z0-9\-_]+$", RegexOptions.CultureInvariant);
            if (false == regexName.Match(this.Name).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
            }

            // DataType (string) maxLength
            if (this.DataType != null && this.DataType.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DataType, length must be less than 128.", new [] { "DataType" });
            }

            // DataType (string) minLength
            if (this.DataType != null && this.DataType.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DataType, length must be greater than 0.", new [] { "DataType" });
            }

            // KeyType (string) maxLength
            if (this.KeyType != null && this.KeyType.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for KeyType, length must be less than 128.", new [] { "KeyType" });
            }

            // KeyType (string) minLength
            if (this.KeyType != null && this.KeyType.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for KeyType, length must be greater than 0.", new [] { "KeyType" });
            }

            yield break;
        }
    }
}
