# Lusid.Sdk.Model.MarginRounding
The increment margin calls are rounded to, and the direction for deliveries and returns.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **decimal** | The increment margin calls are rounded to. Must be greater than zero. | 
**Deliveries** | **string** | How amounts we deliver are rounded. One of Up or Nearest. Available values: Up, Down, Nearest. | 
**Returns** | **string** | How amounts we receive back are rounded. One of Down or Nearest. Available values: Up, Down, Nearest. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal amount = "amount";

string deliveries = "deliveries";
string returns = "returns";

MarginRounding marginRoundingInstance = new MarginRounding(
    amount: amount,
    deliveries: deliveries,
    returns: returns);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
