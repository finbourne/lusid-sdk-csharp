# Lusid.Sdk.Model.ListComplexMarketDataWithMetaDataResponse
Wraps a ComplexMarketData object with information that was retrieved from storage with it.  In particular,  the scope that the data was stored in,  and an object identifying the market data in that scope.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | The scope that the listed ComplexMarketData entity is stored in. | [optional] 
**MarketDataId** | [**ComplexMarketDataId**](ComplexMarketDataId.md) |  | [optional] 
**MarketData** | [**ComplexMarketData**](ComplexMarketData.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "example scope";
ComplexMarketDataId? marketDataId = new ComplexMarketDataId();

ComplexMarketData? marketData = new ComplexMarketData();


ListComplexMarketDataWithMetaDataResponse listComplexMarketDataWithMetaDataResponseInstance = new ListComplexMarketDataWithMetaDataResponse(
    scope: scope,
    marketDataId: marketDataId,
    marketData: marketData);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
