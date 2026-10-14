# Lusid.Sdk.Model.PartnerCapitalAccountRow
One row of the capital account statement with its quarter-, year- and inception-to-date amounts.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RowType** | **string** | The row type: BeginningCapital, Contributions, Distributions, TransfersIn, TransfersOut, NetOperatingIncome, ManagementFeesGross, ManagementFeeOffsets, RealisedGainLoss, UnrealisedGainLoss, CarriedInterest or EndingCapital. | 
**Qtd** | **decimal** | The quarter-to-date amount for the row. | 
**Ytd** | **decimal** | The year-to-date amount for the row. | 
**Itd** | **decimal** | The inception-to-date amount for the row. | 

```csharp
using Lusid.Sdk.Model;
using System;

string rowType = "rowType";decimal qtd = "qtd";
decimal ytd = "ytd";
decimal itd = "itd";


PartnerCapitalAccountRow partnerCapitalAccountRowInstance = new PartnerCapitalAccountRow(
    rowType: rowType,
    qtd: qtd,
    ytd: ytd,
    itd: itd);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
