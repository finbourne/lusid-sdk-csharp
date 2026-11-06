# Lusid.Sdk.Model.ComplianceRuleV3GroupResult
The result of one rule for a single evaluated group: its status, the group key identifying it, the  measured value, the unit the value and limits are expressed in, the limits it was checked against, the  portfolios and orders it affects, and, when it could not be assessed, the missing-data details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Available values: Passed, Failed, Warning, MissingData. | [optional] 
**GroupKey** | **string** |  | [optional] 
**MeasuredValue** | **decimal?** |  | [optional] 
**HardLimit** | **decimal?** |  | [optional] 
**SoftLimit** | **decimal?** |  | [optional] 
**Unit** | **string** | Available values: Absolute, Percentage. | [optional] 
**AffectedPortfolioIds** | **List&lt;string&gt;** |  | [optional] 
**AffectedOrderIds** | **List&lt;string&gt;** |  | [optional] 
**MissingDataDetails** | **List&lt;string&gt;** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string status = "example status";
string groupKey = "example groupKey";
string unit = "example unit";
List<string> affectedPortfolioIds = new List<string>();
List<string> affectedOrderIds = new List<string>();
List<string> missingDataDetails = new List<string>();

ComplianceRuleV3GroupResult complianceRuleV3GroupResultInstance = new ComplianceRuleV3GroupResult(
    status: status,
    groupKey: groupKey,
    measuredValue: measuredValue,
    hardLimit: hardLimit,
    softLimit: softLimit,
    unit: unit,
    affectedPortfolioIds: affectedPortfolioIds,
    affectedOrderIds: affectedOrderIds,
    missingDataDetails: missingDataDetails);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
