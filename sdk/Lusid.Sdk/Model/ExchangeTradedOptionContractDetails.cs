/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](../../../api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application   | Description                                                                       | API / Swagger Documentation                          | |- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -| | LUSID         | Open, API-first, developer-friendly investment data platform.                     | [Swagger](../../../api/swagger/index.html)           | | Web app       | User-facing front end for LUSID.                                                  | [Swagger](../../../app/swagger/index.html)           | | Scheduler     | Automated job scheduler.                                                          | [Swagger](../../../scheduler2/swagger/index.html)    | | Insights      | Monitoring and troubleshooting service.                                           | [Swagger](../../../insights/swagger/index.html)      | | Identity      | Identity management for LUSID (in conjunction with Access)                        | [Swagger](../../../identity/swagger/index.html)      | | Access        | Access control for LUSID (in conjunction with Identity)                           | [Swagger](../../../access/swagger/index.html)        | | Drive         | Secure file repository and manager for collaboration.                             | [Swagger](../../../drive/swagger/index.html)         | | Luminesce     | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](../../../honeycomb/swagger/index.html)     | | Notification  | Notification service.                                                             | [Swagger](../../../notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information.                           | [Swagger](../../../configuration/swagger/index.html) |   # Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"-10\">-10</a>|Server Configuration Error|  | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"102\">102</a>|Version Not Found|  | | <a name=\"103\">103</a>|Api Rate Limit Violation|  | | <a name=\"104\">104</a>|Instrument Not Found|  | | <a name=\"105\">105</a>|Property Not Found|  | | <a name=\"106\">106</a>|Portfolio Recursion Depth|  | | <a name=\"108\">108</a>|Group Not Found|  | | <a name=\"109\">109</a>|Portfolio Not Found|  | | <a name=\"110\">110</a>|Property Schema Not Found|  | | <a name=\"111\">111</a>|Portfolio Ancestry Not Found|  | | <a name=\"112\">112</a>|Portfolio With Id Already Exists|  | | <a name=\"113\">113</a>|Orphaned Portfolio|  | | <a name=\"119\">119</a>|Missing Base Claims|  | | <a name=\"121\">121</a>|Property Not Defined|  | | <a name=\"122\">122</a>|Cannot Delete System Property|  | | <a name=\"123\">123</a>|Cannot Modify Immutable Property Field|  | | <a name=\"124\">124</a>|Property Already Exists|  | | <a name=\"125\">125</a>|Invalid Property Life Time|  | | <a name=\"126\">126</a>|Property Constraint Style Excludes Properties|  | | <a name=\"127\">127</a>|Cannot Modify Default Data Type|  | | <a name=\"128\">128</a>|Group Already Exists|  | | <a name=\"129\">129</a>|No Such Data Type|  | | <a name=\"130\">130</a>|Undefined Value For Data Type|  | | <a name=\"131\">131</a>|Unsupported Value Type Defined On Data Type|  | | <a name=\"132\">132</a>|Validation Error|  | | <a name=\"133\">133</a>|Loop Detected In Group Hierarchy|  | | <a name=\"134\">134</a>|Undefined Acceptable Values|  | | <a name=\"135\">135</a>|Sub Group Already Exists|  | | <a name=\"138\">138</a>|Price Source Not Found|  | | <a name=\"139\">139</a>|Analytic Store Not Found|  | | <a name=\"141\">141</a>|Analytic Store Already Exists|  | | <a name=\"143\">143</a>|Client Instrument Already Exists|  | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"147\">147</a>|Results Not Found|  | | <a name=\"148\">148</a>|Order Field Not In Result Set|  | | <a name=\"149\">149</a>|Operation Failed|  | | <a name=\"150\">150</a>|Elastic Search Error|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"153\">153</a>|Command Processing Failure|  | | <a name=\"154\">154</a>|Entity State Construction Failure|  | | <a name=\"155\">155</a>|Entity Timeline Does Not Exist|  | | <a name=\"156\">156</a>|Concurrency Conflict Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"158\">158</a>|Event Publish Unknown|  | | <a name=\"159\">159</a>|Event Query Failure|  | | <a name=\"160\">160</a>|Blob Did Not Exist|  | | <a name=\"162\">162</a>|Sub System Request Failure|  | | <a name=\"163\">163</a>|Sub System Configuration Failure|  | | <a name=\"165\">165</a>|Failed To Delete|  | | <a name=\"166\">166</a>|Upsert Client Instrument Failure|  | | <a name=\"167\">167</a>|Illegal As At Interval|  | | <a name=\"168\">168</a>|Illegal Bitemporal Query|  | | <a name=\"169\">169</a>|Invalid Alternate Id|  | | <a name=\"170\">170</a>|Cannot Add Source Portfolio Property Explicitly|  | | <a name=\"171\">171</a>|Entity Already Exists In Group|  | | <a name=\"173\">173</a>|Entity With Id Already Exists|  | | <a name=\"174\">174</a>|Derived Portfolio Details Do Not Exist|  | | <a name=\"175\">175</a>|Entity Not In Group|  | | <a name=\"176\">176</a>|Portfolio With Name Already Exists|  | | <a name=\"177\">177</a>|Invalid Transactions|  | | <a name=\"178\">178</a>|Reference Portfolio Not Found|  | | <a name=\"179\">179</a>|Duplicate Id|  | | <a name=\"180\">180</a>|Command Retrieval Failure|  | | <a name=\"181\">181</a>|Data Filter Application Failure|  | | <a name=\"182\">182</a>|Search Failed|  | | <a name=\"183\">183</a>|Movements Engine Configuration Key Failure|  | | <a name=\"184\">184</a>|Fx Rate Source Not Found|  | | <a name=\"185\">185</a>|Accrual Source Not Found|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"188\">188</a>|Invalid Request Headers|  | | <a name=\"189\">189</a>|Price Not Found|  | | <a name=\"190\">190</a>|Invalid Sub Holding Keys Provided|  | | <a name=\"191\">191</a>|Duplicate Sub Holding Keys Provided|  | | <a name=\"192\">192</a>|Cut Definition Not Found|  | | <a name=\"193\">193</a>|Cut Definition Invalid|  | | <a name=\"194\">194</a>|Time Variant Property Deletion Date Unspecified|  | | <a name=\"195\">195</a>|Perpetual Property Deletion Date Specified|  | | <a name=\"196\">196</a>|Time Variant Property Upsert Date Unspecified|  | | <a name=\"197\">197</a>|Perpetual Property Upsert Date Specified|  | | <a name=\"200\">200</a>|Invalid Unit For Data Type|  | | <a name=\"201\">201</a>|Invalid Type For Data Type|  | | <a name=\"202\">202</a>|Invalid Value For Data Type|  | | <a name=\"203\">203</a>|Unit Not Defined For Data Type|  | | <a name=\"204\">204</a>|Units Not Supported On Data Type|  | | <a name=\"205\">205</a>|Cannot Specify Units On Data Type|  | | <a name=\"206\">206</a>|Unit Schema Inconsistent With Data Type|  | | <a name=\"207\">207</a>|Unit Definition Not Specified|  | | <a name=\"208\">208</a>|Duplicate Unit Definitions Specified|  | | <a name=\"209\">209</a>|Invalid Units Definition|  | | <a name=\"210\">210</a>|Invalid Instrument Identifier Unit|  | | <a name=\"211\">211</a>|Holdings Adjustment Does Not Exist|  | | <a name=\"212\">212</a>|Could Not Build Excel Url|  | | <a name=\"213\">213</a>|Could Not Get Excel Version|  | | <a name=\"214\">214</a>|Instrument By Code Not Found|  | | <a name=\"215\">215</a>|Entity Schema Does Not Exist|  | | <a name=\"216\">216</a>|Feature Not Supported On Portfolio Type|  | | <a name=\"217\">217</a>|Quote Not Found|  | | <a name=\"218\">218</a>|Invalid Quote Identifier|  | | <a name=\"219\">219</a>|Invalid Metric For Data Type|  | | <a name=\"220\">220</a>|Invalid Instrument Definition|  | | <a name=\"221\">221</a>|Instrument Upsert Failure|  | | <a name=\"222\">222</a>|Reference Portfolio Request Not Supported|  | | <a name=\"223\">223</a>|Transaction Portfolio Request Not Supported|  | | <a name=\"224\">224</a>|Invalid Property Value Assignment|  | | <a name=\"230\">230</a>|Transaction Type Not Found|  | | <a name=\"231\">231</a>|Transaction Type Duplication|  | | <a name=\"232\">232</a>|Portfolio Does Not Exist At Given Date|  | | <a name=\"233\">233</a>|Query Parser Failure|  | | <a name=\"234\">234</a>|Duplicate Constituent|  | | <a name=\"235\">235</a>|Unresolved Instrument Constituent|  | | <a name=\"236\">236</a>|Unresolved Instrument In Transition|  | | <a name=\"237\">237</a>|Missing Side Definitions|  | | <a name=\"299\">299</a>|Invalid Recipe|  | | <a name=\"300\">300</a>|Missing Recipe|  | | <a name=\"301\">301</a>|Dependencies|  | | <a name=\"304\">304</a>|Portfolio Preprocess Failure|  | | <a name=\"310\">310</a>|Valuation Engine Failure|  | | <a name=\"311\">311</a>|Task Factory Failure|  | | <a name=\"312\">312</a>|Task Evaluation Failure|  | | <a name=\"313\">313</a>|Task Generation Failure|  | | <a name=\"314\">314</a>|Engine Configuration Failure|  | | <a name=\"315\">315</a>|Model Specification Failure|  | | <a name=\"320\">320</a>|Market Data Key Failure|  | | <a name=\"321\">321</a>|Market Resolver Failure|  | | <a name=\"322\">322</a>|Market Data Failure|  | | <a name=\"330\">330</a>|Curve Failure|  | | <a name=\"331\">331</a>|Volatility Surface Failure|  | | <a name=\"332\">332</a>|Volatility Cube Failure|  | | <a name=\"350\">350</a>|Instrument Failure|  | | <a name=\"351\">351</a>|Cash Flows Failure|  | | <a name=\"352\">352</a>|Reference Data Failure|  | | <a name=\"360\">360</a>|Aggregation Failure|  | | <a name=\"361\">361</a>|Aggregation Measure Failure|  | | <a name=\"370\">370</a>|Result Retrieval Failure|  | | <a name=\"371\">371</a>|Result Processing Failure|  | | <a name=\"372\">372</a>|Vendor Result Processing Failure|  | | <a name=\"373\">373</a>|Vendor Result Mapping Failure|  | | <a name=\"374\">374</a>|Vendor Library Unauthorised|  | | <a name=\"375\">375</a>|Vendor Connectivity Error|  | | <a name=\"376\">376</a>|Vendor Interface Error|  | | <a name=\"377\">377</a>|Vendor Pricing Failure|  | | <a name=\"378\">378</a>|Vendor Translation Failure|  | | <a name=\"379\">379</a>|Vendor Key Mapping Failure|  | | <a name=\"380\">380</a>|Vendor Reflection Failure|  | | <a name=\"381\">381</a>|Vendor Process Failure|  | | <a name=\"382\">382</a>|Vendor System Failure|  | | <a name=\"390\">390</a>|Attempt To Upsert Duplicate Quotes|  | | <a name=\"391\">391</a>|Corporate Action Source Does Not Exist|  | | <a name=\"392\">392</a>|Corporate Action Source Already Exists|  | | <a name=\"393\">393</a>|Instrument Identifier Already In Use|  | | <a name=\"394\">394</a>|Properties Not Found|  | | <a name=\"395\">395</a>|Batch Operation Aborted|  | | <a name=\"400\">400</a>|Invalid Iso4217 Currency Code|  | | <a name=\"401\">401</a>|Cannot Assign Instrument Identifier To Currency|  | | <a name=\"402\">402</a>|Cannot Assign Currency Identifier To Non Currency|  | | <a name=\"403\">403</a>|Currency Instrument Cannot Be Deleted|  | | <a name=\"404\">404</a>|Currency Instrument Cannot Have Economic Definition|  | | <a name=\"405\">405</a>|Currency Instrument Cannot Have Lookthrough Portfolio|  | | <a name=\"406\">406</a>|Cannot Create Currency Instrument With Multiple Identifiers|  | | <a name=\"407\">407</a>|Specified Currency Is Undefined|  | | <a name=\"410\">410</a>|Index Does Not Exist|  | | <a name=\"411\">411</a>|Sort Field Does Not Exist|  | | <a name=\"413\">413</a>|Negative Pagination Parameters|  | | <a name=\"414\">414</a>|Invalid Search Syntax|  | | <a name=\"415\">415</a>|Filter Execution Timeout|  | | <a name=\"420\">420</a>|Side Definition Inconsistent|  | | <a name=\"450\">450</a>|Invalid Quote Access Metadata Rule|  | | <a name=\"451\">451</a>|Access Metadata Not Found|  | | <a name=\"452\">452</a>|Invalid Access Metadata Identifier|  | | <a name=\"460\">460</a>|Standard Resource Not Found|  | | <a name=\"461\">461</a>|Standard Resource Conflict|  | | <a name=\"462\">462</a>|Calendar Not Found|  | | <a name=\"463\">463</a>|Date In A Calendar Not Found|  | | <a name=\"464\">464</a>|Invalid Date Source Data|  | | <a name=\"465\">465</a>|Invalid Timezone|  | | <a name=\"601\">601</a>|Person Identifier Already In Use|  | | <a name=\"602\">602</a>|Person Not Found|  | | <a name=\"603\">603</a>|Cannot Set Identifier|  | | <a name=\"617\">617</a>|Invalid Recipe Specification In Request|  | | <a name=\"618\">618</a>|Inline Recipe Deserialisation Failure|  | | <a name=\"619\">619</a>|Identifier Types Not Set For Entity|  | | <a name=\"620\">620</a>|Cannot Delete All Client Defined Identifiers|  | | <a name=\"650\">650</a>|The Order requested was not found.|  | | <a name=\"654\">654</a>|The Allocation requested was not found.|  | | <a name=\"655\">655</a>|Cannot build the fx forward target with the given holdings.|  | | <a name=\"656\">656</a>|Group does not contain expected entities.|  | | <a name=\"665\">665</a>|Destination directory not found|  | | <a name=\"667\">667</a>|Relation definition already exists|  | | <a name=\"672\">672</a>|Could not retrieve file contents|  | | <a name=\"673\">673</a>|Missing entitlements for entities in Group|  | | <a name=\"674\">674</a>|Next Best Action not found|  | | <a name=\"676\">676</a>|Relation definition not defined|  | | <a name=\"677\">677</a>|Invalid entity identifier for relation|  | | <a name=\"681\">681</a>|Sorting by specified field not supported|One or more of the provided fields to order by were either invalid or not supported. | | <a name=\"682\">682</a>|Too many fields to sort by|The number of fields to sort the data by exceeds the number allowed by the endpoint | | <a name=\"684\">684</a>|Sequence Not Found|  | | <a name=\"685\">685</a>|Sequence Already Exists|  | | <a name=\"686\">686</a>|Non-cycling sequence has been exhausted|  | | <a name=\"687\">687</a>|Legal Entity Identifier Already In Use|  | | <a name=\"688\">688</a>|Legal Entity Not Found|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"690\">690</a>|Property Type Is Not Supported|  | | <a name=\"691\">691</a>|Multiple Tax-lots For Currency Type Is Not Supported|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"693\">693</a>|Entity type is not supported for Relationship|  | | <a name=\"694\">694</a>|Relationship Validation Failure|  | | <a name=\"695\">695</a>|Relationship Not Found|  | | <a name=\"697\">697</a>|Derived Property Formula No Longer Valid|  | | <a name=\"698\">698</a>|Story is not available|  | | <a name=\"703\">703</a>|Corporate Action Does Not Exist|  | | <a name=\"720\">720</a>|The provided sort and filter combination is not valid|  | | <a name=\"721\">721</a>|A2B generation failed|  | | <a name=\"722\">722</a>|Aggregated Return Calculation Failure|  | | <a name=\"723\">723</a>|Custom Entity Definition Identifier Already In Use|  | | <a name=\"724\">724</a>|Custom Entity Definition Not Found|  | | <a name=\"725\">725</a>|The Placement requested was not found.|  | | <a name=\"726\">726</a>|The Execution requested was not found.|  | | <a name=\"727\">727</a>|The Block requested was not found.|  | | <a name=\"728\">728</a>|The Participation requested was not found.|  | | <a name=\"729\">729</a>|The Package requested was not found.|  | | <a name=\"730\">730</a>|The OrderInstruction requested was not found.|  | | <a name=\"732\">732</a>|Custom Entity not found.|  | | <a name=\"733\">733</a>|Custom Entity Identifier already in use.|  | | <a name=\"735\">735</a>|Calculation Failed.|  | | <a name=\"736\">736</a>|An expected key on HttpResponse is missing.|  | | <a name=\"737\">737</a>|A required fee detail is missing.|  | | <a name=\"738\">738</a>|Zero rows were returned from Luminesce|  | | <a name=\"739\">739</a>|Provided Weekend Mask was invalid|  | | <a name=\"742\">742</a>|Custom Entity fields do not match the definition|  | | <a name=\"746\">746</a>|The provided sequence is not valid.|  | | <a name=\"751\">751</a>|The type of the Custom Entity is different than the type provided in the definition.|  | | <a name=\"752\">752</a>|Luminesce process returned an error.|  | | <a name=\"753\">753</a>|File name or content incompatible with operation.|  | | <a name=\"755\">755</a>|Schema of response from Drive is not as expected.|  | | <a name=\"757\">757</a>|Schema of response from Luminesce is not as expected.|  | | <a name=\"758\">758</a>|Luminesce timed out.|  | | <a name=\"763\">763</a>|Invalid Lusid Entity Identifier Unit|  | | <a name=\"768\">768</a>|Fee rule not found.|  | | <a name=\"769\">769</a>|Cannot update the base currency of a portfolio with transactions loaded|  | | <a name=\"771\">771</a>|Transaction configuration source not found|  | | <a name=\"774\">774</a>|Compliance rule not found.|  | | <a name=\"775\">775</a>|Fund accounting document cannot be processed.|  | | <a name=\"778\">778</a>|Unable to look up FX rate from trade ccy to portfolio ccy for some of the trades.|  | | <a name=\"782\">782</a>|The Property definition dataType is not matching the derivation formula dataType|  | | <a name=\"783\">783</a>|The Property definition domain is not supported for derived properties|  | | <a name=\"788\">788</a>|Compliance run not found failure.|  | | <a name=\"790\">790</a>|Custom Entity has missing or invalid identifiers|  | | <a name=\"791\">791</a>|Custom Entity definition already exists|  | | <a name=\"792\">792</a>|Compliance PropertyKey is missing.|  | | <a name=\"793\">793</a>|Compliance Criteria Value for matching is missing.|  | | <a name=\"795\">795</a>|Cannot delete identifier definition|  | | <a name=\"796\">796</a>|Tax rule set not found.|  | | <a name=\"797\">797</a>|A tax rule set with this id already exists.|  | | <a name=\"798\">798</a>|Multiple rule sets for the same property key are applicable.|  | | <a name=\"800\">800</a>|Can not upsert an instrument event of this type.|  | | <a name=\"801\">801</a>|The instrument event does not exist.|  | | <a name=\"802\">802</a>|The Instrument event is missing salient information.|  | | <a name=\"803\">803</a>|The Instrument event could not be processed.|  | | <a name=\"804\">804</a>|Some data requested does not follow the order graph assumptions.|  | | <a name=\"811\">811</a>|A price could not be found for an order.|  | | <a name=\"812\">812</a>|A price could not be found for an allocation.|  | | <a name=\"813\">813</a>|Chart of Accounts not found.|  | | <a name=\"814\">814</a>|Account not found.|  | | <a name=\"815\">815</a>|Abor not found.|  | | <a name=\"816\">816</a>|Abor Configuration not found.|  | | <a name=\"817\">817</a>|Reconciliation mapping not found|  | | <a name=\"818\">818</a>|Attribute type could not be deleted because it doesn't exist.|  | | <a name=\"819\">819</a>|Reconciliation not found.|  | | <a name=\"820\">820</a>|Custodian Account not found.|  | | <a name=\"821\">821</a>|Allocation Failure|  | 
 *
 * The version of the OpenAPI document: 1.0.20
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
    /// Most, if not all, information about contracts is standardised. See, e.g. https://www.cmegroup.com/ for  common codes and similar data. This appears to be in common use by well known market information providers, e.g. Bloomberg and Refinitiv.  There is a lot of overlap with this and FuturesContractDetails but as that is an established DTO we must duplicate a number of fields here
    /// </summary>
    [DataContract(Name = "ExchangeTradedOptionContractDetails")]
    public partial class ExchangeTradedOptionContractDetails : IEquatable<ExchangeTradedOptionContractDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeTradedOptionContractDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExchangeTradedOptionContractDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeTradedOptionContractDetails" /> class.
        /// </summary>
        /// <param name="domCcy">Currency in which the contract is paid. (required).</param>
        /// <param name="strike">The option strike, this can be negative for some options. (required).</param>
        /// <param name="contractSize">Size of a single contract. By default this should be set to 1000 if otherwise unknown and is defaulted to such. (required).</param>
        /// <param name="country">Country (code) for the exchange. (required).</param>
        /// <param name="deliveryType">The delivery type, cash or physical. An option on a future is physically settled if upon exercising the  holder receives a future.    Supported string (enumeration) values are: [Cash, Physical]. (required).</param>
        /// <param name="description">Description of contract (required).</param>
        /// <param name="exchangeCode">Exchange code for contract. This can be any string to uniquely identify the exchange (e.g. Exchange Name, MIC, BBG code). (required).</param>
        /// <param name="exerciseDate">Exercise Date. (required).</param>
        /// <param name="exerciseType">The exercise type, European, American or Bermudan.    Supported string (enumeration) values are: [European, Bermudan, American]. (required).</param>
        /// <param name="optionCode">Option Contract Code, typically one or two letters, e.g. OG &#x3D;&gt; Option on Gold. (required).</param>
        /// <param name="optionType">The option type, Call or Put.    Supported string (enumeration) values are: [Call, Put]. (required).</param>
        /// <param name="underlying">underlying (required).</param>
        /// <param name="underlyingCode">Code of the underlying, for an option on futures this should be the futures code. (required).</param>
        public ExchangeTradedOptionContractDetails(string domCcy = default(string), decimal strike = default(decimal), decimal contractSize = default(decimal), string country = default(string), string deliveryType = default(string), string description = default(string), string exchangeCode = default(string), DateTimeOffset exerciseDate = default(DateTimeOffset), string exerciseType = default(string), string optionCode = default(string), string optionType = default(string), LusidInstrument underlying = default(LusidInstrument), string underlyingCode = default(string))
        {
            // to ensure "domCcy" is required (not null)
            this.DomCcy = domCcy ?? throw new ArgumentNullException("domCcy is a required property for ExchangeTradedOptionContractDetails and cannot be null");
            this.Strike = strike;
            this.ContractSize = contractSize;
            // to ensure "country" is required (not null)
            this.Country = country ?? throw new ArgumentNullException("country is a required property for ExchangeTradedOptionContractDetails and cannot be null");
            // to ensure "deliveryType" is required (not null)
            this.DeliveryType = deliveryType ?? throw new ArgumentNullException("deliveryType is a required property for ExchangeTradedOptionContractDetails and cannot be null");
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for ExchangeTradedOptionContractDetails and cannot be null");
            // to ensure "exchangeCode" is required (not null)
            this.ExchangeCode = exchangeCode ?? throw new ArgumentNullException("exchangeCode is a required property for ExchangeTradedOptionContractDetails and cannot be null");
            this.ExerciseDate = exerciseDate;
            // to ensure "exerciseType" is required (not null)
            this.ExerciseType = exerciseType ?? throw new ArgumentNullException("exerciseType is a required property for ExchangeTradedOptionContractDetails and cannot be null");
            // to ensure "optionCode" is required (not null)
            this.OptionCode = optionCode ?? throw new ArgumentNullException("optionCode is a required property for ExchangeTradedOptionContractDetails and cannot be null");
            // to ensure "optionType" is required (not null)
            this.OptionType = optionType ?? throw new ArgumentNullException("optionType is a required property for ExchangeTradedOptionContractDetails and cannot be null");
            // to ensure "underlying" is required (not null)
            this.Underlying = underlying ?? throw new ArgumentNullException("underlying is a required property for ExchangeTradedOptionContractDetails and cannot be null");
            // to ensure "underlyingCode" is required (not null)
            this.UnderlyingCode = underlyingCode ?? throw new ArgumentNullException("underlyingCode is a required property for ExchangeTradedOptionContractDetails and cannot be null");
        }

        /// <summary>
        /// Currency in which the contract is paid.
        /// </summary>
        /// <value>Currency in which the contract is paid.</value>
        [DataMember(Name = "domCcy", IsRequired = true, EmitDefaultValue = false)]
        public string DomCcy { get; set; }

        /// <summary>
        /// The option strike, this can be negative for some options.
        /// </summary>
        /// <value>The option strike, this can be negative for some options.</value>
        [DataMember(Name = "strike", IsRequired = true, EmitDefaultValue = true)]
        public decimal Strike { get; set; }

        /// <summary>
        /// Size of a single contract. By default this should be set to 1000 if otherwise unknown and is defaulted to such.
        /// </summary>
        /// <value>Size of a single contract. By default this should be set to 1000 if otherwise unknown and is defaulted to such.</value>
        [DataMember(Name = "contractSize", IsRequired = true, EmitDefaultValue = true)]
        public decimal ContractSize { get; set; }

        /// <summary>
        /// Country (code) for the exchange.
        /// </summary>
        /// <value>Country (code) for the exchange.</value>
        [DataMember(Name = "country", IsRequired = true, EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// The delivery type, cash or physical. An option on a future is physically settled if upon exercising the  holder receives a future.    Supported string (enumeration) values are: [Cash, Physical].
        /// </summary>
        /// <value>The delivery type, cash or physical. An option on a future is physically settled if upon exercising the  holder receives a future.    Supported string (enumeration) values are: [Cash, Physical].</value>
        [DataMember(Name = "deliveryType", IsRequired = true, EmitDefaultValue = false)]
        public string DeliveryType { get; set; }

        /// <summary>
        /// Description of contract
        /// </summary>
        /// <value>Description of contract</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Exchange code for contract. This can be any string to uniquely identify the exchange (e.g. Exchange Name, MIC, BBG code).
        /// </summary>
        /// <value>Exchange code for contract. This can be any string to uniquely identify the exchange (e.g. Exchange Name, MIC, BBG code).</value>
        [DataMember(Name = "exchangeCode", IsRequired = true, EmitDefaultValue = false)]
        public string ExchangeCode { get; set; }

        /// <summary>
        /// Exercise Date.
        /// </summary>
        /// <value>Exercise Date.</value>
        [DataMember(Name = "exerciseDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset ExerciseDate { get; set; }

        /// <summary>
        /// The exercise type, European, American or Bermudan.    Supported string (enumeration) values are: [European, Bermudan, American].
        /// </summary>
        /// <value>The exercise type, European, American or Bermudan.    Supported string (enumeration) values are: [European, Bermudan, American].</value>
        [DataMember(Name = "exerciseType", IsRequired = true, EmitDefaultValue = false)]
        public string ExerciseType { get; set; }

        /// <summary>
        /// Option Contract Code, typically one or two letters, e.g. OG &#x3D;&gt; Option on Gold.
        /// </summary>
        /// <value>Option Contract Code, typically one or two letters, e.g. OG &#x3D;&gt; Option on Gold.</value>
        [DataMember(Name = "optionCode", IsRequired = true, EmitDefaultValue = false)]
        public string OptionCode { get; set; }

        /// <summary>
        /// The option type, Call or Put.    Supported string (enumeration) values are: [Call, Put].
        /// </summary>
        /// <value>The option type, Call or Put.    Supported string (enumeration) values are: [Call, Put].</value>
        [DataMember(Name = "optionType", IsRequired = true, EmitDefaultValue = false)]
        public string OptionType { get; set; }

        /// <summary>
        /// Gets or Sets Underlying
        /// </summary>
        [DataMember(Name = "underlying", IsRequired = true, EmitDefaultValue = false)]
        public LusidInstrument Underlying { get; set; }

        /// <summary>
        /// Code of the underlying, for an option on futures this should be the futures code.
        /// </summary>
        /// <value>Code of the underlying, for an option on futures this should be the futures code.</value>
        [DataMember(Name = "underlyingCode", IsRequired = true, EmitDefaultValue = false)]
        public string UnderlyingCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExchangeTradedOptionContractDetails {\n");
            sb.Append("  DomCcy: ").Append(DomCcy).Append("\n");
            sb.Append("  Strike: ").Append(Strike).Append("\n");
            sb.Append("  ContractSize: ").Append(ContractSize).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  DeliveryType: ").Append(DeliveryType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExchangeCode: ").Append(ExchangeCode).Append("\n");
            sb.Append("  ExerciseDate: ").Append(ExerciseDate).Append("\n");
            sb.Append("  ExerciseType: ").Append(ExerciseType).Append("\n");
            sb.Append("  OptionCode: ").Append(OptionCode).Append("\n");
            sb.Append("  OptionType: ").Append(OptionType).Append("\n");
            sb.Append("  Underlying: ").Append(Underlying).Append("\n");
            sb.Append("  UnderlyingCode: ").Append(UnderlyingCode).Append("\n");
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
            return this.Equals(input as ExchangeTradedOptionContractDetails);
        }

        /// <summary>
        /// Returns true if ExchangeTradedOptionContractDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeTradedOptionContractDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeTradedOptionContractDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomCcy == input.DomCcy ||
                    (this.DomCcy != null &&
                    this.DomCcy.Equals(input.DomCcy))
                ) && 
                (
                    this.Strike == input.Strike ||
                    this.Strike.Equals(input.Strike)
                ) && 
                (
                    this.ContractSize == input.ContractSize ||
                    this.ContractSize.Equals(input.ContractSize)
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.DeliveryType == input.DeliveryType ||
                    (this.DeliveryType != null &&
                    this.DeliveryType.Equals(input.DeliveryType))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExchangeCode == input.ExchangeCode ||
                    (this.ExchangeCode != null &&
                    this.ExchangeCode.Equals(input.ExchangeCode))
                ) && 
                (
                    this.ExerciseDate == input.ExerciseDate ||
                    (this.ExerciseDate != null &&
                    this.ExerciseDate.Equals(input.ExerciseDate))
                ) && 
                (
                    this.ExerciseType == input.ExerciseType ||
                    (this.ExerciseType != null &&
                    this.ExerciseType.Equals(input.ExerciseType))
                ) && 
                (
                    this.OptionCode == input.OptionCode ||
                    (this.OptionCode != null &&
                    this.OptionCode.Equals(input.OptionCode))
                ) && 
                (
                    this.OptionType == input.OptionType ||
                    (this.OptionType != null &&
                    this.OptionType.Equals(input.OptionType))
                ) && 
                (
                    this.Underlying == input.Underlying ||
                    (this.Underlying != null &&
                    this.Underlying.Equals(input.Underlying))
                ) && 
                (
                    this.UnderlyingCode == input.UnderlyingCode ||
                    (this.UnderlyingCode != null &&
                    this.UnderlyingCode.Equals(input.UnderlyingCode))
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
                if (this.DomCcy != null)
                    hashCode = hashCode * 59 + this.DomCcy.GetHashCode();
                hashCode = hashCode * 59 + this.Strike.GetHashCode();
                hashCode = hashCode * 59 + this.ContractSize.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.DeliveryType != null)
                    hashCode = hashCode * 59 + this.DeliveryType.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExchangeCode != null)
                    hashCode = hashCode * 59 + this.ExchangeCode.GetHashCode();
                if (this.ExerciseDate != null)
                    hashCode = hashCode * 59 + this.ExerciseDate.GetHashCode();
                if (this.ExerciseType != null)
                    hashCode = hashCode * 59 + this.ExerciseType.GetHashCode();
                if (this.OptionCode != null)
                    hashCode = hashCode * 59 + this.OptionCode.GetHashCode();
                if (this.OptionType != null)
                    hashCode = hashCode * 59 + this.OptionType.GetHashCode();
                if (this.Underlying != null)
                    hashCode = hashCode * 59 + this.Underlying.GetHashCode();
                if (this.UnderlyingCode != null)
                    hashCode = hashCode * 59 + this.UnderlyingCode.GetHashCode();
                return hashCode;
            }
        }

    }
}
