# Lusid.Sdk.Model.FundConfigurationRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** |  | 
**DisplayName** | **string** | The name of the Fund. | [optional] 
**Description** | **string** | A description for the Fund. | [optional] 
**DealingFilters** | [**List&lt;ComponentFilter&gt;**](ComponentFilter.md) | The set of filters used to decide which JE lines are included in the dealing. | 
**PnlFilters** | [**List&lt;ComponentFilter&gt;**](ComponentFilter.md) | The set of filters used to decide which JE lines are included in the PnL. | 
**BackOutFilters** | [**List&lt;ComponentFilter&gt;**](ComponentFilter.md) | The set of filters used to decide which JE lines are included in the back outs. | 
**ExternalFeeFilters** | [**List&lt;ExternalFeeComponentFilter&gt;**](ExternalFeeComponentFilter.md) | The set of filters used to decide which JE lines are used for inputting fees from an external source. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the Fund Configuration. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string displayName = "example displayName";
string description = "example description";
List<ComponentFilter> dealingFilters = new List<ComponentFilter>();
List<ComponentFilter> pnlFilters = new List<ComponentFilter>();
List<ComponentFilter> backOutFilters = new List<ComponentFilter>();
List<ExternalFeeComponentFilter> externalFeeFilters = new List<ExternalFeeComponentFilter>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();

FundConfigurationRequest fundConfigurationRequestInstance = new FundConfigurationRequest(
    code: code,
    displayName: displayName,
    description: description,
    dealingFilters: dealingFilters,
    pnlFilters: pnlFilters,
    backOutFilters: backOutFilters,
    externalFeeFilters: externalFeeFilters,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
