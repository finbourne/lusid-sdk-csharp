# Lusid.Sdk.Model.MarketContextSuppliers
It is possible to control which supplier is used for a given asset class.  This field is deprecated in favour of market data rules, which subsumes its functionality.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Commodity** | **string** |  | [optional] 
**Credit** | **string** |  | [optional] 
**Equity** | **string** |  | [optional] 
**Fx** | **string** |  | [optional] 
**Rates** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string commodity = "example commodity";
string credit = "example credit";
string equity = "example equity";
string fx = "example fx";
string rates = "example rates";

MarketContextSuppliers marketContextSuppliersInstance = new MarketContextSuppliers(
    commodity: commodity,
    credit: credit,
    equity: equity,
    fx: fx,
    rates: rates);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
