/* 
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://api.lusid.com/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages :  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python)  # Data Model  The LUSID API has a relatively lightweight but extremely powerful data model.   One of the goals of LUSID was not to enforce on clients a single rigid data model but rather to provide a flexible foundation onto which clients can streamline their data.   One of the primary tools to extend the data model is through using properties.  Properties can be associated with amongst others: - * Transactions * Instruments * Portfolios   The LUSID data model is exposed through the LUSID APIs.  The APIs provide access to both business objects and the meta data used to configure the systems behaviours.   The key business entities are: - * **Portfolios** A portfolio is the primary container for transactions and holdings.  * **Derived Portfolios** Derived portfolios allow portfolios to be created based on other portfolios, by overriding or overlaying specific items * **Holdings** A holding is a position account for a instrument within a portfolio.  Holdings can only be adjusted via transactions. * **Transactions** A Transaction is a source of transactions used to manipulate holdings.  * **Corporate Actions** A corporate action is a market event which occurs to a instrument, for example a stock split * **Instruments**  A instrument represents a currency, tradable instrument or OTC contract that is attached to a transaction and a holding. * **Properties** Several entities allow additional user defined properties to be associated with them.   For example, a Portfolio manager may be associated with a portfolio  Meta data includes: - * **Transaction Types** Transactions are booked with a specific transaction type.  The types are client defined and are used to map the Transaction to a series of movements which update the portfolio holdings.  * **Properties Types** Types of user defined properties used within the system.  This section describes the data model that LUSID exposes via the APIs.  ## Scope  All data in LUSID is segregated at the client level.  Entities in LUSID are identifiable by a unique code.  Every entity lives within a logical data partition known as a Scope.  Scope is an identity namespace allowing two entities with the same unique code to co-exist within individual address spaces.  For example, prices for equities from different vendors may be uploaded into different scopes such as `client/vendor1` and `client/vendor2`.  A portfolio may then be valued using either of the price sources by referencing the appropriate scope.  LUSID Clients cannot access scopes of other clients.  ## Schema  A detailed description of the entities used by the API and parameters for endpoints which take a JSON document can be retrieved via the `schema` endpoint.  ## Instruments  LUSID has its own built-in instrument master which you can use to master your own instrument universe.  Every instrument must be created with one or more unique market identifiers, such as [FIGI](https://openfigi.com/). For any non-listed instruments (eg OTCs), you can upload an instrument against a custom ID of your choosing.  In addition, LUSID will allocate each instrument a unique 'LUSID instrument identifier'. The LUSID instrument identifier is what is used when uploading transactions, holdings, prices, etc. The API exposes an `instrument/lookup` endpoint which can be used to lookup these LUSID identifiers using their market identifiers.  Cash can be referenced using the ISO currency code prefixed with \"`CCY_`\" e.g. `CCY_GBP`  ## Instrument Prices (Analytics)  Instrument prices are stored in LUSID's Analytics Store  | Field|Type|Description | | - --|- --|- -- | | InstrumentUid|string|Unique instrument identifier | | Value|decimal|Value of the analytic, eg price | | Denomination|string|Underlying unit of the analytic, eg currency, EPS etc. |   ## Instrument Data  Instrument data can be uploaded to the system using the [Instrument Properties](#tag/InstrumentProperties) endpoint.  | Field|Type|Description | | - --|- --|- -- |   ## Portfolios  Portfolios are the top-level entity containers within LUSID, containing transactions, corporate actions and holdings.    The transactions build up the portfolio holdings on which valuations, analytics profit & loss and risk can be calculated.     Properties can be associated with Portfolios to add in additional model data.  Portfolio properties can be changed over time as well.  For example, to allow a Portfolio Manager to be linked with a Portfolio.  Additionally, portfolios can be securitised and held by other portfolios, allowing LUSID to perform \"drill-through\" into underlying fund holdings  ### Reference Portfolios Reference portfolios are portfolios that contain only weights, as opposed to transactions, and are designed to represent entities such as indices.  ### Derived Portfolios  LUSID also allows for a portfolio to be composed of another portfolio via derived portfolios.  A derived portfolio can contain its own transactions and also inherits any transactions from its parent portfolio.  Any changes made to the parent portfolio are automatically reflected in derived portfolio.  Derived portfolios in conjunction with scopes are a powerful construct.  For example, to do pre-trade what-if analysis, a derived portfolio could be created a new namespace linked to the underlying live (parent) portfolio.  Analysis can then be undertaken on the derived portfolio without affecting the live portfolio.  ### Portfolio Groups Portfolio groups allow the construction of a hierarchy from portfolios and groups.  Portfolio operations on the group are executed on an aggregated set of portfolios in the hierarchy.   For example:   * Global Portfolios _(group)_   * APAC _(group)_     * Hong Kong _(portfolio)_     * Japan _(portfolio)_   * Europe _(group)_     * France _(portfolio)_     * Germany _(portfolio)_   * UK _(portfolio)_   In this example **Global Portfolios** is a group that consists of an aggregate of **Hong Kong**, **Japan**, **France**, **Germany** and **UK** portfolios.  ### Movements Engine The Movements engine sits on top of the immutable event store and is used to manage the relationship between input trading actions and their associated portfolio holdings.     The movements engine reads in the following entity types:- * Posting Transactions * Applying Corporate Actions  * Holding Adjustments  These are converted to one or more movements and used by the movements engine to calculate holdings.  At the same time it also calculates running balances, and realised P&L.  The outputs from the movements engine are holdings and transactions.  ## Transactions  A transaction represents an economic activity against a Portfolio.  Transactions are processed according to a configuration. This will tell the LUSID engine how to interpret the transaction and correctly update the holdings. LUSID comes with a set of transaction types you can use out of the box, or you can configure your own set(s) of transactions.  For more details see the [LUSID Getting Started Guide for transaction configuration.](https://support.finbourne.com/hc/en-us/articles/360016737511-Configuring-Transaction-Types)  | Field|Type|Description | | - --|- --|- -- | | TransactionId|string|Unique transaction identifier | | Type|string|LUSID transaction type code - Buy, Sell, StockIn, StockOut, etc | | InstrumentIdentifiers|IReadOnlyDictionary`2|Unique instrument identifiers. | | InstrumentUid|string|Unique instrument identifier | | TransactionDate|datetime|Transaction date | | SettlementDate|datetime|Settlement date | | Units|decimal|Quantity of transaction in units of the instrument | | TransactionPrice|tradeprice|Execution price for the transaction | | TotalConsideration|currencyandamount|Total value of the transaction in settlement currency | | ExchangeRate|decimal|Rate between transaction and settle currency | | TransactionCurrency|currency|Transaction currency | | CounterpartyId|string|Counterparty identifier | | Source|string|Where this transaction came from | | NettingSet|string|  |   From these fields, the following values can be calculated  * **Transaction value in Transaction currency**: TotalConsideration / ExchangeRate  * **Transaction value in Portfolio currency**: Transaction value in Transaction currency * TradeToPortfolioRate  ### Example Transactions  #### A Common Purchase Example Three example transactions are shown in the table below.   They represent a purchase of USD denominated IBM shares within a Sterling denominated portfolio.   * The first two transactions are for separate buy and fx trades    * Buying 500 IBM shares for $71,480.00    * A foreign exchange conversion to fund the IBM purchase. (Buy $71,480.00 for &#163;54,846.60)  * The third transaction is an alternate version of the above trades. Buying 500 IBM shares and settling directly in Sterling.  | Column |  Buy Trade | Fx Trade | Buy Trade with foreign Settlement | | - -- -- | - -- -- | - -- -- | - -- -- | | TransactionId | FBN00001 | FBN00002 | FBN00003 | | Type | Buy | FxBuy | Buy | | InstrumentUid | FIGI_BBG000BLNNH6 | CCY_USD | FIGI_BBG000BLNNH6 | | TransactionDate | 2018-08-02 | 2018-08-02 | 2018-08-02 | | SettlementDate | 2018-08-06 | 2018-08-06 | 2018-08-06 | | Units | 500 | 71480 | 500 | | TransactionPrice | 142.96 | 1 | 142.96 | | TradeCurrency | USD | USD | USD | | ExchangeRate | 1 | 0.7673 | 0.7673 | | TotalConsideration.Amount | 71480.00 | 54846.60 | 54846.60 | | TotalConsideration.Currency | USD | GBP | GBP | | Trade/default/TradeToPortfolioRate&ast; | 0.7673 | 0.7673 | 0.7673 |  [&ast; This is a property field]  #### A Forward FX Example  LUSID has a flexible transaction modelling system, and there are a number of different ways of modelling forward fx trades.  The default LUSID transaction types are FwdFxBuy and FwdFxSell. Other types and behaviours can be configured as required.  Using these transaction types, the holdings query will report two forward positions. One in each currency.   Since an FX trade is an exchange of one currency for another, the following two 6 month forward transactions are equivalent:  | Column |  Forward 'Sell' Trade | Forward 'Buy' Trade | | - -- -- | - -- -- | - -- -- | | TransactionId | FBN00004 | FBN00005 | | Type | FwdFxSell | FwdFxBuy | | InstrumentUid | CCY_GBP | CCY_USD | | TransactionDate | 2018-08-02 | 2018-08-02 | | SettlementDate | 2019-02-06 | 2019-02-06 | | Units | 10000.00 | 13142.00 | | TransactionPrice |1 | 1 | | TradeCurrency | GBP | USD | | ExchangeRate | 1.3142 | 0.760919 | | TotalConsideration.Amount | 13142.00 | 10000.00 | | TotalConsideration.Currency | USD | GBP | | Trade/default/TradeToPortfolioRate | 1.0 | 0.760919 |  ## Holdings  A holding represents a position in a instrument or cash on a given date.  | Field|Type|Description | | - --|- --|- -- | | InstrumentUid|string|Unique instrument identifier | | HoldingType|string|Type of holding, eg Position, Balance, CashCommitment, Receivable, ForwardFX | | Units|decimal|Quantity of holding | | SettledUnits|decimal|Settled quantity of holding | | Cost|currencyandamount|Book cost of holding in transaction currency | | CostPortfolioCcy|currencyandamount|Book cost of holding in portfolio currency | | Transaction|Transaction|If this is commitment-type holding, the transaction behind it |   ## Corporate Actions  Corporate actions are represented within LUSID in terms of a set of instrument-specific 'transitions'.  These transitions are used to specify the participants of the corporate action, and the effect that the corporate action will have on holdings in those participants.  *Corporate action*  | Field|Type|Description | | - --|- --|- -- | | SourceId|id|  | | CorporateActionCode|code|  | | AnnouncementDate|datetime|  | | ExDate|datetime|  | | RecordDate|datetime|  | | PaymentDate|datetime|  |    *Transition*  | Field|Type|Description | | - --|- --|- -- |   ## Property  Properties are key-value pairs that can be applied to any entity within a domain (where a domain is `trade`, `portfolio`, `security` etc).  Properties must be defined before use with a `PropertyDefinition` and can then subsequently be added to entities.  # Schemas  The following headers are returned on all responses from LUSID  | Name | Purpose | | - -- | - -- | | lusid-meta-duration | Duration of the request | | lusid-meta-success | Whether or not LUSID considered the request to be successful | | lusid-meta-requestId | The unique identifier for the request | | lusid-schema-url | Url of the schema for the data being returned | | lusid-property-schema-url | Url of the schema for any properties |   # Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"102\">102</a>|VersionNotFound|  | | <a name=\"104\">104</a>|InstrumentNotFound|  | | <a name=\"105\">105</a>|PropertyNotFound|  | | <a name=\"106\">106</a>|PortfolioRecursionDepth|  | | <a name=\"108\">108</a>|GroupNotFound|  | | <a name=\"109\">109</a>|PortfolioNotFound|  | | <a name=\"110\">110</a>|PropertySchemaNotFound|  | | <a name=\"111\">111</a>|PortfolioAncestryNotFound|  | | <a name=\"112\">112</a>|PortfolioWithIdAlreadyExists|  | | <a name=\"113\">113</a>|OrphanedPortfolio|  | | <a name=\"119\">119</a>|MissingBaseClaims|  | | <a name=\"121\">121</a>|PropertyNotDefined|  | | <a name=\"122\">122</a>|CannotDeleteSystemProperty|  | | <a name=\"123\">123</a>|CannotModifyImmutablePropertyField|  | | <a name=\"124\">124</a>|PropertyAlreadyExists|  | | <a name=\"125\">125</a>|InvalidPropertyLifeTime|  | | <a name=\"127\">127</a>|CannotModifyDefaultDataType|  | | <a name=\"128\">128</a>|GroupAlreadyExists|  | | <a name=\"129\">129</a>|NoSuchDataType|  | | <a name=\"132\">132</a>|ValidationError|  | | <a name=\"133\">133</a>|LoopDetectedInGroupHierarchy|  | | <a name=\"135\">135</a>|SubGroupAlreadyExists|  | | <a name=\"138\">138</a>|PriceSourceNotFound|  | | <a name=\"139\">139</a>|AnalyticStoreNotFound|  | | <a name=\"141\">141</a>|AnalyticStoreAlreadyExists|  | | <a name=\"143\">143</a>|ClientInstrumentAlreadyExists|  | | <a name=\"144\">144</a>|DuplicateInParameterSet|  | | <a name=\"147\">147</a>|ResultsNotFound|  | | <a name=\"148\">148</a>|OrderFieldNotInResultSet|  | | <a name=\"149\">149</a>|OperationFailed|  | | <a name=\"150\">150</a>|ElasticSearchError|  | | <a name=\"151\">151</a>|InvalidParameterValue|  | | <a name=\"153\">153</a>|CommandProcessingFailure|  | | <a name=\"154\">154</a>|EntityStateConstructionFailure|  | | <a name=\"155\">155</a>|EntityTimelineDoesNotExist|  | | <a name=\"156\">156</a>|EventPublishFailure|  | | <a name=\"157\">157</a>|InvalidRequestFailure|  | | <a name=\"158\">158</a>|EventPublishUnknown|  | | <a name=\"159\">159</a>|EventQueryFailure|  | | <a name=\"160\">160</a>|BlobDidNotExistFailure|  | | <a name=\"162\">162</a>|SubSystemRequestFailure|  | | <a name=\"163\">163</a>|SubSystemConfigurationFailure|  | | <a name=\"165\">165</a>|FailedToDelete|  | | <a name=\"166\">166</a>|UpsertClientInstrumentFailure|  | | <a name=\"167\">167</a>|IllegalAsAtInterval|  | | <a name=\"168\">168</a>|IllegalBitemporalQuery|  | | <a name=\"169\">169</a>|InvalidAlternateId|  | | <a name=\"170\">170</a>|CannotAddSourcePortfolioPropertyExplicitly|  | | <a name=\"171\">171</a>|EntityAlreadyExistsInGroup|  | | <a name=\"173\">173</a>|EntityWithIdAlreadyExists|  | | <a name=\"174\">174</a>|DerivedPortfolioDetailsDoNotExist|  | | <a name=\"176\">176</a>|PortfolioWithNameAlreadyExists|  | | <a name=\"177\">177</a>|InvalidTransactions|  | | <a name=\"178\">178</a>|ReferencePortfolioNotFound|  | | <a name=\"179\">179</a>|DuplicateIdFailure|  | | <a name=\"180\">180</a>|CommandRetrievalFailure|  | | <a name=\"181\">181</a>|DataFilterApplicationFailure|  | | <a name=\"182\">182</a>|SearchFailed|  | | <a name=\"183\">183</a>|MovementsEngineConfigurationKeyFailure|  | | <a name=\"184\">184</a>|FxRateSourceNotFound|  | | <a name=\"185\">185</a>|AccrualSourceNotFound|  | | <a name=\"186\">186</a>|AccessDenied|  | | <a name=\"187\">187</a>|InvalidIdentityToken|  | | <a name=\"188\">188</a>|InvalidRequestHeaders|  | | <a name=\"189\">189</a>|PriceNotFound|  | | <a name=\"190\">190</a>|InvalidSubHoldingKeysProvided|  | | <a name=\"191\">191</a>|DuplicateSubHoldingKeysProvided|  | | <a name=\"192\">192</a>|CutDefinitionNotFound|  | | <a name=\"193\">193</a>|CutDefinitionInvalid|  | | <a name=\"200\">200</a>|InvalidUnitForDataType|  | | <a name=\"201\">201</a>|InvalidTypeForDataType|  | | <a name=\"202\">202</a>|InvalidValueForDataType|  | | <a name=\"203\">203</a>|UnitNotDefinedForDataType|  | | <a name=\"204\">204</a>|UnitsNotSupportedOnDataType|  | | <a name=\"205\">205</a>|CannotSpecifyUnitsOnDataType|  | | <a name=\"206\">206</a>|UnitSchemaInconsistentWithDataType|  | | <a name=\"207\">207</a>|UnitDefinitionNotSpecified|  | | <a name=\"208\">208</a>|DuplicateUnitDefinitionsSpecified|  | | <a name=\"209\">209</a>|InvalidUnitsDefinition|  | | <a name=\"210\">210</a>|InvalidInstrumentIdentifierUnit|  | | <a name=\"211\">211</a>|HoldingsAdjustmentDoesNotExist|  | | <a name=\"212\">212</a>|CouldNotBuildExcelUrl|  | | <a name=\"213\">213</a>|CouldNotGetExcelVersion|  | | <a name=\"214\">214</a>|InstrumentByCodeNotFound|  | | <a name=\"215\">215</a>|EntitySchemaDoesNotExist|  | | <a name=\"216\">216</a>|FeatureNotSupportedOnPortfolioType|  | | <a name=\"217\">217</a>|QuoteNotFoundFailure|  | | <a name=\"219\">219</a>|InvalidInstrumentDefinition|  | | <a name=\"221\">221</a>|InstrumentUpsertFailure|  | | <a name=\"222\">222</a>|ReferencePortfolioRequestNotSupported|  | | <a name=\"223\">223</a>|TransactionPortfolioRequestNotSupported|  | | <a name=\"224\">224</a>|InvalidPropertyValueAssignment|  | | <a name=\"230\">230</a>|TransactionTypeNotFound|  | | <a name=\"231\">231</a>|TransactionTypeDuplication|  | | <a name=\"232\">232</a>|PortfolioDoesNotExistAtGivenDate|  | | <a name=\"233\">233</a>|QueryParserFailure|  | | <a name=\"234\">234</a>|DuplicateConstituentFailure|  | | <a name=\"235\">235</a>|UnresolvedInstrumentConstituentFailure|  | | <a name=\"236\">236</a>|UnresolvedInstrumentInTransitionFailure|  | | <a name=\"300\">300</a>|MissingRecipeFailure|  | | <a name=\"301\">301</a>|DependenciesFailure|  | | <a name=\"304\">304</a>|PortfolioPreprocessFailure|  | | <a name=\"310\">310</a>|ValuationEngineFailure|  | | <a name=\"311\">311</a>|TaskFactoryFailure|  | | <a name=\"312\">312</a>|TaskEvaluationFailure|  | | <a name=\"350\">350</a>|InstrumentFailure|  | | <a name=\"351\">351</a>|CashFlowsFailure|  | | <a name=\"360\">360</a>|AggregationFailure|  | | <a name=\"370\">370</a>|ResultRetrievalFailure|  | | <a name=\"371\">371</a>|ResultProcessingFailure|  | | <a name=\"371\">371</a>|ResultProcessingFailure|  | | <a name=\"372\">372</a>|VendorResultProcessingFailure|  | | <a name=\"374\">374</a>|AttemptToUpsertDuplicateQuotes|  | | <a name=\"375\">375</a>|CorporateActionSourceDoesNotExist|  | | <a name=\"376\">376</a>|InstrumentIdentifierAlreadyInUse|  | | <a name=\"-10\">-10</a>|ServerConfigurationError|  | | <a name=\"-1\">-1</a>|Unknown error|  | 
 *
 * OpenAPI spec version: 0.10.136
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
    public interface IPortfoliosApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete portfolio
        /// </summary>
        /// <remarks>
        /// Delete a portfolio at the specified effectiveAt
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the deletion (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeletePortfolio (string scope, string code, DateTimeOffset? effectiveAt = null);

        /// <summary>
        /// Delete portfolio
        /// </summary>
        /// <remarks>
        /// Delete a portfolio at the specified effectiveAt
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the deletion (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeletePortfolioWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = null);
        /// <summary>
        /// Delete portfolio properties
        /// </summary>
        /// <remarks>
        /// Delete one, many or all property values from a portfolio for the specified effectiveAt                Specifying no effectiveAt will delete all properties
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the deletion (optional)</param>
        /// <param name="portfolioPropertyKeys">Optional. The keys of the properties to be deleted. None specified indicates the intention to delete all properties from the portfolio (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeletePortfolioProperties (string scope, string code, DateTimeOffset? effectiveAt = null, List<string> portfolioPropertyKeys = null);

        /// <summary>
        /// Delete portfolio properties
        /// </summary>
        /// <remarks>
        /// Delete one, many or all property values from a portfolio for the specified effectiveAt                Specifying no effectiveAt will delete all properties
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the deletion (optional)</param>
        /// <param name="portfolioPropertyKeys">Optional. The keys of the properties to be deleted. None specified indicates the intention to delete all properties from the portfolio (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeletePortfolioPropertiesWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = null, List<string> portfolioPropertyKeys = null);
        /// <summary>
        /// Get portfolio definition
        /// </summary>
        /// <remarks>
        /// Retrieves the basic set of information about a portfolio using the specified scope and code.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>Portfolio</returns>
        Portfolio GetPortfolio (string scope, string code, string effectiveAt = null, DateTimeOffset? asAt = null);

        /// <summary>
        /// Get portfolio definition
        /// </summary>
        /// <remarks>
        /// Retrieves the basic set of information about a portfolio using the specified scope and code.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>ApiResponse of Portfolio</returns>
        ApiResponse<Portfolio> GetPortfolioWithHttpInfo (string scope, string code, string effectiveAt = null, DateTimeOffset? asAt = null);
        /// <summary>
        /// Get commands
        /// </summary>
        /// <remarks>
        /// Gets all commands that modified a specific portfolio, including any input transactions.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="fromAsAt">Optional. Filters commands by those that were processed at or after this date and time (optional)</param>
        /// <param name="toAsAt">Optional. Filters commands by those that were processed at or before this date and time (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>ResourceListOfProcessedCommand</returns>
        ResourceListOfProcessedCommand GetPortfolioCommands (string scope, string code, DateTimeOffset? fromAsAt = null, DateTimeOffset? toAsAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null);

        /// <summary>
        /// Get commands
        /// </summary>
        /// <remarks>
        /// Gets all commands that modified a specific portfolio, including any input transactions.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="fromAsAt">Optional. Filters commands by those that were processed at or after this date and time (optional)</param>
        /// <param name="toAsAt">Optional. Filters commands by those that were processed at or before this date and time (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>ApiResponse of ResourceListOfProcessedCommand</returns>
        ApiResponse<ResourceListOfProcessedCommand> GetPortfolioCommandsWithHttpInfo (string scope, string code, DateTimeOffset? fromAsAt = null, DateTimeOffset? toAsAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null);
        /// <summary>
        /// Get portfolio properties
        /// </summary>
        /// <remarks>
        /// Get the properties of a portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <returns>PortfolioProperties</returns>
        PortfolioProperties GetPortfolioProperties (string scope, string code, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null);

        /// <summary>
        /// Get portfolio properties
        /// </summary>
        /// <remarks>
        /// Get the properties of a portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <returns>ApiResponse of PortfolioProperties</returns>
        ApiResponse<PortfolioProperties> GetPortfolioPropertiesWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null);
        /// <summary>
        /// List portfolios
        /// </summary>
        /// <remarks>
        /// List all portfolios matching the specified criteria.                Example query syntax for the query parameter:                - To see which portfolios have holdings in the specified instruments:                    instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))                * Note that copy/pasting above examples results in incorrect single quote character
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="page">Optional. The pagination token to continue listing portfolios. This value is returned from a previous call to ListPortfolios.  If this is set, then the sortBy, filter, query, effectiveAt, and asAt fields must not have changed. Also, if set, a start  value cannot be set. (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="query">Optional. Expression specifying the criteria that the returned portfolios must meet (optional)</param>
        /// <returns>ResourceListOfPortfolio</returns>
        ResourceListOfPortfolio ListPortfolios (DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, string query = null);

        /// <summary>
        /// List portfolios
        /// </summary>
        /// <remarks>
        /// List all portfolios matching the specified criteria.                Example query syntax for the query parameter:                - To see which portfolios have holdings in the specified instruments:                    instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))                * Note that copy/pasting above examples results in incorrect single quote character
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="page">Optional. The pagination token to continue listing portfolios. This value is returned from a previous call to ListPortfolios.  If this is set, then the sortBy, filter, query, effectiveAt, and asAt fields must not have changed. Also, if set, a start  value cannot be set. (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="query">Optional. Expression specifying the criteria that the returned portfolios must meet (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPortfolio</returns>
        ApiResponse<ResourceListOfPortfolio> ListPortfoliosWithHttpInfo (DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, string query = null);
        /// <summary>
        /// List portfolios for scope
        /// </summary>
        /// <remarks>
        /// List all the portfolios in the specified scope
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>ResourceListOfPortfolio</returns>
        ResourceListOfPortfolio ListPortfoliosForScope (string scope, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null);

        /// <summary>
        /// List portfolios for scope
        /// </summary>
        /// <remarks>
        /// List all the portfolios in the specified scope
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPortfolio</returns>
        ApiResponse<ResourceListOfPortfolio> ListPortfoliosForScopeWithHttpInfo (string scope, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null);
        /// <summary>
        /// Update portfolio definition
        /// </summary>
        /// <remarks>
        /// Update the definition of a specific portfolio. Note, some parts of a portfolio definition are not available for modification after the initial creation.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="request">The updated portfolio definition (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date for the change (optional)</param>
        /// <returns>Portfolio</returns>
        Portfolio UpdatePortfolio (string scope, string code, UpdatePortfolioRequest request = null, DateTimeOffset? effectiveAt = null);

        /// <summary>
        /// Update portfolio definition
        /// </summary>
        /// <remarks>
        /// Update the definition of a specific portfolio. Note, some parts of a portfolio definition are not available for modification after the initial creation.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="request">The updated portfolio definition (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date for the change (optional)</param>
        /// <returns>ApiResponse of Portfolio</returns>
        ApiResponse<Portfolio> UpdatePortfolioWithHttpInfo (string scope, string code, UpdatePortfolioRequest request = null, DateTimeOffset? effectiveAt = null);
        /// <summary>
        /// Upsert portfolio properties
        /// </summary>
        /// <remarks>
        /// Upsert one or more property values to a portfolio. All properties must be of the domain Portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="portfolioProperties">The property values to be upserted to the portfolio. Time variant properties must have an EffectiveFrom date. (optional)</param>
        /// <returns>PortfolioProperties</returns>
        PortfolioProperties UpsertPortfolioProperties (string scope, string code, Object portfolioProperties = null);

        /// <summary>
        /// Upsert portfolio properties
        /// </summary>
        /// <remarks>
        /// Upsert one or more property values to a portfolio. All properties must be of the domain Portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="portfolioProperties">The property values to be upserted to the portfolio. Time variant properties must have an EffectiveFrom date. (optional)</param>
        /// <returns>ApiResponse of PortfolioProperties</returns>
        ApiResponse<PortfolioProperties> UpsertPortfolioPropertiesWithHttpInfo (string scope, string code, Object portfolioProperties = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete portfolio
        /// </summary>
        /// <remarks>
        /// Delete a portfolio at the specified effectiveAt
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the deletion (optional)</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeletePortfolioAsync (string scope, string code, DateTimeOffset? effectiveAt = null);

        /// <summary>
        /// Delete portfolio
        /// </summary>
        /// <remarks>
        /// Delete a portfolio at the specified effectiveAt
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the deletion (optional)</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeletePortfolioAsyncWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = null);
        /// <summary>
        /// Delete portfolio properties
        /// </summary>
        /// <remarks>
        /// Delete one, many or all property values from a portfolio for the specified effectiveAt                Specifying no effectiveAt will delete all properties
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the deletion (optional)</param>
        /// <param name="portfolioPropertyKeys">Optional. The keys of the properties to be deleted. None specified indicates the intention to delete all properties from the portfolio (optional)</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeletePortfolioPropertiesAsync (string scope, string code, DateTimeOffset? effectiveAt = null, List<string> portfolioPropertyKeys = null);

        /// <summary>
        /// Delete portfolio properties
        /// </summary>
        /// <remarks>
        /// Delete one, many or all property values from a portfolio for the specified effectiveAt                Specifying no effectiveAt will delete all properties
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the deletion (optional)</param>
        /// <param name="portfolioPropertyKeys">Optional. The keys of the properties to be deleted. None specified indicates the intention to delete all properties from the portfolio (optional)</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeletePortfolioPropertiesAsyncWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = null, List<string> portfolioPropertyKeys = null);
        /// <summary>
        /// Get portfolio definition
        /// </summary>
        /// <remarks>
        /// Retrieves the basic set of information about a portfolio using the specified scope and code.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>Task of Portfolio</returns>
        System.Threading.Tasks.Task<Portfolio> GetPortfolioAsync (string scope, string code, string effectiveAt = null, DateTimeOffset? asAt = null);

        /// <summary>
        /// Get portfolio definition
        /// </summary>
        /// <remarks>
        /// Retrieves the basic set of information about a portfolio using the specified scope and code.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>Task of ApiResponse (Portfolio)</returns>
        System.Threading.Tasks.Task<ApiResponse<Portfolio>> GetPortfolioAsyncWithHttpInfo (string scope, string code, string effectiveAt = null, DateTimeOffset? asAt = null);
        /// <summary>
        /// Get commands
        /// </summary>
        /// <remarks>
        /// Gets all commands that modified a specific portfolio, including any input transactions.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="fromAsAt">Optional. Filters commands by those that were processed at or after this date and time (optional)</param>
        /// <param name="toAsAt">Optional. Filters commands by those that were processed at or before this date and time (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>Task of ResourceListOfProcessedCommand</returns>
        System.Threading.Tasks.Task<ResourceListOfProcessedCommand> GetPortfolioCommandsAsync (string scope, string code, DateTimeOffset? fromAsAt = null, DateTimeOffset? toAsAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null);

        /// <summary>
        /// Get commands
        /// </summary>
        /// <remarks>
        /// Gets all commands that modified a specific portfolio, including any input transactions.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="fromAsAt">Optional. Filters commands by those that were processed at or after this date and time (optional)</param>
        /// <param name="toAsAt">Optional. Filters commands by those that were processed at or before this date and time (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfProcessedCommand)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfProcessedCommand>> GetPortfolioCommandsAsyncWithHttpInfo (string scope, string code, DateTimeOffset? fromAsAt = null, DateTimeOffset? toAsAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null);
        /// <summary>
        /// Get portfolio properties
        /// </summary>
        /// <remarks>
        /// Get the properties of a portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <returns>Task of PortfolioProperties</returns>
        System.Threading.Tasks.Task<PortfolioProperties> GetPortfolioPropertiesAsync (string scope, string code, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null);

        /// <summary>
        /// Get portfolio properties
        /// </summary>
        /// <remarks>
        /// Get the properties of a portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioProperties)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioProperties>> GetPortfolioPropertiesAsyncWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null);
        /// <summary>
        /// List portfolios
        /// </summary>
        /// <remarks>
        /// List all portfolios matching the specified criteria.                Example query syntax for the query parameter:                - To see which portfolios have holdings in the specified instruments:                    instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))                * Note that copy/pasting above examples results in incorrect single quote character
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="page">Optional. The pagination token to continue listing portfolios. This value is returned from a previous call to ListPortfolios.  If this is set, then the sortBy, filter, query, effectiveAt, and asAt fields must not have changed. Also, if set, a start  value cannot be set. (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="query">Optional. Expression specifying the criteria that the returned portfolios must meet (optional)</param>
        /// <returns>Task of ResourceListOfPortfolio</returns>
        System.Threading.Tasks.Task<ResourceListOfPortfolio> ListPortfoliosAsync (DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, string query = null);

        /// <summary>
        /// List portfolios
        /// </summary>
        /// <remarks>
        /// List all portfolios matching the specified criteria.                Example query syntax for the query parameter:                - To see which portfolios have holdings in the specified instruments:                    instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))                * Note that copy/pasting above examples results in incorrect single quote character
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="page">Optional. The pagination token to continue listing portfolios. This value is returned from a previous call to ListPortfolios.  If this is set, then the sortBy, filter, query, effectiveAt, and asAt fields must not have changed. Also, if set, a start  value cannot be set. (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="query">Optional. Expression specifying the criteria that the returned portfolios must meet (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfPortfolio)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfPortfolio>> ListPortfoliosAsyncWithHttpInfo (DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, string query = null);
        /// <summary>
        /// List portfolios for scope
        /// </summary>
        /// <remarks>
        /// List all the portfolios in the specified scope
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>Task of ResourceListOfPortfolio</returns>
        System.Threading.Tasks.Task<ResourceListOfPortfolio> ListPortfoliosForScopeAsync (string scope, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null);

        /// <summary>
        /// List portfolios for scope
        /// </summary>
        /// <remarks>
        /// List all the portfolios in the specified scope
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfPortfolio)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfPortfolio>> ListPortfoliosForScopeAsyncWithHttpInfo (string scope, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null);
        /// <summary>
        /// Update portfolio definition
        /// </summary>
        /// <remarks>
        /// Update the definition of a specific portfolio. Note, some parts of a portfolio definition are not available for modification after the initial creation.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="request">The updated portfolio definition (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date for the change (optional)</param>
        /// <returns>Task of Portfolio</returns>
        System.Threading.Tasks.Task<Portfolio> UpdatePortfolioAsync (string scope, string code, UpdatePortfolioRequest request = null, DateTimeOffset? effectiveAt = null);

        /// <summary>
        /// Update portfolio definition
        /// </summary>
        /// <remarks>
        /// Update the definition of a specific portfolio. Note, some parts of a portfolio definition are not available for modification after the initial creation.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="request">The updated portfolio definition (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date for the change (optional)</param>
        /// <returns>Task of ApiResponse (Portfolio)</returns>
        System.Threading.Tasks.Task<ApiResponse<Portfolio>> UpdatePortfolioAsyncWithHttpInfo (string scope, string code, UpdatePortfolioRequest request = null, DateTimeOffset? effectiveAt = null);
        /// <summary>
        /// Upsert portfolio properties
        /// </summary>
        /// <remarks>
        /// Upsert one or more property values to a portfolio. All properties must be of the domain Portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="portfolioProperties">The property values to be upserted to the portfolio. Time variant properties must have an EffectiveFrom date. (optional)</param>
        /// <returns>Task of PortfolioProperties</returns>
        System.Threading.Tasks.Task<PortfolioProperties> UpsertPortfolioPropertiesAsync (string scope, string code, Object portfolioProperties = null);

        /// <summary>
        /// Upsert portfolio properties
        /// </summary>
        /// <remarks>
        /// Upsert one or more property values to a portfolio. All properties must be of the domain Portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="portfolioProperties">The property values to be upserted to the portfolio. Time variant properties must have an EffectiveFrom date. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioProperties)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioProperties>> UpsertPortfolioPropertiesAsyncWithHttpInfo (string scope, string code, Object portfolioProperties = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PortfoliosApi : IPortfoliosApi
    {
        private Lusid.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PortfoliosApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PortfoliosApi(String basePath)
        {
            this.Configuration = new Lusid.Sdk.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortfoliosApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PortfoliosApi(Lusid.Sdk.Client.Configuration configuration = null)
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
        /// Delete portfolio Delete a portfolio at the specified effectiveAt
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the deletion (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeletePortfolio (string scope, string code, DateTimeOffset? effectiveAt = null)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = DeletePortfolioWithHttpInfo(scope, code, effectiveAt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete portfolio Delete a portfolio at the specified effectiveAt
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the deletion (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public ApiResponse< DeletedEntityResponse > DeletePortfolioWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->DeletePortfolio");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->DeletePortfolio");

            var localVarPath = "./api/portfolios/{scope}/{code}";
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
                Exception exception = ExceptionFactory("DeletePortfolio", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeletedEntityResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

        /// <summary>
        /// Delete portfolio Delete a portfolio at the specified effectiveAt
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the deletion (optional)</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeletePortfolioAsync (string scope, string code, DateTimeOffset? effectiveAt = null)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = await DeletePortfolioAsyncWithHttpInfo(scope, code, effectiveAt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete portfolio Delete a portfolio at the specified effectiveAt
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the deletion (optional)</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeletePortfolioAsyncWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->DeletePortfolio");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->DeletePortfolio");

            var localVarPath = "./api/portfolios/{scope}/{code}";
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
                Exception exception = ExceptionFactory("DeletePortfolio", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeletedEntityResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

        /// <summary>
        /// Delete portfolio properties Delete one, many or all property values from a portfolio for the specified effectiveAt                Specifying no effectiveAt will delete all properties
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the deletion (optional)</param>
        /// <param name="portfolioPropertyKeys">Optional. The keys of the properties to be deleted. None specified indicates the intention to delete all properties from the portfolio (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeletePortfolioProperties (string scope, string code, DateTimeOffset? effectiveAt = null, List<string> portfolioPropertyKeys = null)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = DeletePortfolioPropertiesWithHttpInfo(scope, code, effectiveAt, portfolioPropertyKeys);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete portfolio properties Delete one, many or all property values from a portfolio for the specified effectiveAt                Specifying no effectiveAt will delete all properties
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the deletion (optional)</param>
        /// <param name="portfolioPropertyKeys">Optional. The keys of the properties to be deleted. None specified indicates the intention to delete all properties from the portfolio (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public ApiResponse< DeletedEntityResponse > DeletePortfolioPropertiesWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = null, List<string> portfolioPropertyKeys = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->DeletePortfolioProperties");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->DeletePortfolioProperties");

            var localVarPath = "./api/portfolios/{scope}/{code}/properties";
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
            if (portfolioPropertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "portfolioPropertyKeys", portfolioPropertyKeys)); // query parameter

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
                Exception exception = ExceptionFactory("DeletePortfolioProperties", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeletedEntityResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

        /// <summary>
        /// Delete portfolio properties Delete one, many or all property values from a portfolio for the specified effectiveAt                Specifying no effectiveAt will delete all properties
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the deletion (optional)</param>
        /// <param name="portfolioPropertyKeys">Optional. The keys of the properties to be deleted. None specified indicates the intention to delete all properties from the portfolio (optional)</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeletePortfolioPropertiesAsync (string scope, string code, DateTimeOffset? effectiveAt = null, List<string> portfolioPropertyKeys = null)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = await DeletePortfolioPropertiesAsyncWithHttpInfo(scope, code, effectiveAt, portfolioPropertyKeys);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete portfolio properties Delete one, many or all property values from a portfolio for the specified effectiveAt                Specifying no effectiveAt will delete all properties
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">Code for the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the deletion (optional)</param>
        /// <param name="portfolioPropertyKeys">Optional. The keys of the properties to be deleted. None specified indicates the intention to delete all properties from the portfolio (optional)</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeletePortfolioPropertiesAsyncWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = null, List<string> portfolioPropertyKeys = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->DeletePortfolioProperties");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->DeletePortfolioProperties");

            var localVarPath = "./api/portfolios/{scope}/{code}/properties";
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
            if (portfolioPropertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "portfolioPropertyKeys", portfolioPropertyKeys)); // query parameter

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
                Exception exception = ExceptionFactory("DeletePortfolioProperties", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeletedEntityResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

        /// <summary>
        /// Get portfolio definition Retrieves the basic set of information about a portfolio using the specified scope and code.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>Portfolio</returns>
        public Portfolio GetPortfolio (string scope, string code, string effectiveAt = null, DateTimeOffset? asAt = null)
        {
             ApiResponse<Portfolio> localVarResponse = GetPortfolioWithHttpInfo(scope, code, effectiveAt, asAt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get portfolio definition Retrieves the basic set of information about a portfolio using the specified scope and code.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>ApiResponse of Portfolio</returns>
        public ApiResponse< Portfolio > GetPortfolioWithHttpInfo (string scope, string code, string effectiveAt = null, DateTimeOffset? asAt = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->GetPortfolio");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->GetPortfolio");

            var localVarPath = "./api/portfolios/{scope}/{code}";
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
                Exception exception = ExceptionFactory("GetPortfolio", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Portfolio>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (Portfolio) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Portfolio)));
        }

        /// <summary>
        /// Get portfolio definition Retrieves the basic set of information about a portfolio using the specified scope and code.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>Task of Portfolio</returns>
        public async System.Threading.Tasks.Task<Portfolio> GetPortfolioAsync (string scope, string code, string effectiveAt = null, DateTimeOffset? asAt = null)
        {
             ApiResponse<Portfolio> localVarResponse = await GetPortfolioAsyncWithHttpInfo(scope, code, effectiveAt, asAt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get portfolio definition Retrieves the basic set of information about a portfolio using the specified scope and code.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <returns>Task of ApiResponse (Portfolio)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Portfolio>> GetPortfolioAsyncWithHttpInfo (string scope, string code, string effectiveAt = null, DateTimeOffset? asAt = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->GetPortfolio");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->GetPortfolio");

            var localVarPath = "./api/portfolios/{scope}/{code}";
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
                Exception exception = ExceptionFactory("GetPortfolio", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Portfolio>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (Portfolio) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Portfolio)));
        }

        /// <summary>
        /// Get commands Gets all commands that modified a specific portfolio, including any input transactions.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="fromAsAt">Optional. Filters commands by those that were processed at or after this date and time (optional)</param>
        /// <param name="toAsAt">Optional. Filters commands by those that were processed at or before this date and time (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>ResourceListOfProcessedCommand</returns>
        public ResourceListOfProcessedCommand GetPortfolioCommands (string scope, string code, DateTimeOffset? fromAsAt = null, DateTimeOffset? toAsAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)
        {
             ApiResponse<ResourceListOfProcessedCommand> localVarResponse = GetPortfolioCommandsWithHttpInfo(scope, code, fromAsAt, toAsAt, sortBy, start, limit, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get commands Gets all commands that modified a specific portfolio, including any input transactions.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="fromAsAt">Optional. Filters commands by those that were processed at or after this date and time (optional)</param>
        /// <param name="toAsAt">Optional. Filters commands by those that were processed at or before this date and time (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>ApiResponse of ResourceListOfProcessedCommand</returns>
        public ApiResponse< ResourceListOfProcessedCommand > GetPortfolioCommandsWithHttpInfo (string scope, string code, DateTimeOffset? fromAsAt = null, DateTimeOffset? toAsAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->GetPortfolioCommands");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->GetPortfolioCommands");

            var localVarPath = "./api/portfolios/{scope}/{code}/commands";
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
            if (fromAsAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "fromAsAt", fromAsAt)); // query parameter
            if (toAsAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "toAsAt", toAsAt)); // query parameter
            if (sortBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "sortBy", sortBy)); // query parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
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
                Exception exception = ExceptionFactory("GetPortfolioCommands", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResourceListOfProcessedCommand>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (ResourceListOfProcessedCommand) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfProcessedCommand)));
        }

        /// <summary>
        /// Get commands Gets all commands that modified a specific portfolio, including any input transactions.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="fromAsAt">Optional. Filters commands by those that were processed at or after this date and time (optional)</param>
        /// <param name="toAsAt">Optional. Filters commands by those that were processed at or before this date and time (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>Task of ResourceListOfProcessedCommand</returns>
        public async System.Threading.Tasks.Task<ResourceListOfProcessedCommand> GetPortfolioCommandsAsync (string scope, string code, DateTimeOffset? fromAsAt = null, DateTimeOffset? toAsAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)
        {
             ApiResponse<ResourceListOfProcessedCommand> localVarResponse = await GetPortfolioCommandsAsyncWithHttpInfo(scope, code, fromAsAt, toAsAt, sortBy, start, limit, filter);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get commands Gets all commands that modified a specific portfolio, including any input transactions.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="fromAsAt">Optional. Filters commands by those that were processed at or after this date and time (optional)</param>
        /// <param name="toAsAt">Optional. Filters commands by those that were processed at or before this date and time (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfProcessedCommand)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResourceListOfProcessedCommand>> GetPortfolioCommandsAsyncWithHttpInfo (string scope, string code, DateTimeOffset? fromAsAt = null, DateTimeOffset? toAsAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->GetPortfolioCommands");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->GetPortfolioCommands");

            var localVarPath = "./api/portfolios/{scope}/{code}/commands";
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
            if (fromAsAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "fromAsAt", fromAsAt)); // query parameter
            if (toAsAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "toAsAt", toAsAt)); // query parameter
            if (sortBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "sortBy", sortBy)); // query parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
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
                Exception exception = ExceptionFactory("GetPortfolioCommands", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResourceListOfProcessedCommand>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (ResourceListOfProcessedCommand) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfProcessedCommand)));
        }

        /// <summary>
        /// Get portfolio properties Get the properties of a portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <returns>PortfolioProperties</returns>
        public PortfolioProperties GetPortfolioProperties (string scope, string code, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null)
        {
             ApiResponse<PortfolioProperties> localVarResponse = GetPortfolioPropertiesWithHttpInfo(scope, code, effectiveAt, asAt, sortBy, start, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get portfolio properties Get the properties of a portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <returns>ApiResponse of PortfolioProperties</returns>
        public ApiResponse< PortfolioProperties > GetPortfolioPropertiesWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->GetPortfolioProperties");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->GetPortfolioProperties");

            var localVarPath = "./api/portfolios/{scope}/{code}/properties";
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
            if (sortBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "sortBy", sortBy)); // query parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter

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
                Exception exception = ExceptionFactory("GetPortfolioProperties", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PortfolioProperties>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (PortfolioProperties) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortfolioProperties)));
        }

        /// <summary>
        /// Get portfolio properties Get the properties of a portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <returns>Task of PortfolioProperties</returns>
        public async System.Threading.Tasks.Task<PortfolioProperties> GetPortfolioPropertiesAsync (string scope, string code, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null)
        {
             ApiResponse<PortfolioProperties> localVarResponse = await GetPortfolioPropertiesAsyncWithHttpInfo(scope, code, effectiveAt, asAt, sortBy, start, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get portfolio properties Get the properties of a portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioProperties)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PortfolioProperties>> GetPortfolioPropertiesAsyncWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->GetPortfolioProperties");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->GetPortfolioProperties");

            var localVarPath = "./api/portfolios/{scope}/{code}/properties";
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
            if (sortBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "sortBy", sortBy)); // query parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter

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
                Exception exception = ExceptionFactory("GetPortfolioProperties", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PortfolioProperties>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (PortfolioProperties) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortfolioProperties)));
        }

        /// <summary>
        /// List portfolios List all portfolios matching the specified criteria.                Example query syntax for the query parameter:                - To see which portfolios have holdings in the specified instruments:                    instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))                * Note that copy/pasting above examples results in incorrect single quote character
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="page">Optional. The pagination token to continue listing portfolios. This value is returned from a previous call to ListPortfolios.  If this is set, then the sortBy, filter, query, effectiveAt, and asAt fields must not have changed. Also, if set, a start  value cannot be set. (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="query">Optional. Expression specifying the criteria that the returned portfolios must meet (optional)</param>
        /// <returns>ResourceListOfPortfolio</returns>
        public ResourceListOfPortfolio ListPortfolios (DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, string query = null)
        {
             ApiResponse<ResourceListOfPortfolio> localVarResponse = ListPortfoliosWithHttpInfo(effectiveAt, asAt, page, sortBy, start, limit, filter, query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List portfolios List all portfolios matching the specified criteria.                Example query syntax for the query parameter:                - To see which portfolios have holdings in the specified instruments:                    instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))                * Note that copy/pasting above examples results in incorrect single quote character
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="page">Optional. The pagination token to continue listing portfolios. This value is returned from a previous call to ListPortfolios.  If this is set, then the sortBy, filter, query, effectiveAt, and asAt fields must not have changed. Also, if set, a start  value cannot be set. (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="query">Optional. Expression specifying the criteria that the returned portfolios must meet (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPortfolio</returns>
        public ApiResponse< ResourceListOfPortfolio > ListPortfoliosWithHttpInfo (DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, string query = null)
        {

            var localVarPath = "./api/portfolios";
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

            if (effectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "effectiveAt", effectiveAt)); // query parameter
            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (sortBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "sortBy", sortBy)); // query parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (query != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "query", query)); // query parameter

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
                Exception exception = ExceptionFactory("ListPortfolios", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResourceListOfPortfolio>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (ResourceListOfPortfolio) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfPortfolio)));
        }

        /// <summary>
        /// List portfolios List all portfolios matching the specified criteria.                Example query syntax for the query parameter:                - To see which portfolios have holdings in the specified instruments:                    instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))                * Note that copy/pasting above examples results in incorrect single quote character
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="page">Optional. The pagination token to continue listing portfolios. This value is returned from a previous call to ListPortfolios.  If this is set, then the sortBy, filter, query, effectiveAt, and asAt fields must not have changed. Also, if set, a start  value cannot be set. (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="query">Optional. Expression specifying the criteria that the returned portfolios must meet (optional)</param>
        /// <returns>Task of ResourceListOfPortfolio</returns>
        public async System.Threading.Tasks.Task<ResourceListOfPortfolio> ListPortfoliosAsync (DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, string query = null)
        {
             ApiResponse<ResourceListOfPortfolio> localVarResponse = await ListPortfoliosAsyncWithHttpInfo(effectiveAt, asAt, page, sortBy, start, limit, filter, query);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List portfolios List all portfolios matching the specified criteria.                Example query syntax for the query parameter:                - To see which portfolios have holdings in the specified instruments:                    instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))                * Note that copy/pasting above examples results in incorrect single quote character
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="page">Optional. The pagination token to continue listing portfolios. This value is returned from a previous call to ListPortfolios.  If this is set, then the sortBy, filter, query, effectiveAt, and asAt fields must not have changed. Also, if set, a start  value cannot be set. (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <param name="query">Optional. Expression specifying the criteria that the returned portfolios must meet (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfPortfolio)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResourceListOfPortfolio>> ListPortfoliosAsyncWithHttpInfo (DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, string query = null)
        {

            var localVarPath = "./api/portfolios";
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

            if (effectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "effectiveAt", effectiveAt)); // query parameter
            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (sortBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "sortBy", sortBy)); // query parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (query != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "query", query)); // query parameter

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
                Exception exception = ExceptionFactory("ListPortfolios", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResourceListOfPortfolio>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (ResourceListOfPortfolio) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfPortfolio)));
        }

        /// <summary>
        /// List portfolios for scope List all the portfolios in the specified scope
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>ResourceListOfPortfolio</returns>
        public ResourceListOfPortfolio ListPortfoliosForScope (string scope, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)
        {
             ApiResponse<ResourceListOfPortfolio> localVarResponse = ListPortfoliosForScopeWithHttpInfo(scope, effectiveAt, asAt, sortBy, start, limit, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List portfolios for scope List all the portfolios in the specified scope
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPortfolio</returns>
        public ApiResponse< ResourceListOfPortfolio > ListPortfoliosForScopeWithHttpInfo (string scope, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->ListPortfoliosForScope");

            var localVarPath = "./api/portfolios/{scope}";
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
            if (effectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "effectiveAt", effectiveAt)); // query parameter
            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter
            if (sortBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "sortBy", sortBy)); // query parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
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
                Exception exception = ExceptionFactory("ListPortfoliosForScope", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResourceListOfPortfolio>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (ResourceListOfPortfolio) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfPortfolio)));
        }

        /// <summary>
        /// List portfolios for scope List all the portfolios in the specified scope
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>Task of ResourceListOfPortfolio</returns>
        public async System.Threading.Tasks.Task<ResourceListOfPortfolio> ListPortfoliosForScopeAsync (string scope, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)
        {
             ApiResponse<ResourceListOfPortfolio> localVarResponse = await ListPortfoliosForScopeAsyncWithHttpInfo(scope, effectiveAt, asAt, sortBy, start, limit, filter);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List portfolios for scope List all the portfolios in the specified scope
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope</param>
        /// <param name="effectiveAt">Optional. The effective date of the data (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the data (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfPortfolio)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResourceListOfPortfolio>> ListPortfoliosForScopeAsyncWithHttpInfo (string scope, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->ListPortfoliosForScope");

            var localVarPath = "./api/portfolios/{scope}";
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
            if (effectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "effectiveAt", effectiveAt)); // query parameter
            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter
            if (sortBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "sortBy", sortBy)); // query parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
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
                Exception exception = ExceptionFactory("ListPortfoliosForScope", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResourceListOfPortfolio>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (ResourceListOfPortfolio) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfPortfolio)));
        }

        /// <summary>
        /// Update portfolio definition Update the definition of a specific portfolio. Note, some parts of a portfolio definition are not available for modification after the initial creation.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="request">The updated portfolio definition (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date for the change (optional)</param>
        /// <returns>Portfolio</returns>
        public Portfolio UpdatePortfolio (string scope, string code, UpdatePortfolioRequest request = null, DateTimeOffset? effectiveAt = null)
        {
             ApiResponse<Portfolio> localVarResponse = UpdatePortfolioWithHttpInfo(scope, code, request, effectiveAt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update portfolio definition Update the definition of a specific portfolio. Note, some parts of a portfolio definition are not available for modification after the initial creation.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="request">The updated portfolio definition (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date for the change (optional)</param>
        /// <returns>ApiResponse of Portfolio</returns>
        public ApiResponse< Portfolio > UpdatePortfolioWithHttpInfo (string scope, string code, UpdatePortfolioRequest request = null, DateTimeOffset? effectiveAt = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->UpdatePortfolio");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->UpdatePortfolio");

            var localVarPath = "./api/portfolios/{scope}/{code}";
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
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
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
                Exception exception = ExceptionFactory("UpdatePortfolio", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Portfolio>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (Portfolio) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Portfolio)));
        }

        /// <summary>
        /// Update portfolio definition Update the definition of a specific portfolio. Note, some parts of a portfolio definition are not available for modification after the initial creation.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="request">The updated portfolio definition (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date for the change (optional)</param>
        /// <returns>Task of Portfolio</returns>
        public async System.Threading.Tasks.Task<Portfolio> UpdatePortfolioAsync (string scope, string code, UpdatePortfolioRequest request = null, DateTimeOffset? effectiveAt = null)
        {
             ApiResponse<Portfolio> localVarResponse = await UpdatePortfolioAsyncWithHttpInfo(scope, code, request, effectiveAt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update portfolio definition Update the definition of a specific portfolio. Note, some parts of a portfolio definition are not available for modification after the initial creation.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="request">The updated portfolio definition (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date for the change (optional)</param>
        /// <returns>Task of ApiResponse (Portfolio)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Portfolio>> UpdatePortfolioAsyncWithHttpInfo (string scope, string code, UpdatePortfolioRequest request = null, DateTimeOffset? effectiveAt = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->UpdatePortfolio");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->UpdatePortfolio");

            var localVarPath = "./api/portfolios/{scope}/{code}";
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
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
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
                Exception exception = ExceptionFactory("UpdatePortfolio", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Portfolio>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (Portfolio) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Portfolio)));
        }

        /// <summary>
        /// Upsert portfolio properties Upsert one or more property values to a portfolio. All properties must be of the domain Portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="portfolioProperties">The property values to be upserted to the portfolio. Time variant properties must have an EffectiveFrom date. (optional)</param>
        /// <returns>PortfolioProperties</returns>
        public PortfolioProperties UpsertPortfolioProperties (string scope, string code, Object portfolioProperties = null)
        {
             ApiResponse<PortfolioProperties> localVarResponse = UpsertPortfolioPropertiesWithHttpInfo(scope, code, portfolioProperties);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Upsert portfolio properties Upsert one or more property values to a portfolio. All properties must be of the domain Portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="portfolioProperties">The property values to be upserted to the portfolio. Time variant properties must have an EffectiveFrom date. (optional)</param>
        /// <returns>ApiResponse of PortfolioProperties</returns>
        public ApiResponse< PortfolioProperties > UpsertPortfolioPropertiesWithHttpInfo (string scope, string code, Object portfolioProperties = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->UpsertPortfolioProperties");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->UpsertPortfolioProperties");

            var localVarPath = "./api/portfolios/{scope}/{code}/properties";
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
            if (portfolioProperties != null && portfolioProperties.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(portfolioProperties); // http body (model) parameter
            }
            else
            {
                localVarPostBody = portfolioProperties; // byte array
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
                Exception exception = ExceptionFactory("UpsertPortfolioProperties", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PortfolioProperties>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (PortfolioProperties) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortfolioProperties)));
        }

        /// <summary>
        /// Upsert portfolio properties Upsert one or more property values to a portfolio. All properties must be of the domain Portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="portfolioProperties">The property values to be upserted to the portfolio. Time variant properties must have an EffectiveFrom date. (optional)</param>
        /// <returns>Task of PortfolioProperties</returns>
        public async System.Threading.Tasks.Task<PortfolioProperties> UpsertPortfolioPropertiesAsync (string scope, string code, Object portfolioProperties = null)
        {
             ApiResponse<PortfolioProperties> localVarResponse = await UpsertPortfolioPropertiesAsyncWithHttpInfo(scope, code, portfolioProperties);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Upsert portfolio properties Upsert one or more property values to a portfolio. All properties must be of the domain Portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="portfolioProperties">The property values to be upserted to the portfolio. Time variant properties must have an EffectiveFrom date. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioProperties)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PortfolioProperties>> UpsertPortfolioPropertiesAsyncWithHttpInfo (string scope, string code, Object portfolioProperties = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->UpsertPortfolioProperties");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->UpsertPortfolioProperties");

            var localVarPath = "./api/portfolios/{scope}/{code}/properties";
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
            if (portfolioProperties != null && portfolioProperties.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(portfolioProperties); // http body (model) parameter
            }
            else
            {
                localVarPostBody = portfolioProperties; // byte array
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
                Exception exception = ExceptionFactory("UpsertPortfolioProperties", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PortfolioProperties>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (PortfolioProperties) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortfolioProperties)));
        }

    }
    
}