# Lusid.Sdk.Model.ComplianceRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** |  | 
**Code** | **string** |  | 
**DisplayName** | **string** |  | 
**Type** | **string** |  | 
**PropertyKey** | **string** |  | [optional] 
**Value** | **string** |  | [optional] 
**AddressKey** | **string** |  | [optional] 
**LowerBound** | **decimal** |  | 
**UpperBound** | **decimal** |  | 
**Schedule** | **string** |  | 
**HardRequirement** | **bool** |  | 
**TargetPortfolioIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) |  | 
**Description** | **string** |  | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string code = "code";
string displayName = "displayName";
string type = "type";
string propertyKey = "example propertyKey";
string value = "example value";
string addressKey = "example addressKey";decimal lowerBound = "lowerBound";
decimal upperBound = "upperBound";

string schedule = "schedule";
bool hardRequirement = //"True";
List<ResourceId> targetPortfolioIds = new List<ResourceId>();
string description = "example description";
ModelVersion? varVersion = new ModelVersion();


ComplianceRule complianceRuleInstance = new ComplianceRule(
    scope: scope,
    code: code,
    displayName: displayName,
    type: type,
    propertyKey: propertyKey,
    value: value,
    addressKey: addressKey,
    lowerBound: lowerBound,
    upperBound: upperBound,
    schedule: schedule,
    hardRequirement: hardRequirement,
    targetPortfolioIds: targetPortfolioIds,
    description: description,
    varVersion: varVersion);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
