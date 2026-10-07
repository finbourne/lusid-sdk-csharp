# Lusid.Sdk.Model.ValuationPointDiagnostic
Something found while striking a valuation point that did not stop it but should be looked at.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | What kind of finding this is. &#39;OwnershipDrift&#39;: a fund structure holder&#39;s declared sharing percentage in a held member differs from the share its contributions make of that member&#39;s capital by enough to misallocate more of the period&#39;s P&amp;L than the holder&#39;s drift materiality warning amount allows. | 
**Message** | **string** | What was found and what to do about it. | 
**Details** | **Dictionary&lt;string, string&gt;** | The values the finding was made on, by name. For &#39;OwnershipDrift&#39;: holder, member, declaredShare, actualShare, delta (actual less declared) and impact (the P&amp;L the drift would misallocate this period). | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string type = "type";
string message = "message";
Dictionary<string, string> details = new Dictionary<string, string>();

ValuationPointDiagnostic valuationPointDiagnosticInstance = new ValuationPointDiagnostic(
    type: type,
    message: message,
    details: details);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
