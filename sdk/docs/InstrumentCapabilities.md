# Lusid.Sdk.Model.InstrumentCapabilities
Instrument capabilities containing useful information about the instrument and the model. This includes  - features corresponding to the instrument i.e. Optionality:American, Other:InflationLinked  - supported addresses (if model provided) i.e. Valuation/Pv, Valuation/DirtyPriceKey, Valuation/Accrued  - economic dependencies (if model provided) i.e. Cash:USD, Fx:GBP.USD, Rates:GBP.GBPOIS

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentId** | **string** | The Lusid instrument id for the instrument e.g. &#39;LUID_00003D4X&#39;. | [optional] 
**Model** | **string** | The pricing model e.g. &#39;Discounting&#39;. | [optional] 
**Features** | **Dictionary&lt;string, string&gt;** | Features of the instrument describing its optionality, payoff type and more e.g. &#39;Instrument/Features/Exercise: American&#39;, &#39;Instrument/Features/Product: Option&#39; | [optional] 
**SupportedAddresses** | [**List&lt;DescribedAddressKey&gt;**](DescribedAddressKey.md) | Queryable addresses supported by the model, e.g. &#39;Valuation/Pv&#39;, &#39;Valuation/Accrued&#39;. | [optional] 
**EconomicDependencies** | [**List&lt;EconomicDependency&gt;**](EconomicDependency.md) | Economic dependencies for the model, e.g. &#39;Fx:GBP.USD&#39;, &#39;Cash:GBP&#39;, &#39;Rates:GBP.GBPOIS&#39;. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string instrumentId = "example instrumentId";
string model = "example model";
Dictionary<string, string> features = new Dictionary<string, string>();
List<DescribedAddressKey> supportedAddresses = new List<DescribedAddressKey>();
List<EconomicDependency> economicDependencies = new List<EconomicDependency>();
List<Link> links = new List<Link>();

InstrumentCapabilities instrumentCapabilitiesInstance = new InstrumentCapabilities(
    instrumentId: instrumentId,
    model: model,
    features: features,
    supportedAddresses: supportedAddresses,
    economicDependencies: economicDependencies,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
