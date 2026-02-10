# Lusid.Sdk.Model.SettlementConfigurationMethodOverride

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PropertyKey** | **string** | Property Key to override the settlement method. Allowed values: &#39;Automatic&#39;, &#39;Instructed&#39; and &#39;Default&#39;, property key must be in the &#39;Transaction&#39; domain. For a derived property keys, the derivation formula should resolve one of the of the allowed values. &#39;Default&#39; will be treated the same as no or an invalid derived value, will fall back to use the regular settlement method. | 

```csharp
using Lusid.Sdk.Model;
using System;

string propertyKey = "propertyKey";

SettlementConfigurationMethodOverride settlementConfigurationMethodOverrideInstance = new SettlementConfigurationMethodOverride(
    propertyKey: propertyKey);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
