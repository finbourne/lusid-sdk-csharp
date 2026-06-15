# Lusid.Sdk.Model.AddressKeyAlias
An address key alias that maps a short alias key to a real key with options.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | The scope of the alias | 
**Code** | **string** | The code of the alias | 
**AliasKey** | **string** | The alias address key, must start with \&quot;Alias/\&quot; prefix (e.g., \&quot;Alias/DailyNZPnL\&quot;) | 
**RealKey** | **string** | The real address key this alias resolves to (e.g., \&quot;ProfitAndLoss/Total\&quot;). Must NOT start with \&quot;Alias/\&quot;. | 
**Options** | **Dictionary&lt;string, string&gt;** | Options to apply when resolving the alias (e.g., {\&quot;Window\&quot;:\&quot;Daily\&quot;,\&quot;TimeZone\&quot;:\&quot;NZ\&quot;}) | [optional] 
**DisplayName** | **string** | Human-readable display name | [optional] 
**Description** | **string** | Description of the alias | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string code = "code";
string aliasKey = "aliasKey";
string realKey = "realKey";
Dictionary<string, string> options = new Dictionary<string, string>();
string displayName = "example displayName";
string description = "example description";

AddressKeyAlias addressKeyAliasInstance = new AddressKeyAlias(
    scope: scope,
    code: code,
    aliasKey: aliasKey,
    realKey: realKey,
    options: options,
    displayName: displayName,
    description: description);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
