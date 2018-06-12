// <auto-generated>
// Copyright © 2018 FINBOURNE TECHNOLOGY LTD
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
// </auto-generated>

namespace Finbourne.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class HoldingDto
    {
        /// <summary>
        /// Initializes a new instance of the HoldingDto class.
        /// </summary>
        public HoldingDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HoldingDto class.
        /// </summary>
        /// <param name="holdingType">Type of holding, eg Position, Balance,
        /// CashCommitment, Receivable, ForwardFX</param>
        /// <param name="securityUid">Unique security identifier</param>
        /// <param name="units">Quantity of holding</param>
        /// <param name="settledUnits">Settled quantity of holding</param>
        /// <param name="cost">Book cost of holding in trade currency</param>
        /// <param name="costPortfolioCcy">Book cost of holding in portfolio
        /// currency</param>
        /// <param name="transaction">If this is commitment-type holding, the
        /// transaction behind it</param>
        public HoldingDto(string holdingType, string securityUid = default(string), IList<PropertyDto> properties = default(IList<PropertyDto>), double? units = default(double?), double? settledUnits = default(double?), double? cost = default(double?), double? costPortfolioCcy = default(double?), TradeDto transaction = default(TradeDto))
        {
            SecurityUid = securityUid;
            Properties = properties;
            HoldingType = holdingType;
            Units = units;
            SettledUnits = settledUnits;
            Cost = cost;
            CostPortfolioCcy = costPortfolioCcy;
            Transaction = transaction;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique security identifier
        /// </summary>
        [JsonProperty(PropertyName = "securityUid")]
        public string SecurityUid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IList<PropertyDto> Properties { get; set; }

        /// <summary>
        /// Gets or sets type of holding, eg Position, Balance, CashCommitment,
        /// Receivable, ForwardFX
        /// </summary>
        [JsonProperty(PropertyName = "holdingType")]
        public string HoldingType { get; set; }

        /// <summary>
        /// Gets or sets quantity of holding
        /// </summary>
        [JsonProperty(PropertyName = "units")]
        public double? Units { get; set; }

        /// <summary>
        /// Gets or sets settled quantity of holding
        /// </summary>
        [JsonProperty(PropertyName = "settledUnits")]
        public double? SettledUnits { get; set; }

        /// <summary>
        /// Gets or sets book cost of holding in trade currency
        /// </summary>
        [JsonProperty(PropertyName = "cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// Gets or sets book cost of holding in portfolio currency
        /// </summary>
        [JsonProperty(PropertyName = "costPortfolioCcy")]
        public double? CostPortfolioCcy { get; set; }

        /// <summary>
        /// Gets or sets if this is commitment-type holding, the transaction
        /// behind it
        /// </summary>
        [JsonProperty(PropertyName = "transaction")]
        public TradeDto Transaction { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (HoldingType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HoldingType");
            }
            if (Properties != null)
            {
                foreach (var element in Properties)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Transaction != null)
            {
                Transaction.Validate();
            }
        }
    }
}
