# Lusid.Sdk.Model.PaymentDetailsSeriesIdentifiers
The two hardcoded series identifier keys that uniquely identify a Payment Details data series.  The currency value must match the top-level currency field on the Payment Instruction.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentType** | **string** | The type of payment series. | 
**Currency** | **string** | ISO 4217 currency code identifying the currency-specific series row. Must match the top-level currency field. | 
**CustodianAccountScope** | **string** | Optional. The scope of the custodian account on the portfolio. Only permitted when the applicable entity is a Portfolio. | [optional] 
**CustodianAccountCode** | **string** | Optional. The code of the custodian account on the portfolio. Only permitted when the applicable entity is a Portfolio. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string paymentType = "paymentType";
string currency = "currency";
string custodianAccountScope = "example custodianAccountScope";
string custodianAccountCode = "example custodianAccountCode";

PaymentDetailsSeriesIdentifiers paymentDetailsSeriesIdentifiersInstance = new PaymentDetailsSeriesIdentifiers(
    paymentType: paymentType,
    currency: currency,
    custodianAccountScope: custodianAccountScope,
    custodianAccountCode: custodianAccountCode);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
