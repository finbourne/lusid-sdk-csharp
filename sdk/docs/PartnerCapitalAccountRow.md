# Lusid.Sdk.Model.PartnerCapitalAccountRow
One row of the capital account statement with its quarter-, year- and inception-to-date amounts.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RowType** | **string** | The row type: BeginningCapital, Contributions, Distributions, TransfersIn, TransfersOut, NetOperatingIncome, ManagementFeesGross, ManagementFeeOffsets, RealisedGainLoss, UnrealisedGainLoss, CarriedInterest or EndingCapital. | 
**Qtd** | **decimal** | The quarter-to-date amount for the row. | 
**Ytd** | **decimal** | The year-to-date amount for the row. | 
**Itd** | **decimal** | The inception-to-date amount for the row. | 
**Details** | [**List&lt;PartnerCapitalAccountRowDetail&gt;**](PartnerCapitalAccountRowDetail.md) | Labelled parts of the row&#39;s total, each already included in the row&#39;s columns. Tax withheld from a distribution on the partner&#39;s behalf is counted as distributed and shown here as its own entry against the distribution it was withheld on. Empty for a row with nothing to break out. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string rowType = "rowType";decimal qtd = "qtd";
decimal ytd = "ytd";
decimal itd = "itd";

List<PartnerCapitalAccountRowDetail> details = new List<PartnerCapitalAccountRowDetail>();

PartnerCapitalAccountRow partnerCapitalAccountRowInstance = new PartnerCapitalAccountRow(
    rowType: rowType,
    qtd: qtd,
    ytd: ytd,
    itd: itd,
    details: details);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
