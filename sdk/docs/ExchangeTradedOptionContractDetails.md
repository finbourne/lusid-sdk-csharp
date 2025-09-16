# Lusid.Sdk.Model.ExchangeTradedOptionContractDetails
Most, if not all, information about contracts is standardised. See, e.g. https://www.cmegroup.com/ for  common codes and similar data. This appears to be in common use by well known market information providers, e.g. Bloomberg and Refinitiv.  There is a lot of overlap with this and FuturesContractDetails but as that is an established DTO we must duplicate a number of fields here

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DomCcy** | **string** | Currency in which the contract is paid. | 
**Strike** | **decimal** | The option strike, this can be negative for some options. | 
**ContractSize** | **decimal** | Size of a single contract. By default this should be set to 1000 if otherwise unknown and is defaulted to such. | 
**Country** | **string** | Country (code) for the exchange. | 
**DeliveryType** | **string** | The delivery type, cash or physical. An option on a future is physically settled if upon exercising the  holder receives a future.    Supported string (enumeration) values are: [Cash, Physical]. | 
**Description** | **string** | Description of contract | 
**ExchangeCode** | **string** | Exchange code for contract. This can be any string to uniquely identify the exchange (e.g. Exchange Name, MIC, BBG code). | 
**ExerciseDate** | **DateTimeOffset** | The last exercise date of the option. | 
**ExerciseType** | **string** | The exercise type, European, American or Bermudan.    Supported string (enumeration) values are: [European, Bermudan, American]. | 
**OptionCode** | **string** | Option Contract Code, typically one or two letters, e.g. OG &#x3D;&gt; Option on Gold. | 
**OptionType** | **string** | The option type, Call or Put.    Supported string (enumeration) values are: [Call, Put]. | 
**Underlying** | [**LusidInstrument**](LusidInstrument.md) |  | 
**UnderlyingCode** | **string** | Code of the underlying, for an option on futures this should be the futures code. | 
**DeliveryDays** | **int** | Number of business days between exercise date and settlement of the option payoff or underlying.  Defaults to 0 if not set. | [optional] 
**BusinessDayConvention** | **string** | The adjustment type to apply to dates that fall upon a non-business day, e.g. modified following or following.  Supported string (enumeration) values are: [NoAdjustment, Previous, P, Following, F, ModifiedPrevious, MP, ModifiedFollowing, MF, HalfMonthModifiedFollowing, Nearest].  Defaults to \&quot;F\&quot; if not set. | [optional] 
**SettlementCalendars** | **List&lt;string&gt;** | An array of strings denoting calendars used in calculating the option settlement date. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string domCcy = "domCcy";decimal strike = "strike";
decimal contractSize = "contractSize";

string country = "country";
string deliveryType = "deliveryType";
string description = "description";
string exchangeCode = "exchangeCode";
string exerciseType = "exerciseType";
string optionCode = "optionCode";
string optionType = "optionType";
LusidInstrument underlying = new LusidInstrument();
string underlyingCode = "underlyingCode";
string businessDayConvention = "example businessDayConvention";
List<string> settlementCalendars = new List<string>();

ExchangeTradedOptionContractDetails exchangeTradedOptionContractDetailsInstance = new ExchangeTradedOptionContractDetails(
    domCcy: domCcy,
    strike: strike,
    contractSize: contractSize,
    country: country,
    deliveryType: deliveryType,
    description: description,
    exchangeCode: exchangeCode,
    exerciseDate: exerciseDate,
    exerciseType: exerciseType,
    optionCode: optionCode,
    optionType: optionType,
    underlying: underlying,
    underlyingCode: underlyingCode,
    deliveryDays: deliveryDays,
    businessDayConvention: businessDayConvention,
    settlementCalendars: settlementCalendars);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
