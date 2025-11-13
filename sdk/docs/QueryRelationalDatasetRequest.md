# Lusid.Sdk.Model.QueryRelationalDatasetRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QueryMethod** | **string** | The method used to query data points. Can be either &#39;Latest&#39; or &#39;TimeSeries&#39;. | [optional] 
**Filter** | **string** | Expression to filter the result set. For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional] 
**CustomSortBy** | **List&lt;string&gt;** | A list of fields to sort the results by. For example, to sort by a Value field &#39;AValueField&#39; in descending order, specify &#39;AValueField DESC&#39;. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string queryMethod = "example queryMethod";
string filter = "example filter";
List<string> customSortBy = new List<string>();

QueryRelationalDatasetRequest queryRelationalDatasetRequestInstance = new QueryRelationalDatasetRequest(
    queryMethod: queryMethod,
    filter: filter,
    customSortBy: customSortBy);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
