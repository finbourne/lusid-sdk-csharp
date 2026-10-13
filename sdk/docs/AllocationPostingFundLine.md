# Lusid.Sdk.Model.AllocationPostingFundLine
One transaction a booking writes on the fund's own books.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The deterministic identifier of the posting: the booking reference, investor record, commitment line, component and side. | [optional] 
**Portfolio** | [**ResourceId**](ResourceId.md) |  | [optional] 
**TransactionType** | **string** | The transaction type written on the fund side, for instance PA.ContributionCalled. | [optional] 
**Amount** | **decimal** | The amount posted, in the event currency. | [optional] 
**Component** | **string** | The component of the event the posting carries. | [optional] 
**InvestorRecordId** | **string** | The investor record the posting is for. | [optional] 
**ViaVehicle** | **string** | The vehicle the investor&#39;s share reached the fund through, when it did not come direct. | [optional] 
**AdmissionVehicle** | **string** | The vehicle the investor was admitted to. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string id = "example id";
ResourceId? portfolio = new ResourceId();

string transactionType = "example transactionType";decimal? amount = "example amount";
string component = "example component";
string investorRecordId = "example investorRecordId";
string viaVehicle = "example viaVehicle";
string admissionVehicle = "example admissionVehicle";

AllocationPostingFundLine allocationPostingFundLineInstance = new AllocationPostingFundLine(
    id: id,
    portfolio: portfolio,
    transactionType: transactionType,
    amount: amount,
    component: component,
    investorRecordId: investorRecordId,
    viaVehicle: viaVehicle,
    admissionVehicle: admissionVehicle);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
