/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) |   # Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"-10\">-10</a>|Server Configuration Error|  | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"102\">102</a>|Version Not Found|  | | <a name=\"103\">103</a>|Api Rate Limit Violation|  | | <a name=\"104\">104</a>|Instrument Not Found|  | | <a name=\"105\">105</a>|Property Not Found|  | | <a name=\"106\">106</a>|Portfolio Recursion Depth|  | | <a name=\"108\">108</a>|Group Not Found|  | | <a name=\"109\">109</a>|Portfolio Not Found|  | | <a name=\"110\">110</a>|Property Schema Not Found|  | | <a name=\"111\">111</a>|Portfolio Ancestry Not Found|  | | <a name=\"112\">112</a>|Portfolio With Id Already Exists|  | | <a name=\"113\">113</a>|Orphaned Portfolio|  | | <a name=\"119\">119</a>|Missing Base Claims|  | | <a name=\"121\">121</a>|Property Not Defined|  | | <a name=\"122\">122</a>|Cannot Delete System Property|  | | <a name=\"123\">123</a>|Cannot Modify Immutable Property Field|  | | <a name=\"124\">124</a>|Property Already Exists|  | | <a name=\"125\">125</a>|Invalid Property Life Time|  | | <a name=\"126\">126</a>|Property Constraint Style Excludes Properties|  | | <a name=\"127\">127</a>|Cannot Modify Default Data Type|  | | <a name=\"128\">128</a>|Group Already Exists|  | | <a name=\"129\">129</a>|No Such Data Type|  | | <a name=\"130\">130</a>|Undefined Value For Data Type|  | | <a name=\"131\">131</a>|Unsupported Value Type Defined On Data Type|  | | <a name=\"132\">132</a>|Validation Error|  | | <a name=\"133\">133</a>|Loop Detected In Group Hierarchy|  | | <a name=\"134\">134</a>|Undefined Acceptable Values|  | | <a name=\"135\">135</a>|Sub Group Already Exists|  | | <a name=\"138\">138</a>|Price Source Not Found|  | | <a name=\"139\">139</a>|Analytic Store Not Found|  | | <a name=\"141\">141</a>|Analytic Store Already Exists|  | | <a name=\"143\">143</a>|Client Instrument Already Exists|  | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"147\">147</a>|Results Not Found|  | | <a name=\"148\">148</a>|Order Field Not In Result Set|  | | <a name=\"149\">149</a>|Operation Failed|  | | <a name=\"150\">150</a>|Elastic Search Error|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"153\">153</a>|Command Processing Failure|  | | <a name=\"154\">154</a>|Entity State Construction Failure|  | | <a name=\"155\">155</a>|Entity Timeline Does Not Exist|  | | <a name=\"156\">156</a>|Concurrency Conflict Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"158\">158</a>|Event Publish Unknown|  | | <a name=\"159\">159</a>|Event Query Failure|  | | <a name=\"160\">160</a>|Blob Did Not Exist|  | | <a name=\"162\">162</a>|Sub System Request Failure|  | | <a name=\"163\">163</a>|Sub System Configuration Failure|  | | <a name=\"165\">165</a>|Failed To Delete|  | | <a name=\"166\">166</a>|Upsert Client Instrument Failure|  | | <a name=\"167\">167</a>|Illegal As At Interval|  | | <a name=\"168\">168</a>|Illegal Bitemporal Query|  | | <a name=\"169\">169</a>|Invalid Alternate Id|  | | <a name=\"170\">170</a>|Cannot Add Source Portfolio Property Explicitly|  | | <a name=\"171\">171</a>|Entity Already Exists In Group|  | | <a name=\"173\">173</a>|Entity With Id Already Exists|  | | <a name=\"174\">174</a>|Derived Portfolio Details Do Not Exist|  | | <a name=\"176\">176</a>|Portfolio With Name Already Exists|  | | <a name=\"177\">177</a>|Invalid Transactions|  | | <a name=\"178\">178</a>|Reference Portfolio Not Found|  | | <a name=\"179\">179</a>|Duplicate Id|  | | <a name=\"180\">180</a>|Command Retrieval Failure|  | | <a name=\"181\">181</a>|Data Filter Application Failure|  | | <a name=\"182\">182</a>|Search Failed|  | | <a name=\"183\">183</a>|Movements Engine Configuration Key Failure|  | | <a name=\"184\">184</a>|Fx Rate Source Not Found|  | | <a name=\"185\">185</a>|Accrual Source Not Found|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"188\">188</a>|Invalid Request Headers|  | | <a name=\"189\">189</a>|Price Not Found|  | | <a name=\"190\">190</a>|Invalid Sub Holding Keys Provided|  | | <a name=\"191\">191</a>|Duplicate Sub Holding Keys Provided|  | | <a name=\"192\">192</a>|Cut Definition Not Found|  | | <a name=\"193\">193</a>|Cut Definition Invalid|  | | <a name=\"194\">194</a>|Time Variant Property Deletion Date Unspecified|  | | <a name=\"195\">195</a>|Perpetual Property Deletion Date Specified|  | | <a name=\"196\">196</a>|Time Variant Property Upsert Date Unspecified|  | | <a name=\"197\">197</a>|Perpetual Property Upsert Date Specified|  | | <a name=\"200\">200</a>|Invalid Unit For Data Type|  | | <a name=\"201\">201</a>|Invalid Type For Data Type|  | | <a name=\"202\">202</a>|Invalid Value For Data Type|  | | <a name=\"203\">203</a>|Unit Not Defined For Data Type|  | | <a name=\"204\">204</a>|Units Not Supported On Data Type|  | | <a name=\"205\">205</a>|Cannot Specify Units On Data Type|  | | <a name=\"206\">206</a>|Unit Schema Inconsistent With Data Type|  | | <a name=\"207\">207</a>|Unit Definition Not Specified|  | | <a name=\"208\">208</a>|Duplicate Unit Definitions Specified|  | | <a name=\"209\">209</a>|Invalid Units Definition|  | | <a name=\"210\">210</a>|Invalid Instrument Identifier Unit|  | | <a name=\"211\">211</a>|Holdings Adjustment Does Not Exist|  | | <a name=\"212\">212</a>|Could Not Build Excel Url|  | | <a name=\"213\">213</a>|Could Not Get Excel Version|  | | <a name=\"214\">214</a>|Instrument By Code Not Found|  | | <a name=\"215\">215</a>|Entity Schema Does Not Exist|  | | <a name=\"216\">216</a>|Feature Not Supported On Portfolio Type|  | | <a name=\"217\">217</a>|Quote Not Found|  | | <a name=\"218\">218</a>|Invalid Quote Identifier|  | | <a name=\"219\">219</a>|Invalid Metric For Data Type|  | | <a name=\"220\">220</a>|Invalid Instrument Definition|  | | <a name=\"221\">221</a>|Instrument Upsert Failure|  | | <a name=\"222\">222</a>|Reference Portfolio Request Not Supported|  | | <a name=\"223\">223</a>|Transaction Portfolio Request Not Supported|  | | <a name=\"224\">224</a>|Invalid Property Value Assignment|  | | <a name=\"230\">230</a>|Transaction Type Not Found|  | | <a name=\"231\">231</a>|Transaction Type Duplication|  | | <a name=\"232\">232</a>|Portfolio Does Not Exist At Given Date|  | | <a name=\"233\">233</a>|Query Parser Failure|  | | <a name=\"234\">234</a>|Duplicate Constituent|  | | <a name=\"235\">235</a>|Unresolved Instrument Constituent|  | | <a name=\"236\">236</a>|Unresolved Instrument In Transition|  | | <a name=\"237\">237</a>|Missing Side Definitions|  | | <a name=\"299\">299</a>|Invalid Recipe|  | | <a name=\"300\">300</a>|Missing Recipe|  | | <a name=\"301\">301</a>|Dependencies|  | | <a name=\"304\">304</a>|Portfolio Preprocess Failure|  | | <a name=\"310\">310</a>|Valuation Engine Failure|  | | <a name=\"311\">311</a>|Task Factory Failure|  | | <a name=\"312\">312</a>|Task Evaluation Failure|  | | <a name=\"313\">313</a>|Task Generation Failure|  | | <a name=\"314\">314</a>|Engine Configuration Failure|  | | <a name=\"315\">315</a>|Model Specification Failure|  | | <a name=\"320\">320</a>|Market Data Key Failure|  | | <a name=\"321\">321</a>|Market Resolver Failure|  | | <a name=\"322\">322</a>|Market Data Failure|  | | <a name=\"330\">330</a>|Curve Failure|  | | <a name=\"331\">331</a>|Volatility Surface Failure|  | | <a name=\"332\">332</a>|Volatility Cube Failure|  | | <a name=\"350\">350</a>|Instrument Failure|  | | <a name=\"351\">351</a>|Cash Flows Failure|  | | <a name=\"352\">352</a>|Reference Data Failure|  | | <a name=\"360\">360</a>|Aggregation Failure|  | | <a name=\"361\">361</a>|Aggregation Measure Failure|  | | <a name=\"370\">370</a>|Result Retrieval Failure|  | | <a name=\"371\">371</a>|Result Processing Failure|  | | <a name=\"372\">372</a>|Vendor Result Processing Failure|  | | <a name=\"373\">373</a>|Vendor Result Mapping Failure|  | | <a name=\"374\">374</a>|Vendor Library Unauthorised|  | | <a name=\"375\">375</a>|Vendor Connectivity Error|  | | <a name=\"376\">376</a>|Vendor Interface Error|  | | <a name=\"377\">377</a>|Vendor Pricing Failure|  | | <a name=\"378\">378</a>|Vendor Translation Failure|  | | <a name=\"379\">379</a>|Vendor Key Mapping Failure|  | | <a name=\"380\">380</a>|Vendor Reflection Failure|  | | <a name=\"381\">381</a>|Vendor Process Failure|  | | <a name=\"382\">382</a>|Vendor System Failure|  | | <a name=\"390\">390</a>|Attempt To Upsert Duplicate Quotes|  | | <a name=\"391\">391</a>|Corporate Action Source Does Not Exist|  | | <a name=\"392\">392</a>|Corporate Action Source Already Exists|  | | <a name=\"393\">393</a>|Instrument Identifier Already In Use|  | | <a name=\"394\">394</a>|Properties Not Found|  | | <a name=\"395\">395</a>|Batch Operation Aborted|  | | <a name=\"400\">400</a>|Invalid Iso4217 Currency Code|  | | <a name=\"401\">401</a>|Cannot Assign Instrument Identifier To Currency|  | | <a name=\"402\">402</a>|Cannot Assign Currency Identifier To Non Currency|  | | <a name=\"403\">403</a>|Currency Instrument Cannot Be Deleted|  | | <a name=\"404\">404</a>|Currency Instrument Cannot Have Economic Definition|  | | <a name=\"405\">405</a>|Currency Instrument Cannot Have Lookthrough Portfolio|  | | <a name=\"406\">406</a>|Cannot Create Currency Instrument With Multiple Identifiers|  | | <a name=\"407\">407</a>|Specified Currency Is Undefined|  | | <a name=\"410\">410</a>|Index Does Not Exist|  | | <a name=\"411\">411</a>|Sort Field Does Not Exist|  | | <a name=\"413\">413</a>|Negative Pagination Parameters|  | | <a name=\"414\">414</a>|Invalid Search Syntax|  | | <a name=\"415\">415</a>|Filter Execution Timeout|  | | <a name=\"420\">420</a>|Side Definition Inconsistent|  | | <a name=\"450\">450</a>|Invalid Quote Access Metadata Rule|  | | <a name=\"451\">451</a>|Access Metadata Not Found|  | | <a name=\"452\">452</a>|Invalid Access Metadata Identifier|  | | <a name=\"460\">460</a>|Standard Resource Not Found|  | | <a name=\"461\">461</a>|Standard Resource Conflict|  | | <a name=\"462\">462</a>|Calendar Not Found|  | | <a name=\"463\">463</a>|Date In A Calendar Not Found|  | | <a name=\"464\">464</a>|Invalid Date Source Data|  | | <a name=\"465\">465</a>|Invalid Timezone|  | | <a name=\"601\">601</a>|Person Identifier Already In Use|  | | <a name=\"602\">602</a>|Person Not Found|  | | <a name=\"603\">603</a>|Cannot Set Identifier|  | | <a name=\"617\">617</a>|Invalid Recipe Specification In Request|  | | <a name=\"618\">618</a>|Inline Recipe Deserialisation Failure|  | | <a name=\"619\">619</a>|Identifier Types Not Set For Entity|  | | <a name=\"620\">620</a>|Cannot Delete All Client Defined Identifiers|  | | <a name=\"650\">650</a>|The Order requested was not found.|  | | <a name=\"654\">654</a>|The Allocation requested was not found.|  | | <a name=\"655\">655</a>|Cannot build the fx forward target with the given holdings.|  | | <a name=\"656\">656</a>|Group does not contain expected entities.|  | | <a name=\"665\">665</a>|Destination directory not found|  | | <a name=\"667\">667</a>|Relation definition already exists|  | | <a name=\"672\">672</a>|Could not retrieve file contents|  | | <a name=\"673\">673</a>|Missing entitlements for entities in Group|  | | <a name=\"674\">674</a>|Next Best Action not found|  | | <a name=\"676\">676</a>|Relation definition not defined|  | | <a name=\"677\">677</a>|Invalid entity identifier for relation|  | | <a name=\"681\">681</a>|Sorting by specified field not supported|One or more of the provided fields to order by were either invalid or not supported. | | <a name=\"682\">682</a>|Too many fields to sort by|The number of fields to sort the data by exceeds the number allowed by the endpoint | | <a name=\"684\">684</a>|Sequence Not Found|  | | <a name=\"685\">685</a>|Sequence Already Exists|  | | <a name=\"686\">686</a>|Non-cycling sequence has been exhausted|  | | <a name=\"687\">687</a>|Legal Entity Identifier Already In Use|  | | <a name=\"688\">688</a>|Legal Entity Not Found|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"690\">690</a>|Property Type Is Not Supported|  | | <a name=\"691\">691</a>|Multiple Tax-lots For Currency Type Is Not Supported|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"693\">693</a>|Entity type is not supported for Relationship|  | | <a name=\"694\">694</a>|Relationship Validation Failure|  | | <a name=\"695\">695</a>|Relationship Not Found|  | | <a name=\"697\">697</a>|Derived Property Formula No Longer Valid|  | | <a name=\"698\">698</a>|Story is not available|  | | <a name=\"703\">703</a>|Corporate Action Does Not Exist|  | | <a name=\"720\">720</a>|The provided sort and filter combination is not valid|  | | <a name=\"721\">721</a>|A2B generation failed|  | | <a name=\"722\">722</a>|Aggregated Return Calculation Failure|  | | <a name=\"723\">723</a>|Custom Entity Definition Identifier Already In Use|  | | <a name=\"724\">724</a>|Custom Entity Definition Not Found|  | | <a name=\"725\">725</a>|The Placement requested was not found.|  | | <a name=\"726\">726</a>|The Execution requested was not found.|  | | <a name=\"727\">727</a>|The Block requested was not found.|  | | <a name=\"728\">728</a>|The Participation requested was not found.|  | | <a name=\"729\">729</a>|The Package requested was not found.|  | | <a name=\"730\">730</a>|The OrderInstruction requested was not found.|  | | <a name=\"732\">732</a>|Custom Entity not found.|  | | <a name=\"733\">733</a>|Custom Entity Identifier already in use.|  | | <a name=\"735\">735</a>|Calculation Failed.|  | | <a name=\"736\">736</a>|An expected key on HttpResponse is missing.|  | | <a name=\"737\">737</a>|A required fee detail is missing.|  | | <a name=\"738\">738</a>|Zero rows were returned from Luminesce|  | | <a name=\"739\">739</a>|Provided Weekend Mask was invalid|  | | <a name=\"742\">742</a>|Custom Entity fields do not match the definition|  | | <a name=\"746\">746</a>|The provided sequence is not valid.|  | | <a name=\"751\">751</a>|The type of the Custom Entity is different than the type provided in the definition.|  | | <a name=\"752\">752</a>|Luminesce process returned an error.|  | | <a name=\"753\">753</a>|File name or content incompatible with operation.|  | | <a name=\"755\">755</a>|Schema of response from Drive is not as expected.|  | | <a name=\"757\">757</a>|Schema of response from Luminesce is not as expected.|  | | <a name=\"758\">758</a>|Luminesce timed out.|  | 
 *
 * The version of the OpenAPI document: 0.11.3862
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// A list of output transactions.
    /// </summary>
    [DataContract(Name = "OutputTransaction")]
    public partial class OutputTransaction : IEquatable<OutputTransaction>
    {
        /// <summary>
        /// The status of the transaction. The available values are: Active, Amended, Cancelled
        /// </summary>
        /// <value>The status of the transaction. The available values are: Active, Amended, Cancelled</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransactionStatusEnum
        {
            /// <summary>
            /// Enum Active for value: Active
            /// </summary>
            [EnumMember(Value = "Active")]
            Active = 1,

            /// <summary>
            /// Enum Amended for value: Amended
            /// </summary>
            [EnumMember(Value = "Amended")]
            Amended = 2,

            /// <summary>
            /// Enum Cancelled for value: Cancelled
            /// </summary>
            [EnumMember(Value = "Cancelled")]
            Cancelled = 3

        }


        /// <summary>
        /// The status of the transaction. The available values are: Active, Amended, Cancelled
        /// </summary>
        /// <value>The status of the transaction. The available values are: Active, Amended, Cancelled</value>
        [DataMember(Name = "transactionStatus", EmitDefaultValue = false)]
        public TransactionStatusEnum? TransactionStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OutputTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTransaction" /> class.
        /// </summary>
        /// <param name="transactionId">The unique identifier for the transaction. (required).</param>
        /// <param name="type">The type of the transaction e.g. &#39;Buy&#39;, &#39;Sell&#39;. The transaction type should have been pre-configured via the System Configuration API endpoint. (required).</param>
        /// <param name="description">The description of the transaction. This only exists on transactions generated by LUSID e.g. a holdings adjustment transaction..</param>
        /// <param name="instrumentIdentifiers">A set of instrument identifiers that can resolve the transaction to a unique instrument..</param>
        /// <param name="instrumentScope">The scope in which the instrument lies..</param>
        /// <param name="instrumentUid">The unqiue Lusid Instrument Id (LUID) of the instrument that the transaction is in. (required).</param>
        /// <param name="transactionDate">The date of the transaction. (required).</param>
        /// <param name="settlementDate">The settlement date of the transaction. (required).</param>
        /// <param name="units">The number of units transacted in the associated instrument. (required).</param>
        /// <param name="transactionAmount">The total value of the transaction in the transaction currency..</param>
        /// <param name="transactionPrice">transactionPrice.</param>
        /// <param name="totalConsideration">totalConsideration.</param>
        /// <param name="exchangeRate">The exchange rate between the transaction and settlement currency (settlement currency being represented by the TotalConsideration.Currency). For example if the transaction currency is in USD and the settlement currency is in GBP this this the USD/GBP rate..</param>
        /// <param name="transactionToPortfolioRate">The exchange rate between the transaction and portfolio currency. For example if the transaction currency is in USD and the portfolio currency is in GBP this this the USD/GBP rate..</param>
        /// <param name="transactionCurrency">The transaction currency..</param>
        /// <param name="properties">Set of unique transaction properties and associated values to stored with the transaction. Each property will be from the &#39;Transaction&#39; domain..</param>
        /// <param name="counterpartyId">The identifier for the counterparty of the transaction..</param>
        /// <param name="source">The source of the transaction. This is used to look up the appropriate transaction group set in the transaction type configuration..</param>
        /// <param name="transactionStatus">The status of the transaction. The available values are: Active, Amended, Cancelled.</param>
        /// <param name="entryDateTime">The asAt datetime that the transaction was added to LUSID..</param>
        /// <param name="cancelDateTime">If the transaction has been cancelled, the asAt datetime that the transaction was cancelled..</param>
        /// <param name="realisedGainLoss">The collection of realised gains or losses resulting from relevant transactions e.g. a sale transaction. The cost used in calculating the realised gain or loss is determined by the accounting method defined when the transaction portfolio is created..</param>
        public OutputTransaction(string transactionId = default(string), string type = default(string), string description = default(string), Dictionary<string, string> instrumentIdentifiers = default(Dictionary<string, string>), string instrumentScope = default(string), string instrumentUid = default(string), DateTimeOffset transactionDate = default(DateTimeOffset), DateTimeOffset settlementDate = default(DateTimeOffset), decimal units = default(decimal), decimal transactionAmount = default(decimal), TransactionPrice transactionPrice = default(TransactionPrice), CurrencyAndAmount totalConsideration = default(CurrencyAndAmount), decimal exchangeRate = default(decimal), decimal? transactionToPortfolioRate = default(decimal?), string transactionCurrency = default(string), Dictionary<string, PerpetualProperty> properties = default(Dictionary<string, PerpetualProperty>), string counterpartyId = default(string), string source = default(string), TransactionStatusEnum? transactionStatus = default(TransactionStatusEnum?), DateTimeOffset entryDateTime = default(DateTimeOffset), DateTimeOffset? cancelDateTime = default(DateTimeOffset?), List<RealisedGainLoss> realisedGainLoss = default(List<RealisedGainLoss>))
        {
            // to ensure "transactionId" is required (not null)
            this.TransactionId = transactionId ?? throw new ArgumentNullException("transactionId is a required property for OutputTransaction and cannot be null");
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for OutputTransaction and cannot be null");
            // to ensure "instrumentUid" is required (not null)
            this.InstrumentUid = instrumentUid ?? throw new ArgumentNullException("instrumentUid is a required property for OutputTransaction and cannot be null");
            this.TransactionDate = transactionDate;
            this.SettlementDate = settlementDate;
            this.Units = units;
            this.Description = description;
            this.InstrumentIdentifiers = instrumentIdentifiers;
            this.InstrumentScope = instrumentScope;
            this.TransactionAmount = transactionAmount;
            this.TransactionPrice = transactionPrice;
            this.TotalConsideration = totalConsideration;
            this.ExchangeRate = exchangeRate;
            this.TransactionToPortfolioRate = transactionToPortfolioRate;
            this.TransactionCurrency = transactionCurrency;
            this.Properties = properties;
            this.CounterpartyId = counterpartyId;
            this.Source = source;
            this.TransactionStatus = transactionStatus;
            this.EntryDateTime = entryDateTime;
            this.CancelDateTime = cancelDateTime;
            this.RealisedGainLoss = realisedGainLoss;
        }

        /// <summary>
        /// The unique identifier for the transaction.
        /// </summary>
        /// <value>The unique identifier for the transaction.</value>
        [DataMember(Name = "transactionId", IsRequired = true, EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// The type of the transaction e.g. &#39;Buy&#39;, &#39;Sell&#39;. The transaction type should have been pre-configured via the System Configuration API endpoint.
        /// </summary>
        /// <value>The type of the transaction e.g. &#39;Buy&#39;, &#39;Sell&#39;. The transaction type should have been pre-configured via the System Configuration API endpoint.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The description of the transaction. This only exists on transactions generated by LUSID e.g. a holdings adjustment transaction.
        /// </summary>
        /// <value>The description of the transaction. This only exists on transactions generated by LUSID e.g. a holdings adjustment transaction.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// A set of instrument identifiers that can resolve the transaction to a unique instrument.
        /// </summary>
        /// <value>A set of instrument identifiers that can resolve the transaction to a unique instrument.</value>
        [DataMember(Name = "instrumentIdentifiers", EmitDefaultValue = true)]
        public Dictionary<string, string> InstrumentIdentifiers { get; set; }

        /// <summary>
        /// The scope in which the instrument lies.
        /// </summary>
        /// <value>The scope in which the instrument lies.</value>
        [DataMember(Name = "instrumentScope", EmitDefaultValue = true)]
        public string InstrumentScope { get; set; }

        /// <summary>
        /// The unqiue Lusid Instrument Id (LUID) of the instrument that the transaction is in.
        /// </summary>
        /// <value>The unqiue Lusid Instrument Id (LUID) of the instrument that the transaction is in.</value>
        [DataMember(Name = "instrumentUid", IsRequired = true, EmitDefaultValue = false)]
        public string InstrumentUid { get; set; }

        /// <summary>
        /// The date of the transaction.
        /// </summary>
        /// <value>The date of the transaction.</value>
        [DataMember(Name = "transactionDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset TransactionDate { get; set; }

        /// <summary>
        /// The settlement date of the transaction.
        /// </summary>
        /// <value>The settlement date of the transaction.</value>
        [DataMember(Name = "settlementDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset SettlementDate { get; set; }

        /// <summary>
        /// The number of units transacted in the associated instrument.
        /// </summary>
        /// <value>The number of units transacted in the associated instrument.</value>
        [DataMember(Name = "units", IsRequired = true, EmitDefaultValue = true)]
        public decimal Units { get; set; }

        /// <summary>
        /// The total value of the transaction in the transaction currency.
        /// </summary>
        /// <value>The total value of the transaction in the transaction currency.</value>
        [DataMember(Name = "transactionAmount", EmitDefaultValue = true)]
        public decimal TransactionAmount { get; set; }

        /// <summary>
        /// Gets or Sets TransactionPrice
        /// </summary>
        [DataMember(Name = "transactionPrice", EmitDefaultValue = false)]
        public TransactionPrice TransactionPrice { get; set; }

        /// <summary>
        /// Gets or Sets TotalConsideration
        /// </summary>
        [DataMember(Name = "totalConsideration", EmitDefaultValue = false)]
        public CurrencyAndAmount TotalConsideration { get; set; }

        /// <summary>
        /// The exchange rate between the transaction and settlement currency (settlement currency being represented by the TotalConsideration.Currency). For example if the transaction currency is in USD and the settlement currency is in GBP this this the USD/GBP rate.
        /// </summary>
        /// <value>The exchange rate between the transaction and settlement currency (settlement currency being represented by the TotalConsideration.Currency). For example if the transaction currency is in USD and the settlement currency is in GBP this this the USD/GBP rate.</value>
        [DataMember(Name = "exchangeRate", EmitDefaultValue = true)]
        public decimal ExchangeRate { get; set; }

        /// <summary>
        /// The exchange rate between the transaction and portfolio currency. For example if the transaction currency is in USD and the portfolio currency is in GBP this this the USD/GBP rate.
        /// </summary>
        /// <value>The exchange rate between the transaction and portfolio currency. For example if the transaction currency is in USD and the portfolio currency is in GBP this this the USD/GBP rate.</value>
        [DataMember(Name = "transactionToPortfolioRate", EmitDefaultValue = true)]
        public decimal? TransactionToPortfolioRate { get; set; }

        /// <summary>
        /// The transaction currency.
        /// </summary>
        /// <value>The transaction currency.</value>
        [DataMember(Name = "transactionCurrency", EmitDefaultValue = true)]
        public string TransactionCurrency { get; set; }

        /// <summary>
        /// Set of unique transaction properties and associated values to stored with the transaction. Each property will be from the &#39;Transaction&#39; domain.
        /// </summary>
        /// <value>Set of unique transaction properties and associated values to stored with the transaction. Each property will be from the &#39;Transaction&#39; domain.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, PerpetualProperty> Properties { get; set; }

        /// <summary>
        /// The identifier for the counterparty of the transaction.
        /// </summary>
        /// <value>The identifier for the counterparty of the transaction.</value>
        [DataMember(Name = "counterpartyId", EmitDefaultValue = true)]
        public string CounterpartyId { get; set; }

        /// <summary>
        /// The source of the transaction. This is used to look up the appropriate transaction group set in the transaction type configuration.
        /// </summary>
        /// <value>The source of the transaction. This is used to look up the appropriate transaction group set in the transaction type configuration.</value>
        [DataMember(Name = "source", EmitDefaultValue = true)]
        public string Source { get; set; }

        /// <summary>
        /// The asAt datetime that the transaction was added to LUSID.
        /// </summary>
        /// <value>The asAt datetime that the transaction was added to LUSID.</value>
        [DataMember(Name = "entryDateTime", EmitDefaultValue = false)]
        public DateTimeOffset EntryDateTime { get; set; }

        /// <summary>
        /// If the transaction has been cancelled, the asAt datetime that the transaction was cancelled.
        /// </summary>
        /// <value>If the transaction has been cancelled, the asAt datetime that the transaction was cancelled.</value>
        [DataMember(Name = "cancelDateTime", EmitDefaultValue = true)]
        public DateTimeOffset? CancelDateTime { get; set; }

        /// <summary>
        /// The collection of realised gains or losses resulting from relevant transactions e.g. a sale transaction. The cost used in calculating the realised gain or loss is determined by the accounting method defined when the transaction portfolio is created.
        /// </summary>
        /// <value>The collection of realised gains or losses resulting from relevant transactions e.g. a sale transaction. The cost used in calculating the realised gain or loss is determined by the accounting method defined when the transaction portfolio is created.</value>
        [DataMember(Name = "realisedGainLoss", EmitDefaultValue = true)]
        public List<RealisedGainLoss> RealisedGainLoss { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutputTransaction {\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  InstrumentIdentifiers: ").Append(InstrumentIdentifiers).Append("\n");
            sb.Append("  InstrumentScope: ").Append(InstrumentScope).Append("\n");
            sb.Append("  InstrumentUid: ").Append(InstrumentUid).Append("\n");
            sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
            sb.Append("  SettlementDate: ").Append(SettlementDate).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  TransactionPrice: ").Append(TransactionPrice).Append("\n");
            sb.Append("  TotalConsideration: ").Append(TotalConsideration).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  TransactionToPortfolioRate: ").Append(TransactionToPortfolioRate).Append("\n");
            sb.Append("  TransactionCurrency: ").Append(TransactionCurrency).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  CounterpartyId: ").Append(CounterpartyId).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  TransactionStatus: ").Append(TransactionStatus).Append("\n");
            sb.Append("  EntryDateTime: ").Append(EntryDateTime).Append("\n");
            sb.Append("  CancelDateTime: ").Append(CancelDateTime).Append("\n");
            sb.Append("  RealisedGainLoss: ").Append(RealisedGainLoss).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OutputTransaction);
        }

        /// <summary>
        /// Returns true if OutputTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of OutputTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutputTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.InstrumentIdentifiers == input.InstrumentIdentifiers ||
                    this.InstrumentIdentifiers != null &&
                    input.InstrumentIdentifiers != null &&
                    this.InstrumentIdentifiers.SequenceEqual(input.InstrumentIdentifiers)
                ) && 
                (
                    this.InstrumentScope == input.InstrumentScope ||
                    (this.InstrumentScope != null &&
                    this.InstrumentScope.Equals(input.InstrumentScope))
                ) && 
                (
                    this.InstrumentUid == input.InstrumentUid ||
                    (this.InstrumentUid != null &&
                    this.InstrumentUid.Equals(input.InstrumentUid))
                ) && 
                (
                    this.TransactionDate == input.TransactionDate ||
                    (this.TransactionDate != null &&
                    this.TransactionDate.Equals(input.TransactionDate))
                ) && 
                (
                    this.SettlementDate == input.SettlementDate ||
                    (this.SettlementDate != null &&
                    this.SettlementDate.Equals(input.SettlementDate))
                ) && 
                (
                    this.Units == input.Units ||
                    this.Units.Equals(input.Units)
                ) && 
                (
                    this.TransactionAmount == input.TransactionAmount ||
                    this.TransactionAmount.Equals(input.TransactionAmount)
                ) && 
                (
                    this.TransactionPrice == input.TransactionPrice ||
                    (this.TransactionPrice != null &&
                    this.TransactionPrice.Equals(input.TransactionPrice))
                ) && 
                (
                    this.TotalConsideration == input.TotalConsideration ||
                    (this.TotalConsideration != null &&
                    this.TotalConsideration.Equals(input.TotalConsideration))
                ) && 
                (
                    this.ExchangeRate == input.ExchangeRate ||
                    this.ExchangeRate.Equals(input.ExchangeRate)
                ) && 
                (
                    this.TransactionToPortfolioRate == input.TransactionToPortfolioRate ||
                    (this.TransactionToPortfolioRate != null &&
                    this.TransactionToPortfolioRate.Equals(input.TransactionToPortfolioRate))
                ) && 
                (
                    this.TransactionCurrency == input.TransactionCurrency ||
                    (this.TransactionCurrency != null &&
                    this.TransactionCurrency.Equals(input.TransactionCurrency))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.CounterpartyId == input.CounterpartyId ||
                    (this.CounterpartyId != null &&
                    this.CounterpartyId.Equals(input.CounterpartyId))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.TransactionStatus == input.TransactionStatus ||
                    this.TransactionStatus.Equals(input.TransactionStatus)
                ) && 
                (
                    this.EntryDateTime == input.EntryDateTime ||
                    (this.EntryDateTime != null &&
                    this.EntryDateTime.Equals(input.EntryDateTime))
                ) && 
                (
                    this.CancelDateTime == input.CancelDateTime ||
                    (this.CancelDateTime != null &&
                    this.CancelDateTime.Equals(input.CancelDateTime))
                ) && 
                (
                    this.RealisedGainLoss == input.RealisedGainLoss ||
                    this.RealisedGainLoss != null &&
                    input.RealisedGainLoss != null &&
                    this.RealisedGainLoss.SequenceEqual(input.RealisedGainLoss)
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
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.InstrumentIdentifiers != null)
                    hashCode = hashCode * 59 + this.InstrumentIdentifiers.GetHashCode();
                if (this.InstrumentScope != null)
                    hashCode = hashCode * 59 + this.InstrumentScope.GetHashCode();
                if (this.InstrumentUid != null)
                    hashCode = hashCode * 59 + this.InstrumentUid.GetHashCode();
                if (this.TransactionDate != null)
                    hashCode = hashCode * 59 + this.TransactionDate.GetHashCode();
                if (this.SettlementDate != null)
                    hashCode = hashCode * 59 + this.SettlementDate.GetHashCode();
                hashCode = hashCode * 59 + this.Units.GetHashCode();
                hashCode = hashCode * 59 + this.TransactionAmount.GetHashCode();
                if (this.TransactionPrice != null)
                    hashCode = hashCode * 59 + this.TransactionPrice.GetHashCode();
                if (this.TotalConsideration != null)
                    hashCode = hashCode * 59 + this.TotalConsideration.GetHashCode();
                hashCode = hashCode * 59 + this.ExchangeRate.GetHashCode();
                if (this.TransactionToPortfolioRate != null)
                    hashCode = hashCode * 59 + this.TransactionToPortfolioRate.GetHashCode();
                if (this.TransactionCurrency != null)
                    hashCode = hashCode * 59 + this.TransactionCurrency.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.CounterpartyId != null)
                    hashCode = hashCode * 59 + this.CounterpartyId.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                hashCode = hashCode * 59 + this.TransactionStatus.GetHashCode();
                if (this.EntryDateTime != null)
                    hashCode = hashCode * 59 + this.EntryDateTime.GetHashCode();
                if (this.CancelDateTime != null)
                    hashCode = hashCode * 59 + this.CancelDateTime.GetHashCode();
                if (this.RealisedGainLoss != null)
                    hashCode = hashCode * 59 + this.RealisedGainLoss.GetHashCode();
                return hashCode;
            }
        }

    }
}
