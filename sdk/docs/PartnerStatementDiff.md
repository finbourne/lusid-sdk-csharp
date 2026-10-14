# Lusid.Sdk.Model.PartnerStatementDiff
The differences between two of a partner's statements.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StatementId** | **string** | The identifier of the statement. | 
**AgainstStatementId** | **string** | The identifier of the statement to compare against. | 
**Identical** | **bool** | Whether the two statements carry the same figures. | 
**Differences** | [**List&lt;PartnerStatementLineDifference&gt;**](PartnerStatementLineDifference.md) | The figures that differ between the two statements. | 

```csharp
using Lusid.Sdk.Model;
using System;

string statementId = "statementId";
string againstStatementId = "againstStatementId";
bool identical = //"True";
List<PartnerStatementLineDifference> differences = new List<PartnerStatementLineDifference>();

PartnerStatementDiff partnerStatementDiffInstance = new PartnerStatementDiff(
    statementId: statementId,
    againstStatementId: againstStatementId,
    identical: identical,
    differences: differences);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
