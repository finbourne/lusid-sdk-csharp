# Lusid.Sdk.Model.UpdateDataTypeRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The display name of the data type. | [optional] 
**Description** | **string** | The description of the data type. | [optional] 
**AcceptableValues** | **List&lt;string&gt;** | The acceptable set of values for this data type. Only applies to &#39;open&#39; value type range. | [optional] 
**AcceptableUnits** | [**List&lt;UpdateUnitRequest&gt;**](UpdateUnitRequest.md) | The definitions of the acceptable units. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "example displayName";
string description = "example description";
List<string> acceptableValues = new List<string>();
List<UpdateUnitRequest> acceptableUnits = new List<UpdateUnitRequest>();

UpdateDataTypeRequest updateDataTypeRequestInstance = new UpdateDataTypeRequest(
    displayName: displayName,
    description: description,
    acceptableValues: acceptableValues,
    acceptableUnits: acceptableUnits);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
