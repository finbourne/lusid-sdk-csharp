# Lusid.Sdk.Model.PreferredShareAllOfIdentifiers
External market codes and identifiers for the share, e.g. its ISIN. A series is mastered once  per distinct security and shared across every holder.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LusidInstrumentId** | **string** |  | [optional] 
**Isin** | **string** |  | [optional] 
**Sedol** | **string** |  | [optional] 
**Cusip** | **string** |  | [optional] 
**ClientInternal** | **string** |  | [optional] 
**Figi** | **string** |  | [optional] 
**RIC** | **string** |  | [optional] 
**QuotePermId** | **string** |  | [optional] 
**REDCode** | **string** |  | [optional] 
**BBGId** | **string** |  | [optional] 
**ICECode** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string lusidInstrumentId = "example lusidInstrumentId";
string isin = "example isin";
string sedol = "example sedol";
string cusip = "example cusip";
string clientInternal = "example clientInternal";
string figi = "example figi";
string rIC = "example rIC";
string quotePermId = "example quotePermId";
string rEDCode = "example rEDCode";
string bBGId = "example bBGId";
string iCECode = "example iCECode";

PreferredShareAllOfIdentifiers preferredShareAllOfIdentifiersInstance = new PreferredShareAllOfIdentifiers(
    lusidInstrumentId: lusidInstrumentId,
    isin: isin,
    sedol: sedol,
    cusip: cusip,
    clientInternal: clientInternal,
    figi: figi,
    rIC: rIC,
    quotePermId: quotePermId,
    rEDCode: rEDCode,
    bBGId: bBGId,
    iCECode: iCECode);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
