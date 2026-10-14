# Lusid.Sdk.Model.PresentationConfiguration
How partner capital is presented on statements and the valuation point.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContributionsReceivableNetted** | **bool?** |  | [optional] 
**SeparateNoticeDueReceiptDates** | **bool?** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool? contributionsReceivableNetted = //"True";
bool? separateNoticeDueReceiptDates = //"True";

PresentationConfiguration presentationConfigurationInstance = new PresentationConfiguration(
    contributionsReceivableNetted: contributionsReceivableNetted,
    separateNoticeDueReceiptDates: separateNoticeDueReceiptDates);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
