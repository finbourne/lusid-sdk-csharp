# Lusid.Sdk.Model.ComplianceKeyUsed
A key a holding contributed to the rule: the key, the role(s) it played in the rule, the holding's own value for  it, and which bag the value was read from.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** |  | 
**Roles** | **List&lt;string&gt;** |  | 
**Value** | **Object** | This holding&#39;s own value for the key. Polymorphic: a number for a result or metric property, a label string for  a label property, or a string for a related property. | [optional] 
**Source** | **string** |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string key = "key";
List<string> roles = new List<string>();
string source = "source";

ComplianceKeyUsed complianceKeyUsedInstance = new ComplianceKeyUsed(
    key: key,
    roles: roles,
    value: value,
    source: source);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
