# Lusid.Sdk.Model.PricingOptions
Options for controlling the default aspects and behaviour of the pricing engine.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModelSelection** | [**ModelSelection**](ModelSelection.md) |  | [optional] 
**UseInstrumentTypeToDeterminePricer** | **bool** | If true then use the instrument type to set the default instrument pricer  This applies where no more specific set of overrides are provided on a per-vendor and instrument basis. | [optional] 
**AllowAnyInstrumentsWithSecUidToPriceOffLookup** | **bool** | By default, one would not expect to price and exotic instrument, i.e. an instrument with a complicated  instrument definition simply through looking up a price as there should be a better way of evaluating it.  To override that behaviour and allow lookup for a price from the instrument identifier(s), set this to true. | [optional] 
**AllowPartiallySuccessfulEvaluation** | **bool** | If true then a failure in task evaluation doesn&#39;t cause overall failure.  results will be returned where they succeeded and annotation elsewhere | [optional] 
**ProduceSeparateResultForLinearOtcLegs** | **bool** | If true (default), when pricing an Fx-Forward or Interest Rate Swap, Future and other linearly separable products, product two results, one for each leg  rather than a single line result with the amalgamated/summed pv from both legs. | [optional] 
**EnableUseOfCachedUnitResults** | **bool** | If true, when pricing using a model or for an instrument that supports use of intermediate cached-results, use them.  Default is that this caching is turned off. | [optional] 
**WindowValuationOnInstrumentStartEnd** | **bool** | If true, when valuing an instrument outside the period where it is &#39;alive&#39; (the start-maturity window) it will return a valuation of zero | [optional] 
**RemoveContingentCashflowsInPaymentDiary** | **bool** | When creating a payment diary, should contingent cash payments (e.g. from exercise of a swaption into a swap) be included or not.  i.e. Is exercise or default being assumed to happen or not. | [optional] 
**UseChildSubHoldingKeysForPortfolioExpansion** | **bool** | Should fund constituents inherit subholding keys from the parent subholding keyb | [optional] 
**ValidateDomesticAndQuoteCurrenciesAreConsistent** | **bool** | Do we validate that the instrument domestic currency matches the quote currency (unless unknown/zzz) when using lookup pricing. | [optional] 
**ConservedQuantityForLookthroughExpansion** | **string** | When performing lookthrough portfolio expansion with ScalingMethodology set to \&quot;Sum\&quot; or \&quot;AbsoluteSum\&quot;,  the quantity specified here will be conserved and apportioned to lookthrough constituents.  For example, an equal-weighting index with 100 constituents can be modelled as a reference portfolio with 1% weights on each equity.  When expanding a $9000 holding of that index into its constituents while conserving PV, we end up with $90 of each equity.  The number of units of each equity held is then implied.  Note that conservation of one quantity may imply non-conservation of others, especially when some constituents are OTCs.                Allowed values are: \&quot;PV\&quot; (default), \&quot;Exposure\&quot;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

