# Lusid.Sdk.Model.ComplianceRunConfiguration
Specification object for the configuration parameters of a compliance run

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PreTradeConfiguration** | [**PreTradeConfiguration**](PreTradeConfiguration.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

PreTradeConfiguration preTradeConfiguration = new PreTradeConfiguration();

ComplianceRunConfiguration complianceRunConfigurationInstance = new ComplianceRunConfiguration(
    preTradeConfiguration: preTradeConfiguration);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
