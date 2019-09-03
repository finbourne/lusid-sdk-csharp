/* 
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://api.lusid.com/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages :  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python)  # Data Model  The LUSID API has a relatively lightweight but extremely powerful data model.   One of the goals of LUSID was not to enforce on clients a single rigid data model but rather to provide a flexible foundation onto which clients can streamline their data.   One of the primary tools to extend the data model is through using properties.  Properties can be associated with amongst others: - * Transactions * Instruments * Portfolios   The LUSID data model is exposed through the LUSID APIs.  The APIs provide access to both business objects and the meta data used to configure the systems behaviours.   The key business entities are: - * **Portfolios** A portfolio is the primary container for transactions and holdings.  * **Derived Portfolios** Derived portfolios allow portfolios to be created based on other portfolios, by overriding or overlaying specific items * **Holdings** A holding is a position account for a instrument within a portfolio.  Holdings can only be adjusted via transactions. * **Transactions** A Transaction is a source of transactions used to manipulate holdings.  * **Corporate Actions** A corporate action is a market event which occurs to a instrument, for example a stock split * **Instruments**  A instrument represents a currency, tradable instrument or OTC contract that is attached to a transaction and a holding. * **Properties** Several entities allow additional user defined properties to be associated with them.   For example, a Portfolio manager may be associated with a portfolio  Meta data includes: - * **Transaction Types** Transactions are booked with a specific transaction type.  The types are client defined and are used to map the Transaction to a series of movements which update the portfolio holdings.  * **Properties Types** Types of user defined properties used within the system.  This section describes the data model that LUSID exposes via the APIs.  ## Scope  All data in LUSID is segregated at the client level.  Entities in LUSID are identifiable by a unique code.  Every entity lives within a logical data partition known as a Scope.  Scope is an identity namespace allowing two entities with the same unique code to co-exist within individual address spaces.  For example, prices for equities from different vendors may be uploaded into different scopes such as `client/vendor1` and `client/vendor2`.  A portfolio may then be valued using either of the price sources by referencing the appropriate scope.  LUSID Clients cannot access scopes of other clients.  ## Schema  A detailed description of the entities used by the API and parameters for endpoints which take a JSON document can be retrieved via the `schema` endpoint.  ## Instruments  LUSID has its own built-in instrument master which you can use to master your own instrument universe.  Every instrument must be created with one or more unique market identifiers, such as [FIGI](https://openfigi.com/). For any non-listed instruments (eg OTCs), you can upload an instrument against a custom ID of your choosing.  In addition, LUSID will allocate each instrument a unique 'LUSID instrument identifier'. The LUSID instrument identifier is what is used when uploading transactions, holdings, prices, etc. The API exposes an `instrument/lookup` endpoint which can be used to lookup these LUSID identifiers using their market identifiers.  Cash can be referenced using the ISO currency code prefixed with \"`CCY_`\" e.g. `CCY_GBP`  ## Instrument Prices (Analytics)  Instrument prices are stored in LUSID's Analytics Store  | Field|Type|Description | | - --|- --|- -- | | InstrumentUid|string|Unique instrument identifier | | Value|decimal|Value of the analytic, eg price | | Denomination|string|Underlying unit of the analytic, eg currency, EPS etc. |   ## Instrument Data  Instrument data can be uploaded to the system using the [Instrument Properties](#tag/InstrumentProperties) endpoint.  | Field|Type|Description | | - --|- --|- -- | | Key|propertykey|The key of the property. This takes the format {domain}/{scope}/{code} e.g. 'Instrument/system/Name' or 'Transaction/strategy/quantsignal'. | | Value|string|The value of the property. | | EffectiveFrom|datetimeoffset|The effective datetime from which the property is valid. |   ## Portfolios  Portfolios are the top-level entity containers within LUSID, containing transactions, corporate actions and holdings.    The transactions build up the portfolio holdings on which valuations, analytics profit & loss and risk can be calculated.     Properties can be associated with Portfolios to add in additional model data.  Portfolio properties can be changed over time as well.  For example, to allow a Portfolio Manager to be linked with a Portfolio.  Additionally, portfolios can be securitised and held by other portfolios, allowing LUSID to perform \"drill-through\" into underlying fund holdings  ### Reference Portfolios Reference portfolios are portfolios that contain only weights, as opposed to transactions, and are designed to represent entities such as indices.  ### Derived Portfolios  LUSID also allows for a portfolio to be composed of another portfolio via derived portfolios.  A derived portfolio can contain its own transactions and also inherits any transactions from its parent portfolio.  Any changes made to the parent portfolio are automatically reflected in derived portfolio.  Derived portfolios in conjunction with scopes are a powerful construct.  For example, to do pre-trade what-if analysis, a derived portfolio could be created a new namespace linked to the underlying live (parent) portfolio.  Analysis can then be undertaken on the derived portfolio without affecting the live portfolio.  ### Portfolio Groups Portfolio groups allow the construction of a hierarchy from portfolios and groups.  Portfolio operations on the group are executed on an aggregated set of portfolios in the hierarchy.   For example:   * Global Portfolios _(group)_   * APAC _(group)_     * Hong Kong _(portfolio)_     * Japan _(portfolio)_   * Europe _(group)_     * France _(portfolio)_     * Germany _(portfolio)_   * UK _(portfolio)_   In this example **Global Portfolios** is a group that consists of an aggregate of **Hong Kong**, **Japan**, **France**, **Germany** and **UK** portfolios.  ### Movements Engine The Movements engine sits on top of the immutable event store and is used to manage the relationship between input trading actions and their associated portfolio holdings.     The movements engine reads in the following entity types:- * Posting Transactions * Applying Corporate Actions  * Holding Adjustments  These are converted to one or more movements and used by the movements engine to calculate holdings.  At the same time it also calculates running balances, and realised P&L.  The outputs from the movements engine are holdings and transactions.  ## Transactions  A transaction represents an economic activity against a Portfolio.  Transactions are processed according to a configuration. This will tell the LUSID engine how to interpret the transaction and correctly update the holdings. LUSID comes with a set of transaction types you can use out of the box, or you can configure your own set(s) of transactions.  For more details see the [LUSID Getting Started Guide for transaction configuration.](https://support.lusid.com/configuring-transaction-types)  | Field|Type|Description | | - --|- --|- -- | | TransactionId|string|The unique identifier for the transaction. | | Type|string|The type of the transaction e.g. 'Buy', 'Sell'. The transaction type should have been pre-configured via the System Configuration API endpoint. If it hasn't been pre-configured the transaction will still be updated or inserted however you will be unable to generate the resultant holdings for the portfolio that contains this transaction as LUSID does not know how to process it. | | InstrumentIdentifiers|map|A set of instrument identifiers to use to resolve the transaction to a unique instrument. | | TransactionDate|dateorcutlabel|The date of the transaction. | | SettlementDate|dateorcutlabel|The settlement date of the transaction. | | Units|decimal|The number of units transacted in the associated instrument. | | TransactionPrice|transactionprice|The price for each unit of the transacted instrument in the transaction currency. | | TotalConsideration|currencyandamount|The total value of the transaction in the settlement currency. | | ExchangeRate|decimal|The exchange rate between the transaction and settlement currency. For example if the transaction currency is in USD and the settlement currency is in GBP this this the USD/GBP rate. | | TransactionCurrency|currency|The transaction currency. | | Properties|map|Set of unique transaction properties and associated values to store with the transaction. Each property must be from the 'Transaction' domain. | | CounterpartyId|string|The identifier for the counterparty of the transaction. | | Source|string|The source of the transaction. This is used to look up the appropriate transaction group set in the transaction type configuration. |   From these fields, the following values can be calculated  * **Transaction value in Transaction currency**: TotalConsideration / ExchangeRate  * **Transaction value in Portfolio currency**: Transaction value in Transaction currency * TradeToPortfolioRate  ### Example Transactions  #### A Common Purchase Example Three example transactions are shown in the table below.   They represent a purchase of USD denominated IBM shares within a Sterling denominated portfolio.   * The first two transactions are for separate buy and fx trades    * Buying 500 IBM shares for $71,480.00    * A foreign exchange conversion to fund the IBM purchase. (Buy $71,480.00 for &#163;54,846.60)  * The third transaction is an alternate version of the above trades. Buying 500 IBM shares and settling directly in Sterling.  | Column |  Buy Trade | Fx Trade | Buy Trade with foreign Settlement | | - -- -- | - -- -- | - -- -- | - -- -- | | TransactionId | FBN00001 | FBN00002 | FBN00003 | | Type | Buy | FxBuy | Buy | | InstrumentIdentifiers | { \"figi\", \"BBG000BLNNH6\" } | { \"CCY\", \"CCY_USD\" } | { \"figi\", \"BBG000BLNNH6\" } | | TransactionDate | 2018-08-02 | 2018-08-02 | 2018-08-02 | | SettlementDate | 2018-08-06 | 2018-08-06 | 2018-08-06 | | Units | 500 | 71480 | 500 | | TransactionPrice | 142.96 | 1 | 142.96 | | TradeCurrency | USD | USD | USD | | ExchangeRate | 1 | 0.7673 | 0.7673 | | TotalConsideration.Amount | 71480.00 | 54846.60 | 54846.60 | | TotalConsideration.Currency | USD | GBP | GBP | | Trade/default/TradeToPortfolioRate&ast; | 0.7673 | 0.7673 | 0.7673 |  [&ast; This is a property field]  #### A Forward FX Example  LUSID has a flexible transaction modelling system, and there are a number of different ways of modelling forward fx trades.  The default LUSID transaction types are FwdFxBuy and FwdFxSell. Other types and behaviours can be configured as required.  Using these transaction types, the holdings query will report two forward positions. One in each currency.   Since an FX trade is an exchange of one currency for another, the following two 6 month forward transactions are equivalent:  | Column |  Forward 'Sell' Trade | Forward 'Buy' Trade | | - -- -- | - -- -- | - -- -- | | TransactionId | FBN00004 | FBN00005 | | Type | FwdFxSell | FwdFxBuy | | InstrumentIdentifiers | { \"CCY\", \"CCY_GBP\" } | { \"CCY\", \"CCY_USD\" } | | TransactionDate | 2018-08-02 | 2018-08-02 | | SettlementDate | 2019-02-06 | 2019-02-06 | | Units | 10000.00 | 13142.00 | | TransactionPrice |1 | 1 | | TradeCurrency | GBP | USD | | ExchangeRate | 1.3142 | 0.760919 | | TotalConsideration.Amount | 13142.00 | 10000.00 | | TotalConsideration.Currency | USD | GBP | | Trade/default/TradeToPortfolioRate | 1.0 | 0.760919 |  ## Holdings  A holding represents a position in a instrument or cash on a given date.  | Field|Type|Description | | - --|- --|- -- | | InstrumentUid|string|The unqiue Lusid Instrument Id (LUID) of the instrument that the holding is in. | | SubHoldingKeys|map|The sub-holding properties which identify the holding. Each property will be from the 'Transaction' domain. These are configured when a transaction portfolio is created. | | Properties|map|The properties which have been requested to be decorated onto the holding. These will be from the 'Instrument' or 'Holding' domain. | | HoldingType|string|The type of the holding e.g. Position, Balance, CashCommitment, Receivable, ForwardFX etc. | | Units|decimal|The total number of units of the holding. | | SettledUnits|decimal|The total number of settled units of the holding. | | Cost|currencyandamount|The total cost of the holding in the transaction currency. | | CostPortfolioCcy|currencyandamount|The total cost of the holding in the portfolio currency. | | Transaction|transaction|The transaction associated with an unsettled holding. |   ## Corporate Actions  Corporate actions are represented within LUSID in terms of a set of instrument-specific 'transitions'.  These transitions are used to specify the participants of the corporate action, and the effect that the corporate action will have on holdings in those participants.  ### Corporate Action  | Field|Type|Description | | - --|- --|- -- | | CorporateActionCode|code|The unique identifier of this corporate action | | Description|string|  | | AnnouncementDate|datetimeoffset|The announcement date of the corporate action | | ExDate|datetimeoffset|The ex date of the corporate action | | RecordDate|datetimeoffset|The record date of the corporate action | | PaymentDate|datetimeoffset|The payment date of the corporate action | | Transitions|corporateactiontransition[]|The transitions that result from this corporate action |   ### Transition  | Field|Type|Description | | - --|- --|- -- | | InputTransition|corporateactiontransitioncomponent|Indicating the basis of the corporate action - which security and how many units | | OutputTransitions|corporateactiontransitioncomponent[]|What will be generated relative to the input transition |   ### Example Corporate Action Transitions  #### A Dividend Action Transition  In this example, for each share of IBM, 0.20 units (or 20 pence) of GBP are generated.  | Column |  Input Transition | Output Transition | | - -- -- | - -- -- | - -- -- | | Instrument Identifiers | { \"figi\" : \"BBG000BLNNH6\" } | { \"ccy\" : \"CCY_GBP\" } | | Units Factor | 1 | 0.20 | | Cost Factor | 1 | 0 |  #### A Split Action Transition  In this example, for each share of IBM, we end up with 2 units (2 shares) of IBM, with total value unchanged.  | Column |  Input Transition | Output Transition | | - -- -- | - -- -- | - -- -- | | Instrument Identifiers | { \"figi\" : \"BBG000BLNNH6\" } | { \"figi\" : \"BBG000BLNNH6\" } | | Units Factor | 1 | 2 | | Cost Factor | 1 | 1 |  #### A Spinoff Action Transition  In this example, for each share of IBM, we end up with 1 unit (1 share) of IBM and 3 units (3 shares) of Celestica, with 85% of the value remaining on the IBM share, and 5% in each Celestica share (15% total).  | Column |  Input Transition | Output Transition 1 | Output Transition 2 | | - -- -- | - -- -- | - -- -- | - -- -- | | Instrument Identifiers | { \"figi\" : \"BBG000BLNNH6\" } | { \"figi\" : \"BBG000BLNNH6\" } | { \"figi\" : \"BBG000HBGRF3\" } | | Units Factor | 1 | 1 | 3 | | Cost Factor | 1 | 0.85 | 0.15 |  ## Property  Properties are key-value pairs that can be applied to any entity within a domain (where a domain is `trade`, `portfolio`, `security` etc).  Properties must be defined before use with a `PropertyDefinition` and can then subsequently be added to entities.  # Schemas  The following headers are returned on all responses from LUSID  | Name | Purpose | | - -- | - -- | | lusid-meta-duration | Duration of the request | | lusid-meta-success | Whether or not LUSID considered the request to be successful | | lusid-meta-requestId | The unique identifier for the request | | lusid-schema-url | Url of the schema for the data being returned | | lusid-property-schema-url | Url of the schema for any properties |   # Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"102\">102</a>|VersionNotFound|  | | <a name=\"104\">104</a>|InstrumentNotFound|  | | <a name=\"105\">105</a>|PropertyNotFound|  | | <a name=\"106\">106</a>|PortfolioRecursionDepth|  | | <a name=\"108\">108</a>|GroupNotFound|  | | <a name=\"109\">109</a>|PortfolioNotFound|  | | <a name=\"110\">110</a>|PropertySchemaNotFound|  | | <a name=\"111\">111</a>|PortfolioAncestryNotFound|  | | <a name=\"112\">112</a>|PortfolioWithIdAlreadyExists|  | | <a name=\"113\">113</a>|OrphanedPortfolio|  | | <a name=\"119\">119</a>|MissingBaseClaims|  | | <a name=\"121\">121</a>|PropertyNotDefined|  | | <a name=\"122\">122</a>|CannotDeleteSystemProperty|  | | <a name=\"123\">123</a>|CannotModifyImmutablePropertyField|  | | <a name=\"124\">124</a>|PropertyAlreadyExists|  | | <a name=\"125\">125</a>|InvalidPropertyLifeTime|  | | <a name=\"127\">127</a>|CannotModifyDefaultDataType|  | | <a name=\"128\">128</a>|GroupAlreadyExists|  | | <a name=\"129\">129</a>|NoSuchDataType|  | | <a name=\"132\">132</a>|ValidationError|  | | <a name=\"133\">133</a>|LoopDetectedInGroupHierarchy|  | | <a name=\"135\">135</a>|SubGroupAlreadyExists|  | | <a name=\"138\">138</a>|PriceSourceNotFound|  | | <a name=\"139\">139</a>|AnalyticStoreNotFound|  | | <a name=\"141\">141</a>|AnalyticStoreAlreadyExists|  | | <a name=\"143\">143</a>|ClientInstrumentAlreadyExists|  | | <a name=\"144\">144</a>|DuplicateInParameterSet|  | | <a name=\"147\">147</a>|ResultsNotFound|  | | <a name=\"148\">148</a>|OrderFieldNotInResultSet|  | | <a name=\"149\">149</a>|OperationFailed|  | | <a name=\"150\">150</a>|ElasticSearchError|  | | <a name=\"151\">151</a>|InvalidParameterValue|  | | <a name=\"153\">153</a>|CommandProcessingFailure|  | | <a name=\"154\">154</a>|EntityStateConstructionFailure|  | | <a name=\"155\">155</a>|EntityTimelineDoesNotExist|  | | <a name=\"156\">156</a>|EventPublishFailure|  | | <a name=\"157\">157</a>|InvalidRequestFailure|  | | <a name=\"158\">158</a>|EventPublishUnknown|  | | <a name=\"159\">159</a>|EventQueryFailure|  | | <a name=\"160\">160</a>|BlobDidNotExistFailure|  | | <a name=\"162\">162</a>|SubSystemRequestFailure|  | | <a name=\"163\">163</a>|SubSystemConfigurationFailure|  | | <a name=\"165\">165</a>|FailedToDelete|  | | <a name=\"166\">166</a>|UpsertClientInstrumentFailure|  | | <a name=\"167\">167</a>|IllegalAsAtInterval|  | | <a name=\"168\">168</a>|IllegalBitemporalQuery|  | | <a name=\"169\">169</a>|InvalidAlternateId|  | | <a name=\"170\">170</a>|CannotAddSourcePortfolioPropertyExplicitly|  | | <a name=\"171\">171</a>|EntityAlreadyExistsInGroup|  | | <a name=\"173\">173</a>|EntityWithIdAlreadyExists|  | | <a name=\"174\">174</a>|DerivedPortfolioDetailsDoNotExist|  | | <a name=\"176\">176</a>|PortfolioWithNameAlreadyExists|  | | <a name=\"177\">177</a>|InvalidTransactions|  | | <a name=\"178\">178</a>|ReferencePortfolioNotFound|  | | <a name=\"179\">179</a>|DuplicateIdFailure|  | | <a name=\"180\">180</a>|CommandRetrievalFailure|  | | <a name=\"181\">181</a>|DataFilterApplicationFailure|  | | <a name=\"182\">182</a>|SearchFailed|  | | <a name=\"183\">183</a>|MovementsEngineConfigurationKeyFailure|  | | <a name=\"184\">184</a>|FxRateSourceNotFound|  | | <a name=\"185\">185</a>|AccrualSourceNotFound|  | | <a name=\"186\">186</a>|AccessDenied|  | | <a name=\"187\">187</a>|InvalidIdentityToken|  | | <a name=\"188\">188</a>|InvalidRequestHeaders|  | | <a name=\"189\">189</a>|PriceNotFound|  | | <a name=\"190\">190</a>|InvalidSubHoldingKeysProvided|  | | <a name=\"191\">191</a>|DuplicateSubHoldingKeysProvided|  | | <a name=\"192\">192</a>|CutDefinitionNotFound|  | | <a name=\"193\">193</a>|CutDefinitionInvalid|  | | <a name=\"200\">200</a>|InvalidUnitForDataType|  | | <a name=\"201\">201</a>|InvalidTypeForDataType|  | | <a name=\"202\">202</a>|InvalidValueForDataType|  | | <a name=\"203\">203</a>|UnitNotDefinedForDataType|  | | <a name=\"204\">204</a>|UnitsNotSupportedOnDataType|  | | <a name=\"205\">205</a>|CannotSpecifyUnitsOnDataType|  | | <a name=\"206\">206</a>|UnitSchemaInconsistentWithDataType|  | | <a name=\"207\">207</a>|UnitDefinitionNotSpecified|  | | <a name=\"208\">208</a>|DuplicateUnitDefinitionsSpecified|  | | <a name=\"209\">209</a>|InvalidUnitsDefinition|  | | <a name=\"210\">210</a>|InvalidInstrumentIdentifierUnit|  | | <a name=\"211\">211</a>|HoldingsAdjustmentDoesNotExist|  | | <a name=\"212\">212</a>|CouldNotBuildExcelUrl|  | | <a name=\"213\">213</a>|CouldNotGetExcelVersion|  | | <a name=\"214\">214</a>|InstrumentByCodeNotFound|  | | <a name=\"215\">215</a>|EntitySchemaDoesNotExist|  | | <a name=\"216\">216</a>|FeatureNotSupportedOnPortfolioType|  | | <a name=\"217\">217</a>|QuoteNotFoundFailure|  | | <a name=\"218\">218</a>|InvalidQuoteIdentifierFailure|  | | <a name=\"219\">219</a>|InvalidInstrumentDefinition|  | | <a name=\"221\">221</a>|InstrumentUpsertFailure|  | | <a name=\"222\">222</a>|ReferencePortfolioRequestNotSupported|  | | <a name=\"223\">223</a>|TransactionPortfolioRequestNotSupported|  | | <a name=\"224\">224</a>|InvalidPropertyValueAssignment|  | | <a name=\"230\">230</a>|TransactionTypeNotFound|  | | <a name=\"231\">231</a>|TransactionTypeDuplication|  | | <a name=\"232\">232</a>|PortfolioDoesNotExistAtGivenDate|  | | <a name=\"233\">233</a>|QueryParserFailure|  | | <a name=\"234\">234</a>|DuplicateConstituentFailure|  | | <a name=\"235\">235</a>|UnresolvedInstrumentConstituentFailure|  | | <a name=\"236\">236</a>|UnresolvedInstrumentInTransitionFailure|  | | <a name=\"300\">300</a>|MissingRecipeFailure|  | | <a name=\"301\">301</a>|DependenciesFailure|  | | <a name=\"304\">304</a>|PortfolioPreprocessFailure|  | | <a name=\"310\">310</a>|ValuationEngineFailure|  | | <a name=\"311\">311</a>|TaskFactoryFailure|  | | <a name=\"312\">312</a>|TaskEvaluationFailure|  | | <a name=\"350\">350</a>|InstrumentFailure|  | | <a name=\"351\">351</a>|CashFlowsFailure|  | | <a name=\"360\">360</a>|AggregationFailure|  | | <a name=\"370\">370</a>|ResultRetrievalFailure|  | | <a name=\"371\">371</a>|ResultProcessingFailure|  | | <a name=\"371\">371</a>|ResultProcessingFailure|  | | <a name=\"372\">372</a>|VendorResultProcessingFailure|  | | <a name=\"373\">373</a>|VendorResultMappingFailure|  | | <a name=\"374\">374</a>|VendorLibraryUnauthorisedFailure|  | | <a name=\"390\">390</a>|AttemptToUpsertDuplicateQuotes|  | | <a name=\"391\">391</a>|CorporateActionSourceDoesNotExist|  | | <a name=\"392\">392</a>|CorporateActionSourceAlreadyExists|  | | <a name=\"393\">393</a>|InstrumentIdentifierAlreadyInUse|  | | <a name=\"394\">394</a>|PropertiesNotFound|  | | <a name=\"395\">395</a>|BatchOperationAborted|  | | <a name=\"400\">400</a>|InvalidIso4217CurrencyCodeFailure|  | | <a name=\"410\">410</a>|IndexDoesNotExist|  | | <a name=\"411\">411</a>|SortFieldDoesNotExist|  | | <a name=\"413\">413</a>|NegativePaginationParameters|  | | <a name=\"414\">414</a>|InvalidSearchSyntax|  | | <a name=\"-10\">-10</a>|ServerConfigurationError|  | | <a name=\"-1\">-1</a>|Unknown error|  | 
 *
 * The version of the OpenAPI document: 0.5.3180
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
        /// [EARLY ACCESS] Delete instrument
        /// </summary>
        /// <remarks>
        /// Delete a single instrument identified by a unique instrument identifier. Once an instrument has been  deleted it will be marked as &#39;inactive&#39; and it can no longer be used when updating or inserting transactions or holdings.  You can still query existing transactions and holdings related to the deleted instrument.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The value of the identifier that resolves to the instrument to delete.</param>
        /// <returns>DeleteInstrumentResponse</returns>
        DeleteInstrumentResponse DeleteInstrument (string identifierType, string identifier);

        /// <summary>
        /// [EARLY ACCESS] Delete instrument
        /// </summary>
        /// <remarks>
        /// Delete a single instrument identified by a unique instrument identifier. Once an instrument has been  deleted it will be marked as &#39;inactive&#39; and it can no longer be used when updating or inserting transactions or holdings.  You can still query existing transactions and holdings related to the deleted instrument.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The value of the identifier that resolves to the instrument to delete.</param>
        /// <returns>ApiResponse of DeleteInstrumentResponse</returns>
        ApiResponse<DeleteInstrumentResponse> DeleteInstrumentWithHttpInfo (string identifierType, string identifier);
        /// <summary>
        /// [EARLY ACCESS] Get instrument
        /// </summary>
        /// <remarks>
        /// Get the definition of a single instrument identified by a unique instrument identifier.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The value of the identifier for the requested instrument.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definition.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definition. Defaults to              return the latest version of the instrument definition if not specified. (optional)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto the instrument.              These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>Instrument</returns>
        Instrument GetInstrument (string identifierType, string identifier, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null);

        /// <summary>
        /// [EARLY ACCESS] Get instrument
        /// </summary>
        /// <remarks>
        /// Get the definition of a single instrument identified by a unique instrument identifier.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The value of the identifier for the requested instrument.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definition.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definition. Defaults to              return the latest version of the instrument definition if not specified. (optional)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto the instrument.              These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>ApiResponse of Instrument</returns>
        ApiResponse<Instrument> GetInstrumentWithHttpInfo (string identifierType, string identifier, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null);
        /// <summary>
        /// [EARLY ACCESS] Get instrument identifier types
        /// </summary>
        /// <remarks>
        /// Get the allowable instrument identifier types and their descriptions.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ResourceListOfInstrumentIdTypeDescriptor</returns>
        ResourceListOfInstrumentIdTypeDescriptor GetInstrumentIdentifierTypes ();

        /// <summary>
        /// [EARLY ACCESS] Get instrument identifier types
        /// </summary>
        /// <remarks>
        /// Get the allowable instrument identifier types and their descriptions.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ResourceListOfInstrumentIdTypeDescriptor</returns>
        ApiResponse<ResourceListOfInstrumentIdTypeDescriptor> GetInstrumentIdentifierTypesWithHttpInfo ();
        /// <summary>
        /// [EARLY ACCESS] Get instruments
        /// </summary>
        /// <remarks>
        /// Get the definition of one or more instruments identified by a collection of unique instrument identifiers.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifiers">The values of the identifier for the requested instruments.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definitions.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definitions.              Defaults to return the latest version of each instrument definition if not specified. (optional)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto the instrument.              These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>GetInstrumentsResponse</returns>
        GetInstrumentsResponse GetInstruments (string identifierType, List<string> identifiers, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null);

        /// <summary>
        /// [EARLY ACCESS] Get instruments
        /// </summary>
        /// <remarks>
        /// Get the definition of one or more instruments identified by a collection of unique instrument identifiers.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifiers">The values of the identifier for the requested instruments.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definitions.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definitions.              Defaults to return the latest version of each instrument definition if not specified. (optional)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto the instrument.              These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>ApiResponse of GetInstrumentsResponse</returns>
        ApiResponse<GetInstrumentsResponse> GetInstrumentsWithHttpInfo (string identifierType, List<string> identifiers, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null);
        /// <summary>
        /// [EARLY ACCESS] List instruments
        /// </summary>
        /// <remarks>
        /// List all the instruments that have been mastered in the LUSID instrument master.  The maximum number of instruments that this method can list per request is 2,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list the instruments. Defaults to return the latest              version of each instruments if not specified. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the instruments.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing instruments from a previous call to list instruments.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="sortBy">Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Defaults to filter down to active instruments only, i.e. those              that have not been deleted. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional, default to &quot;State eq &#39;Active&#39;&quot;)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto each instrument. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>ResourceListOfInstrument</returns>
        ResourceListOfInstrument ListInstruments (DateTimeOffset? asAt = null, DateTimeOrCutLabel effectiveAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null);

        /// <summary>
        /// [EARLY ACCESS] List instruments
        /// </summary>
        /// <remarks>
        /// List all the instruments that have been mastered in the LUSID instrument master.  The maximum number of instruments that this method can list per request is 2,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list the instruments. Defaults to return the latest              version of each instruments if not specified. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the instruments.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing instruments from a previous call to list instruments.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="sortBy">Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Defaults to filter down to active instruments only, i.e. those              that have not been deleted. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional, default to &quot;State eq &#39;Active&#39;&quot;)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto each instrument. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfInstrument</returns>
        ApiResponse<ResourceListOfInstrument> ListInstrumentsWithHttpInfo (DateTimeOffset? asAt = null, DateTimeOrCutLabel effectiveAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null);
        /// <summary>
        /// [EARLY ACCESS] Update instrument identifier
        /// </summary>
        /// <remarks>
        /// Update, insert or delete a single instrument identifier for a single instrument. If it is not being deleted  the identifier will be updated if it already exists and inserted if it does not.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier to use to resolve the instrument e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The original value of the identifier for the requested instrument.</param>
        /// <param name="request">The identifier to update or remove. This may or may not be the same identifier used              to resolve the instrument.</param>
        /// <returns>Instrument</returns>
        Instrument UpdateInstrumentIdentifier (string identifierType, string identifier, UpdateInstrumentIdentifierRequest request);

        /// <summary>
        /// [EARLY ACCESS] Update instrument identifier
        /// </summary>
        /// <remarks>
        /// Update, insert or delete a single instrument identifier for a single instrument. If it is not being deleted  the identifier will be updated if it already exists and inserted if it does not.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier to use to resolve the instrument e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The original value of the identifier for the requested instrument.</param>
        /// <param name="request">The identifier to update or remove. This may or may not be the same identifier used              to resolve the instrument.</param>
        /// <returns>ApiResponse of Instrument</returns>
        ApiResponse<Instrument> UpdateInstrumentIdentifierWithHttpInfo (string identifierType, string identifier, UpdateInstrumentIdentifierRequest request);
        /// <summary>
        /// [EARLY ACCESS] Upsert instruments
        /// </summary>
        /// <remarks>
        /// Update or insert one or more instruments into the LUSID instrument master. An instrument will be updated  if it already exists and inserted if it does not.                In the request each instrument definition should be keyed by a unique correlation id. This id is ephemeral  and is not stored by LUSID. It serves only as a way to easily identify each instrument in the response.                The response will return both the collection of successfully updated or inserted instruments, as well as those that failed.  For the failures a reason will be provided explaining why the instrument could not be updated or inserted.                It is important to always check the failed set for any unsuccessful results.  The maximum number of instruments that this method can upsert per request is 2,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requests">The definitions of the instruments to update or insert. (optional)</param>
        /// <returns>UpsertInstrumentsResponse</returns>
        UpsertInstrumentsResponse UpsertInstruments (Dictionary<string, InstrumentDefinition> requests = null);

        /// <summary>
        /// [EARLY ACCESS] Upsert instruments
        /// </summary>
        /// <remarks>
        /// Update or insert one or more instruments into the LUSID instrument master. An instrument will be updated  if it already exists and inserted if it does not.                In the request each instrument definition should be keyed by a unique correlation id. This id is ephemeral  and is not stored by LUSID. It serves only as a way to easily identify each instrument in the response.                The response will return both the collection of successfully updated or inserted instruments, as well as those that failed.  For the failures a reason will be provided explaining why the instrument could not be updated or inserted.                It is important to always check the failed set for any unsuccessful results.  The maximum number of instruments that this method can upsert per request is 2,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requests">The definitions of the instruments to update or insert. (optional)</param>
        /// <returns>ApiResponse of UpsertInstrumentsResponse</returns>
        ApiResponse<UpsertInstrumentsResponse> UpsertInstrumentsWithHttpInfo (Dictionary<string, InstrumentDefinition> requests = null);
        /// <summary>
        /// [EARLY ACCESS] Upsert instruments properties
        /// </summary>
        /// <remarks>
        /// Update or insert one or more instrument properties for one or more instruments. Each instrument property will be updated  if it already exists and inserted if it does not. If any properties fail to be updated or inserted, none will be updated or inserted and  the reason for the failure will be returned.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentProperties">A collection of instruments and associated instrument properties to update or insert.</param>
        /// <returns>UpsertInstrumentPropertiesResponse</returns>
        UpsertInstrumentPropertiesResponse UpsertInstrumentsProperties (List<UpsertInstrumentPropertyRequest> instrumentProperties);

        /// <summary>
        /// [EARLY ACCESS] Upsert instruments properties
        /// </summary>
        /// <remarks>
        /// Update or insert one or more instrument properties for one or more instruments. Each instrument property will be updated  if it already exists and inserted if it does not. If any properties fail to be updated or inserted, none will be updated or inserted and  the reason for the failure will be returned.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentProperties">A collection of instruments and associated instrument properties to update or insert.</param>
        /// <returns>ApiResponse of UpsertInstrumentPropertiesResponse</returns>
        ApiResponse<UpsertInstrumentPropertiesResponse> UpsertInstrumentsPropertiesWithHttpInfo (List<UpsertInstrumentPropertyRequest> instrumentProperties);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// [EARLY ACCESS] Delete instrument
        /// </summary>
        /// <remarks>
        /// Delete a single instrument identified by a unique instrument identifier. Once an instrument has been  deleted it will be marked as &#39;inactive&#39; and it can no longer be used when updating or inserting transactions or holdings.  You can still query existing transactions and holdings related to the deleted instrument.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The value of the identifier that resolves to the instrument to delete.</param>
        /// <returns>Task of DeleteInstrumentResponse</returns>
        System.Threading.Tasks.Task<DeleteInstrumentResponse> DeleteInstrumentAsync (string identifierType, string identifier);

        /// <summary>
        /// [EARLY ACCESS] Delete instrument
        /// </summary>
        /// <remarks>
        /// Delete a single instrument identified by a unique instrument identifier. Once an instrument has been  deleted it will be marked as &#39;inactive&#39; and it can no longer be used when updating or inserting transactions or holdings.  You can still query existing transactions and holdings related to the deleted instrument.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The value of the identifier that resolves to the instrument to delete.</param>
        /// <returns>Task of ApiResponse (DeleteInstrumentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeleteInstrumentResponse>> DeleteInstrumentAsyncWithHttpInfo (string identifierType, string identifier);
        /// <summary>
        /// [EARLY ACCESS] Get instrument
        /// </summary>
        /// <remarks>
        /// Get the definition of a single instrument identified by a unique instrument identifier.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The value of the identifier for the requested instrument.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definition.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definition. Defaults to              return the latest version of the instrument definition if not specified. (optional)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto the instrument.              These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>Task of Instrument</returns>
        System.Threading.Tasks.Task<Instrument> GetInstrumentAsync (string identifierType, string identifier, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null);

        /// <summary>
        /// [EARLY ACCESS] Get instrument
        /// </summary>
        /// <remarks>
        /// Get the definition of a single instrument identified by a unique instrument identifier.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The value of the identifier for the requested instrument.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definition.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definition. Defaults to              return the latest version of the instrument definition if not specified. (optional)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto the instrument.              These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (Instrument)</returns>
        System.Threading.Tasks.Task<ApiResponse<Instrument>> GetInstrumentAsyncWithHttpInfo (string identifierType, string identifier, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null);
        /// <summary>
        /// [EARLY ACCESS] Get instrument identifier types
        /// </summary>
        /// <remarks>
        /// Get the allowable instrument identifier types and their descriptions.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ResourceListOfInstrumentIdTypeDescriptor</returns>
        System.Threading.Tasks.Task<ResourceListOfInstrumentIdTypeDescriptor> GetInstrumentIdentifierTypesAsync ();

        /// <summary>
        /// [EARLY ACCESS] Get instrument identifier types
        /// </summary>
        /// <remarks>
        /// Get the allowable instrument identifier types and their descriptions.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ResourceListOfInstrumentIdTypeDescriptor)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfInstrumentIdTypeDescriptor>> GetInstrumentIdentifierTypesAsyncWithHttpInfo ();
        /// <summary>
        /// [EARLY ACCESS] Get instruments
        /// </summary>
        /// <remarks>
        /// Get the definition of one or more instruments identified by a collection of unique instrument identifiers.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifiers">The values of the identifier for the requested instruments.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definitions.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definitions.              Defaults to return the latest version of each instrument definition if not specified. (optional)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto the instrument.              These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>Task of GetInstrumentsResponse</returns>
        System.Threading.Tasks.Task<GetInstrumentsResponse> GetInstrumentsAsync (string identifierType, List<string> identifiers, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null);

        /// <summary>
        /// [EARLY ACCESS] Get instruments
        /// </summary>
        /// <remarks>
        /// Get the definition of one or more instruments identified by a collection of unique instrument identifiers.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifiers">The values of the identifier for the requested instruments.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definitions.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definitions.              Defaults to return the latest version of each instrument definition if not specified. (optional)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto the instrument.              These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (GetInstrumentsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetInstrumentsResponse>> GetInstrumentsAsyncWithHttpInfo (string identifierType, List<string> identifiers, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null);
        /// <summary>
        /// [EARLY ACCESS] List instruments
        /// </summary>
        /// <remarks>
        /// List all the instruments that have been mastered in the LUSID instrument master.  The maximum number of instruments that this method can list per request is 2,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list the instruments. Defaults to return the latest              version of each instruments if not specified. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the instruments.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing instruments from a previous call to list instruments.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="sortBy">Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Defaults to filter down to active instruments only, i.e. those              that have not been deleted. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional, default to &quot;State eq &#39;Active&#39;&quot;)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto each instrument. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>Task of ResourceListOfInstrument</returns>
        System.Threading.Tasks.Task<ResourceListOfInstrument> ListInstrumentsAsync (DateTimeOffset? asAt = null, DateTimeOrCutLabel effectiveAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null);

        /// <summary>
        /// [EARLY ACCESS] List instruments
        /// </summary>
        /// <remarks>
        /// List all the instruments that have been mastered in the LUSID instrument master.  The maximum number of instruments that this method can list per request is 2,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list the instruments. Defaults to return the latest              version of each instruments if not specified. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the instruments.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing instruments from a previous call to list instruments.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="sortBy">Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Defaults to filter down to active instruments only, i.e. those              that have not been deleted. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional, default to &quot;State eq &#39;Active&#39;&quot;)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto each instrument. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfInstrument)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfInstrument>> ListInstrumentsAsyncWithHttpInfo (DateTimeOffset? asAt = null, DateTimeOrCutLabel effectiveAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null);
        /// <summary>
        /// [EARLY ACCESS] Update instrument identifier
        /// </summary>
        /// <remarks>
        /// Update, insert or delete a single instrument identifier for a single instrument. If it is not being deleted  the identifier will be updated if it already exists and inserted if it does not.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier to use to resolve the instrument e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The original value of the identifier for the requested instrument.</param>
        /// <param name="request">The identifier to update or remove. This may or may not be the same identifier used              to resolve the instrument.</param>
        /// <returns>Task of Instrument</returns>
        System.Threading.Tasks.Task<Instrument> UpdateInstrumentIdentifierAsync (string identifierType, string identifier, UpdateInstrumentIdentifierRequest request);

        /// <summary>
        /// [EARLY ACCESS] Update instrument identifier
        /// </summary>
        /// <remarks>
        /// Update, insert or delete a single instrument identifier for a single instrument. If it is not being deleted  the identifier will be updated if it already exists and inserted if it does not.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier to use to resolve the instrument e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The original value of the identifier for the requested instrument.</param>
        /// <param name="request">The identifier to update or remove. This may or may not be the same identifier used              to resolve the instrument.</param>
        /// <returns>Task of ApiResponse (Instrument)</returns>
        System.Threading.Tasks.Task<ApiResponse<Instrument>> UpdateInstrumentIdentifierAsyncWithHttpInfo (string identifierType, string identifier, UpdateInstrumentIdentifierRequest request);
        /// <summary>
        /// [EARLY ACCESS] Upsert instruments
        /// </summary>
        /// <remarks>
        /// Update or insert one or more instruments into the LUSID instrument master. An instrument will be updated  if it already exists and inserted if it does not.                In the request each instrument definition should be keyed by a unique correlation id. This id is ephemeral  and is not stored by LUSID. It serves only as a way to easily identify each instrument in the response.                The response will return both the collection of successfully updated or inserted instruments, as well as those that failed.  For the failures a reason will be provided explaining why the instrument could not be updated or inserted.                It is important to always check the failed set for any unsuccessful results.  The maximum number of instruments that this method can upsert per request is 2,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requests">The definitions of the instruments to update or insert. (optional)</param>
        /// <returns>Task of UpsertInstrumentsResponse</returns>
        System.Threading.Tasks.Task<UpsertInstrumentsResponse> UpsertInstrumentsAsync (Dictionary<string, InstrumentDefinition> requests = null);

        /// <summary>
        /// [EARLY ACCESS] Upsert instruments
        /// </summary>
        /// <remarks>
        /// Update or insert one or more instruments into the LUSID instrument master. An instrument will be updated  if it already exists and inserted if it does not.                In the request each instrument definition should be keyed by a unique correlation id. This id is ephemeral  and is not stored by LUSID. It serves only as a way to easily identify each instrument in the response.                The response will return both the collection of successfully updated or inserted instruments, as well as those that failed.  For the failures a reason will be provided explaining why the instrument could not be updated or inserted.                It is important to always check the failed set for any unsuccessful results.  The maximum number of instruments that this method can upsert per request is 2,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requests">The definitions of the instruments to update or insert. (optional)</param>
        /// <returns>Task of ApiResponse (UpsertInstrumentsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpsertInstrumentsResponse>> UpsertInstrumentsAsyncWithHttpInfo (Dictionary<string, InstrumentDefinition> requests = null);
        /// <summary>
        /// [EARLY ACCESS] Upsert instruments properties
        /// </summary>
        /// <remarks>
        /// Update or insert one or more instrument properties for one or more instruments. Each instrument property will be updated  if it already exists and inserted if it does not. If any properties fail to be updated or inserted, none will be updated or inserted and  the reason for the failure will be returned.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentProperties">A collection of instruments and associated instrument properties to update or insert.</param>
        /// <returns>Task of UpsertInstrumentPropertiesResponse</returns>
        System.Threading.Tasks.Task<UpsertInstrumentPropertiesResponse> UpsertInstrumentsPropertiesAsync (List<UpsertInstrumentPropertyRequest> instrumentProperties);

        /// <summary>
        /// [EARLY ACCESS] Upsert instruments properties
        /// </summary>
        /// <remarks>
        /// Update or insert one or more instrument properties for one or more instruments. Each instrument property will be updated  if it already exists and inserted if it does not. If any properties fail to be updated or inserted, none will be updated or inserted and  the reason for the failure will be returned.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentProperties">A collection of instruments and associated instrument properties to update or insert.</param>
        /// <returns>Task of ApiResponse (UpsertInstrumentPropertiesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpsertInstrumentPropertiesResponse>> UpsertInstrumentsPropertiesAsyncWithHttpInfo (List<UpsertInstrumentPropertyRequest> instrumentProperties);
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
        /// </summary>
        /// <returns></returns>
        public InstrumentsApi()
        {
            this.Configuration = Lusid.Sdk.Client.Configuration.Default;

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
        /// [EARLY ACCESS] Delete instrument Delete a single instrument identified by a unique instrument identifier. Once an instrument has been  deleted it will be marked as &#39;inactive&#39; and it can no longer be used when updating or inserting transactions or holdings.  You can still query existing transactions and holdings related to the deleted instrument.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The value of the identifier that resolves to the instrument to delete.</param>
        /// <returns>DeleteInstrumentResponse</returns>
        public DeleteInstrumentResponse DeleteInstrument (string identifierType, string identifier)
        {
             ApiResponse<DeleteInstrumentResponse> localVarResponse = DeleteInstrumentWithHttpInfo(identifierType, identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Delete instrument Delete a single instrument identified by a unique instrument identifier. Once an instrument has been  deleted it will be marked as &#39;inactive&#39; and it can no longer be used when updating or inserting transactions or holdings.  You can still query existing transactions and holdings related to the deleted instrument.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The value of the identifier that resolves to the instrument to delete.</param>
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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.5.3180";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (DeleteInstrumentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeleteInstrumentResponse)));
        }

        /// <summary>
        /// [EARLY ACCESS] Delete instrument Delete a single instrument identified by a unique instrument identifier. Once an instrument has been  deleted it will be marked as &#39;inactive&#39; and it can no longer be used when updating or inserting transactions or holdings.  You can still query existing transactions and holdings related to the deleted instrument.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The value of the identifier that resolves to the instrument to delete.</param>
        /// <returns>Task of DeleteInstrumentResponse</returns>
        public async System.Threading.Tasks.Task<DeleteInstrumentResponse> DeleteInstrumentAsync (string identifierType, string identifier)
        {
             ApiResponse<DeleteInstrumentResponse> localVarResponse = await DeleteInstrumentAsyncWithHttpInfo(identifierType, identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Delete instrument Delete a single instrument identified by a unique instrument identifier. Once an instrument has been  deleted it will be marked as &#39;inactive&#39; and it can no longer be used when updating or inserting transactions or holdings.  You can still query existing transactions and holdings related to the deleted instrument.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The value of the identifier that resolves to the instrument to delete.</param>
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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.5.3180";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (DeleteInstrumentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeleteInstrumentResponse)));
        }

        /// <summary>
        /// [EARLY ACCESS] Get instrument Get the definition of a single instrument identified by a unique instrument identifier.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The value of the identifier for the requested instrument.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definition.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definition. Defaults to              return the latest version of the instrument definition if not specified. (optional)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto the instrument.              These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>Instrument</returns>
        public Instrument GetInstrument (string identifierType, string identifier, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null)
        {
             ApiResponse<Instrument> localVarResponse = GetInstrumentWithHttpInfo(identifierType, identifier, effectiveAt, asAt, instrumentPropertyKeys);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Get instrument Get the definition of a single instrument identified by a unique instrument identifier.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The value of the identifier for the requested instrument.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definition.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definition. Defaults to              return the latest version of the instrument definition if not specified. (optional)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto the instrument.              These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>ApiResponse of Instrument</returns>
        public ApiResponse< Instrument > GetInstrumentWithHttpInfo (string identifierType, string identifier, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null)
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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.5.3180";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Instrument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Instrument)));
        }

        /// <summary>
        /// [EARLY ACCESS] Get instrument Get the definition of a single instrument identified by a unique instrument identifier.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The value of the identifier for the requested instrument.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definition.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definition. Defaults to              return the latest version of the instrument definition if not specified. (optional)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto the instrument.              These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>Task of Instrument</returns>
        public async System.Threading.Tasks.Task<Instrument> GetInstrumentAsync (string identifierType, string identifier, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null)
        {
             ApiResponse<Instrument> localVarResponse = await GetInstrumentAsyncWithHttpInfo(identifierType, identifier, effectiveAt, asAt, instrumentPropertyKeys);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Get instrument Get the definition of a single instrument identified by a unique instrument identifier.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The value of the identifier for the requested instrument.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definition.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definition. Defaults to              return the latest version of the instrument definition if not specified. (optional)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto the instrument.              These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (Instrument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Instrument>> GetInstrumentAsyncWithHttpInfo (string identifierType, string identifier, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null)
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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.5.3180";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Instrument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Instrument)));
        }

        /// <summary>
        /// [EARLY ACCESS] Get instrument identifier types Get the allowable instrument identifier types and their descriptions.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ResourceListOfInstrumentIdTypeDescriptor</returns>
        public ResourceListOfInstrumentIdTypeDescriptor GetInstrumentIdentifierTypes ()
        {
             ApiResponse<ResourceListOfInstrumentIdTypeDescriptor> localVarResponse = GetInstrumentIdentifierTypesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Get instrument identifier types Get the allowable instrument identifier types and their descriptions.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ResourceListOfInstrumentIdTypeDescriptor</returns>
        public ApiResponse< ResourceListOfInstrumentIdTypeDescriptor > GetInstrumentIdentifierTypesWithHttpInfo ()
        {

            var localVarPath = "./api/instruments/identifierTypes";
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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.5.3180";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetInstrumentIdentifierTypes", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResourceListOfInstrumentIdTypeDescriptor>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ResourceListOfInstrumentIdTypeDescriptor) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfInstrumentIdTypeDescriptor)));
        }

        /// <summary>
        /// [EARLY ACCESS] Get instrument identifier types Get the allowable instrument identifier types and their descriptions.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ResourceListOfInstrumentIdTypeDescriptor</returns>
        public async System.Threading.Tasks.Task<ResourceListOfInstrumentIdTypeDescriptor> GetInstrumentIdentifierTypesAsync ()
        {
             ApiResponse<ResourceListOfInstrumentIdTypeDescriptor> localVarResponse = await GetInstrumentIdentifierTypesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Get instrument identifier types Get the allowable instrument identifier types and their descriptions.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ResourceListOfInstrumentIdTypeDescriptor)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResourceListOfInstrumentIdTypeDescriptor>> GetInstrumentIdentifierTypesAsyncWithHttpInfo ()
        {

            var localVarPath = "./api/instruments/identifierTypes";
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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.5.3180";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetInstrumentIdentifierTypes", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResourceListOfInstrumentIdTypeDescriptor>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ResourceListOfInstrumentIdTypeDescriptor) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfInstrumentIdTypeDescriptor)));
        }

        /// <summary>
        /// [EARLY ACCESS] Get instruments Get the definition of one or more instruments identified by a collection of unique instrument identifiers.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifiers">The values of the identifier for the requested instruments.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definitions.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definitions.              Defaults to return the latest version of each instrument definition if not specified. (optional)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto the instrument.              These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>GetInstrumentsResponse</returns>
        public GetInstrumentsResponse GetInstruments (string identifierType, List<string> identifiers, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null)
        {
             ApiResponse<GetInstrumentsResponse> localVarResponse = GetInstrumentsWithHttpInfo(identifierType, identifiers, effectiveAt, asAt, instrumentPropertyKeys);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Get instruments Get the definition of one or more instruments identified by a collection of unique instrument identifiers.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifiers">The values of the identifier for the requested instruments.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definitions.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definitions.              Defaults to return the latest version of each instrument definition if not specified. (optional)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto the instrument.              These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>ApiResponse of GetInstrumentsResponse</returns>
        public ApiResponse< GetInstrumentsResponse > GetInstrumentsWithHttpInfo (string identifierType, List<string> identifiers, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null)
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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.5.3180";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (GetInstrumentsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetInstrumentsResponse)));
        }

        /// <summary>
        /// [EARLY ACCESS] Get instruments Get the definition of one or more instruments identified by a collection of unique instrument identifiers.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifiers">The values of the identifier for the requested instruments.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definitions.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definitions.              Defaults to return the latest version of each instrument definition if not specified. (optional)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto the instrument.              These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>Task of GetInstrumentsResponse</returns>
        public async System.Threading.Tasks.Task<GetInstrumentsResponse> GetInstrumentsAsync (string identifierType, List<string> identifiers, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null)
        {
             ApiResponse<GetInstrumentsResponse> localVarResponse = await GetInstrumentsAsyncWithHttpInfo(identifierType, identifiers, effectiveAt, asAt, instrumentPropertyKeys);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Get instruments Get the definition of one or more instruments identified by a collection of unique instrument identifiers.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier being supplied e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifiers">The values of the identifier for the requested instruments.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definitions.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definitions.              Defaults to return the latest version of each instrument definition if not specified. (optional)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto the instrument.              These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (GetInstrumentsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetInstrumentsResponse>> GetInstrumentsAsyncWithHttpInfo (string identifierType, List<string> identifiers, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null)
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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.5.3180";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (GetInstrumentsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetInstrumentsResponse)));
        }

        /// <summary>
        /// [EARLY ACCESS] List instruments List all the instruments that have been mastered in the LUSID instrument master.  The maximum number of instruments that this method can list per request is 2,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list the instruments. Defaults to return the latest              version of each instruments if not specified. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the instruments.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing instruments from a previous call to list instruments.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="sortBy">Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Defaults to filter down to active instruments only, i.e. those              that have not been deleted. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional, default to &quot;State eq &#39;Active&#39;&quot;)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto each instrument. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>ResourceListOfInstrument</returns>
        public ResourceListOfInstrument ListInstruments (DateTimeOffset? asAt = null, DateTimeOrCutLabel effectiveAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null)
        {
             ApiResponse<ResourceListOfInstrument> localVarResponse = ListInstrumentsWithHttpInfo(asAt, effectiveAt, page, sortBy, start, limit, filter, instrumentPropertyKeys);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] List instruments List all the instruments that have been mastered in the LUSID instrument master.  The maximum number of instruments that this method can list per request is 2,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list the instruments. Defaults to return the latest              version of each instruments if not specified. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the instruments.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing instruments from a previous call to list instruments.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="sortBy">Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Defaults to filter down to active instruments only, i.e. those              that have not been deleted. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional, default to &quot;State eq &#39;Active&#39;&quot;)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto each instrument. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfInstrument</returns>
        public ApiResponse< ResourceListOfInstrument > ListInstrumentsWithHttpInfo (DateTimeOffset? asAt = null, DateTimeOrCutLabel effectiveAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null)
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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.5.3180";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ResourceListOfInstrument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfInstrument)));
        }

        /// <summary>
        /// [EARLY ACCESS] List instruments List all the instruments that have been mastered in the LUSID instrument master.  The maximum number of instruments that this method can list per request is 2,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list the instruments. Defaults to return the latest              version of each instruments if not specified. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the instruments.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing instruments from a previous call to list instruments.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="sortBy">Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Defaults to filter down to active instruments only, i.e. those              that have not been deleted. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional, default to &quot;State eq &#39;Active&#39;&quot;)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto each instrument. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>Task of ResourceListOfInstrument</returns>
        public async System.Threading.Tasks.Task<ResourceListOfInstrument> ListInstrumentsAsync (DateTimeOffset? asAt = null, DateTimeOrCutLabel effectiveAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null)
        {
             ApiResponse<ResourceListOfInstrument> localVarResponse = await ListInstrumentsAsyncWithHttpInfo(asAt, effectiveAt, page, sortBy, start, limit, filter, instrumentPropertyKeys);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] List instruments List all the instruments that have been mastered in the LUSID instrument master.  The maximum number of instruments that this method can list per request is 2,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list the instruments. Defaults to return the latest              version of each instruments if not specified. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the instruments.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing instruments from a previous call to list instruments.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="sortBy">Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Defaults to filter down to active instruments only, i.e. those              that have not been deleted. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional, default to &quot;State eq &#39;Active&#39;&quot;)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto each instrument. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfInstrument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResourceListOfInstrument>> ListInstrumentsAsyncWithHttpInfo (DateTimeOffset? asAt = null, DateTimeOrCutLabel effectiveAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null)
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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.5.3180";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ResourceListOfInstrument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfInstrument)));
        }

        /// <summary>
        /// [EARLY ACCESS] Update instrument identifier Update, insert or delete a single instrument identifier for a single instrument. If it is not being deleted  the identifier will be updated if it already exists and inserted if it does not.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier to use to resolve the instrument e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The original value of the identifier for the requested instrument.</param>
        /// <param name="request">The identifier to update or remove. This may or may not be the same identifier used              to resolve the instrument.</param>
        /// <returns>Instrument</returns>
        public Instrument UpdateInstrumentIdentifier (string identifierType, string identifier, UpdateInstrumentIdentifierRequest request)
        {
             ApiResponse<Instrument> localVarResponse = UpdateInstrumentIdentifierWithHttpInfo(identifierType, identifier, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Update instrument identifier Update, insert or delete a single instrument identifier for a single instrument. If it is not being deleted  the identifier will be updated if it already exists and inserted if it does not.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier to use to resolve the instrument e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The original value of the identifier for the requested instrument.</param>
        /// <param name="request">The identifier to update or remove. This may or may not be the same identifier used              to resolve the instrument.</param>
        /// <returns>ApiResponse of Instrument</returns>
        public ApiResponse< Instrument > UpdateInstrumentIdentifierWithHttpInfo (string identifierType, string identifier, UpdateInstrumentIdentifierRequest request)
        {
            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new ApiException(400, "Missing required parameter 'identifierType' when calling InstrumentsApi->UpdateInstrumentIdentifier");
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling InstrumentsApi->UpdateInstrumentIdentifier");
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling InstrumentsApi->UpdateInstrumentIdentifier");

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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.5.3180";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Instrument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Instrument)));
        }

        /// <summary>
        /// [EARLY ACCESS] Update instrument identifier Update, insert or delete a single instrument identifier for a single instrument. If it is not being deleted  the identifier will be updated if it already exists and inserted if it does not.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier to use to resolve the instrument e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The original value of the identifier for the requested instrument.</param>
        /// <param name="request">The identifier to update or remove. This may or may not be the same identifier used              to resolve the instrument.</param>
        /// <returns>Task of Instrument</returns>
        public async System.Threading.Tasks.Task<Instrument> UpdateInstrumentIdentifierAsync (string identifierType, string identifier, UpdateInstrumentIdentifierRequest request)
        {
             ApiResponse<Instrument> localVarResponse = await UpdateInstrumentIdentifierAsyncWithHttpInfo(identifierType, identifier, request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Update instrument identifier Update, insert or delete a single instrument identifier for a single instrument. If it is not being deleted  the identifier will be updated if it already exists and inserted if it does not.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The identifier to use to resolve the instrument e.g. \&quot;Figi\&quot;.</param>
        /// <param name="identifier">The original value of the identifier for the requested instrument.</param>
        /// <param name="request">The identifier to update or remove. This may or may not be the same identifier used              to resolve the instrument.</param>
        /// <returns>Task of ApiResponse (Instrument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Instrument>> UpdateInstrumentIdentifierAsyncWithHttpInfo (string identifierType, string identifier, UpdateInstrumentIdentifierRequest request)
        {
            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new ApiException(400, "Missing required parameter 'identifierType' when calling InstrumentsApi->UpdateInstrumentIdentifier");
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling InstrumentsApi->UpdateInstrumentIdentifier");
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling InstrumentsApi->UpdateInstrumentIdentifier");

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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.5.3180";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Instrument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Instrument)));
        }

        /// <summary>
        /// [EARLY ACCESS] Upsert instruments Update or insert one or more instruments into the LUSID instrument master. An instrument will be updated  if it already exists and inserted if it does not.                In the request each instrument definition should be keyed by a unique correlation id. This id is ephemeral  and is not stored by LUSID. It serves only as a way to easily identify each instrument in the response.                The response will return both the collection of successfully updated or inserted instruments, as well as those that failed.  For the failures a reason will be provided explaining why the instrument could not be updated or inserted.                It is important to always check the failed set for any unsuccessful results.  The maximum number of instruments that this method can upsert per request is 2,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requests">The definitions of the instruments to update or insert. (optional)</param>
        /// <returns>UpsertInstrumentsResponse</returns>
        public UpsertInstrumentsResponse UpsertInstruments (Dictionary<string, InstrumentDefinition> requests = null)
        {
             ApiResponse<UpsertInstrumentsResponse> localVarResponse = UpsertInstrumentsWithHttpInfo(requests);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Upsert instruments Update or insert one or more instruments into the LUSID instrument master. An instrument will be updated  if it already exists and inserted if it does not.                In the request each instrument definition should be keyed by a unique correlation id. This id is ephemeral  and is not stored by LUSID. It serves only as a way to easily identify each instrument in the response.                The response will return both the collection of successfully updated or inserted instruments, as well as those that failed.  For the failures a reason will be provided explaining why the instrument could not be updated or inserted.                It is important to always check the failed set for any unsuccessful results.  The maximum number of instruments that this method can upsert per request is 2,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requests">The definitions of the instruments to update or insert. (optional)</param>
        /// <returns>ApiResponse of UpsertInstrumentsResponse</returns>
        public ApiResponse< UpsertInstrumentsResponse > UpsertInstrumentsWithHttpInfo (Dictionary<string, InstrumentDefinition> requests = null)
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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.5.3180";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (UpsertInstrumentsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpsertInstrumentsResponse)));
        }

        /// <summary>
        /// [EARLY ACCESS] Upsert instruments Update or insert one or more instruments into the LUSID instrument master. An instrument will be updated  if it already exists and inserted if it does not.                In the request each instrument definition should be keyed by a unique correlation id. This id is ephemeral  and is not stored by LUSID. It serves only as a way to easily identify each instrument in the response.                The response will return both the collection of successfully updated or inserted instruments, as well as those that failed.  For the failures a reason will be provided explaining why the instrument could not be updated or inserted.                It is important to always check the failed set for any unsuccessful results.  The maximum number of instruments that this method can upsert per request is 2,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requests">The definitions of the instruments to update or insert. (optional)</param>
        /// <returns>Task of UpsertInstrumentsResponse</returns>
        public async System.Threading.Tasks.Task<UpsertInstrumentsResponse> UpsertInstrumentsAsync (Dictionary<string, InstrumentDefinition> requests = null)
        {
             ApiResponse<UpsertInstrumentsResponse> localVarResponse = await UpsertInstrumentsAsyncWithHttpInfo(requests);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Upsert instruments Update or insert one or more instruments into the LUSID instrument master. An instrument will be updated  if it already exists and inserted if it does not.                In the request each instrument definition should be keyed by a unique correlation id. This id is ephemeral  and is not stored by LUSID. It serves only as a way to easily identify each instrument in the response.                The response will return both the collection of successfully updated or inserted instruments, as well as those that failed.  For the failures a reason will be provided explaining why the instrument could not be updated or inserted.                It is important to always check the failed set for any unsuccessful results.  The maximum number of instruments that this method can upsert per request is 2,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requests">The definitions of the instruments to update or insert. (optional)</param>
        /// <returns>Task of ApiResponse (UpsertInstrumentsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UpsertInstrumentsResponse>> UpsertInstrumentsAsyncWithHttpInfo (Dictionary<string, InstrumentDefinition> requests = null)
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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.5.3180";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (UpsertInstrumentsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpsertInstrumentsResponse)));
        }

        /// <summary>
        /// [EARLY ACCESS] Upsert instruments properties Update or insert one or more instrument properties for one or more instruments. Each instrument property will be updated  if it already exists and inserted if it does not. If any properties fail to be updated or inserted, none will be updated or inserted and  the reason for the failure will be returned.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentProperties">A collection of instruments and associated instrument properties to update or insert.</param>
        /// <returns>UpsertInstrumentPropertiesResponse</returns>
        public UpsertInstrumentPropertiesResponse UpsertInstrumentsProperties (List<UpsertInstrumentPropertyRequest> instrumentProperties)
        {
             ApiResponse<UpsertInstrumentPropertiesResponse> localVarResponse = UpsertInstrumentsPropertiesWithHttpInfo(instrumentProperties);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Upsert instruments properties Update or insert one or more instrument properties for one or more instruments. Each instrument property will be updated  if it already exists and inserted if it does not. If any properties fail to be updated or inserted, none will be updated or inserted and  the reason for the failure will be returned.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentProperties">A collection of instruments and associated instrument properties to update or insert.</param>
        /// <returns>ApiResponse of UpsertInstrumentPropertiesResponse</returns>
        public ApiResponse< UpsertInstrumentPropertiesResponse > UpsertInstrumentsPropertiesWithHttpInfo (List<UpsertInstrumentPropertyRequest> instrumentProperties)
        {
            // verify the required parameter 'instrumentProperties' is set
            if (instrumentProperties == null)
                throw new ApiException(400, "Missing required parameter 'instrumentProperties' when calling InstrumentsApi->UpsertInstrumentsProperties");

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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.5.3180";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (UpsertInstrumentPropertiesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpsertInstrumentPropertiesResponse)));
        }

        /// <summary>
        /// [EARLY ACCESS] Upsert instruments properties Update or insert one or more instrument properties for one or more instruments. Each instrument property will be updated  if it already exists and inserted if it does not. If any properties fail to be updated or inserted, none will be updated or inserted and  the reason for the failure will be returned.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentProperties">A collection of instruments and associated instrument properties to update or insert.</param>
        /// <returns>Task of UpsertInstrumentPropertiesResponse</returns>
        public async System.Threading.Tasks.Task<UpsertInstrumentPropertiesResponse> UpsertInstrumentsPropertiesAsync (List<UpsertInstrumentPropertyRequest> instrumentProperties)
        {
             ApiResponse<UpsertInstrumentPropertiesResponse> localVarResponse = await UpsertInstrumentsPropertiesAsyncWithHttpInfo(instrumentProperties);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Upsert instruments properties Update or insert one or more instrument properties for one or more instruments. Each instrument property will be updated  if it already exists and inserted if it does not. If any properties fail to be updated or inserted, none will be updated or inserted and  the reason for the failure will be returned.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentProperties">A collection of instruments and associated instrument properties to update or insert.</param>
        /// <returns>Task of ApiResponse (UpsertInstrumentPropertiesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UpsertInstrumentPropertiesResponse>> UpsertInstrumentsPropertiesAsyncWithHttpInfo (List<UpsertInstrumentPropertyRequest> instrumentProperties)
        {
            // verify the required parameter 'instrumentProperties' is set
            if (instrumentProperties == null)
                throw new ApiException(400, "Missing required parameter 'instrumentProperties' when calling InstrumentsApi->UpsertInstrumentsProperties");

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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.5.3180";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (UpsertInstrumentPropertiesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpsertInstrumentPropertiesResponse)));
        }

    }
}