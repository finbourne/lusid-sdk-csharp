# Lusid.Sdk.Model.ComplianceRuleContribution

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index** | **int** | The position of this contribution within the compliance run. | 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**OrderId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Instrument** | **string** | The LUSID instrument identifier (LUID) of the instrument for this contribution. | 
**InstrumentType** | **string** | Optional. The economic type of the instrument for this contribution. | [optional] 
**HoldingType** | **string** | Optional. The holding type of this contribution. | [optional] 
**HoldingId** | **string** | Optional. The internal holding identifier encoding the detail of what the holding includes. | [optional] 
**ResultValues** | **Dictionary&lt;string, decimal&gt;** | Dictionary of AddressKey (as string) and their corresponding decimal valuation results for this contribution. | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | Dictionary of PropertyKey (as string) and their corresponding property for this contribution. | 
**RelatedProperties** | **Dictionary&lt;string, string&gt;** | Dictionary of related property keys (as string) and their string values, read from related entities across a relationship. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId portfolioId = new ResourceId();
ResourceId? orderId = new ResourceId();

string instrument = "instrument";
string instrumentType = "example instrumentType";
string holdingType = "example holdingType";
string holdingId = "example holdingId";
Dictionary<string, decimal> resultValues = new Dictionary<string, decimal>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();
Dictionary<string, string> relatedProperties = new Dictionary<string, string>();

ComplianceRuleContribution complianceRuleContributionInstance = new ComplianceRuleContribution(
    index: index,
    portfolioId: portfolioId,
    orderId: orderId,
    instrument: instrument,
    instrumentType: instrumentType,
    holdingType: holdingType,
    holdingId: holdingId,
    resultValues: resultValues,
    properties: properties,
    relatedProperties: relatedProperties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
