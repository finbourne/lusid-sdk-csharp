# Lusid.Sdk.Model.PartnershipAccountingConfiguration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** |  | 
**ConfigPack** | [**ResourceId**](ResourceId.md) |  | [optional] 
**CommitmentCurrencyPolicy** | **string** | Available values: FundCurrencyOnly. | [optional] 
**RegisterPortfolioGroup** | [**ResourceId**](ResourceId.md) |  | [optional] 
**CapitalModel** | **string** | Available values: PartnershipCapitalAccounts, SeriesUnitised. | [optional] 
**CapabilityOverrides** | [**List&lt;CapabilityOverride&gt;**](CapabilityOverride.md) |  | [optional] 
**Series** | [**SeriesConfiguration**](SeriesConfiguration.md) |  | [optional] 
**EffectiveCapabilities** | **Dictionary&lt;string, string&gt;** | Derived on the way out; ignored on the way in. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool enabled = //"True";
ResourceId? configPack = new ResourceId();

string commitmentCurrencyPolicy = "example commitmentCurrencyPolicy";
ResourceId? registerPortfolioGroup = new ResourceId();

string capitalModel = "example capitalModel";
List<CapabilityOverride> capabilityOverrides = new List<CapabilityOverride>();
SeriesConfiguration? series = new SeriesConfiguration();

Dictionary<string, string> effectiveCapabilities = new Dictionary<string, string>();

PartnershipAccountingConfiguration partnershipAccountingConfigurationInstance = new PartnershipAccountingConfiguration(
    enabled: enabled,
    configPack: configPack,
    commitmentCurrencyPolicy: commitmentCurrencyPolicy,
    registerPortfolioGroup: registerPortfolioGroup,
    capitalModel: capitalModel,
    capabilityOverrides: capabilityOverrides,
    series: series,
    effectiveCapabilities: effectiveCapabilities);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
