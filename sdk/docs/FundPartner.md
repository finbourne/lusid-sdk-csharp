# Lusid.Sdk.Model.FundPartner
A register line of a partnership fund: one partner's commitment and its capital balances at an effective date.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The identifier of the investor record this register line belongs to. | 
**DisplayName** | **string** | The display name of the partner. | [optional] 
**CommitmentLineId** | **string** | The identifier of the commitment (register) line. | 
**LusidInstrumentId** | **string** | The LUSID instrument identifier of the register line&#39;s capital-interest instrument. | 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**IsVehicle** | **bool** | Whether the partner is a vehicle (for example a feeder or parallel fund) rather than an end investor. | 
**PartnerRole** | **string** | The role the partner plays in the partnership. Available values: LimitedPartner (the default), GeneralPartner, GPAffiliate, Employee, CarryVehicle. | 
**RegisterRole** | **string** | The role of the register line. Available values: GPRegister, LPInvestment (the default). | 
**CommitmentCurrency** | **string** | The currency of the partner&#39;s commitment. | 
**Balances** | [**FundPartnerBalances**](FundPartnerBalances.md) |  | 
**ShareOfCommitments** | **decimal** | The partner&#39;s committed capital as a decimal fraction of the fund&#39;s total commitments in the same commitment currency. | 
**AdmittedOn** | **DateTimeOffset?** | The date the partner was admitted, being the date of their first commitment. | [optional] 
**Totals** | [**FundPartnersTotals**](FundPartnersTotals.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "investorRecordId";
string displayName = "example displayName";
string commitmentLineId = "commitmentLineId";
string lusidInstrumentId = "lusidInstrumentId";
ResourceId portfolioId = new ResourceId();
bool isVehicle = //"True";
string partnerRole = "partnerRole";
string registerRole = "registerRole";
string commitmentCurrency = "commitmentCurrency";
FundPartnerBalances balances = new FundPartnerBalances();decimal shareOfCommitments = "shareOfCommitments";

FundPartnersTotals totals = new FundPartnersTotals();

FundPartner fundPartnerInstance = new FundPartner(
    investorRecordId: investorRecordId,
    displayName: displayName,
    commitmentLineId: commitmentLineId,
    lusidInstrumentId: lusidInstrumentId,
    portfolioId: portfolioId,
    isVehicle: isVehicle,
    partnerRole: partnerRole,
    registerRole: registerRole,
    commitmentCurrency: commitmentCurrency,
    balances: balances,
    shareOfCommitments: shareOfCommitments,
    admittedOn: admittedOn,
    totals: totals);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
