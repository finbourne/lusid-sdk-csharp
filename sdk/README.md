# LusidSdk - the C# library for the LUSID API

# Introduction  This page documents the [LUSID APIs](https://api.finbourne.com/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages :  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python)  # Data Model  The LUSID API has a relatively lightweight but extremely powerful data model.   One of the goals of LUSID was not to enforce on clients a single rigid data model but rather to provide a flexible foundation onto which clients can streamline their data.   One of the primary tools to extend the data model is through using properties.  Properties can be associated with amongst others: - * Transactions * Instruments * Portfolios   The LUSID data model is exposed through the LUSID APIs.  The APIs provide access to both business objects and the meta data used to configure the systems behaviours.   The key business entities are: - * **Portfolios** A portfolio is the primary container for transactions and holdings.  * **Derived Portfolios** Derived portfolios allow portfolios to be created based on other portfolios, by overriding or overlaying specific items * **Holdings** A holding is a position account for a instrument within a portfolio.  Holdings can only be adjusted via transactions. * **Transactions** A Transaction is a source of transactions used to manipulate holdings.  * **Corporate Actions** A corporate action is a market event which occurs to a instrument, for example a stock split * **Instruments**  A instrument represents a currency, tradable instrument or OTC contract that is attached to a transaction and a holding. * **Properties** Several entities allow additional user defined properties to be associated with them.   For example, a Portfolio manager may be associated with a portfolio  Meta data includes: - * **Transaction Types** Transactions are booked with a specific transaction type.  The types are client defined and are used to map the Transaction to a series of movements which update the portfolio holdings.  * **Properties Types** Types of user defined properties used within the system.  This section describes the data model that LUSID exposes via the APIs.  ## Scope  All data in LUSID is segregated at the client level.  Entities in LUSID are identifiable by a unique code.  Every entity lives within a logical data partition known as a Scope.  Scope is an identity namespace allowing two entities with the same unique code to co-exist within individual address spaces.  For example, prices for equities from different vendors may be uploaded into different scopes such as `client/vendor1` and `client/vendor2`.  A portfolio may then be valued using either of the price sources by referencing the appropriate scope.  LUSID Clients cannot access scopes of other clients.  ## Schema  A detailed description of the entities used by the API and parameters for endpoints which take a JSON document can be retrieved via the `schema` endpoint.  ## Instruments  LUSID has its own instrument master implementation (LUSID CORE) which sources reference data from multiple data vendors. [OpenFIGI](https://openfigi.com/) and [PermID](https://permid.org/) are used as the instrument identifier when uploading transactions, holdings, prices, etc. The API exposes a `instrument/lookup` endpoint which can be used to lookup these identifiers given other market identifiers.  Cash can be referenced using the ISO currency code prefixed with \"`CCY_`\" e.g. `CCY_GBP`  For any instrument that are not recognised by LUSID (eg OTCs) a client can upload a client defined instrument. Securitised portfolios and funds can be modelled as client defined instruments.  ## Instrument Prices (Analytics)  Instrument prices are stored in LUSID's Analytics Store  | Field|Type|Description | | - --|- --|- -- | | InstrumentUid|string|Unique instrument identifier | | Value|decimal|Value of the analytic, eg price | | Denomination|string|Underlying unit of the analytic, eg currency, EPS etc. |   ## Instrument Data  Instrument data can be uploaded to the system using the [Instrument Properties](#tag/InstrumentProperties) endpoint.  | Field|Type|Description | | - --|- --|- -- | | InstrumentUid|string|Unique instrument identifier |   ## Portfolios  Portfolios are the top-level entity containers within LUSID, containing transactions, corporate actions and holdings.    The transactions build up the portfolio holdings on which valuations, analytics profit & loss and risk can be calculated.     Properties can be associated with Portfolios to add in additional model data.  Portfolio properties can be changed over time as well.  For example, to allow a Portfolio Manager to be linked with a Portfolio.  Additionally, portfolios can be securitised and held by other portfolios, allowing LUSID to perform \"drill-through\" into underlying fund holdings  ### Reference Portfolios Reference portfolios are portfolios that contain only holdings or weights, as opposed to transactions, and are designed to represent entities such as indices.  ### Derived Portfolios  LUSID also allows for a portfolio to be composed of another portfolio via derived portfolios.  A derived portfolio can contain its own transactions and also inherits any transactions from its parent portfolio.  Any changes made to the parent portfolio are automatically reflected in derived portfolio.  Derived portfolios in conjunction with scopes are a powerful construct.  For example, to do pre-trade what-if analysis, a derived portfolio could be created a new namespace linked to the underlying live (parent) portfolio.  Analysis can then be undertaken on the derived portfolio without affecting the live portfolio.  ### Portfolio Groups Portfolio groups allow the construction of a hierarchy from portfolios and groups.  Portfolio operations on the group are executed on an aggregated set of portfolios in the hierarchy.   For example:   * Global Portfolios _(group)_   * APAC _(group)_     * Hong Kong _(portfolio)_     * Japan _(portfolio)_   * Europe _(group)_     * France _(portfolio)_     * Germany _(portfolio)_   * UK _(portfolio)_   In this example **Global Portfolios** is a group that consists of an aggregate of **Hong Kong**, **Japan**, **France**, **Germany** and **UK** portfolios.  ### Movements Engine The Movements engine sits on top of the immutable event store and is used to manage the relationship between input trading actions and their associated portfolio holdings.     The movements engine reads in the following entity types:- * Posting Transactions * Applying Corporate Actions  * Holding Adjustments  These are converted to one or more movements and used by the movements engine to calculate holdings.  At the same time it also calculates running balances, and realised P&L.  The outputs from the movements engine are holdings and transactions.  ## Transactions    A transaction represents an economic activity against a Portfolio.    Transactions are processed according to a configuration. This will tell the LUSID engine how to interpret the transaction and correctly update the holdings. LUSID comes with a set of transaction types you can use out of the box, or you can configure your own set(s) of transactions.    For more details see the [LUSID Getting Started Guide for transaction configuration.](https://support.finbourne.com/hc/en-us/articles/360016737511-Configuring-Transaction-Types)    | Field|Type|Description | | - --|- --|- -- | | TransactionId|string|Unique transaction identifier | | Type|string|LUSID transaction type code - Buy, Sell, StockIn, StockOut, etc | | InstrumentUid|string|Unique instrument identifier | | TransactionDate|datetime|Transaction date | | SettlementDate|datetime|Settlement date | | Units|decimal|Quantity of transaction in units of the instrument | | TransactionPrice|tradeprice|Execution price for the transaction | | TotalConsideration|currencyandamount|Total value of the transaction | | ExchangeRate|decimal|Rate between transaction and settle currency | | TransactionCurrency|currency|Transaction currency | | CounterpartyId|string|Counterparty identifier | | Source|string|Where this transaction came from | | NettingSet|string|  |     ### Example Transactions    #### A Common Purchase Example  Three example transactions are shown in the table below.     They represent a purchase of USD denominated IBM shares within a Sterling denominated portfolio.     * The first two transactions are for separate buy and fx trades     * Buying 500 IBM shares for $71,480.00     * A foreign exchange conversion to fund the IBM purchase. (Buy $71,480.00 for &#163;54,846.60)   * The third transaction is an alternate version of the above trades. Buying 500 IBM shares and settling directly in Sterling.    | Column |  Buy Trade | Fx Trade | Buy Trade with foreign Settlement |  | - -- -- | - -- -- | - -- -- | - -- -- |  | TransactionId | FBN00001 | FBN00002 | FBN00003 |  | Type | Buy | FxBuy | Buy |  | InstrumentUid | FIGI_BBG000BLNNH6 | CCY_USD | FIGI_BBG000BLNNH6 |  | TransactionDate | 2018-08-02 | 2018-08-02 | 2018-08-02 |  | SettlementDate | 2018-08-06 | 2018-08-06 | 2018-08-06 |  | Units | 500 | 71480 | 500 |  | TransactionPrice | 142.96 | 1 | 142.96 |  | TradeCurrency | USD | USD | USD |  | ExchangeRate | 1 | 0.7673 | 0.7673 |  | TotalConsideration.Amount | 71480.00 | 54846.60 | 54846.60 |  | TotalConsideration.Currency | USD | GBP | GBP |  | Trade/default/TradeToPortfolioRate&ast; | 0.7673 | 0.7673 | 0.7673 |    [&ast; This is a property field]    #### A Forward FX Example    LUSID has a flexible transaction modelling system, and there are a number of different ways of modelling forward fx trades.    The default LUSID transaction types are FwdFxBuy and FwdFxSell. Other types and behaviours can be configured as required.    Using these transaction types, the holdings query will report two forward positions. One in each currency.     Since an FX trade is an exchange of one currency for another, the following two 6 month forward transactions are equivalent:    | Column |  Forward 'Sell' Trade | Forward 'Buy' Trade |  | - -- -- | - -- -- | - -- -- |  | TransactionId | FBN00004 | FBN00005 |  | Type | FwdFxSell | FwdFxBuy |  | InstrumentUid | CCY_GBP | CCY_USD |  | TransactionDate | 2018-08-02 | 2018-08-02 |  | SettlementDate | 2019-02-06 | 2019-02-06 |  | Units | 10000.00 | 13142.00 |  | TransactionPrice |1 | 1 |  | TradeCurrency | GBP | USD |  | ExchangeRate | 1.3142 | 0.760919 |  | TotalConsideration.Amount | 13142.00 | 10000.00 |  | TotalConsideration.Currency | USD | GBP |  | Trade/default/TradeToPortfolioRate | 1.0 | 0.760919 |  ## Holdings  A holding represents a position in a instrument or cash on a given date.  | Field|Type|Description | | - --|- --|- -- | | InstrumentUid|string|Unique instrument identifier | | HoldingType|string|Type of holding, eg Position, Balance, CashCommitment, Receivable, ForwardFX | | Units|decimal|Quantity of holding | | SettledUnits|decimal|Settled quantity of holding | | Cost|currencyandamount|Book cost of holding in transaction currency | | CostPortfolioCcy|currencyandamount|Book cost of holding in portfolio currency | | Transaction|TransactionDto|If this is commitment-type holding, the transaction behind it |   ## Corporate Actions  Corporate actions are represented within LUSID in terms of a set of instrument-specific 'transitions'.  These transitions are used to specify the participants of the corporate action, and the effect that the corporate action will have on holdings in those participants.  *Corporate action*  | Field|Type|Description | | - --|- --|- -- | | SourceId|id|  | | CorporateActionCode|code|  | | AnnouncementDate|datetime|  | | ExDate|datetime|  | | RecordDate|datetime|  | | PaymentDate|datetime|  |    *Transition*  | Field|Type|Description | | - --|- --|- -- |   ## Property  Properties are key-value pairs that can be applied to any entity within a domain (where a domain is `trade`, `portfolio`, `security` etc).  Properties must be defined before use with a `PropertyDefinition` and can then subsequently be added to entities.  # Schemas  The following headers are returned on all responses from LUSID  | Name | Purpose | | - -- | - -- | | lusid-meta-duration | Duration of the request | | lusid-meta-success | Whether or not LUSID considered the request to be successful | | lusid-meta-requestId | The unique identifier for the request | | lusid-schema-url | Url of the schema for the data being returned | | lusid-property-schema-url | Url of the schema for any properties |  # Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"100\">100</a>|Personalisations not found|The personalisation(s) identified by the pattern provided could not be found, either because it does not exist or it has been deleted. Please check the pattern your provided. | | <a name=\"101\">101</a>|NonRecursivePersonalisation|  | | <a name=\"102\">102</a>|VersionNotFound|  | | <a name=\"104\">104</a>|InstrumentNotFound|  | | <a name=\"105\">105</a>|PropertyNotFound|  | | <a name=\"106\">106</a>|PortfolioRecursionDepth|  | | <a name=\"108\">108</a>|GroupNotFound|  | | <a name=\"109\">109</a>|PortfolioNotFound|  | | <a name=\"110\">110</a>|PropertySchemaNotFound|  | | <a name=\"111\">111</a>|PortfolioAncestryNotFound|  | | <a name=\"112\">112</a>|PortfolioWithIdAlreadyExists|  | | <a name=\"113\">113</a>|OrphanedPortfolio|  | | <a name=\"119\">119</a>|MissingBaseClaims|  | | <a name=\"121\">121</a>|PropertyNotDefined|  | | <a name=\"122\">122</a>|CannotDeleteSystemProperty|  | | <a name=\"123\">123</a>|CannotModifyImmutablePropertyField|  | | <a name=\"124\">124</a>|PropertyAlreadyExists|  | | <a name=\"125\">125</a>|InvalidPropertyLifeTime|  | | <a name=\"127\">127</a>|CannotModifyDefaultDataType|  | | <a name=\"128\">128</a>|GroupAlreadyExists|  | | <a name=\"129\">129</a>|NoSuchDataType|  | | <a name=\"132\">132</a>|ValidationError|  | | <a name=\"133\">133</a>|LoopDetectedInGroupHierarchy|  | | <a name=\"135\">135</a>|SubGroupAlreadyExists|  | | <a name=\"138\">138</a>|PriceSourceNotFound|  | | <a name=\"139\">139</a>|AnalyticStoreNotFound|  | | <a name=\"141\">141</a>|AnalyticStoreAlreadyExists|  | | <a name=\"143\">143</a>|ClientInstrumentAlreadyExists|  | | <a name=\"144\">144</a>|DuplicateInParameterSet|  | | <a name=\"147\">147</a>|ResultsNotFound|  | | <a name=\"148\">148</a>|OrderFieldNotInResultSet|  | | <a name=\"149\">149</a>|OperationFailed|  | | <a name=\"150\">150</a>|ElasticSearchError|  | | <a name=\"151\">151</a>|InvalidParameterValue|  | | <a name=\"153\">153</a>|CommandProcessingFailure|  | | <a name=\"154\">154</a>|EntityStateConstructionFailure|  | | <a name=\"155\">155</a>|EntityTimelineDoesNotExist|  | | <a name=\"156\">156</a>|EventPublishFailure|  | | <a name=\"157\">157</a>|InvalidRequestFailure|  | | <a name=\"158\">158</a>|EventPublishUnknown|  | | <a name=\"159\">159</a>|EventQueryFailure|  | | <a name=\"160\">160</a>|BlobDidNotExistFailure|  | | <a name=\"162\">162</a>|SubSystemRequestFailure|  | | <a name=\"163\">163</a>|SubSystemConfigurationFailure|  | | <a name=\"165\">165</a>|FailedToDelete|  | | <a name=\"166\">166</a>|UpsertClientInstrumentFailure|  | | <a name=\"167\">167</a>|IllegalAsAtInterval|  | | <a name=\"168\">168</a>|IllegalBitemporalQuery|  | | <a name=\"169\">169</a>|InvalidAlternateId|  | | <a name=\"170\">170</a>|CannotAddSourcePortfolioPropertyExplicitly|  | | <a name=\"171\">171</a>|EntityAlreadyExistsInGroup|  | | <a name=\"173\">173</a>|EntityWithIdAlreadyExists|  | | <a name=\"174\">174</a>|PortfolioDetailsDoNotExist|  | | <a name=\"176\">176</a>|PortfolioWithNameAlreadyExists|  | | <a name=\"177\">177</a>|InvalidTransactions|  | | <a name=\"178\">178</a>|ReferencePortfolioNotFound|  | | <a name=\"179\">179</a>|DuplicateIdFailure|  | | <a name=\"180\">180</a>|CommandRetrievalFailure|  | | <a name=\"181\">181</a>|DataFilterApplicationFailure|  | | <a name=\"182\">182</a>|SearchFailed|  | | <a name=\"183\">183</a>|MovementsEngineConfigurationKeyFailure|  | | <a name=\"184\">184</a>|FxRateSourceNotFound|  | | <a name=\"185\">185</a>|AccrualSourceNotFound|  | | <a name=\"186\">186</a>|EntitlementsFailure|  | | <a name=\"187\">187</a>|InvalidIdentityToken|  | | <a name=\"188\">188</a>|InvalidRequestHeaders|  | | <a name=\"189\">189</a>|PriceNotFound|  | | <a name=\"190\">190</a>|InvalidSubHoldingKeysProvided|  | | <a name=\"191\">191</a>|DuplicateSubHoldingKeysProvided|  | | <a name=\"200\">200</a>|InvalidUnitForDataType|  | | <a name=\"201\">201</a>|InvalidTypeForDataType|  | | <a name=\"202\">202</a>|InvalidValueForDataType|  | | <a name=\"203\">203</a>|UnitNotDefinedForDataType|  | | <a name=\"204\">204</a>|UnitsNotSupportedOnDataType|  | | <a name=\"205\">205</a>|CannotSpecifyUnitsOnDataType|  | | <a name=\"206\">206</a>|UnitSchemaInconsistentWithDataType|  | | <a name=\"207\">207</a>|UnitDefinitionNotSpecified|  | | <a name=\"208\">208</a>|DuplicateUnitDefinitionsSpecified|  | | <a name=\"209\">209</a>|InvalidUnitsDefinition|  | | <a name=\"210\">210</a>|InvalidInstrumentIdentifierUnit|  | | <a name=\"211\">211</a>|HoldingsAdjustmentDoesNotExist|  | | <a name=\"212\">212</a>|CouldNotBuildExcelUrl|  | | <a name=\"213\">213</a>|CouldNotGetExcelVersion|  | | <a name=\"214\">214</a>|InstrumentByCodeNotFound|  | | <a name=\"215\">215</a>|EntitySchemaDoesNotExist|  | | <a name=\"216\">216</a>|FeatureNotSupportedOnPortfolioType|  | | <a name=\"217\">217</a>|QuotePublishFailure|  | | <a name=\"218\">218</a>|QuoteQueryFailure|  | | <a name=\"219\">219</a>|InvalidInstrumentDefinition|  | | <a name=\"221\">221</a>|InstrumentUpsertFailure|  | | <a name=\"222\">222</a>|ReferencePortfolioRequestNotSupported|  | | <a name=\"223\">223</a>|TransactionPortfolioRequestNotSupported|  | | <a name=\"-10\">-10</a>|ServerConfigurationError|  | | <a name=\"-1\">-1</a>|Unknown error|  | 

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 0.7.72
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://www.finbourne.com](https://www.finbourne.com)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext
- UWP >=10.0

