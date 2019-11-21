/* 
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://api.lusid.com/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages :  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python)  # Data Model  The LUSID API has a relatively lightweight but extremely powerful data model. One of the goals of LUSID was not to enforce on clients a single rigid data model but rather to provide a flexible foundation onto which clients can map their own data models.  The core entities in LUSID provide a minimal structure and set of relationships, and the data model can be extended using Properties.  The LUSID data model is exposed through the LUSID APIs.  The APIs provide access to both business objects and the meta data used to configure the systems behaviours.   The key business entities are: - * **Portfolios** A portfolio is a container for transactions and holdings (a **Transaction Portfolio**) or constituents (a **Reference Portfolio**). * **Derived Portfolios**. Derived Portfolios allow Portfolios to be created based on other Portfolios, by overriding or adding specific items. * **Holdings** A Holding is a quantity of an Instrument or a balance of cash within a Portfolio.  Holdings can only be adjusted via Transactions. * **Transactions** A Transaction is an economic event that occurs in a Portfolio, causing its holdings to change. * **Corporate Actions** A corporate action is a market event which occurs to an Instrument and thus applies to all portfolios which holding the instrument.  Examples are stock splits or mergers. * **Constituents** A constituent is a record in a Reference Portfolio containing an Instrument and an associated weight. * **Instruments**  An instrument represents a currency, tradable instrument or OTC contract that is attached to a transaction and a holding. * **Properties** All major entities allow additional user defined properties to be associated with them.   For example, a Portfolio manager may be associated with a portfolio.  Meta data includes: - * **Transaction Types** Transactions are booked with a specific transaction type.  The types are client defined and are used to map the Transaction to a series of movements which update the portfolio holdings.  * **Properties Types** Types of user defined properties used within the system.  ## Scope  All data in LUSID is segregated at the client level.  Entities in LUSID are identifiable by a unique code.  Every entity lives within a logical data partition known as a Scope.  Scope is an identity namespace allowing two entities with the same unique code to co-exist within individual address spaces.  For example, prices for equities from different vendors may be uploaded into different scopes such as `client/vendor1` and `client/vendor2`.  A portfolio may then be valued using either of the price sources by referencing the appropriate scope.  LUSID Clients cannot access scopes of other clients.  ## Instruments  LUSID has its own built-in instrument master which you can use to master your own instrument universe.  Every instrument must be created with one or more unique market identifiers, such as [FIGI](https://openfigi.com/). For any non-listed instruments (eg OTCs), you can upload an instrument against a custom ID of your choosing.  In addition, LUSID will allocate each instrument a unique 'LUSID instrument identifier'. The LUSID instrument identifier is what is used when uploading transactions, holdings, prices, etc. The API exposes an `instrument/lookup` endpoint which can be used to lookup these LUSID identifiers using their market identifiers.  Cash can be referenced using the ISO currency code prefixed with \"`CCY_`\" e.g. `CCY_GBP`  ## Instrument Data  Instrument data can be uploaded to the system using the [Instrument Properties](#tag/InstrumentProperties) endpoint.  | Field|Type|Description | | - --|- --|- -- | | Key|propertykey|The key of the property. This takes the format {domain}/{scope}/{code} e.g. 'Instrument/system/Name' or 'Transaction/strategy/quantsignal'. | | Value|string|The value of the property. | | EffectiveFrom|datetimeoffset|The effective datetime from which the property is valid. |   ## Transaction Portfolios  Portfolios are the top-level entity containers within LUSID, containing transactions, corporate actions and holdings.    The transactions build up the portfolio holdings on which valuations, analytics profit & loss and risk can be calculated.  Properties can be associated with Portfolios to add in additional data.  Portfolio properties can be changed over time, for example to allow a Portfolio Manager to be linked with a Portfolio.  Additionally, portfolios can be securitised and held by other portfolios, allowing LUSID to perform \"drill-through\" into underlying fund holdings  ### Derived Portfolios  LUSID also allows for a portfolio to be composed of another portfolio via derived portfolios.  A derived portfolio can contain its own transactions and also inherits any transactions from its parent portfolio.  Any changes made to the parent portfolio are automatically reflected in derived portfolio.  Derived portfolios in conjunction with scopes are a powerful construct.  For example, to do pre-trade what-if analysis, a derived portfolio could be created a new namespace linked to the underlying live (parent) portfolio.  Analysis can then be undertaken on the derived portfolio without affecting the live portfolio.  ### Transactions  A transaction represents an economic activity against a Portfolio.  Transactions are processed according to a configuration. This will tell the LUSID engine how to interpret the transaction and correctly update the holdings. LUSID comes with a set of transaction types you can use out of the box, or you can configure your own set(s) of transactions.  For more details see the [LUSID Getting Started Guide for transaction configuration.](https://support.lusid.com/configuring-transaction-types)  | Field|Type|Description | | - --|- --|- -- | | TransactionId|string|The unique identifier for the transaction. | | Type|string|The type of the transaction e.g. 'Buy', 'Sell'. The transaction type should have been pre-configured via the System Configuration API endpoint. If it hasn't been pre-configured the transaction will still be updated or inserted however you will be unable to generate the resultant holdings for the portfolio that contains this transaction as LUSID does not know how to process it. | | InstrumentIdentifiers|map|A set of instrument identifiers to use to resolve the transaction to a unique instrument. | | TransactionDate|dateorcutlabel|The date of the transaction. | | SettlementDate|dateorcutlabel|The settlement date of the transaction. | | Units|decimal|The number of units transacted in the associated instrument. | | TransactionPrice|transactionprice|The price for each unit of the transacted instrument in the transaction currency. | | TotalConsideration|currencyandamount|The total value of the transaction in the settlement currency. | | ExchangeRate|decimal|The exchange rate between the transaction and settlement currency. For example if the transaction currency is in USD and the settlement currency is in GBP this this the USD/GBP rate. | | TransactionCurrency|currency|The transaction currency. | | Properties|map|Set of unique transaction properties and associated values to store with the transaction. Each property must be from the 'Transaction' domain. | | CounterpartyId|string|The identifier for the counterparty of the transaction. | | Source|string|The source of the transaction. This is used to look up the appropriate transaction group set in the transaction type configuration. |   From these fields, the following values can be calculated  * **Transaction value in Transaction currency**: TotalConsideration / ExchangeRate  * **Transaction value in Portfolio currency**: Transaction value in Transaction currency * TradeToPortfolioRate  #### Example Transactions  ##### A Common Purchase Example Three example transactions are shown in the table below.   They represent a purchase of USD denominated IBM shares within a Sterling denominated portfolio.   * The first two transactions are for separate buy and fx trades    * Buying 500 IBM shares for $71,480.00    * A foreign exchange conversion to fund the IBM purchase. (Buy $71,480.00 for &#163;54,846.60)  * The third transaction is an alternate version of the above trades. Buying 500 IBM shares and settling directly in Sterling.  | Column |  Buy Trade | Fx Trade | Buy Trade with foreign Settlement | | - -- -- | - -- -- | - -- -- | - -- -- | | TransactionId | FBN00001 | FBN00002 | FBN00003 | | Type | Buy | FxBuy | Buy | | InstrumentIdentifiers | { \"figi\", \"BBG000BLNNH6\" } | { \"CCY\", \"CCY_USD\" } | { \"figi\", \"BBG000BLNNH6\" } | | TransactionDate | 2018-08-02 | 2018-08-02 | 2018-08-02 | | SettlementDate | 2018-08-06 | 2018-08-06 | 2018-08-06 | | Units | 500 | 71480 | 500 | | TransactionPrice | 142.96 | 1 | 142.96 | | TradeCurrency | USD | USD | USD | | ExchangeRate | 1 | 0.7673 | 0.7673 | | TotalConsideration.Amount | 71480.00 | 54846.60 | 54846.60 | | TotalConsideration.Currency | USD | GBP | GBP | | Trade/default/TradeToPortfolioRate&ast; | 0.7673 | 0.7673 | 0.7673 |  [&ast; This is a property field]  ##### A Forward FX Example  LUSID has a flexible transaction modelling system, and there are a number of different ways of modelling forward fx trades.  The default LUSID transaction types are FwdFxBuy and FwdFxSell. Other types and behaviours can be configured as required.  Using these transaction types, the holdings query will report two forward positions. One in each currency.   Since an FX trade is an exchange of one currency for another, the following two 6 month forward transactions are equivalent:  | Column |  Forward 'Sell' Trade | Forward 'Buy' Trade | | - -- -- | - -- -- | - -- -- | | TransactionId | FBN00004 | FBN00005 | | Type | FwdFxSell | FwdFxBuy | | InstrumentIdentifiers | { \"CCY\", \"CCY_GBP\" } | { \"CCY\", \"CCY_USD\" } | | TransactionDate | 2018-08-02 | 2018-08-02 | | SettlementDate | 2019-02-06 | 2019-02-06 | | Units | 10000.00 | 13142.00 | | TransactionPrice |1 | 1 | | TradeCurrency | GBP | USD | | ExchangeRate | 1.3142 | 0.760919 | | TotalConsideration.Amount | 13142.00 | 10000.00 | | TotalConsideration.Currency | USD | GBP | | Trade/default/TradeToPortfolioRate | 1.0 | 0.760919 |  ### Holdings  A holding represents a position in an instrument or cash on a given date.  | Field|Type|Description | | - --|- --|- -- | | InstrumentUid|string|The unqiue Lusid Instrument Id (LUID) of the instrument that the holding is in. | | SubHoldingKeys|map|The sub-holding properties which identify the holding. Each property will be from the 'Transaction' domain. These are configured when a transaction portfolio is created. | | Properties|map|The properties which have been requested to be decorated onto the holding. These will be from the 'Instrument' or 'Holding' domain. | | HoldingType|string|The type of the holding e.g. Position, Balance, CashCommitment, Receivable, ForwardFX etc. | | Units|decimal|The total number of units of the holding. | | SettledUnits|decimal|The total number of settled units of the holding. | | Cost|currencyandamount|The total cost of the holding in the transaction currency. | | CostPortfolioCcy|currencyandamount|The total cost of the holding in the portfolio currency. | | Transaction|transaction|The transaction associated with an unsettled holding. |   ## Corporate Actions  Corporate actions are represented within LUSID in terms of a set of instrument-specific 'transitions'.  These transitions are used to specify the participants of the corporate action, and the effect that the corporate action will have on holdings in those participants.  ### Corporate Action  | Field|Type|Description | | - --|- --|- -- | | CorporateActionCode|code|The unique identifier of this corporate action | | Description|string|  | | AnnouncementDate|datetimeoffset|The announcement date of the corporate action | | ExDate|datetimeoffset|The ex date of the corporate action | | RecordDate|datetimeoffset|The record date of the corporate action | | PaymentDate|datetimeoffset|The payment date of the corporate action | | Transitions|corporateactiontransition[]|The transitions that result from this corporate action |   ### Transition | Field|Type|Description | | - --|- --|- -- | | InputTransition|corporateactiontransitioncomponent|Indicating the basis of the corporate action - which security and how many units | | OutputTransitions|corporateactiontransitioncomponent[]|What will be generated relative to the input transition |   ### Example Corporate Action Transitions  #### A Dividend Action Transition  In this example, for each share of IBM, 0.20 units (or 20 pence) of GBP are generated.  | Column |  Input Transition | Output Transition | | - -- -- | - -- -- | - -- -- | | Instrument Identifiers | { \"figi\" : \"BBG000BLNNH6\" } | { \"ccy\" : \"CCY_GBP\" } | | Units Factor | 1 | 0.20 | | Cost Factor | 1 | 0 |  #### A Split Action Transition  In this example, for each share of IBM, we end up with 2 units (2 shares) of IBM, with total value unchanged.  | Column |  Input Transition | Output Transition | | - -- -- | - -- -- | - -- -- | | Instrument Identifiers | { \"figi\" : \"BBG000BLNNH6\" } | { \"figi\" : \"BBG000BLNNH6\" } | | Units Factor | 1 | 2 | | Cost Factor | 1 | 1 |  #### A Spinoff Action Transition  In this example, for each share of IBM, we end up with 1 unit (1 share) of IBM and 3 units (3 shares) of Celestica, with 85% of the value remaining on the IBM share, and 5% in each Celestica share (15% total).  | Column |  Input Transition | Output Transition 1 | Output Transition 2 | | - -- -- | - -- -- | - -- -- | - -- -- | | Instrument Identifiers | { \"figi\" : \"BBG000BLNNH6\" } | { \"figi\" : \"BBG000BLNNH6\" } | { \"figi\" : \"BBG000HBGRF3\" } | | Units Factor | 1 | 1 | 3 | | Cost Factor | 1 | 0.85 | 0.15 |  ## Reference Portfolios Reference portfolios are portfolios that contain constituents with weights.  They are designed to represent entities such as indices and benchmarks.  ### Constituents | Field|Type|Description | | - --|- --|- -- | | InstrumentIdentifiers|map|Unique instrument identifiers | | InstrumentUid|string|LUSID's internal unique instrument identifier, resolved from the instrument identifiers | | Currency|decimal|  | | Weight|decimal|  | | FloatingWeight|decimal|  |   ## Portfolio Groups Portfolio groups allow the construction of a hierarchy from portfolios and groups.  Portfolio operations on the group are executed on an aggregated set of portfolios in the hierarchy.   For example:   * Global Portfolios _(group)_   * APAC _(group)_     * Hong Kong _(portfolio)_     * Japan _(portfolio)_   * Europe _(group)_     * France _(portfolio)_     * Germany _(portfolio)_   * UK _(portfolio)_   In this example **Global Portfolios** is a group that consists of an aggregate of **Hong Kong**, **Japan**, **France**, **Germany** and **UK** portfolios.  ## Properties  Properties are key-value pairs that can be applied to any entity within a domain (where a domain is `trade`, `portfolio`, `security` etc).  Properties must be defined before use with a `PropertyDefinition` and can then subsequently be added to entities.   ## Schema  A detailed description of the entities used by the API and parameters for endpoints which take a JSON document can be retrieved via the `schema` endpoint.  ## Meta data  The following headers are returned on all responses from LUSID  | Name | Purpose | | - -- | - -- | | lusid-meta-duration | Duration of the request | | lusid-meta-success | Whether or not LUSID considered the request to be successful | | lusid-meta-requestId | The unique identifier for the request | | lusid-schema-url | Url of the schema for the data being returned | | lusid-property-schema-url | Url of the schema for any properties |   # Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"102\">102</a>|VersionNotFound|  | | <a name=\"103\">103</a>|ApiRateLimitViolation|  | | <a name=\"104\">104</a>|InstrumentNotFound|  | | <a name=\"105\">105</a>|PropertyNotFound|  | | <a name=\"106\">106</a>|PortfolioRecursionDepth|  | | <a name=\"108\">108</a>|GroupNotFound|  | | <a name=\"109\">109</a>|PortfolioNotFound|  | | <a name=\"110\">110</a>|PropertySchemaNotFound|  | | <a name=\"111\">111</a>|PortfolioAncestryNotFound|  | | <a name=\"112\">112</a>|PortfolioWithIdAlreadyExists|  | | <a name=\"113\">113</a>|OrphanedPortfolio|  | | <a name=\"119\">119</a>|MissingBaseClaims|  | | <a name=\"121\">121</a>|PropertyNotDefined|  | | <a name=\"122\">122</a>|CannotDeleteSystemProperty|  | | <a name=\"123\">123</a>|CannotModifyImmutablePropertyField|  | | <a name=\"124\">124</a>|PropertyAlreadyExists|  | | <a name=\"125\">125</a>|InvalidPropertyLifeTime|  | | <a name=\"125\">125</a>|InvalidPropertyLifeTime|  | | <a name=\"127\">127</a>|CannotModifyDefaultDataType|  | | <a name=\"128\">128</a>|GroupAlreadyExists|  | | <a name=\"129\">129</a>|NoSuchDataType|  | | <a name=\"130\">130</a>|UndefinedValueForDataType|  | | <a name=\"131\">131</a>|UnsupportedValueTypeDefinedOnDataType|  | | <a name=\"132\">132</a>|ValidationError|  | | <a name=\"133\">133</a>|LoopDetectedInGroupHierarchy|  | | <a name=\"134\">134</a>|UndefinedAcceptableValues|  | | <a name=\"135\">135</a>|SubGroupAlreadyExists|  | | <a name=\"138\">138</a>|PriceSourceNotFound|  | | <a name=\"139\">139</a>|AnalyticStoreNotFound|  | | <a name=\"141\">141</a>|AnalyticStoreAlreadyExists|  | | <a name=\"143\">143</a>|ClientInstrumentAlreadyExists|  | | <a name=\"144\">144</a>|DuplicateInParameterSet|  | | <a name=\"147\">147</a>|ResultsNotFound|  | | <a name=\"148\">148</a>|OrderFieldNotInResultSet|  | | <a name=\"149\">149</a>|OperationFailed|  | | <a name=\"150\">150</a>|ElasticSearchError|  | | <a name=\"151\">151</a>|InvalidParameterValue|  | | <a name=\"153\">153</a>|CommandProcessingFailure|  | | <a name=\"154\">154</a>|EntityStateConstructionFailure|  | | <a name=\"155\">155</a>|EntityTimelineDoesNotExist|  | | <a name=\"156\">156</a>|EventPublishFailure|  | | <a name=\"157\">157</a>|InvalidRequestFailure|  | | <a name=\"158\">158</a>|EventPublishUnknown|  | | <a name=\"159\">159</a>|EventQueryFailure|  | | <a name=\"160\">160</a>|BlobDidNotExistFailure|  | | <a name=\"162\">162</a>|SubSystemRequestFailure|  | | <a name=\"163\">163</a>|SubSystemConfigurationFailure|  | | <a name=\"165\">165</a>|FailedToDelete|  | | <a name=\"166\">166</a>|UpsertClientInstrumentFailure|  | | <a name=\"167\">167</a>|IllegalAsAtInterval|  | | <a name=\"168\">168</a>|IllegalBitemporalQuery|  | | <a name=\"169\">169</a>|InvalidAlternateId|  | | <a name=\"170\">170</a>|CannotAddSourcePortfolioPropertyExplicitly|  | | <a name=\"171\">171</a>|EntityAlreadyExistsInGroup|  | | <a name=\"173\">173</a>|EntityWithIdAlreadyExists|  | | <a name=\"174\">174</a>|DerivedPortfolioDetailsDoNotExist|  | | <a name=\"176\">176</a>|PortfolioWithNameAlreadyExists|  | | <a name=\"177\">177</a>|InvalidTransactions|  | | <a name=\"178\">178</a>|ReferencePortfolioNotFound|  | | <a name=\"179\">179</a>|DuplicateIdFailure|  | | <a name=\"180\">180</a>|CommandRetrievalFailure|  | | <a name=\"181\">181</a>|DataFilterApplicationFailure|  | | <a name=\"182\">182</a>|SearchFailed|  | | <a name=\"183\">183</a>|MovementsEngineConfigurationKeyFailure|  | | <a name=\"184\">184</a>|FxRateSourceNotFound|  | | <a name=\"185\">185</a>|AccrualSourceNotFound|  | | <a name=\"186\">186</a>|AccessDenied|  | | <a name=\"187\">187</a>|InvalidIdentityToken|  | | <a name=\"188\">188</a>|InvalidRequestHeaders|  | | <a name=\"189\">189</a>|PriceNotFound|  | | <a name=\"190\">190</a>|InvalidSubHoldingKeysProvided|  | | <a name=\"191\">191</a>|DuplicateSubHoldingKeysProvided|  | | <a name=\"192\">192</a>|CutDefinitionNotFound|  | | <a name=\"193\">193</a>|CutDefinitionInvalid|  | | <a name=\"194\">194</a>|TimeVariantPropertyDeletionDateUnspecified|  | | <a name=\"195\">195</a>|PerpetualPropertyDeletionDateSpecified|  | | <a name=\"196\">196</a>|TimeVariantPropertyUpsertDateUnspecified|  | | <a name=\"197\">197</a>|PerpetualPropertyUpsertDateSpecified|  | | <a name=\"200\">200</a>|InvalidUnitForDataType|  | | <a name=\"201\">201</a>|InvalidTypeForDataType|  | | <a name=\"202\">202</a>|InvalidValueForDataType|  | | <a name=\"203\">203</a>|UnitNotDefinedForDataType|  | | <a name=\"204\">204</a>|UnitsNotSupportedOnDataType|  | | <a name=\"205\">205</a>|CannotSpecifyUnitsOnDataType|  | | <a name=\"206\">206</a>|UnitSchemaInconsistentWithDataType|  | | <a name=\"207\">207</a>|UnitDefinitionNotSpecified|  | | <a name=\"208\">208</a>|DuplicateUnitDefinitionsSpecified|  | | <a name=\"209\">209</a>|InvalidUnitsDefinition|  | | <a name=\"210\">210</a>|InvalidInstrumentIdentifierUnit|  | | <a name=\"211\">211</a>|HoldingsAdjustmentDoesNotExist|  | | <a name=\"212\">212</a>|CouldNotBuildExcelUrl|  | | <a name=\"213\">213</a>|CouldNotGetExcelVersion|  | | <a name=\"214\">214</a>|InstrumentByCodeNotFound|  | | <a name=\"215\">215</a>|EntitySchemaDoesNotExist|  | | <a name=\"216\">216</a>|FeatureNotSupportedOnPortfolioType|  | | <a name=\"217\">217</a>|QuoteNotFoundFailure|  | | <a name=\"218\">218</a>|InvalidQuoteIdentifierFailure|  | | <a name=\"219\">219</a>|InvalidInstrumentDefinition|  | | <a name=\"219\">219</a>|InvalidInstrumentDefinition|  | | <a name=\"221\">221</a>|InstrumentUpsertFailure|  | | <a name=\"222\">222</a>|ReferencePortfolioRequestNotSupported|  | | <a name=\"223\">223</a>|TransactionPortfolioRequestNotSupported|  | | <a name=\"224\">224</a>|InvalidPropertyValueAssignment|  | | <a name=\"230\">230</a>|TransactionTypeNotFound|  | | <a name=\"231\">231</a>|TransactionTypeDuplication|  | | <a name=\"232\">232</a>|PortfolioDoesNotExistAtGivenDate|  | | <a name=\"233\">233</a>|QueryParserFailure|  | | <a name=\"234\">234</a>|DuplicateConstituentFailure|  | | <a name=\"235\">235</a>|UnresolvedInstrumentConstituentFailure|  | | <a name=\"236\">236</a>|UnresolvedInstrumentInTransitionFailure|  | | <a name=\"237\">237</a>|MissingSideDefinitionsFailure|  | | <a name=\"300\">300</a>|MissingRecipeFailure|  | | <a name=\"301\">301</a>|DependenciesFailure|  | | <a name=\"304\">304</a>|PortfolioPreprocessFailure|  | | <a name=\"310\">310</a>|ValuationEngineFailure|  | | <a name=\"311\">311</a>|TaskFactoryFailure|  | | <a name=\"312\">312</a>|TaskEvaluationFailure|  | | <a name=\"320\">320</a>|MarketDataKeyFailure|  | | <a name=\"321\">321</a>|MarketResolverFailure|  | | <a name=\"322\">322</a>|MarketDataFailure|  | | <a name=\"350\">350</a>|InstrumentFailure|  | | <a name=\"351\">351</a>|CashFlowsFailure|  | | <a name=\"360\">360</a>|AggregationFailure|  | | <a name=\"370\">370</a>|ResultRetrievalFailure|  | | <a name=\"371\">371</a>|VendorPricingFailure|  | | <a name=\"371\">371</a>|VendorPricingFailure|  | | <a name=\"372\">372</a>|VendorResultProcessingFailure|  | | <a name=\"373\">373</a>|VendorResultMappingFailure|  | | <a name=\"374\">374</a>|VendorLibraryUnauthorisedFailure|  | | <a name=\"375\">375</a>|VendorConnectivityError|  | | <a name=\"376\">376</a>|VendorInterfaceError|  | | <a name=\"390\">390</a>|AttemptToUpsertDuplicateQuotes|  | | <a name=\"391\">391</a>|CorporateActionSourceDoesNotExist|  | | <a name=\"392\">392</a>|CorporateActionSourceAlreadyExists|  | | <a name=\"393\">393</a>|InstrumentIdentifierAlreadyInUse|  | | <a name=\"394\">394</a>|PropertiesNotFound|  | | <a name=\"395\">395</a>|BatchOperationAborted|  | | <a name=\"400\">400</a>|InvalidIso4217CurrencyCodeFailure|  | | <a name=\"401\">401</a>|CannotAssignInstrumentIdentifierToCurrencyFailure|  | | <a name=\"402\">402</a>|CannotAssignCurrencyIdentifierToNonCurrency|  | | <a name=\"403\">403</a>|CurrencyInstrumentCannotBeDeleted|  | | <a name=\"404\">404</a>|CurrencyInstrumentCannotHaveEconomicDefinition|  | | <a name=\"405\">405</a>|CurrencyInstrumentCannotHaveLookthroughPortfolio|  | | <a name=\"406\">406</a>|CannotCreateCurrencyInstrumentWithMultipleIdentifiers|  | | <a name=\"410\">410</a>|IndexDoesNotExist|  | | <a name=\"411\">411</a>|SortFieldDoesNotExist|  | | <a name=\"413\">413</a>|NegativePaginationParameters|  | | <a name=\"414\">414</a>|InvalidSearchSyntax|  | | <a name=\"420\">420</a>|SideDefinitionInconsistent|  | | <a name=\"450\">450</a>|InvalidQuoteAccessMetadataRule|  | | <a name=\"451\">451</a>|AccessMetadataNotFound|  | | <a name=\"601\">601</a>|PersonIdentifierAlreadyInUse|  | | <a name=\"602\">602</a>|PersonNotFound|  | | <a name=\"603\">603</a>|CannotSetIdentifier|  | | <a name=\"-10\">-10</a>|ServerConfigurationError|  | | <a name=\"-1\">-1</a>|Unknown error|  | 
 *
 * The version of the OpenAPI document: 0.10.888
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Lusid.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPortfolioGroupsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EARLY ACCESS] Add portfolio to group
        /// </summary>
        /// <remarks>
        /// Add a single portfolio to a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be added to the group.</param>
        /// <param name="portfolioId">The resource identifier of the portfolio to add to the portfolio group. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        PortfolioGroup AddPortfolioToGroup (string scope, string code, DateTimeOffset effectiveAt, ResourceId portfolioId = default(ResourceId));

        /// <summary>
        /// [EARLY ACCESS] Add portfolio to group
        /// </summary>
        /// <remarks>
        /// Add a single portfolio to a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be added to the group.</param>
        /// <param name="portfolioId">The resource identifier of the portfolio to add to the portfolio group. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        ApiResponse<PortfolioGroup> AddPortfolioToGroupWithHttpInfo (string scope, string code, DateTimeOffset effectiveAt, ResourceId portfolioId = default(ResourceId));
        /// <summary>
        /// [EARLY ACCESS] Add sub group to group
        /// </summary>
        /// <remarks>
        /// Add a portfolio group to a portfolio group as a sub group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio group to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio group to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be added to the group.</param>
        /// <param name="portfolioGroupId">The resource identifier of the portfolio group to add to the portfolio group as a sub group. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        PortfolioGroup AddSubGroupToGroup (string scope, string code, DateTimeOffset effectiveAt, ResourceId portfolioGroupId = default(ResourceId));

        /// <summary>
        /// [EARLY ACCESS] Add sub group to group
        /// </summary>
        /// <remarks>
        /// Add a portfolio group to a portfolio group as a sub group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio group to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio group to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be added to the group.</param>
        /// <param name="portfolioGroupId">The resource identifier of the portfolio group to add to the portfolio group as a sub group. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        ApiResponse<PortfolioGroup> AddSubGroupToGroupWithHttpInfo (string scope, string code, DateTimeOffset effectiveAt, ResourceId portfolioGroupId = default(ResourceId));
        /// <summary>
        /// [EARLY ACCESS] Create portfolio group
        /// </summary>
        /// <remarks>
        /// Create a portfolio group in a specific scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope that the portfolio group will be created in.</param>
        /// <param name="request">The definition and details of the portfolio group. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        PortfolioGroup CreatePortfolioGroup (string scope, CreatePortfolioGroupRequest request = default(CreatePortfolioGroupRequest));

        /// <summary>
        /// [EARLY ACCESS] Create portfolio group
        /// </summary>
        /// <remarks>
        /// Create a portfolio group in a specific scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope that the portfolio group will be created in.</param>
        /// <param name="request">The definition and details of the portfolio group. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        ApiResponse<PortfolioGroup> CreatePortfolioGroupWithHttpInfo (string scope, CreatePortfolioGroupRequest request = default(CreatePortfolioGroupRequest));
        /// <summary>
        /// [EARLY ACCESS] Delete group properties
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a single portfolio group. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to delete properties from.</param>
        /// <param name="code">The code of the group to delete properties from. Together with the scope this uniquely identifies the group.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the properties. (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeleteGroupProperties (string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel));

        /// <summary>
        /// [EARLY ACCESS] Delete group properties
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a single portfolio group. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to delete properties from.</param>
        /// <param name="code">The code of the group to delete properties from. Together with the scope this uniquely identifies the group.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the properties. (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeleteGroupPropertiesWithHttpInfo (string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel));
        /// <summary>
        /// [EARLY ACCESS] Delete portfolio from group
        /// </summary>
        /// <remarks>
        /// Remove a single portfolio from a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the portfolio from.</param>
        /// <param name="code">The code of the portfolio group to remove the portfolio from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="portfolioScope">The scope of the portfolio being removed from the portfolio group.</param>
        /// <param name="portfolioCode">The code of the portfolio being removed from the portfolio group. Together with the scope this uniquely identifies the portfolio to remove.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be removed from the portfolio group.</param>
        /// <returns>PortfolioGroup</returns>
        PortfolioGroup DeletePortfolioFromGroup (string scope, string code, string portfolioScope, string portfolioCode, DateTimeOffset effectiveAt);

        /// <summary>
        /// [EARLY ACCESS] Delete portfolio from group
        /// </summary>
        /// <remarks>
        /// Remove a single portfolio from a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the portfolio from.</param>
        /// <param name="code">The code of the portfolio group to remove the portfolio from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="portfolioScope">The scope of the portfolio being removed from the portfolio group.</param>
        /// <param name="portfolioCode">The code of the portfolio being removed from the portfolio group. Together with the scope this uniquely identifies the portfolio to remove.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be removed from the portfolio group.</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        ApiResponse<PortfolioGroup> DeletePortfolioFromGroupWithHttpInfo (string scope, string code, string portfolioScope, string portfolioCode, DateTimeOffset effectiveAt);
        /// <summary>
        /// [EARLY ACCESS] Delete portfolio group
        /// </summary>
        /// <remarks>
        /// Delete a single portfolio group. A portfolio group can be deleted while it still contains portfolios or sub groups.  In this case any portfolios or sub groups contained in this group will not be deleted, however they will no longer be grouped together by this portfolio group.  The deletion will be valid from the portfolio group&#39;s creation datetime, ie. the portfolio group will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to delete.</param>
        /// <param name="code">The code of the portfolio group to delete. Together with the scope this uniquely identifies the portfolio group to delete.</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeletePortfolioGroup (string scope, string code);

        /// <summary>
        /// [EARLY ACCESS] Delete portfolio group
        /// </summary>
        /// <remarks>
        /// Delete a single portfolio group. A portfolio group can be deleted while it still contains portfolios or sub groups.  In this case any portfolios or sub groups contained in this group will not be deleted, however they will no longer be grouped together by this portfolio group.  The deletion will be valid from the portfolio group&#39;s creation datetime, ie. the portfolio group will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to delete.</param>
        /// <param name="code">The code of the portfolio group to delete. Together with the scope this uniquely identifies the portfolio group to delete.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeletePortfolioGroupWithHttpInfo (string scope, string code);
        /// <summary>
        /// [EARLY ACCESS] Delete sub group from group
        /// </summary>
        /// <remarks>
        /// Remove a single portfolio group (sub group) from a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the sub group from.</param>
        /// <param name="code">The code of the portfolio group to remove the sub group from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="subgroupScope">The scope of the sub group to remove from the portfolio group.</param>
        /// <param name="subgroupCode">The code of the sub group to remove from the portfolio group. Together with the scope this uniquely identifies the sub group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be removed from the portfolio group.</param>
        /// <returns>PortfolioGroup</returns>
        PortfolioGroup DeleteSubGroupFromGroup (string scope, string code, string subgroupScope, string subgroupCode, DateTimeOffset effectiveAt);

        /// <summary>
        /// [EARLY ACCESS] Delete sub group from group
        /// </summary>
        /// <remarks>
        /// Remove a single portfolio group (sub group) from a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the sub group from.</param>
        /// <param name="code">The code of the portfolio group to remove the sub group from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="subgroupScope">The scope of the sub group to remove from the portfolio group.</param>
        /// <param name="subgroupCode">The code of the sub group to remove from the portfolio group. Together with the scope this uniquely identifies the sub group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be removed from the portfolio group.</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        ApiResponse<PortfolioGroup> DeleteSubGroupFromGroupWithHttpInfo (string scope, string code, string subgroupScope, string subgroupCode, DateTimeOffset effectiveAt);
        /// <summary>
        /// [EARLY ACCESS] Get group properties
        /// </summary>
        /// <remarks>
        /// List all the properties of a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to list the properties for.</param>
        /// <param name="code">The code of the group to list the properties for. Together with the scope this uniquely identifies the group.</param>
        /// <param name="effectiveAt">The effective date time or cut label at which to list the group&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt date time at which to list the group&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <returns>PortfolioGroupProperties</returns>
        PortfolioGroupProperties GetGroupProperties (string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] Get group properties
        /// </summary>
        /// <remarks>
        /// List all the properties of a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to list the properties for.</param>
        /// <param name="code">The code of the group to list the properties for. Together with the scope this uniquely identifies the group.</param>
        /// <param name="effectiveAt">The effective date time or cut label at which to list the group&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt date time at which to list the group&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroupProperties</returns>
        ApiResponse<PortfolioGroupProperties> GetGroupPropertiesWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] Get portfolio group
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the definition for. Together with the scope              this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to retrieve the portfolio group definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio group definition. Defaults to return              the latest version of the portfolio group definition if not specified. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        PortfolioGroup GetPortfolioGroup (string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] Get portfolio group
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the definition for. Together with the scope              this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to retrieve the portfolio group definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio group definition. Defaults to return              the latest version of the portfolio group definition if not specified. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        ApiResponse<PortfolioGroup> GetPortfolioGroupWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] Get portfolio group commands
        /// </summary>
        /// <remarks>
        /// Gets all the commands that modified a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the commands for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ResourceListOfProcessedCommand</returns>
        ResourceListOfProcessedCommand GetPortfolioGroupCommands (string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string));

        /// <summary>
        /// [EARLY ACCESS] Get portfolio group commands
        /// </summary>
        /// <remarks>
        /// Gets all the commands that modified a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the commands for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfProcessedCommand</returns>
        ApiResponse<ResourceListOfProcessedCommand> GetPortfolioGroupCommandsWithHttpInfo (string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string));
        /// <summary>
        /// [EARLY ACCESS] Get portfolio group expansion
        /// </summary>
        /// <remarks>
        /// List all the portfolios in a group, including all portfolios within sub groups in the group. Each portfolio will be decorated with all of its properties unless a property filter is specified.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to expand.</param>
        /// <param name="code">The code of the portfolio group to expand. Together with the scope this uniquely identifies the portfolio              group to expand.</param>
        /// <param name="effectiveAt">The effective datetime at which to expand the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to expand the portfolio group. Defaults to return the latest version of each portfolio in the group if not specified. (optional)</param>
        /// <param name="propertyFilter">The restricted list of property keys from the \&quot;Portfolio\&quot; domain which will be decorated onto each portfolio. These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>ExpandedGroup</returns>
        ExpandedGroup GetPortfolioGroupExpansion (string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyFilter = default(List<string>));

        /// <summary>
        /// [EARLY ACCESS] Get portfolio group expansion
        /// </summary>
        /// <remarks>
        /// List all the portfolios in a group, including all portfolios within sub groups in the group. Each portfolio will be decorated with all of its properties unless a property filter is specified.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to expand.</param>
        /// <param name="code">The code of the portfolio group to expand. Together with the scope this uniquely identifies the portfolio              group to expand.</param>
        /// <param name="effectiveAt">The effective datetime at which to expand the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to expand the portfolio group. Defaults to return the latest version of each portfolio in the group if not specified. (optional)</param>
        /// <param name="propertyFilter">The restricted list of property keys from the \&quot;Portfolio\&quot; domain which will be decorated onto each portfolio. These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>ApiResponse of ExpandedGroup</returns>
        ApiResponse<ExpandedGroup> GetPortfolioGroupExpansionWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyFilter = default(List<string>));
        /// <summary>
        /// [EARLY ACCESS] List portfolio groups
        /// </summary>
        /// <remarks>
        /// List all the portfolio groups in a single scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to list the portfolio groups in.</param>
        /// <param name="effectiveAt">The effective datetime at which to list the portfolio groups. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio groups. Defaults to return the latest version of each portfolio group if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ResourceListOfPortfolioGroup</returns>
        ResourceListOfPortfolioGroup ListPortfolioGroups (string scope, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string));

        /// <summary>
        /// [EARLY ACCESS] List portfolio groups
        /// </summary>
        /// <remarks>
        /// List all the portfolio groups in a single scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to list the portfolio groups in.</param>
        /// <param name="effectiveAt">The effective datetime at which to list the portfolio groups. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio groups. Defaults to return the latest version of each portfolio group if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPortfolioGroup</returns>
        ApiResponse<ResourceListOfPortfolioGroup> ListPortfolioGroupsWithHttpInfo (string scope, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string));
        /// <summary>
        /// [EARLY ACCESS] Update portfolio group
        /// </summary>
        /// <remarks>
        /// Update the definition of a single portfolio group. Not all elements within a portfolio group definition are modifiable  due to the potential implications for data already stored against the portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to update the definition for.</param>
        /// <param name="code">The code of the portfolio group to update the definition for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to update the definition.</param>
        /// <param name="request">The updated portfolio group definition. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        PortfolioGroup UpdatePortfolioGroup (string scope, string code, DateTimeOffset effectiveAt, UpdatePortfolioGroupRequest request = default(UpdatePortfolioGroupRequest));

        /// <summary>
        /// [EARLY ACCESS] Update portfolio group
        /// </summary>
        /// <remarks>
        /// Update the definition of a single portfolio group. Not all elements within a portfolio group definition are modifiable  due to the potential implications for data already stored against the portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to update the definition for.</param>
        /// <param name="code">The code of the portfolio group to update the definition for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to update the definition.</param>
        /// <param name="request">The updated portfolio group definition. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        ApiResponse<PortfolioGroup> UpdatePortfolioGroupWithHttpInfo (string scope, string code, DateTimeOffset effectiveAt, UpdatePortfolioGroupRequest request = default(UpdatePortfolioGroupRequest));
        /// <summary>
        /// [EARLY ACCESS] Upsert group properties
        /// </summary>
        /// <remarks>
        /// Update or insert one or more properties onto a single group. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;PortfolioGroup&#39;.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to update or insert the properties onto.</param>
        /// <param name="code">The code of the group to update or insert the properties onto. Together with the scope this uniquely identifies the group.</param>
        /// <param name="groupProperties">The properties to be updated or inserted onto the group. Each property in              the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. (optional)</param>
        /// <returns>PortfolioGroupProperties</returns>
        PortfolioGroupProperties UpsertGroupProperties (string scope, string code, Dictionary<string, Property> groupProperties = default(Dictionary<string, Property>));

        /// <summary>
        /// [EARLY ACCESS] Upsert group properties
        /// </summary>
        /// <remarks>
        /// Update or insert one or more properties onto a single group. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;PortfolioGroup&#39;.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to update or insert the properties onto.</param>
        /// <param name="code">The code of the group to update or insert the properties onto. Together with the scope this uniquely identifies the group.</param>
        /// <param name="groupProperties">The properties to be updated or inserted onto the group. Each property in              the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroupProperties</returns>
        ApiResponse<PortfolioGroupProperties> UpsertGroupPropertiesWithHttpInfo (string scope, string code, Dictionary<string, Property> groupProperties = default(Dictionary<string, Property>));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPortfolioGroupsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [EARLY ACCESS] Add portfolio to group
        /// </summary>
        /// <remarks>
        /// Add a single portfolio to a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be added to the group.</param>
        /// <param name="portfolioId">The resource identifier of the portfolio to add to the portfolio group. (optional)</param>
        /// <returns>Task of PortfolioGroup</returns>
        System.Threading.Tasks.Task<PortfolioGroup> AddPortfolioToGroupAsync (string scope, string code, DateTimeOffset effectiveAt, ResourceId portfolioId = default(ResourceId));

        /// <summary>
        /// [EARLY ACCESS] Add portfolio to group
        /// </summary>
        /// <remarks>
        /// Add a single portfolio to a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be added to the group.</param>
        /// <param name="portfolioId">The resource identifier of the portfolio to add to the portfolio group. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioGroup>> AddPortfolioToGroupAsyncWithHttpInfo (string scope, string code, DateTimeOffset effectiveAt, ResourceId portfolioId = default(ResourceId));
        /// <summary>
        /// [EARLY ACCESS] Add sub group to group
        /// </summary>
        /// <remarks>
        /// Add a portfolio group to a portfolio group as a sub group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio group to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio group to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be added to the group.</param>
        /// <param name="portfolioGroupId">The resource identifier of the portfolio group to add to the portfolio group as a sub group. (optional)</param>
        /// <returns>Task of PortfolioGroup</returns>
        System.Threading.Tasks.Task<PortfolioGroup> AddSubGroupToGroupAsync (string scope, string code, DateTimeOffset effectiveAt, ResourceId portfolioGroupId = default(ResourceId));

        /// <summary>
        /// [EARLY ACCESS] Add sub group to group
        /// </summary>
        /// <remarks>
        /// Add a portfolio group to a portfolio group as a sub group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio group to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio group to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be added to the group.</param>
        /// <param name="portfolioGroupId">The resource identifier of the portfolio group to add to the portfolio group as a sub group. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioGroup>> AddSubGroupToGroupAsyncWithHttpInfo (string scope, string code, DateTimeOffset effectiveAt, ResourceId portfolioGroupId = default(ResourceId));
        /// <summary>
        /// [EARLY ACCESS] Create portfolio group
        /// </summary>
        /// <remarks>
        /// Create a portfolio group in a specific scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope that the portfolio group will be created in.</param>
        /// <param name="request">The definition and details of the portfolio group. (optional)</param>
        /// <returns>Task of PortfolioGroup</returns>
        System.Threading.Tasks.Task<PortfolioGroup> CreatePortfolioGroupAsync (string scope, CreatePortfolioGroupRequest request = default(CreatePortfolioGroupRequest));

        /// <summary>
        /// [EARLY ACCESS] Create portfolio group
        /// </summary>
        /// <remarks>
        /// Create a portfolio group in a specific scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope that the portfolio group will be created in.</param>
        /// <param name="request">The definition and details of the portfolio group. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioGroup>> CreatePortfolioGroupAsyncWithHttpInfo (string scope, CreatePortfolioGroupRequest request = default(CreatePortfolioGroupRequest));
        /// <summary>
        /// [EARLY ACCESS] Delete group properties
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a single portfolio group. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to delete properties from.</param>
        /// <param name="code">The code of the group to delete properties from. Together with the scope this uniquely identifies the group.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the properties. (optional)</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeleteGroupPropertiesAsync (string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel));

        /// <summary>
        /// [EARLY ACCESS] Delete group properties
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a single portfolio group. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to delete properties from.</param>
        /// <param name="code">The code of the group to delete properties from. Together with the scope this uniquely identifies the group.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the properties. (optional)</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeleteGroupPropertiesAsyncWithHttpInfo (string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel));
        /// <summary>
        /// [EARLY ACCESS] Delete portfolio from group
        /// </summary>
        /// <remarks>
        /// Remove a single portfolio from a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the portfolio from.</param>
        /// <param name="code">The code of the portfolio group to remove the portfolio from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="portfolioScope">The scope of the portfolio being removed from the portfolio group.</param>
        /// <param name="portfolioCode">The code of the portfolio being removed from the portfolio group. Together with the scope this uniquely identifies the portfolio to remove.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be removed from the portfolio group.</param>
        /// <returns>Task of PortfolioGroup</returns>
        System.Threading.Tasks.Task<PortfolioGroup> DeletePortfolioFromGroupAsync (string scope, string code, string portfolioScope, string portfolioCode, DateTimeOffset effectiveAt);

        /// <summary>
        /// [EARLY ACCESS] Delete portfolio from group
        /// </summary>
        /// <remarks>
        /// Remove a single portfolio from a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the portfolio from.</param>
        /// <param name="code">The code of the portfolio group to remove the portfolio from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="portfolioScope">The scope of the portfolio being removed from the portfolio group.</param>
        /// <param name="portfolioCode">The code of the portfolio being removed from the portfolio group. Together with the scope this uniquely identifies the portfolio to remove.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be removed from the portfolio group.</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioGroup>> DeletePortfolioFromGroupAsyncWithHttpInfo (string scope, string code, string portfolioScope, string portfolioCode, DateTimeOffset effectiveAt);
        /// <summary>
        /// [EARLY ACCESS] Delete portfolio group
        /// </summary>
        /// <remarks>
        /// Delete a single portfolio group. A portfolio group can be deleted while it still contains portfolios or sub groups.  In this case any portfolios or sub groups contained in this group will not be deleted, however they will no longer be grouped together by this portfolio group.  The deletion will be valid from the portfolio group&#39;s creation datetime, ie. the portfolio group will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to delete.</param>
        /// <param name="code">The code of the portfolio group to delete. Together with the scope this uniquely identifies the portfolio group to delete.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeletePortfolioGroupAsync (string scope, string code);

        /// <summary>
        /// [EARLY ACCESS] Delete portfolio group
        /// </summary>
        /// <remarks>
        /// Delete a single portfolio group. A portfolio group can be deleted while it still contains portfolios or sub groups.  In this case any portfolios or sub groups contained in this group will not be deleted, however they will no longer be grouped together by this portfolio group.  The deletion will be valid from the portfolio group&#39;s creation datetime, ie. the portfolio group will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to delete.</param>
        /// <param name="code">The code of the portfolio group to delete. Together with the scope this uniquely identifies the portfolio group to delete.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeletePortfolioGroupAsyncWithHttpInfo (string scope, string code);
        /// <summary>
        /// [EARLY ACCESS] Delete sub group from group
        /// </summary>
        /// <remarks>
        /// Remove a single portfolio group (sub group) from a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the sub group from.</param>
        /// <param name="code">The code of the portfolio group to remove the sub group from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="subgroupScope">The scope of the sub group to remove from the portfolio group.</param>
        /// <param name="subgroupCode">The code of the sub group to remove from the portfolio group. Together with the scope this uniquely identifies the sub group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be removed from the portfolio group.</param>
        /// <returns>Task of PortfolioGroup</returns>
        System.Threading.Tasks.Task<PortfolioGroup> DeleteSubGroupFromGroupAsync (string scope, string code, string subgroupScope, string subgroupCode, DateTimeOffset effectiveAt);

        /// <summary>
        /// [EARLY ACCESS] Delete sub group from group
        /// </summary>
        /// <remarks>
        /// Remove a single portfolio group (sub group) from a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the sub group from.</param>
        /// <param name="code">The code of the portfolio group to remove the sub group from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="subgroupScope">The scope of the sub group to remove from the portfolio group.</param>
        /// <param name="subgroupCode">The code of the sub group to remove from the portfolio group. Together with the scope this uniquely identifies the sub group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be removed from the portfolio group.</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioGroup>> DeleteSubGroupFromGroupAsyncWithHttpInfo (string scope, string code, string subgroupScope, string subgroupCode, DateTimeOffset effectiveAt);
        /// <summary>
        /// [EARLY ACCESS] Get group properties
        /// </summary>
        /// <remarks>
        /// List all the properties of a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to list the properties for.</param>
        /// <param name="code">The code of the group to list the properties for. Together with the scope this uniquely identifies the group.</param>
        /// <param name="effectiveAt">The effective date time or cut label at which to list the group&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt date time at which to list the group&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <returns>Task of PortfolioGroupProperties</returns>
        System.Threading.Tasks.Task<PortfolioGroupProperties> GetGroupPropertiesAsync (string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] Get group properties
        /// </summary>
        /// <remarks>
        /// List all the properties of a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to list the properties for.</param>
        /// <param name="code">The code of the group to list the properties for. Together with the scope this uniquely identifies the group.</param>
        /// <param name="effectiveAt">The effective date time or cut label at which to list the group&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt date time at which to list the group&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioGroupProperties)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioGroupProperties>> GetGroupPropertiesAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] Get portfolio group
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the definition for. Together with the scope              this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to retrieve the portfolio group definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio group definition. Defaults to return              the latest version of the portfolio group definition if not specified. (optional)</param>
        /// <returns>Task of PortfolioGroup</returns>
        System.Threading.Tasks.Task<PortfolioGroup> GetPortfolioGroupAsync (string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] Get portfolio group
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the definition for. Together with the scope              this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to retrieve the portfolio group definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio group definition. Defaults to return              the latest version of the portfolio group definition if not specified. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioGroup>> GetPortfolioGroupAsyncWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] Get portfolio group commands
        /// </summary>
        /// <remarks>
        /// Gets all the commands that modified a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the commands for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>Task of ResourceListOfProcessedCommand</returns>
        System.Threading.Tasks.Task<ResourceListOfProcessedCommand> GetPortfolioGroupCommandsAsync (string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string));

        /// <summary>
        /// [EARLY ACCESS] Get portfolio group commands
        /// </summary>
        /// <remarks>
        /// Gets all the commands that modified a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the commands for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfProcessedCommand)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfProcessedCommand>> GetPortfolioGroupCommandsAsyncWithHttpInfo (string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string));
        /// <summary>
        /// [EARLY ACCESS] Get portfolio group expansion
        /// </summary>
        /// <remarks>
        /// List all the portfolios in a group, including all portfolios within sub groups in the group. Each portfolio will be decorated with all of its properties unless a property filter is specified.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to expand.</param>
        /// <param name="code">The code of the portfolio group to expand. Together with the scope this uniquely identifies the portfolio              group to expand.</param>
        /// <param name="effectiveAt">The effective datetime at which to expand the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to expand the portfolio group. Defaults to return the latest version of each portfolio in the group if not specified. (optional)</param>
        /// <param name="propertyFilter">The restricted list of property keys from the \&quot;Portfolio\&quot; domain which will be decorated onto each portfolio. These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>Task of ExpandedGroup</returns>
        System.Threading.Tasks.Task<ExpandedGroup> GetPortfolioGroupExpansionAsync (string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyFilter = default(List<string>));

        /// <summary>
        /// [EARLY ACCESS] Get portfolio group expansion
        /// </summary>
        /// <remarks>
        /// List all the portfolios in a group, including all portfolios within sub groups in the group. Each portfolio will be decorated with all of its properties unless a property filter is specified.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to expand.</param>
        /// <param name="code">The code of the portfolio group to expand. Together with the scope this uniquely identifies the portfolio              group to expand.</param>
        /// <param name="effectiveAt">The effective datetime at which to expand the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to expand the portfolio group. Defaults to return the latest version of each portfolio in the group if not specified. (optional)</param>
        /// <param name="propertyFilter">The restricted list of property keys from the \&quot;Portfolio\&quot; domain which will be decorated onto each portfolio. These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ExpandedGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExpandedGroup>> GetPortfolioGroupExpansionAsyncWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyFilter = default(List<string>));
        /// <summary>
        /// [EARLY ACCESS] List portfolio groups
        /// </summary>
        /// <remarks>
        /// List all the portfolio groups in a single scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to list the portfolio groups in.</param>
        /// <param name="effectiveAt">The effective datetime at which to list the portfolio groups. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio groups. Defaults to return the latest version of each portfolio group if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>Task of ResourceListOfPortfolioGroup</returns>
        System.Threading.Tasks.Task<ResourceListOfPortfolioGroup> ListPortfolioGroupsAsync (string scope, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string));

        /// <summary>
        /// [EARLY ACCESS] List portfolio groups
        /// </summary>
        /// <remarks>
        /// List all the portfolio groups in a single scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to list the portfolio groups in.</param>
        /// <param name="effectiveAt">The effective datetime at which to list the portfolio groups. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio groups. Defaults to return the latest version of each portfolio group if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfPortfolioGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfPortfolioGroup>> ListPortfolioGroupsAsyncWithHttpInfo (string scope, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string));
        /// <summary>
        /// [EARLY ACCESS] Update portfolio group
        /// </summary>
        /// <remarks>
        /// Update the definition of a single portfolio group. Not all elements within a portfolio group definition are modifiable  due to the potential implications for data already stored against the portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to update the definition for.</param>
        /// <param name="code">The code of the portfolio group to update the definition for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to update the definition.</param>
        /// <param name="request">The updated portfolio group definition. (optional)</param>
        /// <returns>Task of PortfolioGroup</returns>
        System.Threading.Tasks.Task<PortfolioGroup> UpdatePortfolioGroupAsync (string scope, string code, DateTimeOffset effectiveAt, UpdatePortfolioGroupRequest request = default(UpdatePortfolioGroupRequest));

        /// <summary>
        /// [EARLY ACCESS] Update portfolio group
        /// </summary>
        /// <remarks>
        /// Update the definition of a single portfolio group. Not all elements within a portfolio group definition are modifiable  due to the potential implications for data already stored against the portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to update the definition for.</param>
        /// <param name="code">The code of the portfolio group to update the definition for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to update the definition.</param>
        /// <param name="request">The updated portfolio group definition. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioGroup>> UpdatePortfolioGroupAsyncWithHttpInfo (string scope, string code, DateTimeOffset effectiveAt, UpdatePortfolioGroupRequest request = default(UpdatePortfolioGroupRequest));
        /// <summary>
        /// [EARLY ACCESS] Upsert group properties
        /// </summary>
        /// <remarks>
        /// Update or insert one or more properties onto a single group. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;PortfolioGroup&#39;.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to update or insert the properties onto.</param>
        /// <param name="code">The code of the group to update or insert the properties onto. Together with the scope this uniquely identifies the group.</param>
        /// <param name="groupProperties">The properties to be updated or inserted onto the group. Each property in              the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. (optional)</param>
        /// <returns>Task of PortfolioGroupProperties</returns>
        System.Threading.Tasks.Task<PortfolioGroupProperties> UpsertGroupPropertiesAsync (string scope, string code, Dictionary<string, Property> groupProperties = default(Dictionary<string, Property>));

        /// <summary>
        /// [EARLY ACCESS] Upsert group properties
        /// </summary>
        /// <remarks>
        /// Update or insert one or more properties onto a single group. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;PortfolioGroup&#39;.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to update or insert the properties onto.</param>
        /// <param name="code">The code of the group to update or insert the properties onto. Together with the scope this uniquely identifies the group.</param>
        /// <param name="groupProperties">The properties to be updated or inserted onto the group. Each property in              the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioGroupProperties)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioGroupProperties>> UpsertGroupPropertiesAsyncWithHttpInfo (string scope, string code, Dictionary<string, Property> groupProperties = default(Dictionary<string, Property>));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPortfolioGroupsApi : IPortfolioGroupsApiSync, IPortfolioGroupsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PortfolioGroupsApi : IPortfolioGroupsApi
    {
        private Lusid.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioGroupsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PortfolioGroupsApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioGroupsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PortfolioGroupsApi(String basePath)
        {
            this.Configuration = Lusid.Sdk.Client.Configuration.MergeConfigurations(
                Lusid.Sdk.Client.GlobalConfiguration.Instance,
                new Lusid.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioGroupsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PortfolioGroupsApi(Lusid.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Lusid.Sdk.Client.Configuration.MergeConfigurations(
                Lusid.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioGroupsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PortfolioGroupsApi(Lusid.Sdk.Client.ISynchronousClient client,Lusid.Sdk.Client.IAsynchronousClient asyncClient, Lusid.Sdk.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Lusid.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Lusid.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Lusid.Sdk.Client.IReadableConfiguration Configuration {get; set;}

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
        /// [EARLY ACCESS] Add portfolio to group Add a single portfolio to a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be added to the group.</param>
        /// <param name="portfolioId">The resource identifier of the portfolio to add to the portfolio group. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        public PortfolioGroup AddPortfolioToGroup (string scope, string code, DateTimeOffset effectiveAt, ResourceId portfolioId = default(ResourceId))
        {
             Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = AddPortfolioToGroupWithHttpInfo(scope, code, effectiveAt, portfolioId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Add portfolio to group Add a single portfolio to a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be added to the group.</param>
        /// <param name="portfolioId">The resource identifier of the portfolio to add to the portfolio group. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        public Lusid.Sdk.Client.ApiResponse< PortfolioGroup > AddPortfolioToGroupWithHttpInfo (string scope, string code, DateTimeOffset effectiveAt, ResourceId portfolioId = default(ResourceId))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->AddPortfolioToGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->AddPortfolioToGroup");

            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'effectiveAt' when calling PortfolioGroupsApi->AddPortfolioToGroup");

            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (effectiveAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            localVarRequestOptions.Data = portfolioId;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< PortfolioGroup >("/api/portfoliogroups/{scope}/{code}/portfolios", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddPortfolioToGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Add portfolio to group Add a single portfolio to a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be added to the group.</param>
        /// <param name="portfolioId">The resource identifier of the portfolio to add to the portfolio group. (optional)</param>
        /// <returns>Task of PortfolioGroup</returns>
        public async System.Threading.Tasks.Task<PortfolioGroup> AddPortfolioToGroupAsync (string scope, string code, DateTimeOffset effectiveAt, ResourceId portfolioId = default(ResourceId))
        {
             Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = await AddPortfolioToGroupAsyncWithHttpInfo(scope, code, effectiveAt, portfolioId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Add portfolio to group Add a single portfolio to a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be added to the group.</param>
        /// <param name="portfolioId">The resource identifier of the portfolio to add to the portfolio group. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PortfolioGroup>> AddPortfolioToGroupAsyncWithHttpInfo (string scope, string code, DateTimeOffset effectiveAt, ResourceId portfolioId = default(ResourceId))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->AddPortfolioToGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->AddPortfolioToGroup");

            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'effectiveAt' when calling PortfolioGroupsApi->AddPortfolioToGroup");


            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (effectiveAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            localVarRequestOptions.Data = portfolioId;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<PortfolioGroup>("/api/portfoliogroups/{scope}/{code}/portfolios", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddPortfolioToGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Add sub group to group Add a portfolio group to a portfolio group as a sub group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio group to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio group to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be added to the group.</param>
        /// <param name="portfolioGroupId">The resource identifier of the portfolio group to add to the portfolio group as a sub group. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        public PortfolioGroup AddSubGroupToGroup (string scope, string code, DateTimeOffset effectiveAt, ResourceId portfolioGroupId = default(ResourceId))
        {
             Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = AddSubGroupToGroupWithHttpInfo(scope, code, effectiveAt, portfolioGroupId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Add sub group to group Add a portfolio group to a portfolio group as a sub group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio group to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio group to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be added to the group.</param>
        /// <param name="portfolioGroupId">The resource identifier of the portfolio group to add to the portfolio group as a sub group. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        public Lusid.Sdk.Client.ApiResponse< PortfolioGroup > AddSubGroupToGroupWithHttpInfo (string scope, string code, DateTimeOffset effectiveAt, ResourceId portfolioGroupId = default(ResourceId))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->AddSubGroupToGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->AddSubGroupToGroup");

            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'effectiveAt' when calling PortfolioGroupsApi->AddSubGroupToGroup");

            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (effectiveAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            localVarRequestOptions.Data = portfolioGroupId;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< PortfolioGroup >("/api/portfoliogroups/{scope}/{code}/subgroups", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddSubGroupToGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Add sub group to group Add a portfolio group to a portfolio group as a sub group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio group to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio group to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be added to the group.</param>
        /// <param name="portfolioGroupId">The resource identifier of the portfolio group to add to the portfolio group as a sub group. (optional)</param>
        /// <returns>Task of PortfolioGroup</returns>
        public async System.Threading.Tasks.Task<PortfolioGroup> AddSubGroupToGroupAsync (string scope, string code, DateTimeOffset effectiveAt, ResourceId portfolioGroupId = default(ResourceId))
        {
             Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = await AddSubGroupToGroupAsyncWithHttpInfo(scope, code, effectiveAt, portfolioGroupId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Add sub group to group Add a portfolio group to a portfolio group as a sub group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio group to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio group to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be added to the group.</param>
        /// <param name="portfolioGroupId">The resource identifier of the portfolio group to add to the portfolio group as a sub group. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PortfolioGroup>> AddSubGroupToGroupAsyncWithHttpInfo (string scope, string code, DateTimeOffset effectiveAt, ResourceId portfolioGroupId = default(ResourceId))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->AddSubGroupToGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->AddSubGroupToGroup");

            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'effectiveAt' when calling PortfolioGroupsApi->AddSubGroupToGroup");


            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (effectiveAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            localVarRequestOptions.Data = portfolioGroupId;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<PortfolioGroup>("/api/portfoliogroups/{scope}/{code}/subgroups", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddSubGroupToGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Create portfolio group Create a portfolio group in a specific scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope that the portfolio group will be created in.</param>
        /// <param name="request">The definition and details of the portfolio group. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        public PortfolioGroup CreatePortfolioGroup (string scope, CreatePortfolioGroupRequest request = default(CreatePortfolioGroupRequest))
        {
             Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = CreatePortfolioGroupWithHttpInfo(scope, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Create portfolio group Create a portfolio group in a specific scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope that the portfolio group will be created in.</param>
        /// <param name="request">The definition and details of the portfolio group. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        public Lusid.Sdk.Client.ApiResponse< PortfolioGroup > CreatePortfolioGroupWithHttpInfo (string scope, CreatePortfolioGroupRequest request = default(CreatePortfolioGroupRequest))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->CreatePortfolioGroup");

            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            localVarRequestOptions.Data = request;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< PortfolioGroup >("/api/portfoliogroups/{scope}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreatePortfolioGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Create portfolio group Create a portfolio group in a specific scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope that the portfolio group will be created in.</param>
        /// <param name="request">The definition and details of the portfolio group. (optional)</param>
        /// <returns>Task of PortfolioGroup</returns>
        public async System.Threading.Tasks.Task<PortfolioGroup> CreatePortfolioGroupAsync (string scope, CreatePortfolioGroupRequest request = default(CreatePortfolioGroupRequest))
        {
             Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = await CreatePortfolioGroupAsyncWithHttpInfo(scope, request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Create portfolio group Create a portfolio group in a specific scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope that the portfolio group will be created in.</param>
        /// <param name="request">The definition and details of the portfolio group. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PortfolioGroup>> CreatePortfolioGroupAsyncWithHttpInfo (string scope, CreatePortfolioGroupRequest request = default(CreatePortfolioGroupRequest))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->CreatePortfolioGroup");


            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            localVarRequestOptions.Data = request;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<PortfolioGroup>("/api/portfoliogroups/{scope}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreatePortfolioGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Delete group properties Delete one or more properties from a single portfolio group. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to delete properties from.</param>
        /// <param name="code">The code of the group to delete properties from. Together with the scope this uniquely identifies the group.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the properties. (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeleteGroupProperties (string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel))
        {
             Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = DeleteGroupPropertiesWithHttpInfo(scope, code, propertyKeys, effectiveAt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Delete group properties Delete one or more properties from a single portfolio group. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to delete properties from.</param>
        /// <param name="code">The code of the group to delete properties from. Together with the scope this uniquely identifies the group.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the properties. (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public Lusid.Sdk.Client.ApiResponse< DeletedEntityResponse > DeleteGroupPropertiesWithHttpInfo (string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->DeleteGroupProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->DeleteGroupProperties");

            // verify the required parameter 'propertyKeys' is set
            if (propertyKeys == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'propertyKeys' when calling PortfolioGroupsApi->DeleteGroupProperties");

            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (effectiveAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            localVarRequestOptions.Data = propertyKeys;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< DeletedEntityResponse >("/api/portfoliogroups/{scope}/{code}/properties/$delete", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteGroupProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Delete group properties Delete one or more properties from a single portfolio group. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to delete properties from.</param>
        /// <param name="code">The code of the group to delete properties from. Together with the scope this uniquely identifies the group.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the properties. (optional)</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeleteGroupPropertiesAsync (string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel))
        {
             Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = await DeleteGroupPropertiesAsyncWithHttpInfo(scope, code, propertyKeys, effectiveAt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Delete group properties Delete one or more properties from a single portfolio group. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to delete properties from.</param>
        /// <param name="code">The code of the group to delete properties from. Together with the scope this uniquely identifies the group.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the properties. (optional)</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse>> DeleteGroupPropertiesAsyncWithHttpInfo (string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->DeleteGroupProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->DeleteGroupProperties");

            // verify the required parameter 'propertyKeys' is set
            if (propertyKeys == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'propertyKeys' when calling PortfolioGroupsApi->DeleteGroupProperties");


            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (effectiveAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            localVarRequestOptions.Data = propertyKeys;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<DeletedEntityResponse>("/api/portfoliogroups/{scope}/{code}/properties/$delete", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteGroupProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Delete portfolio from group Remove a single portfolio from a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the portfolio from.</param>
        /// <param name="code">The code of the portfolio group to remove the portfolio from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="portfolioScope">The scope of the portfolio being removed from the portfolio group.</param>
        /// <param name="portfolioCode">The code of the portfolio being removed from the portfolio group. Together with the scope this uniquely identifies the portfolio to remove.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be removed from the portfolio group.</param>
        /// <returns>PortfolioGroup</returns>
        public PortfolioGroup DeletePortfolioFromGroup (string scope, string code, string portfolioScope, string portfolioCode, DateTimeOffset effectiveAt)
        {
             Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = DeletePortfolioFromGroupWithHttpInfo(scope, code, portfolioScope, portfolioCode, effectiveAt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Delete portfolio from group Remove a single portfolio from a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the portfolio from.</param>
        /// <param name="code">The code of the portfolio group to remove the portfolio from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="portfolioScope">The scope of the portfolio being removed from the portfolio group.</param>
        /// <param name="portfolioCode">The code of the portfolio being removed from the portfolio group. Together with the scope this uniquely identifies the portfolio to remove.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be removed from the portfolio group.</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        public Lusid.Sdk.Client.ApiResponse< PortfolioGroup > DeletePortfolioFromGroupWithHttpInfo (string scope, string code, string portfolioScope, string portfolioCode, DateTimeOffset effectiveAt)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->DeletePortfolioFromGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->DeletePortfolioFromGroup");

            // verify the required parameter 'portfolioScope' is set
            if (portfolioScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'portfolioScope' when calling PortfolioGroupsApi->DeletePortfolioFromGroup");

            // verify the required parameter 'portfolioCode' is set
            if (portfolioCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'portfolioCode' when calling PortfolioGroupsApi->DeletePortfolioFromGroup");

            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'effectiveAt' when calling PortfolioGroupsApi->DeletePortfolioFromGroup");

            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (portfolioScope != null)
                localVarRequestOptions.PathParameters.Add("portfolioScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(portfolioScope)); // path parameter
            if (portfolioCode != null)
                localVarRequestOptions.PathParameters.Add("portfolioCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(portfolioCode)); // path parameter
            if (effectiveAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete< PortfolioGroup >("/api/portfoliogroups/{scope}/{code}/portfolios/{portfolioScope}/{portfolioCode}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePortfolioFromGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Delete portfolio from group Remove a single portfolio from a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the portfolio from.</param>
        /// <param name="code">The code of the portfolio group to remove the portfolio from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="portfolioScope">The scope of the portfolio being removed from the portfolio group.</param>
        /// <param name="portfolioCode">The code of the portfolio being removed from the portfolio group. Together with the scope this uniquely identifies the portfolio to remove.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be removed from the portfolio group.</param>
        /// <returns>Task of PortfolioGroup</returns>
        public async System.Threading.Tasks.Task<PortfolioGroup> DeletePortfolioFromGroupAsync (string scope, string code, string portfolioScope, string portfolioCode, DateTimeOffset effectiveAt)
        {
             Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = await DeletePortfolioFromGroupAsyncWithHttpInfo(scope, code, portfolioScope, portfolioCode, effectiveAt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Delete portfolio from group Remove a single portfolio from a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the portfolio from.</param>
        /// <param name="code">The code of the portfolio group to remove the portfolio from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="portfolioScope">The scope of the portfolio being removed from the portfolio group.</param>
        /// <param name="portfolioCode">The code of the portfolio being removed from the portfolio group. Together with the scope this uniquely identifies the portfolio to remove.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be removed from the portfolio group.</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PortfolioGroup>> DeletePortfolioFromGroupAsyncWithHttpInfo (string scope, string code, string portfolioScope, string portfolioCode, DateTimeOffset effectiveAt)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->DeletePortfolioFromGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->DeletePortfolioFromGroup");

            // verify the required parameter 'portfolioScope' is set
            if (portfolioScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'portfolioScope' when calling PortfolioGroupsApi->DeletePortfolioFromGroup");

            // verify the required parameter 'portfolioCode' is set
            if (portfolioCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'portfolioCode' when calling PortfolioGroupsApi->DeletePortfolioFromGroup");

            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'effectiveAt' when calling PortfolioGroupsApi->DeletePortfolioFromGroup");


            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (portfolioScope != null)
                localVarRequestOptions.PathParameters.Add("portfolioScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(portfolioScope)); // path parameter
            if (portfolioCode != null)
                localVarRequestOptions.PathParameters.Add("portfolioCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(portfolioCode)); // path parameter
            if (effectiveAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<PortfolioGroup>("/api/portfoliogroups/{scope}/{code}/portfolios/{portfolioScope}/{portfolioCode}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePortfolioFromGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Delete portfolio group Delete a single portfolio group. A portfolio group can be deleted while it still contains portfolios or sub groups.  In this case any portfolios or sub groups contained in this group will not be deleted, however they will no longer be grouped together by this portfolio group.  The deletion will be valid from the portfolio group&#39;s creation datetime, ie. the portfolio group will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to delete.</param>
        /// <param name="code">The code of the portfolio group to delete. Together with the scope this uniquely identifies the portfolio group to delete.</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeletePortfolioGroup (string scope, string code)
        {
             Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = DeletePortfolioGroupWithHttpInfo(scope, code);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Delete portfolio group Delete a single portfolio group. A portfolio group can be deleted while it still contains portfolios or sub groups.  In this case any portfolios or sub groups contained in this group will not be deleted, however they will no longer be grouped together by this portfolio group.  The deletion will be valid from the portfolio group&#39;s creation datetime, ie. the portfolio group will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to delete.</param>
        /// <param name="code">The code of the portfolio group to delete. Together with the scope this uniquely identifies the portfolio group to delete.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public Lusid.Sdk.Client.ApiResponse< DeletedEntityResponse > DeletePortfolioGroupWithHttpInfo (string scope, string code)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->DeletePortfolioGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->DeletePortfolioGroup");

            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete< DeletedEntityResponse >("/api/portfoliogroups/{scope}/{code}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePortfolioGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Delete portfolio group Delete a single portfolio group. A portfolio group can be deleted while it still contains portfolios or sub groups.  In this case any portfolios or sub groups contained in this group will not be deleted, however they will no longer be grouped together by this portfolio group.  The deletion will be valid from the portfolio group&#39;s creation datetime, ie. the portfolio group will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to delete.</param>
        /// <param name="code">The code of the portfolio group to delete. Together with the scope this uniquely identifies the portfolio group to delete.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeletePortfolioGroupAsync (string scope, string code)
        {
             Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = await DeletePortfolioGroupAsyncWithHttpInfo(scope, code);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Delete portfolio group Delete a single portfolio group. A portfolio group can be deleted while it still contains portfolios or sub groups.  In this case any portfolios or sub groups contained in this group will not be deleted, however they will no longer be grouped together by this portfolio group.  The deletion will be valid from the portfolio group&#39;s creation datetime, ie. the portfolio group will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to delete.</param>
        /// <param name="code">The code of the portfolio group to delete. Together with the scope this uniquely identifies the portfolio group to delete.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse>> DeletePortfolioGroupAsyncWithHttpInfo (string scope, string code)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->DeletePortfolioGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->DeletePortfolioGroup");


            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<DeletedEntityResponse>("/api/portfoliogroups/{scope}/{code}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePortfolioGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Delete sub group from group Remove a single portfolio group (sub group) from a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the sub group from.</param>
        /// <param name="code">The code of the portfolio group to remove the sub group from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="subgroupScope">The scope of the sub group to remove from the portfolio group.</param>
        /// <param name="subgroupCode">The code of the sub group to remove from the portfolio group. Together with the scope this uniquely identifies the sub group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be removed from the portfolio group.</param>
        /// <returns>PortfolioGroup</returns>
        public PortfolioGroup DeleteSubGroupFromGroup (string scope, string code, string subgroupScope, string subgroupCode, DateTimeOffset effectiveAt)
        {
             Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = DeleteSubGroupFromGroupWithHttpInfo(scope, code, subgroupScope, subgroupCode, effectiveAt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Delete sub group from group Remove a single portfolio group (sub group) from a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the sub group from.</param>
        /// <param name="code">The code of the portfolio group to remove the sub group from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="subgroupScope">The scope of the sub group to remove from the portfolio group.</param>
        /// <param name="subgroupCode">The code of the sub group to remove from the portfolio group. Together with the scope this uniquely identifies the sub group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be removed from the portfolio group.</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        public Lusid.Sdk.Client.ApiResponse< PortfolioGroup > DeleteSubGroupFromGroupWithHttpInfo (string scope, string code, string subgroupScope, string subgroupCode, DateTimeOffset effectiveAt)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->DeleteSubGroupFromGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->DeleteSubGroupFromGroup");

            // verify the required parameter 'subgroupScope' is set
            if (subgroupScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'subgroupScope' when calling PortfolioGroupsApi->DeleteSubGroupFromGroup");

            // verify the required parameter 'subgroupCode' is set
            if (subgroupCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'subgroupCode' when calling PortfolioGroupsApi->DeleteSubGroupFromGroup");

            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'effectiveAt' when calling PortfolioGroupsApi->DeleteSubGroupFromGroup");

            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (subgroupScope != null)
                localVarRequestOptions.PathParameters.Add("subgroupScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(subgroupScope)); // path parameter
            if (subgroupCode != null)
                localVarRequestOptions.PathParameters.Add("subgroupCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(subgroupCode)); // path parameter
            if (effectiveAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete< PortfolioGroup >("/api/portfoliogroups/{scope}/{code}/subgroups/{subgroupScope}/{subgroupCode}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteSubGroupFromGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Delete sub group from group Remove a single portfolio group (sub group) from a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the sub group from.</param>
        /// <param name="code">The code of the portfolio group to remove the sub group from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="subgroupScope">The scope of the sub group to remove from the portfolio group.</param>
        /// <param name="subgroupCode">The code of the sub group to remove from the portfolio group. Together with the scope this uniquely identifies the sub group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be removed from the portfolio group.</param>
        /// <returns>Task of PortfolioGroup</returns>
        public async System.Threading.Tasks.Task<PortfolioGroup> DeleteSubGroupFromGroupAsync (string scope, string code, string subgroupScope, string subgroupCode, DateTimeOffset effectiveAt)
        {
             Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = await DeleteSubGroupFromGroupAsyncWithHttpInfo(scope, code, subgroupScope, subgroupCode, effectiveAt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Delete sub group from group Remove a single portfolio group (sub group) from a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the sub group from.</param>
        /// <param name="code">The code of the portfolio group to remove the sub group from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="subgroupScope">The scope of the sub group to remove from the portfolio group.</param>
        /// <param name="subgroupCode">The code of the sub group to remove from the portfolio group. Together with the scope this uniquely identifies the sub group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be removed from the portfolio group.</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PortfolioGroup>> DeleteSubGroupFromGroupAsyncWithHttpInfo (string scope, string code, string subgroupScope, string subgroupCode, DateTimeOffset effectiveAt)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->DeleteSubGroupFromGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->DeleteSubGroupFromGroup");

            // verify the required parameter 'subgroupScope' is set
            if (subgroupScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'subgroupScope' when calling PortfolioGroupsApi->DeleteSubGroupFromGroup");

            // verify the required parameter 'subgroupCode' is set
            if (subgroupCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'subgroupCode' when calling PortfolioGroupsApi->DeleteSubGroupFromGroup");

            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'effectiveAt' when calling PortfolioGroupsApi->DeleteSubGroupFromGroup");


            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (subgroupScope != null)
                localVarRequestOptions.PathParameters.Add("subgroupScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(subgroupScope)); // path parameter
            if (subgroupCode != null)
                localVarRequestOptions.PathParameters.Add("subgroupCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(subgroupCode)); // path parameter
            if (effectiveAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<PortfolioGroup>("/api/portfoliogroups/{scope}/{code}/subgroups/{subgroupScope}/{subgroupCode}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteSubGroupFromGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Get group properties List all the properties of a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to list the properties for.</param>
        /// <param name="code">The code of the group to list the properties for. Together with the scope this uniquely identifies the group.</param>
        /// <param name="effectiveAt">The effective date time or cut label at which to list the group&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt date time at which to list the group&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <returns>PortfolioGroupProperties</returns>
        public PortfolioGroupProperties GetGroupProperties (string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
             Lusid.Sdk.Client.ApiResponse<PortfolioGroupProperties> localVarResponse = GetGroupPropertiesWithHttpInfo(scope, code, effectiveAt, asAt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Get group properties List all the properties of a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to list the properties for.</param>
        /// <param name="code">The code of the group to list the properties for. Together with the scope this uniquely identifies the group.</param>
        /// <param name="effectiveAt">The effective date time or cut label at which to list the group&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt date time at which to list the group&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroupProperties</returns>
        public Lusid.Sdk.Client.ApiResponse< PortfolioGroupProperties > GetGroupPropertiesWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetGroupProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetGroupProperties");

            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (effectiveAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            if (asAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< PortfolioGroupProperties >("/api/portfoliogroups/{scope}/{code}/properties", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetGroupProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Get group properties List all the properties of a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to list the properties for.</param>
        /// <param name="code">The code of the group to list the properties for. Together with the scope this uniquely identifies the group.</param>
        /// <param name="effectiveAt">The effective date time or cut label at which to list the group&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt date time at which to list the group&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <returns>Task of PortfolioGroupProperties</returns>
        public async System.Threading.Tasks.Task<PortfolioGroupProperties> GetGroupPropertiesAsync (string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
             Lusid.Sdk.Client.ApiResponse<PortfolioGroupProperties> localVarResponse = await GetGroupPropertiesAsyncWithHttpInfo(scope, code, effectiveAt, asAt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Get group properties List all the properties of a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to list the properties for.</param>
        /// <param name="code">The code of the group to list the properties for. Together with the scope this uniquely identifies the group.</param>
        /// <param name="effectiveAt">The effective date time or cut label at which to list the group&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt date time at which to list the group&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioGroupProperties)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PortfolioGroupProperties>> GetGroupPropertiesAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetGroupProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetGroupProperties");


            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (effectiveAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            if (asAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<PortfolioGroupProperties>("/api/portfoliogroups/{scope}/{code}/properties", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetGroupProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Get portfolio group Retrieve the definition of a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the definition for. Together with the scope              this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to retrieve the portfolio group definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio group definition. Defaults to return              the latest version of the portfolio group definition if not specified. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        public PortfolioGroup GetPortfolioGroup (string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
             Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = GetPortfolioGroupWithHttpInfo(scope, code, effectiveAt, asAt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Get portfolio group Retrieve the definition of a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the definition for. Together with the scope              this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to retrieve the portfolio group definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio group definition. Defaults to return              the latest version of the portfolio group definition if not specified. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        public Lusid.Sdk.Client.ApiResponse< PortfolioGroup > GetPortfolioGroupWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetPortfolioGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetPortfolioGroup");

            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (effectiveAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            if (asAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< PortfolioGroup >("/api/portfoliogroups/{scope}/{code}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Get portfolio group Retrieve the definition of a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the definition for. Together with the scope              this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to retrieve the portfolio group definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio group definition. Defaults to return              the latest version of the portfolio group definition if not specified. (optional)</param>
        /// <returns>Task of PortfolioGroup</returns>
        public async System.Threading.Tasks.Task<PortfolioGroup> GetPortfolioGroupAsync (string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
             Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = await GetPortfolioGroupAsyncWithHttpInfo(scope, code, effectiveAt, asAt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Get portfolio group Retrieve the definition of a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the definition for. Together with the scope              this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to retrieve the portfolio group definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio group definition. Defaults to return              the latest version of the portfolio group definition if not specified. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PortfolioGroup>> GetPortfolioGroupAsyncWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetPortfolioGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetPortfolioGroup");


            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (effectiveAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            if (asAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<PortfolioGroup>("/api/portfoliogroups/{scope}/{code}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Get portfolio group commands Gets all the commands that modified a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the commands for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ResourceListOfProcessedCommand</returns>
        public ResourceListOfProcessedCommand GetPortfolioGroupCommands (string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string))
        {
             Lusid.Sdk.Client.ApiResponse<ResourceListOfProcessedCommand> localVarResponse = GetPortfolioGroupCommandsWithHttpInfo(scope, code, fromAsAt, toAsAt, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Get portfolio group commands Gets all the commands that modified a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the commands for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfProcessedCommand</returns>
        public Lusid.Sdk.Client.ApiResponse< ResourceListOfProcessedCommand > GetPortfolioGroupCommandsWithHttpInfo (string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetPortfolioGroupCommands");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetPortfolioGroupCommands");

            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (fromAsAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "fromAsAt", fromAsAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            if (toAsAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "toAsAt", toAsAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            if (filter != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< ResourceListOfProcessedCommand >("/api/portfoliogroups/{scope}/{code}/commands", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioGroupCommands", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Get portfolio group commands Gets all the commands that modified a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the commands for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>Task of ResourceListOfProcessedCommand</returns>
        public async System.Threading.Tasks.Task<ResourceListOfProcessedCommand> GetPortfolioGroupCommandsAsync (string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string))
        {
             Lusid.Sdk.Client.ApiResponse<ResourceListOfProcessedCommand> localVarResponse = await GetPortfolioGroupCommandsAsyncWithHttpInfo(scope, code, fromAsAt, toAsAt, filter);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Get portfolio group commands Gets all the commands that modified a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the commands for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfProcessedCommand)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfProcessedCommand>> GetPortfolioGroupCommandsAsyncWithHttpInfo (string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetPortfolioGroupCommands");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetPortfolioGroupCommands");


            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (fromAsAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "fromAsAt", fromAsAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            if (toAsAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "toAsAt", toAsAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            if (filter != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfProcessedCommand>("/api/portfoliogroups/{scope}/{code}/commands", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioGroupCommands", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Get portfolio group expansion List all the portfolios in a group, including all portfolios within sub groups in the group. Each portfolio will be decorated with all of its properties unless a property filter is specified.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to expand.</param>
        /// <param name="code">The code of the portfolio group to expand. Together with the scope this uniquely identifies the portfolio              group to expand.</param>
        /// <param name="effectiveAt">The effective datetime at which to expand the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to expand the portfolio group. Defaults to return the latest version of each portfolio in the group if not specified. (optional)</param>
        /// <param name="propertyFilter">The restricted list of property keys from the \&quot;Portfolio\&quot; domain which will be decorated onto each portfolio. These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>ExpandedGroup</returns>
        public ExpandedGroup GetPortfolioGroupExpansion (string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyFilter = default(List<string>))
        {
             Lusid.Sdk.Client.ApiResponse<ExpandedGroup> localVarResponse = GetPortfolioGroupExpansionWithHttpInfo(scope, code, effectiveAt, asAt, propertyFilter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Get portfolio group expansion List all the portfolios in a group, including all portfolios within sub groups in the group. Each portfolio will be decorated with all of its properties unless a property filter is specified.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to expand.</param>
        /// <param name="code">The code of the portfolio group to expand. Together with the scope this uniquely identifies the portfolio              group to expand.</param>
        /// <param name="effectiveAt">The effective datetime at which to expand the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to expand the portfolio group. Defaults to return the latest version of each portfolio in the group if not specified. (optional)</param>
        /// <param name="propertyFilter">The restricted list of property keys from the \&quot;Portfolio\&quot; domain which will be decorated onto each portfolio. These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>ApiResponse of ExpandedGroup</returns>
        public Lusid.Sdk.Client.ApiResponse< ExpandedGroup > GetPortfolioGroupExpansionWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyFilter = default(List<string>))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetPortfolioGroupExpansion");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetPortfolioGroupExpansion");

            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (effectiveAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            if (asAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            if (propertyFilter != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyFilter", propertyFilter))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< ExpandedGroup >("/api/portfoliogroups/{scope}/{code}/expansion", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioGroupExpansion", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Get portfolio group expansion List all the portfolios in a group, including all portfolios within sub groups in the group. Each portfolio will be decorated with all of its properties unless a property filter is specified.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to expand.</param>
        /// <param name="code">The code of the portfolio group to expand. Together with the scope this uniquely identifies the portfolio              group to expand.</param>
        /// <param name="effectiveAt">The effective datetime at which to expand the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to expand the portfolio group. Defaults to return the latest version of each portfolio in the group if not specified. (optional)</param>
        /// <param name="propertyFilter">The restricted list of property keys from the \&quot;Portfolio\&quot; domain which will be decorated onto each portfolio. These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>Task of ExpandedGroup</returns>
        public async System.Threading.Tasks.Task<ExpandedGroup> GetPortfolioGroupExpansionAsync (string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyFilter = default(List<string>))
        {
             Lusid.Sdk.Client.ApiResponse<ExpandedGroup> localVarResponse = await GetPortfolioGroupExpansionAsyncWithHttpInfo(scope, code, effectiveAt, asAt, propertyFilter);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Get portfolio group expansion List all the portfolios in a group, including all portfolios within sub groups in the group. Each portfolio will be decorated with all of its properties unless a property filter is specified.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to expand.</param>
        /// <param name="code">The code of the portfolio group to expand. Together with the scope this uniquely identifies the portfolio              group to expand.</param>
        /// <param name="effectiveAt">The effective datetime at which to expand the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to expand the portfolio group. Defaults to return the latest version of each portfolio in the group if not specified. (optional)</param>
        /// <param name="propertyFilter">The restricted list of property keys from the \&quot;Portfolio\&quot; domain which will be decorated onto each portfolio. These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ExpandedGroup)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ExpandedGroup>> GetPortfolioGroupExpansionAsyncWithHttpInfo (string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyFilter = default(List<string>))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetPortfolioGroupExpansion");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetPortfolioGroupExpansion");


            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (effectiveAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            if (asAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            if (propertyFilter != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyFilter", propertyFilter))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ExpandedGroup>("/api/portfoliogroups/{scope}/{code}/expansion", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioGroupExpansion", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] List portfolio groups List all the portfolio groups in a single scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to list the portfolio groups in.</param>
        /// <param name="effectiveAt">The effective datetime at which to list the portfolio groups. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio groups. Defaults to return the latest version of each portfolio group if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ResourceListOfPortfolioGroup</returns>
        public ResourceListOfPortfolioGroup ListPortfolioGroups (string scope, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string))
        {
             Lusid.Sdk.Client.ApiResponse<ResourceListOfPortfolioGroup> localVarResponse = ListPortfolioGroupsWithHttpInfo(scope, effectiveAt, asAt, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] List portfolio groups List all the portfolio groups in a single scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to list the portfolio groups in.</param>
        /// <param name="effectiveAt">The effective datetime at which to list the portfolio groups. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio groups. Defaults to return the latest version of each portfolio group if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPortfolioGroup</returns>
        public Lusid.Sdk.Client.ApiResponse< ResourceListOfPortfolioGroup > ListPortfolioGroupsWithHttpInfo (string scope, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->ListPortfolioGroups");

            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (effectiveAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            if (asAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            if (filter != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< ResourceListOfPortfolioGroup >("/api/portfoliogroups/{scope}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListPortfolioGroups", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] List portfolio groups List all the portfolio groups in a single scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to list the portfolio groups in.</param>
        /// <param name="effectiveAt">The effective datetime at which to list the portfolio groups. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio groups. Defaults to return the latest version of each portfolio group if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>Task of ResourceListOfPortfolioGroup</returns>
        public async System.Threading.Tasks.Task<ResourceListOfPortfolioGroup> ListPortfolioGroupsAsync (string scope, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string))
        {
             Lusid.Sdk.Client.ApiResponse<ResourceListOfPortfolioGroup> localVarResponse = await ListPortfolioGroupsAsyncWithHttpInfo(scope, effectiveAt, asAt, filter);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] List portfolio groups List all the portfolio groups in a single scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to list the portfolio groups in.</param>
        /// <param name="effectiveAt">The effective datetime at which to list the portfolio groups. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio groups. Defaults to return the latest version of each portfolio group if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfPortfolioGroup)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfPortfolioGroup>> ListPortfolioGroupsAsyncWithHttpInfo (string scope, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->ListPortfolioGroups");


            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (effectiveAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            if (asAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            if (filter != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfPortfolioGroup>("/api/portfoliogroups/{scope}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListPortfolioGroups", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Update portfolio group Update the definition of a single portfolio group. Not all elements within a portfolio group definition are modifiable  due to the potential implications for data already stored against the portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to update the definition for.</param>
        /// <param name="code">The code of the portfolio group to update the definition for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to update the definition.</param>
        /// <param name="request">The updated portfolio group definition. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        public PortfolioGroup UpdatePortfolioGroup (string scope, string code, DateTimeOffset effectiveAt, UpdatePortfolioGroupRequest request = default(UpdatePortfolioGroupRequest))
        {
             Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = UpdatePortfolioGroupWithHttpInfo(scope, code, effectiveAt, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Update portfolio group Update the definition of a single portfolio group. Not all elements within a portfolio group definition are modifiable  due to the potential implications for data already stored against the portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to update the definition for.</param>
        /// <param name="code">The code of the portfolio group to update the definition for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to update the definition.</param>
        /// <param name="request">The updated portfolio group definition. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        public Lusid.Sdk.Client.ApiResponse< PortfolioGroup > UpdatePortfolioGroupWithHttpInfo (string scope, string code, DateTimeOffset effectiveAt, UpdatePortfolioGroupRequest request = default(UpdatePortfolioGroupRequest))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->UpdatePortfolioGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->UpdatePortfolioGroup");

            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'effectiveAt' when calling PortfolioGroupsApi->UpdatePortfolioGroup");

            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (effectiveAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            localVarRequestOptions.Data = request;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put< PortfolioGroup >("/api/portfoliogroups/{scope}/{code}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdatePortfolioGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Update portfolio group Update the definition of a single portfolio group. Not all elements within a portfolio group definition are modifiable  due to the potential implications for data already stored against the portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to update the definition for.</param>
        /// <param name="code">The code of the portfolio group to update the definition for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to update the definition.</param>
        /// <param name="request">The updated portfolio group definition. (optional)</param>
        /// <returns>Task of PortfolioGroup</returns>
        public async System.Threading.Tasks.Task<PortfolioGroup> UpdatePortfolioGroupAsync (string scope, string code, DateTimeOffset effectiveAt, UpdatePortfolioGroupRequest request = default(UpdatePortfolioGroupRequest))
        {
             Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = await UpdatePortfolioGroupAsyncWithHttpInfo(scope, code, effectiveAt, request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Update portfolio group Update the definition of a single portfolio group. Not all elements within a portfolio group definition are modifiable  due to the potential implications for data already stored against the portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to update the definition for.</param>
        /// <param name="code">The code of the portfolio group to update the definition for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to update the definition.</param>
        /// <param name="request">The updated portfolio group definition. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PortfolioGroup>> UpdatePortfolioGroupAsyncWithHttpInfo (string scope, string code, DateTimeOffset effectiveAt, UpdatePortfolioGroupRequest request = default(UpdatePortfolioGroupRequest))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->UpdatePortfolioGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->UpdatePortfolioGroup");

            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'effectiveAt' when calling PortfolioGroupsApi->UpdatePortfolioGroup");


            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (effectiveAt != null)
            {
                foreach (var _kvp in Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            localVarRequestOptions.Data = request;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<PortfolioGroup>("/api/portfoliogroups/{scope}/{code}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdatePortfolioGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Upsert group properties Update or insert one or more properties onto a single group. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;PortfolioGroup&#39;.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to update or insert the properties onto.</param>
        /// <param name="code">The code of the group to update or insert the properties onto. Together with the scope this uniquely identifies the group.</param>
        /// <param name="groupProperties">The properties to be updated or inserted onto the group. Each property in              the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. (optional)</param>
        /// <returns>PortfolioGroupProperties</returns>
        public PortfolioGroupProperties UpsertGroupProperties (string scope, string code, Dictionary<string, Property> groupProperties = default(Dictionary<string, Property>))
        {
             Lusid.Sdk.Client.ApiResponse<PortfolioGroupProperties> localVarResponse = UpsertGroupPropertiesWithHttpInfo(scope, code, groupProperties);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Upsert group properties Update or insert one or more properties onto a single group. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;PortfolioGroup&#39;.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to update or insert the properties onto.</param>
        /// <param name="code">The code of the group to update or insert the properties onto. Together with the scope this uniquely identifies the group.</param>
        /// <param name="groupProperties">The properties to be updated or inserted onto the group. Each property in              the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroupProperties</returns>
        public Lusid.Sdk.Client.ApiResponse< PortfolioGroupProperties > UpsertGroupPropertiesWithHttpInfo (string scope, string code, Dictionary<string, Property> groupProperties = default(Dictionary<string, Property>))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->UpsertGroupProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->UpsertGroupProperties");

            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            localVarRequestOptions.Data = groupProperties;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< PortfolioGroupProperties >("/api/portfoliogroups/{scope}/{code}/properties/$upsert", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertGroupProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] Upsert group properties Update or insert one or more properties onto a single group. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;PortfolioGroup&#39;.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to update or insert the properties onto.</param>
        /// <param name="code">The code of the group to update or insert the properties onto. Together with the scope this uniquely identifies the group.</param>
        /// <param name="groupProperties">The properties to be updated or inserted onto the group. Each property in              the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. (optional)</param>
        /// <returns>Task of PortfolioGroupProperties</returns>
        public async System.Threading.Tasks.Task<PortfolioGroupProperties> UpsertGroupPropertiesAsync (string scope, string code, Dictionary<string, Property> groupProperties = default(Dictionary<string, Property>))
        {
             Lusid.Sdk.Client.ApiResponse<PortfolioGroupProperties> localVarResponse = await UpsertGroupPropertiesAsyncWithHttpInfo(scope, code, groupProperties);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Upsert group properties Update or insert one or more properties onto a single group. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;PortfolioGroup&#39;.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to update or insert the properties onto.</param>
        /// <param name="code">The code of the group to update or insert the properties onto. Together with the scope this uniquely identifies the group.</param>
        /// <param name="groupProperties">The properties to be updated or inserted onto the group. Each property in              the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioGroupProperties)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PortfolioGroupProperties>> UpsertGroupPropertiesAsyncWithHttpInfo (string scope, string code, Dictionary<string, Property> groupProperties = default(Dictionary<string, Property>))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->UpsertGroupProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->UpsertGroupProperties");


            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.10.888");

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (scope != null)
                localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (code != null)
                localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            localVarRequestOptions.Data = groupProperties;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<PortfolioGroupProperties>("/api/portfoliogroups/{scope}/{code}/properties/$upsert", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertGroupProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}