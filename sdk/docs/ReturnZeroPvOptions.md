# Lusid.Sdk.Model.ReturnZeroPvOptions
Options to indicate which errors to ignore when performing valuation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentMatured** | **bool** | Indicates whether attempting to value an instrument after its maturity date should produce a failure (false)  or a zero PV (true). | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool instrumentMatured = //"True";

ReturnZeroPvOptions returnZeroPvOptionsInstance = new ReturnZeroPvOptions(
    instrumentMatured: instrumentMatured);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
