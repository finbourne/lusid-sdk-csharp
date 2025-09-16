# Lusid.Sdk.Model.ComplianceRuleBreakdown

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupStatus** | **string** | The status of this subset of results. | 
**ResultsUsed** | **Dictionary&lt;string, decimal&gt;** | Dictionary of AddressKey (as string) and their corresponding decimal values, that were used in this rule. | 
**PropertiesUsed** | **Dictionary&lt;string, List&lt;Property&gt;&gt;** | Dictionary of PropertyKey (as string) and their corresponding Properties, that were used in this rule | 
**MissingDataInformation** | **List&lt;string&gt;** | List of string information detailing data that was missing from contributions processed in this rule | 
**Lineage** | [**List&lt;LineageMember&gt;**](LineageMember.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string groupStatus = "groupStatus";
Dictionary<string, decimal> resultsUsed = new Dictionary<string, decimal>();
Dictionary<string, List<Property>> propertiesUsed = new Dictionary<string, List<Property>>();
List<string> missingDataInformation = new List<string>();
List<LineageMember> lineage = new List<LineageMember>();

ComplianceRuleBreakdown complianceRuleBreakdownInstance = new ComplianceRuleBreakdown(
    groupStatus: groupStatus,
    resultsUsed: resultsUsed,
    propertiesUsed: propertiesUsed,
    missingDataInformation: missingDataInformation,
    lineage: lineage);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
