# Lusid.Sdk.Model.PartnerInterestShare
How a holder's partner interest in a held fund structure member flowed when the valuation point was struck: from  the member's booked partner allocation, from a dry run of it, at a provisional share of committed capital, or at  the sharing percentage the fund structure edge declares.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Holder** | **string** | The short code of the holding fund, as the fund structure names it. | 
**Member** | **string** | The short code of the held fund structure member whose P&amp;L flowed. | 
**ViaInstrumentId** | **string** | The LUSID instrument id of the instrument the holder holds the member through: the holder&#39;s line on the member&#39;s partner register. | 
**ShareSource** | **string** | Where the holder&#39;s share of the member&#39;s P&amp;L came from. &#39;MemberBooked&#39;: the member&#39;s booked partner allocation to the holder&#39;s line for the period, pool by pool, which a Final valuation point requires. &#39;MemberDryRun&#39;: the member has not booked the period, so a dry run of its allocation gave the holder&#39;s line what the booking would; the point cannot be accepted until the member books and the point is struck again. &#39;Provisional&#39;: the member cannot be allocated yet, so the member&#39;s P&amp;L flowed at the line&#39;s committed capital over the register total; the point cannot be accepted until the member books and the point is struck again. &#39;Declared&#39;: the via instrument is not a line of the member&#39;s register, or the register carries no commitments, so the edge&#39;s declared sharing percentage was used; the valuation point&#39;s diagnostics name the fall-back. | 
**Reason** | **string** | Why a provisional or declared share was taken. Absent when the share came from the member&#39;s allocation. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string holder = "holder";
string member = "member";
string viaInstrumentId = "viaInstrumentId";
string shareSource = "shareSource";
string reason = "example reason";

PartnerInterestShare partnerInterestShareInstance = new PartnerInterestShare(
    holder: holder,
    member: member,
    viaInstrumentId: viaInstrumentId,
    shareSource: shareSource,
    reason: reason);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
