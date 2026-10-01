# Lusid.Sdk.Model.TransactionConfigurationMovementDataRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MovementTypes** | **string** | The movement types. Available values: Settlement, Traded, StockMovement, FutureCash, Commitment, Receivable, CashSettlement, CashForward, CashCommitment, CashReceivable, Accrual, CashAccrual, ForwardFx, CashFxForward, Carry, CarryAsPnl, VariationMargin, Capital, Fee, LimitAdjustment, BalanceAdjustment, Deferred, CashDeferred. | 
**Side** | **string** | The movement side | 
**Direction** | **int** | The movement direction | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The properties associated with the underlying Movement. | [optional] 
**Mappings** | [**List&lt;TransactionPropertyMappingRequest&gt;**](TransactionPropertyMappingRequest.md) | This allows you to map a transaction property to a property on the underlying holding. | [optional] 
**Name** | **string** | The movement name (optional) | [optional] 
**MovementOptions** | **List&lt;string&gt;** | Allows extra specifications for the movement. The options currently available are &#39;DirectAdjustment&#39;, &#39;IncludesTradedInterest&#39;, &#39;Virtual&#39;, &#39;Income&#39;, &#39;Expense&#39;, &#39;Bought&#39;, &#39;Sold&#39;, &#39;Coupon&#39;, &#39;Dividend&#39;, &#39;Fee&#39; and &#39;Tax&#39;. More than one option may be given. A movement type of &#39;StockMovement&#39; with an option of &#39;DirectAdjusment&#39; will allow you to adjust the units of a holding without affecting its cost base. You will, therefore, be able to reflect the impact of a stock split by loading a Transaction. A movement type of &#39;Carry&#39; with the option as &#39;Expense&#39; will not impact the interest accrual for cash-type holdings such loans, loan facilities and deposits. &#39;Bought&#39; and &#39;Sold&#39; declare the direction of traded interest and are only valid alongside &#39;IncludesTradedInterest&#39; on a &#39;Carry&#39; or &#39;CarryAsPnl&#39; movement; without them the direction is inferred from the sign of the amount. &#39;Coupon&#39; and &#39;Dividend&#39; declare the kind of income and are only valid alongside &#39;Income&#39;. &#39;Fee&#39; and &#39;Tax&#39; declare the kind of charge and are valid on &#39;Fee&#39;, &#39;Capital&#39;, &#39;Carry&#39; and &#39;CarryAsPnl&#39; movements; on a &#39;Carry&#39; or &#39;CarryAsPnl&#39; movement they must be declared alongside &#39;Expense&#39;, and they cannot be combined with &#39;Income&#39; or &#39;IncludesTradedInterest&#39;. &#39;Income&#39;, &#39;Expense&#39; and &#39;IncludesTradedInterest&#39; are mutually exclusive, as are &#39;Bought&#39; and &#39;Sold&#39;, &#39;Coupon&#39; and &#39;Dividend&#39;, and &#39;Fee&#39; and &#39;Tax&#39;. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string movementTypes = "movementTypes";
string side = "side";
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();
List<TransactionPropertyMappingRequest> mappings = new List<TransactionPropertyMappingRequest>();
string name = "example name";
List<string> movementOptions = new List<string>();

TransactionConfigurationMovementDataRequest transactionConfigurationMovementDataRequestInstance = new TransactionConfigurationMovementDataRequest(
    movementTypes: movementTypes,
    side: side,
    direction: direction,
    properties: properties,
    mappings: mappings,
    name: name,
    movementOptions: movementOptions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
