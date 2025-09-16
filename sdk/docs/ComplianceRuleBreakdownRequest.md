# Lusid.Sdk.Model.ComplianceRuleBreakdownRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupStatus** | **string** |  | 
**ResultsUsed** | **Dictionary&lt;string, decimal&gt;** |  | 
**PropertiesUsed** | **Dictionary&lt;string, List&lt;Property&gt;&gt;** |  | 
**MissingDataInformation** | **List&lt;string&gt;** |  | 
**Lineage** | [**List&lt;LineageMember&gt;**](LineageMember.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string groupStatus = "groupStatus";
Dictionary<string, decimal> resultsUsed = new Dictionary<string, decimal>();
Dictionary<string, List<Property>> propertiesUsed = new Dictionary<string, List<Property>>();
List<string> missingDataInformation = new List<string>();
List<LineageMember> lineage = new List<LineageMember>();

ComplianceRuleBreakdownRequest complianceRuleBreakdownRequestInstance = new ComplianceRuleBreakdownRequest(
    groupStatus: groupStatus,
    resultsUsed: resultsUsed,
    propertiesUsed: propertiesUsed,
    missingDataInformation: missingDataInformation,
    lineage: lineage);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
