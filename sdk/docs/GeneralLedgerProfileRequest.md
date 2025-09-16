# Lusid.Sdk.Model.GeneralLedgerProfileRequest
A General Ledger Profile Definition.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GeneralLedgerProfileCode** | **string** | The unique code for the General Ledger Profile | 
**DisplayName** | **string** | The name of the General Ledger Profile | 
**Description** | **string** | A description for the General Ledger Profile | [optional] 
**GeneralLedgerProfileMappings** | [**List&lt;GeneralLedgerProfileMapping&gt;**](GeneralLedgerProfileMapping.md) | Rules for mapping Account or property values to aggregation pattern definitions | 

```csharp
using Lusid.Sdk.Model;
using System;

string generalLedgerProfileCode = "generalLedgerProfileCode";
string displayName = "displayName";
string description = "example description";
List<GeneralLedgerProfileMapping> generalLedgerProfileMappings = new List<GeneralLedgerProfileMapping>();

GeneralLedgerProfileRequest generalLedgerProfileRequestInstance = new GeneralLedgerProfileRequest(
    generalLedgerProfileCode: generalLedgerProfileCode,
    displayName: displayName,
    description: description,
    generalLedgerProfileMappings: generalLedgerProfileMappings);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
