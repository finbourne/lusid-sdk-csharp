/* 
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://api.lusid.com/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages :  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python)  # Data Model  The LUSID API has a relatively lightweight but extremely powerful data model. One of the goals of LUSID was not to enforce on clients a single rigid data model but rather to provide a flexible foundation onto which clients can map their own data models.  The core entities in LUSID provide a minimal structure and set of relationships, and the data model can be extended using Properties.  The LUSID data model is exposed through the LUSID APIs.  The APIs provide access to both business objects and the meta data used to configure the systems behaviours.   The key business entities are: - * **Portfolios** A portfolio is a container for transactions and holdings (a **Transaction Portfolio**) or constituents (a **Reference Portfolio**). * **Derived Portfolios**. Derived Portfolios allow Portfolios to be created based on other Portfolios, by overriding or adding specific items. * **Holdings** A Holding is a quantity of an Instrument or a balance of cash within a Portfolio.  Holdings can only be adjusted via Transactions. * **Transactions** A Transaction is an economic event that occurs in a Portfolio, causing its holdings to change. * **Corporate Actions** A corporate action is a market event which occurs to an Instrument and thus applies to all portfolios which holding the instrument.  Examples are stock splits or mergers. * **Constituents** A constituent is a record in a Reference Portfolio containing an Instrument and an associated weight. * **Instruments**  An instrument represents a currency, tradable instrument or OTC contract that is attached to a transaction and a holding. * **Properties** All major entities allow additional user defined properties to be associated with them.   For example, a Portfolio manager may be associated with a portfolio.  Meta data includes: - * **Transaction Types** Transactions are booked with a specific transaction type.  The types are client defined and are used to map the Transaction to a series of movements which update the portfolio holdings.  * **Properties Types** Types of user defined properties used within the system.  ## Scope  All data in LUSID is segregated at the client level.  Entities in LUSID are identifiable by a unique code.  Every entity lives within a logical data partition known as a Scope.  Scope is an identity namespace allowing two entities with the same unique code to co-exist within individual address spaces.  For example, prices for equities from different vendors may be uploaded into different scopes such as `client/vendor1` and `client/vendor2`.  A portfolio may then be valued using either of the price sources by referencing the appropriate scope.  LUSID Clients cannot access scopes of other clients.  ## Instruments  LUSID has its own built-in instrument master which you can use to master your own instrument universe.  Every instrument must be created with one or more unique market identifiers, such as [FIGI](https://openfigi.com/). For any non-listed instruments (eg OTCs), you can upload an instrument against a custom ID of your choosing.  In addition, LUSID will allocate each instrument a unique 'LUSID instrument identifier'. The LUSID instrument identifier is what is used when uploading transactions, holdings, prices, etc. The API exposes an `instrument/lookup` endpoint which can be used to lookup these LUSID identifiers using their market identifiers.  Cash can be referenced using the ISO currency code prefixed with \"`CCY_`\" e.g. `CCY_GBP`  ## Instrument Data  Instrument data can be uploaded to the system using the [Instrument Properties](#tag/InstrumentProperties) endpoint.  | Field|Type|Description | | - --|- --|- -- | | Key|propertykey|The key of the property. This takes the format {domain}/{scope}/{code} e.g. 'Instrument/system/Name' or 'Transaction/strategy/quantsignal'. | | Value|string|The value of the property. | | EffectiveFrom|datetimeoffset|The effective datetime from which the property is valid. |   ## Transaction Portfolios  Portfolios are the top-level entity containers within LUSID, containing transactions, corporate actions and holdings.    The transactions build up the portfolio holdings on which valuations, analytics profit & loss and risk can be calculated.  Properties can be associated with Portfolios to add in additional data.  Portfolio properties can be changed over time, for example to allow a Portfolio Manager to be linked with a Portfolio.  Additionally, portfolios can be securitised and held by other portfolios, allowing LUSID to perform \"drill-through\" into underlying fund holdings  ### Derived Portfolios  LUSID also allows for a portfolio to be composed of another portfolio via derived portfolios.  A derived portfolio can contain its own transactions and also inherits any transactions from its parent portfolio.  Any changes made to the parent portfolio are automatically reflected in derived portfolio.  Derived portfolios in conjunction with scopes are a powerful construct.  For example, to do pre-trade what-if analysis, a derived portfolio could be created a new namespace linked to the underlying live (parent) portfolio.  Analysis can then be undertaken on the derived portfolio without affecting the live portfolio.  ### Transactions  A transaction represents an economic activity against a Portfolio.  Transactions are processed according to a configuration. This will tell the LUSID engine how to interpret the transaction and correctly update the holdings. LUSID comes with a set of transaction types you can use out of the box, or you can configure your own set(s) of transactions.  For more details see the [LUSID Getting Started Guide for transaction configuration.](https://support.lusid.com/configuring-transaction-types)  | Field|Type|Description | | - --|- --|- -- | | TransactionId|string|The unique identifier for the transaction. | | Type|string|The type of the transaction e.g. 'Buy', 'Sell'. The transaction type should have been pre-configured via the System Configuration API endpoint. If it hasn't been pre-configured the transaction will still be updated or inserted however you will be unable to generate the resultant holdings for the portfolio that contains this transaction as LUSID does not know how to process it. | | InstrumentIdentifiers|map|A set of instrument identifiers to use to resolve the transaction to a unique instrument. | | TransactionDate|dateorcutlabel|The date of the transaction. | | SettlementDate|dateorcutlabel|The settlement date of the transaction. | | Units|decimal|The number of units transacted in the associated instrument. | | TransactionPrice|transactionprice|The price for each unit of the transacted instrument in the transaction currency. | | TotalConsideration|currencyandamount|The total value of the transaction in the settlement currency. | | ExchangeRate|decimal|The exchange rate between the transaction and settlement currency. For example if the transaction currency is in USD and the settlement currency is in GBP this this the USD/GBP rate. | | TransactionCurrency|currency|The transaction currency. | | Properties|map|Set of unique transaction properties and associated values to store with the transaction. Each property must be from the 'Transaction' domain. | | CounterpartyId|string|The identifier for the counterparty of the transaction. | | Source|string|The source of the transaction. This is used to look up the appropriate transaction group set in the transaction type configuration. |   From these fields, the following values can be calculated  * **Transaction value in Transaction currency**: TotalConsideration / ExchangeRate  * **Transaction value in Portfolio currency**: Transaction value in Transaction currency * TradeToPortfolioRate  #### Example Transactions  ##### A Common Purchase Example Three example transactions are shown in the table below.   They represent a purchase of USD denominated IBM shares within a Sterling denominated portfolio.   * The first two transactions are for separate buy and fx trades    * Buying 500 IBM shares for $71,480.00    * A foreign exchange conversion to fund the IBM purchase. (Buy $71,480.00 for &#163;54,846.60)  * The third transaction is an alternate version of the above trades. Buying 500 IBM shares and settling directly in Sterling.  | Column |  Buy Trade | Fx Trade | Buy Trade with foreign Settlement | | - -- -- | - -- -- | - -- -- | - -- -- | | TransactionId | FBN00001 | FBN00002 | FBN00003 | | Type | Buy | FxBuy | Buy | | InstrumentIdentifiers | { \"figi\", \"BBG000BLNNH6\" } | { \"CCY\", \"CCY_USD\" } | { \"figi\", \"BBG000BLNNH6\" } | | TransactionDate | 2018-08-02 | 2018-08-02 | 2018-08-02 | | SettlementDate | 2018-08-06 | 2018-08-06 | 2018-08-06 | | Units | 500 | 71480 | 500 | | TransactionPrice | 142.96 | 1 | 142.96 | | TradeCurrency | USD | USD | USD | | ExchangeRate | 1 | 0.7673 | 0.7673 | | TotalConsideration.Amount | 71480.00 | 54846.60 | 54846.60 | | TotalConsideration.Currency | USD | GBP | GBP | | Trade/default/TradeToPortfolioRate&ast; | 0.7673 | 0.7673 | 0.7673 |  [&ast; This is a property field]  ##### A Forward FX Example  LUSID has a flexible transaction modelling system, and there are a number of different ways of modelling forward fx trades.  The default LUSID transaction types are FwdFxBuy and FwdFxSell. Other types and behaviours can be configured as required.  Using these transaction types, the holdings query will report two forward positions. One in each currency.   Since an FX trade is an exchange of one currency for another, the following two 6 month forward transactions are equivalent:  | Column |  Forward 'Sell' Trade | Forward 'Buy' Trade | | - -- -- | - -- -- | - -- -- | | TransactionId | FBN00004 | FBN00005 | | Type | FwdFxSell | FwdFxBuy | | InstrumentIdentifiers | { \"CCY\", \"CCY_GBP\" } | { \"CCY\", \"CCY_USD\" } | | TransactionDate | 2018-08-02 | 2018-08-02 | | SettlementDate | 2019-02-06 | 2019-02-06 | | Units | 10000.00 | 13142.00 | | TransactionPrice |1 | 1 | | TradeCurrency | GBP | USD | | ExchangeRate | 1.3142 | 0.760919 | | TotalConsideration.Amount | 13142.00 | 10000.00 | | TotalConsideration.Currency | USD | GBP | | Trade/default/TradeToPortfolioRate | 1.0 | 0.760919 |  ### Holdings  A holding represents a position in an instrument or cash on a given date.  | Field|Type|Description | | - --|- --|- -- | | InstrumentUid|string|The unqiue Lusid Instrument Id (LUID) of the instrument that the holding is in. | | SubHoldingKeys|map|The sub-holding properties which identify the holding. Each property will be from the 'Transaction' domain. These are configured when a transaction portfolio is created. | | Properties|map|The properties which have been requested to be decorated onto the holding. These will be from the 'Instrument' or 'Holding' domain. | | HoldingType|string|The type of the holding e.g. Position, Balance, CashCommitment, Receivable, ForwardFX etc. | | Units|decimal|The total number of units of the holding. | | SettledUnits|decimal|The total number of settled units of the holding. | | Cost|currencyandamount|The total cost of the holding in the transaction currency. | | CostPortfolioCcy|currencyandamount|The total cost of the holding in the portfolio currency. | | Transaction|transaction|The transaction associated with an unsettled holding. |   ## Corporate Actions  Corporate actions are represented within LUSID in terms of a set of instrument-specific 'transitions'.  These transitions are used to specify the participants of the corporate action, and the effect that the corporate action will have on holdings in those participants.  ### Corporate Action  | Field|Type|Description | | - --|- --|- -- | | CorporateActionCode|code|The unique identifier of this corporate action | | Description|string|  | | AnnouncementDate|datetimeoffset|The announcement date of the corporate action | | ExDate|datetimeoffset|The ex date of the corporate action | | RecordDate|datetimeoffset|The record date of the corporate action | | PaymentDate|datetimeoffset|The payment date of the corporate action | | Transitions|corporateactiontransition[]|The transitions that result from this corporate action |   ### Transition | Field|Type|Description | | - --|- --|- -- | | InputTransition|corporateactiontransitioncomponent|Indicating the basis of the corporate action - which security and how many units | | OutputTransitions|corporateactiontransitioncomponent[]|What will be generated relative to the input transition |   ### Example Corporate Action Transitions  #### A Dividend Action Transition  In this example, for each share of IBM, 0.20 units (or 20 pence) of GBP are generated.  | Column |  Input Transition | Output Transition | | - -- -- | - -- -- | - -- -- | | Instrument Identifiers | { \"figi\" : \"BBG000BLNNH6\" } | { \"ccy\" : \"CCY_GBP\" } | | Units Factor | 1 | 0.20 | | Cost Factor | 1 | 0 |  #### A Split Action Transition  In this example, for each share of IBM, we end up with 2 units (2 shares) of IBM, with total value unchanged.  | Column |  Input Transition | Output Transition | | - -- -- | - -- -- | - -- -- | | Instrument Identifiers | { \"figi\" : \"BBG000BLNNH6\" } | { \"figi\" : \"BBG000BLNNH6\" } | | Units Factor | 1 | 2 | | Cost Factor | 1 | 1 |  #### A Spinoff Action Transition  In this example, for each share of IBM, we end up with 1 unit (1 share) of IBM and 3 units (3 shares) of Celestica, with 85% of the value remaining on the IBM share, and 5% in each Celestica share (15% total).  | Column |  Input Transition | Output Transition 1 | Output Transition 2 | | - -- -- | - -- -- | - -- -- | - -- -- | | Instrument Identifiers | { \"figi\" : \"BBG000BLNNH6\" } | { \"figi\" : \"BBG000BLNNH6\" } | { \"figi\" : \"BBG000HBGRF3\" } | | Units Factor | 1 | 1 | 3 | | Cost Factor | 1 | 0.85 | 0.15 |  ## Reference Portfolios Reference portfolios are portfolios that contain constituents with weights.  They are designed to represent entities such as indices and benchmarks.  ### Constituents | Field|Type|Description | | - --|- --|- -- | | InstrumentIdentifiers|map|Unique instrument identifiers | | InstrumentUid|string|LUSID's internal unique instrument identifier, resolved from the instrument identifiers | | Currency|decimal|  | | Weight|decimal|  | | FloatingWeight|decimal|  |   ## Portfolio Groups Portfolio groups allow the construction of a hierarchy from portfolios and groups.  Portfolio operations on the group are executed on an aggregated set of portfolios in the hierarchy.   For example:   * Global Portfolios _(group)_   * APAC _(group)_     * Hong Kong _(portfolio)_     * Japan _(portfolio)_   * Europe _(group)_     * France _(portfolio)_     * Germany _(portfolio)_   * UK _(portfolio)_   In this example **Global Portfolios** is a group that consists of an aggregate of **Hong Kong**, **Japan**, **France**, **Germany** and **UK** portfolios.  ## Properties  Properties are key-value pairs that can be applied to any entity within a domain (where a domain is `trade`, `portfolio`, `security` etc).  Properties must be defined before use with a `PropertyDefinition` and can then subsequently be added to entities.   ## Schema  A detailed description of the entities used by the API and parameters for endpoints which take a JSON document can be retrieved via the `schema` endpoint.  ## Meta data  The following headers are returned on all responses from LUSID  | Name | Purpose | | - -- | - -- | | lusid-meta-duration | Duration of the request | | lusid-meta-success | Whether or not LUSID considered the request to be successful | | lusid-meta-requestId | The unique identifier for the request | | lusid-schema-url | Url of the schema for the data being returned | | lusid-property-schema-url | Url of the schema for any properties |   # Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"-10\">-10</a>|Server Configuration Error|  | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"102\">102</a>|Version Not Found|  | | <a name=\"103\">103</a>|Api Rate Limit Violation|  | | <a name=\"104\">104</a>|Instrument Not Found|  | | <a name=\"105\">105</a>|Property Not Found|  | | <a name=\"106\">106</a>|Portfolio Recursion Depth|  | | <a name=\"108\">108</a>|Group Not Found|  | | <a name=\"109\">109</a>|Portfolio Not Found|  | | <a name=\"110\">110</a>|Property Schema Not Found|  | | <a name=\"111\">111</a>|Portfolio Ancestry Not Found|  | | <a name=\"112\">112</a>|Portfolio With Id Already Exists|  | | <a name=\"113\">113</a>|Orphaned Portfolio|  | | <a name=\"119\">119</a>|Missing Base Claims|  | | <a name=\"121\">121</a>|Property Not Defined|  | | <a name=\"122\">122</a>|Cannot Delete System Property|  | | <a name=\"123\">123</a>|Cannot Modify Immutable Property Field|  | | <a name=\"124\">124</a>|Property Already Exists|  | | <a name=\"125\">125</a>|Invalid Property Life Time|  | | <a name=\"126\">126</a>|Property Constraint Style Excludes Properties Failure|  | | <a name=\"127\">127</a>|Cannot Modify Default Data Type|  | | <a name=\"128\">128</a>|Group Already Exists|  | | <a name=\"129\">129</a>|No Such Data Type|  | | <a name=\"130\">130</a>|Undefined Value For Data Type|  | | <a name=\"131\">131</a>|Unsupported Value Type Defined On Data Type|  | | <a name=\"132\">132</a>|Validation Error|  | | <a name=\"133\">133</a>|Loop Detected In Group Hierarchy|  | | <a name=\"134\">134</a>|Undefined Acceptable Values|  | | <a name=\"135\">135</a>|Sub Group Already Exists|  | | <a name=\"138\">138</a>|Price Source Not Found|  | | <a name=\"139\">139</a>|Analytic Store Not Found|  | | <a name=\"141\">141</a>|Analytic Store Already Exists|  | | <a name=\"143\">143</a>|Client Instrument Already Exists|  | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"147\">147</a>|Results Not Found|  | | <a name=\"148\">148</a>|Order Field Not In Result Set|  | | <a name=\"149\">149</a>|Operation Failed|  | | <a name=\"150\">150</a>|Elastic Search Error|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"153\">153</a>|Command Processing Failure|  | | <a name=\"154\">154</a>|Entity State Construction Failure|  | | <a name=\"155\">155</a>|Entity Timeline Does Not Exist|  | | <a name=\"156\">156</a>|Event Publish Failure|  | | <a name=\"157\">157</a>|Invalid Request Failure|  | | <a name=\"158\">158</a>|Event Publish Unknown|  | | <a name=\"159\">159</a>|Event Query Failure|  | | <a name=\"160\">160</a>|Blob Did Not Exist Failure|  | | <a name=\"162\">162</a>|Sub System Request Failure|  | | <a name=\"163\">163</a>|Sub System Configuration Failure|  | | <a name=\"165\">165</a>|Failed To Delete|  | | <a name=\"166\">166</a>|Upsert Client Instrument Failure|  | | <a name=\"167\">167</a>|Illegal As At Interval|  | | <a name=\"168\">168</a>|Illegal Bitemporal Query|  | | <a name=\"169\">169</a>|Invalid Alternate Id|  | | <a name=\"170\">170</a>|Cannot Add Source Portfolio Property Explicitly|  | | <a name=\"171\">171</a>|Entity Already Exists In Group|  | | <a name=\"173\">173</a>|Entity With Id Already Exists|  | | <a name=\"174\">174</a>|Derived Portfolio Details Do Not Exist|  | | <a name=\"176\">176</a>|Portfolio With Name Already Exists|  | | <a name=\"177\">177</a>|Invalid Transactions|  | | <a name=\"178\">178</a>|Reference Portfolio Not Found|  | | <a name=\"179\">179</a>|Duplicate Id Failure|  | | <a name=\"180\">180</a>|Command Retrieval Failure|  | | <a name=\"181\">181</a>|Data Filter Application Failure|  | | <a name=\"182\">182</a>|Search Failed|  | | <a name=\"183\">183</a>|Movements Engine Configuration Key Failure|  | | <a name=\"184\">184</a>|Fx Rate Source Not Found|  | | <a name=\"185\">185</a>|Accrual Source Not Found|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"188\">188</a>|Invalid Request Headers|  | | <a name=\"189\">189</a>|Price Not Found|  | | <a name=\"190\">190</a>|Invalid Sub Holding Keys Provided|  | | <a name=\"191\">191</a>|Duplicate Sub Holding Keys Provided|  | | <a name=\"192\">192</a>|Cut Definition Not Found|  | | <a name=\"193\">193</a>|Cut Definition Invalid|  | | <a name=\"194\">194</a>|Time Variant Property Deletion Date Unspecified|  | | <a name=\"195\">195</a>|Perpetual Property Deletion Date Specified|  | | <a name=\"196\">196</a>|Time Variant Property Upsert Date Unspecified|  | | <a name=\"197\">197</a>|Perpetual Property Upsert Date Specified|  | | <a name=\"200\">200</a>|Invalid Unit For Data Type|  | | <a name=\"201\">201</a>|Invalid Type For Data Type|  | | <a name=\"202\">202</a>|Invalid Value For Data Type|  | | <a name=\"203\">203</a>|Unit Not Defined For Data Type|  | | <a name=\"204\">204</a>|Units Not Supported On Data Type|  | | <a name=\"205\">205</a>|Cannot Specify Units On Data Type|  | | <a name=\"206\">206</a>|Unit Schema Inconsistent With Data Type|  | | <a name=\"207\">207</a>|Unit Definition Not Specified|  | | <a name=\"208\">208</a>|Duplicate Unit Definitions Specified|  | | <a name=\"209\">209</a>|Invalid Units Definition|  | | <a name=\"210\">210</a>|Invalid Instrument Identifier Unit|  | | <a name=\"211\">211</a>|Holdings Adjustment Does Not Exist|  | | <a name=\"212\">212</a>|Could Not Build Excel Url|  | | <a name=\"213\">213</a>|Could Not Get Excel Version|  | | <a name=\"214\">214</a>|Instrument By Code Not Found|  | | <a name=\"215\">215</a>|Entity Schema Does Not Exist|  | | <a name=\"216\">216</a>|Feature Not Supported On Portfolio Type|  | | <a name=\"217\">217</a>|Quote Not Found Failure|  | | <a name=\"218\">218</a>|Invalid Quote Identifier Failure|  | | <a name=\"219\">219</a>|Invalid Metric For Data Type|  | | <a name=\"220\">220</a>|Invalid Instrument Definition|  | | <a name=\"221\">221</a>|Instrument Upsert Failure|  | | <a name=\"222\">222</a>|Reference Portfolio Request Not Supported|  | | <a name=\"223\">223</a>|Transaction Portfolio Request Not Supported|  | | <a name=\"224\">224</a>|Invalid Property Value Assignment|  | | <a name=\"230\">230</a>|Transaction Type Not Found|  | | <a name=\"231\">231</a>|Transaction Type Duplication|  | | <a name=\"232\">232</a>|Portfolio Does Not Exist At Given Date|  | | <a name=\"233\">233</a>|Query Parser Failure|  | | <a name=\"234\">234</a>|Duplicate Constituent Failure|  | | <a name=\"235\">235</a>|Unresolved Instrument Constituent Failure|  | | <a name=\"236\">236</a>|Unresolved Instrument In Transition Failure|  | | <a name=\"237\">237</a>|Missing Side Definitions Failure|  | | <a name=\"300\">300</a>|Missing Recipe Failure|  | | <a name=\"301\">301</a>|Dependencies Failure|  | | <a name=\"304\">304</a>|Portfolio Preprocess Failure|  | | <a name=\"310\">310</a>|Valuation Engine Failure|  | | <a name=\"311\">311</a>|Task Factory Failure|  | | <a name=\"312\">312</a>|Task Evaluation Failure|  | | <a name=\"313\">313</a>|Task Generation Failure|  | | <a name=\"320\">320</a>|Market Data Key Failure|  | | <a name=\"321\">321</a>|Market Resolver Failure|  | | <a name=\"322\">322</a>|Market Data Failure|  | | <a name=\"330\">330</a>|Curve Failure|  | | <a name=\"350\">350</a>|Instrument Failure|  | | <a name=\"351\">351</a>|Cash Flows Failure|  | | <a name=\"360\">360</a>|Aggregation Failure|  | | <a name=\"370\">370</a>|Result Retrieval Failure|  | | <a name=\"371\">371</a>|Result Processing Failure|  | | <a name=\"372\">372</a>|Vendor Result Processing Failure|  | | <a name=\"373\">373</a>|Vendor Result Mapping Failure|  | | <a name=\"374\">374</a>|Vendor Library Unauthorised Failure|  | | <a name=\"375\">375</a>|Vendor Connectivity Error|  | | <a name=\"376\">376</a>|Vendor Interface Error|  | | <a name=\"377\">377</a>|Vendor Pricing Failure|  | | <a name=\"390\">390</a>|Attempt To Upsert Duplicate Quotes|  | | <a name=\"391\">391</a>|Corporate Action Source Does Not Exist|  | | <a name=\"392\">392</a>|Corporate Action Source Already Exists|  | | <a name=\"393\">393</a>|Instrument Identifier Already In Use|  | | <a name=\"394\">394</a>|Properties Not Found|  | | <a name=\"395\">395</a>|Batch Operation Aborted|  | | <a name=\"400\">400</a>|Invalid Iso4217 Currency Code Failure|  | | <a name=\"401\">401</a>|Cannot Assign Instrument Identifier To Currency Failure|  | | <a name=\"402\">402</a>|Cannot Assign Currency Identifier To Non Currency|  | | <a name=\"403\">403</a>|Currency Instrument Cannot Be Deleted|  | | <a name=\"404\">404</a>|Currency Instrument Cannot Have Economic Definition|  | | <a name=\"405\">405</a>|Currency Instrument Cannot Have Lookthrough Portfolio|  | | <a name=\"406\">406</a>|Cannot Create Currency Instrument With Multiple Identifiers|  | | <a name=\"410\">410</a>|Index Does Not Exist|  | | <a name=\"411\">411</a>|Sort Field Does Not Exist|  | | <a name=\"413\">413</a>|Negative Pagination Parameters|  | | <a name=\"414\">414</a>|Invalid Search Syntax|  | | <a name=\"420\">420</a>|Side Definition Inconsistent|  | | <a name=\"450\">450</a>|Invalid Quote Access Metadata Rule|  | | <a name=\"451\">451</a>|Access Metadata Not Found|  | | <a name=\"460\">460</a>|Standard Resource Not Found|  | | <a name=\"461\">461</a>|Standard Resource Conflict|  | | <a name=\"601\">601</a>|Person Identifier Already In Use|  | | <a name=\"602\">602</a>|Person Not Found|  | | <a name=\"603\">603</a>|Cannot Set Identifier|  | | <a name=\"617\">617</a>|Invalid Recipe Specification In Request|  | | <a name=\"618\">618</a>|Inline Recipe Deserialisation Failure|  | 
 *
 * The version of the OpenAPI document: 0.10.976
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
    public interface IPortfoliosApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete portfolio
        /// </summary>
        /// <remarks>
        /// Delete a single portfolio. The deletion of the portfolio will be valid from the portfolio&#39;s creation datetime. This means that the portfolio will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio.</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeletePortfolio (string scope, string code);

        /// <summary>
        /// Delete portfolio
        /// </summary>
        /// <remarks>
        /// Delete a single portfolio. The deletion of the portfolio will be valid from the portfolio&#39;s creation datetime. This means that the portfolio will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeletePortfolioWithHttpInfo (string scope, string code);
        /// <summary>
        /// Delete portfolio properties
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a single portfolio. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to delete properties from.</param>
        /// <param name="code">The code of the portfolio to delete properties from. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. Each property must be from the \&quot;Portfolio\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the properties. (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeletePortfolioProperties (string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = null);

        /// <summary>
        /// Delete portfolio properties
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a single portfolio. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to delete properties from.</param>
        /// <param name="code">The code of the portfolio to delete properties from. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. Each property must be from the \&quot;Portfolio\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the properties. (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeletePortfolioPropertiesWithHttpInfo (string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = null);
        /// <summary>
        /// Get portfolio
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a single portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio to retrieve the definition for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio definition. Defaults to return the latest version of the portfolio definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto the portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>Portfolio</returns>
        Portfolio GetPortfolio (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> propertyKeys = null);

        /// <summary>
        /// Get portfolio
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a single portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio to retrieve the definition for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio definition. Defaults to return the latest version of the portfolio definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto the portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>ApiResponse of Portfolio</returns>
        ApiResponse<Portfolio> GetPortfolioWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> propertyKeys = null);
        /// <summary>
        /// [EARLY ACCESS] Get portfolio commands
        /// </summary>
        /// <remarks>
        /// Gets all the commands that modified a single portfolio, including any input transactions.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio to retrieve the commands for. Together with the scope this uniquely identifies              the portfolio.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ResourceListOfProcessedCommand</returns>
        ResourceListOfProcessedCommand GetPortfolioCommands (string scope, string code, DateTimeOffset? fromAsAt = null, DateTimeOffset? toAsAt = null, string filter = null);

        /// <summary>
        /// [EARLY ACCESS] Get portfolio commands
        /// </summary>
        /// <remarks>
        /// Gets all the commands that modified a single portfolio, including any input transactions.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio to retrieve the commands for. Together with the scope this uniquely identifies              the portfolio.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfProcessedCommand</returns>
        ApiResponse<ResourceListOfProcessedCommand> GetPortfolioCommandsWithHttpInfo (string scope, string code, DateTimeOffset? fromAsAt = null, DateTimeOffset? toAsAt = null, string filter = null);
        /// <summary>
        /// Get portfolio properties
        /// </summary>
        /// <remarks>
        /// List all the properties of a single portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to list the properties for.</param>
        /// <param name="code">The code of the portfolio to list the properties for. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolio&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <returns>PortfolioProperties</returns>
        PortfolioProperties GetPortfolioProperties (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null);

        /// <summary>
        /// Get portfolio properties
        /// </summary>
        /// <remarks>
        /// List all the properties of a single portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to list the properties for.</param>
        /// <param name="code">The code of the portfolio to list the properties for. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolio&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <returns>ApiResponse of PortfolioProperties</returns>
        ApiResponse<PortfolioProperties> GetPortfolioPropertiesWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null);
        /// <summary>
        /// List portfolios
        /// </summary>
        /// <remarks>
        /// List all the portfolios matching the specified criteria.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to return the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios from a previous call to list portfolios. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 65,535 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="query">Expression specifying the criteria that the returned portfolios must meet e.g. to see which              portfolios have holdings in the instruments with a Lusid Instrument Id (LUID) of &#39;LUID_PPA8HI6M&#39; or a Figi of &#39;BBG000BLNNH6&#39;              you would specify \&quot;instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))\&quot;. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto each portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>ResourceListOfPortfolio</returns>
        ResourceListOfPortfolio ListPortfolios (DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null, string query = null, List<string> propertyKeys = null);

        /// <summary>
        /// List portfolios
        /// </summary>
        /// <remarks>
        /// List all the portfolios matching the specified criteria.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to return the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios from a previous call to list portfolios. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 65,535 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="query">Expression specifying the criteria that the returned portfolios must meet e.g. to see which              portfolios have holdings in the instruments with a Lusid Instrument Id (LUID) of &#39;LUID_PPA8HI6M&#39; or a Figi of &#39;BBG000BLNNH6&#39;              you would specify \&quot;instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))\&quot;. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto each portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPortfolio</returns>
        ApiResponse<ResourceListOfPortfolio> ListPortfoliosWithHttpInfo (DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null, string query = null, List<string> propertyKeys = null);
        /// <summary>
        /// List portfolios for scope
        /// </summary>
        /// <remarks>
        /// List all the portfolios in a single scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolios.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to return the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios from a previous call to list portfolios. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 65,535 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto each portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>ResourceListOfPortfolio</returns>
        ResourceListOfPortfolio ListPortfoliosForScope (string scope, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null, List<string> propertyKeys = null);

        /// <summary>
        /// List portfolios for scope
        /// </summary>
        /// <remarks>
        /// List all the portfolios in a single scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolios.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to return the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios from a previous call to list portfolios. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 65,535 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto each portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPortfolio</returns>
        ApiResponse<ResourceListOfPortfolio> ListPortfoliosForScopeWithHttpInfo (string scope, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null, List<string> propertyKeys = null);
        /// <summary>
        /// Update portfolio
        /// </summary>
        /// <remarks>
        /// Update the definition of a single portfolio. Not all elements within a portfolio definition are  modifiable due to the potential implications for data already stored against the portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to update the definition for.</param>
        /// <param name="code">The code of the portfolio to update the definition for. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="portfolioDefinition">The updated portfolio definition.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to update the definition. Defaults to the current              LUSID system datetime if not specified. (optional)</param>
        /// <returns>Portfolio</returns>
        Portfolio UpdatePortfolio (string scope, string code, UpdatePortfolioRequest portfolioDefinition, DateTimeOrCutLabel effectiveAt = null);

        /// <summary>
        /// Update portfolio
        /// </summary>
        /// <remarks>
        /// Update the definition of a single portfolio. Not all elements within a portfolio definition are  modifiable due to the potential implications for data already stored against the portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to update the definition for.</param>
        /// <param name="code">The code of the portfolio to update the definition for. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="portfolioDefinition">The updated portfolio definition.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to update the definition. Defaults to the current              LUSID system datetime if not specified. (optional)</param>
        /// <returns>ApiResponse of Portfolio</returns>
        ApiResponse<Portfolio> UpdatePortfolioWithHttpInfo (string scope, string code, UpdatePortfolioRequest portfolioDefinition, DateTimeOrCutLabel effectiveAt = null);
        /// <summary>
        /// Upsert portfolio properties
        /// </summary>
        /// <remarks>
        /// Update or insert one or more properties onto a single portfolio. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;Portfolio&#39;.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to update or insert the properties onto.</param>
        /// <param name="code">The code of the portfolio to update or insert the properties onto. Together with the scope              this uniquely identifies the portfolio.</param>
        /// <param name="portfolioProperties">The properties to be updated or inserted onto the portfolio. Each property in              the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;.</param>
        /// <returns>PortfolioProperties</returns>
        PortfolioProperties UpsertPortfolioProperties (string scope, string code, Dictionary<string, Property> portfolioProperties);

        /// <summary>
        /// Upsert portfolio properties
        /// </summary>
        /// <remarks>
        /// Update or insert one or more properties onto a single portfolio. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;Portfolio&#39;.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to update or insert the properties onto.</param>
        /// <param name="code">The code of the portfolio to update or insert the properties onto. Together with the scope              this uniquely identifies the portfolio.</param>
        /// <param name="portfolioProperties">The properties to be updated or inserted onto the portfolio. Each property in              the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;.</param>
        /// <returns>ApiResponse of PortfolioProperties</returns>
        ApiResponse<PortfolioProperties> UpsertPortfolioPropertiesWithHttpInfo (string scope, string code, Dictionary<string, Property> portfolioProperties);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete portfolio
        /// </summary>
        /// <remarks>
        /// Delete a single portfolio. The deletion of the portfolio will be valid from the portfolio&#39;s creation datetime. This means that the portfolio will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeletePortfolioAsync (string scope, string code);

        /// <summary>
        /// Delete portfolio
        /// </summary>
        /// <remarks>
        /// Delete a single portfolio. The deletion of the portfolio will be valid from the portfolio&#39;s creation datetime. This means that the portfolio will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeletePortfolioAsyncWithHttpInfo (string scope, string code);
        /// <summary>
        /// Delete portfolio properties
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a single portfolio. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to delete properties from.</param>
        /// <param name="code">The code of the portfolio to delete properties from. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. Each property must be from the \&quot;Portfolio\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the properties. (optional)</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeletePortfolioPropertiesAsync (string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = null);

        /// <summary>
        /// Delete portfolio properties
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a single portfolio. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to delete properties from.</param>
        /// <param name="code">The code of the portfolio to delete properties from. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. Each property must be from the \&quot;Portfolio\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the properties. (optional)</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeletePortfolioPropertiesAsyncWithHttpInfo (string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = null);
        /// <summary>
        /// Get portfolio
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a single portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio to retrieve the definition for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio definition. Defaults to return the latest version of the portfolio definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto the portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>Task of Portfolio</returns>
        System.Threading.Tasks.Task<Portfolio> GetPortfolioAsync (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> propertyKeys = null);

        /// <summary>
        /// Get portfolio
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a single portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio to retrieve the definition for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio definition. Defaults to return the latest version of the portfolio definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto the portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (Portfolio)</returns>
        System.Threading.Tasks.Task<ApiResponse<Portfolio>> GetPortfolioAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> propertyKeys = null);
        /// <summary>
        /// [EARLY ACCESS] Get portfolio commands
        /// </summary>
        /// <remarks>
        /// Gets all the commands that modified a single portfolio, including any input transactions.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio to retrieve the commands for. Together with the scope this uniquely identifies              the portfolio.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>Task of ResourceListOfProcessedCommand</returns>
        System.Threading.Tasks.Task<ResourceListOfProcessedCommand> GetPortfolioCommandsAsync (string scope, string code, DateTimeOffset? fromAsAt = null, DateTimeOffset? toAsAt = null, string filter = null);

        /// <summary>
        /// [EARLY ACCESS] Get portfolio commands
        /// </summary>
        /// <remarks>
        /// Gets all the commands that modified a single portfolio, including any input transactions.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio to retrieve the commands for. Together with the scope this uniquely identifies              the portfolio.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfProcessedCommand)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfProcessedCommand>> GetPortfolioCommandsAsyncWithHttpInfo (string scope, string code, DateTimeOffset? fromAsAt = null, DateTimeOffset? toAsAt = null, string filter = null);
        /// <summary>
        /// Get portfolio properties
        /// </summary>
        /// <remarks>
        /// List all the properties of a single portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to list the properties for.</param>
        /// <param name="code">The code of the portfolio to list the properties for. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolio&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <returns>Task of PortfolioProperties</returns>
        System.Threading.Tasks.Task<PortfolioProperties> GetPortfolioPropertiesAsync (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null);

        /// <summary>
        /// Get portfolio properties
        /// </summary>
        /// <remarks>
        /// List all the properties of a single portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to list the properties for.</param>
        /// <param name="code">The code of the portfolio to list the properties for. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolio&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioProperties)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioProperties>> GetPortfolioPropertiesAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null);
        /// <summary>
        /// List portfolios
        /// </summary>
        /// <remarks>
        /// List all the portfolios matching the specified criteria.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to return the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios from a previous call to list portfolios. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 65,535 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="query">Expression specifying the criteria that the returned portfolios must meet e.g. to see which              portfolios have holdings in the instruments with a Lusid Instrument Id (LUID) of &#39;LUID_PPA8HI6M&#39; or a Figi of &#39;BBG000BLNNH6&#39;              you would specify \&quot;instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))\&quot;. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto each portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>Task of ResourceListOfPortfolio</returns>
        System.Threading.Tasks.Task<ResourceListOfPortfolio> ListPortfoliosAsync (DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null, string query = null, List<string> propertyKeys = null);

        /// <summary>
        /// List portfolios
        /// </summary>
        /// <remarks>
        /// List all the portfolios matching the specified criteria.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to return the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios from a previous call to list portfolios. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 65,535 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="query">Expression specifying the criteria that the returned portfolios must meet e.g. to see which              portfolios have holdings in the instruments with a Lusid Instrument Id (LUID) of &#39;LUID_PPA8HI6M&#39; or a Figi of &#39;BBG000BLNNH6&#39;              you would specify \&quot;instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))\&quot;. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto each portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfPortfolio)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfPortfolio>> ListPortfoliosAsyncWithHttpInfo (DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null, string query = null, List<string> propertyKeys = null);
        /// <summary>
        /// List portfolios for scope
        /// </summary>
        /// <remarks>
        /// List all the portfolios in a single scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolios.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to return the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios from a previous call to list portfolios. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 65,535 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto each portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>Task of ResourceListOfPortfolio</returns>
        System.Threading.Tasks.Task<ResourceListOfPortfolio> ListPortfoliosForScopeAsync (string scope, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null, List<string> propertyKeys = null);

        /// <summary>
        /// List portfolios for scope
        /// </summary>
        /// <remarks>
        /// List all the portfolios in a single scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolios.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to return the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios from a previous call to list portfolios. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 65,535 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto each portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfPortfolio)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfPortfolio>> ListPortfoliosForScopeAsyncWithHttpInfo (string scope, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null, List<string> propertyKeys = null);
        /// <summary>
        /// Update portfolio
        /// </summary>
        /// <remarks>
        /// Update the definition of a single portfolio. Not all elements within a portfolio definition are  modifiable due to the potential implications for data already stored against the portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to update the definition for.</param>
        /// <param name="code">The code of the portfolio to update the definition for. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="portfolioDefinition">The updated portfolio definition.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to update the definition. Defaults to the current              LUSID system datetime if not specified. (optional)</param>
        /// <returns>Task of Portfolio</returns>
        System.Threading.Tasks.Task<Portfolio> UpdatePortfolioAsync (string scope, string code, UpdatePortfolioRequest portfolioDefinition, DateTimeOrCutLabel effectiveAt = null);

        /// <summary>
        /// Update portfolio
        /// </summary>
        /// <remarks>
        /// Update the definition of a single portfolio. Not all elements within a portfolio definition are  modifiable due to the potential implications for data already stored against the portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to update the definition for.</param>
        /// <param name="code">The code of the portfolio to update the definition for. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="portfolioDefinition">The updated portfolio definition.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to update the definition. Defaults to the current              LUSID system datetime if not specified. (optional)</param>
        /// <returns>Task of ApiResponse (Portfolio)</returns>
        System.Threading.Tasks.Task<ApiResponse<Portfolio>> UpdatePortfolioAsyncWithHttpInfo (string scope, string code, UpdatePortfolioRequest portfolioDefinition, DateTimeOrCutLabel effectiveAt = null);
        /// <summary>
        /// Upsert portfolio properties
        /// </summary>
        /// <remarks>
        /// Update or insert one or more properties onto a single portfolio. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;Portfolio&#39;.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to update or insert the properties onto.</param>
        /// <param name="code">The code of the portfolio to update or insert the properties onto. Together with the scope              this uniquely identifies the portfolio.</param>
        /// <param name="portfolioProperties">The properties to be updated or inserted onto the portfolio. Each property in              the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;.</param>
        /// <returns>Task of PortfolioProperties</returns>
        System.Threading.Tasks.Task<PortfolioProperties> UpsertPortfolioPropertiesAsync (string scope, string code, Dictionary<string, Property> portfolioProperties);

        /// <summary>
        /// Upsert portfolio properties
        /// </summary>
        /// <remarks>
        /// Update or insert one or more properties onto a single portfolio. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;Portfolio&#39;.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to update or insert the properties onto.</param>
        /// <param name="code">The code of the portfolio to update or insert the properties onto. Together with the scope              this uniquely identifies the portfolio.</param>
        /// <param name="portfolioProperties">The properties to be updated or inserted onto the portfolio. Each property in              the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;.</param>
        /// <returns>Task of ApiResponse (PortfolioProperties)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioProperties>> UpsertPortfolioPropertiesAsyncWithHttpInfo (string scope, string code, Dictionary<string, Property> portfolioProperties);
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
        /// </summary>
        /// <returns></returns>
        public PortfoliosApi()
        {
            this.Configuration = Lusid.Sdk.Client.Configuration.Default;

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
        /// Delete portfolio Delete a single portfolio. The deletion of the portfolio will be valid from the portfolio&#39;s creation datetime. This means that the portfolio will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio.</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeletePortfolio (string scope, string code)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = DeletePortfolioWithHttpInfo(scope, code);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete portfolio Delete a single portfolio. The deletion of the portfolio will be valid from the portfolio&#39;s creation datetime. This means that the portfolio will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public ApiResponse< DeletedEntityResponse > DeletePortfolioWithHttpInfo (string scope, string code)
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

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.10.976";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

        /// <summary>
        /// Delete portfolio Delete a single portfolio. The deletion of the portfolio will be valid from the portfolio&#39;s creation datetime. This means that the portfolio will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeletePortfolioAsync (string scope, string code)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = await DeletePortfolioAsyncWithHttpInfo(scope, code);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete portfolio Delete a single portfolio. The deletion of the portfolio will be valid from the portfolio&#39;s creation datetime. This means that the portfolio will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeletePortfolioAsyncWithHttpInfo (string scope, string code)
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

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.10.976";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

        /// <summary>
        /// Delete portfolio properties Delete one or more properties from a single portfolio. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to delete properties from.</param>
        /// <param name="code">The code of the portfolio to delete properties from. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. Each property must be from the \&quot;Portfolio\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the properties. (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeletePortfolioProperties (string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = null)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = DeletePortfolioPropertiesWithHttpInfo(scope, code, propertyKeys, effectiveAt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete portfolio properties Delete one or more properties from a single portfolio. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to delete properties from.</param>
        /// <param name="code">The code of the portfolio to delete properties from. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. Each property must be from the \&quot;Portfolio\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the properties. (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public ApiResponse< DeletedEntityResponse > DeletePortfolioPropertiesWithHttpInfo (string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->DeletePortfolioProperties");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->DeletePortfolioProperties");
            // verify the required parameter 'propertyKeys' is set
            if (propertyKeys == null)
                throw new ApiException(400, "Missing required parameter 'propertyKeys' when calling PortfoliosApi->DeletePortfolioProperties");

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
            if (propertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "propertyKeys", propertyKeys)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.10.976";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

        /// <summary>
        /// Delete portfolio properties Delete one or more properties from a single portfolio. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to delete properties from.</param>
        /// <param name="code">The code of the portfolio to delete properties from. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. Each property must be from the \&quot;Portfolio\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the properties. (optional)</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeletePortfolioPropertiesAsync (string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = null)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = await DeletePortfolioPropertiesAsyncWithHttpInfo(scope, code, propertyKeys, effectiveAt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete portfolio properties Delete one or more properties from a single portfolio. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to delete properties from.</param>
        /// <param name="code">The code of the portfolio to delete properties from. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. Each property must be from the \&quot;Portfolio\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the properties. (optional)</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeletePortfolioPropertiesAsyncWithHttpInfo (string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->DeletePortfolioProperties");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->DeletePortfolioProperties");
            // verify the required parameter 'propertyKeys' is set
            if (propertyKeys == null)
                throw new ApiException(400, "Missing required parameter 'propertyKeys' when calling PortfoliosApi->DeletePortfolioProperties");

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
            if (propertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "propertyKeys", propertyKeys)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.10.976";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

        /// <summary>
        /// Get portfolio Retrieve the definition of a single portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio to retrieve the definition for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio definition. Defaults to return the latest version of the portfolio definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto the portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>Portfolio</returns>
        public Portfolio GetPortfolio (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> propertyKeys = null)
        {
             ApiResponse<Portfolio> localVarResponse = GetPortfolioWithHttpInfo(scope, code, effectiveAt, asAt, propertyKeys);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get portfolio Retrieve the definition of a single portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio to retrieve the definition for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio definition. Defaults to return the latest version of the portfolio definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto the portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>ApiResponse of Portfolio</returns>
        public ApiResponse< Portfolio > GetPortfolioWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> propertyKeys = null)
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
            if (propertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "propertyKeys", propertyKeys)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.10.976";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Portfolio) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Portfolio)));
        }

        /// <summary>
        /// Get portfolio Retrieve the definition of a single portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio to retrieve the definition for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio definition. Defaults to return the latest version of the portfolio definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto the portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>Task of Portfolio</returns>
        public async System.Threading.Tasks.Task<Portfolio> GetPortfolioAsync (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> propertyKeys = null)
        {
             ApiResponse<Portfolio> localVarResponse = await GetPortfolioAsyncWithHttpInfo(scope, code, effectiveAt, asAt, propertyKeys);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get portfolio Retrieve the definition of a single portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio to retrieve the definition for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio definition. Defaults to return the latest version of the portfolio definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto the portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (Portfolio)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Portfolio>> GetPortfolioAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> propertyKeys = null)
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
            if (propertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "propertyKeys", propertyKeys)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.10.976";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Portfolio) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Portfolio)));
        }

        /// <summary>
        /// [EARLY ACCESS] Get portfolio commands Gets all the commands that modified a single portfolio, including any input transactions.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio to retrieve the commands for. Together with the scope this uniquely identifies              the portfolio.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ResourceListOfProcessedCommand</returns>
        public ResourceListOfProcessedCommand GetPortfolioCommands (string scope, string code, DateTimeOffset? fromAsAt = null, DateTimeOffset? toAsAt = null, string filter = null)
        {
             ApiResponse<ResourceListOfProcessedCommand> localVarResponse = GetPortfolioCommandsWithHttpInfo(scope, code, fromAsAt, toAsAt, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Get portfolio commands Gets all the commands that modified a single portfolio, including any input transactions.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio to retrieve the commands for. Together with the scope this uniquely identifies              the portfolio.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfProcessedCommand</returns>
        public ApiResponse< ResourceListOfProcessedCommand > GetPortfolioCommandsWithHttpInfo (string scope, string code, DateTimeOffset? fromAsAt = null, DateTimeOffset? toAsAt = null, string filter = null)
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
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.10.976";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ResourceListOfProcessedCommand) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfProcessedCommand)));
        }

        /// <summary>
        /// [EARLY ACCESS] Get portfolio commands Gets all the commands that modified a single portfolio, including any input transactions.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio to retrieve the commands for. Together with the scope this uniquely identifies              the portfolio.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>Task of ResourceListOfProcessedCommand</returns>
        public async System.Threading.Tasks.Task<ResourceListOfProcessedCommand> GetPortfolioCommandsAsync (string scope, string code, DateTimeOffset? fromAsAt = null, DateTimeOffset? toAsAt = null, string filter = null)
        {
             ApiResponse<ResourceListOfProcessedCommand> localVarResponse = await GetPortfolioCommandsAsyncWithHttpInfo(scope, code, fromAsAt, toAsAt, filter);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Get portfolio commands Gets all the commands that modified a single portfolio, including any input transactions.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio to retrieve the commands for. Together with the scope this uniquely identifies              the portfolio.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfProcessedCommand)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResourceListOfProcessedCommand>> GetPortfolioCommandsAsyncWithHttpInfo (string scope, string code, DateTimeOffset? fromAsAt = null, DateTimeOffset? toAsAt = null, string filter = null)
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
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.10.976";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ResourceListOfProcessedCommand) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfProcessedCommand)));
        }

        /// <summary>
        /// Get portfolio properties List all the properties of a single portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to list the properties for.</param>
        /// <param name="code">The code of the portfolio to list the properties for. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolio&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <returns>PortfolioProperties</returns>
        public PortfolioProperties GetPortfolioProperties (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)
        {
             ApiResponse<PortfolioProperties> localVarResponse = GetPortfolioPropertiesWithHttpInfo(scope, code, effectiveAt, asAt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get portfolio properties List all the properties of a single portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to list the properties for.</param>
        /// <param name="code">The code of the portfolio to list the properties for. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolio&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <returns>ApiResponse of PortfolioProperties</returns>
        public ApiResponse< PortfolioProperties > GetPortfolioPropertiesWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)
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

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.10.976";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PortfolioProperties) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortfolioProperties)));
        }

        /// <summary>
        /// Get portfolio properties List all the properties of a single portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to list the properties for.</param>
        /// <param name="code">The code of the portfolio to list the properties for. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolio&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <returns>Task of PortfolioProperties</returns>
        public async System.Threading.Tasks.Task<PortfolioProperties> GetPortfolioPropertiesAsync (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)
        {
             ApiResponse<PortfolioProperties> localVarResponse = await GetPortfolioPropertiesAsyncWithHttpInfo(scope, code, effectiveAt, asAt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get portfolio properties List all the properties of a single portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to list the properties for.</param>
        /// <param name="code">The code of the portfolio to list the properties for. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolio&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioProperties)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PortfolioProperties>> GetPortfolioPropertiesAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)
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

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.10.976";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PortfolioProperties) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortfolioProperties)));
        }

        /// <summary>
        /// List portfolios List all the portfolios matching the specified criteria.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to return the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios from a previous call to list portfolios. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 65,535 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="query">Expression specifying the criteria that the returned portfolios must meet e.g. to see which              portfolios have holdings in the instruments with a Lusid Instrument Id (LUID) of &#39;LUID_PPA8HI6M&#39; or a Figi of &#39;BBG000BLNNH6&#39;              you would specify \&quot;instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))\&quot;. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto each portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>ResourceListOfPortfolio</returns>
        public ResourceListOfPortfolio ListPortfolios (DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null, string query = null, List<string> propertyKeys = null)
        {
             ApiResponse<ResourceListOfPortfolio> localVarResponse = ListPortfoliosWithHttpInfo(effectiveAt, asAt, page, start, limit, filter, query, propertyKeys);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List portfolios List all the portfolios matching the specified criteria.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to return the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios from a previous call to list portfolios. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 65,535 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="query">Expression specifying the criteria that the returned portfolios must meet e.g. to see which              portfolios have holdings in the instruments with a Lusid Instrument Id (LUID) of &#39;LUID_PPA8HI6M&#39; or a Figi of &#39;BBG000BLNNH6&#39;              you would specify \&quot;instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))\&quot;. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto each portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPortfolio</returns>
        public ApiResponse< ResourceListOfPortfolio > ListPortfoliosWithHttpInfo (DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null, string query = null, List<string> propertyKeys = null)
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
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (query != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "query", query)); // query parameter
            if (propertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "propertyKeys", propertyKeys)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.10.976";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ResourceListOfPortfolio) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfPortfolio)));
        }

        /// <summary>
        /// List portfolios List all the portfolios matching the specified criteria.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to return the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios from a previous call to list portfolios. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 65,535 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="query">Expression specifying the criteria that the returned portfolios must meet e.g. to see which              portfolios have holdings in the instruments with a Lusid Instrument Id (LUID) of &#39;LUID_PPA8HI6M&#39; or a Figi of &#39;BBG000BLNNH6&#39;              you would specify \&quot;instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))\&quot;. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto each portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>Task of ResourceListOfPortfolio</returns>
        public async System.Threading.Tasks.Task<ResourceListOfPortfolio> ListPortfoliosAsync (DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null, string query = null, List<string> propertyKeys = null)
        {
             ApiResponse<ResourceListOfPortfolio> localVarResponse = await ListPortfoliosAsyncWithHttpInfo(effectiveAt, asAt, page, start, limit, filter, query, propertyKeys);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List portfolios List all the portfolios matching the specified criteria.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to return the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios from a previous call to list portfolios. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 65,535 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="query">Expression specifying the criteria that the returned portfolios must meet e.g. to see which              portfolios have holdings in the instruments with a Lusid Instrument Id (LUID) of &#39;LUID_PPA8HI6M&#39; or a Figi of &#39;BBG000BLNNH6&#39;              you would specify \&quot;instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))\&quot;. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto each portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfPortfolio)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResourceListOfPortfolio>> ListPortfoliosAsyncWithHttpInfo (DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null, string query = null, List<string> propertyKeys = null)
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
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (query != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "query", query)); // query parameter
            if (propertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "propertyKeys", propertyKeys)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.10.976";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ResourceListOfPortfolio) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfPortfolio)));
        }

        /// <summary>
        /// List portfolios for scope List all the portfolios in a single scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolios.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to return the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios from a previous call to list portfolios. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 65,535 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto each portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>ResourceListOfPortfolio</returns>
        public ResourceListOfPortfolio ListPortfoliosForScope (string scope, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null, List<string> propertyKeys = null)
        {
             ApiResponse<ResourceListOfPortfolio> localVarResponse = ListPortfoliosForScopeWithHttpInfo(scope, effectiveAt, asAt, page, start, limit, filter, propertyKeys);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List portfolios for scope List all the portfolios in a single scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolios.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to return the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios from a previous call to list portfolios. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 65,535 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto each portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPortfolio</returns>
        public ApiResponse< ResourceListOfPortfolio > ListPortfoliosForScopeWithHttpInfo (string scope, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null, List<string> propertyKeys = null)
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
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (propertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "propertyKeys", propertyKeys)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.10.976";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ResourceListOfPortfolio) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfPortfolio)));
        }

        /// <summary>
        /// List portfolios for scope List all the portfolios in a single scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolios.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to return the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios from a previous call to list portfolios. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 65,535 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto each portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>Task of ResourceListOfPortfolio</returns>
        public async System.Threading.Tasks.Task<ResourceListOfPortfolio> ListPortfoliosForScopeAsync (string scope, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null, List<string> propertyKeys = null)
        {
             ApiResponse<ResourceListOfPortfolio> localVarResponse = await ListPortfoliosForScopeAsyncWithHttpInfo(scope, effectiveAt, asAt, page, start, limit, filter, propertyKeys);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List portfolios for scope List all the portfolios in a single scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolios.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to return the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios from a previous call to list portfolios. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 65,535 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto each portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfPortfolio)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResourceListOfPortfolio>> ListPortfoliosForScopeAsyncWithHttpInfo (string scope, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null, List<string> propertyKeys = null)
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
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (propertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "propertyKeys", propertyKeys)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.10.976";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ResourceListOfPortfolio) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfPortfolio)));
        }

        /// <summary>
        /// Update portfolio Update the definition of a single portfolio. Not all elements within a portfolio definition are  modifiable due to the potential implications for data already stored against the portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to update the definition for.</param>
        /// <param name="code">The code of the portfolio to update the definition for. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="portfolioDefinition">The updated portfolio definition.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to update the definition. Defaults to the current              LUSID system datetime if not specified. (optional)</param>
        /// <returns>Portfolio</returns>
        public Portfolio UpdatePortfolio (string scope, string code, UpdatePortfolioRequest portfolioDefinition, DateTimeOrCutLabel effectiveAt = null)
        {
             ApiResponse<Portfolio> localVarResponse = UpdatePortfolioWithHttpInfo(scope, code, portfolioDefinition, effectiveAt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update portfolio Update the definition of a single portfolio. Not all elements within a portfolio definition are  modifiable due to the potential implications for data already stored against the portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to update the definition for.</param>
        /// <param name="code">The code of the portfolio to update the definition for. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="portfolioDefinition">The updated portfolio definition.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to update the definition. Defaults to the current              LUSID system datetime if not specified. (optional)</param>
        /// <returns>ApiResponse of Portfolio</returns>
        public ApiResponse< Portfolio > UpdatePortfolioWithHttpInfo (string scope, string code, UpdatePortfolioRequest portfolioDefinition, DateTimeOrCutLabel effectiveAt = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->UpdatePortfolio");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->UpdatePortfolio");
            // verify the required parameter 'portfolioDefinition' is set
            if (portfolioDefinition == null)
                throw new ApiException(400, "Missing required parameter 'portfolioDefinition' when calling PortfoliosApi->UpdatePortfolio");

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
            if (portfolioDefinition != null && portfolioDefinition.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(portfolioDefinition); // http body (model) parameter
            }
            else
            {
                localVarPostBody = portfolioDefinition; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.10.976";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Portfolio) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Portfolio)));
        }

        /// <summary>
        /// Update portfolio Update the definition of a single portfolio. Not all elements within a portfolio definition are  modifiable due to the potential implications for data already stored against the portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to update the definition for.</param>
        /// <param name="code">The code of the portfolio to update the definition for. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="portfolioDefinition">The updated portfolio definition.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to update the definition. Defaults to the current              LUSID system datetime if not specified. (optional)</param>
        /// <returns>Task of Portfolio</returns>
        public async System.Threading.Tasks.Task<Portfolio> UpdatePortfolioAsync (string scope, string code, UpdatePortfolioRequest portfolioDefinition, DateTimeOrCutLabel effectiveAt = null)
        {
             ApiResponse<Portfolio> localVarResponse = await UpdatePortfolioAsyncWithHttpInfo(scope, code, portfolioDefinition, effectiveAt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update portfolio Update the definition of a single portfolio. Not all elements within a portfolio definition are  modifiable due to the potential implications for data already stored against the portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to update the definition for.</param>
        /// <param name="code">The code of the portfolio to update the definition for. Together with the scope this uniquely              identifies the portfolio.</param>
        /// <param name="portfolioDefinition">The updated portfolio definition.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to update the definition. Defaults to the current              LUSID system datetime if not specified. (optional)</param>
        /// <returns>Task of ApiResponse (Portfolio)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Portfolio>> UpdatePortfolioAsyncWithHttpInfo (string scope, string code, UpdatePortfolioRequest portfolioDefinition, DateTimeOrCutLabel effectiveAt = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->UpdatePortfolio");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->UpdatePortfolio");
            // verify the required parameter 'portfolioDefinition' is set
            if (portfolioDefinition == null)
                throw new ApiException(400, "Missing required parameter 'portfolioDefinition' when calling PortfoliosApi->UpdatePortfolio");

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
            if (portfolioDefinition != null && portfolioDefinition.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(portfolioDefinition); // http body (model) parameter
            }
            else
            {
                localVarPostBody = portfolioDefinition; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.10.976";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Portfolio) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Portfolio)));
        }

        /// <summary>
        /// Upsert portfolio properties Update or insert one or more properties onto a single portfolio. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;Portfolio&#39;.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to update or insert the properties onto.</param>
        /// <param name="code">The code of the portfolio to update or insert the properties onto. Together with the scope              this uniquely identifies the portfolio.</param>
        /// <param name="portfolioProperties">The properties to be updated or inserted onto the portfolio. Each property in              the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;.</param>
        /// <returns>PortfolioProperties</returns>
        public PortfolioProperties UpsertPortfolioProperties (string scope, string code, Dictionary<string, Property> portfolioProperties)
        {
             ApiResponse<PortfolioProperties> localVarResponse = UpsertPortfolioPropertiesWithHttpInfo(scope, code, portfolioProperties);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Upsert portfolio properties Update or insert one or more properties onto a single portfolio. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;Portfolio&#39;.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to update or insert the properties onto.</param>
        /// <param name="code">The code of the portfolio to update or insert the properties onto. Together with the scope              this uniquely identifies the portfolio.</param>
        /// <param name="portfolioProperties">The properties to be updated or inserted onto the portfolio. Each property in              the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;.</param>
        /// <returns>ApiResponse of PortfolioProperties</returns>
        public ApiResponse< PortfolioProperties > UpsertPortfolioPropertiesWithHttpInfo (string scope, string code, Dictionary<string, Property> portfolioProperties)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->UpsertPortfolioProperties");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->UpsertPortfolioProperties");
            // verify the required parameter 'portfolioProperties' is set
            if (portfolioProperties == null)
                throw new ApiException(400, "Missing required parameter 'portfolioProperties' when calling PortfoliosApi->UpsertPortfolioProperties");

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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.10.976";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PortfolioProperties) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortfolioProperties)));
        }

        /// <summary>
        /// Upsert portfolio properties Update or insert one or more properties onto a single portfolio. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;Portfolio&#39;.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to update or insert the properties onto.</param>
        /// <param name="code">The code of the portfolio to update or insert the properties onto. Together with the scope              this uniquely identifies the portfolio.</param>
        /// <param name="portfolioProperties">The properties to be updated or inserted onto the portfolio. Each property in              the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;.</param>
        /// <returns>Task of PortfolioProperties</returns>
        public async System.Threading.Tasks.Task<PortfolioProperties> UpsertPortfolioPropertiesAsync (string scope, string code, Dictionary<string, Property> portfolioProperties)
        {
             ApiResponse<PortfolioProperties> localVarResponse = await UpsertPortfolioPropertiesAsyncWithHttpInfo(scope, code, portfolioProperties);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Upsert portfolio properties Update or insert one or more properties onto a single portfolio. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;Portfolio&#39;.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to update or insert the properties onto.</param>
        /// <param name="code">The code of the portfolio to update or insert the properties onto. Together with the scope              this uniquely identifies the portfolio.</param>
        /// <param name="portfolioProperties">The properties to be updated or inserted onto the portfolio. Each property in              the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;.</param>
        /// <returns>Task of ApiResponse (PortfolioProperties)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PortfolioProperties>> UpsertPortfolioPropertiesAsyncWithHttpInfo (string scope, string code, Dictionary<string, Property> portfolioProperties)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->UpsertPortfolioProperties");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->UpsertPortfolioProperties");
            // verify the required parameter 'portfolioProperties' is set
            if (portfolioProperties == null)
                throw new ApiException(400, "Missing required parameter 'portfolioProperties' when calling PortfoliosApi->UpsertPortfolioProperties");

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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.10.976";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PortfolioProperties) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortfolioProperties)));
        }

    }
}