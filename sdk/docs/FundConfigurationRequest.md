# Lusid.Sdk.Model.FundConfigurationRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** |  | 
**DisplayName** | **string** | The name of the Fund. | [optional] 
**Description** | **string** | A description for the Fund. | [optional] 
**DealingFilters** | [**List&lt;ComponentFilter&gt;**](ComponentFilter.md) | The set of filters used to decide which JE lines are included in the dealing. | [optional] 
**PnlFilters** | [**List&lt;ComponentFilter&gt;**](ComponentFilter.md) | The set of filters used to decide which JE lines are included in the PnL. | [optional] 
**BackOutFilters** | [**List&lt;ComponentFilter&gt;**](ComponentFilter.md) | The set of filters used to decide which JE lines are included in the back outs. | [optional] 
**ExternalFeeFilters** | [**List&lt;ExternalFeeComponentFilter&gt;**](ExternalFeeComponentFilter.md) | The set of filters used to decide which JE lines are used for inputting fees from an external source. | [optional] 
**BucketSets** | [**List&lt;BucketSetDefinition&gt;**](BucketSetDefinition.md) | The ordered set of component bucket set definitions for this fund configuration. Each bucket set defines how JE lines are grouped into buckets at VP finalisation. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the Fund Configuration. | [optional] 
**ApportionmentBucketSet** | **string** | The code of the bucket set definition within this fund configuration that is designated as the apportionment bucket set. Must reference a BucketSetDefinition code within the BucketSets collection. | [optional] 
**ApportionmentMethodProperty** | [**ApportionmentMethodProperty**](ApportionmentMethodProperty.md) |  | [optional] 

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
List<BucketSetDefinition> bucketSets = new List<BucketSetDefinition>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();
string apportionmentBucketSet = "example apportionmentBucketSet";
ApportionmentMethodProperty? apportionmentMethodProperty = new ApportionmentMethodProperty();


FundConfigurationRequest fundConfigurationRequestInstance = new FundConfigurationRequest(
    code: code,
    displayName: displayName,
    description: description,
    dealingFilters: dealingFilters,
    pnlFilters: pnlFilters,
    backOutFilters: backOutFilters,
    externalFeeFilters: externalFeeFilters,
    bucketSets: bucketSets,
    properties: properties,
    apportionmentBucketSet: apportionmentBucketSet,
    apportionmentMethodProperty: apportionmentMethodProperty);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
