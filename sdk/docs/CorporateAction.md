# Lusid.Sdk.Model.CorporateAction
A corporate action

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorporateActionCode** | **string** | The unique identifier of this corporate action | 
**Description** | **string** | The description of the corporate action. | [optional] 
**AnnouncementDate** | **DateTimeOffset** | The announcement date of the corporate action | [optional] 
**ExDate** | **DateTimeOffset** | The ex date of the corporate action | [optional] 
**RecordDate** | **DateTimeOffset** | The record date of the corporate action | [optional] 
**PaymentDate** | **DateTimeOffset** | The payment date of the corporate action | [optional] 
**Transitions** | [**List&lt;CorporateActionTransition&gt;**](CorporateActionTransition.md) | The transitions that result from this corporate action | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string corporateActionCode = "corporateActionCode";
string description = "example description";
List<CorporateActionTransition> transitions = new List<CorporateActionTransition>();

CorporateAction corporateActionInstance = new CorporateAction(
    corporateActionCode: corporateActionCode,
    description: description,
    announcementDate: announcementDate,
    exDate: exDate,
    recordDate: recordDate,
    paymentDate: paymentDate,
    transitions: transitions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
