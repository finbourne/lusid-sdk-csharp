# Lusid.Sdk.Model.CreateTransactionPortfolioRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The name of the transaction portfolio. | 
**Description** | **string** | A description for the transaction portfolio. | [optional] 
**Code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies the transaction portfolio. | 
**Created** | **DateTimeOffset?** | The effective datetime at which to create the transaction portfolio. No transactions can be added to the transaction portfolio before this date. Defaults to the current LUSID system datetime if not specified. | [optional] 
**BaseCurrency** | **string** | The base currency of the transaction portfolio in ISO 4217 currency code format. | 
**CorporateActionSourceId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**AccountingMethod** | **string** | Determines the accounting treatment given to the transaction portfolio&#39;s tax lots. The available values are: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst | [optional] 
**SubHoldingKeys** | **List&lt;string&gt;** | A set of unique transaction properties to group the transaction portfolio&#39;s holdings by, perhaps for strategy tagging. Each property must be from the &#39;Transaction&#39; domain and identified by a key in the format {domain}/{scope}/{code}, for example &#39;Transaction/strategies/quantsignal&#39;. See https://support.lusid.com/knowledgebase/article/KA-01879/en-us for more information. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of unique portfolio properties to add custom data to the transaction portfolio. Each property must be from the &#39;Portfolio&#39; domain and identified by a key in the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. Note these properties must be pre-defined. | [optional] 
**InstrumentScopes** | **List&lt;string&gt;** | The resolution strategy used to resolve instruments of transactions/holdings upserted to this portfolio. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

