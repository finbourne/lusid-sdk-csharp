# Lusid.Sdk.Model.AllocationEventNoticeWire
Wire instructions for the payment a notice asks for or announces, from the investor record's payment  instructions. Absent when the investor record holds none.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BankName** | **string** | The name of the bank. | [optional] 
**AccountName** | **string** | The name on the account. | [optional] 
**AccountNumber** | **string** | The account number or IBAN. | [optional] 
**Bic** | **string** | The bank identifier code. | [optional] 
**Reference** | **string** | The payment reference. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string bankName = "example bankName";
string accountName = "example accountName";
string accountNumber = "example accountNumber";
string bic = "example bic";
string reference = "example reference";

AllocationEventNoticeWire allocationEventNoticeWireInstance = new AllocationEventNoticeWire(
    bankName: bankName,
    accountName: accountName,
    accountNumber: accountNumber,
    bic: bic,
    reference: reference);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
