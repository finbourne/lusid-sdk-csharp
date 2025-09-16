# Lusid.Sdk.Model.TrialBalanceQueryParameters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Start** | [**DateOrDiaryEntry**](DateOrDiaryEntry.md) |  | [optional] 
**End** | [**DateOrDiaryEntry**](DateOrDiaryEntry.md) |  | [optional] 
**DateMode** | **string** | The mode of calculation of the trial balance. The available values are: ActivityDate, AccountingDate. | [optional] 
**GeneralLedgerProfileCode** | **string** | The optional code of a general ledger profile used to decorate trial balance with levels. | [optional] 
**PropertyKeys** | **List&lt;string&gt;** | A list of property keys from the &#39;Account&#39; domain to decorate onto the trial balance. | [optional] 
**ExcludeCleardownModule** | **bool** | By deafult this flag is set to false, if this is set to true, no cleardown module will be applied to the trial balance. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

DateOrDiaryEntry? start = new DateOrDiaryEntry();

DateOrDiaryEntry? end = new DateOrDiaryEntry();

string dateMode = "example dateMode";
string generalLedgerProfileCode = "example generalLedgerProfileCode";
List<string> propertyKeys = new List<string>();
bool excludeCleardownModule = //"True";

TrialBalanceQueryParameters trialBalanceQueryParametersInstance = new TrialBalanceQueryParameters(
    start: start,
    end: end,
    dateMode: dateMode,
    generalLedgerProfileCode: generalLedgerProfileCode,
    propertyKeys: propertyKeys,
    excludeCleardownModule: excludeCleardownModule);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
