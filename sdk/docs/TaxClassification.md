# Lusid.Sdk.Model.TaxClassification
The UK life-company tax classification of one instrument at one effective and asAt point.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Luid** | **string** | The LUSID instrument identifier of the classified instrument. | 
**InstrumentName** | **string** | The name of the classified instrument. | [optional] 
**InstrumentType** | **string** | The LUSID instrument type of the classified instrument, where known. | [optional] 
**WithinBlagab** | **bool?** | Whether the instrument is held within the basic life assurance and general annuity business of the fund. Absent when the input has not been set. | [optional] 
**Inputs** | [**TaxClassificationInputs**](TaxClassificationInputs.md) |  | 
**TreatmentOverride** | **string** | The user-supplied treatment leaf that replaces the system-derived one, if any. Available values: OutsideBlagab, LoanRelationship, IndexLinkedGilt, PrivateEquity, RealEstate, FinancialFuture, PooledDerivative, DerivativeProfitAndLoss, NonTransparentScheme, BondFund, TransparentScheme, StandardEquity, Exempt. | [optional] 
**Leaf** | **string** | The treatment leaf the decision tree arrived at. Absent when the instrument could not be classified. Available values: OutsideBlagab, LoanRelationship, IndexLinkedGilt, PrivateEquity, RealEstate, FinancialFuture, PooledDerivative, DerivativeProfitAndLoss, NonTransparentScheme, BondFund, TransparentScheme, StandardEquity, Exempt. | [optional] 
**Treatment** | **string** | The tax treatment class implied by the leaf: ChargeableGains, LoanRelationship, Excluded or Unclassified. Available values: ChargeableGains, LoanRelationship, Excluded, Unclassified. | 
**Status** | **string** | Classified, Overridden, Rejected or Unclassified. Available values: Classified, Overridden, Rejected, Unclassified. | 
**Source** | **string** | Whether the leaf came from the System decision tree or a User override. Available values: System, User. | 
**RuleFired** | **string** | The name of the decision-tree rule that produced the leaf. | 
**Trace** | [**List&lt;TaxClassificationDecisionStep&gt;**](TaxClassificationDecisionStep.md) | The ordered questions the decision tree asked and the answers it took, for audit. | [optional] 
**Exception** | [**TaxClassificationException**](TaxClassificationException.md) |  | [optional] 
**EffectiveAt** | **DateTimeOffset** | The effective date the classification was evaluated at. | 
**AsAt** | **DateTimeOffset** | The asAt time the classification was evaluated at. | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
string luid = "luid";
string instrumentName = "example instrumentName";
string instrumentType = "example instrumentType";
bool? withinBlagab = //"True";
TaxClassificationInputs inputs = new TaxClassificationInputs();
string treatmentOverride = "example treatmentOverride";
string leaf = "example leaf";
string treatment = "treatment";
string status = "status";
string source = "source";
string ruleFired = "ruleFired";
List<TaxClassificationDecisionStep> trace = new List<TaxClassificationDecisionStep>();
TaxClassificationException? exception = new TaxClassificationException();

List<Link> links = new List<Link>();

TaxClassification taxClassificationInstance = new TaxClassification(
    href: href,
    luid: luid,
    instrumentName: instrumentName,
    instrumentType: instrumentType,
    withinBlagab: withinBlagab,
    inputs: inputs,
    treatmentOverride: treatmentOverride,
    leaf: leaf,
    treatment: treatment,
    status: status,
    source: source,
    ruleFired: ruleFired,
    trace: trace,
    exception: exception,
    effectiveAt: effectiveAt,
    asAt: asAt,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
