/* 
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  # Data Model  The LUSID API has a relatively lightweight but extremely powerful data model. One of the goals of LUSID was not to enforce on clients a single rigid data model but rather to provide a flexible foundation onto which clients can map their own data models.  The core entities in LUSID provide a minimal structure and set of relationships, and the data model can be extended using Properties.  The LUSID data model is exposed through the LUSID APIs.  The APIs provide access to both business objects and the meta data used to configure the systems behaviours.   The key business entities are: - * **Portfolios** A portfolio is a container for transactions and holdings (a **Transaction Portfolio**) or constituents (a **Reference Portfolio**). * **Derived Portfolios**. Derived Portfolios allow Portfolios to be created based on other Portfolios, by overriding or adding specific items. * **Holdings** A Holding is a quantity of an Instrument or a balance of cash within a Portfolio.  Holdings can only be adjusted via Transactions. * **Transactions** A Transaction is an economic event that occurs in a Portfolio, causing its holdings to change. * **Corporate Actions** A corporate action is a market event which occurs to an Instrument and thus applies to all portfolios which holding the instrument.  Examples are stock splits or mergers. * **Constituents** A constituent is a record in a Reference Portfolio containing an Instrument and an associated weight. * **Instruments**  An instrument represents a currency, tradable instrument or OTC contract that is attached to a transaction and a holding. * **Properties** All major entities allow additional user defined properties to be associated with them.   For example, a Portfolio manager may be associated with a portfolio.  Meta data includes: - * **Transaction Types** Transactions are booked with a specific transaction type.  The types are client defined and are used to map the Transaction to a series of movements which update the portfolio holdings.  * **Properties Types** Types of user defined properties used within the system.  ## Scope  All data in LUSID is segregated at the client level.  Entities in LUSID are identifiable by a unique code.  Every entity lives within a logical data partition known as a Scope.  Scope is an identity namespace allowing two entities with the same unique code to co-exist within individual address spaces.  For example, prices for equities from different vendors may be uploaded into different scopes such as `client/vendor1` and `client/vendor2`.  A portfolio may then be valued using either of the price sources by referencing the appropriate scope.  LUSID Clients cannot access scopes of other clients.  ## Instruments  LUSID has its own built-in instrument master which you can use to master your own instrument universe.  Every instrument must be created with one or more unique market identifiers, such as [FIGI](https://openfigi.com/). For any non-listed instruments (eg OTCs), you can upload an instrument against a custom ID of your choosing.  In addition, LUSID will allocate each instrument a unique 'LUSID instrument identifier'. The LUSID instrument identifier is what is used when uploading transactions, holdings, prices, etc. The API exposes an `instrument/lookup` endpoint which can be used to lookup these LUSID identifiers using their market identifiers.  Cash can be referenced using the ISO currency code prefixed with \"`CCY_`\" e.g. `CCY_GBP`  ## Instrument Data  Instrument data can be uploaded to the system using the [Instrument Properties](#operation/UpsertInstrumentsProperties) endpoint.  | Field|Type|Description | | - --|- --|- -- | | Key|propertykey|The key of the property. This takes the format {domain}/{scope}/{code} e.g. 'Instrument/system/Name' or 'Transaction/strategy/quantsignal'. | | Value|string|The value of the property. | | EffectiveFrom|datetimeoffset|The effective datetime from which the property is valid. | | EffectiveUntil|datetimeoffset|The effective datetime until which the property is valid. If not supplied this will be valid indefinitely, or until the next 'effectiveFrom' datetime of the property. |   ## Transaction Portfolios  Portfolios are the top-level entity containers within LUSID, containing transactions, corporate actions and holdings.    The transactions build up the portfolio holdings on which valuations, analytics profit & loss and risk can be calculated.  Properties can be associated with Portfolios to add in additional data.  Portfolio properties can be changed over time, for example to allow a Portfolio Manager to be linked with a Portfolio.  Additionally, portfolios can be securitised and held by other portfolios, allowing LUSID to perform \"drill-through\" into underlying fund holdings  ### Derived Portfolios  LUSID also allows for a portfolio to be composed of another portfolio via derived portfolios.  A derived portfolio can contain its own transactions and also inherits any transactions from its parent portfolio.  Any changes made to the parent portfolio are automatically reflected in derived portfolio.  Derived portfolios in conjunction with scopes are a powerful construct.  For example, to do pre-trade what-if analysis, a derived portfolio could be created a new namespace linked to the underlying live (parent) portfolio.  Analysis can then be undertaken on the derived portfolio without affecting the live portfolio.  ### Transactions  A transaction represents an economic activity against a Portfolio.  Transactions are processed according to a configuration. This will tell the LUSID engine how to interpret the transaction and correctly update the holdings. LUSID comes with a set of transaction types you can use out of the box, or you can configure your own set(s) of transactions.  For more details see the [LUSID Getting Started Guide for transaction configuration.](https://support.lusid.com/configuring-transaction-types)  | Field|Type|Description | | - --|- --|- -- | | TransactionId|string|The unique identifier of the transaction. | | Type|string|The type of the transaction, for example 'Buy' or 'Sell'. The transaction type must have been pre-configured using the System Configuration API. If not, this operation will succeed but you are not able to calculate holdings for the portfolio that include this transaction. | | InstrumentIdentifiers|map|A set of instrument identifiers that can resolve the transaction to a unique instrument. | | TransactionDate|dateorcutlabel|The date of the transaction. | | SettlementDate|dateorcutlabel|The settlement date of the transaction. | | Units|decimal|The number of units of the transacted instrument. | | TransactionPrice|transactionprice|The price of each instrument unit in the transaction currency. | | TotalConsideration|currencyandamount|The total value of the transaction in the settlement currency. | | ExchangeRate|decimal|The exchange rate between the transaction and settlement currency (settlement currency being represented by TotalConsideration.Currency). For example, if the transaction currency is USD and the settlement currency is GBP, this would be the appropriate USD/GBP rate. | | TransactionCurrency|currency|The transaction currency. | | Properties|map|A list of unique transaction properties and associated values to store for the transaction. Each property must be from the 'Transaction' domain. | | CounterpartyId|string|The identifier for the counterparty of the transaction. | | Source|string|The source of the transaction. This is used to look up the appropriate transaction group set in the transaction type configuration. |   From these fields, the following values can be calculated  * **Transaction value in Transaction currency**: TotalConsideration / ExchangeRate  * **Transaction value in Portfolio currency**: Transaction value in Transaction currency * TradeToPortfolioRate  #### Example Transactions  ##### A Common Purchase Example Three example transactions are shown in the table below.   They represent a purchase of USD denominated IBM shares within a Sterling denominated portfolio.   * The first two transactions are for separate buy and fx trades    * Buying 500 IBM shares for $71,480.00    * A spot foreign exchange conversion to fund the IBM purchase. (Buy $71,480.00 for &#163;54,846.60)  * The third transaction is an alternate version of the above trades. Buying 500 IBM shares and settling directly in Sterling.  | Column |  Buy Trade | Fx Trade | Buy Trade with foreign Settlement | | - -- -- | - -- -- | - -- -- | - -- -- | | TransactionId | FBN00001 | FBN00002 | FBN00003 | | Type | Buy | FxBuy | Buy | | InstrumentIdentifiers | { \"figi\", \"BBG000BLNNH6\" } | { \"CCY\", \"CCY_USD\" } | { \"figi\", \"BBG000BLNNH6\" } | | TransactionDate | 2018-08-02 | 2018-08-02 | 2018-08-02 | | SettlementDate | 2018-08-06 | 2018-08-06 | 2018-08-06 | | Units | 500 | 71480 | 500 | | TransactionPrice | 142.96 | 1 | 142.96 | | TradeCurrency | USD | USD | USD | | ExchangeRate | 1 | 0.7673 | 0.7673 | | TotalConsideration.Amount | 71480.00 | 54846.60 | 54846.60 | | TotalConsideration.Currency | USD | GBP | GBP | | Trade/default/TradeToPortfolioRate&ast; | 0.7673 | 0.7673 | 0.7673 |  [&ast; This is a property field]  ##### A Forward FX Example  LUSID has a flexible transaction modelling system, meaning there are a number of different ways of modelling forward fx trades.  The default LUSID transaction types are FwdFxBuy and FwdFxSell. Using these transaction types, LUSID will generate two holdings for each Forward FX trade, one for each currency in the trade.  An example Forward Fx trade to sell GBP for USD in a JPY-denominated portfolio is shown below:  | Column | Forward 'Sell' Trade | Notes | | - -- -- | - -- -- | - -- - | | TransactionId | FBN00004 | | | Type | FwdFxSell | | | InstrumentIdentifiers | { \"Instrument/default/Currency\", \"GBP\" } | | | TransactionDate | 2018-08-02 | | | SettlementDate | 2019-02-06 | Six month forward | | Units | 10000.00 | Units of GBP | | TransactionPrice | 1 | | | TradeCurrency | GBP | Currency being sold | | ExchangeRate | 1.3142 | Agreed rate between GBP and USD | | TotalConsideration.Amount | 13142.00 | Amount in the settlement currency, USD | | TotalConsideration.Currency | USD | Settlement currency | | Trade/default/TradeToPortfolioRate | 142.88 | Rate between trade currency, GBP and portfolio base currency, JPY |  Please note that exactly the same economic behaviour could be modelled using the FwdFxBuy Transaction Type with the amounts and rates reversed.  ### Holdings  A holding represents a position in an instrument or cash on a given date.  | Field|Type|Description | | - --|- --|- -- | | InstrumentUid|string|The unique Lusid Instrument Id (LUID) of the instrument that the holding is in. | | SubHoldingKeys|map|The sub-holding properties which identify the holding. Each property will be from the 'Transaction' domain. These are configured when a transaction portfolio is created. | | Properties|map|The properties which have been requested to be decorated onto the holding. These will be from the 'Instrument' or 'Holding' domain. | | HoldingType|string|The type of the holding e.g. Position, Balance, CashCommitment, Receivable, ForwardFX etc. | | Units|decimal|The total number of units of the holding. | | SettledUnits|decimal|The total number of settled units of the holding. | | Cost|currencyandamount|The total cost of the holding in the transaction currency. | | CostPortfolioCcy|currencyandamount|The total cost of the holding in the portfolio currency. | | Transaction|transaction|The transaction associated with an unsettled holding. | | Currency|currency|The holding currency. |   ## Corporate Actions  Corporate actions are represented within LUSID in terms of a set of instrument-specific 'transitions'.  These transitions are used to specify the participants of the corporate action, and the effect that the corporate action will have on holdings in those participants.  ### Corporate Action  | Field|Type|Description | | - --|- --|- -- | | CorporateActionCode|code|The unique identifier of this corporate action | | Description|string|  | | AnnouncementDate|datetimeoffset|The announcement date of the corporate action | | ExDate|datetimeoffset|The ex date of the corporate action | | RecordDate|datetimeoffset|The record date of the corporate action | | PaymentDate|datetimeoffset|The payment date of the corporate action | | Transitions|corporateactiontransition[]|The transitions that result from this corporate action |   ### Transition | Field|Type|Description | | - --|- --|- -- | | InputTransition|corporateactiontransitioncomponent|Indicating the basis of the corporate action - which security and how many units | | OutputTransitions|corporateactiontransitioncomponent[]|What will be generated relative to the input transition |   ### Example Corporate Action Transitions  #### A Dividend Action Transition  In this example, for each share of IBM, 0.20 units (or 20 pence) of GBP are generated.  | Column |  Input Transition | Output Transition | | - -- -- | - -- -- | - -- -- | | Instrument Identifiers | { \"figi\" : \"BBG000BLNNH6\" } | { \"ccy\" : \"CCY_GBP\" } | | Units Factor | 1 | 0.20 | | Cost Factor | 1 | 0 |  #### A Split Action Transition  In this example, for each share of IBM, we end up with 2 units (2 shares) of IBM, with total value unchanged.  | Column |  Input Transition | Output Transition | | - -- -- | - -- -- | - -- -- | | Instrument Identifiers | { \"figi\" : \"BBG000BLNNH6\" } | { \"figi\" : \"BBG000BLNNH6\" } | | Units Factor | 1 | 2 | | Cost Factor | 1 | 1 |  #### A Spinoff Action Transition  In this example, for each share of IBM, we end up with 1 unit (1 share) of IBM and 3 units (3 shares) of Celestica, with 85% of the value remaining on the IBM share, and 5% in each Celestica share (15% total).  | Column |  Input Transition | Output Transition 1 | Output Transition 2 | | - -- -- | - -- -- | - -- -- | - -- -- | | Instrument Identifiers | { \"figi\" : \"BBG000BLNNH6\" } | { \"figi\" : \"BBG000BLNNH6\" } | { \"figi\" : \"BBG000HBGRF3\" } | | Units Factor | 1 | 1 | 3 | | Cost Factor | 1 | 0.85 | 0.15 |  ## Reference Portfolios Reference portfolios are portfolios that contain constituents with weights.  They are designed to represent entities such as indices and benchmarks.  ### Constituents | Field|Type|Description | | - --|- --|- -- | | InstrumentIdentifiers|map|Unique instrument identifiers | | InstrumentUid|string|LUSID's internal unique instrument identifier, resolved from the instrument identifiers | | Currency|decimal|  | | Weight|decimal|  | | FloatingWeight|decimal|  |   ## Portfolio Groups Portfolio groups allow the construction of a hierarchy from portfolios and groups.  Portfolio operations on the group are executed on an aggregated set of portfolios in the hierarchy.   For example:   * Global Portfolios _(group)_   * APAC _(group)_     * Hong Kong _(portfolio)_     * Japan _(portfolio)_   * Europe _(group)_     * France _(portfolio)_     * Germany _(portfolio)_   * UK _(portfolio)_   In this example **Global Portfolios** is a group that consists of an aggregate of **Hong Kong**, **Japan**, **France**, **Germany** and **UK** portfolios.  ## Properties  Properties are key-value pairs that can be applied to any entity within a domain (where a domain is `trade`, `portfolio`, `security` etc).  Properties must be defined before use with a `PropertyDefinition` and can then subsequently be added to entities.   ## Schema  A detailed description of the entities used by the API and parameters for endpoints which take a JSON document can be retrieved via the `schema` endpoint.  ## Meta data  The following headers are returned on all responses from LUSID  | Name | Purpose | | - -- | - -- | | lusid-meta-duration | Duration of the request | | lusid-meta-success | Whether or not LUSID considered the request to be successful | | lusid-meta-requestId | The unique identifier for the request | | lusid-schema-url | Url of the schema for the data being returned | | lusid-property-schema-url | Url of the schema for any properties |   # Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"-10\">-10</a>|Server Configuration Error|  | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"102\">102</a>|Version Not Found|  | | <a name=\"103\">103</a>|Api Rate Limit Violation|  | | <a name=\"104\">104</a>|Instrument Not Found|  | | <a name=\"105\">105</a>|Property Not Found|  | | <a name=\"106\">106</a>|Portfolio Recursion Depth|  | | <a name=\"108\">108</a>|Group Not Found|  | | <a name=\"109\">109</a>|Portfolio Not Found|  | | <a name=\"110\">110</a>|Property Schema Not Found|  | | <a name=\"111\">111</a>|Portfolio Ancestry Not Found|  | | <a name=\"112\">112</a>|Portfolio With Id Already Exists|  | | <a name=\"113\">113</a>|Orphaned Portfolio|  | | <a name=\"119\">119</a>|Missing Base Claims|  | | <a name=\"121\">121</a>|Property Not Defined|  | | <a name=\"122\">122</a>|Cannot Delete System Property|  | | <a name=\"123\">123</a>|Cannot Modify Immutable Property Field|  | | <a name=\"124\">124</a>|Property Already Exists|  | | <a name=\"125\">125</a>|Invalid Property Life Time|  | | <a name=\"126\">126</a>|Property Constraint Style Excludes Properties|  | | <a name=\"127\">127</a>|Cannot Modify Default Data Type|  | | <a name=\"128\">128</a>|Group Already Exists|  | | <a name=\"129\">129</a>|No Such Data Type|  | | <a name=\"130\">130</a>|Undefined Value For Data Type|  | | <a name=\"131\">131</a>|Unsupported Value Type Defined On Data Type|  | | <a name=\"132\">132</a>|Validation Error|  | | <a name=\"133\">133</a>|Loop Detected In Group Hierarchy|  | | <a name=\"134\">134</a>|Undefined Acceptable Values|  | | <a name=\"135\">135</a>|Sub Group Already Exists|  | | <a name=\"138\">138</a>|Price Source Not Found|  | | <a name=\"139\">139</a>|Analytic Store Not Found|  | | <a name=\"141\">141</a>|Analytic Store Already Exists|  | | <a name=\"143\">143</a>|Client Instrument Already Exists|  | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"147\">147</a>|Results Not Found|  | | <a name=\"148\">148</a>|Order Field Not In Result Set|  | | <a name=\"149\">149</a>|Operation Failed|  | | <a name=\"150\">150</a>|Elastic Search Error|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"153\">153</a>|Command Processing Failure|  | | <a name=\"154\">154</a>|Entity State Construction Failure|  | | <a name=\"155\">155</a>|Entity Timeline Does Not Exist|  | | <a name=\"156\">156</a>|Concurrency Conflict Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"158\">158</a>|Event Publish Unknown|  | | <a name=\"159\">159</a>|Event Query Failure|  | | <a name=\"160\">160</a>|Blob Did Not Exist|  | | <a name=\"162\">162</a>|Sub System Request Failure|  | | <a name=\"163\">163</a>|Sub System Configuration Failure|  | | <a name=\"165\">165</a>|Failed To Delete|  | | <a name=\"166\">166</a>|Upsert Client Instrument Failure|  | | <a name=\"167\">167</a>|Illegal As At Interval|  | | <a name=\"168\">168</a>|Illegal Bitemporal Query|  | | <a name=\"169\">169</a>|Invalid Alternate Id|  | | <a name=\"170\">170</a>|Cannot Add Source Portfolio Property Explicitly|  | | <a name=\"171\">171</a>|Entity Already Exists In Group|  | | <a name=\"173\">173</a>|Entity With Id Already Exists|  | | <a name=\"174\">174</a>|Derived Portfolio Details Do Not Exist|  | | <a name=\"176\">176</a>|Portfolio With Name Already Exists|  | | <a name=\"177\">177</a>|Invalid Transactions|  | | <a name=\"178\">178</a>|Reference Portfolio Not Found|  | | <a name=\"179\">179</a>|Duplicate Id|  | | <a name=\"180\">180</a>|Command Retrieval Failure|  | | <a name=\"181\">181</a>|Data Filter Application Failure|  | | <a name=\"182\">182</a>|Search Failed|  | | <a name=\"183\">183</a>|Movements Engine Configuration Key Failure|  | | <a name=\"184\">184</a>|Fx Rate Source Not Found|  | | <a name=\"185\">185</a>|Accrual Source Not Found|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"188\">188</a>|Invalid Request Headers|  | | <a name=\"189\">189</a>|Price Not Found|  | | <a name=\"190\">190</a>|Invalid Sub Holding Keys Provided|  | | <a name=\"191\">191</a>|Duplicate Sub Holding Keys Provided|  | | <a name=\"192\">192</a>|Cut Definition Not Found|  | | <a name=\"193\">193</a>|Cut Definition Invalid|  | | <a name=\"194\">194</a>|Time Variant Property Deletion Date Unspecified|  | | <a name=\"195\">195</a>|Perpetual Property Deletion Date Specified|  | | <a name=\"196\">196</a>|Time Variant Property Upsert Date Unspecified|  | | <a name=\"197\">197</a>|Perpetual Property Upsert Date Specified|  | | <a name=\"200\">200</a>|Invalid Unit For Data Type|  | | <a name=\"201\">201</a>|Invalid Type For Data Type|  | | <a name=\"202\">202</a>|Invalid Value For Data Type|  | | <a name=\"203\">203</a>|Unit Not Defined For Data Type|  | | <a name=\"204\">204</a>|Units Not Supported On Data Type|  | | <a name=\"205\">205</a>|Cannot Specify Units On Data Type|  | | <a name=\"206\">206</a>|Unit Schema Inconsistent With Data Type|  | | <a name=\"207\">207</a>|Unit Definition Not Specified|  | | <a name=\"208\">208</a>|Duplicate Unit Definitions Specified|  | | <a name=\"209\">209</a>|Invalid Units Definition|  | | <a name=\"210\">210</a>|Invalid Instrument Identifier Unit|  | | <a name=\"211\">211</a>|Holdings Adjustment Does Not Exist|  | | <a name=\"212\">212</a>|Could Not Build Excel Url|  | | <a name=\"213\">213</a>|Could Not Get Excel Version|  | | <a name=\"214\">214</a>|Instrument By Code Not Found|  | | <a name=\"215\">215</a>|Entity Schema Does Not Exist|  | | <a name=\"216\">216</a>|Feature Not Supported On Portfolio Type|  | | <a name=\"217\">217</a>|Quote Not Found|  | | <a name=\"218\">218</a>|Invalid Quote Identifier|  | | <a name=\"219\">219</a>|Invalid Metric For Data Type|  | | <a name=\"220\">220</a>|Invalid Instrument Definition|  | | <a name=\"221\">221</a>|Instrument Upsert Failure|  | | <a name=\"222\">222</a>|Reference Portfolio Request Not Supported|  | | <a name=\"223\">223</a>|Transaction Portfolio Request Not Supported|  | | <a name=\"224\">224</a>|Invalid Property Value Assignment|  | | <a name=\"230\">230</a>|Transaction Type Not Found|  | | <a name=\"231\">231</a>|Transaction Type Duplication|  | | <a name=\"232\">232</a>|Portfolio Does Not Exist At Given Date|  | | <a name=\"233\">233</a>|Query Parser Failure|  | | <a name=\"234\">234</a>|Duplicate Constituent|  | | <a name=\"235\">235</a>|Unresolved Instrument Constituent|  | | <a name=\"236\">236</a>|Unresolved Instrument In Transition|  | | <a name=\"237\">237</a>|Missing Side Definitions|  | | <a name=\"299\">299</a>|Invalid Recipe|  | | <a name=\"300\">300</a>|Missing Recipe|  | | <a name=\"301\">301</a>|Dependencies|  | | <a name=\"304\">304</a>|Portfolio Preprocess Failure|  | | <a name=\"310\">310</a>|Valuation Engine Failure|  | | <a name=\"311\">311</a>|Task Factory Failure|  | | <a name=\"312\">312</a>|Task Evaluation Failure|  | | <a name=\"313\">313</a>|Task Generation Failure|  | | <a name=\"314\">314</a>|Engine Configuration Failure|  | | <a name=\"315\">315</a>|Model Specification Failure|  | | <a name=\"320\">320</a>|Market Data Key Failure|  | | <a name=\"321\">321</a>|Market Resolver Failure|  | | <a name=\"322\">322</a>|Market Data Failure|  | | <a name=\"330\">330</a>|Curve Failure|  | | <a name=\"331\">331</a>|Volatility Surface Failure|  | | <a name=\"332\">332</a>|Volatility Cube Failure|  | | <a name=\"350\">350</a>|Instrument Failure|  | | <a name=\"351\">351</a>|Cash Flows Failure|  | | <a name=\"352\">352</a>|Reference Data Failure|  | | <a name=\"360\">360</a>|Aggregation Failure|  | | <a name=\"361\">361</a>|Aggregation Measure Failure|  | | <a name=\"370\">370</a>|Result Retrieval Failure|  | | <a name=\"371\">371</a>|Result Processing Failure|  | | <a name=\"372\">372</a>|Vendor Result Processing Failure|  | | <a name=\"373\">373</a>|Vendor Result Mapping Failure|  | | <a name=\"374\">374</a>|Vendor Library Unauthorised|  | | <a name=\"375\">375</a>|Vendor Connectivity Error|  | | <a name=\"376\">376</a>|Vendor Interface Error|  | | <a name=\"377\">377</a>|Vendor Pricing Failure|  | | <a name=\"378\">378</a>|Vendor Translation Failure|  | | <a name=\"379\">379</a>|Vendor Key Mapping Failure|  | | <a name=\"380\">380</a>|Vendor Reflection Failure|  | | <a name=\"381\">381</a>|Vendor Process Failure|  | | <a name=\"382\">382</a>|Vendor System Failure|  | | <a name=\"390\">390</a>|Attempt To Upsert Duplicate Quotes|  | | <a name=\"391\">391</a>|Corporate Action Source Does Not Exist|  | | <a name=\"392\">392</a>|Corporate Action Source Already Exists|  | | <a name=\"393\">393</a>|Instrument Identifier Already In Use|  | | <a name=\"394\">394</a>|Properties Not Found|  | | <a name=\"395\">395</a>|Batch Operation Aborted|  | | <a name=\"400\">400</a>|Invalid Iso4217 Currency Code|  | | <a name=\"401\">401</a>|Cannot Assign Instrument Identifier To Currency|  | | <a name=\"402\">402</a>|Cannot Assign Currency Identifier To Non Currency|  | | <a name=\"403\">403</a>|Currency Instrument Cannot Be Deleted|  | | <a name=\"404\">404</a>|Currency Instrument Cannot Have Economic Definition|  | | <a name=\"405\">405</a>|Currency Instrument Cannot Have Lookthrough Portfolio|  | | <a name=\"406\">406</a>|Cannot Create Currency Instrument With Multiple Identifiers|  | | <a name=\"407\">407</a>|Specified Currency Is Undefined|  | | <a name=\"410\">410</a>|Index Does Not Exist|  | | <a name=\"411\">411</a>|Sort Field Does Not Exist|  | | <a name=\"413\">413</a>|Negative Pagination Parameters|  | | <a name=\"414\">414</a>|Invalid Search Syntax|  | | <a name=\"415\">415</a>|Filter Execution Timeout|  | | <a name=\"420\">420</a>|Side Definition Inconsistent|  | | <a name=\"450\">450</a>|Invalid Quote Access Metadata Rule|  | | <a name=\"451\">451</a>|Access Metadata Not Found|  | | <a name=\"452\">452</a>|Invalid Access Metadata Identifier|  | | <a name=\"460\">460</a>|Standard Resource Not Found|  | | <a name=\"461\">461</a>|Standard Resource Conflict|  | | <a name=\"462\">462</a>|Calendar Not Found|  | | <a name=\"463\">463</a>|Date In A Calendar Not Found|  | | <a name=\"464\">464</a>|Invalid Date Source Data|  | | <a name=\"465\">465</a>|Invalid Timezone|  | | <a name=\"601\">601</a>|Person Identifier Already In Use|  | | <a name=\"602\">602</a>|Person Not Found|  | | <a name=\"603\">603</a>|Cannot Set Identifier|  | | <a name=\"617\">617</a>|Invalid Recipe Specification In Request|  | | <a name=\"618\">618</a>|Inline Recipe Deserialisation Failure|  | | <a name=\"619\">619</a>|Identifier Types Not Set For Entity|  | | <a name=\"620\">620</a>|Cannot Delete All Client Defined Identifiers|  | | <a name=\"650\">650</a>|The Order requested was not found.|  | | <a name=\"654\">654</a>|The Allocation requested was not found.|  | | <a name=\"655\">655</a>|Cannot build the fx forward target with the given holdings.|  | | <a name=\"656\">656</a>|Group does not contain expected entities.|  | | <a name=\"667\">667</a>|Relation definition already exists|  | | <a name=\"673\">673</a>|Missing entitlements for entities in Group|  | | <a name=\"674\">674</a>|Next Best Action not found|  | | <a name=\"676\">676</a>|Relation definition not defined|  | | <a name=\"677\">677</a>|Invalid entity identifier for relation|  | | <a name=\"681\">681</a>|Sorting by specified field not supported|One or more of the provided fields to order by were either invalid or not supported. | | <a name=\"682\">682</a>|Too many fields to sort by|The number of fields to sort the data by exceeds the number allowed by the endpoint | | <a name=\"684\">684</a>|Sequence Not Found|  | | <a name=\"685\">685</a>|Sequence Already Exists|  | | <a name=\"686\">686</a>|Non-cycling sequence has been exhausted|  | | <a name=\"687\">687</a>|Legal Entity Identifier Already In Use|  | | <a name=\"688\">688</a>|Legal Entity Not Found|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"690\">690</a>|Property Type Is Not Supported|  | | <a name=\"691\">691</a>|Multiple Tax-lots For Currency Type Is Not Supported|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"693\">693</a>|Entity type is not supported for Relationship|  | | <a name=\"694\">694</a>|Relationship Validation Failure|  | | <a name=\"695\">695</a>|Relationship Not Found|  | | <a name=\"697\">697</a>|Derived Property Formula No Longer Valid|  | | <a name=\"698\">698</a>|Story is not available|  | | <a name=\"703\">703</a>|Corporate Action Does Not Exist|  | | <a name=\"720\">720</a>|The provided sort and filter combination is not valid|  | | <a name=\"721\">721</a>|A2B generation failed|  | | <a name=\"722\">722</a>|Aggregated Return Calculation Failure|  | | <a name=\"723\">723</a>|Custom Entity Definition Identifier Already In Use|  | | <a name=\"724\">724</a>|Custom Entity Definition Not Found|  | | <a name=\"725\">725</a>|The Placement requested was not found.|  | | <a name=\"726\">726</a>|The Execution requested was not found.|  | | <a name=\"727\">727</a>|The Block requested was not found.|  | | <a name=\"728\">728</a>|The Participation requested was not found.|  | | <a name=\"729\">729</a>|The Package requested was not found.|  | | <a name=\"730\">730</a>|The OrderInstruction requested was not found.|  | | <a name=\"732\">732</a>|Custom Entity not found.|  | | <a name=\"733\">733</a>|Custom Entity Identifier already in use.|  | | <a name=\"735\">735</a>|Calculation Failed.|  | | <a name=\"736\">736</a>|An expected key on HttpResponse is missing.|  | | <a name=\"737\">737</a>|A required fee detail is missing.|  | | <a name=\"738\">738</a>|Zero rows were returned from Luminesce|  | | <a name=\"739\">739</a>|Provided Weekend Mask was invalid|  | 
 *
 * The version of the OpenAPI document: 0.11.3347
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
    public interface ITransactionPortfoliosApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Adjust holdings
        /// </summary>
        /// <remarks>
        /// Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The selected set of holdings to adjust to the provided targets for the              transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>AdjustHolding</returns>
        AdjustHolding AdjustHoldings (string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = null);

        /// <summary>
        /// Adjust holdings
        /// </summary>
        /// <remarks>
        /// Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The selected set of holdings to adjust to the provided targets for the              transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>ApiResponse of AdjustHolding</returns>
        ApiResponse<AdjustHolding> AdjustHoldingsWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = null);
        /// <summary>
        /// Build transactions
        /// </summary>
        /// <remarks>
        /// Builds and returns all transactions that affect the holdings of a portfolio over a given interval of  effective time into a set of output transactions. This includes transactions automatically generated by  LUSID such as holding adjustments.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or              \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <returns>VersionedResourceListOfOutputTransaction</returns>
        VersionedResourceListOfOutputTransaction BuildTransactions (string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, int? limit = null, string page = null);

        /// <summary>
        /// Build transactions
        /// </summary>
        /// <remarks>
        /// Builds and returns all transactions that affect the holdings of a portfolio over a given interval of  effective time into a set of output transactions. This includes transactions automatically generated by  LUSID such as holding adjustments.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or              \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfOutputTransaction</returns>
        ApiResponse<VersionedResourceListOfOutputTransaction> BuildTransactionsWithHttpInfo (string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, int? limit = null, string page = null);
        /// <summary>
        /// Cancel adjust holdings
        /// </summary>
        /// <remarks>
        /// Cancel all previous holding adjustments made on the specified transaction portfolio for a specified effective  datetime. This should be used to undo holding adjustments made via set holdings or adjust holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holding adjustments should be undone.</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse CancelAdjustHoldings (string scope, string code, DateTimeOrCutLabel effectiveAt);

        /// <summary>
        /// Cancel adjust holdings
        /// </summary>
        /// <remarks>
        /// Cancel all previous holding adjustments made on the specified transaction portfolio for a specified effective  datetime. This should be used to undo holding adjustments made via set holdings or adjust holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holding adjustments should be undone.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> CancelAdjustHoldingsWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt);
        /// <summary>
        /// Cancel transactions
        /// </summary>
        /// <remarks>
        /// Cancel one or more transactions from the transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionIds">The IDs of the transactions to cancel.</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse CancelTransactions (string scope, string code, List<string> transactionIds);

        /// <summary>
        /// Cancel transactions
        /// </summary>
        /// <remarks>
        /// Cancel one or more transactions from the transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionIds">The IDs of the transactions to cancel.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> CancelTransactionsWithHttpInfo (string scope, string code, List<string> transactionIds);
        /// <summary>
        /// Create portfolio
        /// </summary>
        /// <remarks>
        /// Create a transaction portfolio in a particular scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope in which to create the transaction portfolio.</param>
        /// <param name="createTransactionPortfolioRequest">The definition of the transaction portfolio.</param>
        /// <returns>Portfolio</returns>
        Portfolio CreatePortfolio (string scope, CreateTransactionPortfolioRequest createTransactionPortfolioRequest);

        /// <summary>
        /// Create portfolio
        /// </summary>
        /// <remarks>
        /// Create a transaction portfolio in a particular scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope in which to create the transaction portfolio.</param>
        /// <param name="createTransactionPortfolioRequest">The definition of the transaction portfolio.</param>
        /// <returns>ApiResponse of Portfolio</returns>
        ApiResponse<Portfolio> CreatePortfolioWithHttpInfo (string scope, CreateTransactionPortfolioRequest createTransactionPortfolioRequest);
        /// <summary>
        /// Delete properties from transaction
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a single transaction in a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction from which to delete properties.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete.              These must be from the \&quot;Transaction\&quot; domain and have the format {domain}/{scope}/{code}, for example              \&quot;Transaction/strategy/quantsignal\&quot;.</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeletePropertiesFromTransaction (string scope, string code, string transactionId, List<string> propertyKeys);

        /// <summary>
        /// Delete properties from transaction
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a single transaction in a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction from which to delete properties.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete.              These must be from the \&quot;Transaction\&quot; domain and have the format {domain}/{scope}/{code}, for example              \&quot;Transaction/strategy/quantsignal\&quot;.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeletePropertiesFromTransactionWithHttpInfo (string scope, string code, string transactionId, List<string> propertyKeys);
        /// <summary>
        /// Get details
        /// </summary>
        /// <remarks>
        /// Get certain details associated with a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the              scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to returning the latest version of the details if not specified. (optional)</param>
        /// <returns>PortfolioDetails</returns>
        PortfolioDetails GetDetails (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null);

        /// <summary>
        /// Get details
        /// </summary>
        /// <remarks>
        /// Get certain details associated with a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the              scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to returning the latest version of the details if not specified. (optional)</param>
        /// <returns>ApiResponse of PortfolioDetails</returns>
        ApiResponse<PortfolioDetails> GetDetailsWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null);
        /// <summary>
        /// Get holdings
        /// </summary>
        /// <remarks>
        /// Calculate holdings for a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Holding Type, use \&quot;holdingType eq &#39;p&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Holding\&quot; domain to decorate onto              holdings. These must have the format {domain}/{scope}/{code}, for example \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <returns>VersionedResourceListOfPortfolioHolding</returns>
        VersionedResourceListOfPortfolioHolding GetHoldings (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, bool? byTaxlots = null);

        /// <summary>
        /// Get holdings
        /// </summary>
        /// <remarks>
        /// Calculate holdings for a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Holding Type, use \&quot;holdingType eq &#39;p&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Holding\&quot; domain to decorate onto              holdings. These must have the format {domain}/{scope}/{code}, for example \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfPortfolioHolding</returns>
        ApiResponse<VersionedResourceListOfPortfolioHolding> GetHoldingsWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, bool? byTaxlots = null);
        /// <summary>
        /// Get holdings adjustment
        /// </summary>
        /// <remarks>
        /// Get a holdings adjustment made to a transaction portfolio at a specific effective datetime. Note that a  holdings adjustment will only be returned if one exists for the specified effective datetime.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label of the holdings adjustment.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. (optional)</param>
        /// <returns>HoldingsAdjustment</returns>
        HoldingsAdjustment GetHoldingsAdjustment (string scope, string code, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = null);

        /// <summary>
        /// Get holdings adjustment
        /// </summary>
        /// <remarks>
        /// Get a holdings adjustment made to a transaction portfolio at a specific effective datetime. Note that a  holdings adjustment will only be returned if one exists for the specified effective datetime.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label of the holdings adjustment.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. (optional)</param>
        /// <returns>ApiResponse of HoldingsAdjustment</returns>
        ApiResponse<HoldingsAdjustment> GetHoldingsAdjustmentWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = null);
        /// <summary>
        /// [EARLY ACCESS] Get portfolio cash statement
        /// </summary>
        /// <remarks>
        /// Get a cash statement for a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <returns>ResourceListOfPortfolioCashFlow</returns>
        ResourceListOfPortfolioCashFlow GetPortfolioCashStatement (string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = null, string filter = null, string recipeIdScope = null, string recipeIdCode = null);

        /// <summary>
        /// [EARLY ACCESS] Get portfolio cash statement
        /// </summary>
        /// <remarks>
        /// Get a cash statement for a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPortfolioCashFlow</returns>
        ApiResponse<ResourceListOfPortfolioCashFlow> GetPortfolioCashStatementWithHttpInfo (string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = null, string filter = null, string recipeIdScope = null, string recipeIdCode = null);
        /// <summary>
        /// Get transactions
        /// </summary>
        /// <remarks>
        /// Retrieve all the transactions that occurred during a particular time interval.     If the portfolio is a derived transaction portfolio, the transactions returned are the  union set of all transactions of the parent (and any grandparents, etc.) as well as  those of the derived transaction portfolio itself.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.              There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve transactions. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression with which to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; or &#39;Transaction&#39; domain to decorate onto              transactions. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39; or              &#39;Transaction/strategy/quantsignal&#39;. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <returns>VersionedResourceListOfTransaction</returns>
        VersionedResourceListOfTransaction GetTransactions (string scope, string code, DateTimeOrCutLabel fromTransactionDate = null, DateTimeOrCutLabel toTransactionDate = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, string page = null, int? limit = null);

        /// <summary>
        /// Get transactions
        /// </summary>
        /// <remarks>
        /// Retrieve all the transactions that occurred during a particular time interval.     If the portfolio is a derived transaction portfolio, the transactions returned are the  union set of all transactions of the parent (and any grandparents, etc.) as well as  those of the derived transaction portfolio itself.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.              There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve transactions. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression with which to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; or &#39;Transaction&#39; domain to decorate onto              transactions. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39; or              &#39;Transaction/strategy/quantsignal&#39;. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfTransaction</returns>
        ApiResponse<VersionedResourceListOfTransaction> GetTransactionsWithHttpInfo (string scope, string code, DateTimeOrCutLabel fromTransactionDate = null, DateTimeOrCutLabel toTransactionDate = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, string page = null, int? limit = null);
        /// <summary>
        /// List holdings adjustments
        /// </summary>
        /// <remarks>
        /// List the holdings adjustments made to the specified transaction portfolio over a specified interval of effective time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. (optional)</param>
        /// <returns>ResourceListOfHoldingsAdjustmentHeader</returns>
        ResourceListOfHoldingsAdjustmentHeader ListHoldingsAdjustments (string scope, string code, DateTimeOrCutLabel fromEffectiveAt = null, DateTimeOrCutLabel toEffectiveAt = null, DateTimeOffset? asAt = null);

        /// <summary>
        /// List holdings adjustments
        /// </summary>
        /// <remarks>
        /// List the holdings adjustments made to the specified transaction portfolio over a specified interval of effective time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfHoldingsAdjustmentHeader</returns>
        ApiResponse<ResourceListOfHoldingsAdjustmentHeader> ListHoldingsAdjustmentsWithHttpInfo (string scope, string code, DateTimeOrCutLabel fromEffectiveAt = null, DateTimeOrCutLabel toEffectiveAt = null, DateTimeOffset? asAt = null);
        /// <summary>
        /// [EARLY ACCESS] Resolve instrument
        /// </summary>
        /// <remarks>
        /// Try to resolve the instrument for transaction and holdings for a given instrument identifier and a specified    period of time. Also update the instrument identifiers with the given instrument identifiers collection.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="instrumentIdentifierType">The instrument identifier type.</param>
        /// <param name="instrumentIdentifierValue">The value for the given instrument identifier.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="requestBody">The dictionary with the instrument identifiers to be updated on the              transaction and holdings. (optional)</param>
        /// <returns>UpsertPortfolioTransactionsResponse</returns>
        UpsertPortfolioTransactionsResponse ResolveInstrument (string scope, string code, string instrumentIdentifierType, string instrumentIdentifierValue, DateTimeOrCutLabel fromEffectiveAt = null, Dictionary<string, string> requestBody = null);

        /// <summary>
        /// [EARLY ACCESS] Resolve instrument
        /// </summary>
        /// <remarks>
        /// Try to resolve the instrument for transaction and holdings for a given instrument identifier and a specified    period of time. Also update the instrument identifiers with the given instrument identifiers collection.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="instrumentIdentifierType">The instrument identifier type.</param>
        /// <param name="instrumentIdentifierValue">The value for the given instrument identifier.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="requestBody">The dictionary with the instrument identifiers to be updated on the              transaction and holdings. (optional)</param>
        /// <returns>ApiResponse of UpsertPortfolioTransactionsResponse</returns>
        ApiResponse<UpsertPortfolioTransactionsResponse> ResolveInstrumentWithHttpInfo (string scope, string code, string instrumentIdentifierType, string instrumentIdentifierValue, DateTimeOrCutLabel fromEffectiveAt = null, Dictionary<string, string> requestBody = null);
        /// <summary>
        /// Set holdings
        /// </summary>
        /// <remarks>
        /// Set the holdings of the specified transaction portfolio to the provided targets. LUSID will automatically  construct adjustment transactions to ensure that the entire set of holdings for the transaction portfolio  are always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The complete set of target holdings for the transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>AdjustHolding</returns>
        AdjustHolding SetHoldings (string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = null);

        /// <summary>
        /// Set holdings
        /// </summary>
        /// <remarks>
        /// Set the holdings of the specified transaction portfolio to the provided targets. LUSID will automatically  construct adjustment transactions to ensure that the entire set of holdings for the transaction portfolio  are always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The complete set of target holdings for the transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>ApiResponse of AdjustHolding</returns>
        ApiResponse<AdjustHolding> SetHoldingsWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = null);
        /// <summary>
        /// Upsert portfolio details
        /// </summary>
        /// <remarks>
        /// Create or update certain details for a particular transaction portfolio. The details are updated if they already exist, and inserted if they do not.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="createPortfolioDetails">The details to create or update for the specified transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <returns>PortfolioDetails</returns>
        PortfolioDetails UpsertPortfolioDetails (string scope, string code, CreatePortfolioDetails createPortfolioDetails, DateTimeOrCutLabel effectiveAt = null);

        /// <summary>
        /// Upsert portfolio details
        /// </summary>
        /// <remarks>
        /// Create or update certain details for a particular transaction portfolio. The details are updated if they already exist, and inserted if they do not.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="createPortfolioDetails">The details to create or update for the specified transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <returns>ApiResponse of PortfolioDetails</returns>
        ApiResponse<PortfolioDetails> UpsertPortfolioDetailsWithHttpInfo (string scope, string code, CreatePortfolioDetails createPortfolioDetails, DateTimeOrCutLabel effectiveAt = null);
        /// <summary>
        /// Upsert transaction properties
        /// </summary>
        /// <remarks>
        /// Create or update one or more transaction properties for a single transaction in the transaction portfolio.  Each property will be updated if it already exists and created if it does not.  Both transaction and portfolio must exist at the time when properties are created or updated.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update properties for.</param>
        /// <param name="requestBody">The properties and their associated values to create or update.</param>
        /// <returns>UpsertTransactionPropertiesResponse</returns>
        UpsertTransactionPropertiesResponse UpsertTransactionProperties (string scope, string code, string transactionId, Dictionary<string, PerpetualProperty> requestBody);

        /// <summary>
        /// Upsert transaction properties
        /// </summary>
        /// <remarks>
        /// Create or update one or more transaction properties for a single transaction in the transaction portfolio.  Each property will be updated if it already exists and created if it does not.  Both transaction and portfolio must exist at the time when properties are created or updated.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update properties for.</param>
        /// <param name="requestBody">The properties and their associated values to create or update.</param>
        /// <returns>ApiResponse of UpsertTransactionPropertiesResponse</returns>
        ApiResponse<UpsertTransactionPropertiesResponse> UpsertTransactionPropertiesWithHttpInfo (string scope, string code, string transactionId, Dictionary<string, PerpetualProperty> requestBody);
        /// <summary>
        /// Upsert transactions
        /// </summary>
        /// <remarks>
        /// Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.  The maximum number of transactions that this method can upsert per request is 10,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionRequest">A list of transactions to be created or updated.</param>
        /// <returns>UpsertPortfolioTransactionsResponse</returns>
        UpsertPortfolioTransactionsResponse UpsertTransactions (string scope, string code, List<TransactionRequest> transactionRequest);

        /// <summary>
        /// Upsert transactions
        /// </summary>
        /// <remarks>
        /// Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.  The maximum number of transactions that this method can upsert per request is 10,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionRequest">A list of transactions to be created or updated.</param>
        /// <returns>ApiResponse of UpsertPortfolioTransactionsResponse</returns>
        ApiResponse<UpsertPortfolioTransactionsResponse> UpsertTransactionsWithHttpInfo (string scope, string code, List<TransactionRequest> transactionRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Adjust holdings
        /// </summary>
        /// <remarks>
        /// Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The selected set of holdings to adjust to the provided targets for the              transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>Task of AdjustHolding</returns>
        System.Threading.Tasks.Task<AdjustHolding> AdjustHoldingsAsync (string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = null);

        /// <summary>
        /// Adjust holdings
        /// </summary>
        /// <remarks>
        /// Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The selected set of holdings to adjust to the provided targets for the              transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>Task of ApiResponse (AdjustHolding)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdjustHolding>> AdjustHoldingsAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = null);
        /// <summary>
        /// Build transactions
        /// </summary>
        /// <remarks>
        /// Builds and returns all transactions that affect the holdings of a portfolio over a given interval of  effective time into a set of output transactions. This includes transactions automatically generated by  LUSID such as holding adjustments.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or              \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <returns>Task of VersionedResourceListOfOutputTransaction</returns>
        System.Threading.Tasks.Task<VersionedResourceListOfOutputTransaction> BuildTransactionsAsync (string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, int? limit = null, string page = null);

        /// <summary>
        /// Build transactions
        /// </summary>
        /// <remarks>
        /// Builds and returns all transactions that affect the holdings of a portfolio over a given interval of  effective time into a set of output transactions. This includes transactions automatically generated by  LUSID such as holding adjustments.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or              \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfOutputTransaction)</returns>
        System.Threading.Tasks.Task<ApiResponse<VersionedResourceListOfOutputTransaction>> BuildTransactionsAsyncWithHttpInfo (string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, int? limit = null, string page = null);
        /// <summary>
        /// Cancel adjust holdings
        /// </summary>
        /// <remarks>
        /// Cancel all previous holding adjustments made on the specified transaction portfolio for a specified effective  datetime. This should be used to undo holding adjustments made via set holdings or adjust holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holding adjustments should be undone.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> CancelAdjustHoldingsAsync (string scope, string code, DateTimeOrCutLabel effectiveAt);

        /// <summary>
        /// Cancel adjust holdings
        /// </summary>
        /// <remarks>
        /// Cancel all previous holding adjustments made on the specified transaction portfolio for a specified effective  datetime. This should be used to undo holding adjustments made via set holdings or adjust holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holding adjustments should be undone.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> CancelAdjustHoldingsAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt);
        /// <summary>
        /// Cancel transactions
        /// </summary>
        /// <remarks>
        /// Cancel one or more transactions from the transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionIds">The IDs of the transactions to cancel.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> CancelTransactionsAsync (string scope, string code, List<string> transactionIds);

        /// <summary>
        /// Cancel transactions
        /// </summary>
        /// <remarks>
        /// Cancel one or more transactions from the transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionIds">The IDs of the transactions to cancel.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> CancelTransactionsAsyncWithHttpInfo (string scope, string code, List<string> transactionIds);
        /// <summary>
        /// Create portfolio
        /// </summary>
        /// <remarks>
        /// Create a transaction portfolio in a particular scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope in which to create the transaction portfolio.</param>
        /// <param name="createTransactionPortfolioRequest">The definition of the transaction portfolio.</param>
        /// <returns>Task of Portfolio</returns>
        System.Threading.Tasks.Task<Portfolio> CreatePortfolioAsync (string scope, CreateTransactionPortfolioRequest createTransactionPortfolioRequest);

        /// <summary>
        /// Create portfolio
        /// </summary>
        /// <remarks>
        /// Create a transaction portfolio in a particular scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope in which to create the transaction portfolio.</param>
        /// <param name="createTransactionPortfolioRequest">The definition of the transaction portfolio.</param>
        /// <returns>Task of ApiResponse (Portfolio)</returns>
        System.Threading.Tasks.Task<ApiResponse<Portfolio>> CreatePortfolioAsyncWithHttpInfo (string scope, CreateTransactionPortfolioRequest createTransactionPortfolioRequest);
        /// <summary>
        /// Delete properties from transaction
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a single transaction in a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction from which to delete properties.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete.              These must be from the \&quot;Transaction\&quot; domain and have the format {domain}/{scope}/{code}, for example              \&quot;Transaction/strategy/quantsignal\&quot;.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeletePropertiesFromTransactionAsync (string scope, string code, string transactionId, List<string> propertyKeys);

        /// <summary>
        /// Delete properties from transaction
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a single transaction in a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction from which to delete properties.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete.              These must be from the \&quot;Transaction\&quot; domain and have the format {domain}/{scope}/{code}, for example              \&quot;Transaction/strategy/quantsignal\&quot;.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeletePropertiesFromTransactionAsyncWithHttpInfo (string scope, string code, string transactionId, List<string> propertyKeys);
        /// <summary>
        /// Get details
        /// </summary>
        /// <remarks>
        /// Get certain details associated with a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the              scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to returning the latest version of the details if not specified. (optional)</param>
        /// <returns>Task of PortfolioDetails</returns>
        System.Threading.Tasks.Task<PortfolioDetails> GetDetailsAsync (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null);

        /// <summary>
        /// Get details
        /// </summary>
        /// <remarks>
        /// Get certain details associated with a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the              scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to returning the latest version of the details if not specified. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioDetails)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioDetails>> GetDetailsAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null);
        /// <summary>
        /// Get holdings
        /// </summary>
        /// <remarks>
        /// Calculate holdings for a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Holding Type, use \&quot;holdingType eq &#39;p&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Holding\&quot; domain to decorate onto              holdings. These must have the format {domain}/{scope}/{code}, for example \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <returns>Task of VersionedResourceListOfPortfolioHolding</returns>
        System.Threading.Tasks.Task<VersionedResourceListOfPortfolioHolding> GetHoldingsAsync (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, bool? byTaxlots = null);

        /// <summary>
        /// Get holdings
        /// </summary>
        /// <remarks>
        /// Calculate holdings for a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Holding Type, use \&quot;holdingType eq &#39;p&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Holding\&quot; domain to decorate onto              holdings. These must have the format {domain}/{scope}/{code}, for example \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfPortfolioHolding)</returns>
        System.Threading.Tasks.Task<ApiResponse<VersionedResourceListOfPortfolioHolding>> GetHoldingsAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, bool? byTaxlots = null);
        /// <summary>
        /// Get holdings adjustment
        /// </summary>
        /// <remarks>
        /// Get a holdings adjustment made to a transaction portfolio at a specific effective datetime. Note that a  holdings adjustment will only be returned if one exists for the specified effective datetime.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label of the holdings adjustment.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. (optional)</param>
        /// <returns>Task of HoldingsAdjustment</returns>
        System.Threading.Tasks.Task<HoldingsAdjustment> GetHoldingsAdjustmentAsync (string scope, string code, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = null);

        /// <summary>
        /// Get holdings adjustment
        /// </summary>
        /// <remarks>
        /// Get a holdings adjustment made to a transaction portfolio at a specific effective datetime. Note that a  holdings adjustment will only be returned if one exists for the specified effective datetime.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label of the holdings adjustment.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. (optional)</param>
        /// <returns>Task of ApiResponse (HoldingsAdjustment)</returns>
        System.Threading.Tasks.Task<ApiResponse<HoldingsAdjustment>> GetHoldingsAdjustmentAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = null);
        /// <summary>
        /// [EARLY ACCESS] Get portfolio cash statement
        /// </summary>
        /// <remarks>
        /// Get a cash statement for a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <returns>Task of ResourceListOfPortfolioCashFlow</returns>
        System.Threading.Tasks.Task<ResourceListOfPortfolioCashFlow> GetPortfolioCashStatementAsync (string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = null, string filter = null, string recipeIdScope = null, string recipeIdCode = null);

        /// <summary>
        /// [EARLY ACCESS] Get portfolio cash statement
        /// </summary>
        /// <remarks>
        /// Get a cash statement for a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfPortfolioCashFlow)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfPortfolioCashFlow>> GetPortfolioCashStatementAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = null, string filter = null, string recipeIdScope = null, string recipeIdCode = null);
        /// <summary>
        /// Get transactions
        /// </summary>
        /// <remarks>
        /// Retrieve all the transactions that occurred during a particular time interval.     If the portfolio is a derived transaction portfolio, the transactions returned are the  union set of all transactions of the parent (and any grandparents, etc.) as well as  those of the derived transaction portfolio itself.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.              There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve transactions. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression with which to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; or &#39;Transaction&#39; domain to decorate onto              transactions. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39; or              &#39;Transaction/strategy/quantsignal&#39;. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <returns>Task of VersionedResourceListOfTransaction</returns>
        System.Threading.Tasks.Task<VersionedResourceListOfTransaction> GetTransactionsAsync (string scope, string code, DateTimeOrCutLabel fromTransactionDate = null, DateTimeOrCutLabel toTransactionDate = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, string page = null, int? limit = null);

        /// <summary>
        /// Get transactions
        /// </summary>
        /// <remarks>
        /// Retrieve all the transactions that occurred during a particular time interval.     If the portfolio is a derived transaction portfolio, the transactions returned are the  union set of all transactions of the parent (and any grandparents, etc.) as well as  those of the derived transaction portfolio itself.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.              There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve transactions. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression with which to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; or &#39;Transaction&#39; domain to decorate onto              transactions. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39; or              &#39;Transaction/strategy/quantsignal&#39;. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfTransaction)</returns>
        System.Threading.Tasks.Task<ApiResponse<VersionedResourceListOfTransaction>> GetTransactionsAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel fromTransactionDate = null, DateTimeOrCutLabel toTransactionDate = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, string page = null, int? limit = null);
        /// <summary>
        /// List holdings adjustments
        /// </summary>
        /// <remarks>
        /// List the holdings adjustments made to the specified transaction portfolio over a specified interval of effective time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. (optional)</param>
        /// <returns>Task of ResourceListOfHoldingsAdjustmentHeader</returns>
        System.Threading.Tasks.Task<ResourceListOfHoldingsAdjustmentHeader> ListHoldingsAdjustmentsAsync (string scope, string code, DateTimeOrCutLabel fromEffectiveAt = null, DateTimeOrCutLabel toEffectiveAt = null, DateTimeOffset? asAt = null);

        /// <summary>
        /// List holdings adjustments
        /// </summary>
        /// <remarks>
        /// List the holdings adjustments made to the specified transaction portfolio over a specified interval of effective time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfHoldingsAdjustmentHeader)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfHoldingsAdjustmentHeader>> ListHoldingsAdjustmentsAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel fromEffectiveAt = null, DateTimeOrCutLabel toEffectiveAt = null, DateTimeOffset? asAt = null);
        /// <summary>
        /// [EARLY ACCESS] Resolve instrument
        /// </summary>
        /// <remarks>
        /// Try to resolve the instrument for transaction and holdings for a given instrument identifier and a specified    period of time. Also update the instrument identifiers with the given instrument identifiers collection.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="instrumentIdentifierType">The instrument identifier type.</param>
        /// <param name="instrumentIdentifierValue">The value for the given instrument identifier.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="requestBody">The dictionary with the instrument identifiers to be updated on the              transaction and holdings. (optional)</param>
        /// <returns>Task of UpsertPortfolioTransactionsResponse</returns>
        System.Threading.Tasks.Task<UpsertPortfolioTransactionsResponse> ResolveInstrumentAsync (string scope, string code, string instrumentIdentifierType, string instrumentIdentifierValue, DateTimeOrCutLabel fromEffectiveAt = null, Dictionary<string, string> requestBody = null);

        /// <summary>
        /// [EARLY ACCESS] Resolve instrument
        /// </summary>
        /// <remarks>
        /// Try to resolve the instrument for transaction and holdings for a given instrument identifier and a specified    period of time. Also update the instrument identifiers with the given instrument identifiers collection.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="instrumentIdentifierType">The instrument identifier type.</param>
        /// <param name="instrumentIdentifierValue">The value for the given instrument identifier.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="requestBody">The dictionary with the instrument identifiers to be updated on the              transaction and holdings. (optional)</param>
        /// <returns>Task of ApiResponse (UpsertPortfolioTransactionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpsertPortfolioTransactionsResponse>> ResolveInstrumentAsyncWithHttpInfo (string scope, string code, string instrumentIdentifierType, string instrumentIdentifierValue, DateTimeOrCutLabel fromEffectiveAt = null, Dictionary<string, string> requestBody = null);
        /// <summary>
        /// Set holdings
        /// </summary>
        /// <remarks>
        /// Set the holdings of the specified transaction portfolio to the provided targets. LUSID will automatically  construct adjustment transactions to ensure that the entire set of holdings for the transaction portfolio  are always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The complete set of target holdings for the transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>Task of AdjustHolding</returns>
        System.Threading.Tasks.Task<AdjustHolding> SetHoldingsAsync (string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = null);

        /// <summary>
        /// Set holdings
        /// </summary>
        /// <remarks>
        /// Set the holdings of the specified transaction portfolio to the provided targets. LUSID will automatically  construct adjustment transactions to ensure that the entire set of holdings for the transaction portfolio  are always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The complete set of target holdings for the transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>Task of ApiResponse (AdjustHolding)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdjustHolding>> SetHoldingsAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = null);
        /// <summary>
        /// Upsert portfolio details
        /// </summary>
        /// <remarks>
        /// Create or update certain details for a particular transaction portfolio. The details are updated if they already exist, and inserted if they do not.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="createPortfolioDetails">The details to create or update for the specified transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <returns>Task of PortfolioDetails</returns>
        System.Threading.Tasks.Task<PortfolioDetails> UpsertPortfolioDetailsAsync (string scope, string code, CreatePortfolioDetails createPortfolioDetails, DateTimeOrCutLabel effectiveAt = null);

        /// <summary>
        /// Upsert portfolio details
        /// </summary>
        /// <remarks>
        /// Create or update certain details for a particular transaction portfolio. The details are updated if they already exist, and inserted if they do not.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="createPortfolioDetails">The details to create or update for the specified transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioDetails)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioDetails>> UpsertPortfolioDetailsAsyncWithHttpInfo (string scope, string code, CreatePortfolioDetails createPortfolioDetails, DateTimeOrCutLabel effectiveAt = null);
        /// <summary>
        /// Upsert transaction properties
        /// </summary>
        /// <remarks>
        /// Create or update one or more transaction properties for a single transaction in the transaction portfolio.  Each property will be updated if it already exists and created if it does not.  Both transaction and portfolio must exist at the time when properties are created or updated.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update properties for.</param>
        /// <param name="requestBody">The properties and their associated values to create or update.</param>
        /// <returns>Task of UpsertTransactionPropertiesResponse</returns>
        System.Threading.Tasks.Task<UpsertTransactionPropertiesResponse> UpsertTransactionPropertiesAsync (string scope, string code, string transactionId, Dictionary<string, PerpetualProperty> requestBody);

        /// <summary>
        /// Upsert transaction properties
        /// </summary>
        /// <remarks>
        /// Create or update one or more transaction properties for a single transaction in the transaction portfolio.  Each property will be updated if it already exists and created if it does not.  Both transaction and portfolio must exist at the time when properties are created or updated.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update properties for.</param>
        /// <param name="requestBody">The properties and their associated values to create or update.</param>
        /// <returns>Task of ApiResponse (UpsertTransactionPropertiesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpsertTransactionPropertiesResponse>> UpsertTransactionPropertiesAsyncWithHttpInfo (string scope, string code, string transactionId, Dictionary<string, PerpetualProperty> requestBody);
        /// <summary>
        /// Upsert transactions
        /// </summary>
        /// <remarks>
        /// Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.  The maximum number of transactions that this method can upsert per request is 10,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionRequest">A list of transactions to be created or updated.</param>
        /// <returns>Task of UpsertPortfolioTransactionsResponse</returns>
        System.Threading.Tasks.Task<UpsertPortfolioTransactionsResponse> UpsertTransactionsAsync (string scope, string code, List<TransactionRequest> transactionRequest);

        /// <summary>
        /// Upsert transactions
        /// </summary>
        /// <remarks>
        /// Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.  The maximum number of transactions that this method can upsert per request is 10,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionRequest">A list of transactions to be created or updated.</param>
        /// <returns>Task of ApiResponse (UpsertPortfolioTransactionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpsertPortfolioTransactionsResponse>> UpsertTransactionsAsyncWithHttpInfo (string scope, string code, List<TransactionRequest> transactionRequest);
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
        /// </summary>
        /// <returns></returns>
        public TransactionPortfoliosApi()
        {
            this.Configuration = Lusid.Sdk.Client.Configuration.Default;

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
        /// Adjust holdings Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The selected set of holdings to adjust to the provided targets for the              transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>AdjustHolding</returns>
        public AdjustHolding AdjustHoldings (string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = null)
        {
             ApiResponse<AdjustHolding> localVarResponse = AdjustHoldingsWithHttpInfo(scope, code, effectiveAt, adjustHoldingRequest, reconciliationMethods);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Adjust holdings Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The selected set of holdings to adjust to the provided targets for the              transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>ApiResponse of AdjustHolding</returns>
        public ApiResponse< AdjustHolding > AdjustHoldingsWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = null)
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
            // verify the required parameter 'adjustHoldingRequest' is set
            if (adjustHoldingRequest == null)
                throw new ApiException(400, "Missing required parameter 'adjustHoldingRequest' when calling TransactionPortfoliosApi->AdjustHoldings");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/holdings";
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
            if (reconciliationMethods != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "reconciliationMethods", reconciliationMethods)); // query parameter
            if (adjustHoldingRequest != null && adjustHoldingRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(adjustHoldingRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adjustHoldingRequest; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AdjustHolding) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdjustHolding)));
        }

        /// <summary>
        /// Adjust holdings Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The selected set of holdings to adjust to the provided targets for the              transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>Task of AdjustHolding</returns>
        public async System.Threading.Tasks.Task<AdjustHolding> AdjustHoldingsAsync (string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = null)
        {
             ApiResponse<AdjustHolding> localVarResponse = await AdjustHoldingsAsyncWithHttpInfo(scope, code, effectiveAt, adjustHoldingRequest, reconciliationMethods);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Adjust holdings Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The selected set of holdings to adjust to the provided targets for the              transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>Task of ApiResponse (AdjustHolding)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdjustHolding>> AdjustHoldingsAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = null)
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
            // verify the required parameter 'adjustHoldingRequest' is set
            if (adjustHoldingRequest == null)
                throw new ApiException(400, "Missing required parameter 'adjustHoldingRequest' when calling TransactionPortfoliosApi->AdjustHoldings");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/holdings";
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
            if (reconciliationMethods != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "reconciliationMethods", reconciliationMethods)); // query parameter
            if (adjustHoldingRequest != null && adjustHoldingRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(adjustHoldingRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adjustHoldingRequest; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AdjustHolding) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdjustHolding)));
        }

        /// <summary>
        /// Build transactions Builds and returns all transactions that affect the holdings of a portfolio over a given interval of  effective time into a set of output transactions. This includes transactions automatically generated by  LUSID such as holding adjustments.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or              \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <returns>VersionedResourceListOfOutputTransaction</returns>
        public VersionedResourceListOfOutputTransaction BuildTransactions (string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, int? limit = null, string page = null)
        {
             ApiResponse<VersionedResourceListOfOutputTransaction> localVarResponse = BuildTransactionsWithHttpInfo(scope, code, transactionQueryParameters, asAt, filter, propertyKeys, limit, page);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Build transactions Builds and returns all transactions that affect the holdings of a portfolio over a given interval of  effective time into a set of output transactions. This includes transactions automatically generated by  LUSID such as holding adjustments.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or              \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfOutputTransaction</returns>
        public ApiResponse< VersionedResourceListOfOutputTransaction > BuildTransactionsWithHttpInfo (string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, int? limit = null, string page = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->BuildTransactions");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->BuildTransactions");
            // verify the required parameter 'transactionQueryParameters' is set
            if (transactionQueryParameters == null)
                throw new ApiException(400, "Missing required parameter 'transactionQueryParameters' when calling TransactionPortfoliosApi->BuildTransactions");

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
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (propertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "propertyKeys", propertyKeys)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (transactionQueryParameters != null && transactionQueryParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(transactionQueryParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transactionQueryParameters; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (VersionedResourceListOfOutputTransaction) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VersionedResourceListOfOutputTransaction)));
        }

        /// <summary>
        /// Build transactions Builds and returns all transactions that affect the holdings of a portfolio over a given interval of  effective time into a set of output transactions. This includes transactions automatically generated by  LUSID such as holding adjustments.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or              \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <returns>Task of VersionedResourceListOfOutputTransaction</returns>
        public async System.Threading.Tasks.Task<VersionedResourceListOfOutputTransaction> BuildTransactionsAsync (string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, int? limit = null, string page = null)
        {
             ApiResponse<VersionedResourceListOfOutputTransaction> localVarResponse = await BuildTransactionsAsyncWithHttpInfo(scope, code, transactionQueryParameters, asAt, filter, propertyKeys, limit, page);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Build transactions Builds and returns all transactions that affect the holdings of a portfolio over a given interval of  effective time into a set of output transactions. This includes transactions automatically generated by  LUSID such as holding adjustments.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or              \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfOutputTransaction)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VersionedResourceListOfOutputTransaction>> BuildTransactionsAsyncWithHttpInfo (string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, int? limit = null, string page = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->BuildTransactions");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->BuildTransactions");
            // verify the required parameter 'transactionQueryParameters' is set
            if (transactionQueryParameters == null)
                throw new ApiException(400, "Missing required parameter 'transactionQueryParameters' when calling TransactionPortfoliosApi->BuildTransactions");

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
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (propertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "propertyKeys", propertyKeys)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (transactionQueryParameters != null && transactionQueryParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(transactionQueryParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transactionQueryParameters; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (VersionedResourceListOfOutputTransaction) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VersionedResourceListOfOutputTransaction)));
        }

        /// <summary>
        /// Cancel adjust holdings Cancel all previous holding adjustments made on the specified transaction portfolio for a specified effective  datetime. This should be used to undo holding adjustments made via set holdings or adjust holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holding adjustments should be undone.</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse CancelAdjustHoldings (string scope, string code, DateTimeOrCutLabel effectiveAt)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = CancelAdjustHoldingsWithHttpInfo(scope, code, effectiveAt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancel adjust holdings Cancel all previous holding adjustments made on the specified transaction portfolio for a specified effective  datetime. This should be used to undo holding adjustments made via set holdings or adjust holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holding adjustments should be undone.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public ApiResponse< DeletedEntityResponse > CancelAdjustHoldingsWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt)
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
            if (effectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "effectiveAt", effectiveAt)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

        /// <summary>
        /// Cancel adjust holdings Cancel all previous holding adjustments made on the specified transaction portfolio for a specified effective  datetime. This should be used to undo holding adjustments made via set holdings or adjust holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holding adjustments should be undone.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> CancelAdjustHoldingsAsync (string scope, string code, DateTimeOrCutLabel effectiveAt)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = await CancelAdjustHoldingsAsyncWithHttpInfo(scope, code, effectiveAt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancel adjust holdings Cancel all previous holding adjustments made on the specified transaction portfolio for a specified effective  datetime. This should be used to undo holding adjustments made via set holdings or adjust holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holding adjustments should be undone.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> CancelAdjustHoldingsAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt)
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
            if (effectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "effectiveAt", effectiveAt)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

        /// <summary>
        /// Cancel transactions Cancel one or more transactions from the transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionIds">The IDs of the transactions to cancel.</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse CancelTransactions (string scope, string code, List<string> transactionIds)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = CancelTransactionsWithHttpInfo(scope, code, transactionIds);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancel transactions Cancel one or more transactions from the transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionIds">The IDs of the transactions to cancel.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public ApiResponse< DeletedEntityResponse > CancelTransactionsWithHttpInfo (string scope, string code, List<string> transactionIds)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->CancelTransactions");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->CancelTransactions");
            // verify the required parameter 'transactionIds' is set
            if (transactionIds == null)
                throw new ApiException(400, "Missing required parameter 'transactionIds' when calling TransactionPortfoliosApi->CancelTransactions");

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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.11.3347";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CancelTransactions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeletedEntityResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

        /// <summary>
        /// Cancel transactions Cancel one or more transactions from the transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionIds">The IDs of the transactions to cancel.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> CancelTransactionsAsync (string scope, string code, List<string> transactionIds)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = await CancelTransactionsAsyncWithHttpInfo(scope, code, transactionIds);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancel transactions Cancel one or more transactions from the transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionIds">The IDs of the transactions to cancel.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> CancelTransactionsAsyncWithHttpInfo (string scope, string code, List<string> transactionIds)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->CancelTransactions");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->CancelTransactions");
            // verify the required parameter 'transactionIds' is set
            if (transactionIds == null)
                throw new ApiException(400, "Missing required parameter 'transactionIds' when calling TransactionPortfoliosApi->CancelTransactions");

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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.11.3347";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CancelTransactions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeletedEntityResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

        /// <summary>
        /// Create portfolio Create a transaction portfolio in a particular scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope in which to create the transaction portfolio.</param>
        /// <param name="createTransactionPortfolioRequest">The definition of the transaction portfolio.</param>
        /// <returns>Portfolio</returns>
        public Portfolio CreatePortfolio (string scope, CreateTransactionPortfolioRequest createTransactionPortfolioRequest)
        {
             ApiResponse<Portfolio> localVarResponse = CreatePortfolioWithHttpInfo(scope, createTransactionPortfolioRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create portfolio Create a transaction portfolio in a particular scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope in which to create the transaction portfolio.</param>
        /// <param name="createTransactionPortfolioRequest">The definition of the transaction portfolio.</param>
        /// <returns>ApiResponse of Portfolio</returns>
        public ApiResponse< Portfolio > CreatePortfolioWithHttpInfo (string scope, CreateTransactionPortfolioRequest createTransactionPortfolioRequest)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->CreatePortfolio");
            // verify the required parameter 'createTransactionPortfolioRequest' is set
            if (createTransactionPortfolioRequest == null)
                throw new ApiException(400, "Missing required parameter 'createTransactionPortfolioRequest' when calling TransactionPortfoliosApi->CreatePortfolio");

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
            if (createTransactionPortfolioRequest != null && createTransactionPortfolioRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(createTransactionPortfolioRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createTransactionPortfolioRequest; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Portfolio) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Portfolio)));
        }

        /// <summary>
        /// Create portfolio Create a transaction portfolio in a particular scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope in which to create the transaction portfolio.</param>
        /// <param name="createTransactionPortfolioRequest">The definition of the transaction portfolio.</param>
        /// <returns>Task of Portfolio</returns>
        public async System.Threading.Tasks.Task<Portfolio> CreatePortfolioAsync (string scope, CreateTransactionPortfolioRequest createTransactionPortfolioRequest)
        {
             ApiResponse<Portfolio> localVarResponse = await CreatePortfolioAsyncWithHttpInfo(scope, createTransactionPortfolioRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create portfolio Create a transaction portfolio in a particular scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope in which to create the transaction portfolio.</param>
        /// <param name="createTransactionPortfolioRequest">The definition of the transaction portfolio.</param>
        /// <returns>Task of ApiResponse (Portfolio)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Portfolio>> CreatePortfolioAsyncWithHttpInfo (string scope, CreateTransactionPortfolioRequest createTransactionPortfolioRequest)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->CreatePortfolio");
            // verify the required parameter 'createTransactionPortfolioRequest' is set
            if (createTransactionPortfolioRequest == null)
                throw new ApiException(400, "Missing required parameter 'createTransactionPortfolioRequest' when calling TransactionPortfoliosApi->CreatePortfolio");

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
            if (createTransactionPortfolioRequest != null && createTransactionPortfolioRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(createTransactionPortfolioRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createTransactionPortfolioRequest; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Portfolio) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Portfolio)));
        }

        /// <summary>
        /// Delete properties from transaction Delete one or more properties from a single transaction in a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction from which to delete properties.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete.              These must be from the \&quot;Transaction\&quot; domain and have the format {domain}/{scope}/{code}, for example              \&quot;Transaction/strategy/quantsignal\&quot;.</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeletePropertiesFromTransaction (string scope, string code, string transactionId, List<string> propertyKeys)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = DeletePropertiesFromTransactionWithHttpInfo(scope, code, transactionId, propertyKeys);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete properties from transaction Delete one or more properties from a single transaction in a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction from which to delete properties.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete.              These must be from the \&quot;Transaction\&quot; domain and have the format {domain}/{scope}/{code}, for example              \&quot;Transaction/strategy/quantsignal\&quot;.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public ApiResponse< DeletedEntityResponse > DeletePropertiesFromTransactionWithHttpInfo (string scope, string code, string transactionId, List<string> propertyKeys)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->DeletePropertiesFromTransaction");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->DeletePropertiesFromTransaction");
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling TransactionPortfoliosApi->DeletePropertiesFromTransaction");
            // verify the required parameter 'propertyKeys' is set
            if (propertyKeys == null)
                throw new ApiException(400, "Missing required parameter 'propertyKeys' when calling TransactionPortfoliosApi->DeletePropertiesFromTransaction");

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
            if (propertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "propertyKeys", propertyKeys)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.11.3347";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeletePropertiesFromTransaction", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeletedEntityResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

        /// <summary>
        /// Delete properties from transaction Delete one or more properties from a single transaction in a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction from which to delete properties.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete.              These must be from the \&quot;Transaction\&quot; domain and have the format {domain}/{scope}/{code}, for example              \&quot;Transaction/strategy/quantsignal\&quot;.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeletePropertiesFromTransactionAsync (string scope, string code, string transactionId, List<string> propertyKeys)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = await DeletePropertiesFromTransactionAsyncWithHttpInfo(scope, code, transactionId, propertyKeys);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete properties from transaction Delete one or more properties from a single transaction in a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction from which to delete properties.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete.              These must be from the \&quot;Transaction\&quot; domain and have the format {domain}/{scope}/{code}, for example              \&quot;Transaction/strategy/quantsignal\&quot;.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeletePropertiesFromTransactionAsyncWithHttpInfo (string scope, string code, string transactionId, List<string> propertyKeys)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->DeletePropertiesFromTransaction");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->DeletePropertiesFromTransaction");
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling TransactionPortfoliosApi->DeletePropertiesFromTransaction");
            // verify the required parameter 'propertyKeys' is set
            if (propertyKeys == null)
                throw new ApiException(400, "Missing required parameter 'propertyKeys' when calling TransactionPortfoliosApi->DeletePropertiesFromTransaction");

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
            if (propertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "propertyKeys", propertyKeys)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.11.3347";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeletePropertiesFromTransaction", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeletedEntityResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

        /// <summary>
        /// Get details Get certain details associated with a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the              scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to returning the latest version of the details if not specified. (optional)</param>
        /// <returns>PortfolioDetails</returns>
        public PortfolioDetails GetDetails (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)
        {
             ApiResponse<PortfolioDetails> localVarResponse = GetDetailsWithHttpInfo(scope, code, effectiveAt, asAt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get details Get certain details associated with a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the              scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to returning the latest version of the details if not specified. (optional)</param>
        /// <returns>ApiResponse of PortfolioDetails</returns>
        public ApiResponse< PortfolioDetails > GetDetailsWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)
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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PortfolioDetails) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortfolioDetails)));
        }

        /// <summary>
        /// Get details Get certain details associated with a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the              scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to returning the latest version of the details if not specified. (optional)</param>
        /// <returns>Task of PortfolioDetails</returns>
        public async System.Threading.Tasks.Task<PortfolioDetails> GetDetailsAsync (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)
        {
             ApiResponse<PortfolioDetails> localVarResponse = await GetDetailsAsyncWithHttpInfo(scope, code, effectiveAt, asAt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get details Get certain details associated with a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the              scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to returning the latest version of the details if not specified. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioDetails)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PortfolioDetails>> GetDetailsAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)
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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PortfolioDetails) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortfolioDetails)));
        }

        /// <summary>
        /// Get holdings Calculate holdings for a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Holding Type, use \&quot;holdingType eq &#39;p&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Holding\&quot; domain to decorate onto              holdings. These must have the format {domain}/{scope}/{code}, for example \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <returns>VersionedResourceListOfPortfolioHolding</returns>
        public VersionedResourceListOfPortfolioHolding GetHoldings (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, bool? byTaxlots = null)
        {
             ApiResponse<VersionedResourceListOfPortfolioHolding> localVarResponse = GetHoldingsWithHttpInfo(scope, code, effectiveAt, asAt, filter, propertyKeys, byTaxlots);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get holdings Calculate holdings for a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Holding Type, use \&quot;holdingType eq &#39;p&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Holding\&quot; domain to decorate onto              holdings. These must have the format {domain}/{scope}/{code}, for example \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfPortfolioHolding</returns>
        public ApiResponse< VersionedResourceListOfPortfolioHolding > GetHoldingsWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, bool? byTaxlots = null)
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
            if (effectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "effectiveAt", effectiveAt)); // query parameter
            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (propertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "propertyKeys", propertyKeys)); // query parameter
            if (byTaxlots != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "byTaxlots", byTaxlots)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (VersionedResourceListOfPortfolioHolding) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VersionedResourceListOfPortfolioHolding)));
        }

        /// <summary>
        /// Get holdings Calculate holdings for a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Holding Type, use \&quot;holdingType eq &#39;p&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Holding\&quot; domain to decorate onto              holdings. These must have the format {domain}/{scope}/{code}, for example \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <returns>Task of VersionedResourceListOfPortfolioHolding</returns>
        public async System.Threading.Tasks.Task<VersionedResourceListOfPortfolioHolding> GetHoldingsAsync (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, bool? byTaxlots = null)
        {
             ApiResponse<VersionedResourceListOfPortfolioHolding> localVarResponse = await GetHoldingsAsyncWithHttpInfo(scope, code, effectiveAt, asAt, filter, propertyKeys, byTaxlots);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get holdings Calculate holdings for a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Holding Type, use \&quot;holdingType eq &#39;p&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Holding\&quot; domain to decorate onto              holdings. These must have the format {domain}/{scope}/{code}, for example \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfPortfolioHolding)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VersionedResourceListOfPortfolioHolding>> GetHoldingsAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, bool? byTaxlots = null)
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
            if (effectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "effectiveAt", effectiveAt)); // query parameter
            if (asAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "asAt", asAt)); // query parameter
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (propertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "propertyKeys", propertyKeys)); // query parameter
            if (byTaxlots != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "byTaxlots", byTaxlots)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (VersionedResourceListOfPortfolioHolding) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VersionedResourceListOfPortfolioHolding)));
        }

        /// <summary>
        /// Get holdings adjustment Get a holdings adjustment made to a transaction portfolio at a specific effective datetime. Note that a  holdings adjustment will only be returned if one exists for the specified effective datetime.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label of the holdings adjustment.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. (optional)</param>
        /// <returns>HoldingsAdjustment</returns>
        public HoldingsAdjustment GetHoldingsAdjustment (string scope, string code, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = null)
        {
             ApiResponse<HoldingsAdjustment> localVarResponse = GetHoldingsAdjustmentWithHttpInfo(scope, code, effectiveAt, asAt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get holdings adjustment Get a holdings adjustment made to a transaction portfolio at a specific effective datetime. Note that a  holdings adjustment will only be returned if one exists for the specified effective datetime.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label of the holdings adjustment.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. (optional)</param>
        /// <returns>ApiResponse of HoldingsAdjustment</returns>
        public ApiResponse< HoldingsAdjustment > GetHoldingsAdjustmentWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = null)
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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (HoldingsAdjustment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(HoldingsAdjustment)));
        }

        /// <summary>
        /// Get holdings adjustment Get a holdings adjustment made to a transaction portfolio at a specific effective datetime. Note that a  holdings adjustment will only be returned if one exists for the specified effective datetime.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label of the holdings adjustment.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. (optional)</param>
        /// <returns>Task of HoldingsAdjustment</returns>
        public async System.Threading.Tasks.Task<HoldingsAdjustment> GetHoldingsAdjustmentAsync (string scope, string code, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = null)
        {
             ApiResponse<HoldingsAdjustment> localVarResponse = await GetHoldingsAdjustmentAsyncWithHttpInfo(scope, code, effectiveAt, asAt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get holdings adjustment Get a holdings adjustment made to a transaction portfolio at a specific effective datetime. Note that a  holdings adjustment will only be returned if one exists for the specified effective datetime.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label of the holdings adjustment.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. (optional)</param>
        /// <returns>Task of ApiResponse (HoldingsAdjustment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HoldingsAdjustment>> GetHoldingsAdjustmentAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = null)
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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (HoldingsAdjustment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(HoldingsAdjustment)));
        }

        /// <summary>
        /// [EARLY ACCESS] Get portfolio cash statement Get a cash statement for a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <returns>ResourceListOfPortfolioCashFlow</returns>
        public ResourceListOfPortfolioCashFlow GetPortfolioCashStatement (string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = null, string filter = null, string recipeIdScope = null, string recipeIdCode = null)
        {
             ApiResponse<ResourceListOfPortfolioCashFlow> localVarResponse = GetPortfolioCashStatementWithHttpInfo(scope, code, fromEffectiveAt, toEffectiveAt, asAt, filter, recipeIdScope, recipeIdCode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Get portfolio cash statement Get a cash statement for a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPortfolioCashFlow</returns>
        public ApiResponse< ResourceListOfPortfolioCashFlow > GetPortfolioCashStatementWithHttpInfo (string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = null, string filter = null, string recipeIdScope = null, string recipeIdCode = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetPortfolioCashStatement");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetPortfolioCashStatement");
            // verify the required parameter 'fromEffectiveAt' is set
            if (fromEffectiveAt == null)
                throw new ApiException(400, "Missing required parameter 'fromEffectiveAt' when calling TransactionPortfoliosApi->GetPortfolioCashStatement");
            // verify the required parameter 'toEffectiveAt' is set
            if (toEffectiveAt == null)
                throw new ApiException(400, "Missing required parameter 'toEffectiveAt' when calling TransactionPortfoliosApi->GetPortfolioCashStatement");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/cashstatement";
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
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (recipeIdScope != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "recipeIdScope", recipeIdScope)); // query parameter
            if (recipeIdCode != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "recipeIdCode", recipeIdCode)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.11.3347";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPortfolioCashStatement", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResourceListOfPortfolioCashFlow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ResourceListOfPortfolioCashFlow) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfPortfolioCashFlow)));
        }

        /// <summary>
        /// [EARLY ACCESS] Get portfolio cash statement Get a cash statement for a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <returns>Task of ResourceListOfPortfolioCashFlow</returns>
        public async System.Threading.Tasks.Task<ResourceListOfPortfolioCashFlow> GetPortfolioCashStatementAsync (string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = null, string filter = null, string recipeIdScope = null, string recipeIdCode = null)
        {
             ApiResponse<ResourceListOfPortfolioCashFlow> localVarResponse = await GetPortfolioCashStatementAsyncWithHttpInfo(scope, code, fromEffectiveAt, toEffectiveAt, asAt, filter, recipeIdScope, recipeIdCode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Get portfolio cash statement Get a cash statement for a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfPortfolioCashFlow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResourceListOfPortfolioCashFlow>> GetPortfolioCashStatementAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = null, string filter = null, string recipeIdScope = null, string recipeIdCode = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetPortfolioCashStatement");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetPortfolioCashStatement");
            // verify the required parameter 'fromEffectiveAt' is set
            if (fromEffectiveAt == null)
                throw new ApiException(400, "Missing required parameter 'fromEffectiveAt' when calling TransactionPortfoliosApi->GetPortfolioCashStatement");
            // verify the required parameter 'toEffectiveAt' is set
            if (toEffectiveAt == null)
                throw new ApiException(400, "Missing required parameter 'toEffectiveAt' when calling TransactionPortfoliosApi->GetPortfolioCashStatement");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/cashstatement";
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
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (recipeIdScope != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "recipeIdScope", recipeIdScope)); // query parameter
            if (recipeIdCode != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "recipeIdCode", recipeIdCode)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.11.3347";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPortfolioCashStatement", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResourceListOfPortfolioCashFlow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ResourceListOfPortfolioCashFlow) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfPortfolioCashFlow)));
        }

        /// <summary>
        /// Get transactions Retrieve all the transactions that occurred during a particular time interval.     If the portfolio is a derived transaction portfolio, the transactions returned are the  union set of all transactions of the parent (and any grandparents, etc.) as well as  those of the derived transaction portfolio itself.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.              There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve transactions. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression with which to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; or &#39;Transaction&#39; domain to decorate onto              transactions. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39; or              &#39;Transaction/strategy/quantsignal&#39;. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <returns>VersionedResourceListOfTransaction</returns>
        public VersionedResourceListOfTransaction GetTransactions (string scope, string code, DateTimeOrCutLabel fromTransactionDate = null, DateTimeOrCutLabel toTransactionDate = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, string page = null, int? limit = null)
        {
             ApiResponse<VersionedResourceListOfTransaction> localVarResponse = GetTransactionsWithHttpInfo(scope, code, fromTransactionDate, toTransactionDate, asAt, filter, propertyKeys, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get transactions Retrieve all the transactions that occurred during a particular time interval.     If the portfolio is a derived transaction portfolio, the transactions returned are the  union set of all transactions of the parent (and any grandparents, etc.) as well as  those of the derived transaction portfolio itself.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.              There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve transactions. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression with which to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; or &#39;Transaction&#39; domain to decorate onto              transactions. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39; or              &#39;Transaction/strategy/quantsignal&#39;. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfTransaction</returns>
        public ApiResponse< VersionedResourceListOfTransaction > GetTransactionsWithHttpInfo (string scope, string code, DateTimeOrCutLabel fromTransactionDate = null, DateTimeOrCutLabel toTransactionDate = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, string page = null, int? limit = null)
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
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (propertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "propertyKeys", propertyKeys)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (VersionedResourceListOfTransaction) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VersionedResourceListOfTransaction)));
        }

        /// <summary>
        /// Get transactions Retrieve all the transactions that occurred during a particular time interval.     If the portfolio is a derived transaction portfolio, the transactions returned are the  union set of all transactions of the parent (and any grandparents, etc.) as well as  those of the derived transaction portfolio itself.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.              There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve transactions. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression with which to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; or &#39;Transaction&#39; domain to decorate onto              transactions. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39; or              &#39;Transaction/strategy/quantsignal&#39;. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <returns>Task of VersionedResourceListOfTransaction</returns>
        public async System.Threading.Tasks.Task<VersionedResourceListOfTransaction> GetTransactionsAsync (string scope, string code, DateTimeOrCutLabel fromTransactionDate = null, DateTimeOrCutLabel toTransactionDate = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, string page = null, int? limit = null)
        {
             ApiResponse<VersionedResourceListOfTransaction> localVarResponse = await GetTransactionsAsyncWithHttpInfo(scope, code, fromTransactionDate, toTransactionDate, asAt, filter, propertyKeys, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get transactions Retrieve all the transactions that occurred during a particular time interval.     If the portfolio is a derived transaction portfolio, the transactions returned are the  union set of all transactions of the parent (and any grandparents, etc.) as well as  those of the derived transaction portfolio itself.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.              There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve transactions. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression with which to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; or &#39;Transaction&#39; domain to decorate onto              transactions. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39; or              &#39;Transaction/strategy/quantsignal&#39;. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfTransaction)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VersionedResourceListOfTransaction>> GetTransactionsAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel fromTransactionDate = null, DateTimeOrCutLabel toTransactionDate = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, string page = null, int? limit = null)
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
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (propertyKeys != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "propertyKeys", propertyKeys)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (VersionedResourceListOfTransaction) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VersionedResourceListOfTransaction)));
        }

        /// <summary>
        /// List holdings adjustments List the holdings adjustments made to the specified transaction portfolio over a specified interval of effective time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. (optional)</param>
        /// <returns>ResourceListOfHoldingsAdjustmentHeader</returns>
        public ResourceListOfHoldingsAdjustmentHeader ListHoldingsAdjustments (string scope, string code, DateTimeOrCutLabel fromEffectiveAt = null, DateTimeOrCutLabel toEffectiveAt = null, DateTimeOffset? asAt = null)
        {
             ApiResponse<ResourceListOfHoldingsAdjustmentHeader> localVarResponse = ListHoldingsAdjustmentsWithHttpInfo(scope, code, fromEffectiveAt, toEffectiveAt, asAt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List holdings adjustments List the holdings adjustments made to the specified transaction portfolio over a specified interval of effective time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfHoldingsAdjustmentHeader</returns>
        public ApiResponse< ResourceListOfHoldingsAdjustmentHeader > ListHoldingsAdjustmentsWithHttpInfo (string scope, string code, DateTimeOrCutLabel fromEffectiveAt = null, DateTimeOrCutLabel toEffectiveAt = null, DateTimeOffset? asAt = null)
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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ResourceListOfHoldingsAdjustmentHeader) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfHoldingsAdjustmentHeader)));
        }

        /// <summary>
        /// List holdings adjustments List the holdings adjustments made to the specified transaction portfolio over a specified interval of effective time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. (optional)</param>
        /// <returns>Task of ResourceListOfHoldingsAdjustmentHeader</returns>
        public async System.Threading.Tasks.Task<ResourceListOfHoldingsAdjustmentHeader> ListHoldingsAdjustmentsAsync (string scope, string code, DateTimeOrCutLabel fromEffectiveAt = null, DateTimeOrCutLabel toEffectiveAt = null, DateTimeOffset? asAt = null)
        {
             ApiResponse<ResourceListOfHoldingsAdjustmentHeader> localVarResponse = await ListHoldingsAdjustmentsAsyncWithHttpInfo(scope, code, fromEffectiveAt, toEffectiveAt, asAt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List holdings adjustments List the holdings adjustments made to the specified transaction portfolio over a specified interval of effective time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfHoldingsAdjustmentHeader)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResourceListOfHoldingsAdjustmentHeader>> ListHoldingsAdjustmentsAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel fromEffectiveAt = null, DateTimeOrCutLabel toEffectiveAt = null, DateTimeOffset? asAt = null)
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

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ResourceListOfHoldingsAdjustmentHeader) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfHoldingsAdjustmentHeader)));
        }

        /// <summary>
        /// [EARLY ACCESS] Resolve instrument Try to resolve the instrument for transaction and holdings for a given instrument identifier and a specified    period of time. Also update the instrument identifiers with the given instrument identifiers collection.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="instrumentIdentifierType">The instrument identifier type.</param>
        /// <param name="instrumentIdentifierValue">The value for the given instrument identifier.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="requestBody">The dictionary with the instrument identifiers to be updated on the              transaction and holdings. (optional)</param>
        /// <returns>UpsertPortfolioTransactionsResponse</returns>
        public UpsertPortfolioTransactionsResponse ResolveInstrument (string scope, string code, string instrumentIdentifierType, string instrumentIdentifierValue, DateTimeOrCutLabel fromEffectiveAt = null, Dictionary<string, string> requestBody = null)
        {
             ApiResponse<UpsertPortfolioTransactionsResponse> localVarResponse = ResolveInstrumentWithHttpInfo(scope, code, instrumentIdentifierType, instrumentIdentifierValue, fromEffectiveAt, requestBody);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Resolve instrument Try to resolve the instrument for transaction and holdings for a given instrument identifier and a specified    period of time. Also update the instrument identifiers with the given instrument identifiers collection.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="instrumentIdentifierType">The instrument identifier type.</param>
        /// <param name="instrumentIdentifierValue">The value for the given instrument identifier.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="requestBody">The dictionary with the instrument identifiers to be updated on the              transaction and holdings. (optional)</param>
        /// <returns>ApiResponse of UpsertPortfolioTransactionsResponse</returns>
        public ApiResponse< UpsertPortfolioTransactionsResponse > ResolveInstrumentWithHttpInfo (string scope, string code, string instrumentIdentifierType, string instrumentIdentifierValue, DateTimeOrCutLabel fromEffectiveAt = null, Dictionary<string, string> requestBody = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->ResolveInstrument");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->ResolveInstrument");
            // verify the required parameter 'instrumentIdentifierType' is set
            if (instrumentIdentifierType == null)
                throw new ApiException(400, "Missing required parameter 'instrumentIdentifierType' when calling TransactionPortfoliosApi->ResolveInstrument");
            // verify the required parameter 'instrumentIdentifierValue' is set
            if (instrumentIdentifierValue == null)
                throw new ApiException(400, "Missing required parameter 'instrumentIdentifierValue' when calling TransactionPortfoliosApi->ResolveInstrument");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/$resolve";
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
            if (instrumentIdentifierType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "instrumentIdentifierType", instrumentIdentifierType)); // query parameter
            if (instrumentIdentifierValue != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "instrumentIdentifierValue", instrumentIdentifierValue)); // query parameter
            if (fromEffectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "fromEffectiveAt", fromEffectiveAt)); // query parameter
            if (requestBody != null && requestBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(requestBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = requestBody; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.11.3347";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ResolveInstrument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UpsertPortfolioTransactionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (UpsertPortfolioTransactionsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpsertPortfolioTransactionsResponse)));
        }

        /// <summary>
        /// [EARLY ACCESS] Resolve instrument Try to resolve the instrument for transaction and holdings for a given instrument identifier and a specified    period of time. Also update the instrument identifiers with the given instrument identifiers collection.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="instrumentIdentifierType">The instrument identifier type.</param>
        /// <param name="instrumentIdentifierValue">The value for the given instrument identifier.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="requestBody">The dictionary with the instrument identifiers to be updated on the              transaction and holdings. (optional)</param>
        /// <returns>Task of UpsertPortfolioTransactionsResponse</returns>
        public async System.Threading.Tasks.Task<UpsertPortfolioTransactionsResponse> ResolveInstrumentAsync (string scope, string code, string instrumentIdentifierType, string instrumentIdentifierValue, DateTimeOrCutLabel fromEffectiveAt = null, Dictionary<string, string> requestBody = null)
        {
             ApiResponse<UpsertPortfolioTransactionsResponse> localVarResponse = await ResolveInstrumentAsyncWithHttpInfo(scope, code, instrumentIdentifierType, instrumentIdentifierValue, fromEffectiveAt, requestBody);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Resolve instrument Try to resolve the instrument for transaction and holdings for a given instrument identifier and a specified    period of time. Also update the instrument identifiers with the given instrument identifiers collection.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="instrumentIdentifierType">The instrument identifier type.</param>
        /// <param name="instrumentIdentifierValue">The value for the given instrument identifier.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="requestBody">The dictionary with the instrument identifiers to be updated on the              transaction and holdings. (optional)</param>
        /// <returns>Task of ApiResponse (UpsertPortfolioTransactionsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UpsertPortfolioTransactionsResponse>> ResolveInstrumentAsyncWithHttpInfo (string scope, string code, string instrumentIdentifierType, string instrumentIdentifierValue, DateTimeOrCutLabel fromEffectiveAt = null, Dictionary<string, string> requestBody = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->ResolveInstrument");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->ResolveInstrument");
            // verify the required parameter 'instrumentIdentifierType' is set
            if (instrumentIdentifierType == null)
                throw new ApiException(400, "Missing required parameter 'instrumentIdentifierType' when calling TransactionPortfoliosApi->ResolveInstrument");
            // verify the required parameter 'instrumentIdentifierValue' is set
            if (instrumentIdentifierValue == null)
                throw new ApiException(400, "Missing required parameter 'instrumentIdentifierValue' when calling TransactionPortfoliosApi->ResolveInstrument");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/$resolve";
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
            if (instrumentIdentifierType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "instrumentIdentifierType", instrumentIdentifierType)); // query parameter
            if (instrumentIdentifierValue != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "instrumentIdentifierValue", instrumentIdentifierValue)); // query parameter
            if (fromEffectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "fromEffectiveAt", fromEffectiveAt)); // query parameter
            if (requestBody != null && requestBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(requestBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = requestBody; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.11.3347";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ResolveInstrument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UpsertPortfolioTransactionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (UpsertPortfolioTransactionsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpsertPortfolioTransactionsResponse)));
        }

        /// <summary>
        /// Set holdings Set the holdings of the specified transaction portfolio to the provided targets. LUSID will automatically  construct adjustment transactions to ensure that the entire set of holdings for the transaction portfolio  are always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The complete set of target holdings for the transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>AdjustHolding</returns>
        public AdjustHolding SetHoldings (string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = null)
        {
             ApiResponse<AdjustHolding> localVarResponse = SetHoldingsWithHttpInfo(scope, code, effectiveAt, adjustHoldingRequest, reconciliationMethods);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Set holdings Set the holdings of the specified transaction portfolio to the provided targets. LUSID will automatically  construct adjustment transactions to ensure that the entire set of holdings for the transaction portfolio  are always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The complete set of target holdings for the transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>ApiResponse of AdjustHolding</returns>
        public ApiResponse< AdjustHolding > SetHoldingsWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = null)
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
            // verify the required parameter 'adjustHoldingRequest' is set
            if (adjustHoldingRequest == null)
                throw new ApiException(400, "Missing required parameter 'adjustHoldingRequest' when calling TransactionPortfoliosApi->SetHoldings");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/holdings";
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
            if (reconciliationMethods != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "reconciliationMethods", reconciliationMethods)); // query parameter
            if (adjustHoldingRequest != null && adjustHoldingRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(adjustHoldingRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adjustHoldingRequest; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AdjustHolding) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdjustHolding)));
        }

        /// <summary>
        /// Set holdings Set the holdings of the specified transaction portfolio to the provided targets. LUSID will automatically  construct adjustment transactions to ensure that the entire set of holdings for the transaction portfolio  are always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The complete set of target holdings for the transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>Task of AdjustHolding</returns>
        public async System.Threading.Tasks.Task<AdjustHolding> SetHoldingsAsync (string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = null)
        {
             ApiResponse<AdjustHolding> localVarResponse = await SetHoldingsAsyncWithHttpInfo(scope, code, effectiveAt, adjustHoldingRequest, reconciliationMethods);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Set holdings Set the holdings of the specified transaction portfolio to the provided targets. LUSID will automatically  construct adjustment transactions to ensure that the entire set of holdings for the transaction portfolio  are always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The complete set of target holdings for the transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>Task of ApiResponse (AdjustHolding)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdjustHolding>> SetHoldingsAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = null)
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
            // verify the required parameter 'adjustHoldingRequest' is set
            if (adjustHoldingRequest == null)
                throw new ApiException(400, "Missing required parameter 'adjustHoldingRequest' when calling TransactionPortfoliosApi->SetHoldings");

            var localVarPath = "./api/transactionportfolios/{scope}/{code}/holdings";
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
            if (reconciliationMethods != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "reconciliationMethods", reconciliationMethods)); // query parameter
            if (adjustHoldingRequest != null && adjustHoldingRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(adjustHoldingRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adjustHoldingRequest; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AdjustHolding) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdjustHolding)));
        }

        /// <summary>
        /// Upsert portfolio details Create or update certain details for a particular transaction portfolio. The details are updated if they already exist, and inserted if they do not.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="createPortfolioDetails">The details to create or update for the specified transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <returns>PortfolioDetails</returns>
        public PortfolioDetails UpsertPortfolioDetails (string scope, string code, CreatePortfolioDetails createPortfolioDetails, DateTimeOrCutLabel effectiveAt = null)
        {
             ApiResponse<PortfolioDetails> localVarResponse = UpsertPortfolioDetailsWithHttpInfo(scope, code, createPortfolioDetails, effectiveAt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Upsert portfolio details Create or update certain details for a particular transaction portfolio. The details are updated if they already exist, and inserted if they do not.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="createPortfolioDetails">The details to create or update for the specified transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <returns>ApiResponse of PortfolioDetails</returns>
        public ApiResponse< PortfolioDetails > UpsertPortfolioDetailsWithHttpInfo (string scope, string code, CreatePortfolioDetails createPortfolioDetails, DateTimeOrCutLabel effectiveAt = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->UpsertPortfolioDetails");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->UpsertPortfolioDetails");
            // verify the required parameter 'createPortfolioDetails' is set
            if (createPortfolioDetails == null)
                throw new ApiException(400, "Missing required parameter 'createPortfolioDetails' when calling TransactionPortfoliosApi->UpsertPortfolioDetails");

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
            if (createPortfolioDetails != null && createPortfolioDetails.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(createPortfolioDetails); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createPortfolioDetails; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PortfolioDetails) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortfolioDetails)));
        }

        /// <summary>
        /// Upsert portfolio details Create or update certain details for a particular transaction portfolio. The details are updated if they already exist, and inserted if they do not.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="createPortfolioDetails">The details to create or update for the specified transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <returns>Task of PortfolioDetails</returns>
        public async System.Threading.Tasks.Task<PortfolioDetails> UpsertPortfolioDetailsAsync (string scope, string code, CreatePortfolioDetails createPortfolioDetails, DateTimeOrCutLabel effectiveAt = null)
        {
             ApiResponse<PortfolioDetails> localVarResponse = await UpsertPortfolioDetailsAsyncWithHttpInfo(scope, code, createPortfolioDetails, effectiveAt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Upsert portfolio details Create or update certain details for a particular transaction portfolio. The details are updated if they already exist, and inserted if they do not.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="createPortfolioDetails">The details to create or update for the specified transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <returns>Task of ApiResponse (PortfolioDetails)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PortfolioDetails>> UpsertPortfolioDetailsAsyncWithHttpInfo (string scope, string code, CreatePortfolioDetails createPortfolioDetails, DateTimeOrCutLabel effectiveAt = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->UpsertPortfolioDetails");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->UpsertPortfolioDetails");
            // verify the required parameter 'createPortfolioDetails' is set
            if (createPortfolioDetails == null)
                throw new ApiException(400, "Missing required parameter 'createPortfolioDetails' when calling TransactionPortfoliosApi->UpsertPortfolioDetails");

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
            if (createPortfolioDetails != null && createPortfolioDetails.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(createPortfolioDetails); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createPortfolioDetails; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PortfolioDetails) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortfolioDetails)));
        }

        /// <summary>
        /// Upsert transaction properties Create or update one or more transaction properties for a single transaction in the transaction portfolio.  Each property will be updated if it already exists and created if it does not.  Both transaction and portfolio must exist at the time when properties are created or updated.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update properties for.</param>
        /// <param name="requestBody">The properties and their associated values to create or update.</param>
        /// <returns>UpsertTransactionPropertiesResponse</returns>
        public UpsertTransactionPropertiesResponse UpsertTransactionProperties (string scope, string code, string transactionId, Dictionary<string, PerpetualProperty> requestBody)
        {
             ApiResponse<UpsertTransactionPropertiesResponse> localVarResponse = UpsertTransactionPropertiesWithHttpInfo(scope, code, transactionId, requestBody);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Upsert transaction properties Create or update one or more transaction properties for a single transaction in the transaction portfolio.  Each property will be updated if it already exists and created if it does not.  Both transaction and portfolio must exist at the time when properties are created or updated.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update properties for.</param>
        /// <param name="requestBody">The properties and their associated values to create or update.</param>
        /// <returns>ApiResponse of UpsertTransactionPropertiesResponse</returns>
        public ApiResponse< UpsertTransactionPropertiesResponse > UpsertTransactionPropertiesWithHttpInfo (string scope, string code, string transactionId, Dictionary<string, PerpetualProperty> requestBody)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->UpsertTransactionProperties");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->UpsertTransactionProperties");
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling TransactionPortfoliosApi->UpsertTransactionProperties");
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling TransactionPortfoliosApi->UpsertTransactionProperties");

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
            if (requestBody != null && requestBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(requestBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = requestBody; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.11.3347";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpsertTransactionProperties", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UpsertTransactionPropertiesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (UpsertTransactionPropertiesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpsertTransactionPropertiesResponse)));
        }

        /// <summary>
        /// Upsert transaction properties Create or update one or more transaction properties for a single transaction in the transaction portfolio.  Each property will be updated if it already exists and created if it does not.  Both transaction and portfolio must exist at the time when properties are created or updated.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update properties for.</param>
        /// <param name="requestBody">The properties and their associated values to create or update.</param>
        /// <returns>Task of UpsertTransactionPropertiesResponse</returns>
        public async System.Threading.Tasks.Task<UpsertTransactionPropertiesResponse> UpsertTransactionPropertiesAsync (string scope, string code, string transactionId, Dictionary<string, PerpetualProperty> requestBody)
        {
             ApiResponse<UpsertTransactionPropertiesResponse> localVarResponse = await UpsertTransactionPropertiesAsyncWithHttpInfo(scope, code, transactionId, requestBody);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Upsert transaction properties Create or update one or more transaction properties for a single transaction in the transaction portfolio.  Each property will be updated if it already exists and created if it does not.  Both transaction and portfolio must exist at the time when properties are created or updated.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update properties for.</param>
        /// <param name="requestBody">The properties and their associated values to create or update.</param>
        /// <returns>Task of ApiResponse (UpsertTransactionPropertiesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UpsertTransactionPropertiesResponse>> UpsertTransactionPropertiesAsyncWithHttpInfo (string scope, string code, string transactionId, Dictionary<string, PerpetualProperty> requestBody)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->UpsertTransactionProperties");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->UpsertTransactionProperties");
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling TransactionPortfoliosApi->UpsertTransactionProperties");
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling TransactionPortfoliosApi->UpsertTransactionProperties");

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
            if (requestBody != null && requestBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(requestBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = requestBody; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.11.3347";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpsertTransactionProperties", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UpsertTransactionPropertiesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (UpsertTransactionPropertiesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpsertTransactionPropertiesResponse)));
        }

        /// <summary>
        /// Upsert transactions Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.  The maximum number of transactions that this method can upsert per request is 10,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionRequest">A list of transactions to be created or updated.</param>
        /// <returns>UpsertPortfolioTransactionsResponse</returns>
        public UpsertPortfolioTransactionsResponse UpsertTransactions (string scope, string code, List<TransactionRequest> transactionRequest)
        {
             ApiResponse<UpsertPortfolioTransactionsResponse> localVarResponse = UpsertTransactionsWithHttpInfo(scope, code, transactionRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Upsert transactions Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.  The maximum number of transactions that this method can upsert per request is 10,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionRequest">A list of transactions to be created or updated.</param>
        /// <returns>ApiResponse of UpsertPortfolioTransactionsResponse</returns>
        public ApiResponse< UpsertPortfolioTransactionsResponse > UpsertTransactionsWithHttpInfo (string scope, string code, List<TransactionRequest> transactionRequest)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->UpsertTransactions");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->UpsertTransactions");
            // verify the required parameter 'transactionRequest' is set
            if (transactionRequest == null)
                throw new ApiException(400, "Missing required parameter 'transactionRequest' when calling TransactionPortfoliosApi->UpsertTransactions");

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
            if (transactionRequest != null && transactionRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(transactionRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transactionRequest; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (UpsertPortfolioTransactionsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpsertPortfolioTransactionsResponse)));
        }

        /// <summary>
        /// Upsert transactions Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.  The maximum number of transactions that this method can upsert per request is 10,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionRequest">A list of transactions to be created or updated.</param>
        /// <returns>Task of UpsertPortfolioTransactionsResponse</returns>
        public async System.Threading.Tasks.Task<UpsertPortfolioTransactionsResponse> UpsertTransactionsAsync (string scope, string code, List<TransactionRequest> transactionRequest)
        {
             ApiResponse<UpsertPortfolioTransactionsResponse> localVarResponse = await UpsertTransactionsAsyncWithHttpInfo(scope, code, transactionRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Upsert transactions Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.  The maximum number of transactions that this method can upsert per request is 10,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionRequest">A list of transactions to be created or updated.</param>
        /// <returns>Task of ApiResponse (UpsertPortfolioTransactionsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UpsertPortfolioTransactionsResponse>> UpsertTransactionsAsyncWithHttpInfo (string scope, string code, List<TransactionRequest> transactionRequest)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->UpsertTransactions");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->UpsertTransactions");
            // verify the required parameter 'transactionRequest' is set
            if (transactionRequest == null)
                throw new ApiException(400, "Missing required parameter 'transactionRequest' when calling TransactionPortfoliosApi->UpsertTransactions");

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
            if (transactionRequest != null && transactionRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(transactionRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transactionRequest; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.11.3347";

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
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (UpsertPortfolioTransactionsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpsertPortfolioTransactionsResponse)));
        }

    }
}