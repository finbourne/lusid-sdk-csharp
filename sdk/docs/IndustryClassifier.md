# Lusid.Sdk.Model.IndustryClassifier
Object describing a particular industry classifier,  which comprises a classification code and the name of the classification system to which the code belongs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassificationSystemName** | **string** | The name of the classification system to which the classification code belongs (e.g. GICS). | 
**ClassificationCode** | **string** | The specific industry classification code assigned to the legal entity. | 

```csharp
using Lusid.Sdk.Model;
using System;

string classificationSystemName = "classificationSystemName";
string classificationCode = "classificationCode";

IndustryClassifier industryClassifierInstance = new IndustryClassifier(
    classificationSystemName: classificationSystemName,
    classificationCode: classificationCode);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
