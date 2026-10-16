# Lusid.Sdk.Model.MarginItem
One margin arrangement under an agreement, either variation or initial.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The stable key that margin calls and custodian accounts refer to this item by. Unique across the agreement&#39;s variation and initial margin. | 
**TradeFilter** | **string** | A filter selecting the trades this item covers. Required where the agreement has more than one margin item. | [optional] 
**Settlement** | **string** | Whether margin is settled (Settled) or collateralised (Collateral). Optional. Available values: Collateral, Settled. | [optional] 
**LegalMechanism** | **string** | How title to posted collateral is held. One of TitleTransfer or SecurityInterest. Optional. Available values: TitleTransfer, SecurityInterest. | [optional] 
**WePost** | [**PartyTerms**](PartyTerms.md) |  | 
**TheyPost** | [**PartyTerms**](PartyTerms.md) |  | 
**EligibleCollateral** | [**EligibleCollateralReferences**](EligibleCollateralReferences.md) |  | [optional] 
**Calculation** | [**MarginCalculation**](MarginCalculation.md) |  | 
**MarginAccounts** | [**MarginAccounts**](MarginAccounts.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string tradeFilter = "example tradeFilter";
string settlement = "example settlement";
string legalMechanism = "example legalMechanism";
PartyTerms wePost = new PartyTerms();
PartyTerms theyPost = new PartyTerms();
EligibleCollateralReferences? eligibleCollateral = new EligibleCollateralReferences();

MarginCalculation calculation = new MarginCalculation();
MarginAccounts? marginAccounts = new MarginAccounts();


MarginItem marginItemInstance = new MarginItem(
    code: code,
    tradeFilter: tradeFilter,
    settlement: settlement,
    legalMechanism: legalMechanism,
    wePost: wePost,
    theyPost: theyPost,
    eligibleCollateral: eligibleCollateral,
    calculation: calculation,
    marginAccounts: marginAccounts);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