<a name="dependencies"></a>
## Dependencies
- FubarCoder.RestSharp.Portable.Core >=4.0.7
- FubarCoder.RestSharp.Portable.HttpClient >=4.0.7
- Newtonsoft.Json >=10.0.3

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using LusidSdk.Api;
using LusidSdk.Client;
using LusidSdk.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using LusidSdk.Api;
using LusidSdk.Client;
using LusidSdk.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AggregationApi();
            var scope = scope_example;  // string | The scope of the portfolio group
            var code = code_example;  // string | The code of the portfolio group
            var request = new AggregationRequest(); // AggregationRequest | The request specifying the parameters of the aggregation (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 

            try
            {
                // Aggregate data in a portfolio group
                ListAggregationResponse result = apiInstance.GetAggregationByGroup(scope, code, request, sortBy, start, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AggregationApi.GetAggregationByGroup: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AggregationApi* | [**GetAggregationByGroup**](docs/AggregationApi.md#getaggregationbygroup) | **POST** /api/portfoliogroups/{scope}/{code}/$aggregate | Aggregate data in a portfolio group
*AggregationApi* | [**GetAggregationByPortfolio**](docs/AggregationApi.md#getaggregationbyportfolio) | **POST** /api/portfolios/{scope}/{code}/$aggregate | Aggregate data in a portfolio
*AggregationApi* | [**GetAggregationByResultSet**](docs/AggregationApi.md#getaggregationbyresultset) | **POST** /api/results/{scope}/{resultsKey}/$aggregate | Aggregate using result data
*AggregationApi* | [**GetNestedAggregationByGroup**](docs/AggregationApi.md#getnestedaggregationbygroup) | **POST** /api/portfoliogroups/{scope}/{code}/$aggregatenested | Aggregate data in a portfolio group, as nested
*AnalyticsStoresApi* | [**CreateAnalyticStore**](docs/AnalyticsStoresApi.md#createanalyticstore) | **POST** /api/analytics | Create analytic store
*AnalyticsStoresApi* | [**DeleteAnalyticStore**](docs/AnalyticsStoresApi.md#deleteanalyticstore) | **DELETE** /api/analytics/{scope}/{year}/{month}/{day} | Delete analytic store
*AnalyticsStoresApi* | [**GetAnalyticStore**](docs/AnalyticsStoresApi.md#getanalyticstore) | **GET** /api/analytics/{scope}/{year}/{month}/{day} | Get analytic store
*AnalyticsStoresApi* | [**ListAnalyticStores**](docs/AnalyticsStoresApi.md#listanalyticstores) | **GET** /api/analytics | List analytic stores
*AnalyticsStoresApi* | [**SetAnalytics**](docs/AnalyticsStoresApi.md#setanalytics) | **PUT** /api/analytics/{scope}/{year}/{month}/{day}/prices | Set analytic data
*ApplicationMetadataApi* | [**GetExcelDownloadUrl**](docs/ApplicationMetadataApi.md#getexceldownloadurl) | **GET** /api/metadata/downloads/excel | Get Excel download url
*ApplicationMetadataApi* | [**GetLusidVersions**](docs/ApplicationMetadataApi.md#getlusidversions) | **GET** /api/metadata/versions | Get LUSID versions
*CorporateActionsApi* | [**BatchUpsertCorporateActions**](docs/CorporateActionsApi.md#batchupsertcorporateactions) | **POST** /api/corporateactions/{scope}/{code} | Upsert corporate actions
*CorporateActionsApi* | [**GetCorporateActions**](docs/CorporateActionsApi.md#getcorporateactions) | **GET** /api/corporateactions/{scope}/{code} | Get corporate actions
*DataTypesApi* | [**CreateDataType**](docs/DataTypesApi.md#createdatatype) | **POST** /api/datatypes | Create data type definition
*DataTypesApi* | [**GetDataType**](docs/DataTypesApi.md#getdatatype) | **GET** /api/datatypes/{scope}/{code} | Get data type definition
*DataTypesApi* | [**GetUnitsFromDataType**](docs/DataTypesApi.md#getunitsfromdatatype) | **GET** /api/datatypes/{scope}/{code}/units | Get units from data type
*DataTypesApi* | [**ListDataTypes**](docs/DataTypesApi.md#listdatatypes) | **GET** /api/datatypes/{scope} | List data types
*DataTypesApi* | [**UpdateDataType**](docs/DataTypesApi.md#updatedatatype) | **PUT** /api/datatypes/{scope}/{code} | Update data type definition
*DerivedTransactionPortfoliosApi* | [**CreateDerivedPortfolio**](docs/DerivedTransactionPortfoliosApi.md#createderivedportfolio) | **POST** /api/derivedtransactionportfolios/{scope} | Create derived transaction portfolio
*DerivedTransactionPortfoliosApi* | [**DeleteDerivedPortfolioDetails**](docs/DerivedTransactionPortfoliosApi.md#deletederivedportfoliodetails) | **DELETE** /api/derivedtransactionportfolios/{scope}/{code}/details | Delete portfolio details
*InstrumentsApi* | [**BatchAddClientInstruments**](docs/InstrumentsApi.md#batchaddclientinstruments) | **POST** /api/instruments | Create instrument
*InstrumentsApi* | [**BatchDeleteClientInstruments**](docs/InstrumentsApi.md#batchdeleteclientinstruments) | **DELETE** /api/instruments | Delete instrument
*InstrumentsApi* | [**BatchUpsertInstrumentProperties**](docs/InstrumentsApi.md#batchupsertinstrumentproperties) | **POST** /api/instruments/$upsertproperties | Upsert instrument properties
*InstrumentsApi* | [**GetInstrument**](docs/InstrumentsApi.md#getinstrument) | **GET** /api/instruments/{uid} | Get instrument definition
*InstrumentsApi* | [**LookupInstrumentsFromCodes**](docs/InstrumentsApi.md#lookupinstrumentsfromcodes) | **POST** /api/instruments/$lookup | Lookup instrument definition
*LoginApi* | [**GetSamlIdentityProviderId**](docs/LoginApi.md#getsamlidentityproviderid) | **GET** /api/login/saml/{domain} | Get SAML Identity Provider
*PersonalisationsApi* | [**DeletePersonalisation**](docs/PersonalisationsApi.md#deletepersonalisation) | **DELETE** /api/personalisations | Delete a personalisation
*PersonalisationsApi* | [**GetPersonalisations**](docs/PersonalisationsApi.md#getpersonalisations) | **GET** /api/personalisations | Get personalisation
*PersonalisationsApi* | [**UpsertPersonalisations**](docs/PersonalisationsApi.md#upsertpersonalisations) | **POST** /api/personalisations | Upsert personalisations
*PortfolioGroupsApi* | [**AddPortfolioToGroup**](docs/PortfolioGroupsApi.md#addportfoliotogroup) | **POST** /api/portfoliogroups/{scope}/{code}/portfolios | Add portfolio to group
*PortfolioGroupsApi* | [**AddSubGroupToGroup**](docs/PortfolioGroupsApi.md#addsubgrouptogroup) | **POST** /api/portfoliogroups/{scope}/{code}/subgroups | Add group to group
*PortfolioGroupsApi* | [**CreatePortfolioGroup**](docs/PortfolioGroupsApi.md#createportfoliogroup) | **POST** /api/portfoliogroups/{scope} | Create group
*PortfolioGroupsApi* | [**DeletePortfolioFromGroup**](docs/PortfolioGroupsApi.md#deleteportfoliofromgroup) | **DELETE** /api/portfoliogroups/{scope}/{code}/portfolios/{portfolioScope}/{portfolioCode} | Remove portfolio from group
*PortfolioGroupsApi* | [**DeletePortfolioGroup**](docs/PortfolioGroupsApi.md#deleteportfoliogroup) | **DELETE** /api/portfoliogroups/{scope}/{code} | Delete group
*PortfolioGroupsApi* | [**DeleteSubGroupFromGroup**](docs/PortfolioGroupsApi.md#deletesubgroupfromgroup) | **DELETE** /api/portfoliogroups/{scope}/{code}/subgroups/{subgroupScope}/{subgroupCode} | Remove group from group
*PortfolioGroupsApi* | [**GetPortfolioGroup**](docs/PortfolioGroupsApi.md#getportfoliogroup) | **GET** /api/portfoliogroups/{scope}/{code} | Get portfolio group
*PortfolioGroupsApi* | [**GetPortfolioGroupCommands**](docs/PortfolioGroupsApi.md#getportfoliogroupcommands) | **GET** /api/portfoliogroups/{scope}/{code}/commands | Get commands
*PortfolioGroupsApi* | [**GetPortfolioGroupExpansion**](docs/PortfolioGroupsApi.md#getportfoliogroupexpansion) | **GET** /api/portfoliogroups/{scope}/{code}/expansion | Get a full expansion of a portfolio group
*PortfolioGroupsApi* | [**ListPortfolioGroups**](docs/PortfolioGroupsApi.md#listportfoliogroups) | **GET** /api/portfoliogroups/{scope} | List groups in scope
*PortfolioGroupsApi* | [**UpdatePortfolioGroup**](docs/PortfolioGroupsApi.md#updateportfoliogroup) | **PUT** /api/portfoliogroups/{scope}/{code} | Update group
*PortfoliosApi* | [**DeletePortfolio**](docs/PortfoliosApi.md#deleteportfolio) | **DELETE** /api/portfolios/{scope}/{code} | Delete portfolio
*PortfoliosApi* | [**DeletePortfolioProperties**](docs/PortfoliosApi.md#deleteportfolioproperties) | **DELETE** /api/portfolios/{scope}/{code}/properties | Delete portfolios
*PortfoliosApi* | [**GetPortfolio**](docs/PortfoliosApi.md#getportfolio) | **GET** /api/portfolios/{scope}/{code} | Get portfolio definition
*PortfoliosApi* | [**GetPortfolioCommands**](docs/PortfoliosApi.md#getportfoliocommands) | **GET** /api/portfolios/{scope}/{code}/commands | Get commands
*PortfoliosApi* | [**GetPortfolioProperties**](docs/PortfoliosApi.md#getportfolioproperties) | **GET** /api/portfolios/{scope}/{code}/properties | Get portfolio properties
*PortfoliosApi* | [**ListPortfolioScopes**](docs/PortfoliosApi.md#listportfolioscopes) | **GET** /api/portfolios | List portfolio scopes
*PortfoliosApi* | [**ListPortfolios**](docs/PortfoliosApi.md#listportfolios) | **GET** /api/portfolios/{scope} | List portfolios
*PortfoliosApi* | [**UpdatePortfolio**](docs/PortfoliosApi.md#updateportfolio) | **PUT** /api/portfolios/{scope}/{code} | Update portfolio definition
*PortfoliosApi* | [**UpsertPortfolioProperties**](docs/PortfoliosApi.md#upsertportfolioproperties) | **POST** /api/portfolios/{scope}/{code}/properties | Upsert properties
*PropertyDefinitionsApi* | [**CreatePropertyDefinition**](docs/PropertyDefinitionsApi.md#createpropertydefinition) | **POST** /api/propertydefinitions | Define a new property
*PropertyDefinitionsApi* | [**DeletePropertyDefinition**](docs/PropertyDefinitionsApi.md#deletepropertydefinition) | **DELETE** /api/propertydefinitions/{domain}/{scope}/{code} | Delete the definition of the specified property
*PropertyDefinitionsApi* | [**GetMultiplePropertyDefinitions**](docs/PropertyDefinitionsApi.md#getmultiplepropertydefinitions) | **GET** /api/propertydefinitions | Get one or more property definitions
*PropertyDefinitionsApi* | [**GetPropertyDefinition**](docs/PropertyDefinitionsApi.md#getpropertydefinition) | **GET** /api/propertydefinitions/{domain}/{scope}/{code} | Retrieve the definition for the identified property
*PropertyDefinitionsApi* | [**UpdatePropertyDefinition**](docs/PropertyDefinitionsApi.md#updatepropertydefinition) | **PUT** /api/propertydefinitions/{domain}/{scope}/{code} | Update the definition of the specified existing property
*ReconciliationsApi* | [**ReconcileHoldings**](docs/ReconciliationsApi.md#reconcileholdings) | **POST** /api/portfolios/$reconcileholdings | Reconcile portfolio holdings
*ReferencePortfolioApi* | [**CreateReferencePortfolio**](docs/ReferencePortfolioApi.md#createreferenceportfolio) | **POST** /api/referenceportfolios/{scope} | Create reference portfolio
*ReferencePortfolioApi* | [**GetReferencePortfolioConstituents**](docs/ReferencePortfolioApi.md#getreferenceportfolioconstituents) | **GET** /api/referenceportfolios/{scope}/{code}/{effectiveAt}/constituents | 
*ReferencePortfolioApi* | [**UpsertReferencePortfolioConstituents**](docs/ReferencePortfolioApi.md#upsertreferenceportfolioconstituents) | **POST** /api/referenceportfolios/{scope}/{code}/{effectiveAt}/constituents | Add constituents
*ResultsApi* | [**GetResults**](docs/ResultsApi.md#getresults) | **GET** /api/results/{scope}/{key}/{date} | Get results
*ResultsApi* | [**UpsertResults**](docs/ResultsApi.md#upsertresults) | **POST** /api/results/{scope}/{key}/{date} | Upsert results
*SchemasApi* | [**GetEntitySchema**](docs/SchemasApi.md#getentityschema) | **GET** /api/schemas/entities/{entity} | Get schema
*SchemasApi* | [**GetPropertySchema**](docs/SchemasApi.md#getpropertyschema) | **GET** /api/schemas/properties | Get property schema
*SchemasApi* | [**GetValueTypes**](docs/SchemasApi.md#getvaluetypes) | **GET** /api/schemas/types | Get value types
*SchemasApi* | [**ListEntities**](docs/SchemasApi.md#listentities) | **GET** /api/schemas/entities | List entities
*SearchApi* | [**PortfolioGroupsSearch**](docs/SearchApi.md#portfoliogroupssearch) | **POST** /api/search/portfoliogroups | Search portfolio groups
*SearchApi* | [**PortfoliosSearch**](docs/SearchApi.md#portfoliossearch) | **POST** /api/search/portfolios | Search portfolios
*SearchApi* | [**PropertiesSearch**](docs/SearchApi.md#propertiessearch) | **POST** /api/search/propertydefinitions | Search property definitions
*SystemConfigurationApi* | [**CreateConfigurationTransactionType**](docs/SystemConfigurationApi.md#createconfigurationtransactiontype) | **POST** /api/systemconfiguration/transactiontypes | Create transaction type
*SystemConfigurationApi* | [**ListConfigurationTransactionTypes**](docs/SystemConfigurationApi.md#listconfigurationtransactiontypes) | **GET** /api/systemconfiguration/transactiontypes | List transaction types
*SystemConfigurationApi* | [**SetConfigurationTransactionTypes**](docs/SystemConfigurationApi.md#setconfigurationtransactiontypes) | **PUT** /api/systemconfiguration/transactiontypes | Set transaction types
*TransactionPortfoliosApi* | [**AddTransactionProperty**](docs/TransactionPortfoliosApi.md#addtransactionproperty) | **POST** /api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/properties | Add transaction properties
*TransactionPortfoliosApi* | [**AdjustHoldings**](docs/TransactionPortfoliosApi.md#adjustholdings) | **POST** /api/transactionportfolios/{scope}/{code}/holdings/{effectiveAt} | Adjust holdings
*TransactionPortfoliosApi* | [**BuildTransactions**](docs/TransactionPortfoliosApi.md#buildtransactions) | **POST** /api/transactionportfolios/{scope}/{code}/transactions/$build | Build output transactions
*TransactionPortfoliosApi* | [**CancelAdjustHoldings**](docs/TransactionPortfoliosApi.md#canceladjustholdings) | **DELETE** /api/transactionportfolios/{scope}/{code}/holdings/{effectiveAt} | Cancel holdings adjustments
*TransactionPortfoliosApi* | [**CreatePortfolio**](docs/TransactionPortfoliosApi.md#createportfolio) | **POST** /api/transactionportfolios/{scope} | Create transaction portfolio
*TransactionPortfoliosApi* | [**DeletePropertyFromTransaction**](docs/TransactionPortfoliosApi.md#deletepropertyfromtransaction) | **DELETE** /api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/properties | Delete transaction property
*TransactionPortfoliosApi* | [**DeleteTransactions**](docs/TransactionPortfoliosApi.md#deletetransactions) | **DELETE** /api/transactionportfolios/{scope}/{code}/transactions | Delete transactions
*TransactionPortfoliosApi* | [**GetDetails**](docs/TransactionPortfoliosApi.md#getdetails) | **GET** /api/transactionportfolios/{scope}/{code}/details | Get portfolio details
*TransactionPortfoliosApi* | [**GetHoldings**](docs/TransactionPortfoliosApi.md#getholdings) | **GET** /api/transactionportfolios/{scope}/{code}/holdings | Get holdings
*TransactionPortfoliosApi* | [**GetHoldingsAdjustment**](docs/TransactionPortfoliosApi.md#getholdingsadjustment) | **GET** /api/transactionportfolios/{scope}/{code}/holdingsadjustments/{effectiveAt} | Get holding adjustment
*TransactionPortfoliosApi* | [**GetTransactions**](docs/TransactionPortfoliosApi.md#gettransactions) | **GET** /api/transactionportfolios/{scope}/{code}/transactions | Get transactions
*TransactionPortfoliosApi* | [**ListHoldingsAdjustments**](docs/TransactionPortfoliosApi.md#listholdingsadjustments) | **GET** /api/transactionportfolios/{scope}/{code}/holdingsadjustments | List holdings adjustments
*TransactionPortfoliosApi* | [**SetHoldings**](docs/TransactionPortfoliosApi.md#setholdings) | **PUT** /api/transactionportfolios/{scope}/{code}/holdings/{effectiveAt} | Set all holdings on a transaction portfolio
*TransactionPortfoliosApi* | [**UpsertPortfolioDetails**](docs/TransactionPortfoliosApi.md#upsertportfoliodetails) | **POST** /api/transactionportfolios/{scope}/{code}/details | Upsert details
*TransactionPortfoliosApi* | [**UpsertTransactions**](docs/TransactionPortfoliosApi.md#upserttransactions) | **POST** /api/transactionportfolios/{scope}/{code}/transactions | Upsert transactions into the specified transaction portfolio


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddTransactionPropertyResponse](docs/AddTransactionPropertyResponse.md)
 - [Model.AdjustHolding](docs/AdjustHolding.md)
 - [Model.AdjustHoldingRequest](docs/AdjustHoldingRequest.md)
 - [Model.AggregateSpec](docs/AggregateSpec.md)
 - [Model.AggregationRequest](docs/AggregationRequest.md)
 - [Model.AggregationResponseNode](docs/AggregationResponseNode.md)
 - [Model.AnalyticStore](docs/AnalyticStore.md)
 - [Model.AnalyticStoreKey](docs/AnalyticStoreKey.md)
 - [Model.CompletePortfolio](docs/CompletePortfolio.md)
 - [Model.CorporateAction](docs/CorporateAction.md)
 - [Model.CorporateActionTransition](docs/CorporateActionTransition.md)
 - [Model.CorporateActionTransitionComponent](docs/CorporateActionTransitionComponent.md)
 - [Model.CreateAnalyticStoreRequest](docs/CreateAnalyticStoreRequest.md)
 - [Model.CreateClientInstrumentRequest](docs/CreateClientInstrumentRequest.md)
 - [Model.CreateCorporateAction](docs/CreateCorporateAction.md)
 - [Model.CreateDataTypeRequest](docs/CreateDataTypeRequest.md)
 - [Model.CreateDerivedTransactionPortfolioRequest](docs/CreateDerivedTransactionPortfolioRequest.md)
 - [Model.CreateInstrumentPropertyRequest](docs/CreateInstrumentPropertyRequest.md)
 - [Model.CreatePortfolioDetails](docs/CreatePortfolioDetails.md)
 - [Model.CreatePortfolioGroupRequest](docs/CreatePortfolioGroupRequest.md)
 - [Model.CreatePropertyDefinitionRequest](docs/CreatePropertyDefinitionRequest.md)
 - [Model.CreateReferencePortfolioRequest](docs/CreateReferencePortfolioRequest.md)
 - [Model.CreateResults](docs/CreateResults.md)
 - [Model.CreateTransactionPortfolioRequest](docs/CreateTransactionPortfolioRequest.md)
 - [Model.CreateUnitDefinition](docs/CreateUnitDefinition.md)
 - [Model.CurrencyAndAmount](docs/CurrencyAndAmount.md)
 - [Model.DataType](docs/DataType.md)
 - [Model.DeleteClientInstrumentsResponse](docs/DeleteClientInstrumentsResponse.md)
 - [Model.DeletedEntityResponse](docs/DeletedEntityResponse.md)
 - [Model.ErrorDetail](docs/ErrorDetail.md)
 - [Model.ErrorDetailBase](docs/ErrorDetailBase.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.ExpandedGroup](docs/ExpandedGroup.md)
 - [Model.FieldSchema](docs/FieldSchema.md)
 - [Model.HoldingAdjustment](docs/HoldingAdjustment.md)
 - [Model.HoldingsAdjustment](docs/HoldingsAdjustment.md)
 - [Model.HoldingsAdjustmentHeader](docs/HoldingsAdjustmentHeader.md)
 - [Model.IUnitDefinition](docs/IUnitDefinition.md)
 - [Model.Instrument](docs/Instrument.md)
 - [Model.InstrumentAnalytic](docs/InstrumentAnalytic.md)
 - [Model.InstrumentDefinition](docs/InstrumentDefinition.md)
 - [Model.InstrumentProperty](docs/InstrumentProperty.md)
 - [Model.KeyValuePairOfPropertyKeyToFieldSchema](docs/KeyValuePairOfPropertyKeyToFieldSchema.md)
 - [Model.KeyValuePairOfStringToFieldSchema](docs/KeyValuePairOfStringToFieldSchema.md)
 - [Model.Link](docs/Link.md)
 - [Model.ListAggregationResponse](docs/ListAggregationResponse.md)
 - [Model.LookupInstrumentsFromCodesResponse](docs/LookupInstrumentsFromCodesResponse.md)
 - [Model.MetricValue](docs/MetricValue.md)
 - [Model.NestedAggregationResponse](docs/NestedAggregationResponse.md)
 - [Model.OutputTransaction](docs/OutputTransaction.md)
 - [Model.PerpetualProperty](docs/PerpetualProperty.md)
 - [Model.PerpetualPropertyValue](docs/PerpetualPropertyValue.md)
 - [Model.Personalisation](docs/Personalisation.md)
 - [Model.Portfolio](docs/Portfolio.md)
 - [Model.PortfolioDetails](docs/PortfolioDetails.md)
 - [Model.PortfolioGroup](docs/PortfolioGroup.md)
 - [Model.PortfolioHolding](docs/PortfolioHolding.md)
 - [Model.PortfolioProperties](docs/PortfolioProperties.md)
 - [Model.PortfolioReconciliationRequest](docs/PortfolioReconciliationRequest.md)
 - [Model.PortfolioSearchResult](docs/PortfolioSearchResult.md)
 - [Model.PortfoliosReconciliationRequest](docs/PortfoliosReconciliationRequest.md)
 - [Model.ProcessedCommand](docs/ProcessedCommand.md)
 - [Model.Property](docs/Property.md)
 - [Model.PropertyDefinition](docs/PropertyDefinition.md)
 - [Model.PropertyFilter](docs/PropertyFilter.md)
 - [Model.PropertySchema](docs/PropertySchema.md)
 - [Model.PropertyValue](docs/PropertyValue.md)
 - [Model.RealisedGainLoss](docs/RealisedGainLoss.md)
 - [Model.ReconciliationBreak](docs/ReconciliationBreak.md)
 - [Model.ReferencePortfolioConstituent](docs/ReferencePortfolioConstituent.md)
 - [Model.ReferencePortfolioConstituentRequest](docs/ReferencePortfolioConstituentRequest.md)
 - [Model.ResourceId](docs/ResourceId.md)
 - [Model.ResourceListOfAnalyticStoreKey](docs/ResourceListOfAnalyticStoreKey.md)
 - [Model.ResourceListOfCorporateActionEvent](docs/ResourceListOfCorporateActionEvent.md)
 - [Model.ResourceListOfDataType](docs/ResourceListOfDataType.md)
 - [Model.ResourceListOfHoldingsAdjustmentHeader](docs/ResourceListOfHoldingsAdjustmentHeader.md)
 - [Model.ResourceListOfPersonalisation](docs/ResourceListOfPersonalisation.md)
 - [Model.ResourceListOfPortfolio](docs/ResourceListOfPortfolio.md)
 - [Model.ResourceListOfPortfolioGroup](docs/ResourceListOfPortfolioGroup.md)
 - [Model.ResourceListOfPortfolioSearchResult](docs/ResourceListOfPortfolioSearchResult.md)
 - [Model.ResourceListOfProcessedCommand](docs/ResourceListOfProcessedCommand.md)
 - [Model.ResourceListOfPropertyDefinition](docs/ResourceListOfPropertyDefinition.md)
 - [Model.ResourceListOfReconciliationBreak](docs/ResourceListOfReconciliationBreak.md)
 - [Model.ResourceListOfReferencePortfolioConstituent](docs/ResourceListOfReferencePortfolioConstituent.md)
 - [Model.ResourceListOfScope](docs/ResourceListOfScope.md)
 - [Model.ResourceListOfString](docs/ResourceListOfString.md)
 - [Model.ResourceListOfTransactionMetaData](docs/ResourceListOfTransactionMetaData.md)
 - [Model.ResourceListOfValueType](docs/ResourceListOfValueType.md)
 - [Model.ResultDataSchema](docs/ResultDataSchema.md)
 - [Model.Results](docs/Results.md)
 - [Model.Schema](docs/Schema.md)
 - [Model.TargetTaxLot](docs/TargetTaxLot.md)
 - [Model.TargetTaxLotRequest](docs/TargetTaxLotRequest.md)
 - [Model.Transaction](docs/Transaction.md)
 - [Model.TransactionConfigurationData](docs/TransactionConfigurationData.md)
 - [Model.TransactionConfigurationDataRequest](docs/TransactionConfigurationDataRequest.md)
 - [Model.TransactionConfigurationMovementData](docs/TransactionConfigurationMovementData.md)
 - [Model.TransactionConfigurationMovementDataRequest](docs/TransactionConfigurationMovementDataRequest.md)
 - [Model.TransactionConfigurationTypeAlias](docs/TransactionConfigurationTypeAlias.md)
 - [Model.TransactionPrice](docs/TransactionPrice.md)
 - [Model.TransactionPropertyMapping](docs/TransactionPropertyMapping.md)
 - [Model.TransactionPropertyMappingRequest](docs/TransactionPropertyMappingRequest.md)
 - [Model.TransactionQueryParameters](docs/TransactionQueryParameters.md)
 - [Model.TransactionRequest](docs/TransactionRequest.md)
 - [Model.TryAddClientInstruments](docs/TryAddClientInstruments.md)
 - [Model.UpdateDataTypeRequest](docs/UpdateDataTypeRequest.md)
 - [Model.UpdatePortfolioGroupRequest](docs/UpdatePortfolioGroupRequest.md)
 - [Model.UpdatePortfolioRequest](docs/UpdatePortfolioRequest.md)
 - [Model.UpdatePropertyDefinitionRequest](docs/UpdatePropertyDefinitionRequest.md)
 - [Model.UpsertCorporateActionsResponse](docs/UpsertCorporateActionsResponse.md)
 - [Model.UpsertInstrumentPropertiesResponse](docs/UpsertInstrumentPropertiesResponse.md)
 - [Model.UpsertPersonalisationResponse](docs/UpsertPersonalisationResponse.md)
 - [Model.UpsertPortfolioTransactionsResponse](docs/UpsertPortfolioTransactionsResponse.md)
 - [Model.UpsertReferencePortfolioConstituentsResponse](docs/UpsertReferencePortfolioConstituentsResponse.md)
 - [Model.User](docs/User.md)
 - [Model.Version](docs/Version.md)
 - [Model.VersionSummary](docs/VersionSummary.md)
 - [Model.VersionedResourceListOfHolding](docs/VersionedResourceListOfHolding.md)
 - [Model.VersionedResourceListOfOutputTransaction](docs/VersionedResourceListOfOutputTransaction.md)
 - [Model.VersionedResourceListOfTransaction](docs/VersionedResourceListOfTransaction.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="oauth2"></a>
### oauth2

- **Type**: OAuth
- **Flow**: implicit
- **Authorization URL**: https://lusid.okta.com/oauth2/aus5a776yendDqtEq2p6/v1/authorize
- **Scopes**: N/A

