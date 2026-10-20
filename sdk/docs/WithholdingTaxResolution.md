# Lusid.Sdk.Model.WithholdingTaxResolution

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResolutionStatus** | **string** | Match or NoMatch: the status booking stamps on a transaction. | 
**MatchedRule** | [**WithholdingTaxMatchedRule**](WithholdingTaxMatchedRule.md) |  | [optional] 
**RateTiers** | [**WithholdingTaxRateTiers**](WithholdingTaxRateTiers.md) |  | [optional] 
**RasFlags** | [**WithholdingTaxReliefAtSourceFlags**](WithholdingTaxReliefAtSourceFlags.md) |  | [optional] 
**DerivedSplit** | [**WithholdingTaxRateSplit**](WithholdingTaxRateSplit.md) |  | [optional] 
**Provenance** | [**WithholdingTaxResolutionProvenance**](WithholdingTaxResolutionProvenance.md) |  | [optional] 
**ResolvedDimensions** | **Dictionary&lt;string, string&gt;** | Each dimension of either dataset, with the value used. Null where there is no value. | 
**IsWhatIf** | **bool** | False when the saved configuration&#39;s datasets and source order are used as they are. True when a dataset or the source order differs from the configuration&#39;s, or when no configuration was given. | 
**UnresolvedDimensions** | [**Dictionary&lt;string, WithholdingTaxUnresolvedDimension&gt;**](WithholdingTaxUnresolvedDimension.md) | Each dimension that booking reads from the transaction, portfolio or fund, that dimensions does not supply, and that a couldAlsoMatch entry needs. It is null, so only rows blank on it match. Empty in Raw mode. | 
**CouldAlsoMatch** | [**List&lt;WithholdingTaxAlternativeMatch&gt;**](WithholdingTaxAlternativeMatch.md) | Each other row that booking would choose with its own values for the unresolved dimensions, fewest values first, up to the limit. Where one entry&#39;s values include another&#39;s, the one with more values applies. | 
**HasMoreAlternatives** | **bool** | True when the limit stopped the lookup before it tried every combination of values, so couldAlsoMatch may miss rows. Ask again with a higher limit. | 

```csharp
using Lusid.Sdk.Model;
using System;

string resolutionStatus = "resolutionStatus";
WithholdingTaxMatchedRule? matchedRule = new WithholdingTaxMatchedRule();

WithholdingTaxRateTiers? rateTiers = new WithholdingTaxRateTiers();

WithholdingTaxReliefAtSourceFlags? rasFlags = new WithholdingTaxReliefAtSourceFlags();

WithholdingTaxRateSplit? derivedSplit = new WithholdingTaxRateSplit();

WithholdingTaxResolutionProvenance? provenance = new WithholdingTaxResolutionProvenance();

Dictionary<string, string> resolvedDimensions = new Dictionary<string, string>();
bool isWhatIf = //"True";
Dictionary<string, WithholdingTaxUnresolvedDimension> unresolvedDimensions = new Dictionary<string, WithholdingTaxUnresolvedDimension>();
List<WithholdingTaxAlternativeMatch> couldAlsoMatch = new List<WithholdingTaxAlternativeMatch>();
bool hasMoreAlternatives = //"True";

WithholdingTaxResolution withholdingTaxResolutionInstance = new WithholdingTaxResolution(
    resolutionStatus: resolutionStatus,
    matchedRule: matchedRule,
    rateTiers: rateTiers,
    rasFlags: rasFlags,
    derivedSplit: derivedSplit,
    provenance: provenance,
    resolvedDimensions: resolvedDimensions,
    isWhatIf: isWhatIf,
    unresolvedDimensions: unresolvedDimensions,
    couldAlsoMatch: couldAlsoMatch,
    hasMoreAlternatives: hasMoreAlternatives);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
