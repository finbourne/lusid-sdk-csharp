# Lusid.Sdk.Model.FxForwardInstrument
Lusid-ibor internal representation of a Fx Forward instrument
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DomAmount** | **double** | The amount that is to be paid in the domestic currency on the maturity date. | 
**FgnAmount** | **double** | The amount that is to be paid in the foreign currency on the maturity date | 
**IsNdf** | **bool** | Is the contract an Fx-Forward of \&quot;Non-Deliverable\&quot; type, meaning a single payment in the domestic currency based on  the change in fx-rate vs  a reference rate is used. | [optional] 
**FixingDate** | **DateTimeOffset** | The fixing date. Its presence determines the NDF status of the instrument. | [optional] 
**FgnCcy** | **string** | The foreign (other) currency of the instrument. In the NDF case, only payments are made in the domestic currency.  For the outright forward, currencies are exchanged. By domestic is then that of the portfolio. | 
**RefSpotRate** | **double** | The reference Fx Spot rate for currency pair Foreign-Domestic that was seen on the trade start date (time). | [optional] 
**StartDate** | **DateTimeOffset** | The start date of the instrument. This is normally synonymous with the trade-date. | 
**MaturityDate** | **DateTimeOffset** | The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates beyond their last payment date | 
**DomCcy** | **string** | The domestic currency of the instrument. | 
**InstrumentType** | **string** | Instrument type, must be property for JSON. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

