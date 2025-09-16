# Lusid.Sdk.Model.ListAggregationResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AggregationEffectiveAt** | **DateTimeOffset** |  | [optional] 
**AggregationAsAt** | **DateTimeOffset** |  | [optional] 
**Href** | **string** |  | [optional] 
**Data** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** |  | [optional] 
**AggregationCurrency** | **string** |  | [optional] 
**DataSchema** | [**ResultDataSchema**](ResultDataSchema.md) |  | [optional] 
**AggregationFailures** | [**List&lt;AggregationMeasureFailureDetail&gt;**](AggregationMeasureFailureDetail.md) |  | [optional] 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
List<Dictionary<string, Object>> data = new List<Dictionary<string, Object>>();
string aggregationCurrency = "example aggregationCurrency";
ResultDataSchema? dataSchema = new ResultDataSchema();

List<AggregationMeasureFailureDetail> aggregationFailures = new List<AggregationMeasureFailureDetail>();
ResourceId? recipeId = new ResourceId();

List<Link> links = new List<Link>();

ListAggregationResponse listAggregationResponseInstance = new ListAggregationResponse(
    aggregationEffectiveAt: aggregationEffectiveAt,
    aggregationAsAt: aggregationAsAt,
    href: href,
    data: data,
    aggregationCurrency: aggregationCurrency,
    dataSchema: dataSchema,
    aggregationFailures: aggregationFailures,
    recipeId: recipeId,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
