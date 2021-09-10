/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3476
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
    /// TransactionConfigurationMovementData
    /// </summary>
    [DataContract(Name = "TransactionConfigurationMovementData")]
    public partial class TransactionConfigurationMovementData : IEquatable<TransactionConfigurationMovementData>
    {
        /// <summary>
        /// . The available values are: Settlement, Traded, StockMovement, FutureCash, Commitment, Receivable, CashSettlement, CashForward, CashCommitment, CashReceivable, Accrual, CashAccrual, ForwardFx, CashFxForward, UnsettledCashTypes, Carry, CarryAsPnl
        /// </summary>
        /// <value>. The available values are: Settlement, Traded, StockMovement, FutureCash, Commitment, Receivable, CashSettlement, CashForward, CashCommitment, CashReceivable, Accrual, CashAccrual, ForwardFx, CashFxForward, UnsettledCashTypes, Carry, CarryAsPnl</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MovementTypesEnum
        {
            /// <summary>
            /// Enum Settlement for value: Settlement
            /// </summary>
            [EnumMember(Value = "Settlement")]
            Settlement = 1,

            /// <summary>
            /// Enum Traded for value: Traded
            /// </summary>
            [EnumMember(Value = "Traded")]
            Traded = 2,

            /// <summary>
            /// Enum StockMovement for value: StockMovement
            /// </summary>
            [EnumMember(Value = "StockMovement")]
            StockMovement = 3,

            /// <summary>
            /// Enum FutureCash for value: FutureCash
            /// </summary>
            [EnumMember(Value = "FutureCash")]
            FutureCash = 4,

            /// <summary>
            /// Enum Commitment for value: Commitment
            /// </summary>
            [EnumMember(Value = "Commitment")]
            Commitment = 5,

            /// <summary>
            /// Enum Receivable for value: Receivable
            /// </summary>
            [EnumMember(Value = "Receivable")]
            Receivable = 6,

            /// <summary>
            /// Enum CashSettlement for value: CashSettlement
            /// </summary>
            [EnumMember(Value = "CashSettlement")]
            CashSettlement = 7,

            /// <summary>
            /// Enum CashForward for value: CashForward
            /// </summary>
            [EnumMember(Value = "CashForward")]
            CashForward = 8,

            /// <summary>
            /// Enum CashCommitment for value: CashCommitment
            /// </summary>
            [EnumMember(Value = "CashCommitment")]
            CashCommitment = 9,

            /// <summary>
            /// Enum CashReceivable for value: CashReceivable
            /// </summary>
            [EnumMember(Value = "CashReceivable")]
            CashReceivable = 10,

            /// <summary>
            /// Enum Accrual for value: Accrual
            /// </summary>
            [EnumMember(Value = "Accrual")]
            Accrual = 11,

            /// <summary>
            /// Enum CashAccrual for value: CashAccrual
            /// </summary>
            [EnumMember(Value = "CashAccrual")]
            CashAccrual = 12,

            /// <summary>
            /// Enum ForwardFx for value: ForwardFx
            /// </summary>
            [EnumMember(Value = "ForwardFx")]
            ForwardFx = 13,

            /// <summary>
            /// Enum CashFxForward for value: CashFxForward
            /// </summary>
            [EnumMember(Value = "CashFxForward")]
            CashFxForward = 14,

            /// <summary>
            /// Enum UnsettledCashTypes for value: UnsettledCashTypes
            /// </summary>
            [EnumMember(Value = "UnsettledCashTypes")]
            UnsettledCashTypes = 15,

            /// <summary>
            /// Enum Carry for value: Carry
            /// </summary>
            [EnumMember(Value = "Carry")]
            Carry = 16,

            /// <summary>
            /// Enum CarryAsPnl for value: CarryAsPnl
            /// </summary>
            [EnumMember(Value = "CarryAsPnl")]
            CarryAsPnl = 17

        }


        /// <summary>
        /// . The available values are: Settlement, Traded, StockMovement, FutureCash, Commitment, Receivable, CashSettlement, CashForward, CashCommitment, CashReceivable, Accrual, CashAccrual, ForwardFx, CashFxForward, UnsettledCashTypes, Carry, CarryAsPnl
        /// </summary>
        /// <value>. The available values are: Settlement, Traded, StockMovement, FutureCash, Commitment, Receivable, CashSettlement, CashForward, CashCommitment, CashReceivable, Accrual, CashAccrual, ForwardFx, CashFxForward, UnsettledCashTypes, Carry, CarryAsPnl</value>
        [DataMember(Name = "movementTypes", IsRequired = true, EmitDefaultValue = false)]
        public MovementTypesEnum MovementTypes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionConfigurationMovementData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionConfigurationMovementData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionConfigurationMovementData" /> class.
        /// </summary>
        /// <param name="movementTypes">. The available values are: Settlement, Traded, StockMovement, FutureCash, Commitment, Receivable, CashSettlement, CashForward, CashCommitment, CashReceivable, Accrual, CashAccrual, ForwardFx, CashFxForward, UnsettledCashTypes, Carry, CarryAsPnl (required).</param>
        /// <param name="side">The movement side (required).</param>
        /// <param name="direction">The movement direction (required).</param>
        /// <param name="properties">The properties associated with the underlying Movement..</param>
        /// <param name="mappings">This allows you to map a transaction property to a property on the underlying holding..</param>
        /// <param name="name">The movement name (optional).</param>
        public TransactionConfigurationMovementData(MovementTypesEnum movementTypes = default(MovementTypesEnum), string side = default(string), int direction = default(int), Dictionary<string, PerpetualProperty> properties = default(Dictionary<string, PerpetualProperty>), List<TransactionPropertyMapping> mappings = default(List<TransactionPropertyMapping>), string name = default(string))
        {
            this.MovementTypes = movementTypes;
            // to ensure "side" is required (not null)
            this.Side = side ?? throw new ArgumentNullException("side is a required property for TransactionConfigurationMovementData and cannot be null");
            this.Direction = direction;
            this.Properties = properties;
            this.Mappings = mappings;
            this.Name = name;
        }

        /// <summary>
        /// The movement side
        /// </summary>
        /// <value>The movement side</value>
        [DataMember(Name = "side", IsRequired = true, EmitDefaultValue = false)]
        public string Side { get; set; }

        /// <summary>
        /// The movement direction
        /// </summary>
        /// <value>The movement direction</value>
        [DataMember(Name = "direction", IsRequired = true, EmitDefaultValue = true)]
        public int Direction { get; set; }

        /// <summary>
        /// The properties associated with the underlying Movement.
        /// </summary>
        /// <value>The properties associated with the underlying Movement.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, PerpetualProperty> Properties { get; set; }

        /// <summary>
        /// This allows you to map a transaction property to a property on the underlying holding.
        /// </summary>
        /// <value>This allows you to map a transaction property to a property on the underlying holding.</value>
        [DataMember(Name = "mappings", EmitDefaultValue = true)]
        public List<TransactionPropertyMapping> Mappings { get; set; }

        /// <summary>
        /// The movement name (optional)
        /// </summary>
        /// <value>The movement name (optional)</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionConfigurationMovementData {\n");
            sb.Append("  MovementTypes: ").Append(MovementTypes).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Mappings: ").Append(Mappings).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as TransactionConfigurationMovementData);
        }

        /// <summary>
        /// Returns true if TransactionConfigurationMovementData instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionConfigurationMovementData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionConfigurationMovementData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MovementTypes == input.MovementTypes ||
                    this.MovementTypes.Equals(input.MovementTypes)
                ) && 
                (
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
                ) && 
                (
                    this.Direction == input.Direction ||
                    this.Direction.Equals(input.Direction)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Mappings == input.Mappings ||
                    this.Mappings != null &&
                    input.Mappings != null &&
                    this.Mappings.SequenceEqual(input.Mappings)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                hashCode = hashCode * 59 + this.MovementTypes.GetHashCode();
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Mappings != null)
                    hashCode = hashCode * 59 + this.Mappings.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }
}
