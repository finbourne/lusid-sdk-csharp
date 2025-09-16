# Lusid.Sdk.Model.TransactionTemplateSpecification

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** |  | 
**SupportedInstrumentTypes** | **List&lt;string&gt;** |  | 
**SupportedParticipationTypes** | **List&lt;string&gt;** |  | 
**SupportedElectionTypes** | [**List&lt;ElectionSpecification&gt;**](ElectionSpecification.md) |  | 
**SupportedTemplateFields** | [**List&lt;TemplateField&gt;**](TemplateField.md) |  | 
**EligibilityCalculation** | [**EligibilityCalculation**](EligibilityCalculation.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string instrumentEventType = "instrumentEventType";
List<string> supportedInstrumentTypes = new List<string>();
List<string> supportedParticipationTypes = new List<string>();
List<ElectionSpecification> supportedElectionTypes = new List<ElectionSpecification>();
List<TemplateField> supportedTemplateFields = new List<TemplateField>();
EligibilityCalculation eligibilityCalculation = new EligibilityCalculation();

TransactionTemplateSpecification transactionTemplateSpecificationInstance = new TransactionTemplateSpecification(
    instrumentEventType: instrumentEventType,
    supportedInstrumentTypes: supportedInstrumentTypes,
    supportedParticipationTypes: supportedParticipationTypes,
    supportedElectionTypes: supportedElectionTypes,
    supportedTemplateFields: supportedTemplateFields,
    eligibilityCalculation: eligibilityCalculation);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
