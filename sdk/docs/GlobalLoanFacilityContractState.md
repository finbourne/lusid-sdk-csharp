# Lusid.Sdk.Model.GlobalLoanFacilityContractState
The desired global state of a single FlexibleLoan contract. Balances are global - across all investors -  rather than investor specific.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContractDetails** | [**ContractDetails**](ContractDetails.md) |  | 
**Balance** | **decimal** | The desired global balance for this contract, in the contract&#39;s own currency. Must be non-negative. | 
**BalanceInFacilityCcy** | **decimal?** | The desired global balance expressed in the facility currency. Required when the contract currency  differs from the facility currency, and defaults to Balance otherwise. | [optional] 
**AgencyFxRate** | **decimal?** | The agency FX rate converting contract currency to facility currency. Required when the contract  currency differs from the facility currency. When omitted it is derived from the two balances where  possible, and otherwise defaults to 1. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ContractDetails contractDetails = new ContractDetails();decimal balance = "balance";


GlobalLoanFacilityContractState globalLoanFacilityContractStateInstance = new GlobalLoanFacilityContractState(
    contractDetails: contractDetails,
    balance: balance,
    balanceInFacilityCcy: balanceInFacilityCcy,
    agencyFxRate: agencyFxRate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
