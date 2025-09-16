# Lusid.Sdk.Model.ComplianceRuleUpsertRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** |  | 
**Code** | **string** |  | [optional] 
**DisplayName** | **string** |  | [optional] 
**Type** | **string** |  | 
**PropertyKey** | **string** |  | [optional] 
**Value** | **string** |  | [optional] 
**LowerBound** | **decimal** |  | 
**UpperBound** | **decimal** |  | 
**Schedule** | **string** |  | 
**HardRequirement** | **bool** |  | 
**TargetPortfolioIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) |  | 
**Description** | **string** |  | [optional] 
**AddressKey** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string code = "example code";
string displayName = "example displayName";
string type = "type";
string propertyKey = "example propertyKey";
string value = "example value";decimal lowerBound = "lowerBound";
decimal upperBound = "upperBound";

string schedule = "schedule";
bool hardRequirement = //"True";
List<ResourceId> targetPortfolioIds = new List<ResourceId>();
string description = "example description";
string addressKey = "example addressKey";

ComplianceRuleUpsertRequest complianceRuleUpsertRequestInstance = new ComplianceRuleUpsertRequest(
    scope: scope,
    code: code,
    displayName: displayName,
    type: type,
    propertyKey: propertyKey,
    value: value,
    lowerBound: lowerBound,
    upperBound: upperBound,
    schedule: schedule,
    hardRequirement: hardRequirement,
    targetPortfolioIds: targetPortfolioIds,
    description: description,
    addressKey: addressKey);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
