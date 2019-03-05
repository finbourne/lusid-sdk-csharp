/* 
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://api.lusid.com/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages :  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python)  # Data Model  The LUSID API has a relatively lightweight but extremely powerful data model.   One of the goals of LUSID was not to enforce on clients a single rigid data model but rather to provide a flexible foundation onto which clients can streamline their data.   One of the primary tools to extend the data model is through using properties.  Properties can be associated with amongst others: - * Transactions * Instruments * Portfolios   The LUSID data model is exposed through the LUSID APIs.  The APIs provide access to both business objects and the meta data used to configure the systems behaviours.   The key business entities are: - * **Portfolios** A portfolio is the primary container for transactions and holdings.  * **Derived Portfolios** Derived portfolios allow portfolios to be created based on other portfolios, by overriding or overlaying specific items * **Holdings** A holding is a position account for a instrument within a portfolio.  Holdings can only be adjusted via transactions. * **Transactions** A Transaction is a source of transactions used to manipulate holdings.  * **Corporate Actions** A corporate action is a market event which occurs to a instrument, for example a stock split * **Instruments**  A instrument represents a currency, tradable instrument or OTC contract that is attached to a transaction and a holding. * **Properties** Several entities allow additional user defined properties to be associated with them.   For example, a Portfolio manager may be associated with a portfolio  Meta data includes: - * **Transaction Types** Transactions are booked with a specific transaction type.  The types are client defined and are used to map the Transaction to a series of movements which update the portfolio holdings.  * **Properties Types** Types of user defined properties used within the system.  This section describes the data model that LUSID exposes via the APIs.  ## Scope  All data in LUSID is segregated at the client level.  Entities in LUSID are identifiable by a unique code.  Every entity lives within a logical data partition known as a Scope.  Scope is an identity namespace allowing two entities with the same unique code to co-exist within individual address spaces.  For example, prices for equities from different vendors may be uploaded into different scopes such as `client/vendor1` and `client/vendor2`.  A portfolio may then be valued using either of the price sources by referencing the appropriate scope.  LUSID Clients cannot access scopes of other clients.  ## Schema  A detailed description of the entities used by the API and parameters for endpoints which take a JSON document can be retrieved via the `schema` endpoint.  ## Instruments  LUSID has its own built-in instrument master which you can use to master your own instrument universe.  Every instrument must be created with one or more unique market identifiers, such as [FIGI](https://openfigi.com/) or RIC code. For any non-listed instruments (eg OTCs), you can upload an instrument against a custom ID of your choosing.  In addition, LUSID will allocate each instrument a unique 'LUSID instrument identifier'. The LUSID instrument identifier is what is used when uploading transactions, holdings, prices, etc. The API exposes an `instrument/lookup` endpoint which can be used to lookup these LUSID identifiers using their market identifiers.  Cash can be referenced using the ISO currency code prefixed with \"`CCY_`\" e.g. `CCY_GBP`  ## Instrument Prices (Analytics)  Instrument prices are stored in LUSID's Analytics Store  | Field|Type|Description | | - --|- --|- -- | | InstrumentUid|string|Unique instrument identifier | | Value|decimal|Value of the analytic, eg price | | Denomination|string|Underlying unit of the analytic, eg currency, EPS etc. |   ## Instrument Data  Instrument data can be uploaded to the system using the [Instrument Properties](#tag/InstrumentProperties) endpoint.  | Field|Type|Description | | - --|- --|- -- |   ## Portfolios  Portfolios are the top-level entity containers within LUSID, containing transactions, corporate actions and holdings.    The transactions build up the portfolio holdings on which valuations, analytics profit & loss and risk can be calculated.     Properties can be associated with Portfolios to add in additional model data.  Portfolio properties can be changed over time as well.  For example, to allow a Portfolio Manager to be linked with a Portfolio.  Additionally, portfolios can be securitised and held by other portfolios, allowing LUSID to perform \"drill-through\" into underlying fund holdings  ### Reference Portfolios Reference portfolios are portfolios that contain only weights, as opposed to transactions, and are designed to represent entities such as indices.  ### Derived Portfolios  LUSID also allows for a portfolio to be composed of another portfolio via derived portfolios.  A derived portfolio can contain its own transactions and also inherits any transactions from its parent portfolio.  Any changes made to the parent portfolio are automatically reflected in derived portfolio.  Derived portfolios in conjunction with scopes are a powerful construct.  For example, to do pre-trade what-if analysis, a derived portfolio could be created a new namespace linked to the underlying live (parent) portfolio.  Analysis can then be undertaken on the derived portfolio without affecting the live portfolio.  ### Portfolio Groups Portfolio groups allow the construction of a hierarchy from portfolios and groups.  Portfolio operations on the group are executed on an aggregated set of portfolios in the hierarchy.   For example:   * Global Portfolios _(group)_   * APAC _(group)_     * Hong Kong _(portfolio)_     * Japan _(portfolio)_   * Europe _(group)_     * France _(portfolio)_     * Germany _(portfolio)_   * UK _(portfolio)_   In this example **Global Portfolios** is a group that consists of an aggregate of **Hong Kong**, **Japan**, **France**, **Germany** and **UK** portfolios.  ### Movements Engine The Movements engine sits on top of the immutable event store and is used to manage the relationship between input trading actions and their associated portfolio holdings.     The movements engine reads in the following entity types:- * Posting Transactions * Applying Corporate Actions  * Holding Adjustments  These are converted to one or more movements and used by the movements engine to calculate holdings.  At the same time it also calculates running balances, and realised P&L.  The outputs from the movements engine are holdings and transactions.  ## Transactions  A transaction represents an economic activity against a Portfolio.  Transactions are processed according to a configuration. This will tell the LUSID engine how to interpret the transaction and correctly update the holdings. LUSID comes with a set of transaction types you can use out of the box, or you can configure your own set(s) of transactions.  For more details see the [LUSID Getting Started Guide for transaction configuration.](https://support.finbourne.com/hc/en-us/articles/360016737511-Configuring-Transaction-Types)  | Field|Type|Description | | - --|- --|- -- | | TransactionId|string|Unique transaction identifier | | Type|string|LUSID transaction type code - Buy, Sell, StockIn, StockOut, etc | | InstrumentIdentifiers|IReadOnlyDictionary`2|Unique instrument identifiers. | | InstrumentUid|string|Unique instrument identifier | | TransactionDate|datetime|Transaction date | | SettlementDate|datetime|Settlement date | | Units|decimal|Quantity of transaction in units of the instrument | | TransactionPrice|tradeprice|Execution price for the transaction | | TotalConsideration|currencyandamount|Total value of the transaction in settlement currency | | ExchangeRate|decimal|Rate between transaction and settle currency | | TransactionCurrency|currency|Transaction currency | | CounterpartyId|string|Counterparty identifier | | Source|string|Where this transaction came from | | NettingSet|string|  |   From these fields, the following values can be calculated  * **Transaction value in Transaction currency**: TotalConsideration / ExchangeRate  * **Transaction value in Portfolio currency**: Transaction value in Transaction currency * TradeToPortfolioRate  ### Example Transactions  #### A Common Purchase Example Three example transactions are shown in the table below.   They represent a purchase of USD denominated IBM shares within a Sterling denominated portfolio.   * The first two transactions are for separate buy and fx trades    * Buying 500 IBM shares for $71,480.00    * A foreign exchange conversion to fund the IBM purchase. (Buy $71,480.00 for &#163;54,846.60)  * The third transaction is an alternate version of the above trades. Buying 500 IBM shares and settling directly in Sterling.  | Column |  Buy Trade | Fx Trade | Buy Trade with foreign Settlement | | - -- -- | - -- -- | - -- -- | - -- -- | | TransactionId | FBN00001 | FBN00002 | FBN00003 | | Type | Buy | FxBuy | Buy | | InstrumentUid | FIGI_BBG000BLNNH6 | CCY_USD | FIGI_BBG000BLNNH6 | | TransactionDate | 2018-08-02 | 2018-08-02 | 2018-08-02 | | SettlementDate | 2018-08-06 | 2018-08-06 | 2018-08-06 | | Units | 500 | 71480 | 500 | | TransactionPrice | 142.96 | 1 | 142.96 | | TradeCurrency | USD | USD | USD | | ExchangeRate | 1 | 0.7673 | 0.7673 | | TotalConsideration.Amount | 71480.00 | 54846.60 | 54846.60 | | TotalConsideration.Currency | USD | GBP | GBP | | Trade/default/TradeToPortfolioRate&ast; | 0.7673 | 0.7673 | 0.7673 |  [&ast; This is a property field]  #### A Forward FX Example  LUSID has a flexible transaction modelling system, and there are a number of different ways of modelling forward fx trades.  The default LUSID transaction types are FwdFxBuy and FwdFxSell. Other types and behaviours can be configured as required.  Using these transaction types, the holdings query will report two forward positions. One in each currency.   Since an FX trade is an exchange of one currency for another, the following two 6 month forward transactions are equivalent:  | Column |  Forward 'Sell' Trade | Forward 'Buy' Trade | | - -- -- | - -- -- | - -- -- | | TransactionId | FBN00004 | FBN00005 | | Type | FwdFxSell | FwdFxBuy | | InstrumentUid | CCY_GBP | CCY_USD | | TransactionDate | 2018-08-02 | 2018-08-02 | | SettlementDate | 2019-02-06 | 2019-02-06 | | Units | 10000.00 | 13142.00 | | TransactionPrice |1 | 1 | | TradeCurrency | GBP | USD | | ExchangeRate | 1.3142 | 0.760919 | | TotalConsideration.Amount | 13142.00 | 10000.00 | | TotalConsideration.Currency | USD | GBP | | Trade/default/TradeToPortfolioRate | 1.0 | 0.760919 |  ## Holdings  A holding represents a position in a instrument or cash on a given date.  | Field|Type|Description | | - --|- --|- -- | | InstrumentUid|string|Unique instrument identifier | | HoldingType|string|Type of holding, eg Position, Balance, CashCommitment, Receivable, ForwardFX | | Units|decimal|Quantity of holding | | SettledUnits|decimal|Settled quantity of holding | | Cost|currencyandamount|Book cost of holding in transaction currency | | CostPortfolioCcy|currencyandamount|Book cost of holding in portfolio currency | | Transaction|Transaction|If this is commitment-type holding, the transaction behind it |   ## Corporate Actions  Corporate actions are represented within LUSID in terms of a set of instrument-specific 'transitions'.  These transitions are used to specify the participants of the corporate action, and the effect that the corporate action will have on holdings in those participants.  *Corporate action*  | Field|Type|Description | | - --|- --|- -- | | SourceId|id|  | | CorporateActionCode|code|  | | AnnouncementDate|datetime|  | | ExDate|datetime|  | | RecordDate|datetime|  | | PaymentDate|datetime|  |    *Transition*  | Field|Type|Description | | - --|- --|- -- |   ## Property  Properties are key-value pairs that can be applied to any entity within a domain (where a domain is `trade`, `portfolio`, `security` etc).  Properties must be defined before use with a `PropertyDefinition` and can then subsequently be added to entities.  # Schemas  The following headers are returned on all responses from LUSID  | Name | Purpose | | - -- | - -- | | lusid-meta-duration | Duration of the request | | lusid-meta-success | Whether or not LUSID considered the request to be successful | | lusid-meta-requestId | The unique identifier for the request | | lusid-schema-url | Url of the schema for the data being returned | | lusid-property-schema-url | Url of the schema for any properties |   # Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"102\">102</a>|VersionNotFound|  | | <a name=\"104\">104</a>|InstrumentNotFound|  | | <a name=\"105\">105</a>|PropertyNotFound|  | | <a name=\"106\">106</a>|PortfolioRecursionDepth|  | | <a name=\"108\">108</a>|GroupNotFound|  | | <a name=\"109\">109</a>|PortfolioNotFound|  | | <a name=\"110\">110</a>|PropertySchemaNotFound|  | | <a name=\"111\">111</a>|PortfolioAncestryNotFound|  | | <a name=\"112\">112</a>|PortfolioWithIdAlreadyExists|  | | <a name=\"113\">113</a>|OrphanedPortfolio|  | | <a name=\"119\">119</a>|MissingBaseClaims|  | | <a name=\"121\">121</a>|PropertyNotDefined|  | | <a name=\"122\">122</a>|CannotDeleteSystemProperty|  | | <a name=\"123\">123</a>|CannotModifyImmutablePropertyField|  | | <a name=\"124\">124</a>|PropertyAlreadyExists|  | | <a name=\"125\">125</a>|InvalidPropertyLifeTime|  | | <a name=\"127\">127</a>|CannotModifyDefaultDataType|  | | <a name=\"128\">128</a>|GroupAlreadyExists|  | | <a name=\"129\">129</a>|NoSuchDataType|  | | <a name=\"132\">132</a>|ValidationError|  | | <a name=\"133\">133</a>|LoopDetectedInGroupHierarchy|  | | <a name=\"135\">135</a>|SubGroupAlreadyExists|  | | <a name=\"138\">138</a>|PriceSourceNotFound|  | | <a name=\"139\">139</a>|AnalyticStoreNotFound|  | | <a name=\"141\">141</a>|AnalyticStoreAlreadyExists|  | | <a name=\"143\">143</a>|ClientInstrumentAlreadyExists|  | | <a name=\"144\">144</a>|DuplicateInParameterSet|  | | <a name=\"147\">147</a>|ResultsNotFound|  | | <a name=\"148\">148</a>|OrderFieldNotInResultSet|  | | <a name=\"149\">149</a>|OperationFailed|  | | <a name=\"150\">150</a>|ElasticSearchError|  | | <a name=\"151\">151</a>|InvalidParameterValue|  | | <a name=\"153\">153</a>|CommandProcessingFailure|  | | <a name=\"154\">154</a>|EntityStateConstructionFailure|  | | <a name=\"155\">155</a>|EntityTimelineDoesNotExist|  | | <a name=\"156\">156</a>|EventPublishFailure|  | | <a name=\"157\">157</a>|InvalidRequestFailure|  | | <a name=\"158\">158</a>|EventPublishUnknown|  | | <a name=\"159\">159</a>|EventQueryFailure|  | | <a name=\"160\">160</a>|BlobDidNotExistFailure|  | | <a name=\"162\">162</a>|SubSystemRequestFailure|  | | <a name=\"163\">163</a>|SubSystemConfigurationFailure|  | | <a name=\"165\">165</a>|FailedToDelete|  | | <a name=\"166\">166</a>|UpsertClientInstrumentFailure|  | | <a name=\"167\">167</a>|IllegalAsAtInterval|  | | <a name=\"168\">168</a>|IllegalBitemporalQuery|  | | <a name=\"169\">169</a>|InvalidAlternateId|  | | <a name=\"170\">170</a>|CannotAddSourcePortfolioPropertyExplicitly|  | | <a name=\"171\">171</a>|EntityAlreadyExistsInGroup|  | | <a name=\"173\">173</a>|EntityWithIdAlreadyExists|  | | <a name=\"174\">174</a>|PortfolioDetailsDoNotExist|  | | <a name=\"176\">176</a>|PortfolioWithNameAlreadyExists|  | | <a name=\"177\">177</a>|InvalidTransactions|  | | <a name=\"178\">178</a>|ReferencePortfolioNotFound|  | | <a name=\"179\">179</a>|DuplicateIdFailure|  | | <a name=\"180\">180</a>|CommandRetrievalFailure|  | | <a name=\"181\">181</a>|DataFilterApplicationFailure|  | | <a name=\"182\">182</a>|SearchFailed|  | | <a name=\"183\">183</a>|MovementsEngineConfigurationKeyFailure|  | | <a name=\"184\">184</a>|FxRateSourceNotFound|  | | <a name=\"185\">185</a>|AccrualSourceNotFound|  | | <a name=\"186\">186</a>|EntitlementsFailure|  | | <a name=\"187\">187</a>|InvalidIdentityToken|  | | <a name=\"188\">188</a>|InvalidRequestHeaders|  | | <a name=\"189\">189</a>|PriceNotFound|  | | <a name=\"190\">190</a>|InvalidSubHoldingKeysProvided|  | | <a name=\"191\">191</a>|DuplicateSubHoldingKeysProvided|  | | <a name=\"192\">192</a>|CutDefinitionNotFound|  | | <a name=\"193\">193</a>|CutDefinitionInvalid|  | | <a name=\"200\">200</a>|InvalidUnitForDataType|  | | <a name=\"201\">201</a>|InvalidTypeForDataType|  | | <a name=\"202\">202</a>|InvalidValueForDataType|  | | <a name=\"203\">203</a>|UnitNotDefinedForDataType|  | | <a name=\"204\">204</a>|UnitsNotSupportedOnDataType|  | | <a name=\"205\">205</a>|CannotSpecifyUnitsOnDataType|  | | <a name=\"206\">206</a>|UnitSchemaInconsistentWithDataType|  | | <a name=\"207\">207</a>|UnitDefinitionNotSpecified|  | | <a name=\"208\">208</a>|DuplicateUnitDefinitionsSpecified|  | | <a name=\"209\">209</a>|InvalidUnitsDefinition|  | | <a name=\"210\">210</a>|InvalidInstrumentIdentifierUnit|  | | <a name=\"211\">211</a>|HoldingsAdjustmentDoesNotExist|  | | <a name=\"212\">212</a>|CouldNotBuildExcelUrl|  | | <a name=\"213\">213</a>|CouldNotGetExcelVersion|  | | <a name=\"214\">214</a>|InstrumentByCodeNotFound|  | | <a name=\"215\">215</a>|EntitySchemaDoesNotExist|  | | <a name=\"216\">216</a>|FeatureNotSupportedOnPortfolioType|  | | <a name=\"217\">217</a>|QuoteNotFoundFailure|  | | <a name=\"219\">219</a>|InvalidInstrumentDefinition|  | | <a name=\"221\">221</a>|InstrumentUpsertFailure|  | | <a name=\"222\">222</a>|ReferencePortfolioRequestNotSupported|  | | <a name=\"223\">223</a>|TransactionPortfolioRequestNotSupported|  | | <a name=\"224\">224</a>|InvalidPropertyValueAssignment|  | | <a name=\"230\">230</a>|TransactionTypeNotFound|  | | <a name=\"231\">231</a>|TransactionTypeDuplication|  | | <a name=\"232\">232</a>|PortfolioDoesNotExistAtGivenDate|  | | <a name=\"233\">233</a>|QueryParserFailure|  | | <a name=\"234\">234</a>|DuplicateConstituentFailure|  | | <a name=\"235\">235</a>|UnresolvedConstituentFailure|  | | <a name=\"301\">301</a>|DependenciesFailure|  | | <a name=\"304\">304</a>|PortfolioPreprocessFailure|  | | <a name=\"310\">310</a>|ValuationEngineFailure|  | | <a name=\"311\">311</a>|TaskFactoryFailure|  | | <a name=\"312\">312</a>|TaskEvaluationFailure|  | | <a name=\"350\">350</a>|InstrumentFailure|  | | <a name=\"351\">351</a>|CashFlowsFailure|  | | <a name=\"370\">370</a>|ResultRetrievalFailure|  | | <a name=\"371\">371</a>|ResultProcessingFailure|  | | <a name=\"372\">372</a>|VendorResultProcessingFailure|  | | <a name=\"373\">373</a>|CannotSupplyTimesWithPortfoliosQuery|  | | <a name=\"374\">374</a>|AttemptToUpsertDuplicateQuotes|  | | <a name=\"-10\">-10</a>|ServerConfigurationError|  | | <a name=\"-1\">-1</a>|Unknown error|  | 
 *
 * OpenAPI spec version: 0.9.161
 * Contact: info@finbourne.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Lusid.Sdk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITransactionPortfoliosApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add transaction properties
        /// </summary>
        /// <remarks>
        /// Upsert one or more transaction properties to a single transaction in a portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="transactionId">Id of transaction</param>
        /// <param name="transactionProperties">Transaction properties values (optional)</param>
        /// <returns>AddTransactionPropertyResponse</returns>
        AddTransactionPropertyResponse AddTransactionProperty (string scope, string code, string transactionId, Object transactionProperties = null);

        /// <summary>
        /// Add transaction properties
        /// </summary>
        /// <remarks>
        /// Upsert one or more transaction properties to a single transaction in a portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="transactionId">Id of transaction</param>
        /// <param name="transactionProperties">Transaction properties values (optional)</param>
        /// <returns>ApiResponse of AddTransactionPropertyResponse</returns>
        ApiResponse<AddTransactionPropertyResponse> AddTransactionPropertyWithHttpInfo (string scope, string code, string transactionId, Object transactionProperties = null);
        /// <summary>
        /// Adjust holdings
        /// </summary>
        /// <remarks>
        /// Adjust one or more holdings in a transaction portfolio    Prompt the creation of transactions in a specific transaction portfolio to bring selected holdings to the specified targets
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <param name="holdingAdjustments">The selected set of holdings adjustments (optional)</param>
        /// <returns>AdjustHolding</returns>
        AdjustHolding AdjustHoldings (string scope, string code, DateTimeOffset? effectiveAt, List<AdjustHoldingRequest> holdingAdjustments = null);

        /// <summary>
        /// Adjust holdings
        /// </summary>
        /// <remarks>
        /// Adjust one or more holdings in a transaction portfolio    Prompt the creation of transactions in a specific transaction portfolio to bring selected holdings to the specified targets
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <param name="holdingAdjustments">The selected set of holdings adjustments (optional)</param>
        /// <returns>ApiResponse of AdjustHolding</returns>
        ApiResponse<AdjustHolding> AdjustHoldingsWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt, List<AdjustHoldingRequest> holdingAdjustments = null);
        /// <summary>
        /// Build output transactions
        /// </summary>
        /// <remarks>
        /// Builds and returns the collection of all types of transactions that affect the holdings of a portfolio in to a set of output transactions
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values to be decorated onto the transactions (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="parameters">Optional. Transaction query parameters (optional)</param>
        /// <returns>VersionedResourceListOfOutputTransaction</returns>
        VersionedResourceListOfOutputTransaction BuildTransactions (string scope, string code, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, List<string> instrumentPropertyKeys = null, string filter = null, TransactionQueryParameters parameters = null);

        /// <summary>
        /// Build output transactions
        /// </summary>
        /// <remarks>
        /// Builds and returns the collection of all types of transactions that affect the holdings of a portfolio in to a set of output transactions
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values to be decorated onto the transactions (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="parameters">Optional. Transaction query parameters (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfOutputTransaction</returns>
        ApiResponse<VersionedResourceListOfOutputTransaction> BuildTransactionsWithHttpInfo (string scope, string code, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, List<string> instrumentPropertyKeys = null, string filter = null, TransactionQueryParameters parameters = null);
        /// <summary>
        /// Cancel holdings adjustments
        /// </summary>
        /// <remarks>
        /// Cancel previous adjust-holdings for the portfolio for a specific date
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse CancelAdjustHoldings (string scope, string code, DateTimeOffset? effectiveAt);

        /// <summary>
        /// Cancel holdings adjustments
        /// </summary>
        /// <remarks>
        /// Cancel previous adjust-holdings for the portfolio for a specific date
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> CancelAdjustHoldingsWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt);
        /// <summary>
        /// Create transaction portfolio
        /// </summary>
        /// <remarks>
        /// Create a transaction portfolio in a specific scope
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope into which the transaction portfolio will be created</param>
        /// <param name="createRequest">The transaction portfolio definition (optional)</param>
        /// <returns>Portfolio</returns>
        Portfolio CreatePortfolio (string scope, CreateTransactionPortfolioRequest createRequest = null);

        /// <summary>
        /// Create transaction portfolio
        /// </summary>
        /// <remarks>
        /// Create a transaction portfolio in a specific scope
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope into which the transaction portfolio will be created</param>
        /// <param name="createRequest">The transaction portfolio definition (optional)</param>
        /// <returns>ApiResponse of Portfolio</returns>
        ApiResponse<Portfolio> CreatePortfolioWithHttpInfo (string scope, CreateTransactionPortfolioRequest createRequest = null);
        /// <summary>
        /// Delete executions
        /// </summary>
        /// <remarks>
        /// Delete one or more executions from a transaction portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="executionIds">Ids of executions to delete (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeleteExecutions (string scope, string code, List<string> executionIds = null);

        /// <summary>
        /// Delete executions
        /// </summary>
        /// <remarks>
        /// Delete one or more executions from a transaction portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="executionIds">Ids of executions to delete (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeleteExecutionsWithHttpInfo (string scope, string code, List<string> executionIds = null);
        /// <summary>
        /// Delete transaction property
        /// </summary>
        /// <remarks>
        /// Delete a property value from a single transaction in a portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="transactionId">Id of the transaction to delete the property from</param>
        /// <param name="transactionPropertyKey">The key of the property to be deleted (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeletePropertyFromTransaction (string scope, string code, string transactionId, string transactionPropertyKey = null);

        /// <summary>
        /// Delete transaction property
        /// </summary>
        /// <remarks>
        /// Delete a property value from a single transaction in a portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="transactionId">Id of the transaction to delete the property from</param>
        /// <param name="transactionPropertyKey">The key of the property to be deleted (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeletePropertyFromTransactionWithHttpInfo (string scope, string code, string transactionId, string transactionPropertyKey = null);
        /// <summary>
        /// Delete transactions
        /// </summary>
        /// <remarks>
        /// Delete one or more transactions from a transaction portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="transactionIds">Ids of transactions to delete (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeleteTransactions (string scope, string code, List<string> transactionIds = null);

        /// <summary>
        /// Delete transactions
        /// </summary>
        /// <remarks>
        /// Delete one or more transactions from a transaction portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="transactionIds">Ids of transactions to delete (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeleteTransactionsWithHttpInfo (string scope, string code, List<string> transactionIds = null);
        /// <summary>
        /// Get portfolio details
        /// </summary>
        /// <remarks>
        /// Get the details document associated with a transaction portfolio                When requesting details from a derived transaction portfolio, the returned set of details could come from a different transaction portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>PortfolioDetails</returns>
        PortfolioDetails GetDetails (string scope, string code, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null);

        /// <summary>
        /// Get portfolio details
        /// </summary>
        /// <remarks>
        /// Get the details document associated with a transaction portfolio                When requesting details from a derived transaction portfolio, the returned set of details could come from a different transaction portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>ApiResponse of PortfolioDetails</returns>
        ApiResponse<PortfolioDetails> GetDetailsWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null);
        /// <summary>
        /// Get holdings
        /// </summary>
        /// <remarks>
        /// Get the aggregate holdings of a transaction portfolio.  If no effectiveAt or asAt  are supplied then values will be defaulted to the latest system time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="byTaxlots">Option to expand holdings to return the underlying tax-lots (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the portfolio (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values to be decorated onto the holdings (optional)</param>
        /// <returns>VersionedResourceListOfPortfolioHolding</returns>
        VersionedResourceListOfPortfolioHolding GetHoldings (string scope, string code, bool? byTaxlots = null, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null);

        /// <summary>
        /// Get holdings
        /// </summary>
        /// <remarks>
        /// Get the aggregate holdings of a transaction portfolio.  If no effectiveAt or asAt  are supplied then values will be defaulted to the latest system time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="byTaxlots">Option to expand holdings to return the underlying tax-lots (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the portfolio (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values to be decorated onto the holdings (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfPortfolioHolding</returns>
        ApiResponse<VersionedResourceListOfPortfolioHolding> GetHoldingsWithHttpInfo (string scope, string code, bool? byTaxlots = null, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null);
        /// <summary>
        /// Get holding adjustment
        /// </summary>
        /// <remarks>
        /// Get a holdings adjustment for a transaction portfolio at a specific effective time.    A holdings adjustment definition will only be returned if one exists for the specified effective time
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective time of the holdings adjustment</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>HoldingsAdjustment</returns>
        HoldingsAdjustment GetHoldingsAdjustment (string scope, string code, DateTimeOffset? effectiveAt, DateTimeOffset? asAt = null);

        /// <summary>
        /// Get holding adjustment
        /// </summary>
        /// <remarks>
        /// Get a holdings adjustment for a transaction portfolio at a specific effective time.    A holdings adjustment definition will only be returned if one exists for the specified effective time
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective time of the holdings adjustment</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>ApiResponse of HoldingsAdjustment</returns>
        ApiResponse<HoldingsAdjustment> GetHoldingsAdjustmentWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt, DateTimeOffset? asAt = null);
        /// <summary>
        /// Get transactions
        /// </summary>
        /// <remarks>
        /// Get the transactions from a transaction portfolio    When the requested portfolio is a derived transaction portfolio, the returned set of transactions is the union set of all transactions of the parent (and ancestors) and the specified portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="fromTransactionDate">Optional. Limit the returned transactions to those with a transaction date equal or later than this date (optional)</param>
        /// <param name="toTransactionDate">Optional. Limit the returned transactions to those with a transaction date equal or before this date (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values that will be decorated onto the transactions (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>VersionedResourceListOfTransaction</returns>
        VersionedResourceListOfTransaction GetTransactions (string scope, string code, DateTimeOffset? fromTransactionDate = null, DateTimeOffset? toTransactionDate = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, List<string> instrumentPropertyKeys = null, string filter = null);

        /// <summary>
        /// Get transactions
        /// </summary>
        /// <remarks>
        /// Get the transactions from a transaction portfolio    When the requested portfolio is a derived transaction portfolio, the returned set of transactions is the union set of all transactions of the parent (and ancestors) and the specified portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="fromTransactionDate">Optional. Limit the returned transactions to those with a transaction date equal or later than this date (optional)</param>
        /// <param name="toTransactionDate">Optional. Limit the returned transactions to those with a transaction date equal or before this date (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values that will be decorated onto the transactions (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfTransaction</returns>
        ApiResponse<VersionedResourceListOfTransaction> GetTransactionsWithHttpInfo (string scope, string code, DateTimeOffset? fromTransactionDate = null, DateTimeOffset? toTransactionDate = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, List<string> instrumentPropertyKeys = null, string filter = null);
        /// <summary>
        /// List holdings adjustments
        /// </summary>
        /// <remarks>
        /// Get holdings adjustments from a transaction portfolio in an interval of effective time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="fromEffectiveAt">Holdings adjustments between this time (inclusive) and the toEffectiveAt are returned. (optional)</param>
        /// <param name="toEffectiveAt">Holdings adjustments between this time (inclusive) and the fromEffectiveAt are returned. (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>ResourceListOfHoldingsAdjustmentHeader</returns>
        ResourceListOfHoldingsAdjustmentHeader ListHoldingsAdjustments (string scope, string code, DateTimeOffset? fromEffectiveAt = null, DateTimeOffset? toEffectiveAt = null, DateTimeOffset? asAt = null);

        /// <summary>
        /// List holdings adjustments
        /// </summary>
        /// <remarks>
        /// Get holdings adjustments from a transaction portfolio in an interval of effective time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="fromEffectiveAt">Holdings adjustments between this time (inclusive) and the toEffectiveAt are returned. (optional)</param>
        /// <param name="toEffectiveAt">Holdings adjustments between this time (inclusive) and the fromEffectiveAt are returned. (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>ApiResponse of ResourceListOfHoldingsAdjustmentHeader</returns>
        ApiResponse<ResourceListOfHoldingsAdjustmentHeader> ListHoldingsAdjustmentsWithHttpInfo (string scope, string code, DateTimeOffset? fromEffectiveAt = null, DateTimeOffset? toEffectiveAt = null, DateTimeOffset? asAt = null);
        /// <summary>
        /// Set all holdings on a transaction portfolio
        /// </summary>
        /// <remarks>
        /// Prompt the creation of transactions in a specific transaction portfolio to bring all holdings to the specified targets
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio</param>
        /// <param name="code">The code of the transaction portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <param name="holdingAdjustments">The complete set of holdings adjustments for the portfolio (optional)</param>
        /// <returns>AdjustHolding</returns>
        AdjustHolding SetHoldings (string scope, string code, DateTimeOffset? effectiveAt, List<AdjustHoldingRequest> holdingAdjustments = null);

        /// <summary>
        /// Set all holdings on a transaction portfolio
        /// </summary>
        /// <remarks>
        /// Prompt the creation of transactions in a specific transaction portfolio to bring all holdings to the specified targets
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio</param>
        /// <param name="code">The code of the transaction portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <param name="holdingAdjustments">The complete set of holdings adjustments for the portfolio (optional)</param>
        /// <returns>ApiResponse of AdjustHolding</returns>
        ApiResponse<AdjustHolding> SetHoldingsWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt, List<AdjustHoldingRequest> holdingAdjustments = null);
        /// <summary>
        /// Upsert executions
        /// </summary>
        /// <remarks>
        /// Inserts new executions, or updates those already present
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="executions">The executions to be updated (optional)</param>
        /// <returns>UpsertPortfolioExecutionsResponse</returns>
        UpsertPortfolioExecutionsResponse UpsertExecutions (string scope, string code, List<ExecutionRequest> executions = null);

        /// <summary>
        /// Upsert executions
        /// </summary>
        /// <remarks>
        /// Inserts new executions, or updates those already present
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="executions">The executions to be updated (optional)</param>
        /// <returns>ApiResponse of UpsertPortfolioExecutionsResponse</returns>
        ApiResponse<UpsertPortfolioExecutionsResponse> UpsertExecutionsWithHttpInfo (string scope, string code, List<ExecutionRequest> executions = null);
        /// <summary>
        /// Upsert details
        /// </summary>
        /// <remarks>
        /// Update the portfolio details for the specified transaction portfolios or add if it doesn&#39;t already exist (in the case of a derived transaction portfolio).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="details">The set of details for the portfolio (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the change (optional)</param>
        /// <returns>PortfolioDetails</returns>
        PortfolioDetails UpsertPortfolioDetails (string scope, string code, CreatePortfolioDetails details = null, DateTimeOffset? effectiveAt = null);

        /// <summary>
        /// Upsert details
        /// </summary>
        /// <remarks>
        /// Update the portfolio details for the specified transaction portfolios or add if it doesn&#39;t already exist (in the case of a derived transaction portfolio).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="details">The set of details for the portfolio (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the change (optional)</param>
        /// <returns>ApiResponse of PortfolioDetails</returns>
        ApiResponse<PortfolioDetails> UpsertPortfolioDetailsWithHttpInfo (string scope, string code, CreatePortfolioDetails details = null, DateTimeOffset? effectiveAt = null);
        /// <summary>
        /// Upsert transactions into the specified transaction portfolio
        /// </summary>
        /// <remarks>
        /// Upsert transactions
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code for the portfolio</param>
        /// <param name="transactions">The transactions to be upserted (optional)</param>
        /// <returns>UpsertPortfolioTransactionsResponse</returns>
        UpsertPortfolioTransactionsResponse UpsertTransactions (string scope, string code, List<TransactionRequest> transactions = null);

        /// <summary>
        /// Upsert transactions into the specified transaction portfolio
        /// </summary>
        /// <remarks>
        /// Upsert transactions
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code for the portfolio</param>
        /// <param name="transactions">The transactions to be upserted (optional)</param>
        /// <returns>ApiResponse of UpsertPortfolioTransactionsResponse</returns>
        ApiResponse<UpsertPortfolioTransactionsResponse> UpsertTransactionsWithHttpInfo (string scope, string code, List<TransactionRequest> transactions = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Add transaction properties
        /// </summary>
        /// <remarks>
        /// Upsert one or more transaction properties to a single transaction in a portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="transactionId">Id of transaction</param>
        /// <param name="transactionProperties">Transaction properties values (optional)</param>
        /// <returns>Task of AddTransactionPropertyResponse</returns>
        System.Threading.Tasks.Task<AddTransactionPropertyResponse> AddTransactionPropertyAsync (string scope, string code, string transactionId, Object transactionProperties = null);

        /// <summary>
        /// Add transaction properties
        /// </summary>
        /// <remarks>
        /// Upsert one or more transaction properties to a single transaction in a portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="transactionId">Id of transaction</param>
        /// <param name="transactionProperties">Transaction properties values (optional)</param>
        /// <returns>Task of ApiResponse (AddTransactionPropertyResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddTransactionPropertyResponse>> AddTransactionPropertyAsyncWithHttpInfo (string scope, string code, string transactionId, Object transactionProperties = null);
        /// <summary>
        /// Adjust holdings
        /// </summary>
        /// <remarks>
        /// Adjust one or more holdings in a transaction portfolio    Prompt the creation of transactions in a specific transaction portfolio to bring selected holdings to the specified targets
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <param name="holdingAdjustments">The selected set of holdings adjustments (optional)</param>
        /// <returns>Task of AdjustHolding</returns>
        System.Threading.Tasks.Task<AdjustHolding> AdjustHoldingsAsync (string scope, string code, DateTimeOffset? effectiveAt, List<AdjustHoldingRequest> holdingAdjustments = null);

        /// <summary>
        /// Adjust holdings
        /// </summary>
        /// <remarks>
        /// Adjust one or more holdings in a transaction portfolio    Prompt the creation of transactions in a specific transaction portfolio to bring selected holdings to the specified targets
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <param name="holdingAdjustments">The selected set of holdings adjustments (optional)</param>
        /// <returns>Task of ApiResponse (AdjustHolding)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdjustHolding>> AdjustHoldingsAsyncWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt, List<AdjustHoldingRequest> holdingAdjustments = null);
        /// <summary>
        /// Build output transactions
        /// </summary>
        /// <remarks>
        /// Builds and returns the collection of all types of transactions that affect the holdings of a portfolio in to a set of output transactions
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values to be decorated onto the transactions (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="parameters">Optional. Transaction query parameters (optional)</param>
        /// <returns>Task of VersionedResourceListOfOutputTransaction</returns>
        System.Threading.Tasks.Task<VersionedResourceListOfOutputTransaction> BuildTransactionsAsync (string scope, string code, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, List<string> instrumentPropertyKeys = null, string filter = null, TransactionQueryParameters parameters = null);

        /// <summary>
        /// Build output transactions
        /// </summary>
        /// <remarks>
        /// Builds and returns the collection of all types of transactions that affect the holdings of a portfolio in to a set of output transactions
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values to be decorated onto the transactions (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="parameters">Optional. Transaction query parameters (optional)</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfOutputTransaction)</returns>
        System.Threading.Tasks.Task<ApiResponse<VersionedResourceListOfOutputTransaction>> BuildTransactionsAsyncWithHttpInfo (string scope, string code, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, List<string> instrumentPropertyKeys = null, string filter = null, TransactionQueryParameters parameters = null);
        /// <summary>
        /// Cancel holdings adjustments
        /// </summary>
        /// <remarks>
        /// Cancel previous adjust-holdings for the portfolio for a specific date
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> CancelAdjustHoldingsAsync (string scope, string code, DateTimeOffset? effectiveAt);

        /// <summary>
        /// Cancel holdings adjustments
        /// </summary>
        /// <remarks>
        /// Cancel previous adjust-holdings for the portfolio for a specific date
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> CancelAdjustHoldingsAsyncWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt);
        /// <summary>
        /// Create transaction portfolio
        /// </summary>
        /// <remarks>
        /// Create a transaction portfolio in a specific scope
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope into which the transaction portfolio will be created</param>
        /// <param name="createRequest">The transaction portfolio definition (optional)</param>
        /// <returns>Task of Portfolio</returns>
        System.Threading.Tasks.Task<Portfolio> CreatePortfolioAsync (string scope, CreateTransactionPortfolioRequest createRequest = null);

        /// <summary>
        /// Create transaction portfolio
        /// </summary>
        /// <remarks>
        /// Create a transaction portfolio in a specific scope
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope into which the transaction portfolio will be created</param>
        /// <param name="createRequest">The transaction portfolio definition (optional)</param>
        /// <returns>Task of ApiResponse (Portfolio)</returns>
        System.Threading.Tasks.Task<ApiResponse<Portfolio>> CreatePortfolioAsyncWithHttpInfo (string scope, CreateTransactionPortfolioRequest createRequest = null);
        /// <summary>
        /// Delete executions
        /// </summary>
        /// <remarks>
        /// Delete one or more executions from a transaction portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="executionIds">Ids of executions to delete (optional)</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeleteExecutionsAsync (string scope, string code, List<string> executionIds = null);

        /// <summary>
        /// Delete executions
        /// </summary>
        /// <remarks>
        /// Delete one or more executions from a transaction portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="executionIds">Ids of executions to delete (optional)</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeleteExecutionsAsyncWithHttpInfo (string scope, string code, List<string> executionIds = null);
        /// <summary>
        /// Delete transaction property
        /// </summary>
        /// <remarks>
        /// Delete a property value from a single transaction in a portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="transactionId">Id of the transaction to delete the property from</param>
        /// <param name="transactionPropertyKey">The key of the property to be deleted (optional)</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeletePropertyFromTransactionAsync (string scope, string code, string transactionId, string transactionPropertyKey = null);

        /// <summary>
        /// Delete transaction property
        /// </summary>
        /// <remarks>
        /// Delete a property value from a single transaction in a portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="transactionId">Id of the transaction to delete the property from</param>
        /// <param name="transactionPropertyKey">The key of the property to be deleted (optional)</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeletePropertyFromTransactionAsyncWithHttpInfo (string scope, string code, string transactionId, string transactionPropertyKey = null);
        /// <summary>
        /// Delete transactions
        /// </summary>
        /// <remarks>
        /// Delete one or more transactions from a transaction portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="transactionIds">Ids of transactions to delete (optional)</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeleteTransactionsAsync (string scope, string code, List<string> transactionIds = null);

        /// <summary>
        /// Delete transactions
        /// </summary>
        /// <remarks>
        /// Delete one or more transactions from a transaction portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="transactionIds">Ids of transactions to delete (optional)</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeleteTransactionsAsyncWithHttpInfo (string scope, string code, List<string> transactionIds = null);
        /// <summary>
        /// Get portfolio details
        /// </summary>
        /// <remarks>
        /// Get the details document associated with a transaction portfolio                When requesting details from a derived transaction portfolio, the returned set of details could come from a different transaction portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>Task of PortfolioDetails</returns>
        System.Threading.Tasks.Task<PortfolioDetails> GetDetailsAsync (string scope, string code, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null);

        /// <summary>
        /// Get portfolio details
        /// </summary>
        /// <remarks>
        /// Get the details document associated with a transaction portfolio                When requesting details from a derived transaction portfolio, the returned set of details could come from a different transaction portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioDetails)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioDetails>> GetDetailsAsyncWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null);
        /// <summary>
        /// Get holdings
        /// </summary>
        /// <remarks>
        /// Get the aggregate holdings of a transaction portfolio.  If no effectiveAt or asAt  are supplied then values will be defaulted to the latest system time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="byTaxlots">Option to expand holdings to return the underlying tax-lots (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the portfolio (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values to be decorated onto the holdings (optional)</param>
        /// <returns>Task of VersionedResourceListOfPortfolioHolding</returns>
        System.Threading.Tasks.Task<VersionedResourceListOfPortfolioHolding> GetHoldingsAsync (string scope, string code, bool? byTaxlots = null, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null);

        /// <summary>
        /// Get holdings
        /// </summary>
        /// <remarks>
        /// Get the aggregate holdings of a transaction portfolio.  If no effectiveAt or asAt  are supplied then values will be defaulted to the latest system time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="byTaxlots">Option to expand holdings to return the underlying tax-lots (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the portfolio (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values to be decorated onto the holdings (optional)</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfPortfolioHolding)</returns>
        System.Threading.Tasks.Task<ApiResponse<VersionedResourceListOfPortfolioHolding>> GetHoldingsAsyncWithHttpInfo (string scope, string code, bool? byTaxlots = null, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null);
        /// <summary>
        /// Get holding adjustment
        /// </summary>
        /// <remarks>
        /// Get a holdings adjustment for a transaction portfolio at a specific effective time.    A holdings adjustment definition will only be returned if one exists for the specified effective time
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective time of the holdings adjustment</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>Task of HoldingsAdjustment</returns>
        System.Threading.Tasks.Task<HoldingsAdjustment> GetHoldingsAdjustmentAsync (string scope, string code, DateTimeOffset? effectiveAt, DateTimeOffset? asAt = null);

        /// <summary>
        /// Get holding adjustment
        /// </summary>
        /// <remarks>
        /// Get a holdings adjustment for a transaction portfolio at a specific effective time.    A holdings adjustment definition will only be returned if one exists for the specified effective time
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective time of the holdings adjustment</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>Task of ApiResponse (HoldingsAdjustment)</returns>
        System.Threading.Tasks.Task<ApiResponse<HoldingsAdjustment>> GetHoldingsAdjustmentAsyncWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt, DateTimeOffset? asAt = null);
        /// <summary>
        /// Get transactions
        /// </summary>
        /// <remarks>
        /// Get the transactions from a transaction portfolio    When the requested portfolio is a derived transaction portfolio, the returned set of transactions is the union set of all transactions of the parent (and ancestors) and the specified portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="fromTransactionDate">Optional. Limit the returned transactions to those with a transaction date equal or later than this date (optional)</param>
        /// <param name="toTransactionDate">Optional. Limit the returned transactions to those with a transaction date equal or before this date (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values that will be decorated onto the transactions (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>Task of VersionedResourceListOfTransaction</returns>
        System.Threading.Tasks.Task<VersionedResourceListOfTransaction> GetTransactionsAsync (string scope, string code, DateTimeOffset? fromTransactionDate = null, DateTimeOffset? toTransactionDate = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, List<string> instrumentPropertyKeys = null, string filter = null);

        /// <summary>
        /// Get transactions
        /// </summary>
        /// <remarks>
        /// Get the transactions from a transaction portfolio    When the requested portfolio is a derived transaction portfolio, the returned set of transactions is the union set of all transactions of the parent (and ancestors) and the specified portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="fromTransactionDate">Optional. Limit the returned transactions to those with a transaction date equal or later than this date (optional)</param>
        /// <param name="toTransactionDate">Optional. Limit the returned transactions to those with a transaction date equal or before this date (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values that will be decorated onto the transactions (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfTransaction)</returns>
        System.Threading.Tasks.Task<ApiResponse<VersionedResourceListOfTransaction>> GetTransactionsAsyncWithHttpInfo (string scope, string code, DateTimeOffset? fromTransactionDate = null, DateTimeOffset? toTransactionDate = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, List<string> instrumentPropertyKeys = null, string filter = null);
        /// <summary>
        /// List holdings adjustments
        /// </summary>
        /// <remarks>
        /// Get holdings adjustments from a transaction portfolio in an interval of effective time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="fromEffectiveAt">Holdings adjustments between this time (inclusive) and the toEffectiveAt are returned. (optional)</param>
        /// <param name="toEffectiveAt">Holdings adjustments between this time (inclusive) and the fromEffectiveAt are returned. (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>Task of ResourceListOfHoldingsAdjustmentHeader</returns>
        System.Threading.Tasks.Task<ResourceListOfHoldingsAdjustmentHeader> ListHoldingsAdjustmentsAsync (string scope, string code, DateTimeOffset? fromEffectiveAt = null, DateTimeOffset? toEffectiveAt = null, DateTimeOffset? asAt = null);

        /// <summary>
        /// List holdings adjustments
        /// </summary>
        /// <remarks>
        /// Get holdings adjustments from a transaction portfolio in an interval of effective time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="fromEffectiveAt">Holdings adjustments between this time (inclusive) and the toEffectiveAt are returned. (optional)</param>
        /// <param name="toEffectiveAt">Holdings adjustments between this time (inclusive) and the fromEffectiveAt are returned. (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfHoldingsAdjustmentHeader)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfHoldingsAdjustmentHeader>> ListHoldingsAdjustmentsAsyncWithHttpInfo (string scope, string code, DateTimeOffset? fromEffectiveAt = null, DateTimeOffset? toEffectiveAt = null, DateTimeOffset? asAt = null);
        /// <summary>
        /// Set all holdings on a transaction portfolio
        /// </summary>
        /// <remarks>
        /// Prompt the creation of transactions in a specific transaction portfolio to bring all holdings to the specified targets
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio</param>
        /// <param name="code">The code of the transaction portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <param name="holdingAdjustments">The complete set of holdings adjustments for the portfolio (optional)</param>
        /// <returns>Task of AdjustHolding</returns>
        System.Threading.Tasks.Task<AdjustHolding> SetHoldingsAsync (string scope, string code, DateTimeOffset? effectiveAt, List<AdjustHoldingRequest> holdingAdjustments = null);

        /// <summary>
        /// Set all holdings on a transaction portfolio
        /// </summary>
        /// <remarks>
        /// Prompt the creation of transactions in a specific transaction portfolio to bring all holdings to the specified targets
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio</param>
        /// <param name="code">The code of the transaction portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <param name="holdingAdjustments">The complete set of holdings adjustments for the portfolio (optional)</param>
        /// <returns>Task of ApiResponse (AdjustHolding)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdjustHolding>> SetHoldingsAsyncWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt, List<AdjustHoldingRequest> holdingAdjustments = null);
        /// <summary>
        /// Upsert executions
        /// </summary>
        /// <remarks>
        /// Inserts new executions, or updates those already present
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="executions">The executions to be updated (optional)</param>
        /// <returns>Task of UpsertPortfolioExecutionsResponse</returns>
        System.Threading.Tasks.Task<UpsertPortfolioExecutionsResponse> UpsertExecutionsAsync (string scope, string code, List<ExecutionRequest> executions = null);

        /// <summary>
        /// Upsert executions
        /// </summary>
        /// <remarks>
        /// Inserts new executions, or updates those already present
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="executions">The executions to be updated (optional)</param>
        /// <returns>Task of ApiResponse (UpsertPortfolioExecutionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpsertPortfolioExecutionsResponse>> UpsertExecutionsAsyncWithHttpInfo (string scope, string code, List<ExecutionRequest> executions = null);
        /// <summary>
        /// Upsert details
        /// </summary>
        /// <remarks>
        /// Update the portfolio details for the specified transaction portfolios or add if it doesn&#39;t already exist (in the case of a derived transaction portfolio).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="details">The set of details for the portfolio (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the change (optional)</param>
        /// <returns>Task of PortfolioDetails</returns>
        System.Threading.Tasks.Task<PortfolioDetails> UpsertPortfolioDetailsAsync (string scope, string code, CreatePortfolioDetails details = null, DateTimeOffset? effectiveAt = null);

        /// <summary>
        /// Upsert details
        /// </summary>
        /// <remarks>
        /// Update the portfolio details for the specified transaction portfolios or add if it doesn&#39;t already exist (in the case of a derived transaction portfolio).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="details">The set of details for the portfolio (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the change (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioDetails)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioDetails>> UpsertPortfolioDetailsAsyncWithHttpInfo (string scope, string code, CreatePortfolioDetails details = null, DateTimeOffset? effectiveAt = null);
        /// <summary>
        /// Upsert transactions into the specified transaction portfolio
        /// </summary>
        /// <remarks>
        /// Upsert transactions
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code for the portfolio</param>
        /// <param name="transactions">The transactions to be upserted (optional)</param>
        /// <returns>Task of UpsertPortfolioTransactionsResponse</returns>
        System.Threading.Tasks.Task<UpsertPortfolioTransactionsResponse> UpsertTransactionsAsync (string scope, string code, List<TransactionRequest> transactions = null);

        /// <summary>
        /// Upsert transactions into the specified transaction portfolio
        /// </summary>
        /// <remarks>
        /// Upsert transactions
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code for the portfolio</param>
        /// <param name="transactions">The transactions to be upserted (optional)</param>
        /// <returns>Task of ApiResponse (UpsertPortfolioTransactionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpsertPortfolioTransactionsResponse>> UpsertTransactionsAsyncWithHttpInfo (string scope, string code, List<TransactionRequest> transactions = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TransactionPortfoliosApi : ITransactionPortfoliosApi
    {
        private Lusid.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionPortfoliosApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionPortfoliosApi(String basePath)
        {
            this.Configuration = new Lusid.Sdk.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionPortfoliosApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TransactionPortfoliosApi(Lusid.Sdk.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Lusid.Sdk.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Lusid.Sdk.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Lusid.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Add transaction properties Upsert one or more transaction properties to a single transaction in a portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="transactionId">Id of transaction</param>
        /// <param name="transactionProperties">Transaction properties values (optional)</param>
        /// <returns>AddTransactionPropertyResponse</returns>
        public AddTransactionPropertyResponse AddTransactionProperty (string scope, string code, string transactionId, Object transactionProperties = null)
        {
             ApiResponse<AddTransactionPropertyResponse> localVarResponse = AddTransactionPropertyWithHttpInfo(scope, code, transactionId, transactionProperties);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add transaction properties Upsert one or more transaction properties to a single transaction in a portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="transactionId">Id of transaction</param>
        /// <param name="transactionProperties">Transaction properties values (optional)</param>
        /// <returns>ApiResponse of AddTransactionPropertyResponse</returns>
        public ApiResponse< AddTransactionPropertyResponse > AddTransactionPropertyWithHttpInfo (string scope, string code, string transactionId, Object transactionProperties = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->AddTransactionProperty");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->AddTransactionProperty");
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling TransactionPortfoliosApi->AddTransactionProperty");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/properties";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (transactionId != null) localVarPathParams.Add("transactionId", this.Configuration.ApiClient.ParameterToString(transactionId)); // path parameter
            if (transactionProperties != null && transactionProperties.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(transactionProperties); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transactionProperties; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddTransactionProperty", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AddTransactionPropertyResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (AddTransactionPropertyResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AddTransactionPropertyResponse)));
        }

        /// <summary>
        /// Add transaction properties Upsert one or more transaction properties to a single transaction in a portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="transactionId">Id of transaction</param>
        /// <param name="transactionProperties">Transaction properties values (optional)</param>
        /// <returns>Task of AddTransactionPropertyResponse</returns>
        public async System.Threading.Tasks.Task<AddTransactionPropertyResponse> AddTransactionPropertyAsync (string scope, string code, string transactionId, Object transactionProperties = null)
        {
             ApiResponse<AddTransactionPropertyResponse> localVarResponse = await AddTransactionPropertyAsyncWithHttpInfo(scope, code, transactionId, transactionProperties);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add transaction properties Upsert one or more transaction properties to a single transaction in a portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="transactionId">Id of transaction</param>
        /// <param name="transactionProperties">Transaction properties values (optional)</param>
        /// <returns>Task of ApiResponse (AddTransactionPropertyResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AddTransactionPropertyResponse>> AddTransactionPropertyAsyncWithHttpInfo (string scope, string code, string transactionId, Object transactionProperties = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->AddTransactionProperty");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->AddTransactionProperty");
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling TransactionPortfoliosApi->AddTransactionProperty");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/properties";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (transactionId != null) localVarPathParams.Add("transactionId", this.Configuration.ApiClient.ParameterToString(transactionId)); // path parameter
            if (transactionProperties != null && transactionProperties.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(transactionProperties); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transactionProperties; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddTransactionProperty", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AddTransactionPropertyResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (AddTransactionPropertyResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AddTransactionPropertyResponse)));
        }

        /// <summary>
        /// Adjust holdings Adjust one or more holdings in a transaction portfolio    Prompt the creation of transactions in a specific transaction portfolio to bring selected holdings to the specified targets
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <param name="holdingAdjustments">The selected set of holdings adjustments (optional)</param>
        /// <returns>AdjustHolding</returns>
        public AdjustHolding AdjustHoldings (string scope, string code, DateTimeOffset? effectiveAt, List<AdjustHoldingRequest> holdingAdjustments = null)
        {
             ApiResponse<AdjustHolding> localVarResponse = AdjustHoldingsWithHttpInfo(scope, code, effectiveAt, holdingAdjustments);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Adjust holdings Adjust one or more holdings in a transaction portfolio    Prompt the creation of transactions in a specific transaction portfolio to bring selected holdings to the specified targets
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <param name="holdingAdjustments">The selected set of holdings adjustments (optional)</param>
        /// <returns>ApiResponse of AdjustHolding</returns>
        public ApiResponse< AdjustHolding > AdjustHoldingsWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt, List<AdjustHoldingRequest> holdingAdjustments = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->AdjustHoldings");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->AdjustHoldings");
            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new ApiException(400, "Missing required parameter 'effectiveAt' when calling TransactionPortfoliosApi->AdjustHoldings");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/holdings/{effectiveAt}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (effectiveAt != null) localVarPathParams.Add("effectiveAt", this.Configuration.ApiClient.ParameterToString(effectiveAt)); // path parameter
            if (holdingAdjustments != null && holdingAdjustments.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(holdingAdjustments); // http body (model) parameter
            }
            else
            {
                localVarPostBody = holdingAdjustments; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AdjustHoldings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AdjustHolding>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (AdjustHolding) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdjustHolding)));
        }

        /// <summary>
        /// Adjust holdings Adjust one or more holdings in a transaction portfolio    Prompt the creation of transactions in a specific transaction portfolio to bring selected holdings to the specified targets
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <param name="holdingAdjustments">The selected set of holdings adjustments (optional)</param>
        /// <returns>Task of AdjustHolding</returns>
        public async System.Threading.Tasks.Task<AdjustHolding> AdjustHoldingsAsync (string scope, string code, DateTimeOffset? effectiveAt, List<AdjustHoldingRequest> holdingAdjustments = null)
        {
             ApiResponse<AdjustHolding> localVarResponse = await AdjustHoldingsAsyncWithHttpInfo(scope, code, effectiveAt, holdingAdjustments);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Adjust holdings Adjust one or more holdings in a transaction portfolio    Prompt the creation of transactions in a specific transaction portfolio to bring selected holdings to the specified targets
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <param name="holdingAdjustments">The selected set of holdings adjustments (optional)</param>
        /// <returns>Task of ApiResponse (AdjustHolding)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdjustHolding>> AdjustHoldingsAsyncWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt, List<AdjustHoldingRequest> holdingAdjustments = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->AdjustHoldings");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->AdjustHoldings");
            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new ApiException(400, "Missing required parameter 'effectiveAt' when calling TransactionPortfoliosApi->AdjustHoldings");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/holdings/{effectiveAt}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (effectiveAt != null) localVarPathParams.Add("effectiveAt", this.Configuration.ApiClient.ParameterToString(effectiveAt)); // path parameter
            if (holdingAdjustments != null && holdingAdjustments.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(holdingAdjustments); // http body (model) parameter
            }
            else
            {
                localVarPostBody = holdingAdjustments; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AdjustHoldings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AdjustHolding>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (AdjustHolding) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdjustHolding)));
        }

        /// <summary>
        /// Build output transactions Builds and returns the collection of all types of transactions that affect the holdings of a portfolio in to a set of output transactions
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values to be decorated onto the transactions (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="parameters">Optional. Transaction query parameters (optional)</param>
        /// <returns>VersionedResourceListOfOutputTransaction</returns>
        public VersionedResourceListOfOutputTransaction BuildTransactions (string scope, string code, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, List<string> instrumentPropertyKeys = null, string filter = null, TransactionQueryParameters parameters = null)
        {
             ApiResponse<VersionedResourceListOfOutputTransaction> localVarResponse = BuildTransactionsWithHttpInfo(scope, code, asAt, sortBy, start, limit, instrumentPropertyKeys, filter, parameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Build output transactions Builds and returns the collection of all types of transactions that affect the holdings of a portfolio in to a set of output transactions
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values to be decorated onto the transactions (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="parameters">Optional. Transaction query parameters (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfOutputTransaction</returns>
        public ApiResponse< VersionedResourceListOfOutputTransaction > BuildTransactionsWithHttpInfo (string scope, string code, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, List<string> instrumentPropertyKeys = null, string filter = null, TransactionQueryParameters parameters = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->BuildTransactions");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->BuildTransactions");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/transactions/$build";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter
            if (sortBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "sortBy", sortBy)); // query parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (instrumentPropertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "instrumentPropertyKeys", instrumentPropertyKeys)); // query parameter
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (parameters != null && parameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(parameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = parameters; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BuildTransactions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VersionedResourceListOfOutputTransaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (VersionedResourceListOfOutputTransaction) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VersionedResourceListOfOutputTransaction)));
        }

        /// <summary>
        /// Build output transactions Builds and returns the collection of all types of transactions that affect the holdings of a portfolio in to a set of output transactions
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values to be decorated onto the transactions (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="parameters">Optional. Transaction query parameters (optional)</param>
        /// <returns>Task of VersionedResourceListOfOutputTransaction</returns>
        public async System.Threading.Tasks.Task<VersionedResourceListOfOutputTransaction> BuildTransactionsAsync (string scope, string code, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, List<string> instrumentPropertyKeys = null, string filter = null, TransactionQueryParameters parameters = null)
        {
             ApiResponse<VersionedResourceListOfOutputTransaction> localVarResponse = await BuildTransactionsAsyncWithHttpInfo(scope, code, asAt, sortBy, start, limit, instrumentPropertyKeys, filter, parameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Build output transactions Builds and returns the collection of all types of transactions that affect the holdings of a portfolio in to a set of output transactions
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values to be decorated onto the transactions (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="parameters">Optional. Transaction query parameters (optional)</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfOutputTransaction)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VersionedResourceListOfOutputTransaction>> BuildTransactionsAsyncWithHttpInfo (string scope, string code, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, List<string> instrumentPropertyKeys = null, string filter = null, TransactionQueryParameters parameters = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->BuildTransactions");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->BuildTransactions");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/transactions/$build";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter
            if (sortBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "sortBy", sortBy)); // query parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (instrumentPropertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "instrumentPropertyKeys", instrumentPropertyKeys)); // query parameter
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (parameters != null && parameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(parameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = parameters; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BuildTransactions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VersionedResourceListOfOutputTransaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (VersionedResourceListOfOutputTransaction) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VersionedResourceListOfOutputTransaction)));
        }

        /// <summary>
        /// Cancel holdings adjustments Cancel previous adjust-holdings for the portfolio for a specific date
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse CancelAdjustHoldings (string scope, string code, DateTimeOffset? effectiveAt)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = CancelAdjustHoldingsWithHttpInfo(scope, code, effectiveAt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancel holdings adjustments Cancel previous adjust-holdings for the portfolio for a specific date
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public ApiResponse< DeletedEntityResponse > CancelAdjustHoldingsWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->CancelAdjustHoldings");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->CancelAdjustHoldings");
            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new ApiException(400, "Missing required parameter 'effectiveAt' when calling TransactionPortfoliosApi->CancelAdjustHoldings");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/holdings/{effectiveAt}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (effectiveAt != null) localVarPathParams.Add("effectiveAt", this.Configuration.ApiClient.ParameterToString(effectiveAt)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CancelAdjustHoldings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeletedEntityResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

        /// <summary>
        /// Cancel holdings adjustments Cancel previous adjust-holdings for the portfolio for a specific date
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> CancelAdjustHoldingsAsync (string scope, string code, DateTimeOffset? effectiveAt)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = await CancelAdjustHoldingsAsyncWithHttpInfo(scope, code, effectiveAt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancel holdings adjustments Cancel previous adjust-holdings for the portfolio for a specific date
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> CancelAdjustHoldingsAsyncWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->CancelAdjustHoldings");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->CancelAdjustHoldings");
            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new ApiException(400, "Missing required parameter 'effectiveAt' when calling TransactionPortfoliosApi->CancelAdjustHoldings");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/holdings/{effectiveAt}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (effectiveAt != null) localVarPathParams.Add("effectiveAt", this.Configuration.ApiClient.ParameterToString(effectiveAt)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CancelAdjustHoldings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeletedEntityResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

        /// <summary>
        /// Create transaction portfolio Create a transaction portfolio in a specific scope
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope into which the transaction portfolio will be created</param>
        /// <param name="createRequest">The transaction portfolio definition (optional)</param>
        /// <returns>Portfolio</returns>
        public Portfolio CreatePortfolio (string scope, CreateTransactionPortfolioRequest createRequest = null)
        {
             ApiResponse<Portfolio> localVarResponse = CreatePortfolioWithHttpInfo(scope, createRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create transaction portfolio Create a transaction portfolio in a specific scope
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope into which the transaction portfolio will be created</param>
        /// <param name="createRequest">The transaction portfolio definition (optional)</param>
        /// <returns>ApiResponse of Portfolio</returns>
        public ApiResponse< Portfolio > CreatePortfolioWithHttpInfo (string scope, CreateTransactionPortfolioRequest createRequest = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->CreatePortfolio");

            var localVarPath = "./api/transactionportfolios/{scope}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (createRequest != null && createRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(createRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createRequest; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreatePortfolio", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Portfolio>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (Portfolio) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Portfolio)));
        }

        /// <summary>
        /// Create transaction portfolio Create a transaction portfolio in a specific scope
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope into which the transaction portfolio will be created</param>
        /// <param name="createRequest">The transaction portfolio definition (optional)</param>
        /// <returns>Task of Portfolio</returns>
        public async System.Threading.Tasks.Task<Portfolio> CreatePortfolioAsync (string scope, CreateTransactionPortfolioRequest createRequest = null)
        {
             ApiResponse<Portfolio> localVarResponse = await CreatePortfolioAsyncWithHttpInfo(scope, createRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create transaction portfolio Create a transaction portfolio in a specific scope
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope into which the transaction portfolio will be created</param>
        /// <param name="createRequest">The transaction portfolio definition (optional)</param>
        /// <returns>Task of ApiResponse (Portfolio)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Portfolio>> CreatePortfolioAsyncWithHttpInfo (string scope, CreateTransactionPortfolioRequest createRequest = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->CreatePortfolio");

            var localVarPath = "./api/transactionportfolios/{scope}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (createRequest != null && createRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(createRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createRequest; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreatePortfolio", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Portfolio>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (Portfolio) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Portfolio)));
        }

        /// <summary>
        /// Delete executions Delete one or more executions from a transaction portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="executionIds">Ids of executions to delete (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeleteExecutions (string scope, string code, List<string> executionIds = null)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = DeleteExecutionsWithHttpInfo(scope, code, executionIds);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete executions Delete one or more executions from a transaction portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="executionIds">Ids of executions to delete (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public ApiResponse< DeletedEntityResponse > DeleteExecutionsWithHttpInfo (string scope, string code, List<string> executionIds = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->DeleteExecutions");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->DeleteExecutions");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/executions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (executionIds != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "executionIds", executionIds)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteExecutions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeletedEntityResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

        /// <summary>
        /// Delete executions Delete one or more executions from a transaction portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="executionIds">Ids of executions to delete (optional)</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeleteExecutionsAsync (string scope, string code, List<string> executionIds = null)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = await DeleteExecutionsAsyncWithHttpInfo(scope, code, executionIds);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete executions Delete one or more executions from a transaction portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="executionIds">Ids of executions to delete (optional)</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeleteExecutionsAsyncWithHttpInfo (string scope, string code, List<string> executionIds = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->DeleteExecutions");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->DeleteExecutions");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/executions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (executionIds != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "executionIds", executionIds)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteExecutions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeletedEntityResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

        /// <summary>
        /// Delete transaction property Delete a property value from a single transaction in a portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="transactionId">Id of the transaction to delete the property from</param>
        /// <param name="transactionPropertyKey">The key of the property to be deleted (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeletePropertyFromTransaction (string scope, string code, string transactionId, string transactionPropertyKey = null)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = DeletePropertyFromTransactionWithHttpInfo(scope, code, transactionId, transactionPropertyKey);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete transaction property Delete a property value from a single transaction in a portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="transactionId">Id of the transaction to delete the property from</param>
        /// <param name="transactionPropertyKey">The key of the property to be deleted (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public ApiResponse< DeletedEntityResponse > DeletePropertyFromTransactionWithHttpInfo (string scope, string code, string transactionId, string transactionPropertyKey = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->DeletePropertyFromTransaction");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->DeletePropertyFromTransaction");
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling TransactionPortfoliosApi->DeletePropertyFromTransaction");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/properties";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (transactionId != null) localVarPathParams.Add("transactionId", this.Configuration.ApiClient.ParameterToString(transactionId)); // path parameter
            if (transactionPropertyKey != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "transactionPropertyKey", transactionPropertyKey)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeletePropertyFromTransaction", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeletedEntityResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

        /// <summary>
        /// Delete transaction property Delete a property value from a single transaction in a portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="transactionId">Id of the transaction to delete the property from</param>
        /// <param name="transactionPropertyKey">The key of the property to be deleted (optional)</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeletePropertyFromTransactionAsync (string scope, string code, string transactionId, string transactionPropertyKey = null)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = await DeletePropertyFromTransactionAsyncWithHttpInfo(scope, code, transactionId, transactionPropertyKey);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete transaction property Delete a property value from a single transaction in a portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="transactionId">Id of the transaction to delete the property from</param>
        /// <param name="transactionPropertyKey">The key of the property to be deleted (optional)</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeletePropertyFromTransactionAsyncWithHttpInfo (string scope, string code, string transactionId, string transactionPropertyKey = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->DeletePropertyFromTransaction");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->DeletePropertyFromTransaction");
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling TransactionPortfoliosApi->DeletePropertyFromTransaction");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/properties";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (transactionId != null) localVarPathParams.Add("transactionId", this.Configuration.ApiClient.ParameterToString(transactionId)); // path parameter
            if (transactionPropertyKey != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "transactionPropertyKey", transactionPropertyKey)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeletePropertyFromTransaction", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeletedEntityResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

        /// <summary>
        /// Delete transactions Delete one or more transactions from a transaction portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="transactionIds">Ids of transactions to delete (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeleteTransactions (string scope, string code, List<string> transactionIds = null)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = DeleteTransactionsWithHttpInfo(scope, code, transactionIds);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete transactions Delete one or more transactions from a transaction portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="transactionIds">Ids of transactions to delete (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public ApiResponse< DeletedEntityResponse > DeleteTransactionsWithHttpInfo (string scope, string code, List<string> transactionIds = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->DeleteTransactions");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->DeleteTransactions");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/transactions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (transactionIds != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "transactionIds", transactionIds)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteTransactions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeletedEntityResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

        /// <summary>
        /// Delete transactions Delete one or more transactions from a transaction portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="transactionIds">Ids of transactions to delete (optional)</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeleteTransactionsAsync (string scope, string code, List<string> transactionIds = null)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = await DeleteTransactionsAsyncWithHttpInfo(scope, code, transactionIds);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete transactions Delete one or more transactions from a transaction portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="transactionIds">Ids of transactions to delete (optional)</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeleteTransactionsAsyncWithHttpInfo (string scope, string code, List<string> transactionIds = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->DeleteTransactions");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->DeleteTransactions");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/transactions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (transactionIds != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "transactionIds", transactionIds)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteTransactions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeletedEntityResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

        /// <summary>
        /// Get portfolio details Get the details document associated with a transaction portfolio                When requesting details from a derived transaction portfolio, the returned set of details could come from a different transaction portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>PortfolioDetails</returns>
        public PortfolioDetails GetDetails (string scope, string code, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null)
        {
             ApiResponse<PortfolioDetails> localVarResponse = GetDetailsWithHttpInfo(scope, code, effectiveAt, asAt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get portfolio details Get the details document associated with a transaction portfolio                When requesting details from a derived transaction portfolio, the returned set of details could come from a different transaction portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>ApiResponse of PortfolioDetails</returns>
        public ApiResponse< PortfolioDetails > GetDetailsWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetDetails");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetDetails");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/details";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (effectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "effectiveAt", effectiveAt)); // query parameter
            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PortfolioDetails>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (PortfolioDetails) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortfolioDetails)));
        }

        /// <summary>
        /// Get portfolio details Get the details document associated with a transaction portfolio                When requesting details from a derived transaction portfolio, the returned set of details could come from a different transaction portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>Task of PortfolioDetails</returns>
        public async System.Threading.Tasks.Task<PortfolioDetails> GetDetailsAsync (string scope, string code, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null)
        {
             ApiResponse<PortfolioDetails> localVarResponse = await GetDetailsAsyncWithHttpInfo(scope, code, effectiveAt, asAt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get portfolio details Get the details document associated with a transaction portfolio                When requesting details from a derived transaction portfolio, the returned set of details could come from a different transaction portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioDetails)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PortfolioDetails>> GetDetailsAsyncWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetDetails");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetDetails");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/details";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (effectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "effectiveAt", effectiveAt)); // query parameter
            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PortfolioDetails>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (PortfolioDetails) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortfolioDetails)));
        }

        /// <summary>
        /// Get holdings Get the aggregate holdings of a transaction portfolio.  If no effectiveAt or asAt  are supplied then values will be defaulted to the latest system time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="byTaxlots">Option to expand holdings to return the underlying tax-lots (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the portfolio (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values to be decorated onto the holdings (optional)</param>
        /// <returns>VersionedResourceListOfPortfolioHolding</returns>
        public VersionedResourceListOfPortfolioHolding GetHoldings (string scope, string code, bool? byTaxlots = null, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null)
        {
             ApiResponse<VersionedResourceListOfPortfolioHolding> localVarResponse = GetHoldingsWithHttpInfo(scope, code, byTaxlots, effectiveAt, asAt, sortBy, start, limit, filter, instrumentPropertyKeys);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get holdings Get the aggregate holdings of a transaction portfolio.  If no effectiveAt or asAt  are supplied then values will be defaulted to the latest system time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="byTaxlots">Option to expand holdings to return the underlying tax-lots (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the portfolio (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values to be decorated onto the holdings (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfPortfolioHolding</returns>
        public ApiResponse< VersionedResourceListOfPortfolioHolding > GetHoldingsWithHttpInfo (string scope, string code, bool? byTaxlots = null, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetHoldings");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetHoldings");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/holdings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (byTaxlots != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "byTaxlots", byTaxlots)); // query parameter
            if (effectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "effectiveAt", effectiveAt)); // query parameter
            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter
            if (sortBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "sortBy", sortBy)); // query parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (instrumentPropertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "instrumentPropertyKeys", instrumentPropertyKeys)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetHoldings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VersionedResourceListOfPortfolioHolding>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (VersionedResourceListOfPortfolioHolding) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VersionedResourceListOfPortfolioHolding)));
        }

        /// <summary>
        /// Get holdings Get the aggregate holdings of a transaction portfolio.  If no effectiveAt or asAt  are supplied then values will be defaulted to the latest system time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="byTaxlots">Option to expand holdings to return the underlying tax-lots (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the portfolio (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values to be decorated onto the holdings (optional)</param>
        /// <returns>Task of VersionedResourceListOfPortfolioHolding</returns>
        public async System.Threading.Tasks.Task<VersionedResourceListOfPortfolioHolding> GetHoldingsAsync (string scope, string code, bool? byTaxlots = null, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null)
        {
             ApiResponse<VersionedResourceListOfPortfolioHolding> localVarResponse = await GetHoldingsAsyncWithHttpInfo(scope, code, byTaxlots, effectiveAt, asAt, sortBy, start, limit, filter, instrumentPropertyKeys);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get holdings Get the aggregate holdings of a transaction portfolio.  If no effectiveAt or asAt  are supplied then values will be defaulted to the latest system time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="byTaxlots">Option to expand holdings to return the underlying tax-lots (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the portfolio (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values to be decorated onto the holdings (optional)</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfPortfolioHolding)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VersionedResourceListOfPortfolioHolding>> GetHoldingsAsyncWithHttpInfo (string scope, string code, bool? byTaxlots = null, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetHoldings");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetHoldings");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/holdings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (byTaxlots != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "byTaxlots", byTaxlots)); // query parameter
            if (effectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "effectiveAt", effectiveAt)); // query parameter
            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter
            if (sortBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "sortBy", sortBy)); // query parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (instrumentPropertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "instrumentPropertyKeys", instrumentPropertyKeys)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetHoldings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VersionedResourceListOfPortfolioHolding>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (VersionedResourceListOfPortfolioHolding) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VersionedResourceListOfPortfolioHolding)));
        }

        /// <summary>
        /// Get holding adjustment Get a holdings adjustment for a transaction portfolio at a specific effective time.    A holdings adjustment definition will only be returned if one exists for the specified effective time
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective time of the holdings adjustment</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>HoldingsAdjustment</returns>
        public HoldingsAdjustment GetHoldingsAdjustment (string scope, string code, DateTimeOffset? effectiveAt, DateTimeOffset? asAt = null)
        {
             ApiResponse<HoldingsAdjustment> localVarResponse = GetHoldingsAdjustmentWithHttpInfo(scope, code, effectiveAt, asAt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get holding adjustment Get a holdings adjustment for a transaction portfolio at a specific effective time.    A holdings adjustment definition will only be returned if one exists for the specified effective time
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective time of the holdings adjustment</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>ApiResponse of HoldingsAdjustment</returns>
        public ApiResponse< HoldingsAdjustment > GetHoldingsAdjustmentWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt, DateTimeOffset? asAt = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetHoldingsAdjustment");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetHoldingsAdjustment");
            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new ApiException(400, "Missing required parameter 'effectiveAt' when calling TransactionPortfoliosApi->GetHoldingsAdjustment");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/holdingsadjustments/{effectiveAt}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (effectiveAt != null) localVarPathParams.Add("effectiveAt", this.Configuration.ApiClient.ParameterToString(effectiveAt)); // path parameter
            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetHoldingsAdjustment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<HoldingsAdjustment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (HoldingsAdjustment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(HoldingsAdjustment)));
        }

        /// <summary>
        /// Get holding adjustment Get a holdings adjustment for a transaction portfolio at a specific effective time.    A holdings adjustment definition will only be returned if one exists for the specified effective time
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective time of the holdings adjustment</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>Task of HoldingsAdjustment</returns>
        public async System.Threading.Tasks.Task<HoldingsAdjustment> GetHoldingsAdjustmentAsync (string scope, string code, DateTimeOffset? effectiveAt, DateTimeOffset? asAt = null)
        {
             ApiResponse<HoldingsAdjustment> localVarResponse = await GetHoldingsAdjustmentAsyncWithHttpInfo(scope, code, effectiveAt, asAt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get holding adjustment Get a holdings adjustment for a transaction portfolio at a specific effective time.    A holdings adjustment definition will only be returned if one exists for the specified effective time
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective time of the holdings adjustment</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>Task of ApiResponse (HoldingsAdjustment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HoldingsAdjustment>> GetHoldingsAdjustmentAsyncWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt, DateTimeOffset? asAt = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetHoldingsAdjustment");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetHoldingsAdjustment");
            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new ApiException(400, "Missing required parameter 'effectiveAt' when calling TransactionPortfoliosApi->GetHoldingsAdjustment");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/holdingsadjustments/{effectiveAt}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (effectiveAt != null) localVarPathParams.Add("effectiveAt", this.Configuration.ApiClient.ParameterToString(effectiveAt)); // path parameter
            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetHoldingsAdjustment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<HoldingsAdjustment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (HoldingsAdjustment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(HoldingsAdjustment)));
        }

        /// <summary>
        /// Get transactions Get the transactions from a transaction portfolio    When the requested portfolio is a derived transaction portfolio, the returned set of transactions is the union set of all transactions of the parent (and ancestors) and the specified portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="fromTransactionDate">Optional. Limit the returned transactions to those with a transaction date equal or later than this date (optional)</param>
        /// <param name="toTransactionDate">Optional. Limit the returned transactions to those with a transaction date equal or before this date (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values that will be decorated onto the transactions (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>VersionedResourceListOfTransaction</returns>
        public VersionedResourceListOfTransaction GetTransactions (string scope, string code, DateTimeOffset? fromTransactionDate = null, DateTimeOffset? toTransactionDate = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, List<string> instrumentPropertyKeys = null, string filter = null)
        {
             ApiResponse<VersionedResourceListOfTransaction> localVarResponse = GetTransactionsWithHttpInfo(scope, code, fromTransactionDate, toTransactionDate, asAt, sortBy, start, limit, instrumentPropertyKeys, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get transactions Get the transactions from a transaction portfolio    When the requested portfolio is a derived transaction portfolio, the returned set of transactions is the union set of all transactions of the parent (and ancestors) and the specified portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="fromTransactionDate">Optional. Limit the returned transactions to those with a transaction date equal or later than this date (optional)</param>
        /// <param name="toTransactionDate">Optional. Limit the returned transactions to those with a transaction date equal or before this date (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values that will be decorated onto the transactions (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfTransaction</returns>
        public ApiResponse< VersionedResourceListOfTransaction > GetTransactionsWithHttpInfo (string scope, string code, DateTimeOffset? fromTransactionDate = null, DateTimeOffset? toTransactionDate = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, List<string> instrumentPropertyKeys = null, string filter = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetTransactions");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetTransactions");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/transactions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (fromTransactionDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "fromTransactionDate", fromTransactionDate)); // query parameter
            if (toTransactionDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "toTransactionDate", toTransactionDate)); // query parameter
            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter
            if (sortBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "sortBy", sortBy)); // query parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (instrumentPropertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "instrumentPropertyKeys", instrumentPropertyKeys)); // query parameter
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTransactions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VersionedResourceListOfTransaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (VersionedResourceListOfTransaction) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VersionedResourceListOfTransaction)));
        }

        /// <summary>
        /// Get transactions Get the transactions from a transaction portfolio    When the requested portfolio is a derived transaction portfolio, the returned set of transactions is the union set of all transactions of the parent (and ancestors) and the specified portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="fromTransactionDate">Optional. Limit the returned transactions to those with a transaction date equal or later than this date (optional)</param>
        /// <param name="toTransactionDate">Optional. Limit the returned transactions to those with a transaction date equal or before this date (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values that will be decorated onto the transactions (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>Task of VersionedResourceListOfTransaction</returns>
        public async System.Threading.Tasks.Task<VersionedResourceListOfTransaction> GetTransactionsAsync (string scope, string code, DateTimeOffset? fromTransactionDate = null, DateTimeOffset? toTransactionDate = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, List<string> instrumentPropertyKeys = null, string filter = null)
        {
             ApiResponse<VersionedResourceListOfTransaction> localVarResponse = await GetTransactionsAsyncWithHttpInfo(scope, code, fromTransactionDate, toTransactionDate, asAt, sortBy, start, limit, instrumentPropertyKeys, filter);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get transactions Get the transactions from a transaction portfolio    When the requested portfolio is a derived transaction portfolio, the returned set of transactions is the union set of all transactions of the parent (and ancestors) and the specified portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="fromTransactionDate">Optional. Limit the returned transactions to those with a transaction date equal or later than this date (optional)</param>
        /// <param name="toTransactionDate">Optional. Limit the returned transactions to those with a transaction date equal or before this date (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys for the instrument property values that will be decorated onto the transactions (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfTransaction)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VersionedResourceListOfTransaction>> GetTransactionsAsyncWithHttpInfo (string scope, string code, DateTimeOffset? fromTransactionDate = null, DateTimeOffset? toTransactionDate = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, List<string> instrumentPropertyKeys = null, string filter = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetTransactions");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetTransactions");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/transactions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (fromTransactionDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "fromTransactionDate", fromTransactionDate)); // query parameter
            if (toTransactionDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "toTransactionDate", toTransactionDate)); // query parameter
            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter
            if (sortBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "sortBy", sortBy)); // query parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (instrumentPropertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "instrumentPropertyKeys", instrumentPropertyKeys)); // query parameter
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTransactions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VersionedResourceListOfTransaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (VersionedResourceListOfTransaction) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VersionedResourceListOfTransaction)));
        }

        /// <summary>
        /// List holdings adjustments Get holdings adjustments from a transaction portfolio in an interval of effective time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="fromEffectiveAt">Holdings adjustments between this time (inclusive) and the toEffectiveAt are returned. (optional)</param>
        /// <param name="toEffectiveAt">Holdings adjustments between this time (inclusive) and the fromEffectiveAt are returned. (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>ResourceListOfHoldingsAdjustmentHeader</returns>
        public ResourceListOfHoldingsAdjustmentHeader ListHoldingsAdjustments (string scope, string code, DateTimeOffset? fromEffectiveAt = null, DateTimeOffset? toEffectiveAt = null, DateTimeOffset? asAt = null)
        {
             ApiResponse<ResourceListOfHoldingsAdjustmentHeader> localVarResponse = ListHoldingsAdjustmentsWithHttpInfo(scope, code, fromEffectiveAt, toEffectiveAt, asAt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List holdings adjustments Get holdings adjustments from a transaction portfolio in an interval of effective time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="fromEffectiveAt">Holdings adjustments between this time (inclusive) and the toEffectiveAt are returned. (optional)</param>
        /// <param name="toEffectiveAt">Holdings adjustments between this time (inclusive) and the fromEffectiveAt are returned. (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>ApiResponse of ResourceListOfHoldingsAdjustmentHeader</returns>
        public ApiResponse< ResourceListOfHoldingsAdjustmentHeader > ListHoldingsAdjustmentsWithHttpInfo (string scope, string code, DateTimeOffset? fromEffectiveAt = null, DateTimeOffset? toEffectiveAt = null, DateTimeOffset? asAt = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->ListHoldingsAdjustments");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->ListHoldingsAdjustments");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/holdingsadjustments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (fromEffectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "fromEffectiveAt", fromEffectiveAt)); // query parameter
            if (toEffectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "toEffectiveAt", toEffectiveAt)); // query parameter
            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListHoldingsAdjustments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResourceListOfHoldingsAdjustmentHeader>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (ResourceListOfHoldingsAdjustmentHeader) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfHoldingsAdjustmentHeader)));
        }

        /// <summary>
        /// List holdings adjustments Get holdings adjustments from a transaction portfolio in an interval of effective time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="fromEffectiveAt">Holdings adjustments between this time (inclusive) and the toEffectiveAt are returned. (optional)</param>
        /// <param name="toEffectiveAt">Holdings adjustments between this time (inclusive) and the fromEffectiveAt are returned. (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>Task of ResourceListOfHoldingsAdjustmentHeader</returns>
        public async System.Threading.Tasks.Task<ResourceListOfHoldingsAdjustmentHeader> ListHoldingsAdjustmentsAsync (string scope, string code, DateTimeOffset? fromEffectiveAt = null, DateTimeOffset? toEffectiveAt = null, DateTimeOffset? asAt = null)
        {
             ApiResponse<ResourceListOfHoldingsAdjustmentHeader> localVarResponse = await ListHoldingsAdjustmentsAsyncWithHttpInfo(scope, code, fromEffectiveAt, toEffectiveAt, asAt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List holdings adjustments Get holdings adjustments from a transaction portfolio in an interval of effective time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="fromEffectiveAt">Holdings adjustments between this time (inclusive) and the toEffectiveAt are returned. (optional)</param>
        /// <param name="toEffectiveAt">Holdings adjustments between this time (inclusive) and the fromEffectiveAt are returned. (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfHoldingsAdjustmentHeader)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResourceListOfHoldingsAdjustmentHeader>> ListHoldingsAdjustmentsAsyncWithHttpInfo (string scope, string code, DateTimeOffset? fromEffectiveAt = null, DateTimeOffset? toEffectiveAt = null, DateTimeOffset? asAt = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->ListHoldingsAdjustments");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->ListHoldingsAdjustments");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/holdingsadjustments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (fromEffectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "fromEffectiveAt", fromEffectiveAt)); // query parameter
            if (toEffectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "toEffectiveAt", toEffectiveAt)); // query parameter
            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListHoldingsAdjustments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResourceListOfHoldingsAdjustmentHeader>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (ResourceListOfHoldingsAdjustmentHeader) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfHoldingsAdjustmentHeader)));
        }

        /// <summary>
        /// Set all holdings on a transaction portfolio Prompt the creation of transactions in a specific transaction portfolio to bring all holdings to the specified targets
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio</param>
        /// <param name="code">The code of the transaction portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <param name="holdingAdjustments">The complete set of holdings adjustments for the portfolio (optional)</param>
        /// <returns>AdjustHolding</returns>
        public AdjustHolding SetHoldings (string scope, string code, DateTimeOffset? effectiveAt, List<AdjustHoldingRequest> holdingAdjustments = null)
        {
             ApiResponse<AdjustHolding> localVarResponse = SetHoldingsWithHttpInfo(scope, code, effectiveAt, holdingAdjustments);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Set all holdings on a transaction portfolio Prompt the creation of transactions in a specific transaction portfolio to bring all holdings to the specified targets
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio</param>
        /// <param name="code">The code of the transaction portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <param name="holdingAdjustments">The complete set of holdings adjustments for the portfolio (optional)</param>
        /// <returns>ApiResponse of AdjustHolding</returns>
        public ApiResponse< AdjustHolding > SetHoldingsWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt, List<AdjustHoldingRequest> holdingAdjustments = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->SetHoldings");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->SetHoldings");
            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new ApiException(400, "Missing required parameter 'effectiveAt' when calling TransactionPortfoliosApi->SetHoldings");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/holdings/{effectiveAt}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (effectiveAt != null) localVarPathParams.Add("effectiveAt", this.Configuration.ApiClient.ParameterToString(effectiveAt)); // path parameter
            if (holdingAdjustments != null && holdingAdjustments.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(holdingAdjustments); // http body (model) parameter
            }
            else
            {
                localVarPostBody = holdingAdjustments; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SetHoldings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AdjustHolding>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (AdjustHolding) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdjustHolding)));
        }

        /// <summary>
        /// Set all holdings on a transaction portfolio Prompt the creation of transactions in a specific transaction portfolio to bring all holdings to the specified targets
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio</param>
        /// <param name="code">The code of the transaction portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <param name="holdingAdjustments">The complete set of holdings adjustments for the portfolio (optional)</param>
        /// <returns>Task of AdjustHolding</returns>
        public async System.Threading.Tasks.Task<AdjustHolding> SetHoldingsAsync (string scope, string code, DateTimeOffset? effectiveAt, List<AdjustHoldingRequest> holdingAdjustments = null)
        {
             ApiResponse<AdjustHolding> localVarResponse = await SetHoldingsAsyncWithHttpInfo(scope, code, effectiveAt, holdingAdjustments);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Set all holdings on a transaction portfolio Prompt the creation of transactions in a specific transaction portfolio to bring all holdings to the specified targets
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio</param>
        /// <param name="code">The code of the transaction portfolio</param>
        /// <param name="effectiveAt">The effective date of the change</param>
        /// <param name="holdingAdjustments">The complete set of holdings adjustments for the portfolio (optional)</param>
        /// <returns>Task of ApiResponse (AdjustHolding)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdjustHolding>> SetHoldingsAsyncWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt, List<AdjustHoldingRequest> holdingAdjustments = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->SetHoldings");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->SetHoldings");
            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new ApiException(400, "Missing required parameter 'effectiveAt' when calling TransactionPortfoliosApi->SetHoldings");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/holdings/{effectiveAt}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (effectiveAt != null) localVarPathParams.Add("effectiveAt", this.Configuration.ApiClient.ParameterToString(effectiveAt)); // path parameter
            if (holdingAdjustments != null && holdingAdjustments.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(holdingAdjustments); // http body (model) parameter
            }
            else
            {
                localVarPostBody = holdingAdjustments; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SetHoldings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AdjustHolding>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (AdjustHolding) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdjustHolding)));
        }

        /// <summary>
        /// Upsert executions Inserts new executions, or updates those already present
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="executions">The executions to be updated (optional)</param>
        /// <returns>UpsertPortfolioExecutionsResponse</returns>
        public UpsertPortfolioExecutionsResponse UpsertExecutions (string scope, string code, List<ExecutionRequest> executions = null)
        {
             ApiResponse<UpsertPortfolioExecutionsResponse> localVarResponse = UpsertExecutionsWithHttpInfo(scope, code, executions);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Upsert executions Inserts new executions, or updates those already present
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="executions">The executions to be updated (optional)</param>
        /// <returns>ApiResponse of UpsertPortfolioExecutionsResponse</returns>
        public ApiResponse< UpsertPortfolioExecutionsResponse > UpsertExecutionsWithHttpInfo (string scope, string code, List<ExecutionRequest> executions = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->UpsertExecutions");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->UpsertExecutions");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/executions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (executions != null && executions.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(executions); // http body (model) parameter
            }
            else
            {
                localVarPostBody = executions; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpsertExecutions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UpsertPortfolioExecutionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (UpsertPortfolioExecutionsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpsertPortfolioExecutionsResponse)));
        }

        /// <summary>
        /// Upsert executions Inserts new executions, or updates those already present
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="executions">The executions to be updated (optional)</param>
        /// <returns>Task of UpsertPortfolioExecutionsResponse</returns>
        public async System.Threading.Tasks.Task<UpsertPortfolioExecutionsResponse> UpsertExecutionsAsync (string scope, string code, List<ExecutionRequest> executions = null)
        {
             ApiResponse<UpsertPortfolioExecutionsResponse> localVarResponse = await UpsertExecutionsAsyncWithHttpInfo(scope, code, executions);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Upsert executions Inserts new executions, or updates those already present
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="executions">The executions to be updated (optional)</param>
        /// <returns>Task of ApiResponse (UpsertPortfolioExecutionsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UpsertPortfolioExecutionsResponse>> UpsertExecutionsAsyncWithHttpInfo (string scope, string code, List<ExecutionRequest> executions = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->UpsertExecutions");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->UpsertExecutions");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/executions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (executions != null && executions.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(executions); // http body (model) parameter
            }
            else
            {
                localVarPostBody = executions; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpsertExecutions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UpsertPortfolioExecutionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (UpsertPortfolioExecutionsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpsertPortfolioExecutionsResponse)));
        }

        /// <summary>
        /// Upsert details Update the portfolio details for the specified transaction portfolios or add if it doesn&#39;t already exist (in the case of a derived transaction portfolio).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="details">The set of details for the portfolio (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the change (optional)</param>
        /// <returns>PortfolioDetails</returns>
        public PortfolioDetails UpsertPortfolioDetails (string scope, string code, CreatePortfolioDetails details = null, DateTimeOffset? effectiveAt = null)
        {
             ApiResponse<PortfolioDetails> localVarResponse = UpsertPortfolioDetailsWithHttpInfo(scope, code, details, effectiveAt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Upsert details Update the portfolio details for the specified transaction portfolios or add if it doesn&#39;t already exist (in the case of a derived transaction portfolio).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="details">The set of details for the portfolio (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the change (optional)</param>
        /// <returns>ApiResponse of PortfolioDetails</returns>
        public ApiResponse< PortfolioDetails > UpsertPortfolioDetailsWithHttpInfo (string scope, string code, CreatePortfolioDetails details = null, DateTimeOffset? effectiveAt = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->UpsertPortfolioDetails");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->UpsertPortfolioDetails");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/details";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (effectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "effectiveAt", effectiveAt)); // query parameter
            if (details != null && details.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(details); // http body (model) parameter
            }
            else
            {
                localVarPostBody = details; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpsertPortfolioDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PortfolioDetails>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (PortfolioDetails) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortfolioDetails)));
        }

        /// <summary>
        /// Upsert details Update the portfolio details for the specified transaction portfolios or add if it doesn&#39;t already exist (in the case of a derived transaction portfolio).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="details">The set of details for the portfolio (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the change (optional)</param>
        /// <returns>Task of PortfolioDetails</returns>
        public async System.Threading.Tasks.Task<PortfolioDetails> UpsertPortfolioDetailsAsync (string scope, string code, CreatePortfolioDetails details = null, DateTimeOffset? effectiveAt = null)
        {
             ApiResponse<PortfolioDetails> localVarResponse = await UpsertPortfolioDetailsAsyncWithHttpInfo(scope, code, details, effectiveAt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Upsert details Update the portfolio details for the specified transaction portfolios or add if it doesn&#39;t already exist (in the case of a derived transaction portfolio).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="details">The set of details for the portfolio (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the change (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioDetails)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PortfolioDetails>> UpsertPortfolioDetailsAsyncWithHttpInfo (string scope, string code, CreatePortfolioDetails details = null, DateTimeOffset? effectiveAt = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->UpsertPortfolioDetails");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->UpsertPortfolioDetails");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/details";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (effectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "effectiveAt", effectiveAt)); // query parameter
            if (details != null && details.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(details); // http body (model) parameter
            }
            else
            {
                localVarPostBody = details; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpsertPortfolioDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PortfolioDetails>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (PortfolioDetails) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortfolioDetails)));
        }

        /// <summary>
        /// Upsert transactions into the specified transaction portfolio Upsert transactions
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code for the portfolio</param>
        /// <param name="transactions">The transactions to be upserted (optional)</param>
        /// <returns>UpsertPortfolioTransactionsResponse</returns>
        public UpsertPortfolioTransactionsResponse UpsertTransactions (string scope, string code, List<TransactionRequest> transactions = null)
        {
             ApiResponse<UpsertPortfolioTransactionsResponse> localVarResponse = UpsertTransactionsWithHttpInfo(scope, code, transactions);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Upsert transactions into the specified transaction portfolio Upsert transactions
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code for the portfolio</param>
        /// <param name="transactions">The transactions to be upserted (optional)</param>
        /// <returns>ApiResponse of UpsertPortfolioTransactionsResponse</returns>
        public ApiResponse< UpsertPortfolioTransactionsResponse > UpsertTransactionsWithHttpInfo (string scope, string code, List<TransactionRequest> transactions = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->UpsertTransactions");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->UpsertTransactions");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/transactions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (transactions != null && transactions.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(transactions); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transactions; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpsertTransactions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UpsertPortfolioTransactionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (UpsertPortfolioTransactionsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpsertPortfolioTransactionsResponse)));
        }

        /// <summary>
        /// Upsert transactions into the specified transaction portfolio Upsert transactions
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code for the portfolio</param>
        /// <param name="transactions">The transactions to be upserted (optional)</param>
        /// <returns>Task of UpsertPortfolioTransactionsResponse</returns>
        public async System.Threading.Tasks.Task<UpsertPortfolioTransactionsResponse> UpsertTransactionsAsync (string scope, string code, List<TransactionRequest> transactions = null)
        {
             ApiResponse<UpsertPortfolioTransactionsResponse> localVarResponse = await UpsertTransactionsAsyncWithHttpInfo(scope, code, transactions);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Upsert transactions into the specified transaction portfolio Upsert transactions
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code for the portfolio</param>
        /// <param name="transactions">The transactions to be upserted (optional)</param>
        /// <returns>Task of ApiResponse (UpsertPortfolioTransactionsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UpsertPortfolioTransactionsResponse>> UpsertTransactionsAsyncWithHttpInfo (string scope, string code, List<TransactionRequest> transactions = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->UpsertTransactions");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->UpsertTransactions");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/transactions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (transactions != null && transactions.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(transactions); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transactions; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpsertTransactions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UpsertPortfolioTransactionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (UpsertPortfolioTransactionsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpsertPortfolioTransactionsResponse)));
        }

    }
    
}