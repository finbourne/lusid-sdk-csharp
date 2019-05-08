/* 
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://api.lusid.com/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages :  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python)  # Data Model  The LUSID API has a relatively lightweight but extremely powerful data model.   One of the goals of LUSID was not to enforce on clients a single rigid data model but rather to provide a flexible foundation onto which clients can streamline their data.   One of the primary tools to extend the data model is through using properties.  Properties can be associated with amongst others: - * Transactions * Instruments * Portfolios   The LUSID data model is exposed through the LUSID APIs.  The APIs provide access to both business objects and the meta data used to configure the systems behaviours.   The key business entities are: - * **Portfolios** A portfolio is the primary container for transactions and holdings.  * **Derived Portfolios** Derived portfolios allow portfolios to be created based on other portfolios, by overriding or overlaying specific items * **Holdings** A holding is a position account for a instrument within a portfolio.  Holdings can only be adjusted via transactions. * **Transactions** A Transaction is a source of transactions used to manipulate holdings.  * **Corporate Actions** A corporate action is a market event which occurs to a instrument, for example a stock split * **Instruments**  A instrument represents a currency, tradable instrument or OTC contract that is attached to a transaction and a holding. * **Properties** Several entities allow additional user defined properties to be associated with them.   For example, a Portfolio manager may be associated with a portfolio  Meta data includes: - * **Transaction Types** Transactions are booked with a specific transaction type.  The types are client defined and are used to map the Transaction to a series of movements which update the portfolio holdings.  * **Properties Types** Types of user defined properties used within the system.  This section describes the data model that LUSID exposes via the APIs.  ## Scope  All data in LUSID is segregated at the client level.  Entities in LUSID are identifiable by a unique code.  Every entity lives within a logical data partition known as a Scope.  Scope is an identity namespace allowing two entities with the same unique code to co-exist within individual address spaces.  For example, prices for equities from different vendors may be uploaded into different scopes such as `client/vendor1` and `client/vendor2`.  A portfolio may then be valued using either of the price sources by referencing the appropriate scope.  LUSID Clients cannot access scopes of other clients.  ## Schema  A detailed description of the entities used by the API and parameters for endpoints which take a JSON document can be retrieved via the `schema` endpoint.  ## Instruments  LUSID has its own built-in instrument master which you can use to master your own instrument universe.  Every instrument must be created with one or more unique market identifiers, such as [FIGI](https://openfigi.com/) or RIC code. For any non-listed instruments (eg OTCs), you can upload an instrument against a custom ID of your choosing.  In addition, LUSID will allocate each instrument a unique 'LUSID instrument identifier'. The LUSID instrument identifier is what is used when uploading transactions, holdings, prices, etc. The API exposes an `instrument/lookup` endpoint which can be used to lookup these LUSID identifiers using their market identifiers.  Cash can be referenced using the ISO currency code prefixed with \"`CCY_`\" e.g. `CCY_GBP`  ## Instrument Prices (Analytics)  Instrument prices are stored in LUSID's Analytics Store  | Field|Type|Description | | - --|- --|- -- | | InstrumentUid|string|Unique instrument identifier | | Value|decimal|Value of the analytic, eg price | | Denomination|string|Underlying unit of the analytic, eg currency, EPS etc. |   ## Instrument Data  Instrument data can be uploaded to the system using the [Instrument Properties](#tag/InstrumentProperties) endpoint.  | Field|Type|Description | | - --|- --|- -- |   ## Portfolios  Portfolios are the top-level entity containers within LUSID, containing transactions, corporate actions and holdings.    The transactions build up the portfolio holdings on which valuations, analytics profit & loss and risk can be calculated.     Properties can be associated with Portfolios to add in additional model data.  Portfolio properties can be changed over time as well.  For example, to allow a Portfolio Manager to be linked with a Portfolio.  Additionally, portfolios can be securitised and held by other portfolios, allowing LUSID to perform \"drill-through\" into underlying fund holdings  ### Reference Portfolios Reference portfolios are portfolios that contain only weights, as opposed to transactions, and are designed to represent entities such as indices.  ### Derived Portfolios  LUSID also allows for a portfolio to be composed of another portfolio via derived portfolios.  A derived portfolio can contain its own transactions and also inherits any transactions from its parent portfolio.  Any changes made to the parent portfolio are automatically reflected in derived portfolio.  Derived portfolios in conjunction with scopes are a powerful construct.  For example, to do pre-trade what-if analysis, a derived portfolio could be created a new namespace linked to the underlying live (parent) portfolio.  Analysis can then be undertaken on the derived portfolio without affecting the live portfolio.  ### Portfolio Groups Portfolio groups allow the construction of a hierarchy from portfolios and groups.  Portfolio operations on the group are executed on an aggregated set of portfolios in the hierarchy.   For example:   * Global Portfolios _(group)_   * APAC _(group)_     * Hong Kong _(portfolio)_     * Japan _(portfolio)_   * Europe _(group)_     * France _(portfolio)_     * Germany _(portfolio)_   * UK _(portfolio)_   In this example **Global Portfolios** is a group that consists of an aggregate of **Hong Kong**, **Japan**, **France**, **Germany** and **UK** portfolios.  ### Movements Engine The Movements engine sits on top of the immutable event store and is used to manage the relationship between input trading actions and their associated portfolio holdings.     The movements engine reads in the following entity types:- * Posting Transactions * Applying Corporate Actions  * Holding Adjustments  These are converted to one or more movements and used by the movements engine to calculate holdings.  At the same time it also calculates running balances, and realised P&L.  The outputs from the movements engine are holdings and transactions.  ## Transactions  A transaction represents an economic activity against a Portfolio.  Transactions are processed according to a configuration. This will tell the LUSID engine how to interpret the transaction and correctly update the holdings. LUSID comes with a set of transaction types you can use out of the box, or you can configure your own set(s) of transactions.  For more details see the [LUSID Getting Started Guide for transaction configuration.](https://support.finbourne.com/hc/en-us/articles/360016737511-Configuring-Transaction-Types)  | Field|Type|Description | | - --|- --|- -- | | TransactionId|string|Unique transaction identifier | | Type|string|LUSID transaction type code - Buy, Sell, StockIn, StockOut, etc | | InstrumentIdentifiers|IReadOnlyDictionary`2|Unique instrument identifiers. | | InstrumentUid|string|Unique instrument identifier | | TransactionDate|datetime|Transaction date | | SettlementDate|datetime|Settlement date | | Units|decimal|Quantity of transaction in units of the instrument | | TransactionPrice|tradeprice|Execution price for the transaction | | TotalConsideration|currencyandamount|Total value of the transaction in settlement currency | | ExchangeRate|decimal|Rate between transaction and settle currency | | TransactionCurrency|currency|Transaction currency | | CounterpartyId|string|Counterparty identifier | | Source|string|Where this transaction came from | | NettingSet|string|  |   From these fields, the following values can be calculated  * **Transaction value in Transaction currency**: TotalConsideration / ExchangeRate  * **Transaction value in Portfolio currency**: Transaction value in Transaction currency * TradeToPortfolioRate  ### Example Transactions  #### A Common Purchase Example Three example transactions are shown in the table below.   They represent a purchase of USD denominated IBM shares within a Sterling denominated portfolio.   * The first two transactions are for separate buy and fx trades    * Buying 500 IBM shares for $71,480.00    * A foreign exchange conversion to fund the IBM purchase. (Buy $71,480.00 for &#163;54,846.60)  * The third transaction is an alternate version of the above trades. Buying 500 IBM shares and settling directly in Sterling.  | Column |  Buy Trade | Fx Trade | Buy Trade with foreign Settlement | | - -- -- | - -- -- | - -- -- | - -- -- | | TransactionId | FBN00001 | FBN00002 | FBN00003 | | Type | Buy | FxBuy | Buy | | InstrumentUid | FIGI_BBG000BLNNH6 | CCY_USD | FIGI_BBG000BLNNH6 | | TransactionDate | 2018-08-02 | 2018-08-02 | 2018-08-02 | | SettlementDate | 2018-08-06 | 2018-08-06 | 2018-08-06 | | Units | 500 | 71480 | 500 | | TransactionPrice | 142.96 | 1 | 142.96 | | TradeCurrency | USD | USD | USD | | ExchangeRate | 1 | 0.7673 | 0.7673 | | TotalConsideration.Amount | 71480.00 | 54846.60 | 54846.60 | | TotalConsideration.Currency | USD | GBP | GBP | | Trade/default/TradeToPortfolioRate&ast; | 0.7673 | 0.7673 | 0.7673 |  [&ast; This is a property field]  #### A Forward FX Example  LUSID has a flexible transaction modelling system, and there are a number of different ways of modelling forward fx trades.  The default LUSID transaction types are FwdFxBuy and FwdFxSell. Other types and behaviours can be configured as required.  Using these transaction types, the holdings query will report two forward positions. One in each currency.   Since an FX trade is an exchange of one currency for another, the following two 6 month forward transactions are equivalent:  | Column |  Forward 'Sell' Trade | Forward 'Buy' Trade | | - -- -- | - -- -- | - -- -- | | TransactionId | FBN00004 | FBN00005 | | Type | FwdFxSell | FwdFxBuy | | InstrumentUid | CCY_GBP | CCY_USD | | TransactionDate | 2018-08-02 | 2018-08-02 | | SettlementDate | 2019-02-06 | 2019-02-06 | | Units | 10000.00 | 13142.00 | | TransactionPrice |1 | 1 | | TradeCurrency | GBP | USD | | ExchangeRate | 1.3142 | 0.760919 | | TotalConsideration.Amount | 13142.00 | 10000.00 | | TotalConsideration.Currency | USD | GBP | | Trade/default/TradeToPortfolioRate | 1.0 | 0.760919 |  ## Holdings  A holding represents a position in a instrument or cash on a given date.  | Field|Type|Description | | - --|- --|- -- | | InstrumentUid|string|Unique instrument identifier | | HoldingType|string|Type of holding, eg Position, Balance, CashCommitment, Receivable, ForwardFX | | Units|decimal|Quantity of holding | | SettledUnits|decimal|Settled quantity of holding | | Cost|currencyandamount|Book cost of holding in transaction currency | | CostPortfolioCcy|currencyandamount|Book cost of holding in portfolio currency | | Transaction|Transaction|If this is commitment-type holding, the transaction behind it |   ## Corporate Actions  Corporate actions are represented within LUSID in terms of a set of instrument-specific 'transitions'.  These transitions are used to specify the participants of the corporate action, and the effect that the corporate action will have on holdings in those participants.  *Corporate action*  | Field|Type|Description | | - --|- --|- -- | | SourceId|id|  | | CorporateActionCode|code|  | | AnnouncementDate|datetime|  | | ExDate|datetime|  | | RecordDate|datetime|  | | PaymentDate|datetime|  |    *Transition*  | Field|Type|Description | | - --|- --|- -- |   ## Property  Properties are key-value pairs that can be applied to any entity within a domain (where a domain is `trade`, `portfolio`, `security` etc).  Properties must be defined before use with a `PropertyDefinition` and can then subsequently be added to entities.  # Schemas  The following headers are returned on all responses from LUSID  | Name | Purpose | | - -- | - -- | | lusid-meta-duration | Duration of the request | | lusid-meta-success | Whether or not LUSID considered the request to be successful | | lusid-meta-requestId | The unique identifier for the request | | lusid-schema-url | Url of the schema for the data being returned | | lusid-property-schema-url | Url of the schema for any properties |   # Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"102\">102</a>|VersionNotFound|  | | <a name=\"104\">104</a>|InstrumentNotFound|  | | <a name=\"105\">105</a>|PropertyNotFound|  | | <a name=\"106\">106</a>|PortfolioRecursionDepth|  | | <a name=\"108\">108</a>|GroupNotFound|  | | <a name=\"109\">109</a>|PortfolioNotFound|  | | <a name=\"110\">110</a>|PropertySchemaNotFound|  | | <a name=\"111\">111</a>|PortfolioAncestryNotFound|  | | <a name=\"112\">112</a>|PortfolioWithIdAlreadyExists|  | | <a name=\"113\">113</a>|OrphanedPortfolio|  | | <a name=\"119\">119</a>|MissingBaseClaims|  | | <a name=\"121\">121</a>|PropertyNotDefined|  | | <a name=\"122\">122</a>|CannotDeleteSystemProperty|  | | <a name=\"123\">123</a>|CannotModifyImmutablePropertyField|  | | <a name=\"124\">124</a>|PropertyAlreadyExists|  | | <a name=\"125\">125</a>|InvalidPropertyLifeTime|  | | <a name=\"127\">127</a>|CannotModifyDefaultDataType|  | | <a name=\"128\">128</a>|GroupAlreadyExists|  | | <a name=\"129\">129</a>|NoSuchDataType|  | | <a name=\"132\">132</a>|ValidationError|  | | <a name=\"133\">133</a>|LoopDetectedInGroupHierarchy|  | | <a name=\"135\">135</a>|SubGroupAlreadyExists|  | | <a name=\"138\">138</a>|PriceSourceNotFound|  | | <a name=\"139\">139</a>|AnalyticStoreNotFound|  | | <a name=\"141\">141</a>|AnalyticStoreAlreadyExists|  | | <a name=\"143\">143</a>|ClientInstrumentAlreadyExists|  | | <a name=\"144\">144</a>|DuplicateInParameterSet|  | | <a name=\"147\">147</a>|ResultsNotFound|  | | <a name=\"148\">148</a>|OrderFieldNotInResultSet|  | | <a name=\"149\">149</a>|OperationFailed|  | | <a name=\"150\">150</a>|ElasticSearchError|  | | <a name=\"151\">151</a>|InvalidParameterValue|  | | <a name=\"153\">153</a>|CommandProcessingFailure|  | | <a name=\"154\">154</a>|EntityStateConstructionFailure|  | | <a name=\"155\">155</a>|EntityTimelineDoesNotExist|  | | <a name=\"156\">156</a>|EventPublishFailure|  | | <a name=\"157\">157</a>|InvalidRequestFailure|  | | <a name=\"158\">158</a>|EventPublishUnknown|  | | <a name=\"159\">159</a>|EventQueryFailure|  | | <a name=\"160\">160</a>|BlobDidNotExistFailure|  | | <a name=\"162\">162</a>|SubSystemRequestFailure|  | | <a name=\"163\">163</a>|SubSystemConfigurationFailure|  | | <a name=\"165\">165</a>|FailedToDelete|  | | <a name=\"166\">166</a>|UpsertClientInstrumentFailure|  | | <a name=\"167\">167</a>|IllegalAsAtInterval|  | | <a name=\"168\">168</a>|IllegalBitemporalQuery|  | | <a name=\"169\">169</a>|InvalidAlternateId|  | | <a name=\"170\">170</a>|CannotAddSourcePortfolioPropertyExplicitly|  | | <a name=\"171\">171</a>|EntityAlreadyExistsInGroup|  | | <a name=\"173\">173</a>|EntityWithIdAlreadyExists|  | | <a name=\"174\">174</a>|DerivedPortfolioDetailsDoNotExist|  | | <a name=\"176\">176</a>|PortfolioWithNameAlreadyExists|  | | <a name=\"177\">177</a>|InvalidTransactions|  | | <a name=\"178\">178</a>|ReferencePortfolioNotFound|  | | <a name=\"179\">179</a>|DuplicateIdFailure|  | | <a name=\"180\">180</a>|CommandRetrievalFailure|  | | <a name=\"181\">181</a>|DataFilterApplicationFailure|  | | <a name=\"182\">182</a>|SearchFailed|  | | <a name=\"183\">183</a>|MovementsEngineConfigurationKeyFailure|  | | <a name=\"184\">184</a>|FxRateSourceNotFound|  | | <a name=\"185\">185</a>|AccrualSourceNotFound|  | | <a name=\"186\">186</a>|AccessDenied|  | | <a name=\"187\">187</a>|InvalidIdentityToken|  | | <a name=\"188\">188</a>|InvalidRequestHeaders|  | | <a name=\"189\">189</a>|PriceNotFound|  | | <a name=\"190\">190</a>|InvalidSubHoldingKeysProvided|  | | <a name=\"191\">191</a>|DuplicateSubHoldingKeysProvided|  | | <a name=\"192\">192</a>|CutDefinitionNotFound|  | | <a name=\"193\">193</a>|CutDefinitionInvalid|  | | <a name=\"200\">200</a>|InvalidUnitForDataType|  | | <a name=\"201\">201</a>|InvalidTypeForDataType|  | | <a name=\"202\">202</a>|InvalidValueForDataType|  | | <a name=\"203\">203</a>|UnitNotDefinedForDataType|  | | <a name=\"204\">204</a>|UnitsNotSupportedOnDataType|  | | <a name=\"205\">205</a>|CannotSpecifyUnitsOnDataType|  | | <a name=\"206\">206</a>|UnitSchemaInconsistentWithDataType|  | | <a name=\"207\">207</a>|UnitDefinitionNotSpecified|  | | <a name=\"208\">208</a>|DuplicateUnitDefinitionsSpecified|  | | <a name=\"209\">209</a>|InvalidUnitsDefinition|  | | <a name=\"210\">210</a>|InvalidInstrumentIdentifierUnit|  | | <a name=\"211\">211</a>|HoldingsAdjustmentDoesNotExist|  | | <a name=\"212\">212</a>|CouldNotBuildExcelUrl|  | | <a name=\"213\">213</a>|CouldNotGetExcelVersion|  | | <a name=\"214\">214</a>|InstrumentByCodeNotFound|  | | <a name=\"215\">215</a>|EntitySchemaDoesNotExist|  | | <a name=\"216\">216</a>|FeatureNotSupportedOnPortfolioType|  | | <a name=\"217\">217</a>|QuoteNotFoundFailure|  | | <a name=\"219\">219</a>|InvalidInstrumentDefinition|  | | <a name=\"221\">221</a>|InstrumentUpsertFailure|  | | <a name=\"222\">222</a>|ReferencePortfolioRequestNotSupported|  | | <a name=\"223\">223</a>|TransactionPortfolioRequestNotSupported|  | | <a name=\"224\">224</a>|InvalidPropertyValueAssignment|  | | <a name=\"230\">230</a>|TransactionTypeNotFound|  | | <a name=\"231\">231</a>|TransactionTypeDuplication|  | | <a name=\"232\">232</a>|PortfolioDoesNotExistAtGivenDate|  | | <a name=\"233\">233</a>|QueryParserFailure|  | | <a name=\"234\">234</a>|DuplicateConstituentFailure|  | | <a name=\"235\">235</a>|UnresolvedInstrumentConstituentFailure|  | | <a name=\"236\">236</a>|UnresolvedInstrumentInTransitionFailure|  | | <a name=\"300\">300</a>|MissingRecipeFailure|  | | <a name=\"301\">301</a>|DependenciesFailure|  | | <a name=\"304\">304</a>|PortfolioPreprocessFailure|  | | <a name=\"310\">310</a>|ValuationEngineFailure|  | | <a name=\"311\">311</a>|TaskFactoryFailure|  | | <a name=\"312\">312</a>|TaskEvaluationFailure|  | | <a name=\"350\">350</a>|InstrumentFailure|  | | <a name=\"351\">351</a>|CashFlowsFailure|  | | <a name=\"360\">360</a>|AggregationFailure|  | | <a name=\"370\">370</a>|ResultRetrievalFailure|  | | <a name=\"371\">371</a>|ResultProcessingFailure|  | | <a name=\"372\">372</a>|VendorResultProcessingFailure|  | | <a name=\"374\">374</a>|AttemptToUpsertDuplicateQuotes|  | | <a name=\"375\">375</a>|CorporateActionSourceDoesNotExist|  | | <a name=\"376\">376</a>|InstrumentIdentifierAlreadyInUse|  | | <a name=\"-10\">-10</a>|ServerConfigurationError|  | | <a name=\"-1\">-1</a>|Unknown error|  | 
 *
 * OpenAPI spec version: 0.5.2578
 * Contact: info@finbourne.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Lusid.Sdk.Client.SwaggerDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// ErrorResponse
    /// </summary>
    [DataContract]
    public partial class ErrorResponse :  IEquatable<ErrorResponse>
    {
        /// <summary>
        /// Defines Code
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,
            
            /// <summary>
            /// Enum VersionNotFound for value: VersionNotFound
            /// </summary>
            [EnumMember(Value = "VersionNotFound")]
            VersionNotFound = 2,
            
            /// <summary>
            /// Enum InstrumentNotFound for value: InstrumentNotFound
            /// </summary>
            [EnumMember(Value = "InstrumentNotFound")]
            InstrumentNotFound = 3,
            
            /// <summary>
            /// Enum PropertyNotFound for value: PropertyNotFound
            /// </summary>
            [EnumMember(Value = "PropertyNotFound")]
            PropertyNotFound = 4,
            
            /// <summary>
            /// Enum PortfolioRecursionDepth for value: PortfolioRecursionDepth
            /// </summary>
            [EnumMember(Value = "PortfolioRecursionDepth")]
            PortfolioRecursionDepth = 5,
            
            /// <summary>
            /// Enum GroupNotFound for value: GroupNotFound
            /// </summary>
            [EnumMember(Value = "GroupNotFound")]
            GroupNotFound = 6,
            
            /// <summary>
            /// Enum PortfolioNotFound for value: PortfolioNotFound
            /// </summary>
            [EnumMember(Value = "PortfolioNotFound")]
            PortfolioNotFound = 7,
            
            /// <summary>
            /// Enum PropertySchemaNotFound for value: PropertySchemaNotFound
            /// </summary>
            [EnumMember(Value = "PropertySchemaNotFound")]
            PropertySchemaNotFound = 8,
            
            /// <summary>
            /// Enum PortfolioAncestryNotFound for value: PortfolioAncestryNotFound
            /// </summary>
            [EnumMember(Value = "PortfolioAncestryNotFound")]
            PortfolioAncestryNotFound = 9,
            
            /// <summary>
            /// Enum PortfolioWithIdAlreadyExists for value: PortfolioWithIdAlreadyExists
            /// </summary>
            [EnumMember(Value = "PortfolioWithIdAlreadyExists")]
            PortfolioWithIdAlreadyExists = 10,
            
            /// <summary>
            /// Enum OrphanedPortfolio for value: OrphanedPortfolio
            /// </summary>
            [EnumMember(Value = "OrphanedPortfolio")]
            OrphanedPortfolio = 11,
            
            /// <summary>
            /// Enum MissingBaseClaims for value: MissingBaseClaims
            /// </summary>
            [EnumMember(Value = "MissingBaseClaims")]
            MissingBaseClaims = 12,
            
            /// <summary>
            /// Enum PropertyNotDefined for value: PropertyNotDefined
            /// </summary>
            [EnumMember(Value = "PropertyNotDefined")]
            PropertyNotDefined = 13,
            
            /// <summary>
            /// Enum CannotDeleteSystemProperty for value: CannotDeleteSystemProperty
            /// </summary>
            [EnumMember(Value = "CannotDeleteSystemProperty")]
            CannotDeleteSystemProperty = 14,
            
            /// <summary>
            /// Enum CannotModifyImmutablePropertyField for value: CannotModifyImmutablePropertyField
            /// </summary>
            [EnumMember(Value = "CannotModifyImmutablePropertyField")]
            CannotModifyImmutablePropertyField = 15,
            
            /// <summary>
            /// Enum PropertyAlreadyExists for value: PropertyAlreadyExists
            /// </summary>
            [EnumMember(Value = "PropertyAlreadyExists")]
            PropertyAlreadyExists = 16,
            
            /// <summary>
            /// Enum InvalidPropertyLifeTime for value: InvalidPropertyLifeTime
            /// </summary>
            [EnumMember(Value = "InvalidPropertyLifeTime")]
            InvalidPropertyLifeTime = 17,
            
            /// <summary>
            /// Enum CannotModifyDefaultDataType for value: CannotModifyDefaultDataType
            /// </summary>
            [EnumMember(Value = "CannotModifyDefaultDataType")]
            CannotModifyDefaultDataType = 18,
            
            /// <summary>
            /// Enum GroupAlreadyExists for value: GroupAlreadyExists
            /// </summary>
            [EnumMember(Value = "GroupAlreadyExists")]
            GroupAlreadyExists = 19,
            
            /// <summary>
            /// Enum NoSuchDataType for value: NoSuchDataType
            /// </summary>
            [EnumMember(Value = "NoSuchDataType")]
            NoSuchDataType = 20,
            
            /// <summary>
            /// Enum ValidationError for value: ValidationError
            /// </summary>
            [EnumMember(Value = "ValidationError")]
            ValidationError = 21,
            
            /// <summary>
            /// Enum LoopDetectedInGroupHierarchy for value: LoopDetectedInGroupHierarchy
            /// </summary>
            [EnumMember(Value = "LoopDetectedInGroupHierarchy")]
            LoopDetectedInGroupHierarchy = 22,
            
            /// <summary>
            /// Enum SubGroupAlreadyExists for value: SubGroupAlreadyExists
            /// </summary>
            [EnumMember(Value = "SubGroupAlreadyExists")]
            SubGroupAlreadyExists = 23,
            
            /// <summary>
            /// Enum PriceSourceNotFound for value: PriceSourceNotFound
            /// </summary>
            [EnumMember(Value = "PriceSourceNotFound")]
            PriceSourceNotFound = 24,
            
            /// <summary>
            /// Enum AnalyticStoreNotFound for value: AnalyticStoreNotFound
            /// </summary>
            [EnumMember(Value = "AnalyticStoreNotFound")]
            AnalyticStoreNotFound = 25,
            
            /// <summary>
            /// Enum AnalyticStoreAlreadyExists for value: AnalyticStoreAlreadyExists
            /// </summary>
            [EnumMember(Value = "AnalyticStoreAlreadyExists")]
            AnalyticStoreAlreadyExists = 26,
            
            /// <summary>
            /// Enum ClientInstrumentAlreadyExists for value: ClientInstrumentAlreadyExists
            /// </summary>
            [EnumMember(Value = "ClientInstrumentAlreadyExists")]
            ClientInstrumentAlreadyExists = 27,
            
            /// <summary>
            /// Enum DuplicateInParameterSet for value: DuplicateInParameterSet
            /// </summary>
            [EnumMember(Value = "DuplicateInParameterSet")]
            DuplicateInParameterSet = 28,
            
            /// <summary>
            /// Enum ResultsNotFound for value: ResultsNotFound
            /// </summary>
            [EnumMember(Value = "ResultsNotFound")]
            ResultsNotFound = 29,
            
            /// <summary>
            /// Enum OrderFieldNotInResultSet for value: OrderFieldNotInResultSet
            /// </summary>
            [EnumMember(Value = "OrderFieldNotInResultSet")]
            OrderFieldNotInResultSet = 30,
            
            /// <summary>
            /// Enum OperationFailed for value: OperationFailed
            /// </summary>
            [EnumMember(Value = "OperationFailed")]
            OperationFailed = 31,
            
            /// <summary>
            /// Enum ElasticSearchError for value: ElasticSearchError
            /// </summary>
            [EnumMember(Value = "ElasticSearchError")]
            ElasticSearchError = 32,
            
            /// <summary>
            /// Enum InvalidParameterValue for value: InvalidParameterValue
            /// </summary>
            [EnumMember(Value = "InvalidParameterValue")]
            InvalidParameterValue = 33,
            
            /// <summary>
            /// Enum CommandProcessingFailure for value: CommandProcessingFailure
            /// </summary>
            [EnumMember(Value = "CommandProcessingFailure")]
            CommandProcessingFailure = 34,
            
            /// <summary>
            /// Enum EntityStateConstructionFailure for value: EntityStateConstructionFailure
            /// </summary>
            [EnumMember(Value = "EntityStateConstructionFailure")]
            EntityStateConstructionFailure = 35,
            
            /// <summary>
            /// Enum EntityTimelineDoesNotExist for value: EntityTimelineDoesNotExist
            /// </summary>
            [EnumMember(Value = "EntityTimelineDoesNotExist")]
            EntityTimelineDoesNotExist = 36,
            
            /// <summary>
            /// Enum EventPublishFailure for value: EventPublishFailure
            /// </summary>
            [EnumMember(Value = "EventPublishFailure")]
            EventPublishFailure = 37,
            
            /// <summary>
            /// Enum InvalidRequestFailure for value: InvalidRequestFailure
            /// </summary>
            [EnumMember(Value = "InvalidRequestFailure")]
            InvalidRequestFailure = 38,
            
            /// <summary>
            /// Enum EventPublishUnknown for value: EventPublishUnknown
            /// </summary>
            [EnumMember(Value = "EventPublishUnknown")]
            EventPublishUnknown = 39,
            
            /// <summary>
            /// Enum EventQueryFailure for value: EventQueryFailure
            /// </summary>
            [EnumMember(Value = "EventQueryFailure")]
            EventQueryFailure = 40,
            
            /// <summary>
            /// Enum BlobDidNotExistFailure for value: BlobDidNotExistFailure
            /// </summary>
            [EnumMember(Value = "BlobDidNotExistFailure")]
            BlobDidNotExistFailure = 41,
            
            /// <summary>
            /// Enum SubSystemRequestFailure for value: SubSystemRequestFailure
            /// </summary>
            [EnumMember(Value = "SubSystemRequestFailure")]
            SubSystemRequestFailure = 42,
            
            /// <summary>
            /// Enum SubSystemConfigurationFailure for value: SubSystemConfigurationFailure
            /// </summary>
            [EnumMember(Value = "SubSystemConfigurationFailure")]
            SubSystemConfigurationFailure = 43,
            
            /// <summary>
            /// Enum FailedToDelete for value: FailedToDelete
            /// </summary>
            [EnumMember(Value = "FailedToDelete")]
            FailedToDelete = 44,
            
            /// <summary>
            /// Enum UpsertClientInstrumentFailure for value: UpsertClientInstrumentFailure
            /// </summary>
            [EnumMember(Value = "UpsertClientInstrumentFailure")]
            UpsertClientInstrumentFailure = 45,
            
            /// <summary>
            /// Enum IllegalAsAtInterval for value: IllegalAsAtInterval
            /// </summary>
            [EnumMember(Value = "IllegalAsAtInterval")]
            IllegalAsAtInterval = 46,
            
            /// <summary>
            /// Enum IllegalBitemporalQuery for value: IllegalBitemporalQuery
            /// </summary>
            [EnumMember(Value = "IllegalBitemporalQuery")]
            IllegalBitemporalQuery = 47,
            
            /// <summary>
            /// Enum InvalidAlternateId for value: InvalidAlternateId
            /// </summary>
            [EnumMember(Value = "InvalidAlternateId")]
            InvalidAlternateId = 48,
            
            /// <summary>
            /// Enum CannotAddSourcePortfolioPropertyExplicitly for value: CannotAddSourcePortfolioPropertyExplicitly
            /// </summary>
            [EnumMember(Value = "CannotAddSourcePortfolioPropertyExplicitly")]
            CannotAddSourcePortfolioPropertyExplicitly = 49,
            
            /// <summary>
            /// Enum EntityAlreadyExistsInGroup for value: EntityAlreadyExistsInGroup
            /// </summary>
            [EnumMember(Value = "EntityAlreadyExistsInGroup")]
            EntityAlreadyExistsInGroup = 50,
            
            /// <summary>
            /// Enum EntityWithIdAlreadyExists for value: EntityWithIdAlreadyExists
            /// </summary>
            [EnumMember(Value = "EntityWithIdAlreadyExists")]
            EntityWithIdAlreadyExists = 51,
            
            /// <summary>
            /// Enum DerivedPortfolioDetailsDoNotExist for value: DerivedPortfolioDetailsDoNotExist
            /// </summary>
            [EnumMember(Value = "DerivedPortfolioDetailsDoNotExist")]
            DerivedPortfolioDetailsDoNotExist = 52,
            
            /// <summary>
            /// Enum PortfolioWithNameAlreadyExists for value: PortfolioWithNameAlreadyExists
            /// </summary>
            [EnumMember(Value = "PortfolioWithNameAlreadyExists")]
            PortfolioWithNameAlreadyExists = 53,
            
            /// <summary>
            /// Enum InvalidTransactions for value: InvalidTransactions
            /// </summary>
            [EnumMember(Value = "InvalidTransactions")]
            InvalidTransactions = 54,
            
            /// <summary>
            /// Enum ReferencePortfolioNotFound for value: ReferencePortfolioNotFound
            /// </summary>
            [EnumMember(Value = "ReferencePortfolioNotFound")]
            ReferencePortfolioNotFound = 55,
            
            /// <summary>
            /// Enum DuplicateIdFailure for value: DuplicateIdFailure
            /// </summary>
            [EnumMember(Value = "DuplicateIdFailure")]
            DuplicateIdFailure = 56,
            
            /// <summary>
            /// Enum CommandRetrievalFailure for value: CommandRetrievalFailure
            /// </summary>
            [EnumMember(Value = "CommandRetrievalFailure")]
            CommandRetrievalFailure = 57,
            
            /// <summary>
            /// Enum DataFilterApplicationFailure for value: DataFilterApplicationFailure
            /// </summary>
            [EnumMember(Value = "DataFilterApplicationFailure")]
            DataFilterApplicationFailure = 58,
            
            /// <summary>
            /// Enum SearchFailed for value: SearchFailed
            /// </summary>
            [EnumMember(Value = "SearchFailed")]
            SearchFailed = 59,
            
            /// <summary>
            /// Enum MovementsEngineConfigurationKeyFailure for value: MovementsEngineConfigurationKeyFailure
            /// </summary>
            [EnumMember(Value = "MovementsEngineConfigurationKeyFailure")]
            MovementsEngineConfigurationKeyFailure = 60,
            
            /// <summary>
            /// Enum FxRateSourceNotFound for value: FxRateSourceNotFound
            /// </summary>
            [EnumMember(Value = "FxRateSourceNotFound")]
            FxRateSourceNotFound = 61,
            
            /// <summary>
            /// Enum AccrualSourceNotFound for value: AccrualSourceNotFound
            /// </summary>
            [EnumMember(Value = "AccrualSourceNotFound")]
            AccrualSourceNotFound = 62,
            
            /// <summary>
            /// Enum AccessDenied for value: AccessDenied
            /// </summary>
            [EnumMember(Value = "AccessDenied")]
            AccessDenied = 63,
            
            /// <summary>
            /// Enum InvalidIdentityToken for value: InvalidIdentityToken
            /// </summary>
            [EnumMember(Value = "InvalidIdentityToken")]
            InvalidIdentityToken = 64,
            
            /// <summary>
            /// Enum InvalidRequestHeaders for value: InvalidRequestHeaders
            /// </summary>
            [EnumMember(Value = "InvalidRequestHeaders")]
            InvalidRequestHeaders = 65,
            
            /// <summary>
            /// Enum PriceNotFound for value: PriceNotFound
            /// </summary>
            [EnumMember(Value = "PriceNotFound")]
            PriceNotFound = 66,
            
            /// <summary>
            /// Enum InvalidSubHoldingKeysProvided for value: InvalidSubHoldingKeysProvided
            /// </summary>
            [EnumMember(Value = "InvalidSubHoldingKeysProvided")]
            InvalidSubHoldingKeysProvided = 67,
            
            /// <summary>
            /// Enum DuplicateSubHoldingKeysProvided for value: DuplicateSubHoldingKeysProvided
            /// </summary>
            [EnumMember(Value = "DuplicateSubHoldingKeysProvided")]
            DuplicateSubHoldingKeysProvided = 68,
            
            /// <summary>
            /// Enum CutDefinitionNotFound for value: CutDefinitionNotFound
            /// </summary>
            [EnumMember(Value = "CutDefinitionNotFound")]
            CutDefinitionNotFound = 69,
            
            /// <summary>
            /// Enum CutDefinitionInvalid for value: CutDefinitionInvalid
            /// </summary>
            [EnumMember(Value = "CutDefinitionInvalid")]
            CutDefinitionInvalid = 70,
            
            /// <summary>
            /// Enum ServerConfigurationError for value: ServerConfigurationError
            /// </summary>
            [EnumMember(Value = "ServerConfigurationError")]
            ServerConfigurationError = 71,
            
            /// <summary>
            /// Enum InvalidUnitForDataType for value: InvalidUnitForDataType
            /// </summary>
            [EnumMember(Value = "InvalidUnitForDataType")]
            InvalidUnitForDataType = 72,
            
            /// <summary>
            /// Enum InvalidTypeForDataType for value: InvalidTypeForDataType
            /// </summary>
            [EnumMember(Value = "InvalidTypeForDataType")]
            InvalidTypeForDataType = 73,
            
            /// <summary>
            /// Enum InvalidValueForDataType for value: InvalidValueForDataType
            /// </summary>
            [EnumMember(Value = "InvalidValueForDataType")]
            InvalidValueForDataType = 74,
            
            /// <summary>
            /// Enum UnitNotDefinedForDataType for value: UnitNotDefinedForDataType
            /// </summary>
            [EnumMember(Value = "UnitNotDefinedForDataType")]
            UnitNotDefinedForDataType = 75,
            
            /// <summary>
            /// Enum UnitsNotSupportedOnDataType for value: UnitsNotSupportedOnDataType
            /// </summary>
            [EnumMember(Value = "UnitsNotSupportedOnDataType")]
            UnitsNotSupportedOnDataType = 76,
            
            /// <summary>
            /// Enum CannotSpecifyUnitsOnDataType for value: CannotSpecifyUnitsOnDataType
            /// </summary>
            [EnumMember(Value = "CannotSpecifyUnitsOnDataType")]
            CannotSpecifyUnitsOnDataType = 77,
            
            /// <summary>
            /// Enum UnitSchemaInconsistentWithDataType for value: UnitSchemaInconsistentWithDataType
            /// </summary>
            [EnumMember(Value = "UnitSchemaInconsistentWithDataType")]
            UnitSchemaInconsistentWithDataType = 78,
            
            /// <summary>
            /// Enum UnitDefinitionNotSpecified for value: UnitDefinitionNotSpecified
            /// </summary>
            [EnumMember(Value = "UnitDefinitionNotSpecified")]
            UnitDefinitionNotSpecified = 79,
            
            /// <summary>
            /// Enum DuplicateUnitDefinitionsSpecified for value: DuplicateUnitDefinitionsSpecified
            /// </summary>
            [EnumMember(Value = "DuplicateUnitDefinitionsSpecified")]
            DuplicateUnitDefinitionsSpecified = 80,
            
            /// <summary>
            /// Enum InvalidUnitsDefinition for value: InvalidUnitsDefinition
            /// </summary>
            [EnumMember(Value = "InvalidUnitsDefinition")]
            InvalidUnitsDefinition = 81,
            
            /// <summary>
            /// Enum InvalidInstrumentIdentifierUnit for value: InvalidInstrumentIdentifierUnit
            /// </summary>
            [EnumMember(Value = "InvalidInstrumentIdentifierUnit")]
            InvalidInstrumentIdentifierUnit = 82,
            
            /// <summary>
            /// Enum HoldingsAdjustmentDoesNotExist for value: HoldingsAdjustmentDoesNotExist
            /// </summary>
            [EnumMember(Value = "HoldingsAdjustmentDoesNotExist")]
            HoldingsAdjustmentDoesNotExist = 83,
            
            /// <summary>
            /// Enum CouldNotBuildExcelUrl for value: CouldNotBuildExcelUrl
            /// </summary>
            [EnumMember(Value = "CouldNotBuildExcelUrl")]
            CouldNotBuildExcelUrl = 84,
            
            /// <summary>
            /// Enum CouldNotGetExcelVersion for value: CouldNotGetExcelVersion
            /// </summary>
            [EnumMember(Value = "CouldNotGetExcelVersion")]
            CouldNotGetExcelVersion = 85,
            
            /// <summary>
            /// Enum InstrumentByCodeNotFound for value: InstrumentByCodeNotFound
            /// </summary>
            [EnumMember(Value = "InstrumentByCodeNotFound")]
            InstrumentByCodeNotFound = 86,
            
            /// <summary>
            /// Enum EntitySchemaDoesNotExist for value: EntitySchemaDoesNotExist
            /// </summary>
            [EnumMember(Value = "EntitySchemaDoesNotExist")]
            EntitySchemaDoesNotExist = 87,
            
            /// <summary>
            /// Enum FeatureNotSupportedOnPortfolioType for value: FeatureNotSupportedOnPortfolioType
            /// </summary>
            [EnumMember(Value = "FeatureNotSupportedOnPortfolioType")]
            FeatureNotSupportedOnPortfolioType = 88,
            
            /// <summary>
            /// Enum QuoteNotFoundFailure for value: QuoteNotFoundFailure
            /// </summary>
            [EnumMember(Value = "QuoteNotFoundFailure")]
            QuoteNotFoundFailure = 89,
            
            /// <summary>
            /// Enum ReferencePortfolioRequestNotSupported for value: ReferencePortfolioRequestNotSupported
            /// </summary>
            [EnumMember(Value = "ReferencePortfolioRequestNotSupported")]
            ReferencePortfolioRequestNotSupported = 90,
            
            /// <summary>
            /// Enum TransactionPortfolioRequestNotSupported for value: TransactionPortfolioRequestNotSupported
            /// </summary>
            [EnumMember(Value = "TransactionPortfolioRequestNotSupported")]
            TransactionPortfolioRequestNotSupported = 91,
            
            /// <summary>
            /// Enum InvalidInstrumentDefinition for value: InvalidInstrumentDefinition
            /// </summary>
            [EnumMember(Value = "InvalidInstrumentDefinition")]
            InvalidInstrumentDefinition = 92,
            
            /// <summary>
            /// Enum InstrumentUpsertFailure for value: InstrumentUpsertFailure
            /// </summary>
            [EnumMember(Value = "InstrumentUpsertFailure")]
            InstrumentUpsertFailure = 93,
            
            /// <summary>
            /// Enum TransactionTypeNotFound for value: TransactionTypeNotFound
            /// </summary>
            [EnumMember(Value = "TransactionTypeNotFound")]
            TransactionTypeNotFound = 94,
            
            /// <summary>
            /// Enum TransactionTypeDuplication for value: TransactionTypeDuplication
            /// </summary>
            [EnumMember(Value = "TransactionTypeDuplication")]
            TransactionTypeDuplication = 95,
            
            /// <summary>
            /// Enum InvalidPropertyValueAssignment for value: InvalidPropertyValueAssignment
            /// </summary>
            [EnumMember(Value = "InvalidPropertyValueAssignment")]
            InvalidPropertyValueAssignment = 96,
            
            /// <summary>
            /// Enum PortfolioDoesNotExistAtGivenDate for value: PortfolioDoesNotExistAtGivenDate
            /// </summary>
            [EnumMember(Value = "PortfolioDoesNotExistAtGivenDate")]
            PortfolioDoesNotExistAtGivenDate = 97,
            
            /// <summary>
            /// Enum QueryParserFailure for value: QueryParserFailure
            /// </summary>
            [EnumMember(Value = "QueryParserFailure")]
            QueryParserFailure = 98,
            
            /// <summary>
            /// Enum DuplicateConstituentFailure for value: DuplicateConstituentFailure
            /// </summary>
            [EnumMember(Value = "DuplicateConstituentFailure")]
            DuplicateConstituentFailure = 99,
            
            /// <summary>
            /// Enum UnresolvedInstrumentConstituentFailure for value: UnresolvedInstrumentConstituentFailure
            /// </summary>
            [EnumMember(Value = "UnresolvedInstrumentConstituentFailure")]
            UnresolvedInstrumentConstituentFailure = 100,
            
            /// <summary>
            /// Enum UnresolvedInstrumentInTransitionFailure for value: UnresolvedInstrumentInTransitionFailure
            /// </summary>
            [EnumMember(Value = "UnresolvedInstrumentInTransitionFailure")]
            UnresolvedInstrumentInTransitionFailure = 101,
            
            /// <summary>
            /// Enum MissingRecipeFailure for value: MissingRecipeFailure
            /// </summary>
            [EnumMember(Value = "MissingRecipeFailure")]
            MissingRecipeFailure = 102,
            
            /// <summary>
            /// Enum DependenciesFailure for value: DependenciesFailure
            /// </summary>
            [EnumMember(Value = "DependenciesFailure")]
            DependenciesFailure = 103,
            
            /// <summary>
            /// Enum PortfolioPreprocessFailure for value: PortfolioPreprocessFailure
            /// </summary>
            [EnumMember(Value = "PortfolioPreprocessFailure")]
            PortfolioPreprocessFailure = 104,
            
            /// <summary>
            /// Enum ValuationEngineFailure for value: ValuationEngineFailure
            /// </summary>
            [EnumMember(Value = "ValuationEngineFailure")]
            ValuationEngineFailure = 105,
            
            /// <summary>
            /// Enum TaskFactoryFailure for value: TaskFactoryFailure
            /// </summary>
            [EnumMember(Value = "TaskFactoryFailure")]
            TaskFactoryFailure = 106,
            
            /// <summary>
            /// Enum TaskEvaluationFailure for value: TaskEvaluationFailure
            /// </summary>
            [EnumMember(Value = "TaskEvaluationFailure")]
            TaskEvaluationFailure = 107,
            
            /// <summary>
            /// Enum InstrumentFailure for value: InstrumentFailure
            /// </summary>
            [EnumMember(Value = "InstrumentFailure")]
            InstrumentFailure = 108,
            
            /// <summary>
            /// Enum CashFlowsFailure for value: CashFlowsFailure
            /// </summary>
            [EnumMember(Value = "CashFlowsFailure")]
            CashFlowsFailure = 109,
            
            /// <summary>
            /// Enum AggregationFailure for value: AggregationFailure
            /// </summary>
            [EnumMember(Value = "AggregationFailure")]
            AggregationFailure = 110,
            
            /// <summary>
            /// Enum ResultRetrievalFailure for value: ResultRetrievalFailure
            /// </summary>
            [EnumMember(Value = "ResultRetrievalFailure")]
            ResultRetrievalFailure = 111,
            
            /// <summary>
            /// Enum ResultProcessingFailure for value: ResultProcessingFailure
            /// </summary>
            [EnumMember(Value = "ResultProcessingFailure")]
            ResultProcessingFailure = 112,
            
            /// <summary>
            /// Enum VendorResultProcessingFailure for value: VendorResultProcessingFailure
            /// </summary>
            [EnumMember(Value = "VendorResultProcessingFailure")]
            VendorResultProcessingFailure = 113,
            
            /// <summary>
            /// Enum AttemptToUpsertDuplicateQuotes for value: AttemptToUpsertDuplicateQuotes
            /// </summary>
            [EnumMember(Value = "AttemptToUpsertDuplicateQuotes")]
            AttemptToUpsertDuplicateQuotes = 114,
            
            /// <summary>
            /// Enum CorporateActionSourceDoesNotExist for value: CorporateActionSourceDoesNotExist
            /// </summary>
            [EnumMember(Value = "CorporateActionSourceDoesNotExist")]
            CorporateActionSourceDoesNotExist = 115,
            
            /// <summary>
            /// Enum InstrumentIdentifierAlreadyInUse for value: InstrumentIdentifierAlreadyInUse
            /// </summary>
            [EnumMember(Value = "InstrumentIdentifierAlreadyInUse")]
            InstrumentIdentifierAlreadyInUse = 116
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public CodeEnum? Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        /// <param name="Status">Status.</param>
        /// <param name="Code">Code.</param>
        /// <param name="Message">Message.</param>
        /// <param name="DetailedMessage">DetailedMessage.</param>
        /// <param name="Items">Items.</param>
        /// <param name="MoreInfo">MoreInfo.</param>
        public ErrorResponse(int? Status = default(int?), CodeEnum? Code = default(CodeEnum?), string Message = default(string), string DetailedMessage = default(string), List<ErrorDetailBase> Items = default(List<ErrorDetailBase>), string MoreInfo = default(string))
        {
            this.Status = Status;
            this.Code = Code;
            this.Message = Message;
            this.DetailedMessage = DetailedMessage;
            this.Items = Items;
            this.MoreInfo = MoreInfo;
        }
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }


        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets DetailedMessage
        /// </summary>
        [DataMember(Name="detailedMessage", EmitDefaultValue=false)]
        public string DetailedMessage { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<ErrorDetailBase> Items { get; set; }

        /// <summary>
        /// Gets or Sets MoreInfo
        /// </summary>
        [DataMember(Name="moreInfo", EmitDefaultValue=false)]
        public string MoreInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  DetailedMessage: ").Append(DetailedMessage).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  MoreInfo: ").Append(MoreInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ErrorResponse);
        }

        /// <summary>
        /// Returns true if ErrorResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.DetailedMessage == input.DetailedMessage ||
                    (this.DetailedMessage != null &&
                    this.DetailedMessage.Equals(input.DetailedMessage))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.MoreInfo == input.MoreInfo ||
                    (this.MoreInfo != null &&
                    this.MoreInfo.Equals(input.MoreInfo))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.DetailedMessage != null)
                    hashCode = hashCode * 59 + this.DetailedMessage.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.MoreInfo != null)
                    hashCode = hashCode * 59 + this.MoreInfo.GetHashCode();
                return hashCode;
            }
        }
    }

}
