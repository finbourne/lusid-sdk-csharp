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
    public interface IInstrumentsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete instrument
        /// </summary>
        /// <remarks>
        /// Attempt to delete one or more \&quot;client\&quot; instruments.    The response will include those instruments that could not be deleted (as well as any available details).                It is important to always check the &#39;Failed&#39; set for any unsuccessful results.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The instrument identifier</param>
        /// <returns>DeleteInstrumentResponse</returns>
        DeleteInstrumentResponse DeleteInstrument (string identifierType, string identifier);

        /// <summary>
        /// Delete instrument
        /// </summary>
        /// <remarks>
        /// Attempt to delete one or more \&quot;client\&quot; instruments.    The response will include those instruments that could not be deleted (as well as any available details).                It is important to always check the &#39;Failed&#39; set for any unsuccessful results.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The instrument identifier</param>
        /// <returns>ApiResponse of DeleteInstrumentResponse</returns>
        ApiResponse<DeleteInstrumentResponse> DeleteInstrumentWithHttpInfo (string identifierType, string identifier);
        /// <summary>
        /// Get instrument definition
        /// </summary>
        /// <remarks>
        /// Get an individual instrument by the one of its unique instrument identifiers. Optionally, it is possible to decorate each instrument with specified property data.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The identifier of the requested instrument</param>
        /// <param name="effectiveAt">Optional. The effective date of the query (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the query (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>Instrument</returns>
        Instrument GetInstrument (string identifierType, string identifier, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null);

        /// <summary>
        /// Get instrument definition
        /// </summary>
        /// <remarks>
        /// Get an individual instrument by the one of its unique instrument identifiers. Optionally, it is possible to decorate each instrument with specified property data.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The identifier of the requested instrument</param>
        /// <param name="effectiveAt">Optional. The effective date of the query (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the query (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>ApiResponse of Instrument</returns>
        ApiResponse<Instrument> GetInstrumentWithHttpInfo (string identifierType, string identifier, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null);
        /// <summary>
        /// Get allowable instrument identifiers
        /// </summary>
        /// <remarks>
        /// Returns a collection of instrument identifier type descriptors. Each descriptor specifies the properties  of a particular instrument identifier - its name, its cardinality (whether or not multiple instruments can  share the same identifier value), and its corresponding PropertyKey.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ResourceListOfInstrumentIdTypeDescriptor</returns>
        ResourceListOfInstrumentIdTypeDescriptor GetInstrumentIdentifiers ();

        /// <summary>
        /// Get allowable instrument identifiers
        /// </summary>
        /// <remarks>
        /// Returns a collection of instrument identifier type descriptors. Each descriptor specifies the properties  of a particular instrument identifier - its name, its cardinality (whether or not multiple instruments can  share the same identifier value), and its corresponding PropertyKey.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ResourceListOfInstrumentIdTypeDescriptor</returns>
        ApiResponse<ResourceListOfInstrumentIdTypeDescriptor> GetInstrumentIdentifiersWithHttpInfo ();
        /// <summary>
        /// Get instrument definition
        /// </summary>
        /// <remarks>
        /// Get a collection of instruments by a set of identifiers. Optionally, it is possible to decorate each instrument with specified property data.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifiers being supplied</param>
        /// <param name="identifiers">The identifiers of the instruments to get</param>
        /// <param name="effectiveAt">Optional. The effective date of the request (optional)</param>
        /// <param name="asAt">Optional. The as at date of the request (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>GetInstrumentsResponse</returns>
        GetInstrumentsResponse GetInstruments (string identifierType, List<string> identifiers, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null);

        /// <summary>
        /// Get instrument definition
        /// </summary>
        /// <remarks>
        /// Get a collection of instruments by a set of identifiers. Optionally, it is possible to decorate each instrument with specified property data.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifiers being supplied</param>
        /// <param name="identifiers">The identifiers of the instruments to get</param>
        /// <param name="effectiveAt">Optional. The effective date of the request (optional)</param>
        /// <param name="asAt">Optional. The as at date of the request (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>ApiResponse of GetInstrumentsResponse</returns>
        ApiResponse<GetInstrumentsResponse> GetInstrumentsWithHttpInfo (string identifierType, List<string> identifiers, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null);
        /// <summary>
        /// Get all of the currently mastered instruments in LUSID
        /// </summary>
        /// <remarks>
        /// Lists all instruments that have been mastered within LUSID.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">Optional. The AsAt time (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the query (optional)</param>
        /// <param name="page">Optional. The pagination token to continue listing instruments. This value is returned from a previous call to ListInstruments.  If this is set, then the sortBy, filter, effectiveAt, and asAt fields must not have changed. Also, if set, a start value cannot be set. (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set - the default filter returns only instruments in the Active state (optional, default to State eq &#39;Active&#39;)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>ResourceListOfInstrument</returns>
        ResourceListOfInstrument ListInstruments (DateTimeOffset? asAt = null, DateTimeOffset? effectiveAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null);

        /// <summary>
        /// Get all of the currently mastered instruments in LUSID
        /// </summary>
        /// <remarks>
        /// Lists all instruments that have been mastered within LUSID.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">Optional. The AsAt time (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the query (optional)</param>
        /// <param name="page">Optional. The pagination token to continue listing instruments. This value is returned from a previous call to ListInstruments.  If this is set, then the sortBy, filter, effectiveAt, and asAt fields must not have changed. Also, if set, a start value cannot be set. (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set - the default filter returns only instruments in the Active state (optional, default to State eq &#39;Active&#39;)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>ApiResponse of ResourceListOfInstrument</returns>
        ApiResponse<ResourceListOfInstrument> ListInstrumentsWithHttpInfo (DateTimeOffset? asAt = null, DateTimeOffset? effectiveAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null);
        /// <summary>
        /// Update instrument identifier
        /// </summary>
        /// <remarks>
        /// Adds, updates, or removes an identifier on an instrument
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The instrument identifier</param>
        /// <param name="request">The identifier to add, update, or remove (optional)</param>
        /// <returns>Instrument</returns>
        Instrument UpdateInstrumentIdentifier (string identifierType, string identifier, UpdateInstrumentIdentifierRequest request = null);

        /// <summary>
        /// Update instrument identifier
        /// </summary>
        /// <remarks>
        /// Adds, updates, or removes an identifier on an instrument
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The instrument identifier</param>
        /// <param name="request">The identifier to add, update, or remove (optional)</param>
        /// <returns>ApiResponse of Instrument</returns>
        ApiResponse<Instrument> UpdateInstrumentIdentifierWithHttpInfo (string identifierType, string identifier, UpdateInstrumentIdentifierRequest request = null);
        /// <summary>
        /// Upsert instruments
        /// </summary>
        /// <remarks>
        /// Attempt to master one or more instruments in LUSID&#39;s instrument master. Each instrument is keyed by some unique key. This key is unimportant, and serves only as a method to identify created instruments in the response.    The response will return both the collection of successfully created instruments, as well as those that were rejected and why their creation failed. They will be keyed against the key supplied in the  request.                It is important to always check the &#39;Failed&#39; set for any unsuccessful results.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requests">The instrument definitions (optional)</param>
        /// <returns>UpsertInstrumentsResponse</returns>
        UpsertInstrumentsResponse UpsertInstruments (Object requests = null);

        /// <summary>
        /// Upsert instruments
        /// </summary>
        /// <remarks>
        /// Attempt to master one or more instruments in LUSID&#39;s instrument master. Each instrument is keyed by some unique key. This key is unimportant, and serves only as a method to identify created instruments in the response.    The response will return both the collection of successfully created instruments, as well as those that were rejected and why their creation failed. They will be keyed against the key supplied in the  request.                It is important to always check the &#39;Failed&#39; set for any unsuccessful results.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requests">The instrument definitions (optional)</param>
        /// <returns>ApiResponse of UpsertInstrumentsResponse</returns>
        ApiResponse<UpsertInstrumentsResponse> UpsertInstrumentsWithHttpInfo (Object requests = null);
        /// <summary>
        /// Upsert instrument properties
        /// </summary>
        /// <remarks>
        /// Attempt to upsert property data for one or more instruments, properties, and effective dates.    The response will include the details of any failures that occurred during data storage.                It is important to always check the &#39;Failed&#39; collection for any unsuccessful results.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentProperties">The instrument property data (optional)</param>
        /// <returns>UpsertInstrumentPropertiesResponse</returns>
        UpsertInstrumentPropertiesResponse UpsertInstrumentsProperties (List<UpsertInstrumentPropertyRequest> instrumentProperties = null);

        /// <summary>
        /// Upsert instrument properties
        /// </summary>
        /// <remarks>
        /// Attempt to upsert property data for one or more instruments, properties, and effective dates.    The response will include the details of any failures that occurred during data storage.                It is important to always check the &#39;Failed&#39; collection for any unsuccessful results.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentProperties">The instrument property data (optional)</param>
        /// <returns>ApiResponse of UpsertInstrumentPropertiesResponse</returns>
        ApiResponse<UpsertInstrumentPropertiesResponse> UpsertInstrumentsPropertiesWithHttpInfo (List<UpsertInstrumentPropertyRequest> instrumentProperties = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete instrument
        /// </summary>
        /// <remarks>
        /// Attempt to delete one or more \&quot;client\&quot; instruments.    The response will include those instruments that could not be deleted (as well as any available details).                It is important to always check the &#39;Failed&#39; set for any unsuccessful results.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The instrument identifier</param>
        /// <returns>Task of DeleteInstrumentResponse</returns>
        System.Threading.Tasks.Task<DeleteInstrumentResponse> DeleteInstrumentAsync (string identifierType, string identifier);

        /// <summary>
        /// Delete instrument
        /// </summary>
        /// <remarks>
        /// Attempt to delete one or more \&quot;client\&quot; instruments.    The response will include those instruments that could not be deleted (as well as any available details).                It is important to always check the &#39;Failed&#39; set for any unsuccessful results.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The instrument identifier</param>
        /// <returns>Task of ApiResponse (DeleteInstrumentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeleteInstrumentResponse>> DeleteInstrumentAsyncWithHttpInfo (string identifierType, string identifier);
        /// <summary>
        /// Get instrument definition
        /// </summary>
        /// <remarks>
        /// Get an individual instrument by the one of its unique instrument identifiers. Optionally, it is possible to decorate each instrument with specified property data.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The identifier of the requested instrument</param>
        /// <param name="effectiveAt">Optional. The effective date of the query (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the query (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>Task of Instrument</returns>
        System.Threading.Tasks.Task<Instrument> GetInstrumentAsync (string identifierType, string identifier, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null);

        /// <summary>
        /// Get instrument definition
        /// </summary>
        /// <remarks>
        /// Get an individual instrument by the one of its unique instrument identifiers. Optionally, it is possible to decorate each instrument with specified property data.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The identifier of the requested instrument</param>
        /// <param name="effectiveAt">Optional. The effective date of the query (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the query (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>Task of ApiResponse (Instrument)</returns>
        System.Threading.Tasks.Task<ApiResponse<Instrument>> GetInstrumentAsyncWithHttpInfo (string identifierType, string identifier, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null);
        /// <summary>
        /// Get allowable instrument identifiers
        /// </summary>
        /// <remarks>
        /// Returns a collection of instrument identifier type descriptors. Each descriptor specifies the properties  of a particular instrument identifier - its name, its cardinality (whether or not multiple instruments can  share the same identifier value), and its corresponding PropertyKey.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ResourceListOfInstrumentIdTypeDescriptor</returns>
        System.Threading.Tasks.Task<ResourceListOfInstrumentIdTypeDescriptor> GetInstrumentIdentifiersAsync ();

        /// <summary>
        /// Get allowable instrument identifiers
        /// </summary>
        /// <remarks>
        /// Returns a collection of instrument identifier type descriptors. Each descriptor specifies the properties  of a particular instrument identifier - its name, its cardinality (whether or not multiple instruments can  share the same identifier value), and its corresponding PropertyKey.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ResourceListOfInstrumentIdTypeDescriptor)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfInstrumentIdTypeDescriptor>> GetInstrumentIdentifiersAsyncWithHttpInfo ();
        /// <summary>
        /// Get instrument definition
        /// </summary>
        /// <remarks>
        /// Get a collection of instruments by a set of identifiers. Optionally, it is possible to decorate each instrument with specified property data.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifiers being supplied</param>
        /// <param name="identifiers">The identifiers of the instruments to get</param>
        /// <param name="effectiveAt">Optional. The effective date of the request (optional)</param>
        /// <param name="asAt">Optional. The as at date of the request (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>Task of GetInstrumentsResponse</returns>
        System.Threading.Tasks.Task<GetInstrumentsResponse> GetInstrumentsAsync (string identifierType, List<string> identifiers, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null);

        /// <summary>
        /// Get instrument definition
        /// </summary>
        /// <remarks>
        /// Get a collection of instruments by a set of identifiers. Optionally, it is possible to decorate each instrument with specified property data.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifiers being supplied</param>
        /// <param name="identifiers">The identifiers of the instruments to get</param>
        /// <param name="effectiveAt">Optional. The effective date of the request (optional)</param>
        /// <param name="asAt">Optional. The as at date of the request (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>Task of ApiResponse (GetInstrumentsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetInstrumentsResponse>> GetInstrumentsAsyncWithHttpInfo (string identifierType, List<string> identifiers, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null);
        /// <summary>
        /// Get all of the currently mastered instruments in LUSID
        /// </summary>
        /// <remarks>
        /// Lists all instruments that have been mastered within LUSID.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">Optional. The AsAt time (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the query (optional)</param>
        /// <param name="page">Optional. The pagination token to continue listing instruments. This value is returned from a previous call to ListInstruments.  If this is set, then the sortBy, filter, effectiveAt, and asAt fields must not have changed. Also, if set, a start value cannot be set. (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set - the default filter returns only instruments in the Active state (optional, default to State eq &#39;Active&#39;)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>Task of ResourceListOfInstrument</returns>
        System.Threading.Tasks.Task<ResourceListOfInstrument> ListInstrumentsAsync (DateTimeOffset? asAt = null, DateTimeOffset? effectiveAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null);

        /// <summary>
        /// Get all of the currently mastered instruments in LUSID
        /// </summary>
        /// <remarks>
        /// Lists all instruments that have been mastered within LUSID.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">Optional. The AsAt time (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the query (optional)</param>
        /// <param name="page">Optional. The pagination token to continue listing instruments. This value is returned from a previous call to ListInstruments.  If this is set, then the sortBy, filter, effectiveAt, and asAt fields must not have changed. Also, if set, a start value cannot be set. (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set - the default filter returns only instruments in the Active state (optional, default to State eq &#39;Active&#39;)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfInstrument)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfInstrument>> ListInstrumentsAsyncWithHttpInfo (DateTimeOffset? asAt = null, DateTimeOffset? effectiveAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null);
        /// <summary>
        /// Update instrument identifier
        /// </summary>
        /// <remarks>
        /// Adds, updates, or removes an identifier on an instrument
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The instrument identifier</param>
        /// <param name="request">The identifier to add, update, or remove (optional)</param>
        /// <returns>Task of Instrument</returns>
        System.Threading.Tasks.Task<Instrument> UpdateInstrumentIdentifierAsync (string identifierType, string identifier, UpdateInstrumentIdentifierRequest request = null);

        /// <summary>
        /// Update instrument identifier
        /// </summary>
        /// <remarks>
        /// Adds, updates, or removes an identifier on an instrument
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The instrument identifier</param>
        /// <param name="request">The identifier to add, update, or remove (optional)</param>
        /// <returns>Task of ApiResponse (Instrument)</returns>
        System.Threading.Tasks.Task<ApiResponse<Instrument>> UpdateInstrumentIdentifierAsyncWithHttpInfo (string identifierType, string identifier, UpdateInstrumentIdentifierRequest request = null);
        /// <summary>
        /// Upsert instruments
        /// </summary>
        /// <remarks>
        /// Attempt to master one or more instruments in LUSID&#39;s instrument master. Each instrument is keyed by some unique key. This key is unimportant, and serves only as a method to identify created instruments in the response.    The response will return both the collection of successfully created instruments, as well as those that were rejected and why their creation failed. They will be keyed against the key supplied in the  request.                It is important to always check the &#39;Failed&#39; set for any unsuccessful results.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requests">The instrument definitions (optional)</param>
        /// <returns>Task of UpsertInstrumentsResponse</returns>
        System.Threading.Tasks.Task<UpsertInstrumentsResponse> UpsertInstrumentsAsync (Object requests = null);

        /// <summary>
        /// Upsert instruments
        /// </summary>
        /// <remarks>
        /// Attempt to master one or more instruments in LUSID&#39;s instrument master. Each instrument is keyed by some unique key. This key is unimportant, and serves only as a method to identify created instruments in the response.    The response will return both the collection of successfully created instruments, as well as those that were rejected and why their creation failed. They will be keyed against the key supplied in the  request.                It is important to always check the &#39;Failed&#39; set for any unsuccessful results.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requests">The instrument definitions (optional)</param>
        /// <returns>Task of ApiResponse (UpsertInstrumentsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpsertInstrumentsResponse>> UpsertInstrumentsAsyncWithHttpInfo (Object requests = null);
        /// <summary>
        /// Upsert instrument properties
        /// </summary>
        /// <remarks>
        /// Attempt to upsert property data for one or more instruments, properties, and effective dates.    The response will include the details of any failures that occurred during data storage.                It is important to always check the &#39;Failed&#39; collection for any unsuccessful results.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentProperties">The instrument property data (optional)</param>
        /// <returns>Task of UpsertInstrumentPropertiesResponse</returns>
        System.Threading.Tasks.Task<UpsertInstrumentPropertiesResponse> UpsertInstrumentsPropertiesAsync (List<UpsertInstrumentPropertyRequest> instrumentProperties = null);

        /// <summary>
        /// Upsert instrument properties
        /// </summary>
        /// <remarks>
        /// Attempt to upsert property data for one or more instruments, properties, and effective dates.    The response will include the details of any failures that occurred during data storage.                It is important to always check the &#39;Failed&#39; collection for any unsuccessful results.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentProperties">The instrument property data (optional)</param>
        /// <returns>Task of ApiResponse (UpsertInstrumentPropertiesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpsertInstrumentPropertiesResponse>> UpsertInstrumentsPropertiesAsyncWithHttpInfo (List<UpsertInstrumentPropertyRequest> instrumentProperties = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InstrumentsApi : IInstrumentsApi
    {
        private Lusid.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InstrumentsApi(String basePath)
        {
            this.Configuration = new Lusid.Sdk.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InstrumentsApi(Lusid.Sdk.Client.Configuration configuration = null)
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
        /// Delete instrument Attempt to delete one or more \&quot;client\&quot; instruments.    The response will include those instruments that could not be deleted (as well as any available details).                It is important to always check the &#39;Failed&#39; set for any unsuccessful results.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The instrument identifier</param>
        /// <returns>DeleteInstrumentResponse</returns>
        public DeleteInstrumentResponse DeleteInstrument (string identifierType, string identifier)
        {
             ApiResponse<DeleteInstrumentResponse> localVarResponse = DeleteInstrumentWithHttpInfo(identifierType, identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete instrument Attempt to delete one or more \&quot;client\&quot; instruments.    The response will include those instruments that could not be deleted (as well as any available details).                It is important to always check the &#39;Failed&#39; set for any unsuccessful results.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The instrument identifier</param>
        /// <returns>ApiResponse of DeleteInstrumentResponse</returns>
        public ApiResponse< DeleteInstrumentResponse > DeleteInstrumentWithHttpInfo (string identifierType, string identifier)
        {
            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new ApiException(400, "Missing required parameter 'identifierType' when calling InstrumentsApi->DeleteInstrument");
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling InstrumentsApi->DeleteInstrument");

            var localVarPath = "./api/instruments/{identifierType}/{identifier}";
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

            if (identifierType != null) localVarPathParams.Add("identifierType", this.Configuration.ApiClient.ParameterToString(identifierType)); // path parameter
            if (identifier != null) localVarPathParams.Add("identifier", this.Configuration.ApiClient.ParameterToString(identifier)); // path parameter

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
                Exception exception = ExceptionFactory("DeleteInstrument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeleteInstrumentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (DeleteInstrumentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeleteInstrumentResponse)));
        }

        /// <summary>
        /// Delete instrument Attempt to delete one or more \&quot;client\&quot; instruments.    The response will include those instruments that could not be deleted (as well as any available details).                It is important to always check the &#39;Failed&#39; set for any unsuccessful results.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The instrument identifier</param>
        /// <returns>Task of DeleteInstrumentResponse</returns>
        public async System.Threading.Tasks.Task<DeleteInstrumentResponse> DeleteInstrumentAsync (string identifierType, string identifier)
        {
             ApiResponse<DeleteInstrumentResponse> localVarResponse = await DeleteInstrumentAsyncWithHttpInfo(identifierType, identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete instrument Attempt to delete one or more \&quot;client\&quot; instruments.    The response will include those instruments that could not be deleted (as well as any available details).                It is important to always check the &#39;Failed&#39; set for any unsuccessful results.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The instrument identifier</param>
        /// <returns>Task of ApiResponse (DeleteInstrumentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeleteInstrumentResponse>> DeleteInstrumentAsyncWithHttpInfo (string identifierType, string identifier)
        {
            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new ApiException(400, "Missing required parameter 'identifierType' when calling InstrumentsApi->DeleteInstrument");
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling InstrumentsApi->DeleteInstrument");

            var localVarPath = "./api/instruments/{identifierType}/{identifier}";
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

            if (identifierType != null) localVarPathParams.Add("identifierType", this.Configuration.ApiClient.ParameterToString(identifierType)); // path parameter
            if (identifier != null) localVarPathParams.Add("identifier", this.Configuration.ApiClient.ParameterToString(identifier)); // path parameter

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
                Exception exception = ExceptionFactory("DeleteInstrument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeleteInstrumentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (DeleteInstrumentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeleteInstrumentResponse)));
        }

        /// <summary>
        /// Get instrument definition Get an individual instrument by the one of its unique instrument identifiers. Optionally, it is possible to decorate each instrument with specified property data.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The identifier of the requested instrument</param>
        /// <param name="effectiveAt">Optional. The effective date of the query (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the query (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>Instrument</returns>
        public Instrument GetInstrument (string identifierType, string identifier, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null)
        {
             ApiResponse<Instrument> localVarResponse = GetInstrumentWithHttpInfo(identifierType, identifier, effectiveAt, asAt, instrumentPropertyKeys);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get instrument definition Get an individual instrument by the one of its unique instrument identifiers. Optionally, it is possible to decorate each instrument with specified property data.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The identifier of the requested instrument</param>
        /// <param name="effectiveAt">Optional. The effective date of the query (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the query (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>ApiResponse of Instrument</returns>
        public ApiResponse< Instrument > GetInstrumentWithHttpInfo (string identifierType, string identifier, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null)
        {
            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new ApiException(400, "Missing required parameter 'identifierType' when calling InstrumentsApi->GetInstrument");
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling InstrumentsApi->GetInstrument");

            var localVarPath = "./api/instruments/{identifierType}/{identifier}";
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

            if (identifierType != null) localVarPathParams.Add("identifierType", this.Configuration.ApiClient.ParameterToString(identifierType)); // path parameter
            if (identifier != null) localVarPathParams.Add("identifier", this.Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (effectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "effectiveAt", effectiveAt)); // query parameter
            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter
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
                Exception exception = ExceptionFactory("GetInstrument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Instrument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (Instrument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Instrument)));
        }

        /// <summary>
        /// Get instrument definition Get an individual instrument by the one of its unique instrument identifiers. Optionally, it is possible to decorate each instrument with specified property data.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The identifier of the requested instrument</param>
        /// <param name="effectiveAt">Optional. The effective date of the query (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the query (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>Task of Instrument</returns>
        public async System.Threading.Tasks.Task<Instrument> GetInstrumentAsync (string identifierType, string identifier, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null)
        {
             ApiResponse<Instrument> localVarResponse = await GetInstrumentAsyncWithHttpInfo(identifierType, identifier, effectiveAt, asAt, instrumentPropertyKeys);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get instrument definition Get an individual instrument by the one of its unique instrument identifiers. Optionally, it is possible to decorate each instrument with specified property data.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The identifier of the requested instrument</param>
        /// <param name="effectiveAt">Optional. The effective date of the query (optional)</param>
        /// <param name="asAt">Optional. The AsAt date of the query (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>Task of ApiResponse (Instrument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Instrument>> GetInstrumentAsyncWithHttpInfo (string identifierType, string identifier, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null)
        {
            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new ApiException(400, "Missing required parameter 'identifierType' when calling InstrumentsApi->GetInstrument");
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling InstrumentsApi->GetInstrument");

            var localVarPath = "./api/instruments/{identifierType}/{identifier}";
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

            if (identifierType != null) localVarPathParams.Add("identifierType", this.Configuration.ApiClient.ParameterToString(identifierType)); // path parameter
            if (identifier != null) localVarPathParams.Add("identifier", this.Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (effectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "effectiveAt", effectiveAt)); // query parameter
            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter
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
                Exception exception = ExceptionFactory("GetInstrument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Instrument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (Instrument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Instrument)));
        }

        /// <summary>
        /// Get allowable instrument identifiers Returns a collection of instrument identifier type descriptors. Each descriptor specifies the properties  of a particular instrument identifier - its name, its cardinality (whether or not multiple instruments can  share the same identifier value), and its corresponding PropertyKey.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ResourceListOfInstrumentIdTypeDescriptor</returns>
        public ResourceListOfInstrumentIdTypeDescriptor GetInstrumentIdentifiers ()
        {
             ApiResponse<ResourceListOfInstrumentIdTypeDescriptor> localVarResponse = GetInstrumentIdentifiersWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get allowable instrument identifiers Returns a collection of instrument identifier type descriptors. Each descriptor specifies the properties  of a particular instrument identifier - its name, its cardinality (whether or not multiple instruments can  share the same identifier value), and its corresponding PropertyKey.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ResourceListOfInstrumentIdTypeDescriptor</returns>
        public ApiResponse< ResourceListOfInstrumentIdTypeDescriptor > GetInstrumentIdentifiersWithHttpInfo ()
        {

            var localVarPath = "./api/instruments/identifiers";
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
                Exception exception = ExceptionFactory("GetInstrumentIdentifiers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResourceListOfInstrumentIdTypeDescriptor>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (ResourceListOfInstrumentIdTypeDescriptor) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfInstrumentIdTypeDescriptor)));
        }

        /// <summary>
        /// Get allowable instrument identifiers Returns a collection of instrument identifier type descriptors. Each descriptor specifies the properties  of a particular instrument identifier - its name, its cardinality (whether or not multiple instruments can  share the same identifier value), and its corresponding PropertyKey.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ResourceListOfInstrumentIdTypeDescriptor</returns>
        public async System.Threading.Tasks.Task<ResourceListOfInstrumentIdTypeDescriptor> GetInstrumentIdentifiersAsync ()
        {
             ApiResponse<ResourceListOfInstrumentIdTypeDescriptor> localVarResponse = await GetInstrumentIdentifiersAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get allowable instrument identifiers Returns a collection of instrument identifier type descriptors. Each descriptor specifies the properties  of a particular instrument identifier - its name, its cardinality (whether or not multiple instruments can  share the same identifier value), and its corresponding PropertyKey.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ResourceListOfInstrumentIdTypeDescriptor)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResourceListOfInstrumentIdTypeDescriptor>> GetInstrumentIdentifiersAsyncWithHttpInfo ()
        {

            var localVarPath = "./api/instruments/identifiers";
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
                Exception exception = ExceptionFactory("GetInstrumentIdentifiers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResourceListOfInstrumentIdTypeDescriptor>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (ResourceListOfInstrumentIdTypeDescriptor) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfInstrumentIdTypeDescriptor)));
        }

        /// <summary>
        /// Get instrument definition Get a collection of instruments by a set of identifiers. Optionally, it is possible to decorate each instrument with specified property data.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifiers being supplied</param>
        /// <param name="identifiers">The identifiers of the instruments to get</param>
        /// <param name="effectiveAt">Optional. The effective date of the request (optional)</param>
        /// <param name="asAt">Optional. The as at date of the request (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>GetInstrumentsResponse</returns>
        public GetInstrumentsResponse GetInstruments (string identifierType, List<string> identifiers, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null)
        {
             ApiResponse<GetInstrumentsResponse> localVarResponse = GetInstrumentsWithHttpInfo(identifierType, identifiers, effectiveAt, asAt, instrumentPropertyKeys);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get instrument definition Get a collection of instruments by a set of identifiers. Optionally, it is possible to decorate each instrument with specified property data.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifiers being supplied</param>
        /// <param name="identifiers">The identifiers of the instruments to get</param>
        /// <param name="effectiveAt">Optional. The effective date of the request (optional)</param>
        /// <param name="asAt">Optional. The as at date of the request (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>ApiResponse of GetInstrumentsResponse</returns>
        public ApiResponse< GetInstrumentsResponse > GetInstrumentsWithHttpInfo (string identifierType, List<string> identifiers, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null)
        {
            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new ApiException(400, "Missing required parameter 'identifierType' when calling InstrumentsApi->GetInstruments");
            // verify the required parameter 'identifiers' is set
            if (identifiers == null)
                throw new ApiException(400, "Missing required parameter 'identifiers' when calling InstrumentsApi->GetInstruments");

            var localVarPath = "./api/instruments/$get";
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

            if (identifierType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "identifierType", identifierType)); // query parameter
            if (effectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "effectiveAt", effectiveAt)); // query parameter
            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter
            if (instrumentPropertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "instrumentPropertyKeys", instrumentPropertyKeys)); // query parameter
            if (identifiers != null && identifiers.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(identifiers); // http body (model) parameter
            }
            else
            {
                localVarPostBody = identifiers; // byte array
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
                Exception exception = ExceptionFactory("GetInstruments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetInstrumentsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (GetInstrumentsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetInstrumentsResponse)));
        }

        /// <summary>
        /// Get instrument definition Get a collection of instruments by a set of identifiers. Optionally, it is possible to decorate each instrument with specified property data.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifiers being supplied</param>
        /// <param name="identifiers">The identifiers of the instruments to get</param>
        /// <param name="effectiveAt">Optional. The effective date of the request (optional)</param>
        /// <param name="asAt">Optional. The as at date of the request (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>Task of GetInstrumentsResponse</returns>
        public async System.Threading.Tasks.Task<GetInstrumentsResponse> GetInstrumentsAsync (string identifierType, List<string> identifiers, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null)
        {
             ApiResponse<GetInstrumentsResponse> localVarResponse = await GetInstrumentsAsyncWithHttpInfo(identifierType, identifiers, effectiveAt, asAt, instrumentPropertyKeys);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get instrument definition Get a collection of instruments by a set of identifiers. Optionally, it is possible to decorate each instrument with specified property data.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifiers being supplied</param>
        /// <param name="identifiers">The identifiers of the instruments to get</param>
        /// <param name="effectiveAt">Optional. The effective date of the request (optional)</param>
        /// <param name="asAt">Optional. The as at date of the request (optional)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>Task of ApiResponse (GetInstrumentsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetInstrumentsResponse>> GetInstrumentsAsyncWithHttpInfo (string identifierType, List<string> identifiers, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null)
        {
            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new ApiException(400, "Missing required parameter 'identifierType' when calling InstrumentsApi->GetInstruments");
            // verify the required parameter 'identifiers' is set
            if (identifiers == null)
                throw new ApiException(400, "Missing required parameter 'identifiers' when calling InstrumentsApi->GetInstruments");

            var localVarPath = "./api/instruments/$get";
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

            if (identifierType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "identifierType", identifierType)); // query parameter
            if (effectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "effectiveAt", effectiveAt)); // query parameter
            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter
            if (instrumentPropertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "instrumentPropertyKeys", instrumentPropertyKeys)); // query parameter
            if (identifiers != null && identifiers.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(identifiers); // http body (model) parameter
            }
            else
            {
                localVarPostBody = identifiers; // byte array
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
                Exception exception = ExceptionFactory("GetInstruments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetInstrumentsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (GetInstrumentsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetInstrumentsResponse)));
        }

        /// <summary>
        /// Get all of the currently mastered instruments in LUSID Lists all instruments that have been mastered within LUSID.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">Optional. The AsAt time (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the query (optional)</param>
        /// <param name="page">Optional. The pagination token to continue listing instruments. This value is returned from a previous call to ListInstruments.  If this is set, then the sortBy, filter, effectiveAt, and asAt fields must not have changed. Also, if set, a start value cannot be set. (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set - the default filter returns only instruments in the Active state (optional, default to State eq &#39;Active&#39;)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>ResourceListOfInstrument</returns>
        public ResourceListOfInstrument ListInstruments (DateTimeOffset? asAt = null, DateTimeOffset? effectiveAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null)
        {
             ApiResponse<ResourceListOfInstrument> localVarResponse = ListInstrumentsWithHttpInfo(asAt, effectiveAt, page, sortBy, start, limit, filter, instrumentPropertyKeys);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all of the currently mastered instruments in LUSID Lists all instruments that have been mastered within LUSID.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">Optional. The AsAt time (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the query (optional)</param>
        /// <param name="page">Optional. The pagination token to continue listing instruments. This value is returned from a previous call to ListInstruments.  If this is set, then the sortBy, filter, effectiveAt, and asAt fields must not have changed. Also, if set, a start value cannot be set. (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set - the default filter returns only instruments in the Active state (optional, default to State eq &#39;Active&#39;)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>ApiResponse of ResourceListOfInstrument</returns>
        public ApiResponse< ResourceListOfInstrument > ListInstrumentsWithHttpInfo (DateTimeOffset? asAt = null, DateTimeOffset? effectiveAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null)
        {

            var localVarPath = "./api/instruments";
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

            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter
            if (effectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "effectiveAt", effectiveAt)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
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
                Exception exception = ExceptionFactory("ListInstruments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResourceListOfInstrument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (ResourceListOfInstrument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfInstrument)));
        }

        /// <summary>
        /// Get all of the currently mastered instruments in LUSID Lists all instruments that have been mastered within LUSID.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">Optional. The AsAt time (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the query (optional)</param>
        /// <param name="page">Optional. The pagination token to continue listing instruments. This value is returned from a previous call to ListInstruments.  If this is set, then the sortBy, filter, effectiveAt, and asAt fields must not have changed. Also, if set, a start value cannot be set. (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set - the default filter returns only instruments in the Active state (optional, default to State eq &#39;Active&#39;)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>Task of ResourceListOfInstrument</returns>
        public async System.Threading.Tasks.Task<ResourceListOfInstrument> ListInstrumentsAsync (DateTimeOffset? asAt = null, DateTimeOffset? effectiveAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null)
        {
             ApiResponse<ResourceListOfInstrument> localVarResponse = await ListInstrumentsAsyncWithHttpInfo(asAt, effectiveAt, page, sortBy, start, limit, filter, instrumentPropertyKeys);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all of the currently mastered instruments in LUSID Lists all instruments that have been mastered within LUSID.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">Optional. The AsAt time (optional)</param>
        /// <param name="effectiveAt">Optional. The effective date of the query (optional)</param>
        /// <param name="page">Optional. The pagination token to continue listing instruments. This value is returned from a previous call to ListInstruments.  If this is set, then the sortBy, filter, effectiveAt, and asAt fields must not have changed. Also, if set, a start value cannot be set. (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set - the default filter returns only instruments in the Active state (optional, default to State eq &#39;Active&#39;)</param>
        /// <param name="instrumentPropertyKeys">Optional. Keys of the properties to be decorated on to the instrument (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfInstrument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResourceListOfInstrument>> ListInstrumentsAsyncWithHttpInfo (DateTimeOffset? asAt = null, DateTimeOffset? effectiveAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null)
        {

            var localVarPath = "./api/instruments";
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

            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter
            if (effectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "effectiveAt", effectiveAt)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
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
                Exception exception = ExceptionFactory("ListInstruments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResourceListOfInstrument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (ResourceListOfInstrument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfInstrument)));
        }

        /// <summary>
        /// Update instrument identifier Adds, updates, or removes an identifier on an instrument
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The instrument identifier</param>
        /// <param name="request">The identifier to add, update, or remove (optional)</param>
        /// <returns>Instrument</returns>
        public Instrument UpdateInstrumentIdentifier (string identifierType, string identifier, UpdateInstrumentIdentifierRequest request = null)
        {
             ApiResponse<Instrument> localVarResponse = UpdateInstrumentIdentifierWithHttpInfo(identifierType, identifier, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update instrument identifier Adds, updates, or removes an identifier on an instrument
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The instrument identifier</param>
        /// <param name="request">The identifier to add, update, or remove (optional)</param>
        /// <returns>ApiResponse of Instrument</returns>
        public ApiResponse< Instrument > UpdateInstrumentIdentifierWithHttpInfo (string identifierType, string identifier, UpdateInstrumentIdentifierRequest request = null)
        {
            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new ApiException(400, "Missing required parameter 'identifierType' when calling InstrumentsApi->UpdateInstrumentIdentifier");
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling InstrumentsApi->UpdateInstrumentIdentifier");

            var localVarPath = "./api/instruments/{identifierType}/{identifier}";
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

            if (identifierType != null) localVarPathParams.Add("identifierType", this.Configuration.ApiClient.ParameterToString(identifierType)); // path parameter
            if (identifier != null) localVarPathParams.Add("identifier", this.Configuration.ApiClient.ParameterToString(identifier)); // path parameter
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateInstrumentIdentifier", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Instrument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (Instrument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Instrument)));
        }

        /// <summary>
        /// Update instrument identifier Adds, updates, or removes an identifier on an instrument
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The instrument identifier</param>
        /// <param name="request">The identifier to add, update, or remove (optional)</param>
        /// <returns>Task of Instrument</returns>
        public async System.Threading.Tasks.Task<Instrument> UpdateInstrumentIdentifierAsync (string identifierType, string identifier, UpdateInstrumentIdentifierRequest request = null)
        {
             ApiResponse<Instrument> localVarResponse = await UpdateInstrumentIdentifierAsyncWithHttpInfo(identifierType, identifier, request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update instrument identifier Adds, updates, or removes an identifier on an instrument
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The type of identifier being supplied</param>
        /// <param name="identifier">The instrument identifier</param>
        /// <param name="request">The identifier to add, update, or remove (optional)</param>
        /// <returns>Task of ApiResponse (Instrument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Instrument>> UpdateInstrumentIdentifierAsyncWithHttpInfo (string identifierType, string identifier, UpdateInstrumentIdentifierRequest request = null)
        {
            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new ApiException(400, "Missing required parameter 'identifierType' when calling InstrumentsApi->UpdateInstrumentIdentifier");
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling InstrumentsApi->UpdateInstrumentIdentifier");

            var localVarPath = "./api/instruments/{identifierType}/{identifier}";
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

            if (identifierType != null) localVarPathParams.Add("identifierType", this.Configuration.ApiClient.ParameterToString(identifierType)); // path parameter
            if (identifier != null) localVarPathParams.Add("identifier", this.Configuration.ApiClient.ParameterToString(identifier)); // path parameter
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateInstrumentIdentifier", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Instrument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (Instrument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Instrument)));
        }

        /// <summary>
        /// Upsert instruments Attempt to master one or more instruments in LUSID&#39;s instrument master. Each instrument is keyed by some unique key. This key is unimportant, and serves only as a method to identify created instruments in the response.    The response will return both the collection of successfully created instruments, as well as those that were rejected and why their creation failed. They will be keyed against the key supplied in the  request.                It is important to always check the &#39;Failed&#39; set for any unsuccessful results.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requests">The instrument definitions (optional)</param>
        /// <returns>UpsertInstrumentsResponse</returns>
        public UpsertInstrumentsResponse UpsertInstruments (Object requests = null)
        {
             ApiResponse<UpsertInstrumentsResponse> localVarResponse = UpsertInstrumentsWithHttpInfo(requests);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Upsert instruments Attempt to master one or more instruments in LUSID&#39;s instrument master. Each instrument is keyed by some unique key. This key is unimportant, and serves only as a method to identify created instruments in the response.    The response will return both the collection of successfully created instruments, as well as those that were rejected and why their creation failed. They will be keyed against the key supplied in the  request.                It is important to always check the &#39;Failed&#39; set for any unsuccessful results.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requests">The instrument definitions (optional)</param>
        /// <returns>ApiResponse of UpsertInstrumentsResponse</returns>
        public ApiResponse< UpsertInstrumentsResponse > UpsertInstrumentsWithHttpInfo (Object requests = null)
        {

            var localVarPath = "./api/instruments";
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

            if (requests != null && requests.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(requests); // http body (model) parameter
            }
            else
            {
                localVarPostBody = requests; // byte array
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
                Exception exception = ExceptionFactory("UpsertInstruments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UpsertInstrumentsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (UpsertInstrumentsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpsertInstrumentsResponse)));
        }

        /// <summary>
        /// Upsert instruments Attempt to master one or more instruments in LUSID&#39;s instrument master. Each instrument is keyed by some unique key. This key is unimportant, and serves only as a method to identify created instruments in the response.    The response will return both the collection of successfully created instruments, as well as those that were rejected and why their creation failed. They will be keyed against the key supplied in the  request.                It is important to always check the &#39;Failed&#39; set for any unsuccessful results.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requests">The instrument definitions (optional)</param>
        /// <returns>Task of UpsertInstrumentsResponse</returns>
        public async System.Threading.Tasks.Task<UpsertInstrumentsResponse> UpsertInstrumentsAsync (Object requests = null)
        {
             ApiResponse<UpsertInstrumentsResponse> localVarResponse = await UpsertInstrumentsAsyncWithHttpInfo(requests);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Upsert instruments Attempt to master one or more instruments in LUSID&#39;s instrument master. Each instrument is keyed by some unique key. This key is unimportant, and serves only as a method to identify created instruments in the response.    The response will return both the collection of successfully created instruments, as well as those that were rejected and why their creation failed. They will be keyed against the key supplied in the  request.                It is important to always check the &#39;Failed&#39; set for any unsuccessful results.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requests">The instrument definitions (optional)</param>
        /// <returns>Task of ApiResponse (UpsertInstrumentsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UpsertInstrumentsResponse>> UpsertInstrumentsAsyncWithHttpInfo (Object requests = null)
        {

            var localVarPath = "./api/instruments";
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

            if (requests != null && requests.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(requests); // http body (model) parameter
            }
            else
            {
                localVarPostBody = requests; // byte array
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
                Exception exception = ExceptionFactory("UpsertInstruments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UpsertInstrumentsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (UpsertInstrumentsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpsertInstrumentsResponse)));
        }

        /// <summary>
        /// Upsert instrument properties Attempt to upsert property data for one or more instruments, properties, and effective dates.    The response will include the details of any failures that occurred during data storage.                It is important to always check the &#39;Failed&#39; collection for any unsuccessful results.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentProperties">The instrument property data (optional)</param>
        /// <returns>UpsertInstrumentPropertiesResponse</returns>
        public UpsertInstrumentPropertiesResponse UpsertInstrumentsProperties (List<UpsertInstrumentPropertyRequest> instrumentProperties = null)
        {
             ApiResponse<UpsertInstrumentPropertiesResponse> localVarResponse = UpsertInstrumentsPropertiesWithHttpInfo(instrumentProperties);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Upsert instrument properties Attempt to upsert property data for one or more instruments, properties, and effective dates.    The response will include the details of any failures that occurred during data storage.                It is important to always check the &#39;Failed&#39; collection for any unsuccessful results.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentProperties">The instrument property data (optional)</param>
        /// <returns>ApiResponse of UpsertInstrumentPropertiesResponse</returns>
        public ApiResponse< UpsertInstrumentPropertiesResponse > UpsertInstrumentsPropertiesWithHttpInfo (List<UpsertInstrumentPropertyRequest> instrumentProperties = null)
        {

            var localVarPath = "./api/instruments/$upsertproperties";
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

            if (instrumentProperties != null && instrumentProperties.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(instrumentProperties); // http body (model) parameter
            }
            else
            {
                localVarPostBody = instrumentProperties; // byte array
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
                Exception exception = ExceptionFactory("UpsertInstrumentsProperties", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UpsertInstrumentPropertiesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (UpsertInstrumentPropertiesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpsertInstrumentPropertiesResponse)));
        }

        /// <summary>
        /// Upsert instrument properties Attempt to upsert property data for one or more instruments, properties, and effective dates.    The response will include the details of any failures that occurred during data storage.                It is important to always check the &#39;Failed&#39; collection for any unsuccessful results.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentProperties">The instrument property data (optional)</param>
        /// <returns>Task of UpsertInstrumentPropertiesResponse</returns>
        public async System.Threading.Tasks.Task<UpsertInstrumentPropertiesResponse> UpsertInstrumentsPropertiesAsync (List<UpsertInstrumentPropertyRequest> instrumentProperties = null)
        {
             ApiResponse<UpsertInstrumentPropertiesResponse> localVarResponse = await UpsertInstrumentsPropertiesAsyncWithHttpInfo(instrumentProperties);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Upsert instrument properties Attempt to upsert property data for one or more instruments, properties, and effective dates.    The response will include the details of any failures that occurred during data storage.                It is important to always check the &#39;Failed&#39; collection for any unsuccessful results.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentProperties">The instrument property data (optional)</param>
        /// <returns>Task of ApiResponse (UpsertInstrumentPropertiesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UpsertInstrumentPropertiesResponse>> UpsertInstrumentsPropertiesAsyncWithHttpInfo (List<UpsertInstrumentPropertyRequest> instrumentProperties = null)
        {

            var localVarPath = "./api/instruments/$upsertproperties";
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

            if (instrumentProperties != null && instrumentProperties.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(instrumentProperties); // http body (model) parameter
            }
            else
            {
                localVarPostBody = instrumentProperties; // byte array
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
                Exception exception = ExceptionFactory("UpsertInstrumentsProperties", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UpsertInstrumentPropertiesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key,  x => String.Join(",", x.Value.ToArray())),
                (UpsertInstrumentPropertiesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpsertInstrumentPropertiesResponse)));
        }

    }
    
}