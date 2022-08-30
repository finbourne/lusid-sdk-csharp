# Lusid.Sdk.Model.CreateDerivedTransactionPortfolioRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The name of the derived transaction portfolio. | 
**Description** | **string** | A description for the derived transaction portfolio. | [optional] 
**Code** | **string** | The code of the derived transaction portfolio. Together with the scope this uniquely identifies the derived transaction portfolio. | 
**ParentPortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**Created** | **DateTimeOffset?** | This will be auto-populated to be the parent portfolio creation date. | [optional] 
**CorporateActionSourceId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**AccountingMethod** | **string** | Determines the accounting treatment given to the transaction portfolio&#39;s tax lots. The available values are: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst | [optional] 
**SubHoldingKeys** | **List&lt;string&gt;** | A set of unique transaction properties to group the derived transaction portfolio&#39;s holdings by, perhaps for strategy tagging. Each property must be from the &#39;Transaction&#39; domain and identified by a key in the format {domain}/{scope}/{code}, for example &#39;Transaction/strategies/quantsignal&#39;. See https://support.lusid.com/knowledgebase/article/KA-01879/en-us for more information. | [optional] 
**InstrumentScopes** | **List&lt;string&gt;** | The resolution strategy used to resolve instruments of transactions/holdings upserted to this derived portfolio. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

