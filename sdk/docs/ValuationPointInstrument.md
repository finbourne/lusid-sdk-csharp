# Lusid.Sdk.Model.ValuationPointInstrument
An Instrument held at a Valuation Point, including its origin

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Instrument** | [**Instrument**](Instrument.md) |  | [optional] 
**ValuationPointOrigin** | **string** | Designates if the instrument was originally part of the Valuation Point or if it was added as part of a Complex Close action. Available values: None, Original, Added, OriginalAndAdded. | [optional] 
**AddedOriginValuationPointCode** | **string** | The Valuation Point, only for an Instrument added as part of a Complex Close action. | [optional] 
**AddedOriginValuationPointVariantCode** | **string** | The Valuation Point variant, only for Instruments added as part of a Complex Close action. | [optional] 
**ValuationPointOriginSource** | **List&lt;string&gt;** | Collection of sources of Post Close Activities which added this instrument. Available values: Undefined, Manual, Auto. | [optional] 
**ValuationPointOriginType** | **List&lt;string&gt;** | Collection of types of Post Close Activities which added this instrument. Available values: PortfolioTransaction, PortfolioSettlementInstruction, InstrumentActivity, QuoteActivity. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The requested instrument properties. These will be from the &#39;Instrument&#39; domain. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Instrument? instrument = new Instrument();

string valuationPointOrigin = "example valuationPointOrigin";
string addedOriginValuationPointCode = "example addedOriginValuationPointCode";
string addedOriginValuationPointVariantCode = "example addedOriginValuationPointVariantCode";
List<string> valuationPointOriginSource = new List<string>();
List<string> valuationPointOriginType = new List<string>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();

ValuationPointInstrument valuationPointInstrumentInstance = new ValuationPointInstrument(
    instrument: instrument,
    valuationPointOrigin: valuationPointOrigin,
    addedOriginValuationPointCode: addedOriginValuationPointCode,
    addedOriginValuationPointVariantCode: addedOriginValuationPointVariantCode,
    valuationPointOriginSource: valuationPointOriginSource,
    valuationPointOriginType: valuationPointOriginType,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
