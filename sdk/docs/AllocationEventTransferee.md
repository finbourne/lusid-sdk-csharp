# Lusid.Sdk.Model.AllocationEventTransferee
A transferee a Transfer's booking gives a line: the line, and the investment account it is opened under.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The transferee&#39;s investor record, as the leg names it. | [optional] 
**FundId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**LineId** | **string** | The commitment line opened for the transferee. | [optional] 
**Line** | **string** | What happens to the line: Open when a booking would open it, Opened when this booking opened it. | [optional] 
**InvestmentAccountScope** | **string** | The scope of the investment account the line is opened under: the fund&#39;s. | [optional] 
**InvestmentAccountIdentifierType** | **string** | The type of the investment account&#39;s identifier, as a property key. An account a transfer opens is identified by InvestmentAccount/system/TransfereeAccountId. | [optional] 
**InvestmentAccountIdentifierValue** | **string** | The value of the investment account&#39;s identifier. An account a transfer opens has the value &#39;{fundCode}-{investor record LUID}&#39;, so a retry or a concurrent transfer finds the same account. | [optional] 
**InvestmentAccount** | **string** | What happens to the investment account: Existing when the transferee already holds it, Create when a booking would open it, Created when this booking opened it. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "example investorRecordId";
ResourceId? fundId = new ResourceId();

string lineId = "example lineId";
string line = "example line";
string investmentAccountScope = "example investmentAccountScope";
string investmentAccountIdentifierType = "example investmentAccountIdentifierType";
string investmentAccountIdentifierValue = "example investmentAccountIdentifierValue";
string investmentAccount = "example investmentAccount";

AllocationEventTransferee allocationEventTransfereeInstance = new AllocationEventTransferee(
    investorRecordId: investorRecordId,
    fundId: fundId,
    lineId: lineId,
    line: line,
    investmentAccountScope: investmentAccountScope,
    investmentAccountIdentifierType: investmentAccountIdentifierType,
    investmentAccountIdentifierValue: investmentAccountIdentifierValue,
    investmentAccount: investmentAccount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
