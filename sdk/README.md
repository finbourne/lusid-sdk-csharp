<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://www.lusid.com/api*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AborApi* | [**AddDiaryEntry**](docs/AborApi.md#adddiaryentry) | **POST** /api/abor/{scope}/{code}/accountingdiary | [EXPERIMENTAL] AddDiaryEntry: Add a diary entry to the specified Abor.
*AborApi* | [**ClosePeriod**](docs/AborApi.md#closeperiod) | **POST** /api/abor/{scope}/{code}/accountingdiary/$closeperiod | [EXPERIMENTAL] ClosePeriod: Closes or locks the current period for the given Abor.
*AborApi* | [**CreateAbor**](docs/AborApi.md#createabor) | **POST** /api/abor/{scope} | [EXPERIMENTAL] CreateAbor: Create an Abor.
*AborApi* | [**DeleteAbor**](docs/AborApi.md#deleteabor) | **DELETE** /api/abor/{scope}/{code} | [EXPERIMENTAL] DeleteAbor: Delete an Abor.
*AborApi* | [**GetAbor**](docs/AborApi.md#getabor) | **GET** /api/abor/{scope}/{code} | [EXPERIMENTAL] GetAbor: Get Abor.
*AborApi* | [**GetJournalEntryLines**](docs/AborApi.md#getjournalentrylines) | **POST** /api/abor/{scope}/{code}/journalentrylines/$query | [EXPERIMENTAL] GetJournalEntryLines: Get the Journal Entry lines for the given Abor.
*AborApi* | [**GetTrialBalance**](docs/AborApi.md#gettrialbalance) | **POST** /api/abor/{scope}/{code}/trialbalance/$query | [EXPERIMENTAL] GetTrialBalance: Get the Trial balance for the given Abor.
*AborApi* | [**ListAbors**](docs/AborApi.md#listabors) | **GET** /api/abor | [EXPERIMENTAL] ListAbors: List Abors.
*AborApi* | [**ListDiaryEntries**](docs/AborApi.md#listdiaryentries) | **GET** /api/abor/{scope}/{code}/accountingdiary | [EXPERIMENTAL] ListDiaryEntries: List diary entries.
*AborApi* | [**LockPeriod**](docs/AborApi.md#lockperiod) | **POST** /api/abor/{scope}/{code}/accountingdiary/$lockperiod | [EXPERIMENTAL] LockPeriod: Locks the last Closed or given Closed Period.
*AborApi* | [**PatchAbor**](docs/AborApi.md#patchabor) | **PATCH** /api/abor/{scope}/{code} | [EXPERIMENTAL] PatchAbor: Patch Abor.
*AborApi* | [**ReOpenPeriods**](docs/AborApi.md#reopenperiods) | **POST** /api/abor/{scope}/{code}/accountingdiary/$reopenperiods | [EXPERIMENTAL] ReOpenPeriods: Reopen periods from a seed Diary Entry Code or when not specified, the last Closed Period for the given Abor.
*AborApi* | [**UpsertAborProperties**](docs/AborApi.md#upsertaborproperties) | **POST** /api/abor/{scope}/{code}/properties/$upsert | [EXPERIMENTAL] UpsertAborProperties: Upsert Abor properties
*AborConfigurationApi* | [**CreateAborConfiguration**](docs/AborConfigurationApi.md#createaborconfiguration) | **POST** /api/aborconfiguration/{scope} | [EXPERIMENTAL] CreateAborConfiguration: Create an AborConfiguration.
*AborConfigurationApi* | [**DeleteAborConfiguration**](docs/AborConfigurationApi.md#deleteaborconfiguration) | **DELETE** /api/aborconfiguration/{scope}/{code} | [EXPERIMENTAL] DeleteAborConfiguration: Delete an AborConfiguration.
*AborConfigurationApi* | [**GetAborConfiguration**](docs/AborConfigurationApi.md#getaborconfiguration) | **GET** /api/aborconfiguration/{scope}/{code} | [EXPERIMENTAL] GetAborConfiguration: Get AborConfiguration.
*AborConfigurationApi* | [**ListAborConfigurations**](docs/AborConfigurationApi.md#listaborconfigurations) | **GET** /api/aborconfiguration | [EXPERIMENTAL] ListAborConfigurations: List AborConfiguration.
*AborConfigurationApi* | [**UpsertAborConfigurationProperties**](docs/AborConfigurationApi.md#upsertaborconfigurationproperties) | **POST** /api/aborconfiguration/{scope}/{code}/properties/$upsert | [EXPERIMENTAL] UpsertAborConfigurationProperties: Upsert AborConfiguration properties
*AddressKeyDefinitionApi* | [**CreateAddressKeyDefinition**](docs/AddressKeyDefinitionApi.md#createaddresskeydefinition) | **POST** /api/addresskeydefinitions | [EARLY ACCESS] CreateAddressKeyDefinition: Create an AddressKeyDefinition.
*AddressKeyDefinitionApi* | [**GetAddressKeyDefinition**](docs/AddressKeyDefinitionApi.md#getaddresskeydefinition) | **GET** /api/addresskeydefinitions/{key} | [EARLY ACCESS] GetAddressKeyDefinition: Get an AddressKeyDefinition.
*AddressKeyDefinitionApi* | [**ListAddressKeyDefinitions**](docs/AddressKeyDefinitionApi.md#listaddresskeydefinitions) | **GET** /api/addresskeydefinitions | [EARLY ACCESS] ListAddressKeyDefinitions: List AddressKeyDefinitions.
*AggregationApi* | [**GenerateConfigurationRecipe**](docs/AggregationApi.md#generateconfigurationrecipe) | **POST** /api/aggregation/{scope}/{code}/$generateconfigurationrecipe | [EXPERIMENTAL] GenerateConfigurationRecipe: Generates a recipe sufficient to perform valuations for the given portfolio.
*AggregationApi* | [**GetQueryableKeys**](docs/AggregationApi.md#getqueryablekeys) | **GET** /api/results/queryable/keys | GetQueryableKeys: Query the set of supported \"addresses\" that can be queried from the aggregation endpoint.
*AggregationApi* | [**GetValuation**](docs/AggregationApi.md#getvaluation) | **POST** /api/aggregation/$valuation | GetValuation: Perform valuation for a list of portfolios and/or portfolio groups
*AggregationApi* | [**GetValuationOfWeightedInstruments**](docs/AggregationApi.md#getvaluationofweightedinstruments) | **POST** /api/aggregation/$valuationinlined | GetValuationOfWeightedInstruments: Perform valuation for an inlined portfolio
*AllocationsApi* | [**DeleteAllocation**](docs/AllocationsApi.md#deleteallocation) | **DELETE** /api/allocations/{scope}/{code} | [EARLY ACCESS] DeleteAllocation: Delete allocation
*AllocationsApi* | [**GetAllocation**](docs/AllocationsApi.md#getallocation) | **GET** /api/allocations/{scope}/{code} | [EARLY ACCESS] GetAllocation: Get Allocation
*AllocationsApi* | [**ListAllocations**](docs/AllocationsApi.md#listallocations) | **GET** /api/allocations | ListAllocations: List Allocations
*AllocationsApi* | [**UpsertAllocations**](docs/AllocationsApi.md#upsertallocations) | **POST** /api/allocations | UpsertAllocations: Upsert Allocations
*AmortisationRuleSetsApi* | [**CreateAmortisationRuleSet**](docs/AmortisationRuleSetsApi.md#createamortisationruleset) | **POST** /api/amortisation/rulesets/{scope} | [EXPERIMENTAL] CreateAmortisationRuleSet: Create an amortisation rule set.
*AmortisationRuleSetsApi* | [**DeleteAmortisationRuleset**](docs/AmortisationRuleSetsApi.md#deleteamortisationruleset) | **DELETE** /api/amortisation/rulesets/{scope}/{code} | [EXPERIMENTAL] DeleteAmortisationRuleset: Delete an amortisation rule set.
*AmortisationRuleSetsApi* | [**GetAmortisationRuleSet**](docs/AmortisationRuleSetsApi.md#getamortisationruleset) | **GET** /api/amortisation/rulesets/{scope}/{code} | [EXPERIMENTAL] GetAmortisationRuleSet: Retrieve the definition of a single amortisation rule set
*AmortisationRuleSetsApi* | [**ListAmortisationRuleSets**](docs/AmortisationRuleSetsApi.md#listamortisationrulesets) | **GET** /api/amortisation/rulesets | [EXPERIMENTAL] ListAmortisationRuleSets: List amortisation rule sets.
*AmortisationRuleSetsApi* | [**SetAmortisationRules**](docs/AmortisationRuleSetsApi.md#setamortisationrules) | **PUT** /api/amortisation/rulesets/{scope}/{code}/rules | [EXPERIMENTAL] SetAmortisationRules: Set Amortisation Rules on an existing Amortisation Rule Set.
*AmortisationRuleSetsApi* | [**UpdateAmortisationRuleSetDetails**](docs/AmortisationRuleSetsApi.md#updateamortisationrulesetdetails) | **PUT** /api/amortisation/rulesets/{scope}/{code}/details | [EXPERIMENTAL] UpdateAmortisationRuleSetDetails: Update an amortisation rule set.
*ApplicationMetadataApi* | [**GetExcelAddin**](docs/ApplicationMetadataApi.md#getexceladdin) | **GET** /api/metadata/downloads/exceladdin | GetExcelAddin: Download Excel Addin
*ApplicationMetadataApi* | [**GetLusidVersions**](docs/ApplicationMetadataApi.md#getlusidversions) | **GET** /api/metadata/versions | GetLusidVersions: Get LUSID versions
*ApplicationMetadataApi* | [**ListAccessControlledResources**](docs/ApplicationMetadataApi.md#listaccesscontrolledresources) | **GET** /api/metadata/access/resources | ListAccessControlledResources: Get resources available for access control
*BlocksApi* | [**DeleteBlock**](docs/BlocksApi.md#deleteblock) | **DELETE** /api/blocks/{scope}/{code} | [EARLY ACCESS] DeleteBlock: Delete block
*BlocksApi* | [**GetBlock**](docs/BlocksApi.md#getblock) | **GET** /api/blocks/{scope}/{code} | [EARLY ACCESS] GetBlock: Get Block
*BlocksApi* | [**ListBlocks**](docs/BlocksApi.md#listblocks) | **GET** /api/blocks | [EARLY ACCESS] ListBlocks: List Blocks
*BlocksApi* | [**UpsertBlocks**](docs/BlocksApi.md#upsertblocks) | **POST** /api/blocks | [EARLY ACCESS] UpsertBlocks: Upsert Block
*CalendarsApi* | [**AddBusinessDaysToDate**](docs/CalendarsApi.md#addbusinessdaystodate) | **POST** /api/calendars/businessday/{scope}/add | [EARLY ACCESS] AddBusinessDaysToDate: Adds the requested number of Business Days to the provided date.
*CalendarsApi* | [**AddDateToCalendar**](docs/CalendarsApi.md#adddatetocalendar) | **PUT** /api/calendars/generic/{scope}/{code}/dates | AddDateToCalendar: Add a date to a calendar
*CalendarsApi* | [**BatchUpsertDatesForCalendar**](docs/CalendarsApi.md#batchupsertdatesforcalendar) | **POST** /api/calendars/generic/{scope}/{code}/dates/$batchUpsert | BatchUpsertDatesForCalendar: Batch upsert dates to a calendar
*CalendarsApi* | [**CreateCalendar**](docs/CalendarsApi.md#createcalendar) | **POST** /api/calendars/generic | [EARLY ACCESS] CreateCalendar: Create a calendar in its generic form
*CalendarsApi* | [**DeleteCalendar**](docs/CalendarsApi.md#deletecalendar) | **DELETE** /api/calendars/generic/{scope}/{code} | [EARLY ACCESS] DeleteCalendar: Delete a calendar
*CalendarsApi* | [**DeleteDateFromCalendar**](docs/CalendarsApi.md#deletedatefromcalendar) | **DELETE** /api/calendars/generic/{scope}/{code}/dates/{dateId} | DeleteDateFromCalendar: Remove a date from a calendar
*CalendarsApi* | [**DeleteDatesFromCalendar**](docs/CalendarsApi.md#deletedatesfromcalendar) | **POST** /api/calendars/generic/{scope}/{code}/dates/$delete | DeleteDatesFromCalendar: Delete dates from a calendar
*CalendarsApi* | [**GenerateSchedule**](docs/CalendarsApi.md#generateschedule) | **POST** /api/calendars/schedule/{scope} | [EARLY ACCESS] GenerateSchedule: Generate an ordered schedule of dates.
*CalendarsApi* | [**GetCalendar**](docs/CalendarsApi.md#getcalendar) | **GET** /api/calendars/generic/{scope}/{code} | GetCalendar: Get a calendar in its generic form
*CalendarsApi* | [**GetDates**](docs/CalendarsApi.md#getdates) | **GET** /api/calendars/generic/{scope}/{code}/dates | [EARLY ACCESS] GetDates: Get dates for a specific calendar
*CalendarsApi* | [**IsBusinessDateTime**](docs/CalendarsApi.md#isbusinessdatetime) | **GET** /api/calendars/businessday/{scope}/{code} | [EARLY ACCESS] IsBusinessDateTime: Check whether a DateTime is a \"Business DateTime\"
*CalendarsApi* | [**ListCalendars**](docs/CalendarsApi.md#listcalendars) | **GET** /api/calendars/generic | [EARLY ACCESS] ListCalendars: List Calendars
*CalendarsApi* | [**ListCalendarsInScope**](docs/CalendarsApi.md#listcalendarsinscope) | **GET** /api/calendars/generic/{scope} | ListCalendarsInScope: List all calenders in a specified scope
*CalendarsApi* | [**UpdateCalendar**](docs/CalendarsApi.md#updatecalendar) | **POST** /api/calendars/generic/{scope}/{code} | [EARLY ACCESS] UpdateCalendar: Update a calendar
*ChartOfAccountsApi* | [**CreateChartOfAccounts**](docs/ChartOfAccountsApi.md#createchartofaccounts) | **POST** /api/chartofaccounts/{scope} | [EXPERIMENTAL] CreateChartOfAccounts: Create a Chart of Accounts
*ChartOfAccountsApi* | [**CreateCleardownModule**](docs/ChartOfAccountsApi.md#createcleardownmodule) | **POST** /api/chartofaccounts/{scope}/{code}/cleardownmodules | [EXPERIMENTAL] CreateCleardownModule: Create a Cleardown Module
*ChartOfAccountsApi* | [**CreateGeneralLedgerProfile**](docs/ChartOfAccountsApi.md#creategeneralledgerprofile) | **POST** /api/chartofaccounts/{scope}/{code}/generalledgerprofile | [EXPERIMENTAL] CreateGeneralLedgerProfile: Create a General Ledger Profile.
*ChartOfAccountsApi* | [**CreatePostingModule**](docs/ChartOfAccountsApi.md#createpostingmodule) | **POST** /api/chartofaccounts/{scope}/{code}/postingmodules | [EXPERIMENTAL] CreatePostingModule: Create a Posting Module
*ChartOfAccountsApi* | [**DeleteAccounts**](docs/ChartOfAccountsApi.md#deleteaccounts) | **POST** /api/chartofaccounts/{scope}/{code}/accounts/$delete | [EXPERIMENTAL] DeleteAccounts: Soft or hard delete multiple accounts
*ChartOfAccountsApi* | [**DeleteChartOfAccounts**](docs/ChartOfAccountsApi.md#deletechartofaccounts) | **DELETE** /api/chartofaccounts/{scope}/{code} | [EXPERIMENTAL] DeleteChartOfAccounts: Delete a Chart of Accounts
*ChartOfAccountsApi* | [**DeleteCleardownModule**](docs/ChartOfAccountsApi.md#deletecleardownmodule) | **DELETE** /api/chartofaccounts/{scope}/{code}/cleardownmodules/{cleardownModuleCode} | [EXPERIMENTAL] DeleteCleardownModule: Delete a Cleardown Module.
*ChartOfAccountsApi* | [**DeleteGeneralLedgerProfile**](docs/ChartOfAccountsApi.md#deletegeneralledgerprofile) | **DELETE** /api/chartofaccounts/{scope}/{code}/generalledgerprofile/{generalLedgerProfileCode} | [EXPERIMENTAL] DeleteGeneralLedgerProfile: Delete a General Ledger Profile.
*ChartOfAccountsApi* | [**DeletePostingModule**](docs/ChartOfAccountsApi.md#deletepostingmodule) | **DELETE** /api/chartofaccounts/{scope}/{code}/postingmodules/{postingModuleCode} | [EXPERIMENTAL] DeletePostingModule: Delete a Posting Module.
*ChartOfAccountsApi* | [**GetAccount**](docs/ChartOfAccountsApi.md#getaccount) | **GET** /api/chartofaccounts/{scope}/{code}/accounts/{accountCode} | [EXPERIMENTAL] GetAccount: Get Account
*ChartOfAccountsApi* | [**GetChartOfAccounts**](docs/ChartOfAccountsApi.md#getchartofaccounts) | **GET** /api/chartofaccounts/{scope}/{code} | [EXPERIMENTAL] GetChartOfAccounts: Get ChartOfAccounts
*ChartOfAccountsApi* | [**GetCleardownModule**](docs/ChartOfAccountsApi.md#getcleardownmodule) | **GET** /api/chartofaccounts/{scope}/{code}/cleardownmodules/{cleardownModuleCode} | [EXPERIMENTAL] GetCleardownModule: Get a Cleardown Module
*ChartOfAccountsApi* | [**GetGeneralLedgerProfile**](docs/ChartOfAccountsApi.md#getgeneralledgerprofile) | **GET** /api/chartofaccounts/{scope}/{code}/generalledgerprofile/{generalLedgerProfileCode} | [EXPERIMENTAL] GetGeneralLedgerProfile: Get a General Ledger Profile.
*ChartOfAccountsApi* | [**GetPostingModule**](docs/ChartOfAccountsApi.md#getpostingmodule) | **GET** /api/chartofaccounts/{scope}/{code}/postingmodules/{postingModuleCode} | [EXPERIMENTAL] GetPostingModule: Get a Posting Module
*ChartOfAccountsApi* | [**ListAccounts**](docs/ChartOfAccountsApi.md#listaccounts) | **GET** /api/chartofaccounts/{scope}/{code}/accounts | [EXPERIMENTAL] ListAccounts: List Accounts
*ChartOfAccountsApi* | [**ListChartsOfAccounts**](docs/ChartOfAccountsApi.md#listchartsofaccounts) | **GET** /api/chartofaccounts | [EXPERIMENTAL] ListChartsOfAccounts: List Charts of Accounts
*ChartOfAccountsApi* | [**ListCleardownModuleRules**](docs/ChartOfAccountsApi.md#listcleardownmodulerules) | **GET** /api/chartofaccounts/{scope}/{code}/cleardownmodules/{cleardownModuleCode}/cleardownrules | [EXPERIMENTAL] ListCleardownModuleRules: List Cleardown Module Rules
*ChartOfAccountsApi* | [**ListCleardownModules**](docs/ChartOfAccountsApi.md#listcleardownmodules) | **GET** /api/chartofaccounts/{scope}/{code}/cleardownmodules | [EXPERIMENTAL] ListCleardownModules: List Cleardown Modules
*ChartOfAccountsApi* | [**ListGeneralLedgerProfiles**](docs/ChartOfAccountsApi.md#listgeneralledgerprofiles) | **GET** /api/chartofaccounts/{scope}/{code}/generalledgerprofile | [EXPERIMENTAL] ListGeneralLedgerProfiles: List General Ledger Profiles.
*ChartOfAccountsApi* | [**ListPostingModuleRules**](docs/ChartOfAccountsApi.md#listpostingmodulerules) | **GET** /api/chartofaccounts/{scope}/{code}/postingmodules/{postingModuleCode}/postingrules | [EXPERIMENTAL] ListPostingModuleRules: List Posting Module Rules
*ChartOfAccountsApi* | [**ListPostingModules**](docs/ChartOfAccountsApi.md#listpostingmodules) | **GET** /api/chartofaccounts/{scope}/{code}/postingmodules | [EXPERIMENTAL] ListPostingModules: List Posting Modules
*ChartOfAccountsApi* | [**PatchChartOfAccounts**](docs/ChartOfAccountsApi.md#patchchartofaccounts) | **PATCH** /api/chartofaccounts/{scope}/{code} | [EXPERIMENTAL] PatchChartOfAccounts: Patch a Chart of Accounts.
*ChartOfAccountsApi* | [**PatchCleardownModule**](docs/ChartOfAccountsApi.md#patchcleardownmodule) | **PATCH** /api/chartofaccounts/{scope}/{code}/cleardownmodules/{cleardownModuleCode} | [EXPERIMENTAL] PatchCleardownModule: Patch a Cleardown Module
*ChartOfAccountsApi* | [**PatchPostingModule**](docs/ChartOfAccountsApi.md#patchpostingmodule) | **PATCH** /api/chartofaccounts/{scope}/{code}/postingmodules/{postingModuleCode} | [EXPERIMENTAL] PatchPostingModule: Patch a Posting Module
*ChartOfAccountsApi* | [**SetCleardownModuleDetails**](docs/ChartOfAccountsApi.md#setcleardownmoduledetails) | **PUT** /api/chartofaccounts/{scope}/{code}/cleardownmodules/{cleardownModuleCode} | [EXPERIMENTAL] SetCleardownModuleDetails: Set the details of a Cleardown Module
*ChartOfAccountsApi* | [**SetCleardownModuleRules**](docs/ChartOfAccountsApi.md#setcleardownmodulerules) | **PUT** /api/chartofaccounts/{scope}/{code}/cleardownmodules/{cleardownModuleCode}/cleardownrules | [EXPERIMENTAL] SetCleardownModuleRules: Set the rules of a Cleardown Module
*ChartOfAccountsApi* | [**SetGeneralLedgerProfileMappings**](docs/ChartOfAccountsApi.md#setgeneralledgerprofilemappings) | **PUT** /api/chartofaccounts/{scope}/{code}/generalledgerprofile/{generalLedgerProfileCode}/mappings | [EXPERIMENTAL] SetGeneralLedgerProfileMappings: Sets the General Ledger Profile Mappings.
*ChartOfAccountsApi* | [**SetPostingModuleDetails**](docs/ChartOfAccountsApi.md#setpostingmoduledetails) | **PUT** /api/chartofaccounts/{scope}/{code}/postingmodules/{postingModuleCode} | [EXPERIMENTAL] SetPostingModuleDetails: Set the details of a Posting Module
*ChartOfAccountsApi* | [**SetPostingModuleRules**](docs/ChartOfAccountsApi.md#setpostingmodulerules) | **PUT** /api/chartofaccounts/{scope}/{code}/postingmodules/{postingModuleCode}/postingrules | [EXPERIMENTAL] SetPostingModuleRules: Set the rules of a Posting Module
*ChartOfAccountsApi* | [**UpsertAccountProperties**](docs/ChartOfAccountsApi.md#upsertaccountproperties) | **POST** /api/chartofaccounts/{scope}/{code}/accounts/{accountCode}/properties/$upsert | [EXPERIMENTAL] UpsertAccountProperties: Upsert account properties
*ChartOfAccountsApi* | [**UpsertAccounts**](docs/ChartOfAccountsApi.md#upsertaccounts) | **POST** /api/chartofaccounts/{scope}/{code}/accounts | [EXPERIMENTAL] UpsertAccounts: Upsert Accounts
*ChartOfAccountsApi* | [**UpsertChartOfAccountsProperties**](docs/ChartOfAccountsApi.md#upsertchartofaccountsproperties) | **POST** /api/chartofaccounts/{scope}/{code}/properties/$upsert | [EXPERIMENTAL] UpsertChartOfAccountsProperties: Upsert Chart of Accounts properties
*ComplexMarketDataApi* | [**DeleteComplexMarketData**](docs/ComplexMarketDataApi.md#deletecomplexmarketdata) | **POST** /api/complexmarketdata/{scope}/$delete | [EARLY ACCESS] DeleteComplexMarketData: Delete one or more items of complex market data, assuming they are present.
*ComplexMarketDataApi* | [**GetComplexMarketData**](docs/ComplexMarketDataApi.md#getcomplexmarketdata) | **POST** /api/complexmarketdata/{scope}/$get | [EARLY ACCESS] GetComplexMarketData: Get complex market data
*ComplexMarketDataApi* | [**ListComplexMarketData**](docs/ComplexMarketDataApi.md#listcomplexmarketdata) | **GET** /api/complexmarketdata | [EXPERIMENTAL] ListComplexMarketData: List the set of ComplexMarketData
*ComplexMarketDataApi* | [**UpsertComplexMarketData**](docs/ComplexMarketDataApi.md#upsertcomplexmarketdata) | **POST** /api/complexmarketdata/{scope} | UpsertComplexMarketData: Upsert a set of complex market data items. This creates or updates the data in Lusid.
*ComplianceApi* | [**CreateComplianceTemplate**](docs/ComplianceApi.md#createcompliancetemplate) | **POST** /api/compliance/templates/{scope} | [EARLY ACCESS] CreateComplianceTemplate: Create a Compliance Rule Template
*ComplianceApi* | [**DeleteComplianceRule**](docs/ComplianceApi.md#deletecompliancerule) | **DELETE** /api/compliance/rules/{scope}/{code} | [EARLY ACCESS] DeleteComplianceRule: Delete compliance rule.
*ComplianceApi* | [**DeleteComplianceTemplate**](docs/ComplianceApi.md#deletecompliancetemplate) | **DELETE** /api/compliance/templates/{scope}/{code} | [EARLY ACCESS] DeleteComplianceTemplate: Delete a ComplianceRuleTemplate
*ComplianceApi* | [**GetComplianceRule**](docs/ComplianceApi.md#getcompliancerule) | **GET** /api/compliance/rules/{scope}/{code} | [EARLY ACCESS] GetComplianceRule: Get compliance rule.
*ComplianceApi* | [**GetComplianceRuleResult**](docs/ComplianceApi.md#getcomplianceruleresult) | **GET** /api/compliance/runs/summary/{runScope}/{runCode}/{ruleScope}/{ruleCode} | [EARLY ACCESS] GetComplianceRuleResult: Get detailed results for a specific rule within a compliance run.
*ComplianceApi* | [**GetComplianceTemplate**](docs/ComplianceApi.md#getcompliancetemplate) | **GET** /api/compliance/templates/{scope}/{code} | [EARLY ACCESS] GetComplianceTemplate: Get the requested compliance template.
*ComplianceApi* | [**GetDecoratedComplianceRunSummary**](docs/ComplianceApi.md#getdecoratedcompliancerunsummary) | **GET** /api/compliance/runs/summary/{scope}/{code}/$decorate | [EARLY ACCESS] GetDecoratedComplianceRunSummary: Get decorated summary results for a specific compliance run.
*ComplianceApi* | [**ListComplianceRules**](docs/ComplianceApi.md#listcompliancerules) | **GET** /api/compliance/rules | [EARLY ACCESS] ListComplianceRules: List compliance rules.
*ComplianceApi* | [**ListComplianceRuns**](docs/ComplianceApi.md#listcomplianceruns) | **GET** /api/compliance/runs | [EARLY ACCESS] ListComplianceRuns: List historical compliance run identifiers.
*ComplianceApi* | [**ListComplianceTemplates**](docs/ComplianceApi.md#listcompliancetemplates) | **GET** /api/compliance/templates | [EARLY ACCESS] ListComplianceTemplates: List compliance templates.
*ComplianceApi* | [**RunCompliance**](docs/ComplianceApi.md#runcompliance) | **POST** /api/compliance/runs | [EARLY ACCESS] RunCompliance: Run a compliance check.
*ComplianceApi* | [**RunCompliancePreview**](docs/ComplianceApi.md#runcompliancepreview) | **POST** /api/compliance/preview/runs | [EARLY ACCESS] RunCompliancePreview: Run a compliance check.
*ComplianceApi* | [**UpdateComplianceTemplate**](docs/ComplianceApi.md#updatecompliancetemplate) | **PUT** /api/compliance/templates/{scope}/{code} | [EARLY ACCESS] UpdateComplianceTemplate: Update a ComplianceRuleTemplate
*ComplianceApi* | [**UpsertComplianceRule**](docs/ComplianceApi.md#upsertcompliancerule) | **POST** /api/compliance/rules | [EARLY ACCESS] UpsertComplianceRule: Upsert a compliance rule.
*ComplianceApi* | [**UpsertComplianceRunSummary**](docs/ComplianceApi.md#upsertcompliancerunsummary) | **POST** /api/compliance/runs/summary | [EARLY ACCESS] UpsertComplianceRunSummary: Upsert a compliance run summary.
*ConfigurationRecipeApi* | [**DeleteConfigurationRecipe**](docs/ConfigurationRecipeApi.md#deleteconfigurationrecipe) | **DELETE** /api/recipes/{scope}/{code} | DeleteConfigurationRecipe: Delete a Configuration Recipe, assuming that it is present.
*ConfigurationRecipeApi* | [**DeleteRecipeComposer**](docs/ConfigurationRecipeApi.md#deleterecipecomposer) | **DELETE** /api/recipes/composer/{scope}/{code} | [EXPERIMENTAL] DeleteRecipeComposer: Delete a Recipe Composer, assuming that it is present.
*ConfigurationRecipeApi* | [**GetConfigurationRecipe**](docs/ConfigurationRecipeApi.md#getconfigurationrecipe) | **GET** /api/recipes/{scope}/{code} | GetConfigurationRecipe: Get Configuration Recipe
*ConfigurationRecipeApi* | [**GetDerivedRecipe**](docs/ConfigurationRecipeApi.md#getderivedrecipe) | **GET** /api/recipes/derived/{scope}/{code} | [EXPERIMENTAL] GetDerivedRecipe: Get Configuration Recipe either from the store or expanded from a Recipe Composer.
*ConfigurationRecipeApi* | [**GetRecipeComposer**](docs/ConfigurationRecipeApi.md#getrecipecomposer) | **GET** /api/recipes/composer/{scope}/{code} | [EXPERIMENTAL] GetRecipeComposer: Get Recipe Composer
*ConfigurationRecipeApi* | [**GetRecipeComposerResolvedInline**](docs/ConfigurationRecipeApi.md#getrecipecomposerresolvedinline) | **POST** /api/recipes/composer/resolvedinline$ | [EXPERIMENTAL] GetRecipeComposerResolvedInline: Given a Recipe Composer, this endpoint expands into a Configuration Recipe without persistence. Primarily used for testing purposes.
*ConfigurationRecipeApi* | [**ListConfigurationRecipes**](docs/ConfigurationRecipeApi.md#listconfigurationrecipes) | **GET** /api/recipes | ListConfigurationRecipes: List the set of Configuration Recipes
*ConfigurationRecipeApi* | [**ListDerivedRecipes**](docs/ConfigurationRecipeApi.md#listderivedrecipes) | **GET** /api/recipes/derived | [EXPERIMENTAL] ListDerivedRecipes: List the complete set of all Configuration Recipes, both from the configuration recipe store and also from expanded recipe composers.
*ConfigurationRecipeApi* | [**ListRecipeComposers**](docs/ConfigurationRecipeApi.md#listrecipecomposers) | **GET** /api/recipes/composer | [EXPERIMENTAL] ListRecipeComposers: List the set of Recipe Composers
*ConfigurationRecipeApi* | [**UpsertConfigurationRecipe**](docs/ConfigurationRecipeApi.md#upsertconfigurationrecipe) | **POST** /api/recipes | UpsertConfigurationRecipe: Upsert a Configuration Recipe. This creates or updates the data in Lusid.
*ConfigurationRecipeApi* | [**UpsertRecipeComposer**](docs/ConfigurationRecipeApi.md#upsertrecipecomposer) | **POST** /api/recipes/composer | [EXPERIMENTAL] UpsertRecipeComposer: Upsert a Recipe Composer. This creates or updates the data in Lusid.
*ConventionsApi* | [**DeleteCdsFlowConventions**](docs/ConventionsApi.md#deletecdsflowconventions) | **DELETE** /api/conventions/credit/conventions/{scope}/{code} | [BETA] DeleteCdsFlowConventions: Delete the CDS Flow Conventions of given scope and code, assuming that it is present.
*ConventionsApi* | [**DeleteFlowConventions**](docs/ConventionsApi.md#deleteflowconventions) | **DELETE** /api/conventions/rates/flowconventions/{scope}/{code} | [BETA] DeleteFlowConventions: Delete the Flow Conventions of given scope and code, assuming that it is present.
*ConventionsApi* | [**DeleteIndexConvention**](docs/ConventionsApi.md#deleteindexconvention) | **DELETE** /api/conventions/rates/indexconventions/{scope}/{code} | [BETA] DeleteIndexConvention: Delete the Index Convention of given scope and code, assuming that it is present.
*ConventionsApi* | [**GetCdsFlowConventions**](docs/ConventionsApi.md#getcdsflowconventions) | **GET** /api/conventions/credit/conventions/{scope}/{code} | [BETA] GetCdsFlowConventions: Get CDS Flow Conventions
*ConventionsApi* | [**GetFlowConventions**](docs/ConventionsApi.md#getflowconventions) | **GET** /api/conventions/rates/flowconventions/{scope}/{code} | [BETA] GetFlowConventions: Get Flow Conventions
*ConventionsApi* | [**GetIndexConvention**](docs/ConventionsApi.md#getindexconvention) | **GET** /api/conventions/rates/indexconventions/{scope}/{code} | [BETA] GetIndexConvention: Get Index Convention
*ConventionsApi* | [**ListCdsFlowConventions**](docs/ConventionsApi.md#listcdsflowconventions) | **GET** /api/conventions/credit/conventions | [BETA] ListCdsFlowConventions: List the set of CDS Flow Conventions
*ConventionsApi* | [**ListFlowConventions**](docs/ConventionsApi.md#listflowconventions) | **GET** /api/conventions/rates/flowconventions | [BETA] ListFlowConventions: List the set of Flow Conventions
*ConventionsApi* | [**ListIndexConvention**](docs/ConventionsApi.md#listindexconvention) | **GET** /api/conventions/rates/indexconventions | [BETA] ListIndexConvention: List the set of Index Conventions
*ConventionsApi* | [**UpsertCdsFlowConventions**](docs/ConventionsApi.md#upsertcdsflowconventions) | **POST** /api/conventions/credit/conventions | [BETA] UpsertCdsFlowConventions: Upsert a set of CDS Flow Conventions. This creates or updates the data in Lusid.
*ConventionsApi* | [**UpsertFlowConventions**](docs/ConventionsApi.md#upsertflowconventions) | **POST** /api/conventions/rates/flowconventions | [BETA] UpsertFlowConventions: Upsert Flow Conventions. This creates or updates the data in Lusid.
*ConventionsApi* | [**UpsertIndexConvention**](docs/ConventionsApi.md#upsertindexconvention) | **POST** /api/conventions/rates/indexconventions | [BETA] UpsertIndexConvention: Upsert a set of Index Convention. This creates or updates the data in Lusid.
*CorporateActionSourcesApi* | [**BatchUpsertCorporateActions**](docs/CorporateActionSourcesApi.md#batchupsertcorporateactions) | **POST** /api/corporateactionsources/{scope}/{code}/corporateactions | [EARLY ACCESS] BatchUpsertCorporateActions: Batch upsert corporate actions (instrument transition events) to corporate action source.
*CorporateActionSourcesApi* | [**CreateCorporateActionSource**](docs/CorporateActionSourcesApi.md#createcorporateactionsource) | **POST** /api/corporateactionsources | [EARLY ACCESS] CreateCorporateActionSource: Create corporate action source
*CorporateActionSourcesApi* | [**DeleteCorporateActionSource**](docs/CorporateActionSourcesApi.md#deletecorporateactionsource) | **DELETE** /api/corporateactionsources/{scope}/{code} | [BETA] DeleteCorporateActionSource: Delete corporate actions (instrument transition events) from the corporate action source.
*CorporateActionSourcesApi* | [**DeleteCorporateActions**](docs/CorporateActionSourcesApi.md#deletecorporateactions) | **DELETE** /api/corporateactionsources/{scope}/{code}/corporateactions | [EARLY ACCESS] DeleteCorporateActions: Delete corporate actions
*CorporateActionSourcesApi* | [**DeleteInstrumentEvents**](docs/CorporateActionSourcesApi.md#deleteinstrumentevents) | **DELETE** /api/corporateactionsources/{scope}/{code}/instrumentevents | [EARLY ACCESS] DeleteInstrumentEvents: Delete corporate actions (instrument transition events) from the corporate action source.
*CorporateActionSourcesApi* | [**GetCorporateActions**](docs/CorporateActionSourcesApi.md#getcorporateactions) | **GET** /api/corporateactionsources/{scope}/{code}/corporateactions | [EARLY ACCESS] GetCorporateActions: List corporate actions (instrument transition events) from the corporate action source.
*CorporateActionSourcesApi* | [**GetInstrumentEvents**](docs/CorporateActionSourcesApi.md#getinstrumentevents) | **GET** /api/corporateactionsources/{scope}/{code}/instrumentevents | [EARLY ACCESS] GetInstrumentEvents: Get extrinsic instrument events out of a given corporate actions source.
*CorporateActionSourcesApi* | [**ListCorporateActionSources**](docs/CorporateActionSourcesApi.md#listcorporateactionsources) | **GET** /api/corporateactionsources | [EARLY ACCESS] ListCorporateActionSources: List corporate action sources
*CorporateActionSourcesApi* | [**UpsertInstrumentEvents**](docs/CorporateActionSourcesApi.md#upsertinstrumentevents) | **POST** /api/corporateactionsources/{scope}/{code}/instrumentevents | [EARLY ACCESS] UpsertInstrumentEvents: Upsert instrument events to the provided corporate actions source.
*CounterpartiesApi* | [**DeleteCounterpartyAgreement**](docs/CounterpartiesApi.md#deletecounterpartyagreement) | **DELETE** /api/counterparties/counterpartyagreements/{scope}/{code} | [EARLY ACCESS] DeleteCounterpartyAgreement: Delete the Counterparty Agreement of given scope and code
*CounterpartiesApi* | [**DeleteCreditSupportAnnex**](docs/CounterpartiesApi.md#deletecreditsupportannex) | **DELETE** /api/counterparties/creditsupportannexes/{scope}/{code} | [EARLY ACCESS] DeleteCreditSupportAnnex: Delete the Credit Support Annex of given scope and code
*CounterpartiesApi* | [**GetCounterpartyAgreement**](docs/CounterpartiesApi.md#getcounterpartyagreement) | **GET** /api/counterparties/counterpartyagreements/{scope}/{code} | [EARLY ACCESS] GetCounterpartyAgreement: Get Counterparty Agreement
*CounterpartiesApi* | [**GetCreditSupportAnnex**](docs/CounterpartiesApi.md#getcreditsupportannex) | **GET** /api/counterparties/creditsupportannexes/{scope}/{code} | [EARLY ACCESS] GetCreditSupportAnnex: Get Credit Support Annex
*CounterpartiesApi* | [**ListCounterpartyAgreements**](docs/CounterpartiesApi.md#listcounterpartyagreements) | **GET** /api/counterparties/counterpartyagreements | [EARLY ACCESS] ListCounterpartyAgreements: List the set of Counterparty Agreements
*CounterpartiesApi* | [**ListCreditSupportAnnexes**](docs/CounterpartiesApi.md#listcreditsupportannexes) | **GET** /api/counterparties/creditsupportannexes | [EARLY ACCESS] ListCreditSupportAnnexes: List the set of Credit Support Annexes
*CounterpartiesApi* | [**UpsertCounterpartyAgreement**](docs/CounterpartiesApi.md#upsertcounterpartyagreement) | **POST** /api/counterparties/counterpartyagreements | [EARLY ACCESS] UpsertCounterpartyAgreement: Upsert Counterparty Agreement
*CounterpartiesApi* | [**UpsertCreditSupportAnnex**](docs/CounterpartiesApi.md#upsertcreditsupportannex) | **POST** /api/counterparties/creditsupportannexes | [EARLY ACCESS] UpsertCreditSupportAnnex: Upsert Credit Support Annex
*CustomEntitiesApi* | [**DeleteCustomEntity**](docs/CustomEntitiesApi.md#deletecustomentity) | **DELETE** /api/customentities/{entityType}/{identifierType}/{identifierValue} | DeleteCustomEntity: Delete a Custom Entity instance.
*CustomEntitiesApi* | [**DeleteCustomEntityAccessMetadata**](docs/CustomEntitiesApi.md#deletecustomentityaccessmetadata) | **DELETE** /api/customentities/{entityType}/{identifierType}/{identifierValue}/metadata/{metadataKey} | [EARLY ACCESS] DeleteCustomEntityAccessMetadata: Delete a Custom Entity Access Metadata entry
*CustomEntitiesApi* | [**GetAllCustomEntityAccessMetadata**](docs/CustomEntitiesApi.md#getallcustomentityaccessmetadata) | **GET** /api/customentities/{entityType}/{identifierType}/{identifierValue}/metadata | [EARLY ACCESS] GetAllCustomEntityAccessMetadata: Get all the Access Metadata rules for a Custom Entity
*CustomEntitiesApi* | [**GetCustomEntity**](docs/CustomEntitiesApi.md#getcustomentity) | **GET** /api/customentities/{entityType}/{identifierType}/{identifierValue} | GetCustomEntity: Get a Custom Entity instance.
*CustomEntitiesApi* | [**GetCustomEntityAccessMetadataByKey**](docs/CustomEntitiesApi.md#getcustomentityaccessmetadatabykey) | **GET** /api/customentities/{entityType}/{identifierType}/{identifierValue}/metadata/{metadataKey} | [EARLY ACCESS] GetCustomEntityAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Custom Entity
*CustomEntitiesApi* | [**GetCustomEntityRelationships**](docs/CustomEntitiesApi.md#getcustomentityrelationships) | **GET** /api/customentities/{entityType}/{identifierType}/{identifierValue}/relationships | [EARLY ACCESS] GetCustomEntityRelationships: Get Relationships for Custom Entity
*CustomEntitiesApi* | [**ListCustomEntities**](docs/CustomEntitiesApi.md#listcustomentities) | **GET** /api/customentities/{entityType} | ListCustomEntities: List Custom Entities of the specified entityType.
*CustomEntitiesApi* | [**PatchCustomEntityAccessMetadata**](docs/CustomEntitiesApi.md#patchcustomentityaccessmetadata) | **PATCH** /api/customentities/{entityType}/{identifierType}/{identifierValue}/metadata | [EARLY ACCESS] PatchCustomEntityAccessMetadata: Patch Access Metadata rules for a Custom Entity.
*CustomEntitiesApi* | [**UpsertCustomEntities**](docs/CustomEntitiesApi.md#upsertcustomentities) | **POST** /api/customentities/{entityType}/$batchUpsert | [EARLY ACCESS] UpsertCustomEntities: Batch upsert instances of Custom Entities
*CustomEntitiesApi* | [**UpsertCustomEntity**](docs/CustomEntitiesApi.md#upsertcustomentity) | **POST** /api/customentities/{entityType} | UpsertCustomEntity: Upsert a Custom Entity instance
*CustomEntitiesApi* | [**UpsertCustomEntityAccessMetadata**](docs/CustomEntitiesApi.md#upsertcustomentityaccessmetadata) | **PUT** /api/customentities/{entityType}/{identifierType}/{identifierValue}/metadata/{metadataKey} | [EARLY ACCESS] UpsertCustomEntityAccessMetadata: Upsert a Custom Entity Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.
*CustomEntityDefinitionsApi* | [**CreateCustomEntityDefinition**](docs/CustomEntityDefinitionsApi.md#createcustomentitydefinition) | **POST** /api/customentities/entitytypes | [EARLY ACCESS] CreateCustomEntityDefinition: Define a new Custom Entity type.
*CustomEntityDefinitionsApi* | [**GetDefinition**](docs/CustomEntityDefinitionsApi.md#getdefinition) | **GET** /api/customentities/entitytypes/{entityType} | [EARLY ACCESS] GetDefinition: Get a Custom Entity type definition.
*CustomEntityDefinitionsApi* | [**ListCustomEntityDefinitions**](docs/CustomEntityDefinitionsApi.md#listcustomentitydefinitions) | **GET** /api/customentities/entitytypes | [EARLY ACCESS] ListCustomEntityDefinitions: List the Custom Entity type definitions
*CustomEntityDefinitionsApi* | [**UpdateCustomEntityDefinition**](docs/CustomEntityDefinitionsApi.md#updatecustomentitydefinition) | **PUT** /api/customentities/entitytypes/{entityType} | [EARLY ACCESS] UpdateCustomEntityDefinition: Modify an existing Custom Entity type.
*CustomEntityTypesApi* | [**CreateCustomEntityType**](docs/CustomEntityTypesApi.md#createcustomentitytype) | **POST** /api/customentitytypes | [EARLY ACCESS] CreateCustomEntityType: Define a new Custom Entity Type.
*CustomEntityTypesApi* | [**GetCustomEntityType**](docs/CustomEntityTypesApi.md#getcustomentitytype) | **GET** /api/customentitytypes/{entityType} | [EARLY ACCESS] GetCustomEntityType: Get a Custom Entity Type.
*CustomEntityTypesApi* | [**ListCustomEntityTypes**](docs/CustomEntityTypesApi.md#listcustomentitytypes) | **GET** /api/customentitytypes | [EARLY ACCESS] ListCustomEntityTypes: List Custom Entity Types.
*CustomEntityTypesApi* | [**UpdateCustomEntityType**](docs/CustomEntityTypesApi.md#updatecustomentitytype) | **PUT** /api/customentitytypes/{entityType} | [EARLY ACCESS] UpdateCustomEntityType: Modify an existing Custom Entity Type.
*CutLabelDefinitionsApi* | [**CreateCutLabelDefinition**](docs/CutLabelDefinitionsApi.md#createcutlabeldefinition) | **POST** /api/systemconfiguration/cutlabels | CreateCutLabelDefinition: Create a Cut Label
*CutLabelDefinitionsApi* | [**DeleteCutLabelDefinition**](docs/CutLabelDefinitionsApi.md#deletecutlabeldefinition) | **DELETE** /api/systemconfiguration/cutlabels/{code} | DeleteCutLabelDefinition: Delete a Cut Label
*CutLabelDefinitionsApi* | [**GetCutLabelDefinition**](docs/CutLabelDefinitionsApi.md#getcutlabeldefinition) | **GET** /api/systemconfiguration/cutlabels/{code} | GetCutLabelDefinition: Get a Cut Label
*CutLabelDefinitionsApi* | [**ListCutLabelDefinitions**](docs/CutLabelDefinitionsApi.md#listcutlabeldefinitions) | **GET** /api/systemconfiguration/cutlabels | ListCutLabelDefinitions: List Existing Cut Labels
*CutLabelDefinitionsApi* | [**UpdateCutLabelDefinition**](docs/CutLabelDefinitionsApi.md#updatecutlabeldefinition) | **PUT** /api/systemconfiguration/cutlabels/{code} | UpdateCutLabelDefinition: Update a Cut Label
*DataTypesApi* | [**CreateDataType**](docs/DataTypesApi.md#createdatatype) | **POST** /api/datatypes | [EARLY ACCESS] CreateDataType: Create data type definition
*DataTypesApi* | [**DeleteDataType**](docs/DataTypesApi.md#deletedatatype) | **DELETE** /api/datatypes/{scope}/{code} | DeleteDataType: Delete a data type definition.
*DataTypesApi* | [**GetDataType**](docs/DataTypesApi.md#getdatatype) | **GET** /api/datatypes/{scope}/{code} | GetDataType: Get data type definition
*DataTypesApi* | [**GetUnitsFromDataType**](docs/DataTypesApi.md#getunitsfromdatatype) | **GET** /api/datatypes/{scope}/{code}/units | [EARLY ACCESS] GetUnitsFromDataType: Get units from data type
*DataTypesApi* | [**ListDataTypeSummaries**](docs/DataTypesApi.md#listdatatypesummaries) | **GET** /api/datatypes | [EARLY ACCESS] ListDataTypeSummaries: List all data type summaries, without the reference data
*DataTypesApi* | [**ListDataTypes**](docs/DataTypesApi.md#listdatatypes) | **GET** /api/datatypes/{scope} | ListDataTypes: List data types
*DataTypesApi* | [**UpdateDataType**](docs/DataTypesApi.md#updatedatatype) | **PUT** /api/datatypes/{scope}/{code} | [EARLY ACCESS] UpdateDataType: Update data type definition
*DataTypesApi* | [**UpdateReferenceData**](docs/DataTypesApi.md#updatereferencedata) | **PUT** /api/datatypes/{scope}/{code}/referencedata | [EARLY ACCESS] UpdateReferenceData: Update all reference data on a data type, includes the reference values, the field definitions, field values
*DataTypesApi* | [**UpdateReferenceValues**](docs/DataTypesApi.md#updatereferencevalues) | **PUT** /api/datatypes/{scope}/{code}/referencedatavalues | [EARLY ACCESS] UpdateReferenceValues: Update reference data on a data type
*DerivedTransactionPortfoliosApi* | [**CreateDerivedPortfolio**](docs/DerivedTransactionPortfoliosApi.md#createderivedportfolio) | **POST** /api/derivedtransactionportfolios/{scope} | CreateDerivedPortfolio: Create derived portfolio
*DerivedTransactionPortfoliosApi* | [**DeleteDerivedPortfolioDetails**](docs/DerivedTransactionPortfoliosApi.md#deletederivedportfoliodetails) | **DELETE** /api/derivedtransactionportfolios/{scope}/{code}/details | [EARLY ACCESS] DeleteDerivedPortfolioDetails: Delete derived portfolio details
*EntitiesApi* | [**GetCustomEntityByEntityUniqueId**](docs/EntitiesApi.md#getcustomentitybyentityuniqueid) | **GET** /api/entities/customentities/{entityUniqueId} | [EXPERIMENTAL] GetCustomEntityByEntityUniqueId: Get a Custom Entity instance by its EntityUniqueId
*EntitiesApi* | [**GetDataTypeByEntityUniqueId**](docs/EntitiesApi.md#getdatatypebyentityuniqueid) | **GET** /api/entities/datatypes/{entityUniqueId} | [EXPERIMENTAL] GetDataTypeByEntityUniqueId: Get DataType by EntityUniqueId
*EntitiesApi* | [**GetEntityHistory**](docs/EntitiesApi.md#getentityhistory) | **GET** /api/entities/{entityType}/{entityUniqueId}/history | [EXPERIMENTAL] GetEntityHistory: List an entity's history information
*EntitiesApi* | [**GetInstrumentByEntityUniqueId**](docs/EntitiesApi.md#getinstrumentbyentityuniqueid) | **GET** /api/entities/instruments/{entityUniqueId} | [EXPERIMENTAL] GetInstrumentByEntityUniqueId: Get instrument by EntityUniqueId
*EntitiesApi* | [**GetPortfolioByEntityUniqueId**](docs/EntitiesApi.md#getportfoliobyentityuniqueid) | **GET** /api/entities/portfolios/{entityUniqueId} | [EXPERIMENTAL] GetPortfolioByEntityUniqueId: Get portfolio by EntityUniqueId
*EntitiesApi* | [**GetPortfolioChanges**](docs/EntitiesApi.md#getportfoliochanges) | **GET** /api/entities/changes/portfolios | GetPortfolioChanges: Get the next change to each portfolio in a scope.
*EntitiesApi* | [**GetPropertyDefinitionByEntityUniqueId**](docs/EntitiesApi.md#getpropertydefinitionbyentityuniqueid) | **GET** /api/entities/propertydefinitions/{entityUniqueId} | [EXPERIMENTAL] GetPropertyDefinitionByEntityUniqueId: Get property definition by EntityUniqueId
*ExecutionsApi* | [**DeleteExecution**](docs/ExecutionsApi.md#deleteexecution) | **DELETE** /api/executions/{scope}/{code} | [EARLY ACCESS] DeleteExecution: Delete execution
*ExecutionsApi* | [**GetExecution**](docs/ExecutionsApi.md#getexecution) | **GET** /api/executions/{scope}/{code} | [EARLY ACCESS] GetExecution: Get Execution
*ExecutionsApi* | [**ListExecutions**](docs/ExecutionsApi.md#listexecutions) | **GET** /api/executions | ListExecutions: List Executions
*ExecutionsApi* | [**UpsertExecutions**](docs/ExecutionsApi.md#upsertexecutions) | **POST** /api/executions | UpsertExecutions: Upsert Execution
*FeeTypesApi* | [**CreateFeeType**](docs/FeeTypesApi.md#createfeetype) | **POST** /api/feetypes/{scope} | [EXPERIMENTAL] CreateFeeType: Create a FeeType.
*FeeTypesApi* | [**DeleteFeeType**](docs/FeeTypesApi.md#deletefeetype) | **DELETE** /api/feetypes/{scope}/{code} | [EXPERIMENTAL] DeleteFeeType: Delete a FeeType.
*FeeTypesApi* | [**GetFeeTemplateSpecifications**](docs/FeeTypesApi.md#getfeetemplatespecifications) | **GET** /api/feetypes/feetransactiontemplatespecification | [EXPERIMENTAL] GetFeeTemplateSpecifications: Get FeeTemplateSpecifications used in the FeeType.
*FeeTypesApi* | [**GetFeeType**](docs/FeeTypesApi.md#getfeetype) | **GET** /api/feetypes/{scope}/{code} | [EXPERIMENTAL] GetFeeType: Get a FeeType
*FeeTypesApi* | [**ListFeeTypes**](docs/FeeTypesApi.md#listfeetypes) | **GET** /api/feetypes | [EXPERIMENTAL] ListFeeTypes: List FeeTypes
*FeeTypesApi* | [**UpdateFeeType**](docs/FeeTypesApi.md#updatefeetype) | **PUT** /api/feetypes/{scope}/{code} | [EXPERIMENTAL] UpdateFeeType: Update a FeeType.
*FundConfigurationApi* | [**CreateFundConfiguration**](docs/FundConfigurationApi.md#createfundconfiguration) | **POST** /api/fundconfigurations/{scope} | [EXPERIMENTAL] CreateFundConfiguration: Create a FundConfiguration.
*FundConfigurationApi* | [**DeleteFundConfiguration**](docs/FundConfigurationApi.md#deletefundconfiguration) | **DELETE** /api/fundconfigurations/{scope}/{code} | [EXPERIMENTAL] DeleteFundConfiguration: Delete a FundConfiguration.
*FundConfigurationApi* | [**GetFundConfiguration**](docs/FundConfigurationApi.md#getfundconfiguration) | **GET** /api/fundconfigurations/{scope}/{code} | [EXPERIMENTAL] GetFundConfiguration: Get FundConfiguration.
*FundConfigurationApi* | [**ListFundConfigurations**](docs/FundConfigurationApi.md#listfundconfigurations) | **GET** /api/fundconfigurations | [EXPERIMENTAL] ListFundConfigurations: List FundConfiguration.
*FundConfigurationApi* | [**PatchFundConfiguration**](docs/FundConfigurationApi.md#patchfundconfiguration) | **PATCH** /api/fundconfigurations/{scope}/{code} | [EXPERIMENTAL] PatchFundConfiguration: Patch Fund Configuration.
*FundConfigurationApi* | [**UpsertFundConfigurationProperties**](docs/FundConfigurationApi.md#upsertfundconfigurationproperties) | **POST** /api/fundconfigurations/{scope}/{code}/properties/$upsert | [EXPERIMENTAL] UpsertFundConfigurationProperties: Upsert FundConfiguration properties
*FundsApi* | [**AcceptEstimateValuationPoint**](docs/FundsApi.md#acceptestimatevaluationpoint) | **POST** /api/funds/{scope}/{code}/valuationpoints/$acceptestimate | [EXPERIMENTAL] AcceptEstimateValuationPoint: Accepts an Estimate Valuation Point.
*FundsApi* | [**CreateFee**](docs/FundsApi.md#createfee) | **POST** /api/funds/{scope}/{code}/fees | [EXPERIMENTAL] CreateFee: Create a Fee.
*FundsApi* | [**CreateFund**](docs/FundsApi.md#createfund) | **POST** /api/funds/{scope} | [EXPERIMENTAL] CreateFund: Create a Fund.
*FundsApi* | [**DeleteFee**](docs/FundsApi.md#deletefee) | **DELETE** /api/funds/{scope}/{code}/fees/{feeCode} | [EXPERIMENTAL] DeleteFee: Delete a Fee.
*FundsApi* | [**DeleteFund**](docs/FundsApi.md#deletefund) | **DELETE** /api/funds/{scope}/{code} | [EXPERIMENTAL] DeleteFund: Delete a Fund.
*FundsApi* | [**DeleteValuationPoint**](docs/FundsApi.md#deletevaluationpoint) | **DELETE** /api/funds/{scope}/{code}/valuationpoints/{diaryEntryCode} | [EXPERIMENTAL] DeleteValuationPoint: Delete a Valuation Point.
*FundsApi* | [**FinaliseCandidateValuationPoint**](docs/FundsApi.md#finalisecandidatevaluationpoint) | **POST** /api/funds/{scope}/{code}/valuationpoints/$finalisecandidate | [EXPERIMENTAL] FinaliseCandidateValuationPoint: Finalise Candidate.
*FundsApi* | [**GetFee**](docs/FundsApi.md#getfee) | **GET** /api/funds/{scope}/{code}/fees/{feeCode} | [EXPERIMENTAL] GetFee: Get a Fee for a specified Fund.
*FundsApi* | [**GetFund**](docs/FundsApi.md#getfund) | **GET** /api/funds/{scope}/{code} | [EXPERIMENTAL] GetFund: Get a Fund.
*FundsApi* | [**GetValuationPointData**](docs/FundsApi.md#getvaluationpointdata) | **POST** /api/funds/{scope}/{code}/valuationpoints/$query | [EXPERIMENTAL] GetValuationPointData: Get Valuation Point Data for a Fund.
*FundsApi* | [**ListFees**](docs/FundsApi.md#listfees) | **GET** /api/funds/{scope}/{code}/fees | [EXPERIMENTAL] ListFees: List Fees for a specified Fund.
*FundsApi* | [**ListFunds**](docs/FundsApi.md#listfunds) | **GET** /api/funds | [EXPERIMENTAL] ListFunds: List Funds.
*FundsApi* | [**ListValuationPointOverview**](docs/FundsApi.md#listvaluationpointoverview) | **GET** /api/funds/{scope}/{code}/valuationPointOverview | [EXPERIMENTAL] ListValuationPointOverview: List Valuation Points Overview for a given Fund.
*FundsApi* | [**PatchFee**](docs/FundsApi.md#patchfee) | **PATCH** /api/funds/{scope}/{code}/fees/{feeCode} | [EXPERIMENTAL] PatchFee: Patch Fee.
*FundsApi* | [**PatchFund**](docs/FundsApi.md#patchfund) | **PATCH** /api/funds/{scope}/{code} | [EXPERIMENTAL] PatchFund: Patch a Fund.
*FundsApi* | [**SetShareClassInstruments**](docs/FundsApi.md#setshareclassinstruments) | **PUT** /api/funds/{scope}/{code}/shareclasses | [EXPERIMENTAL] SetShareClassInstruments: Set the ShareClass Instruments on a fund.
*FundsApi* | [**UpsertDiaryEntryTypeValuationPoint**](docs/FundsApi.md#upsertdiaryentrytypevaluationpoint) | **POST** /api/funds/{scope}/{code}/valuationpoints | [EXPERIMENTAL] UpsertDiaryEntryTypeValuationPoint: Upsert Valuation Point.
*FundsApi* | [**UpsertFeeProperties**](docs/FundsApi.md#upsertfeeproperties) | **POST** /api/funds/{scope}/{code}/fees/{feeCode}/properties/$upsert | [EXPERIMENTAL] UpsertFeeProperties: Upsert Fee properties.
*FundsApi* | [**UpsertFundProperties**](docs/FundsApi.md#upsertfundproperties) | **POST** /api/funds/{scope}/{code}/properties/$upsert | [EXPERIMENTAL] UpsertFundProperties: Upsert Fund properties.
*GroupReconciliationsApi* | [**CreateComparisonRuleset**](docs/GroupReconciliationsApi.md#createcomparisonruleset) | **POST** /api/reconciliations/comparisonrulesets | [EXPERIMENTAL] CreateComparisonRuleset: Create a Group Reconciliation Comparison Ruleset
*GroupReconciliationsApi* | [**CreateGroupReconciliationDefinition**](docs/GroupReconciliationsApi.md#creategroupreconciliationdefinition) | **POST** /api/reconciliations/groupreconciliationdefinitions | [EXPERIMENTAL] CreateGroupReconciliationDefinition: Create Group Reconciliation Definition
*GroupReconciliationsApi* | [**DeleteComparisonRuleset**](docs/GroupReconciliationsApi.md#deletecomparisonruleset) | **DELETE** /api/reconciliations/comparisonrulesets/{scope}/{code} | [EXPERIMENTAL] DeleteComparisonRuleset: Deletes a particular Group Reconciliation Comparison Ruleset
*GroupReconciliationsApi* | [**DeleteGroupReconciliationDefinition**](docs/GroupReconciliationsApi.md#deletegroupreconciliationdefinition) | **DELETE** /api/reconciliations/groupreconciliationdefinitions/{scope}/{code} | [EXPERIMENTAL] DeleteGroupReconciliationDefinition: Delete Group Reconciliation Definition
*GroupReconciliationsApi* | [**GetComparisonResult**](docs/GroupReconciliationsApi.md#getcomparisonresult) | **GET** /api/reconciliations/groupreconciliationdefinitions/{scope}/{code}/{resultId} | [EXPERIMENTAL] GetComparisonResult: Get a single Group Reconciliation Comparison Result by scope and code.
*GroupReconciliationsApi* | [**GetComparisonRuleset**](docs/GroupReconciliationsApi.md#getcomparisonruleset) | **GET** /api/reconciliations/comparisonrulesets/{scope}/{code} | [EXPERIMENTAL] GetComparisonRuleset: Get a single Group Reconciliation Comparison Ruleset by scope and code.
*GroupReconciliationsApi* | [**GetGroupReconciliationDefinition**](docs/GroupReconciliationsApi.md#getgroupreconciliationdefinition) | **GET** /api/reconciliations/groupreconciliationdefinitions/{scope}/{code} | [EXPERIMENTAL] GetGroupReconciliationDefinition: Get group reconciliation definition
*GroupReconciliationsApi* | [**ListComparisonResults**](docs/GroupReconciliationsApi.md#listcomparisonresults) | **GET** /api/reconciliations/comparisonresults | [EXPERIMENTAL] ListComparisonResults: Get a set of Group Reconciliation Comparison Results.
*GroupReconciliationsApi* | [**ListComparisonRulesets**](docs/GroupReconciliationsApi.md#listcomparisonrulesets) | **GET** /api/reconciliations/comparisonrulesets | [EXPERIMENTAL] ListComparisonRulesets: Get a set of Group Reconciliation Comparison Rulesets
*GroupReconciliationsApi* | [**ListGroupReconciliationDefinitions**](docs/GroupReconciliationsApi.md#listgroupreconciliationdefinitions) | **GET** /api/reconciliations/groupreconciliationdefinitions | [EXPERIMENTAL] ListGroupReconciliationDefinitions: List group reconciliation definitions
*GroupReconciliationsApi* | [**RunReconciliation**](docs/GroupReconciliationsApi.md#runreconciliation) | **POST** /api/reconciliations/groupreconciliationdefinitions/{scope}/{code}/$run | [EXPERIMENTAL] RunReconciliation: Runs a Group Reconciliation
*GroupReconciliationsApi* | [**UpdateComparisonRuleset**](docs/GroupReconciliationsApi.md#updatecomparisonruleset) | **PUT** /api/reconciliations/comparisonrulesets/{scope}/{code} | [EXPERIMENTAL] UpdateComparisonRuleset: Update Group Reconciliation Comparison Ruleset defined by scope and code
*GroupReconciliationsApi* | [**UpdateGroupReconciliationDefinition**](docs/GroupReconciliationsApi.md#updategroupreconciliationdefinition) | **PUT** /api/reconciliations/groupreconciliationdefinitions/{scope}/{code} | [EXPERIMENTAL] UpdateGroupReconciliationDefinition: Update group reconciliation definition
*InstrumentEventTypesApi* | [**CreateTransactionTemplate**](docs/InstrumentEventTypesApi.md#createtransactiontemplate) | **POST** /api/instrumenteventtypes/{instrumentEventType}/transactiontemplates/{instrumentType}/{scope} | [EXPERIMENTAL] CreateTransactionTemplate: Create Transaction Template
*InstrumentEventTypesApi* | [**DeleteTransactionTemplate**](docs/InstrumentEventTypesApi.md#deletetransactiontemplate) | **DELETE** /api/instrumenteventtypes/{instrumentEventType}/transactiontemplates/{instrumentType}/{scope} | [EXPERIMENTAL] DeleteTransactionTemplate: Delete Transaction Template
*InstrumentEventTypesApi* | [**GetTransactionTemplate**](docs/InstrumentEventTypesApi.md#gettransactiontemplate) | **GET** /api/instrumenteventtypes/{instrumentEventType}/transactiontemplates/{instrumentType}/{scope} | [EXPERIMENTAL] GetTransactionTemplate: Get Transaction Template
*InstrumentEventTypesApi* | [**GetTransactionTemplateSpecification**](docs/InstrumentEventTypesApi.md#gettransactiontemplatespecification) | **GET** /api/instrumenteventtypes/{instrumentEventType}/transactiontemplatespecification | [EXPERIMENTAL] GetTransactionTemplateSpecification: Get Transaction Template Specification.
*InstrumentEventTypesApi* | [**ListTransactionTemplateSpecifications**](docs/InstrumentEventTypesApi.md#listtransactiontemplatespecifications) | **GET** /api/instrumenteventtypes/transactiontemplatespecifications | [EXPERIMENTAL] ListTransactionTemplateSpecifications: List Transaction Template Specifications.
*InstrumentEventTypesApi* | [**ListTransactionTemplates**](docs/InstrumentEventTypesApi.md#listtransactiontemplates) | **GET** /api/instrumenteventtypes/transactiontemplates | [EXPERIMENTAL] ListTransactionTemplates: List Transaction Templates
*InstrumentEventTypesApi* | [**UpdateTransactionTemplate**](docs/InstrumentEventTypesApi.md#updatetransactiontemplate) | **PUT** /api/instrumenteventtypes/{instrumentEventType}/transactiontemplates/{instrumentType}/{scope} | [EXPERIMENTAL] UpdateTransactionTemplate: Update Transaction Template
*InstrumentEventsApi* | [**QueryApplicableInstrumentEvents**](docs/InstrumentEventsApi.md#queryapplicableinstrumentevents) | **POST** /api/instrumentevents/$queryApplicableInstrumentEvents | [EXPERIMENTAL] QueryApplicableInstrumentEvents: Returns a list of applicable instrument events based on the holdings of the portfolios and date range specified in the query.
*InstrumentEventsApi* | [**QueryBucketedCashFlows**](docs/InstrumentEventsApi.md#querybucketedcashflows) | **POST** /api/instrumentevents/$queryBucketedCashFlows | QueryBucketedCashFlows: Returns bucketed cashflows based on the holdings of the portfolios and date range specified in the query.
*InstrumentEventsApi* | [**QueryCashFlows**](docs/InstrumentEventsApi.md#querycashflows) | **POST** /api/instrumentevents/$queryCashFlows | [EXPERIMENTAL] QueryCashFlows: Returns a list of cashflows based on the holdings of the portfolios and date range specified in the query.
*InstrumentEventsApi* | [**QueryInstrumentEvents**](docs/InstrumentEventsApi.md#queryinstrumentevents) | **POST** /api/instrumentevents/$query | [EXPERIMENTAL] QueryInstrumentEvents: Returns a list of instrument events based on the holdings of the portfolios and date range specified in the query.
*InstrumentEventsApi* | [**QueryTradeTickets**](docs/InstrumentEventsApi.md#querytradetickets) | **POST** /api/instrumentevents/$queryTradeTickets | [EXPERIMENTAL] QueryTradeTickets: Returns a list of trade tickets based on the holdings of the portfolios and date range specified in the query.
*InstrumentsApi* | [**BatchUpsertInstrumentProperties**](docs/InstrumentsApi.md#batchupsertinstrumentproperties) | **POST** /api/instruments/$batchupsertproperties | BatchUpsertInstrumentProperties: Batch upsert instruments properties
*InstrumentsApi* | [**CalculateSettlementDate**](docs/InstrumentsApi.md#calculatesettlementdate) | **GET** /api/instruments/{identifierType}/{identifier}/settlementdate | [EARLY ACCESS] CalculateSettlementDate: Get the settlement date for an instrument.
*InstrumentsApi* | [**DeleteInstrument**](docs/InstrumentsApi.md#deleteinstrument) | **DELETE** /api/instruments/{identifierType}/{identifier} | DeleteInstrument: Soft delete a single instrument
*InstrumentsApi* | [**DeleteInstrumentProperties**](docs/InstrumentsApi.md#deleteinstrumentproperties) | **POST** /api/instruments/{identifierType}/{identifier}/properties/$delete | [EARLY ACCESS] DeleteInstrumentProperties: Delete instrument properties
*InstrumentsApi* | [**DeleteInstruments**](docs/InstrumentsApi.md#deleteinstruments) | **POST** /api/instruments/$delete | DeleteInstruments: Soft or hard delete multiple instruments
*InstrumentsApi* | [**GetAllPossibleFeatures**](docs/InstrumentsApi.md#getallpossiblefeatures) | **GET** /api/instruments/{instrumentType}/allfeatures | [EXPERIMENTAL] GetAllPossibleFeatures: Provides list of all possible features for instrument type.
*InstrumentsApi* | [**GetExistingInstrumentCapabilities**](docs/InstrumentsApi.md#getexistinginstrumentcapabilities) | **GET** /api/instruments/{identifier}/capabilities | [EXPERIMENTAL] GetExistingInstrumentCapabilities: Retrieve capabilities of an existing instrument identified by LUID. These include instrument features, and if model is provided it also includes supported address keys and economic dependencies.  Given an lusid instrument id provides instrument capabilities, outlining features, and, given the model, the capabilities also include supported addresses as well as economic dependencies.
*InstrumentsApi* | [**GetExistingInstrumentModels**](docs/InstrumentsApi.md#getexistinginstrumentmodels) | **GET** /api/instruments/{identifier}/models | GetExistingInstrumentModels: Retrieve supported pricing models for an existing instrument identified by LUID.
*InstrumentsApi* | [**GetInstrument**](docs/InstrumentsApi.md#getinstrument) | **GET** /api/instruments/{identifierType}/{identifier} | GetInstrument: Get instrument
*InstrumentsApi* | [**GetInstrumentIdentifierTypes**](docs/InstrumentsApi.md#getinstrumentidentifiertypes) | **GET** /api/instruments/identifierTypes | GetInstrumentIdentifierTypes: Get instrument identifier types
*InstrumentsApi* | [**GetInstrumentPaymentDiary**](docs/InstrumentsApi.md#getinstrumentpaymentdiary) | **GET** /api/instruments/{identifierType}/{identifier}/paymentdiary | [EXPERIMENTAL] GetInstrumentPaymentDiary: Get instrument payment diary
*InstrumentsApi* | [**GetInstrumentProperties**](docs/InstrumentsApi.md#getinstrumentproperties) | **GET** /api/instruments/{identifierType}/{identifier}/properties | GetInstrumentProperties: Get instrument properties
*InstrumentsApi* | [**GetInstrumentPropertyTimeSeries**](docs/InstrumentsApi.md#getinstrumentpropertytimeseries) | **GET** /api/instruments/{identifierType}/{identifier}/properties/time-series | GetInstrumentPropertyTimeSeries: Get instrument property time series
*InstrumentsApi* | [**GetInstrumentRelationships**](docs/InstrumentsApi.md#getinstrumentrelationships) | **GET** /api/instruments/{identifierType}/{identifier}/relationships | [EARLY ACCESS] GetInstrumentRelationships: Get Instrument relationships
*InstrumentsApi* | [**GetInstruments**](docs/InstrumentsApi.md#getinstruments) | **POST** /api/instruments/$get | GetInstruments: Get instruments
*InstrumentsApi* | [**ListInstrumentProperties**](docs/InstrumentsApi.md#listinstrumentproperties) | **GET** /api/instruments/{identifierType}/{identifier}/properties/list | [EARLY ACCESS] ListInstrumentProperties: Get instrument properties (with Pagination)
*InstrumentsApi* | [**ListInstruments**](docs/InstrumentsApi.md#listinstruments) | **GET** /api/instruments | ListInstruments: List instruments
*InstrumentsApi* | [**QueryInstrumentCapabilities**](docs/InstrumentsApi.md#queryinstrumentcapabilities) | **POST** /api/instruments/capabilities | [EXPERIMENTAL] QueryInstrumentCapabilities: Query capabilities of a particular instrument in advance of creating it. These include instrument features, and if model is provided it also includes supported address keys and economic dependencies.
*InstrumentsApi* | [**UpdateInstrumentIdentifier**](docs/InstrumentsApi.md#updateinstrumentidentifier) | **POST** /api/instruments/{identifierType}/{identifier} | UpdateInstrumentIdentifier: Update instrument identifier
*InstrumentsApi* | [**UpsertInstruments**](docs/InstrumentsApi.md#upsertinstruments) | **POST** /api/instruments | UpsertInstruments: Upsert instruments
*InstrumentsApi* | [**UpsertInstrumentsProperties**](docs/InstrumentsApi.md#upsertinstrumentsproperties) | **POST** /api/instruments/$upsertproperties | UpsertInstrumentsProperties: Upsert instruments properties
*LegacyComplianceApi* | [**DeleteLegacyComplianceRule**](docs/LegacyComplianceApi.md#deletelegacycompliancerule) | **DELETE** /api/legacy/compliance/rules/{scope}/{code} | [EXPERIMENTAL] DeleteLegacyComplianceRule: Deletes a compliance rule.
*LegacyComplianceApi* | [**GetLegacyBreachedOrdersInfo**](docs/LegacyComplianceApi.md#getlegacybreachedordersinfo) | **GET** /api/legacy/compliance/runs/breached/{runId} | [EXPERIMENTAL] GetLegacyBreachedOrdersInfo: Get the Ids of Breached orders in a given compliance run and the corresponding list of rules that could have caused it.
*LegacyComplianceApi* | [**GetLegacyComplianceRule**](docs/LegacyComplianceApi.md#getlegacycompliancerule) | **GET** /api/legacy/compliance/rules/{scope}/{code} | [EXPERIMENTAL] GetLegacyComplianceRule: Retrieve the definition of single compliance rule.
*LegacyComplianceApi* | [**GetLegacyComplianceRunResults**](docs/LegacyComplianceApi.md#getlegacycompliancerunresults) | **GET** /api/legacy/compliance/runs/{runId} | [EXPERIMENTAL] GetLegacyComplianceRunResults: Get the details of a single compliance run.
*LegacyComplianceApi* | [**ListLegacyComplianceRules**](docs/LegacyComplianceApi.md#listlegacycompliancerules) | **GET** /api/legacy/compliance/rules | [EXPERIMENTAL] ListLegacyComplianceRules: List compliance rules, with optional filtering.
*LegacyComplianceApi* | [**ListLegacyComplianceRunInfo**](docs/LegacyComplianceApi.md#listlegacycomplianceruninfo) | **GET** /api/legacy/compliance/runs | [EXPERIMENTAL] ListLegacyComplianceRunInfo: List historical compliance run ids.
*LegacyComplianceApi* | [**RunLegacyCompliance**](docs/LegacyComplianceApi.md#runlegacycompliance) | **POST** /api/legacy/compliance/runs | [EXPERIMENTAL] RunLegacyCompliance: Kick off the compliance check process
*LegacyComplianceApi* | [**UpsertLegacyComplianceRules**](docs/LegacyComplianceApi.md#upsertlegacycompliancerules) | **POST** /api/legacy/compliance/rules | [EXPERIMENTAL] UpsertLegacyComplianceRules: Upsert compliance rules.
*LegalEntitiesApi* | [**DeleteLegalEntity**](docs/LegalEntitiesApi.md#deletelegalentity) | **DELETE** /api/legalentities/{idTypeScope}/{idTypeCode}/{code} | DeleteLegalEntity: Delete Legal Entity
*LegalEntitiesApi* | [**DeleteLegalEntityAccessMetadata**](docs/LegalEntitiesApi.md#deletelegalentityaccessmetadata) | **DELETE** /api/legalentities/{idTypeScope}/{idTypeCode}/{code}/metadata/{metadataKey} | DeleteLegalEntityAccessMetadata: Delete a Legal Entity Access Metadata entry
*LegalEntitiesApi* | [**DeleteLegalEntityIdentifiers**](docs/LegalEntitiesApi.md#deletelegalentityidentifiers) | **DELETE** /api/legalentities/{idTypeScope}/{idTypeCode}/{code}/identifiers | [EARLY ACCESS] DeleteLegalEntityIdentifiers: Delete Legal Entity Identifiers
*LegalEntitiesApi* | [**DeleteLegalEntityProperties**](docs/LegalEntitiesApi.md#deletelegalentityproperties) | **DELETE** /api/legalentities/{idTypeScope}/{idTypeCode}/{code}/properties | [EARLY ACCESS] DeleteLegalEntityProperties: Delete Legal Entity Properties
*LegalEntitiesApi* | [**GetAllLegalEntityAccessMetadata**](docs/LegalEntitiesApi.md#getalllegalentityaccessmetadata) | **GET** /api/legalentities/{idTypeScope}/{idTypeCode}/{code}/metadata | GetAllLegalEntityAccessMetadata: Get Access Metadata rules for a Legal Entity
*LegalEntitiesApi* | [**GetLegalEntity**](docs/LegalEntitiesApi.md#getlegalentity) | **GET** /api/legalentities/{idTypeScope}/{idTypeCode}/{code} | GetLegalEntity: Get Legal Entity
*LegalEntitiesApi* | [**GetLegalEntityAccessMetadataByKey**](docs/LegalEntitiesApi.md#getlegalentityaccessmetadatabykey) | **GET** /api/legalentities/{idTypeScope}/{idTypeCode}/{code}/metadata/{metadataKey} | [EARLY ACCESS] GetLegalEntityAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Legal Entity
*LegalEntitiesApi* | [**GetLegalEntityPropertyTimeSeries**](docs/LegalEntitiesApi.md#getlegalentitypropertytimeseries) | **GET** /api/legalentities/{idTypeScope}/{idTypeCode}/{code}/properties/time-series | GetLegalEntityPropertyTimeSeries: Get Legal Entity Property Time Series
*LegalEntitiesApi* | [**GetLegalEntityRelations**](docs/LegalEntitiesApi.md#getlegalentityrelations) | **GET** /api/legalentities/{idTypeScope}/{idTypeCode}/{code}/relations | GetLegalEntityRelations: Get Relations for Legal Entity
*LegalEntitiesApi* | [**GetLegalEntityRelationships**](docs/LegalEntitiesApi.md#getlegalentityrelationships) | **GET** /api/legalentities/{idTypeScope}/{idTypeCode}/{code}/relationships | GetLegalEntityRelationships: Get Relationships for Legal Entity
*LegalEntitiesApi* | [**ListAllLegalEntities**](docs/LegalEntitiesApi.md#listalllegalentities) | **GET** /api/legalentities | ListAllLegalEntities: List Legal Entities
*LegalEntitiesApi* | [**ListLegalEntities**](docs/LegalEntitiesApi.md#listlegalentities) | **GET** /api/legalentities/{idTypeScope}/{idTypeCode} | ListLegalEntities: List Legal Entities
*LegalEntitiesApi* | [**PatchLegalEntityAccessMetadata**](docs/LegalEntitiesApi.md#patchlegalentityaccessmetadata) | **PATCH** /api/legalentities/{idTypeScope}/{idTypeCode}/{code}/metadata | [EARLY ACCESS] PatchLegalEntityAccessMetadata: Patch Access Metadata rules for a Legal Entity.
*LegalEntitiesApi* | [**SetLegalEntityIdentifiers**](docs/LegalEntitiesApi.md#setlegalentityidentifiers) | **POST** /api/legalentities/{idTypeScope}/{idTypeCode}/{code}/identifiers | [EARLY ACCESS] SetLegalEntityIdentifiers: Set Legal Entity Identifiers
*LegalEntitiesApi* | [**SetLegalEntityProperties**](docs/LegalEntitiesApi.md#setlegalentityproperties) | **POST** /api/legalentities/{idTypeScope}/{idTypeCode}/{code}/properties | SetLegalEntityProperties: Set Legal Entity Properties
*LegalEntitiesApi* | [**UpsertLegalEntities**](docs/LegalEntitiesApi.md#upsertlegalentities) | **POST** /api/legalentities/$batchUpsert | [EARLY ACCESS] UpsertLegalEntities: Pluralised upsert of Legal Entities
*LegalEntitiesApi* | [**UpsertLegalEntity**](docs/LegalEntitiesApi.md#upsertlegalentity) | **POST** /api/legalentities | UpsertLegalEntity: Upsert Legal Entity
*LegalEntitiesApi* | [**UpsertLegalEntityAccessMetadata**](docs/LegalEntitiesApi.md#upsertlegalentityaccessmetadata) | **PUT** /api/legalentities/{idTypeScope}/{idTypeCode}/{code}/metadata/{metadataKey} | UpsertLegalEntityAccessMetadata: Upsert a Legal Entity Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.
*OrderGraphApi* | [**ListOrderGraphBlocks**](docs/OrderGraphApi.md#listordergraphblocks) | **GET** /api/ordergraph/blocks | ListOrderGraphBlocks: Lists blocks that pass the filter provided, and builds a summary picture of the state of their associated order entities.
*OrderGraphApi* | [**ListOrderGraphPlacementChildren**](docs/OrderGraphApi.md#listordergraphplacementchildren) | **GET** /api/ordergraph/placementchildren/{scope}/{code} | [EARLY ACCESS] ListOrderGraphPlacementChildren: Lists all placements for the parent placement specified by the scope and code, and builds a summary picture of the state of their associated order entities.
*OrderGraphApi* | [**ListOrderGraphPlacements**](docs/OrderGraphApi.md#listordergraphplacements) | **GET** /api/ordergraph/placements | ListOrderGraphPlacements: Lists placements that pass the filter provided, and builds a summary picture of the state of their associated order entities.
*OrderInstructionsApi* | [**DeleteOrderInstruction**](docs/OrderInstructionsApi.md#deleteorderinstruction) | **DELETE** /api/orderinstructions/{scope}/{code} | [EXPERIMENTAL] DeleteOrderInstruction: Delete orderInstruction
*OrderInstructionsApi* | [**GetOrderInstruction**](docs/OrderInstructionsApi.md#getorderinstruction) | **GET** /api/orderinstructions/{scope}/{code} | [EXPERIMENTAL] GetOrderInstruction: Get OrderInstruction
*OrderInstructionsApi* | [**ListOrderInstructions**](docs/OrderInstructionsApi.md#listorderinstructions) | **GET** /api/orderinstructions | [EXPERIMENTAL] ListOrderInstructions: List OrderInstructions
*OrderInstructionsApi* | [**UpsertOrderInstructions**](docs/OrderInstructionsApi.md#upsertorderinstructions) | **POST** /api/orderinstructions | [EXPERIMENTAL] UpsertOrderInstructions: Upsert OrderInstruction
*OrderManagementApi* | [**BookTransactions**](docs/OrderManagementApi.md#booktransactions) | **POST** /api/ordermanagement/booktransactions | [EXPERIMENTAL] BookTransactions: Books transactions using specific allocations as a source.
*OrderManagementApi* | [**CancelOrders**](docs/OrderManagementApi.md#cancelorders) | **POST** /api/ordermanagement/cancelorders | [EARLY ACCESS] CancelOrders: Cancel existing orders
*OrderManagementApi* | [**CancelOrdersAndMoveRemaining**](docs/OrderManagementApi.md#cancelordersandmoveremaining) | **POST** /api/ordermanagement/cancelordersandmoveremaining | [EARLY ACCESS] CancelOrdersAndMoveRemaining: Cancel existing orders and move any unplaced quantities to new orders in new blocks
*OrderManagementApi* | [**CancelPlacements**](docs/OrderManagementApi.md#cancelplacements) | **POST** /api/ordermanagement/$cancelplacements | [EARLY ACCESS] CancelPlacements: Cancel existing placements
*OrderManagementApi* | [**CreateOrders**](docs/OrderManagementApi.md#createorders) | **POST** /api/ordermanagement/createorders | [EARLY ACCESS] CreateOrders: Upsert a Block and associated orders
*OrderManagementApi* | [**GetOrderHistory**](docs/OrderManagementApi.md#getorderhistory) | **GET** /api/ordermanagement/order/{scope}/{code}/$history | [EXPERIMENTAL] GetOrderHistory: Get the history of an order and related entity changes
*OrderManagementApi* | [**MoveOrders**](docs/OrderManagementApi.md#moveorders) | **POST** /api/ordermanagement/moveorders | [EARLY ACCESS] MoveOrders: Move orders to new or existing block
*OrderManagementApi* | [**PlaceBlocks**](docs/OrderManagementApi.md#placeblocks) | **POST** /api/ordermanagement/placeblocks | [EARLY ACCESS] PlaceBlocks: Places blocks for a given list of placement requests.
*OrderManagementApi* | [**RunAllocationService**](docs/OrderManagementApi.md#runallocationservice) | **POST** /api/ordermanagement/allocate | [EXPERIMENTAL] RunAllocationService: Runs the Allocation Service
*OrderManagementApi* | [**UpdateOrders**](docs/OrderManagementApi.md#updateorders) | **POST** /api/ordermanagement/updateorders | [EARLY ACCESS] UpdateOrders: Update existing orders
*OrderManagementApi* | [**UpdatePlacements**](docs/OrderManagementApi.md#updateplacements) | **POST** /api/ordermanagement/$updateplacements | [EARLY ACCESS] UpdatePlacements: Update existing placements
*OrdersApi* | [**DeleteOrder**](docs/OrdersApi.md#deleteorder) | **DELETE** /api/orders/{scope}/{code} | [EARLY ACCESS] DeleteOrder: Delete order
*OrdersApi* | [**GetOrder**](docs/OrdersApi.md#getorder) | **GET** /api/orders/{scope}/{code} | [EARLY ACCESS] GetOrder: Get Order
*OrdersApi* | [**ListOrders**](docs/OrdersApi.md#listorders) | **GET** /api/orders | ListOrders: List Orders
*OrdersApi* | [**UpsertOrders**](docs/OrdersApi.md#upsertorders) | **POST** /api/orders | UpsertOrders: Upsert Order
*PackagesApi* | [**DeletePackage**](docs/PackagesApi.md#deletepackage) | **DELETE** /api/packages/{scope}/{code} | [EXPERIMENTAL] DeletePackage: Delete package
*PackagesApi* | [**GetPackage**](docs/PackagesApi.md#getpackage) | **GET** /api/packages/{scope}/{code} | [EXPERIMENTAL] GetPackage: Get Package
*PackagesApi* | [**ListPackages**](docs/PackagesApi.md#listpackages) | **GET** /api/packages | [EXPERIMENTAL] ListPackages: List Packages
*PackagesApi* | [**UpsertPackages**](docs/PackagesApi.md#upsertpackages) | **POST** /api/packages | [EXPERIMENTAL] UpsertPackages: Upsert Package
*ParticipationsApi* | [**DeleteParticipation**](docs/ParticipationsApi.md#deleteparticipation) | **DELETE** /api/participations/{scope}/{code} | [EARLY ACCESS] DeleteParticipation: Delete participation
*ParticipationsApi* | [**GetParticipation**](docs/ParticipationsApi.md#getparticipation) | **GET** /api/participations/{scope}/{code} | [EARLY ACCESS] GetParticipation: Get Participation
*ParticipationsApi* | [**ListParticipations**](docs/ParticipationsApi.md#listparticipations) | **GET** /api/participations | [EARLY ACCESS] ListParticipations: List Participations
*ParticipationsApi* | [**UpsertParticipations**](docs/ParticipationsApi.md#upsertparticipations) | **POST** /api/participations | [EARLY ACCESS] UpsertParticipations: Upsert Participation
*PersonsApi* | [**DeletePerson**](docs/PersonsApi.md#deleteperson) | **DELETE** /api/persons/{idTypeScope}/{idTypeCode}/{code} | DeletePerson: Delete person
*PersonsApi* | [**DeletePersonAccessMetadata**](docs/PersonsApi.md#deletepersonaccessmetadata) | **DELETE** /api/persons/{idTypeScope}/{idTypeCode}/{code}/metadata/{metadataKey} | [EARLY ACCESS] DeletePersonAccessMetadata: Delete a Person Access Metadata entry
*PersonsApi* | [**DeletePersonIdentifiers**](docs/PersonsApi.md#deletepersonidentifiers) | **DELETE** /api/persons/{idTypeScope}/{idTypeCode}/{code}/identifiers | [EARLY ACCESS] DeletePersonIdentifiers: Delete Person Identifiers
*PersonsApi* | [**DeletePersonProperties**](docs/PersonsApi.md#deletepersonproperties) | **DELETE** /api/persons/{idTypeScope}/{idTypeCode}/{code}/properties | [EARLY ACCESS] DeletePersonProperties: Delete Person Properties
*PersonsApi* | [**GetAllPersonAccessMetadata**](docs/PersonsApi.md#getallpersonaccessmetadata) | **GET** /api/persons/{idTypeScope}/{idTypeCode}/{code}/metadata | [EARLY ACCESS] GetAllPersonAccessMetadata: Get Access Metadata rules for a Person
*PersonsApi* | [**GetPerson**](docs/PersonsApi.md#getperson) | **GET** /api/persons/{idTypeScope}/{idTypeCode}/{code} | [EARLY ACCESS] GetPerson: Get Person
*PersonsApi* | [**GetPersonAccessMetadataByKey**](docs/PersonsApi.md#getpersonaccessmetadatabykey) | **GET** /api/persons/{idTypeScope}/{idTypeCode}/{code}/metadata/{metadataKey} | [EARLY ACCESS] GetPersonAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Person
*PersonsApi* | [**GetPersonPropertyTimeSeries**](docs/PersonsApi.md#getpersonpropertytimeseries) | **GET** /api/persons/{idTypeScope}/{idTypeCode}/{code}/properties/time-series | [EARLY ACCESS] GetPersonPropertyTimeSeries: Get Person Property Time Series
*PersonsApi* | [**GetPersonRelations**](docs/PersonsApi.md#getpersonrelations) | **GET** /api/persons/{idTypeScope}/{idTypeCode}/{code}/relations | [EARLY ACCESS] GetPersonRelations: Get Relations for Person
*PersonsApi* | [**GetPersonRelationships**](docs/PersonsApi.md#getpersonrelationships) | **GET** /api/persons/{idTypeScope}/{idTypeCode}/{code}/relationships | [EARLY ACCESS] GetPersonRelationships: Get Relationships for Person
*PersonsApi* | [**ListAllPersons**](docs/PersonsApi.md#listallpersons) | **GET** /api/persons | [EARLY ACCESS] ListAllPersons: List All Persons
*PersonsApi* | [**ListPersons**](docs/PersonsApi.md#listpersons) | **GET** /api/persons/{idTypeScope}/{idTypeCode} | [EARLY ACCESS] ListPersons: List Persons
*PersonsApi* | [**PatchPersonAccessMetadata**](docs/PersonsApi.md#patchpersonaccessmetadata) | **PATCH** /api/persons/{idTypeScope}/{idTypeCode}/{code}/metadata | [EARLY ACCESS] PatchPersonAccessMetadata: Patch Access Metadata rules for a Person.
*PersonsApi* | [**SetPersonIdentifiers**](docs/PersonsApi.md#setpersonidentifiers) | **POST** /api/persons/{idTypeScope}/{idTypeCode}/{code}/identifiers | [EARLY ACCESS] SetPersonIdentifiers: Set Person Identifiers
*PersonsApi* | [**SetPersonProperties**](docs/PersonsApi.md#setpersonproperties) | **POST** /api/persons/{idTypeScope}/{idTypeCode}/{code}/properties | [EARLY ACCESS] SetPersonProperties: Set Person Properties
*PersonsApi* | [**UpsertPerson**](docs/PersonsApi.md#upsertperson) | **POST** /api/persons | UpsertPerson: Upsert Person
*PersonsApi* | [**UpsertPersonAccessMetadata**](docs/PersonsApi.md#upsertpersonaccessmetadata) | **PUT** /api/persons/{idTypeScope}/{idTypeCode}/{code}/metadata/{metadataKey} | [EARLY ACCESS] UpsertPersonAccessMetadata: Upsert a Person Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.
*PersonsApi* | [**UpsertPersons**](docs/PersonsApi.md#upsertpersons) | **POST** /api/persons/$batchUpsert | [EARLY ACCESS] UpsertPersons: Pluralised Upsert of Persons
*PlacementsApi* | [**DeletePlacement**](docs/PlacementsApi.md#deleteplacement) | **DELETE** /api/placements/{scope}/{code} | [EARLY ACCESS] DeletePlacement: Delete placement
*PlacementsApi* | [**GetPlacement**](docs/PlacementsApi.md#getplacement) | **GET** /api/placements/{scope}/{code} | [EARLY ACCESS] GetPlacement: Get Placement
*PlacementsApi* | [**ListPlacements**](docs/PlacementsApi.md#listplacements) | **GET** /api/placements | [EARLY ACCESS] ListPlacements: List Placements
*PlacementsApi* | [**UpsertPlacements**](docs/PlacementsApi.md#upsertplacements) | **POST** /api/placements | [EARLY ACCESS] UpsertPlacements: Upsert Placement
*PortfolioGroupsApi* | [**AddPortfolioToGroup**](docs/PortfolioGroupsApi.md#addportfoliotogroup) | **POST** /api/portfoliogroups/{scope}/{code}/portfolios | [EARLY ACCESS] AddPortfolioToGroup: Add portfolio to group
*PortfolioGroupsApi* | [**AddSubGroupToGroup**](docs/PortfolioGroupsApi.md#addsubgrouptogroup) | **POST** /api/portfoliogroups/{scope}/{code}/subgroups | [EARLY ACCESS] AddSubGroupToGroup: Add sub group to group
*PortfolioGroupsApi* | [**BuildTransactionsForPortfolioGroup**](docs/PortfolioGroupsApi.md#buildtransactionsforportfoliogroup) | **POST** /api/portfoliogroups/{scope}/{code}/transactions/$build | BuildTransactionsForPortfolioGroup: Build transactions for transaction portfolios in a portfolio group
*PortfolioGroupsApi* | [**CreatePortfolioGroup**](docs/PortfolioGroupsApi.md#createportfoliogroup) | **POST** /api/portfoliogroups/{scope} | CreatePortfolioGroup: Create portfolio group
*PortfolioGroupsApi* | [**DeleteGroupProperties**](docs/PortfolioGroupsApi.md#deletegroupproperties) | **POST** /api/portfoliogroups/{scope}/{code}/properties/$delete | [EARLY ACCESS] DeleteGroupProperties: Delete group properties
*PortfolioGroupsApi* | [**DeleteKeyFromPortfolioGroupAccessMetadata**](docs/PortfolioGroupsApi.md#deletekeyfromportfoliogroupaccessmetadata) | **DELETE** /api/portfoliogroups/{scope}/{code}/metadata/{metadataKey} | [EARLY ACCESS] DeleteKeyFromPortfolioGroupAccessMetadata: Delete a Portfolio Group Access Metadata entry
*PortfolioGroupsApi* | [**DeletePortfolioFromGroup**](docs/PortfolioGroupsApi.md#deleteportfoliofromgroup) | **DELETE** /api/portfoliogroups/{scope}/{code}/portfolios/{portfolioScope}/{portfolioCode} | [EARLY ACCESS] DeletePortfolioFromGroup: Delete portfolio from group
*PortfolioGroupsApi* | [**DeletePortfolioGroup**](docs/PortfolioGroupsApi.md#deleteportfoliogroup) | **DELETE** /api/portfoliogroups/{scope}/{code} | [EARLY ACCESS] DeletePortfolioGroup: Delete portfolio group
*PortfolioGroupsApi* | [**DeleteSubGroupFromGroup**](docs/PortfolioGroupsApi.md#deletesubgroupfromgroup) | **DELETE** /api/portfoliogroups/{scope}/{code}/subgroups/{subgroupScope}/{subgroupCode} | [EARLY ACCESS] DeleteSubGroupFromGroup: Delete sub group from group
*PortfolioGroupsApi* | [**GetA2BDataForPortfolioGroup**](docs/PortfolioGroupsApi.md#geta2bdataforportfoliogroup) | **GET** /api/portfoliogroups/{scope}/{code}/a2b | [EARLY ACCESS] GetA2BDataForPortfolioGroup: Get A2B data for a Portfolio Group
*PortfolioGroupsApi* | [**GetGroupProperties**](docs/PortfolioGroupsApi.md#getgroupproperties) | **GET** /api/portfoliogroups/{scope}/{code}/properties | [EARLY ACCESS] GetGroupProperties: Get group properties
*PortfolioGroupsApi* | [**GetHoldingsForPortfolioGroup**](docs/PortfolioGroupsApi.md#getholdingsforportfoliogroup) | **GET** /api/portfoliogroups/{scope}/{code}/holdings | GetHoldingsForPortfolioGroup: Get holdings for transaction portfolios in portfolio group
*PortfolioGroupsApi* | [**GetPortfolioGroup**](docs/PortfolioGroupsApi.md#getportfoliogroup) | **GET** /api/portfoliogroups/{scope}/{code} | GetPortfolioGroup: Get portfolio group
*PortfolioGroupsApi* | [**GetPortfolioGroupAccessMetadataByKey**](docs/PortfolioGroupsApi.md#getportfoliogroupaccessmetadatabykey) | **GET** /api/portfoliogroups/{scope}/{code}/metadata/{metadataKey} | [EARLY ACCESS] GetPortfolioGroupAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Portfolio Group
*PortfolioGroupsApi* | [**GetPortfolioGroupCommands**](docs/PortfolioGroupsApi.md#getportfoliogroupcommands) | **GET** /api/portfoliogroups/{scope}/{code}/commands | GetPortfolioGroupCommands: Get portfolio group commands
*PortfolioGroupsApi* | [**GetPortfolioGroupExpansion**](docs/PortfolioGroupsApi.md#getportfoliogroupexpansion) | **GET** /api/portfoliogroups/{scope}/{code}/expansion | [EARLY ACCESS] GetPortfolioGroupExpansion: Get portfolio group expansion
*PortfolioGroupsApi* | [**GetPortfolioGroupMetadata**](docs/PortfolioGroupsApi.md#getportfoliogroupmetadata) | **GET** /api/portfoliogroups/{scope}/{code}/metadata | [EARLY ACCESS] GetPortfolioGroupMetadata: Get Access Metadata rules for Portfolio Group
*PortfolioGroupsApi* | [**GetPortfolioGroupPropertyTimeSeries**](docs/PortfolioGroupsApi.md#getportfoliogrouppropertytimeseries) | **GET** /api/portfoliogroups/{scope}/{code}/properties/time-series | [EARLY ACCESS] GetPortfolioGroupPropertyTimeSeries: Get the time series of a portfolio group property
*PortfolioGroupsApi* | [**GetPortfolioGroupRelations**](docs/PortfolioGroupsApi.md#getportfoliogrouprelations) | **GET** /api/portfoliogroups/{scope}/{code}/relations | [EXPERIMENTAL] GetPortfolioGroupRelations: Get Relations for Portfolio Group
*PortfolioGroupsApi* | [**GetPortfolioGroupRelationships**](docs/PortfolioGroupsApi.md#getportfoliogrouprelationships) | **GET** /api/portfoliogroups/{scope}/{code}/relationships | [EARLY ACCESS] GetPortfolioGroupRelationships: Get Relationships for Portfolio Group
*PortfolioGroupsApi* | [**GetTransactionsForPortfolioGroup**](docs/PortfolioGroupsApi.md#gettransactionsforportfoliogroup) | **GET** /api/portfoliogroups/{scope}/{code}/transactions | GetTransactionsForPortfolioGroup: Get transactions for transaction portfolios in a portfolio group
*PortfolioGroupsApi* | [**ListPortfolioGroups**](docs/PortfolioGroupsApi.md#listportfoliogroups) | **GET** /api/portfoliogroups/{scope} | ListPortfolioGroups: List portfolio groups
*PortfolioGroupsApi* | [**PatchPortfolioGroupAccessMetadata**](docs/PortfolioGroupsApi.md#patchportfoliogroupaccessmetadata) | **PATCH** /api/portfoliogroups/{scope}/{code}/metadata | [EARLY ACCESS] PatchPortfolioGroupAccessMetadata: Patch Access Metadata rules for a Portfolio Group.
*PortfolioGroupsApi* | [**UpdatePortfolioGroup**](docs/PortfolioGroupsApi.md#updateportfoliogroup) | **PUT** /api/portfoliogroups/{scope}/{code} | [EARLY ACCESS] UpdatePortfolioGroup: Update portfolio group
*PortfolioGroupsApi* | [**UpsertGroupProperties**](docs/PortfolioGroupsApi.md#upsertgroupproperties) | **POST** /api/portfoliogroups/{scope}/{code}/properties/$upsert | [EARLY ACCESS] UpsertGroupProperties: Upsert group properties
*PortfolioGroupsApi* | [**UpsertPortfolioGroupAccessMetadata**](docs/PortfolioGroupsApi.md#upsertportfoliogroupaccessmetadata) | **PUT** /api/portfoliogroups/{scope}/{code}/metadata/{metadataKey} | UpsertPortfolioGroupAccessMetadata: Upsert a Portfolio Group Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.
*PortfoliosApi* | [**BatchUpsertPortfolioAccessMetadata**](docs/PortfoliosApi.md#batchupsertportfolioaccessmetadata) | **PUT** /api/portfolios/metadata | [EARLY ACCESS] BatchUpsertPortfolioAccessMetadata: Upsert multiple Portfolio Access Metadata Rules to multiple Portfolios
*PortfoliosApi* | [**DeleteInstrumentEventInstruction**](docs/PortfoliosApi.md#deleteinstrumenteventinstruction) | **DELETE** /api/portfolios/{scope}/{code}/instrumenteventinstructions/{instrumentEventInstructionId} | [EARLY ACCESS] DeleteInstrumentEventInstruction: Delete Instrument Event Instruction
*PortfoliosApi* | [**DeleteKeyFromPortfolioAccessMetadata**](docs/PortfoliosApi.md#deletekeyfromportfolioaccessmetadata) | **DELETE** /api/portfolios/{scope}/{code}/metadata/{metadataKey} | DeleteKeyFromPortfolioAccessMetadata: Delete a Portfolio Access Metadata Rule
*PortfoliosApi* | [**DeletePortfolio**](docs/PortfoliosApi.md#deleteportfolio) | **DELETE** /api/portfolios/{scope}/{code} | DeletePortfolio: Delete portfolio
*PortfoliosApi* | [**DeletePortfolioProperties**](docs/PortfoliosApi.md#deleteportfolioproperties) | **DELETE** /api/portfolios/{scope}/{code}/properties | DeletePortfolioProperties: Delete portfolio properties
*PortfoliosApi* | [**DeletePortfolioReturns**](docs/PortfoliosApi.md#deleteportfolioreturns) | **DELETE** /api/portfolios/{scope}/{code}/returns/{returnScope}/{returnCode}/$delete | [EARLY ACCESS] DeletePortfolioReturns: Delete Returns
*PortfoliosApi* | [**GetAggregatedReturnsDispersionMetrics**](docs/PortfoliosApi.md#getaggregatedreturnsdispersionmetrics) | **POST** /api/portfolios/{scope}/{code}/returns/dispersion/$aggregated | [EARLY ACCESS] GetAggregatedReturnsDispersionMetrics: Get the Aggregated Returns Dispersion metric
*PortfoliosApi* | [**GetCompositeBreakdown**](docs/PortfoliosApi.md#getcompositebreakdown) | **POST** /api/portfolios/{scope}/{code}/returns/breakdown | [EARLY ACCESS] GetCompositeBreakdown: Get the Composite Breakdown on how the composite Returns are calculated
*PortfoliosApi* | [**GetInstrumentEventInstruction**](docs/PortfoliosApi.md#getinstrumenteventinstruction) | **GET** /api/portfolios/{scope}/{code}/instrumenteventinstructions/{instrumentEventInstructionId} | [EARLY ACCESS] GetInstrumentEventInstruction: Get Instrument Event Instruction
*PortfoliosApi* | [**GetPortfolio**](docs/PortfoliosApi.md#getportfolio) | **GET** /api/portfolios/{scope}/{code} | GetPortfolio: Get portfolio
*PortfoliosApi* | [**GetPortfolioAggregateReturns**](docs/PortfoliosApi.md#getportfolioaggregatereturns) | **GET** /api/portfolios/{scope}/{code}/returns/{returnScope}/{returnCode}/aggregated | [DEPRECATED] GetPortfolioAggregateReturns: Aggregate Returns (This is a deprecated endpoint).
*PortfoliosApi* | [**GetPortfolioAggregatedReturns**](docs/PortfoliosApi.md#getportfolioaggregatedreturns) | **POST** /api/portfolios/{scope}/{code}/returns/$aggregated | GetPortfolioAggregatedReturns: Aggregated Returns
*PortfoliosApi* | [**GetPortfolioCommands**](docs/PortfoliosApi.md#getportfoliocommands) | **GET** /api/portfolios/{scope}/{code}/commands | GetPortfolioCommands: Get portfolio commands
*PortfoliosApi* | [**GetPortfolioMetadata**](docs/PortfoliosApi.md#getportfoliometadata) | **GET** /api/portfolios/{scope}/{code}/metadata | GetPortfolioMetadata: Get access metadata rules for a portfolio
*PortfoliosApi* | [**GetPortfolioProperties**](docs/PortfoliosApi.md#getportfolioproperties) | **GET** /api/portfolios/{scope}/{code}/properties | GetPortfolioProperties: Get portfolio properties
*PortfoliosApi* | [**GetPortfolioPropertyTimeSeries**](docs/PortfoliosApi.md#getportfoliopropertytimeseries) | **GET** /api/portfolios/{scope}/{code}/properties/time-series | GetPortfolioPropertyTimeSeries: Get portfolio property time series
*PortfoliosApi* | [**GetPortfolioRelations**](docs/PortfoliosApi.md#getportfoliorelations) | **GET** /api/portfolios/{scope}/{code}/relations | [EXPERIMENTAL] GetPortfolioRelations: Get portfolio relations
*PortfoliosApi* | [**GetPortfolioRelationships**](docs/PortfoliosApi.md#getportfoliorelationships) | **GET** /api/portfolios/{scope}/{code}/relationships | GetPortfolioRelationships: Get portfolio relationships
*PortfoliosApi* | [**GetPortfolioReturns**](docs/PortfoliosApi.md#getportfolioreturns) | **GET** /api/portfolios/{scope}/{code}/returns/{returnScope}/{returnCode} | GetPortfolioReturns: Get Returns
*PortfoliosApi* | [**GetPortfoliosAccessMetadataByKey**](docs/PortfoliosApi.md#getportfoliosaccessmetadatabykey) | **GET** /api/portfolios/{scope}/{code}/metadata/{metadataKey} | [EARLY ACCESS] GetPortfoliosAccessMetadataByKey: Get an entry identified by a metadataKey in the access metadata object
*PortfoliosApi* | [**ListInstrumentEventInstructions**](docs/PortfoliosApi.md#listinstrumenteventinstructions) | **GET** /api/portfolios/{scope}/{code}/instrumenteventinstructions | [EARLY ACCESS] ListInstrumentEventInstructions: List Instrument Event Instructions
*PortfoliosApi* | [**ListPortfolioProperties**](docs/PortfoliosApi.md#listportfolioproperties) | **GET** /api/portfolios/{scope}/{code}/properties/list | [EARLY ACCESS] ListPortfolioProperties: Get portfolio properties
*PortfoliosApi* | [**ListPortfolios**](docs/PortfoliosApi.md#listportfolios) | **GET** /api/portfolios | ListPortfolios: List portfolios
*PortfoliosApi* | [**ListPortfoliosForScope**](docs/PortfoliosApi.md#listportfoliosforscope) | **GET** /api/portfolios/{scope} | ListPortfoliosForScope: List portfolios for scope
*PortfoliosApi* | [**PatchPortfolio**](docs/PortfoliosApi.md#patchportfolio) | **PATCH** /api/portfolios/{scope}/{code} | PatchPortfolio: Patch portfolio.
*PortfoliosApi* | [**PatchPortfolioAccessMetadata**](docs/PortfoliosApi.md#patchportfolioaccessmetadata) | **PATCH** /api/portfolios/{scope}/{code}/metadata | [EARLY ACCESS] PatchPortfolioAccessMetadata: Patch Access Metadata rules for a Portfolio.
*PortfoliosApi* | [**UpdatePortfolio**](docs/PortfoliosApi.md#updateportfolio) | **PUT** /api/portfolios/{scope}/{code} | UpdatePortfolio: Update portfolio
*PortfoliosApi* | [**UpsertInstrumentEventInstructions**](docs/PortfoliosApi.md#upsertinstrumenteventinstructions) | **POST** /api/portfolios/{scope}/{code}/instrumenteventinstructions | [EARLY ACCESS] UpsertInstrumentEventInstructions: Upsert Instrument Event Instructions
*PortfoliosApi* | [**UpsertPortfolioAccessMetadata**](docs/PortfoliosApi.md#upsertportfolioaccessmetadata) | **PUT** /api/portfolios/{scope}/{code}/metadata/{metadataKey} | UpsertPortfolioAccessMetadata: Upsert a Portfolio Access Metadata Rule associated with specific metadataKey. This creates or updates the data in LUSID.
*PortfoliosApi* | [**UpsertPortfolioProperties**](docs/PortfoliosApi.md#upsertportfolioproperties) | **POST** /api/portfolios/{scope}/{code}/properties | UpsertPortfolioProperties: Upsert portfolio properties
*PortfoliosApi* | [**UpsertPortfolioReturns**](docs/PortfoliosApi.md#upsertportfolioreturns) | **POST** /api/portfolios/{scope}/{code}/returns/{returnScope}/{returnCode} | UpsertPortfolioReturns: Upsert Returns
*PropertyDefinitionsApi* | [**CreateDerivedPropertyDefinition**](docs/PropertyDefinitionsApi.md#createderivedpropertydefinition) | **POST** /api/propertydefinitions/derived | [EARLY ACCESS] CreateDerivedPropertyDefinition: Create derived property definition
*PropertyDefinitionsApi* | [**CreatePropertyDefinition**](docs/PropertyDefinitionsApi.md#createpropertydefinition) | **POST** /api/propertydefinitions | CreatePropertyDefinition: Create property definition
*PropertyDefinitionsApi* | [**DeletePropertyDefinition**](docs/PropertyDefinitionsApi.md#deletepropertydefinition) | **DELETE** /api/propertydefinitions/{domain}/{scope}/{code} | DeletePropertyDefinition: Delete property definition
*PropertyDefinitionsApi* | [**DeletePropertyDefinitionProperties**](docs/PropertyDefinitionsApi.md#deletepropertydefinitionproperties) | **POST** /api/propertydefinitions/{domain}/{scope}/{code}/properties/$delete | [EARLY ACCESS] DeletePropertyDefinitionProperties: Delete property definition properties
*PropertyDefinitionsApi* | [**GetMultiplePropertyDefinitions**](docs/PropertyDefinitionsApi.md#getmultiplepropertydefinitions) | **GET** /api/propertydefinitions | GetMultiplePropertyDefinitions: Get multiple property definitions
*PropertyDefinitionsApi* | [**GetPropertyDefinition**](docs/PropertyDefinitionsApi.md#getpropertydefinition) | **GET** /api/propertydefinitions/{domain}/{scope}/{code} | GetPropertyDefinition: Get property definition
*PropertyDefinitionsApi* | [**GetPropertyDefinitionPropertyTimeSeries**](docs/PropertyDefinitionsApi.md#getpropertydefinitionpropertytimeseries) | **GET** /api/propertydefinitions/{domain}/{scope}/{code}/properties/time-series | [EARLY ACCESS] GetPropertyDefinitionPropertyTimeSeries: Get Property Definition Property Time Series
*PropertyDefinitionsApi* | [**ListPropertyDefinitions**](docs/PropertyDefinitionsApi.md#listpropertydefinitions) | **GET** /api/propertydefinitions/$list | ListPropertyDefinitions: List property definitions
*PropertyDefinitionsApi* | [**UpdateDerivedPropertyDefinition**](docs/PropertyDefinitionsApi.md#updatederivedpropertydefinition) | **PUT** /api/propertydefinitions/derived/{domain}/{scope}/{code} | [EARLY ACCESS] UpdateDerivedPropertyDefinition: Update a pre-existing derived property definition
*PropertyDefinitionsApi* | [**UpdatePropertyDefinition**](docs/PropertyDefinitionsApi.md#updatepropertydefinition) | **PUT** /api/propertydefinitions/{domain}/{scope}/{code} | UpdatePropertyDefinition: Update property definition
*PropertyDefinitionsApi* | [**UpsertPropertyDefinitionProperties**](docs/PropertyDefinitionsApi.md#upsertpropertydefinitionproperties) | **POST** /api/propertydefinitions/{domain}/{scope}/{code}/properties | UpsertPropertyDefinitionProperties: Upsert properties to a property definition
*QueryableKeysApi* | [**GetAllQueryableKeys**](docs/QueryableKeysApi.md#getallqueryablekeys) | **GET** /api/queryablekeys | [EARLY ACCESS] GetAllQueryableKeys: Query the set of supported \"addresses\" that can be queried from all endpoints.
*QuotesApi* | [**DeleteQuoteAccessMetadataRule**](docs/QuotesApi.md#deletequoteaccessmetadatarule) | **DELETE** /api/metadata/quotes/rules/{scope} | [EXPERIMENTAL] DeleteQuoteAccessMetadataRule: Delete a Quote Access Metadata Rule
*QuotesApi* | [**DeleteQuotes**](docs/QuotesApi.md#deletequotes) | **POST** /api/quotes/{scope}/$delete | DeleteQuotes: Delete quotes
*QuotesApi* | [**GetQuotes**](docs/QuotesApi.md#getquotes) | **POST** /api/quotes/{scope}/$get | GetQuotes: Get quotes
*QuotesApi* | [**GetQuotesAccessMetadataRule**](docs/QuotesApi.md#getquotesaccessmetadatarule) | **GET** /api/metadata/quotes/rules | [EXPERIMENTAL] GetQuotesAccessMetadataRule: Get a quote access metadata rule
*QuotesApi* | [**ListQuotes**](docs/QuotesApi.md#listquotes) | **GET** /api/quotes/{scope}/$deprecated | [DEPRECATED] ListQuotes: List quotes
*QuotesApi* | [**ListQuotesAccessMetadataRules**](docs/QuotesApi.md#listquotesaccessmetadatarules) | **GET** /api/metadata/quotes/rules/{scope} | [EXPERIMENTAL] ListQuotesAccessMetadataRules: List all quote access metadata rules in a scope
*QuotesApi* | [**ListQuotesForScope**](docs/QuotesApi.md#listquotesforscope) | **GET** /api/quotes/{scope} | ListQuotesForScope: List quotes for scope
*QuotesApi* | [**UpsertQuoteAccessMetadataRule**](docs/QuotesApi.md#upsertquoteaccessmetadatarule) | **POST** /api/metadata/quotes/rules/{scope} | [EXPERIMENTAL] UpsertQuoteAccessMetadataRule: Upsert a Quote Access Metadata Rule. This creates or updates the data in LUSID.
*QuotesApi* | [**UpsertQuotes**](docs/QuotesApi.md#upsertquotes) | **POST** /api/quotes/{scope} | UpsertQuotes: Upsert quotes
*ReconciliationsApi* | [**CreateScheduledReconciliation**](docs/ReconciliationsApi.md#createscheduledreconciliation) | **POST** /api/portfolios/$scheduledReconciliations/{scope} | [EXPERIMENTAL] CreateScheduledReconciliation: Create a scheduled reconciliation
*ReconciliationsApi* | [**DeleteReconciliation**](docs/ReconciliationsApi.md#deletereconciliation) | **DELETE** /api/portfolios/$scheduledReconciliations/{scope}/{code} | [EXPERIMENTAL] DeleteReconciliation: Delete scheduled reconciliation
*ReconciliationsApi* | [**DeleteReconciliationMapping**](docs/ReconciliationsApi.md#deletereconciliationmapping) | **DELETE** /api/portfolios/mapping/{scope}/{code} | [EARLY ACCESS] DeleteReconciliationMapping: Delete a mapping
*ReconciliationsApi* | [**GetReconciliation**](docs/ReconciliationsApi.md#getreconciliation) | **GET** /api/portfolios/$scheduledReconciliations/{scope}/{code} | [EXPERIMENTAL] GetReconciliation: Get scheduled reconciliation
*ReconciliationsApi* | [**GetReconciliationMapping**](docs/ReconciliationsApi.md#getreconciliationmapping) | **GET** /api/portfolios/mapping/{scope}/{code} | [EARLY ACCESS] GetReconciliationMapping: Get a mapping
*ReconciliationsApi* | [**ListReconciliationMappings**](docs/ReconciliationsApi.md#listreconciliationmappings) | **GET** /api/portfolios/mapping | [EARLY ACCESS] ListReconciliationMappings: List the reconciliation mappings
*ReconciliationsApi* | [**ListReconciliations**](docs/ReconciliationsApi.md#listreconciliations) | **GET** /api/portfolios/$scheduledReconciliations | [EXPERIMENTAL] ListReconciliations: List scheduled reconciliations
*ReconciliationsApi* | [**ReconcileGeneric**](docs/ReconciliationsApi.md#reconcilegeneric) | **POST** /api/portfolios/$reconcileGeneric | ReconcileGeneric: Reconcile either holdings or valuations performed on one or two sets of holdings using one or two configuration recipes.                The output is configurable for various types of comparisons, to allow tolerances on numerical and date-time data or case-insensitivity on strings,  and elision of resulting differences where they are 'empty' or null or zero.
*ReconciliationsApi* | [**ReconcileHoldings**](docs/ReconciliationsApi.md#reconcileholdings) | **POST** /api/portfolios/$reconcileholdings | [EARLY ACCESS] ReconcileHoldings: Reconcile portfolio holdings
*ReconciliationsApi* | [**ReconcileInline**](docs/ReconciliationsApi.md#reconcileinline) | **POST** /api/portfolios/$reconcileInline | ReconcileInline: Reconcile valuations performed on one or two sets of inline instruments using one or two configuration recipes.
*ReconciliationsApi* | [**ReconcileTransactions**](docs/ReconciliationsApi.md#reconciletransactions) | **POST** /api/portfolios/$reconcileTransactions | [EARLY ACCESS] ReconcileTransactions: Perform a Transactions Reconciliation.
*ReconciliationsApi* | [**ReconcileTransactionsV2**](docs/ReconciliationsApi.md#reconciletransactionsv2) | **POST** /api/portfolios/$reconcileTransactionsV2 | [EXPERIMENTAL] ReconcileTransactionsV2: Perform a Transactions Reconciliation.
*ReconciliationsApi* | [**ReconcileValuation**](docs/ReconciliationsApi.md#reconcilevaluation) | **POST** /api/portfolios/$reconcileValuation | ReconcileValuation: Reconcile valuations performed on one or two sets of holdings using one or two configuration recipes.
*ReconciliationsApi* | [**UpdateReconciliation**](docs/ReconciliationsApi.md#updatereconciliation) | **POST** /api/portfolios/$scheduledReconciliations/{scope}/{code} | [EXPERIMENTAL] UpdateReconciliation: Update scheduled reconciliation
*ReconciliationsApi* | [**UpsertReconciliationMapping**](docs/ReconciliationsApi.md#upsertreconciliationmapping) | **POST** /api/portfolios/mapping | [EARLY ACCESS] UpsertReconciliationMapping: Create or update a mapping
*ReferenceListsApi* | [**DeleteReferenceList**](docs/ReferenceListsApi.md#deletereferencelist) | **DELETE** /api/referencelists/{scope}/{code} | [EARLY ACCESS] DeleteReferenceList: Delete Reference List
*ReferenceListsApi* | [**GetReferenceList**](docs/ReferenceListsApi.md#getreferencelist) | **GET** /api/referencelists/{scope}/{code} | GetReferenceList: Get Reference List
*ReferenceListsApi* | [**ListReferenceLists**](docs/ReferenceListsApi.md#listreferencelists) | **GET** /api/referencelists | [EARLY ACCESS] ListReferenceLists: List Reference Lists
*ReferenceListsApi* | [**UpsertReferenceList**](docs/ReferenceListsApi.md#upsertreferencelist) | **POST** /api/referencelists | [EARLY ACCESS] UpsertReferenceList: Upsert Reference List
*ReferencePortfolioApi* | [**CreateReferencePortfolio**](docs/ReferencePortfolioApi.md#createreferenceportfolio) | **POST** /api/referenceportfolios/{scope} | CreateReferencePortfolio: Create reference portfolio
*ReferencePortfolioApi* | [**GetReferencePortfolioConstituents**](docs/ReferencePortfolioApi.md#getreferenceportfolioconstituents) | **GET** /api/referenceportfolios/{scope}/{code}/constituents | GetReferencePortfolioConstituents: Get reference portfolio constituents
*ReferencePortfolioApi* | [**ListConstituentsAdjustments**](docs/ReferencePortfolioApi.md#listconstituentsadjustments) | **GET** /api/referenceportfolios/{scope}/{code}/constituentsadjustments | ListConstituentsAdjustments: List constituents adjustments
*ReferencePortfolioApi* | [**UpsertReferencePortfolioConstituentProperties**](docs/ReferencePortfolioApi.md#upsertreferenceportfolioconstituentproperties) | **POST** /api/referenceportfolios/{scope}/{code}/constituents/properties | [EARLY ACCESS] UpsertReferencePortfolioConstituentProperties: Upsert constituent properties
*ReferencePortfolioApi* | [**UpsertReferencePortfolioConstituents**](docs/ReferencePortfolioApi.md#upsertreferenceportfolioconstituents) | **POST** /api/referenceportfolios/{scope}/{code}/constituents | UpsertReferencePortfolioConstituents: Upsert reference portfolio constituents
*RelationDefinitionsApi* | [**CreateRelationDefinition**](docs/RelationDefinitionsApi.md#createrelationdefinition) | **POST** /api/relationdefinitions | [EXPERIMENTAL] CreateRelationDefinition: Create a relation definition
*RelationDefinitionsApi* | [**DeleteRelationDefinition**](docs/RelationDefinitionsApi.md#deleterelationdefinition) | **DELETE** /api/relationdefinitions/{scope}/{code} | [EXPERIMENTAL] DeleteRelationDefinition: Delete relation definition
*RelationDefinitionsApi* | [**GetRelationDefinition**](docs/RelationDefinitionsApi.md#getrelationdefinition) | **GET** /api/relationdefinitions/{scope}/{code} | [EXPERIMENTAL] GetRelationDefinition: Get relation definition
*RelationsApi* | [**CreateRelation**](docs/RelationsApi.md#createrelation) | **POST** /api/relations/{scope}/{code} | [EXPERIMENTAL] CreateRelation: Create Relation
*RelationsApi* | [**DeleteRelation**](docs/RelationsApi.md#deleterelation) | **POST** /api/relations/{scope}/{code}/$delete | [EXPERIMENTAL] DeleteRelation: Delete a relation
*RelationshipDefinitionsApi* | [**CreateRelationshipDefinition**](docs/RelationshipDefinitionsApi.md#createrelationshipdefinition) | **POST** /api/relationshipdefinitions | [EARLY ACCESS] CreateRelationshipDefinition: Create Relationship Definition
*RelationshipDefinitionsApi* | [**DeleteRelationshipDefinition**](docs/RelationshipDefinitionsApi.md#deleterelationshipdefinition) | **DELETE** /api/relationshipdefinitions/{scope}/{code} | [EARLY ACCESS] DeleteRelationshipDefinition: Delete Relationship Definition
*RelationshipDefinitionsApi* | [**GetRelationshipDefinition**](docs/RelationshipDefinitionsApi.md#getrelationshipdefinition) | **GET** /api/relationshipdefinitions/{scope}/{code} | [EARLY ACCESS] GetRelationshipDefinition: Get relationship definition
*RelationshipDefinitionsApi* | [**ListRelationshipDefinitions**](docs/RelationshipDefinitionsApi.md#listrelationshipdefinitions) | **GET** /api/relationshipdefinitions | [EARLY ACCESS] ListRelationshipDefinitions: List relationship definitions
*RelationshipDefinitionsApi* | [**UpdateRelationshipDefinition**](docs/RelationshipDefinitionsApi.md#updaterelationshipdefinition) | **PUT** /api/relationshipdefinitions/{scope}/{code} | [EARLY ACCESS] UpdateRelationshipDefinition: Update Relationship Definition
*RelationshipsApi* | [**CreateRelationship**](docs/RelationshipsApi.md#createrelationship) | **POST** /api/relationshipdefinitions/{scope}/{code}/relationships | CreateRelationship: Create Relationship
*RelationshipsApi* | [**DeleteRelationship**](docs/RelationshipsApi.md#deleterelationship) | **POST** /api/relationshipdefinitions/{scope}/{code}/relationships/$delete | [EARLY ACCESS] DeleteRelationship: Delete Relationship
*SchemasApi* | [**GetEntitySchema**](docs/SchemasApi.md#getentityschema) | **GET** /api/schemas/entities/{entity} | [EARLY ACCESS] GetEntitySchema: Get schema
*SchemasApi* | [**GetPropertySchema**](docs/SchemasApi.md#getpropertyschema) | **GET** /api/schemas/properties | [EARLY ACCESS] GetPropertySchema: Get property schema
*SchemasApi* | [**GetValueTypes**](docs/SchemasApi.md#getvaluetypes) | **GET** /api/schemas/types | [EARLY ACCESS] GetValueTypes: Get value types
*SchemasApi* | [**ListEntities**](docs/SchemasApi.md#listentities) | **GET** /api/schemas/entities | [EARLY ACCESS] ListEntities: List entities
*ScopesApi* | [**ListEntityScopes**](docs/ScopesApi.md#listentityscopes) | **GET** /api/scopes/{entityType} | ListEntityScopes: List Entity Scopes
*ScopesApi* | [**ListScopes**](docs/ScopesApi.md#listscopes) | **GET** /api/scopes | ListScopes: List Scopes
*ScriptedTranslationApi* | [**GetTranslationDialect**](docs/ScriptedTranslationApi.md#gettranslationdialect) | **GET** /api/scriptedtranslation/dialects/{scope}/{vendor}/{sourceSystem}/{entityType}/{serialisationFormat}/{version} | [EARLY ACCESS] GetTranslationDialect: Get a dialect.
*ScriptedTranslationApi* | [**GetTranslationScript**](docs/ScriptedTranslationApi.md#gettranslationscript) | **GET** /api/scriptedtranslation/scripts/{scope}/{code}/{version} | [EARLY ACCESS] GetTranslationScript: Retrieve a translation script by its identifier.
*ScriptedTranslationApi* | [**ListDialectIds**](docs/ScriptedTranslationApi.md#listdialectids) | **GET** /api/scriptedtranslation/dialects/ids | [EARLY ACCESS] ListDialectIds: List dialect identifiers matching an optional filter.
*ScriptedTranslationApi* | [**ListTranslationScriptIds**](docs/ScriptedTranslationApi.md#listtranslationscriptids) | **GET** /api/scriptedtranslation/scripts/ids | [EARLY ACCESS] ListTranslationScriptIds: List translation script identifiers.
*ScriptedTranslationApi* | [**TranslateEntities**](docs/ScriptedTranslationApi.md#translateentities) | **POST** /api/scriptedtranslation/translateentities | [EARLY ACCESS] TranslateEntities: Translate a collection of entities with a specified translation script.
*ScriptedTranslationApi* | [**TranslateEntitiesInlined**](docs/ScriptedTranslationApi.md#translateentitiesinlined) | **POST** /api/scriptedtranslation/translateentitiesinlined | [EARLY ACCESS] TranslateEntitiesInlined: Translate a collection of entities, inlining the body of the translation script.
*ScriptedTranslationApi* | [**UpsertTranslationDialect**](docs/ScriptedTranslationApi.md#upserttranslationdialect) | **POST** /api/scriptedtranslation/dialects | [EARLY ACCESS] UpsertTranslationDialect: Upsert a Dialect.
*ScriptedTranslationApi* | [**UpsertTranslationScript**](docs/ScriptedTranslationApi.md#upserttranslationscript) | **POST** /api/scriptedtranslation/scripts | [EARLY ACCESS] UpsertTranslationScript: Upsert a translation script.
*SearchApi* | [**InstrumentsSearch**](docs/SearchApi.md#instrumentssearch) | **POST** /api/search/instruments | [EARLY ACCESS] InstrumentsSearch: Instruments search
*SearchApi* | [**SearchPortfolioGroups**](docs/SearchApi.md#searchportfoliogroups) | **GET** /api/search/portfoliogroups | SearchPortfolioGroups: Search Portfolio Groups
*SearchApi* | [**SearchPortfolios**](docs/SearchApi.md#searchportfolios) | **GET** /api/search/portfolios | SearchPortfolios: Search Portfolios
*SearchApi* | [**SearchProperties**](docs/SearchApi.md#searchproperties) | **GET** /api/search/propertydefinitions | SearchProperties: Search Property Definitions
*SequencesApi* | [**CreateSequence**](docs/SequencesApi.md#createsequence) | **POST** /api/sequences/{scope} | [EARLY ACCESS] CreateSequence: Create a new sequence
*SequencesApi* | [**GetSequence**](docs/SequencesApi.md#getsequence) | **GET** /api/sequences/{scope}/{code} | [EARLY ACCESS] GetSequence: Get a specified sequence
*SequencesApi* | [**ListSequences**](docs/SequencesApi.md#listsequences) | **GET** /api/sequences | [EARLY ACCESS] ListSequences: List Sequences
*SequencesApi* | [**Next**](docs/SequencesApi.md#next) | **GET** /api/sequences/{scope}/{code}/next | [EARLY ACCESS] Next: Get next values from sequence
*StagedModificationsApi* | [**AddDecision**](docs/StagedModificationsApi.md#adddecision) | **POST** /api/stagedmodifications/{id}/decision | [EXPERIMENTAL] AddDecision: AddDecision
*StagedModificationsApi* | [**GetStagedModification**](docs/StagedModificationsApi.md#getstagedmodification) | **GET** /api/stagedmodifications/{id} | [EXPERIMENTAL] GetStagedModification: GetStagedModification
*StagedModificationsApi* | [**ListRequestedChanges**](docs/StagedModificationsApi.md#listrequestedchanges) | **GET** /api/stagedmodifications/{id}/requestedChanges | [EXPERIMENTAL] ListRequestedChanges: ListRequestedChanges
*StagedModificationsApi* | [**ListStagedModifications**](docs/StagedModificationsApi.md#liststagedmodifications) | **GET** /api/stagedmodifications | [EXPERIMENTAL] ListStagedModifications: ListStagedModifications
*StagingRuleSetApi* | [**CreateStagingRuleSet**](docs/StagingRuleSetApi.md#createstagingruleset) | **POST** /api/stagingrulesets/{entityType} | [EXPERIMENTAL] CreateStagingRuleSet: Create a StagingRuleSet
*StagingRuleSetApi* | [**DeleteStagingRuleSet**](docs/StagingRuleSetApi.md#deletestagingruleset) | **DELETE** /api/stagingrulesets/{entityType} | [EXPERIMENTAL] DeleteStagingRuleSet: Delete a StagingRuleSet
*StagingRuleSetApi* | [**GetStagingRuleSet**](docs/StagingRuleSetApi.md#getstagingruleset) | **GET** /api/stagingrulesets/{entityType} | [EXPERIMENTAL] GetStagingRuleSet: Get a StagingRuleSet
*StagingRuleSetApi* | [**ListStagingRuleSets**](docs/StagingRuleSetApi.md#liststagingrulesets) | **GET** /api/stagingrulesets | [EXPERIMENTAL] ListStagingRuleSets: List StagingRuleSets
*StagingRuleSetApi* | [**UpdateStagingRuleSet**](docs/StagingRuleSetApi.md#updatestagingruleset) | **PUT** /api/stagingrulesets/{entityType} | [EXPERIMENTAL] UpdateStagingRuleSet: Update a StagingRuleSet
*StructuredResultDataApi* | [**CreateDataMap**](docs/StructuredResultDataApi.md#createdatamap) | **POST** /api/unitresults/datamap/{scope} | CreateDataMap: Create data map
*StructuredResultDataApi* | [**DeleteStructuredResultData**](docs/StructuredResultDataApi.md#deletestructuredresultdata) | **POST** /api/unitresults/{scope}/$delete | [EXPERIMENTAL] DeleteStructuredResultData: Delete structured result data
*StructuredResultDataApi* | [**GetAddressKeyDefinitionsForDocument**](docs/StructuredResultDataApi.md#getaddresskeydefinitionsfordocument) | **GET** /api/unitresults/virtualdocument/{scope}/{code}/{source}/{resultType}/addresskeydefinitions | [EARLY ACCESS] GetAddressKeyDefinitionsForDocument: Get AddressKeyDefinitions for a virtual document.
*StructuredResultDataApi* | [**GetDataMap**](docs/StructuredResultDataApi.md#getdatamap) | **POST** /api/unitresults/datamap/{scope}/$get | [EXPERIMENTAL] GetDataMap: Get data map
*StructuredResultDataApi* | [**GetStructuredResultData**](docs/StructuredResultDataApi.md#getstructuredresultdata) | **POST** /api/unitresults/{scope}/$get | GetStructuredResultData: Get structured result data
*StructuredResultDataApi* | [**GetVirtualDocument**](docs/StructuredResultDataApi.md#getvirtualdocument) | **POST** /api/unitresults/virtualdocument/{scope}/$get | [EXPERIMENTAL] GetVirtualDocument: Get Virtual Documents
*StructuredResultDataApi* | [**GetVirtualDocumentRows**](docs/StructuredResultDataApi.md#getvirtualdocumentrows) | **GET** /api/unitresults/virtualdocument/{scope}/{code}/{source}/{resultType} | [EARLY ACCESS] GetVirtualDocumentRows: Get Virtual Document Rows
*StructuredResultDataApi* | [**UpsertResultValue**](docs/StructuredResultDataApi.md#upsertresultvalue) | **POST** /api/unitresults/resultvalue/{scope} | [EXPERIMENTAL] UpsertResultValue: Upsert result value
*StructuredResultDataApi* | [**UpsertStructuredResultData**](docs/StructuredResultDataApi.md#upsertstructuredresultdata) | **POST** /api/unitresults/{scope} | UpsertStructuredResultData: Upsert structured result data
*SystemConfigurationApi* | [**CreateConfigurationTransactionType**](docs/SystemConfigurationApi.md#createconfigurationtransactiontype) | **POST** /api/systemconfiguration/transactions/type | [EARLY ACCESS] CreateConfigurationTransactionType: Create transaction type
*SystemConfigurationApi* | [**CreateSideDefinition**](docs/SystemConfigurationApi.md#createsidedefinition) | **POST** /api/systemconfiguration/transactions/side | [EXPERIMENTAL] CreateSideDefinition: Create side definition
*SystemConfigurationApi* | [**DeleteTransactionConfigurationSource**](docs/SystemConfigurationApi.md#deletetransactionconfigurationsource) | **DELETE** /api/systemconfiguration/transactions/type/{source} | [EXPERIMENTAL] DeleteTransactionConfigurationSource: Delete all transaction configurations for a source
*SystemConfigurationApi* | [**GetTransactionConfigurationSource**](docs/SystemConfigurationApi.md#gettransactionconfigurationsource) | **GET** /api/systemconfiguration/transactions/type/{source} | [EXPERIMENTAL] GetTransactionConfigurationSource: Get all transaction configurations for a source
*SystemConfigurationApi* | [**ListConfigurationTransactionTypes**](docs/SystemConfigurationApi.md#listconfigurationtransactiontypes) | **GET** /api/systemconfiguration/transactions | [EARLY ACCESS] ListConfigurationTransactionTypes: List transaction types
*SystemConfigurationApi* | [**SetConfigurationTransactionTypes**](docs/SystemConfigurationApi.md#setconfigurationtransactiontypes) | **PUT** /api/systemconfiguration/transactions | [EXPERIMENTAL] SetConfigurationTransactionTypes: Set transaction types
*SystemConfigurationApi* | [**SetTransactionConfigurationSource**](docs/SystemConfigurationApi.md#settransactionconfigurationsource) | **PUT** /api/systemconfiguration/transactions/type/{source} | [EXPERIMENTAL] SetTransactionConfigurationSource: Set transaction types for a source
*TaxRuleSetsApi* | [**CreateTaxRuleSet**](docs/TaxRuleSetsApi.md#createtaxruleset) | **POST** /api/tax/rulesets | [EXPERIMENTAL] CreateTaxRuleSet: Create a tax rule set.
*TaxRuleSetsApi* | [**DeleteTaxRuleSet**](docs/TaxRuleSetsApi.md#deletetaxruleset) | **DELETE** /api/tax/rulesets/{scope}/{code} | [EXPERIMENTAL] DeleteTaxRuleSet: Delete a tax rule set.
*TaxRuleSetsApi* | [**GetTaxRuleSet**](docs/TaxRuleSetsApi.md#gettaxruleset) | **GET** /api/tax/rulesets/{scope}/{code} | [EXPERIMENTAL] GetTaxRuleSet: Retrieve the definition of single tax rule set.
*TaxRuleSetsApi* | [**ListTaxRuleSets**](docs/TaxRuleSetsApi.md#listtaxrulesets) | **GET** /api/tax/rulesets | [EXPERIMENTAL] ListTaxRuleSets: List tax rule sets.
*TaxRuleSetsApi* | [**UpdateTaxRuleSet**](docs/TaxRuleSetsApi.md#updatetaxruleset) | **PUT** /api/tax/rulesets/{scope}/{code} | [EXPERIMENTAL] UpdateTaxRuleSet: Update a tax rule set.
*TransactionConfigurationApi* | [**DeleteSideDefinition**](docs/TransactionConfigurationApi.md#deletesidedefinition) | **DELETE** /api/transactionconfiguration/sides/{side}/$delete | DeleteSideDefinition: Delete the given side definition
*TransactionConfigurationApi* | [**DeleteTransactionType**](docs/TransactionConfigurationApi.md#deletetransactiontype) | **DELETE** /api/transactionconfiguration/types/{source}/{type} | DeleteTransactionType: Delete a transaction type
*TransactionConfigurationApi* | [**DeleteTransactionTypeSource**](docs/TransactionConfigurationApi.md#deletetransactiontypesource) | **DELETE** /api/transactionconfiguration/types/{source}/$delete | DeleteTransactionTypeSource: Delete all transaction types for the given source and scope
*TransactionConfigurationApi* | [**GetSideDefinition**](docs/TransactionConfigurationApi.md#getsidedefinition) | **GET** /api/transactionconfiguration/sides/{side} | GetSideDefinition: Get the side definition for a given side name( or label)
*TransactionConfigurationApi* | [**GetTransactionType**](docs/TransactionConfigurationApi.md#gettransactiontype) | **GET** /api/transactionconfiguration/types/{source}/{type} | GetTransactionType: Get a single transaction configuration type
*TransactionConfigurationApi* | [**ListSideDefinitions**](docs/TransactionConfigurationApi.md#listsidedefinitions) | **GET** /api/transactionconfiguration/sides | ListSideDefinitions: List the side definitions
*TransactionConfigurationApi* | [**ListTransactionTypes**](docs/TransactionConfigurationApi.md#listtransactiontypes) | **GET** /api/transactionconfiguration/types | ListTransactionTypes: List transaction types
*TransactionConfigurationApi* | [**SetSideDefinition**](docs/TransactionConfigurationApi.md#setsidedefinition) | **PUT** /api/transactionconfiguration/sides/{side} | SetSideDefinition: Set a side definition
*TransactionConfigurationApi* | [**SetSideDefinitions**](docs/TransactionConfigurationApi.md#setsidedefinitions) | **PUT** /api/transactionconfiguration/sides | SetSideDefinitions: Set the given side definitions
*TransactionConfigurationApi* | [**SetTransactionType**](docs/TransactionConfigurationApi.md#settransactiontype) | **PUT** /api/transactionconfiguration/types/{source}/{type} | SetTransactionType: Set a specific transaction type
*TransactionConfigurationApi* | [**SetTransactionTypeSource**](docs/TransactionConfigurationApi.md#settransactiontypesource) | **PUT** /api/transactionconfiguration/types/{source} | SetTransactionTypeSource: Set the transaction types for the given source and scope
*TransactionFeesApi* | [**DeleteTransactionFeeRule**](docs/TransactionFeesApi.md#deletetransactionfeerule) | **DELETE** /api/transactions/fees/rules/{code} | [EXPERIMENTAL] DeleteTransactionFeeRule: Deletes a fee rule.
*TransactionFeesApi* | [**GetApplicableTransactionFees**](docs/TransactionFeesApi.md#getapplicabletransactionfees) | **POST** /api/transactions/fees/$GetApplicableFees | [EXPERIMENTAL] GetApplicableTransactionFees: Get the Fees and Commissions that may be applicable to a transaction.
*TransactionFeesApi* | [**GetTransactionFeeRule**](docs/TransactionFeesApi.md#gettransactionfeerule) | **GET** /api/transactions/fees/rules/{code} | [EXPERIMENTAL] GetTransactionFeeRule: Retrieve the definition of single fee rule.
*TransactionFeesApi* | [**ListTransactionFeeRules**](docs/TransactionFeesApi.md#listtransactionfeerules) | **GET** /api/transactions/fees/rules | [EXPERIMENTAL] ListTransactionFeeRules: List fee rules, with optional filtering.
*TransactionFeesApi* | [**UpsertTransactionFeeRules**](docs/TransactionFeesApi.md#upserttransactionfeerules) | **POST** /api/transactions/fees/rules | [EXPERIMENTAL] UpsertTransactionFeeRules: Upsert fee rules.
*TransactionPortfoliosApi* | [**AdjustHoldings**](docs/TransactionPortfoliosApi.md#adjustholdings) | **POST** /api/transactionportfolios/{scope}/{code}/holdings | AdjustHoldings: Adjust holdings
*TransactionPortfoliosApi* | [**BatchAdjustHoldings**](docs/TransactionPortfoliosApi.md#batchadjustholdings) | **POST** /api/transactionportfolios/{scope}/{code}/holdings/$batchAdjust | [EARLY ACCESS] BatchAdjustHoldings: Batch adjust holdings
*TransactionPortfoliosApi* | [**BatchCreateTradeTickets**](docs/TransactionPortfoliosApi.md#batchcreatetradetickets) | **POST** /api/transactionportfolios/{scope}/{code}/$batchtradetickets | [EARLY ACCESS] BatchCreateTradeTickets: Batch Create Trade Tickets
*TransactionPortfoliosApi* | [**BatchUpsertTransactions**](docs/TransactionPortfoliosApi.md#batchupserttransactions) | **POST** /api/transactionportfolios/{scope}/{code}/transactions/$batchUpsert | [EARLY ACCESS] BatchUpsertTransactions: Batch upsert transactions
*TransactionPortfoliosApi* | [**BuildTransactions**](docs/TransactionPortfoliosApi.md#buildtransactions) | **POST** /api/transactionportfolios/{scope}/{code}/transactions/$build | BuildTransactions: Build transactions
*TransactionPortfoliosApi* | [**CancelAdjustHoldings**](docs/TransactionPortfoliosApi.md#canceladjustholdings) | **DELETE** /api/transactionportfolios/{scope}/{code}/holdings | CancelAdjustHoldings: Cancel adjust holdings
*TransactionPortfoliosApi* | [**CancelTransactions**](docs/TransactionPortfoliosApi.md#canceltransactions) | **DELETE** /api/transactionportfolios/{scope}/{code}/transactions | CancelTransactions: Cancel transactions
*TransactionPortfoliosApi* | [**CreatePortfolio**](docs/TransactionPortfoliosApi.md#createportfolio) | **POST** /api/transactionportfolios/{scope} | CreatePortfolio: Create portfolio
*TransactionPortfoliosApi* | [**CreateTradeTicket**](docs/TransactionPortfoliosApi.md#createtradeticket) | **POST** /api/transactionportfolios/{scope}/{code}/$tradeticket | [EARLY ACCESS] CreateTradeTicket: Create Trade Ticket
*TransactionPortfoliosApi* | [**DeleteCustodianAccounts**](docs/TransactionPortfoliosApi.md#deletecustodianaccounts) | **POST** /api/transactionportfolios/{scope}/{code}/custodianaccounts/$delete | [EXPERIMENTAL] DeleteCustodianAccounts: Soft or hard delete multiple custodian accounts
*TransactionPortfoliosApi* | [**DeletePropertiesFromTransaction**](docs/TransactionPortfoliosApi.md#deletepropertiesfromtransaction) | **DELETE** /api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/properties | DeletePropertiesFromTransaction: Delete properties from transaction
*TransactionPortfoliosApi* | [**GetA2BData**](docs/TransactionPortfoliosApi.md#geta2bdata) | **GET** /api/transactionportfolios/{scope}/{code}/a2b | GetA2BData: Get A2B data
*TransactionPortfoliosApi* | [**GetA2BMovements**](docs/TransactionPortfoliosApi.md#geta2bmovements) | **GET** /api/transactionportfolios/{scope}/{code}/a2bmovements | GetA2BMovements: Get an A2B report at the movement level for the given portfolio.
*TransactionPortfoliosApi* | [**GetBucketedCashFlows**](docs/TransactionPortfoliosApi.md#getbucketedcashflows) | **POST** /api/transactionportfolios/{scope}/{code}/bucketedCashFlows | [EXPERIMENTAL] GetBucketedCashFlows: Get bucketed cash flows from a list of portfolios
*TransactionPortfoliosApi* | [**GetCustodianAccount**](docs/TransactionPortfoliosApi.md#getcustodianaccount) | **GET** /api/transactionportfolios/{scope}/{code}/custodianaccounts/{custodianAccountScope}/{custodianAccountCode} | [EXPERIMENTAL] GetCustodianAccount: Get Custodian Account
*TransactionPortfoliosApi* | [**GetDetails**](docs/TransactionPortfoliosApi.md#getdetails) | **GET** /api/transactionportfolios/{scope}/{code}/details | GetDetails: Get details
*TransactionPortfoliosApi* | [**GetHoldingContributors**](docs/TransactionPortfoliosApi.md#getholdingcontributors) | **GET** /api/transactionportfolios/{scope}/{code}/holdings/{holdingId}/contributors | [EARLY ACCESS] GetHoldingContributors: Get Holdings Contributors
*TransactionPortfoliosApi* | [**GetHoldings**](docs/TransactionPortfoliosApi.md#getholdings) | **GET** /api/transactionportfolios/{scope}/{code}/holdings | GetHoldings: Get holdings
*TransactionPortfoliosApi* | [**GetHoldingsAdjustment**](docs/TransactionPortfoliosApi.md#getholdingsadjustment) | **GET** /api/transactionportfolios/{scope}/{code}/holdingsadjustments/{effectiveAt} | GetHoldingsAdjustment: Get holdings adjustment
*TransactionPortfoliosApi* | [**GetHoldingsWithOrders**](docs/TransactionPortfoliosApi.md#getholdingswithorders) | **GET** /api/transactionportfolios/{scope}/{code}/holdingsWithOrders | [EXPERIMENTAL] GetHoldingsWithOrders: Get holdings with orders
*TransactionPortfoliosApi* | [**GetMultipleHoldingContributors**](docs/TransactionPortfoliosApi.md#getmultipleholdingcontributors) | **POST** /api/transactionportfolios/{scope}/{code}/holdings/contributors/$get | [EARLY ACCESS] GetMultipleHoldingContributors: Get Multiple Holding Contributors
*TransactionPortfoliosApi* | [**GetPortfolioCashFlows**](docs/TransactionPortfoliosApi.md#getportfoliocashflows) | **GET** /api/transactionportfolios/{scope}/{code}/cashflows | GetPortfolioCashFlows: Get portfolio cash flows
*TransactionPortfoliosApi* | [**GetPortfolioCashLadder**](docs/TransactionPortfoliosApi.md#getportfoliocashladder) | **GET** /api/transactionportfolios/{scope}/{code}/cashladder | GetPortfolioCashLadder: Get portfolio cash ladder
*TransactionPortfoliosApi* | [**GetPortfolioCashStatement**](docs/TransactionPortfoliosApi.md#getportfoliocashstatement) | **GET** /api/transactionportfolios/{scope}/{code}/cashstatement | GetPortfolioCashStatement: Get portfolio cash statement
*TransactionPortfoliosApi* | [**GetTransactionHistory**](docs/TransactionPortfoliosApi.md#gettransactionhistory) | **GET** /api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/history | GetTransactionHistory: Get the history of a transaction
*TransactionPortfoliosApi* | [**GetTransactions**](docs/TransactionPortfoliosApi.md#gettransactions) | **GET** /api/transactionportfolios/{scope}/{code}/transactions | GetTransactions: Get transactions
*TransactionPortfoliosApi* | [**GetUpsertablePortfolioCashFlows**](docs/TransactionPortfoliosApi.md#getupsertableportfoliocashflows) | **GET** /api/transactionportfolios/{scope}/{code}/upsertablecashflows | GetUpsertablePortfolioCashFlows: Get upsertable portfolio cash flows.
*TransactionPortfoliosApi* | [**ListCustodianAccounts**](docs/TransactionPortfoliosApi.md#listcustodianaccounts) | **GET** /api/transactionportfolios/{scope}/{code}/custodianaccounts | [EXPERIMENTAL] ListCustodianAccounts: List Custodian Accounts
*TransactionPortfoliosApi* | [**ListHoldingsAdjustments**](docs/TransactionPortfoliosApi.md#listholdingsadjustments) | **GET** /api/transactionportfolios/{scope}/{code}/holdingsadjustments | ListHoldingsAdjustments: List holdings adjustments
*TransactionPortfoliosApi* | [**PatchPortfolioDetails**](docs/TransactionPortfoliosApi.md#patchportfoliodetails) | **PATCH** /api/transactionportfolios/{scope}/{code}/details | PatchPortfolioDetails: Patch portfolio details
*TransactionPortfoliosApi* | [**PreviewTransaction**](docs/TransactionPortfoliosApi.md#previewtransaction) | **POST** /api/transactionportfolios/{scope}/{code}/previewTransaction | [EARLY ACCESS] PreviewTransaction: Preview a transaction
*TransactionPortfoliosApi* | [**ResolveInstrument**](docs/TransactionPortfoliosApi.md#resolveinstrument) | **POST** /api/transactionportfolios/{scope}/{code}/$resolve | ResolveInstrument: Resolve instrument
*TransactionPortfoliosApi* | [**SetHoldings**](docs/TransactionPortfoliosApi.md#setholdings) | **PUT** /api/transactionportfolios/{scope}/{code}/holdings | SetHoldings: Set holdings
*TransactionPortfoliosApi* | [**UpsertCustodianAccounts**](docs/TransactionPortfoliosApi.md#upsertcustodianaccounts) | **POST** /api/transactionportfolios/{scope}/{code}/custodianaccounts | [EXPERIMENTAL] UpsertCustodianAccounts: Upsert Custodian Accounts
*TransactionPortfoliosApi* | [**UpsertCustodianAccountsProperties**](docs/TransactionPortfoliosApi.md#upsertcustodianaccountsproperties) | **POST** /api/transactionportfolios/{scope}/{code}/custodianaccounts/{custodianAccountScope}/{custodianAccountCode}/properties/$upsert | [EXPERIMENTAL] UpsertCustodianAccountsProperties: Upsert custodian accounts properties
*TransactionPortfoliosApi* | [**UpsertPortfolioDetails**](docs/TransactionPortfoliosApi.md#upsertportfoliodetails) | **POST** /api/transactionportfolios/{scope}/{code}/details | UpsertPortfolioDetails: Upsert portfolio details
*TransactionPortfoliosApi* | [**UpsertTransactionProperties**](docs/TransactionPortfoliosApi.md#upserttransactionproperties) | **POST** /api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/properties | UpsertTransactionProperties: Upsert transaction properties
*TransactionPortfoliosApi* | [**UpsertTransactions**](docs/TransactionPortfoliosApi.md#upserttransactions) | **POST** /api/transactionportfolios/{scope}/{code}/transactions | UpsertTransactions: Upsert transactions
*TranslationApi* | [**TranslateInstrumentDefinitions**](docs/TranslationApi.md#translateinstrumentdefinitions) | **POST** /api/translation/instrumentdefinitions | [EXPERIMENTAL] TranslateInstrumentDefinitions: Translate instruments
*TranslationApi* | [**TranslateTradeTickets**](docs/TranslationApi.md#translatetradetickets) | **POST** /api/translation/tradetickets | [EXPERIMENTAL] TranslateTradeTickets: Translate trade ticket
*WorkspaceApi* | [**CreatePersonalItem**](docs/WorkspaceApi.md#createpersonalitem) | **POST** /api/workspaces/personal/{workspaceName}/items | [EXPERIMENTAL] CreatePersonalItem: Create a new item in a personal workspace.
*WorkspaceApi* | [**CreatePersonalWorkspace**](docs/WorkspaceApi.md#createpersonalworkspace) | **POST** /api/workspaces/personal | [EXPERIMENTAL] CreatePersonalWorkspace: Create a new personal workspace.
*WorkspaceApi* | [**CreateSharedItem**](docs/WorkspaceApi.md#createshareditem) | **POST** /api/workspaces/shared/{workspaceName}/items | [EXPERIMENTAL] CreateSharedItem: Create a new item in a shared workspace.
*WorkspaceApi* | [**CreateSharedWorkspace**](docs/WorkspaceApi.md#createsharedworkspace) | **POST** /api/workspaces/shared | [EXPERIMENTAL] CreateSharedWorkspace: Create a new shared workspace.
*WorkspaceApi* | [**DeletePersonalItem**](docs/WorkspaceApi.md#deletepersonalitem) | **DELETE** /api/workspaces/personal/{workspaceName}/items/{itemName} | [EXPERIMENTAL] DeletePersonalItem: Delete an item from a personal workspace.
*WorkspaceApi* | [**DeletePersonalWorkspace**](docs/WorkspaceApi.md#deletepersonalworkspace) | **DELETE** /api/workspaces/personal/{workspaceName} | [EXPERIMENTAL] DeletePersonalWorkspace: Delete a personal workspace.
*WorkspaceApi* | [**DeleteSharedItem**](docs/WorkspaceApi.md#deleteshareditem) | **DELETE** /api/workspaces/shared/{workspaceName}/items/{itemName} | [EXPERIMENTAL] DeleteSharedItem: Delete an item from a shared workspace.
*WorkspaceApi* | [**DeleteSharedWorkspace**](docs/WorkspaceApi.md#deletesharedworkspace) | **DELETE** /api/workspaces/shared/{workspaceName} | [EXPERIMENTAL] DeleteSharedWorkspace: Delete a shared workspace.
*WorkspaceApi* | [**GetPersonalItem**](docs/WorkspaceApi.md#getpersonalitem) | **GET** /api/workspaces/personal/{workspaceName}/items/{itemName} | [EXPERIMENTAL] GetPersonalItem: Get a single personal workspace item.
*WorkspaceApi* | [**GetPersonalWorkspace**](docs/WorkspaceApi.md#getpersonalworkspace) | **GET** /api/workspaces/personal/{workspaceName} | [EXPERIMENTAL] GetPersonalWorkspace: Get a personal workspace.
*WorkspaceApi* | [**GetSharedItem**](docs/WorkspaceApi.md#getshareditem) | **GET** /api/workspaces/shared/{workspaceName}/items/{itemName} | [EXPERIMENTAL] GetSharedItem: Get a single shared workspace item.
*WorkspaceApi* | [**GetSharedWorkspace**](docs/WorkspaceApi.md#getsharedworkspace) | **GET** /api/workspaces/shared/{workspaceName} | [EXPERIMENTAL] GetSharedWorkspace: Get a shared workspace.
*WorkspaceApi* | [**ListPersonalItems**](docs/WorkspaceApi.md#listpersonalitems) | **GET** /api/workspaces/personal/{workspaceName}/items | [EXPERIMENTAL] ListPersonalItems: List the items in a personal workspace.
*WorkspaceApi* | [**ListPersonalWorkspaces**](docs/WorkspaceApi.md#listpersonalworkspaces) | **GET** /api/workspaces/personal | [EXPERIMENTAL] ListPersonalWorkspaces: List personal workspaces.
*WorkspaceApi* | [**ListSharedItems**](docs/WorkspaceApi.md#listshareditems) | **GET** /api/workspaces/shared/{workspaceName}/items | [EXPERIMENTAL] ListSharedItems: List the items in a shared workspace.
*WorkspaceApi* | [**ListSharedWorkspaces**](docs/WorkspaceApi.md#listsharedworkspaces) | **GET** /api/workspaces/shared | [EXPERIMENTAL] ListSharedWorkspaces: List shared workspaces.
*WorkspaceApi* | [**UpdatePersonalItem**](docs/WorkspaceApi.md#updatepersonalitem) | **PUT** /api/workspaces/personal/{workspaceName}/items/{itemName} | [EXPERIMENTAL] UpdatePersonalItem: Update an item in a personal workspace.
*WorkspaceApi* | [**UpdatePersonalWorkspace**](docs/WorkspaceApi.md#updatepersonalworkspace) | **PUT** /api/workspaces/personal/{workspaceName} | [EXPERIMENTAL] UpdatePersonalWorkspace: Update a personal workspace.
*WorkspaceApi* | [**UpdateSharedItem**](docs/WorkspaceApi.md#updateshareditem) | **PUT** /api/workspaces/shared/{workspaceName}/items/{itemName} | [EXPERIMENTAL] UpdateSharedItem: Update an item in a shared workspace.
*WorkspaceApi* | [**UpdateSharedWorkspace**](docs/WorkspaceApi.md#updatesharedworkspace) | **PUT** /api/workspaces/shared/{workspaceName} | [EXPERIMENTAL] UpdateSharedWorkspace: Update a shared workspace.


<a id="documentation-for-models"></a>
## Documentation for Models

 - [A2BBreakdown](docs/A2BBreakdown.md)
 - [A2BCategory](docs/A2BCategory.md)
 - [A2BDataRecord](docs/A2BDataRecord.md)
 - [A2BMovementRecord](docs/A2BMovementRecord.md)
 - [Abor](docs/Abor.md)
 - [AborConfiguration](docs/AborConfiguration.md)
 - [AborConfigurationProperties](docs/AborConfigurationProperties.md)
 - [AborConfigurationRequest](docs/AborConfigurationRequest.md)
 - [AborProperties](docs/AborProperties.md)
 - [AborRequest](docs/AborRequest.md)
 - [AcceptEstimateValuationPointResponse](docs/AcceptEstimateValuationPointResponse.md)
 - [AccessControlledAction](docs/AccessControlledAction.md)
 - [AccessControlledResource](docs/AccessControlledResource.md)
 - [AccessMetadataOperation](docs/AccessMetadataOperation.md)
 - [AccessMetadataValue](docs/AccessMetadataValue.md)
 - [Account](docs/Account.md)
 - [AccountProperties](docs/AccountProperties.md)
 - [AccountingMethod](docs/AccountingMethod.md)
 - [AccountsUpsertResponse](docs/AccountsUpsertResponse.md)
 - [AccumulationEvent](docs/AccumulationEvent.md)
 - [AccumulationEventAllOf](docs/AccumulationEventAllOf.md)
 - [ActionId](docs/ActionId.md)
 - [AddBusinessDaysToDateRequest](docs/AddBusinessDaysToDateRequest.md)
 - [AddBusinessDaysToDateResponse](docs/AddBusinessDaysToDateResponse.md)
 - [AdditionalPayment](docs/AdditionalPayment.md)
 - [AddressDefinition](docs/AddressDefinition.md)
 - [AddressKeyComplianceParameter](docs/AddressKeyComplianceParameter.md)
 - [AddressKeyComplianceParameterAllOf](docs/AddressKeyComplianceParameterAllOf.md)
 - [AddressKeyDefinition](docs/AddressKeyDefinition.md)
 - [AddressKeyFilter](docs/AddressKeyFilter.md)
 - [AddressKeyList](docs/AddressKeyList.md)
 - [AddressKeyListAllOf](docs/AddressKeyListAllOf.md)
 - [AddressKeyListComplianceParameter](docs/AddressKeyListComplianceParameter.md)
 - [AddressKeyListComplianceParameterAllOf](docs/AddressKeyListComplianceParameterAllOf.md)
 - [AddressKeyOptionDefinition](docs/AddressKeyOptionDefinition.md)
 - [AdjustHolding](docs/AdjustHolding.md)
 - [AdjustHoldingForDateRequest](docs/AdjustHoldingForDateRequest.md)
 - [AdjustHoldingRequest](docs/AdjustHoldingRequest.md)
 - [AggregateSpec](docs/AggregateSpec.md)
 - [AggregatedReturn](docs/AggregatedReturn.md)
 - [AggregatedReturnsDispersionRequest](docs/AggregatedReturnsDispersionRequest.md)
 - [AggregatedReturnsRequest](docs/AggregatedReturnsRequest.md)
 - [AggregatedReturnsResponse](docs/AggregatedReturnsResponse.md)
 - [AggregatedTransactionsRequest](docs/AggregatedTransactionsRequest.md)
 - [AggregationContext](docs/AggregationContext.md)
 - [AggregationMeasureFailureDetail](docs/AggregationMeasureFailureDetail.md)
 - [AggregationOp](docs/AggregationOp.md)
 - [AggregationOptions](docs/AggregationOptions.md)
 - [AggregationQuery](docs/AggregationQuery.md)
 - [AggregationType](docs/AggregationType.md)
 - [Allocation](docs/Allocation.md)
 - [AllocationRequest](docs/AllocationRequest.md)
 - [AllocationServiceRunResponse](docs/AllocationServiceRunResponse.md)
 - [AllocationSetRequest](docs/AllocationSetRequest.md)
 - [AmortisationEvent](docs/AmortisationEvent.md)
 - [AmortisationEventAllOf](docs/AmortisationEventAllOf.md)
 - [AmortisationRule](docs/AmortisationRule.md)
 - [AmortisationRuleSet](docs/AmortisationRuleSet.md)
 - [Amount](docs/Amount.md)
 - [AnnulQuotesResponse](docs/AnnulQuotesResponse.md)
 - [AnnulSingleStructuredDataResponse](docs/AnnulSingleStructuredDataResponse.md)
 - [AnnulStructuredDataResponse](docs/AnnulStructuredDataResponse.md)
 - [ApplicableInstrumentEvent](docs/ApplicableInstrumentEvent.md)
 - [AssetClass](docs/AssetClass.md)
 - [AssetLeg](docs/AssetLeg.md)
 - [Barrier](docs/Barrier.md)
 - [Basket](docs/Basket.md)
 - [BasketAllOf](docs/BasketAllOf.md)
 - [BasketIdentifier](docs/BasketIdentifier.md)
 - [BatchAdjustHoldingsResponse](docs/BatchAdjustHoldingsResponse.md)
 - [BatchUpsertDatesForCalendarResponse](docs/BatchUpsertDatesForCalendarResponse.md)
 - [BatchUpsertInstrumentPropertiesResponse](docs/BatchUpsertInstrumentPropertiesResponse.md)
 - [BatchUpsertPortfolioAccessMetadataRequest](docs/BatchUpsertPortfolioAccessMetadataRequest.md)
 - [BatchUpsertPortfolioAccessMetadataResponse](docs/BatchUpsertPortfolioAccessMetadataResponse.md)
 - [BatchUpsertPortfolioAccessMetadataResponseItem](docs/BatchUpsertPortfolioAccessMetadataResponseItem.md)
 - [BatchUpsertPortfolioTransactionsResponse](docs/BatchUpsertPortfolioTransactionsResponse.md)
 - [BatchUpsertPropertyDefinitionPropertiesResponse](docs/BatchUpsertPropertyDefinitionPropertiesResponse.md)
 - [Block](docs/Block.md)
 - [BlockAndOrderIdRequest](docs/BlockAndOrderIdRequest.md)
 - [BlockAndOrders](docs/BlockAndOrders.md)
 - [BlockAndOrdersCreateRequest](docs/BlockAndOrdersCreateRequest.md)
 - [BlockAndOrdersRequest](docs/BlockAndOrdersRequest.md)
 - [BlockRequest](docs/BlockRequest.md)
 - [BlockSetRequest](docs/BlockSetRequest.md)
 - [BlockedOrderRequest](docs/BlockedOrderRequest.md)
 - [Bond](docs/Bond.md)
 - [BondAllOf](docs/BondAllOf.md)
 - [BondConversionEntry](docs/BondConversionEntry.md)
 - [BondConversionSchedule](docs/BondConversionSchedule.md)
 - [BondConversionScheduleAllOf](docs/BondConversionScheduleAllOf.md)
 - [BondCouponEvent](docs/BondCouponEvent.md)
 - [BondCouponEventAllOf](docs/BondCouponEventAllOf.md)
 - [BondDefaultEvent](docs/BondDefaultEvent.md)
 - [BondDefaultEventAllOf](docs/BondDefaultEventAllOf.md)
 - [BondPrincipalEvent](docs/BondPrincipalEvent.md)
 - [BondPrincipalEventAllOf](docs/BondPrincipalEventAllOf.md)
 - [BonusIssueEvent](docs/BonusIssueEvent.md)
 - [BonusIssueEventAllOf](docs/BonusIssueEventAllOf.md)
 - [BookTransactionsRequest](docs/BookTransactionsRequest.md)
 - [BookTransactionsResponse](docs/BookTransactionsResponse.md)
 - [BoolComplianceParameter](docs/BoolComplianceParameter.md)
 - [BoolComplianceParameterAllOf](docs/BoolComplianceParameterAllOf.md)
 - [BoolListComplianceParameter](docs/BoolListComplianceParameter.md)
 - [BranchStep](docs/BranchStep.md)
 - [BranchStepAllOf](docs/BranchStepAllOf.md)
 - [BranchStepRequest](docs/BranchStepRequest.md)
 - [BranchStepRequestAllOf](docs/BranchStepRequestAllOf.md)
 - [BreakCodeSource](docs/BreakCodeSource.md)
 - [BucketedCashFlowRequest](docs/BucketedCashFlowRequest.md)
 - [BucketedCashFlowResponse](docs/BucketedCashFlowResponse.md)
 - [BucketingSchedule](docs/BucketingSchedule.md)
 - [CalculationInfo](docs/CalculationInfo.md)
 - [Calendar](docs/Calendar.md)
 - [CalendarDate](docs/CalendarDate.md)
 - [CalendarDependency](docs/CalendarDependency.md)
 - [CalendarDependencyAllOf](docs/CalendarDependencyAllOf.md)
 - [CallOnIntermediateSecuritiesEvent](docs/CallOnIntermediateSecuritiesEvent.md)
 - [CallOnIntermediateSecuritiesEventAllOf](docs/CallOnIntermediateSecuritiesEventAllOf.md)
 - [CancelOrderAndMoveRemainingResult](docs/CancelOrderAndMoveRemainingResult.md)
 - [CancelOrdersAndMoveRemainingRequest](docs/CancelOrdersAndMoveRemainingRequest.md)
 - [CancelOrdersAndMoveRemainingResponse](docs/CancelOrdersAndMoveRemainingResponse.md)
 - [CancelOrdersResponse](docs/CancelOrdersResponse.md)
 - [CancelPlacementsResponse](docs/CancelPlacementsResponse.md)
 - [CancelledOrderResult](docs/CancelledOrderResult.md)
 - [CancelledPlacementResult](docs/CancelledPlacementResult.md)
 - [CapFloor](docs/CapFloor.md)
 - [CapFloorAllOf](docs/CapFloorAllOf.md)
 - [CapitalDistributionEvent](docs/CapitalDistributionEvent.md)
 - [CapitalDistributionEventAllOf](docs/CapitalDistributionEventAllOf.md)
 - [Cash](docs/Cash.md)
 - [CashAllOf](docs/CashAllOf.md)
 - [CashAndSecurityOfferElection](docs/CashAndSecurityOfferElection.md)
 - [CashDependency](docs/CashDependency.md)
 - [CashDependencyAllOf](docs/CashDependencyAllOf.md)
 - [CashDividendEvent](docs/CashDividendEvent.md)
 - [CashDividendEventAllOf](docs/CashDividendEventAllOf.md)
 - [CashElection](docs/CashElection.md)
 - [CashFlowEvent](docs/CashFlowEvent.md)
 - [CashFlowEventAllOf](docs/CashFlowEventAllOf.md)
 - [CashFlowLineage](docs/CashFlowLineage.md)
 - [CashFlowValue](docs/CashFlowValue.md)
 - [CashFlowValueAllOf](docs/CashFlowValueAllOf.md)
 - [CashFlowValueSet](docs/CashFlowValueSet.md)
 - [CashFlowValueSetAllOf](docs/CashFlowValueSetAllOf.md)
 - [CashLadderRecord](docs/CashLadderRecord.md)
 - [CashOfferElection](docs/CashOfferElection.md)
 - [CashPerpetual](docs/CashPerpetual.md)
 - [CashPerpetualAllOf](docs/CashPerpetualAllOf.md)
 - [CdsCreditEvent](docs/CdsCreditEvent.md)
 - [CdsCreditEventAllOf](docs/CdsCreditEventAllOf.md)
 - [CdsFlowConventions](docs/CdsFlowConventions.md)
 - [CdsIndex](docs/CdsIndex.md)
 - [CdsIndexAllOf](docs/CdsIndexAllOf.md)
 - [CdsProtectionDetailSpecification](docs/CdsProtectionDetailSpecification.md)
 - [CdxCreditEvent](docs/CdxCreditEvent.md)
 - [CdxCreditEventAllOf](docs/CdxCreditEventAllOf.md)
 - [Change](docs/Change.md)
 - [ChangeHistory](docs/ChangeHistory.md)
 - [ChangeHistoryAction](docs/ChangeHistoryAction.md)
 - [ChangeInterval](docs/ChangeInterval.md)
 - [ChangeIntervalWithOrderManagementDetail](docs/ChangeIntervalWithOrderManagementDetail.md)
 - [ChangeItem](docs/ChangeItem.md)
 - [ChartOfAccounts](docs/ChartOfAccounts.md)
 - [ChartOfAccountsProperties](docs/ChartOfAccountsProperties.md)
 - [ChartOfAccountsRequest](docs/ChartOfAccountsRequest.md)
 - [CheckStep](docs/CheckStep.md)
 - [CheckStepAllOf](docs/CheckStepAllOf.md)
 - [CheckStepRequest](docs/CheckStepRequest.md)
 - [CleardownModuleDetails](docs/CleardownModuleDetails.md)
 - [CleardownModuleRequest](docs/CleardownModuleRequest.md)
 - [CleardownModuleResponse](docs/CleardownModuleResponse.md)
 - [CleardownModuleRule](docs/CleardownModuleRule.md)
 - [CleardownModuleRulesUpdatedResponse](docs/CleardownModuleRulesUpdatedResponse.md)
 - [CloseEvent](docs/CloseEvent.md)
 - [CloseEventAllOf](docs/CloseEventAllOf.md)
 - [ClosePeriodDiaryEntryRequest](docs/ClosePeriodDiaryEntryRequest.md)
 - [ComparisonAttributeValuePair](docs/ComparisonAttributeValuePair.md)
 - [CompletePortfolio](docs/CompletePortfolio.md)
 - [CompleteRelation](docs/CompleteRelation.md)
 - [CompleteRelationship](docs/CompleteRelationship.md)
 - [ComplexBond](docs/ComplexBond.md)
 - [ComplexBondAllOf](docs/ComplexBondAllOf.md)
 - [ComplexMarketData](docs/ComplexMarketData.md)
 - [ComplexMarketDataId](docs/ComplexMarketDataId.md)
 - [ComplianceBreachedOrderInfo](docs/ComplianceBreachedOrderInfo.md)
 - [ComplianceParameter](docs/ComplianceParameter.md)
 - [ComplianceParameterType](docs/ComplianceParameterType.md)
 - [ComplianceRule](docs/ComplianceRule.md)
 - [ComplianceRuleBreakdown](docs/ComplianceRuleBreakdown.md)
 - [ComplianceRuleBreakdownRequest](docs/ComplianceRuleBreakdownRequest.md)
 - [ComplianceRuleResponse](docs/ComplianceRuleResponse.md)
 - [ComplianceRuleResult](docs/ComplianceRuleResult.md)
 - [ComplianceRuleResultDetail](docs/ComplianceRuleResultDetail.md)
 - [ComplianceRuleResultPortfolioDetail](docs/ComplianceRuleResultPortfolioDetail.md)
 - [ComplianceRuleResultV2](docs/ComplianceRuleResultV2.md)
 - [ComplianceRuleTemplate](docs/ComplianceRuleTemplate.md)
 - [ComplianceRuleUpsertRequest](docs/ComplianceRuleUpsertRequest.md)
 - [ComplianceRuleUpsertResponse](docs/ComplianceRuleUpsertResponse.md)
 - [ComplianceRunConfiguration](docs/ComplianceRunConfiguration.md)
 - [ComplianceRunInfo](docs/ComplianceRunInfo.md)
 - [ComplianceRunInfoV2](docs/ComplianceRunInfoV2.md)
 - [ComplianceStep](docs/ComplianceStep.md)
 - [ComplianceStepRequest](docs/ComplianceStepRequest.md)
 - [ComplianceStepType](docs/ComplianceStepType.md)
 - [ComplianceStepTypeRequest](docs/ComplianceStepTypeRequest.md)
 - [ComplianceSummaryRuleResult](docs/ComplianceSummaryRuleResult.md)
 - [ComplianceSummaryRuleResultRequest](docs/ComplianceSummaryRuleResultRequest.md)
 - [ComplianceTemplate](docs/ComplianceTemplate.md)
 - [ComplianceTemplateParameter](docs/ComplianceTemplateParameter.md)
 - [ComplianceTemplateVariation](docs/ComplianceTemplateVariation.md)
 - [ComplianceTemplateVariationDto](docs/ComplianceTemplateVariationDto.md)
 - [ComplianceTemplateVariationRequest](docs/ComplianceTemplateVariationRequest.md)
 - [ComponentFilter](docs/ComponentFilter.md)
 - [ComponentTransaction](docs/ComponentTransaction.md)
 - [CompositeBreakdown](docs/CompositeBreakdown.md)
 - [CompositeBreakdownRequest](docs/CompositeBreakdownRequest.md)
 - [CompositeBreakdownResponse](docs/CompositeBreakdownResponse.md)
 - [CompositeDispersion](docs/CompositeDispersion.md)
 - [CompositeDispersionResponse](docs/CompositeDispersionResponse.md)
 - [Compounding](docs/Compounding.md)
 - [ConfigurationRecipe](docs/ConfigurationRecipe.md)
 - [ConstantVolatilitySurface](docs/ConstantVolatilitySurface.md)
 - [ConstantVolatilitySurfaceAllOf](docs/ConstantVolatilitySurfaceAllOf.md)
 - [ConstituentsAdjustmentHeader](docs/ConstituentsAdjustmentHeader.md)
 - [ContractForDifference](docs/ContractForDifference.md)
 - [ContractForDifferenceAllOf](docs/ContractForDifferenceAllOf.md)
 - [CorporateAction](docs/CorporateAction.md)
 - [CorporateActionSource](docs/CorporateActionSource.md)
 - [CorporateActionTransition](docs/CorporateActionTransition.md)
 - [CorporateActionTransitionComponent](docs/CorporateActionTransitionComponent.md)
 - [CorporateActionTransitionComponentRequest](docs/CorporateActionTransitionComponentRequest.md)
 - [CorporateActionTransitionRequest](docs/CorporateActionTransitionRequest.md)
 - [CounterpartyAgreement](docs/CounterpartyAgreement.md)
 - [CounterpartyRiskInformation](docs/CounterpartyRiskInformation.md)
 - [CounterpartySignatory](docs/CounterpartySignatory.md)
 - [CreateAddressKeyDefinitionRequest](docs/CreateAddressKeyDefinitionRequest.md)
 - [CreateAmortisationRuleSetRequest](docs/CreateAmortisationRuleSetRequest.md)
 - [CreateCalendarRequest](docs/CreateCalendarRequest.md)
 - [CreateComplianceTemplateRequest](docs/CreateComplianceTemplateRequest.md)
 - [CreateCorporateActionSourceRequest](docs/CreateCorporateActionSourceRequest.md)
 - [CreateCustomEntityTypeRequest](docs/CreateCustomEntityTypeRequest.md)
 - [CreateCutLabelDefinitionRequest](docs/CreateCutLabelDefinitionRequest.md)
 - [CreateDataMapRequest](docs/CreateDataMapRequest.md)
 - [CreateDataTypeRequest](docs/CreateDataTypeRequest.md)
 - [CreateDateRequest](docs/CreateDateRequest.md)
 - [CreateDerivedPropertyDefinitionRequest](docs/CreateDerivedPropertyDefinitionRequest.md)
 - [CreateDerivedTransactionPortfolioRequest](docs/CreateDerivedTransactionPortfolioRequest.md)
 - [CreateGroupReconciliationComparisonRulesetRequest](docs/CreateGroupReconciliationComparisonRulesetRequest.md)
 - [CreateGroupReconciliationDefinitionRequest](docs/CreateGroupReconciliationDefinitionRequest.md)
 - [CreatePortfolioDetails](docs/CreatePortfolioDetails.md)
 - [CreatePortfolioGroupRequest](docs/CreatePortfolioGroupRequest.md)
 - [CreatePropertyDefinitionRequest](docs/CreatePropertyDefinitionRequest.md)
 - [CreateRecipeRequest](docs/CreateRecipeRequest.md)
 - [CreateReconciliationRequest](docs/CreateReconciliationRequest.md)
 - [CreateReferencePortfolioRequest](docs/CreateReferencePortfolioRequest.md)
 - [CreateRelationDefinitionRequest](docs/CreateRelationDefinitionRequest.md)
 - [CreateRelationRequest](docs/CreateRelationRequest.md)
 - [CreateRelationshipDefinitionRequest](docs/CreateRelationshipDefinitionRequest.md)
 - [CreateRelationshipRequest](docs/CreateRelationshipRequest.md)
 - [CreateSequenceRequest](docs/CreateSequenceRequest.md)
 - [CreateStagingRuleSetRequest](docs/CreateStagingRuleSetRequest.md)
 - [CreateTaxRuleSetRequest](docs/CreateTaxRuleSetRequest.md)
 - [CreateTradeTicketsResponse](docs/CreateTradeTicketsResponse.md)
 - [CreateTransactionPortfolioRequest](docs/CreateTransactionPortfolioRequest.md)
 - [CreateUnitDefinition](docs/CreateUnitDefinition.md)
 - [CreditDefaultSwap](docs/CreditDefaultSwap.md)
 - [CreditDefaultSwapAllOf](docs/CreditDefaultSwapAllOf.md)
 - [CreditPremiumCashFlowEvent](docs/CreditPremiumCashFlowEvent.md)
 - [CreditPremiumCashFlowEventAllOf](docs/CreditPremiumCashFlowEventAllOf.md)
 - [CreditRating](docs/CreditRating.md)
 - [CreditSpreadCurveData](docs/CreditSpreadCurveData.md)
 - [CreditSpreadCurveDataAllOf](docs/CreditSpreadCurveDataAllOf.md)
 - [CreditSupportAnnex](docs/CreditSupportAnnex.md)
 - [CriterionType](docs/CriterionType.md)
 - [CurrencyAndAmount](docs/CurrencyAndAmount.md)
 - [CurveOptions](docs/CurveOptions.md)
 - [CurveOptionsAllOf](docs/CurveOptionsAllOf.md)
 - [CustodianAccount](docs/CustodianAccount.md)
 - [CustodianAccountProperties](docs/CustodianAccountProperties.md)
 - [CustodianAccountRequest](docs/CustodianAccountRequest.md)
 - [CustodianAccountsUpsertResponse](docs/CustodianAccountsUpsertResponse.md)
 - [CustomEntityDefinition](docs/CustomEntityDefinition.md)
 - [CustomEntityDefinitionRequest](docs/CustomEntityDefinitionRequest.md)
 - [CustomEntityEntity](docs/CustomEntityEntity.md)
 - [CustomEntityField](docs/CustomEntityField.md)
 - [CustomEntityFieldDefinition](docs/CustomEntityFieldDefinition.md)
 - [CustomEntityId](docs/CustomEntityId.md)
 - [CustomEntityRequest](docs/CustomEntityRequest.md)
 - [CustomEntityResponse](docs/CustomEntityResponse.md)
 - [CustomEntityType](docs/CustomEntityType.md)
 - [CutLabelDefinition](docs/CutLabelDefinition.md)
 - [CutLocalTime](docs/CutLocalTime.md)
 - [DataDefinition](docs/DataDefinition.md)
 - [DataMapKey](docs/DataMapKey.md)
 - [DataMapping](docs/DataMapping.md)
 - [DataScope](docs/DataScope.md)
 - [DataType](docs/DataType.md)
 - [DataTypeEntity](docs/DataTypeEntity.md)
 - [DataTypeSummary](docs/DataTypeSummary.md)
 - [DataTypeValueRange](docs/DataTypeValueRange.md)
 - [DateAttributes](docs/DateAttributes.md)
 - [DateOrDiaryEntry](docs/DateOrDiaryEntry.md)
 - [DateRange](docs/DateRange.md)
 - [DateTimeComparisonType](docs/DateTimeComparisonType.md)
 - [DateTimeComplianceParameter](docs/DateTimeComplianceParameter.md)
 - [DateTimeComplianceParameterAllOf](docs/DateTimeComplianceParameterAllOf.md)
 - [DateTimeListComplianceParameter](docs/DateTimeListComplianceParameter.md)
 - [DayMonth](docs/DayMonth.md)
 - [DayOfWeek](docs/DayOfWeek.md)
 - [DecimalComplianceParameter](docs/DecimalComplianceParameter.md)
 - [DecimalComplianceParameterAllOf](docs/DecimalComplianceParameterAllOf.md)
 - [DecimalList](docs/DecimalList.md)
 - [DecimalListAllOf](docs/DecimalListAllOf.md)
 - [DecimalListComplianceParameter](docs/DecimalListComplianceParameter.md)
 - [DecoratedComplianceRunSummary](docs/DecoratedComplianceRunSummary.md)
 - [DeleteAccountsResponse](docs/DeleteAccountsResponse.md)
 - [DeleteCustodianAccountsResponse](docs/DeleteCustodianAccountsResponse.md)
 - [DeleteInstrumentPropertiesResponse](docs/DeleteInstrumentPropertiesResponse.md)
 - [DeleteInstrumentResponse](docs/DeleteInstrumentResponse.md)
 - [DeleteInstrumentsResponse](docs/DeleteInstrumentsResponse.md)
 - [DeleteModes](docs/DeleteModes.md)
 - [DeleteRelationRequest](docs/DeleteRelationRequest.md)
 - [DeleteRelationshipRequest](docs/DeleteRelationshipRequest.md)
 - [DeletedEntityResponse](docs/DeletedEntityResponse.md)
 - [DependencySourceFilter](docs/DependencySourceFilter.md)
 - [DescribedAddressKey](docs/DescribedAddressKey.md)
 - [Dialect](docs/Dialect.md)
 - [DialectId](docs/DialectId.md)
 - [DialectSchema](docs/DialectSchema.md)
 - [DiaryEntry](docs/DiaryEntry.md)
 - [DiaryEntryRequest](docs/DiaryEntryRequest.md)
 - [DiscountFactorCurveData](docs/DiscountFactorCurveData.md)
 - [DiscountFactorCurveDataAllOf](docs/DiscountFactorCurveDataAllOf.md)
 - [DiscountingDependency](docs/DiscountingDependency.md)
 - [DiscountingDependencyAllOf](docs/DiscountingDependencyAllOf.md)
 - [DiscountingMethod](docs/DiscountingMethod.md)
 - [DividendOptionEvent](docs/DividendOptionEvent.md)
 - [DividendOptionEventAllOf](docs/DividendOptionEventAllOf.md)
 - [DividendReinvestmentEvent](docs/DividendReinvestmentEvent.md)
 - [DividendReinvestmentEventAllOf](docs/DividendReinvestmentEventAllOf.md)
 - [EconomicDependency](docs/EconomicDependency.md)
 - [EconomicDependencyType](docs/EconomicDependencyType.md)
 - [EconomicDependencyWithComplexMarketData](docs/EconomicDependencyWithComplexMarketData.md)
 - [EconomicDependencyWithQuote](docs/EconomicDependencyWithQuote.md)
 - [EffectiveRange](docs/EffectiveRange.md)
 - [ElectionSpecification](docs/ElectionSpecification.md)
 - [EligibilityCalculation](docs/EligibilityCalculation.md)
 - [EmptyModelOptions](docs/EmptyModelOptions.md)
 - [EmptyModelOptionsAllOf](docs/EmptyModelOptionsAllOf.md)
 - [EntityIdentifier](docs/EntityIdentifier.md)
 - [Equity](docs/Equity.md)
 - [EquityAllOf](docs/EquityAllOf.md)
 - [EquityAllOfIdentifiers](docs/EquityAllOfIdentifiers.md)
 - [EquityCurveByPricesData](docs/EquityCurveByPricesData.md)
 - [EquityCurveByPricesDataAllOf](docs/EquityCurveByPricesDataAllOf.md)
 - [EquityCurveDependency](docs/EquityCurveDependency.md)
 - [EquityCurveDependencyAllOf](docs/EquityCurveDependencyAllOf.md)
 - [EquityModelOptions](docs/EquityModelOptions.md)
 - [EquityModelOptionsAllOf](docs/EquityModelOptionsAllOf.md)
 - [EquityOption](docs/EquityOption.md)
 - [EquityOptionAllOf](docs/EquityOptionAllOf.md)
 - [EquitySwap](docs/EquitySwap.md)
 - [EquitySwapAllOf](docs/EquitySwapAllOf.md)
 - [EquityVolDependency](docs/EquityVolDependency.md)
 - [EquityVolDependencyAllOf](docs/EquityVolDependencyAllOf.md)
 - [EquityVolSurfaceData](docs/EquityVolSurfaceData.md)
 - [EquityVolSurfaceDataAllOf](docs/EquityVolSurfaceDataAllOf.md)
 - [ErrorDetail](docs/ErrorDetail.md)
 - [EventDateRange](docs/EventDateRange.md)
 - [ExDividendConfiguration](docs/ExDividendConfiguration.md)
 - [ExchangeTradedOption](docs/ExchangeTradedOption.md)
 - [ExchangeTradedOptionAllOf](docs/ExchangeTradedOptionAllOf.md)
 - [ExchangeTradedOptionContractDetails](docs/ExchangeTradedOptionContractDetails.md)
 - [Execution](docs/Execution.md)
 - [ExecutionRequest](docs/ExecutionRequest.md)
 - [ExecutionSetRequest](docs/ExecutionSetRequest.md)
 - [ExerciseEvent](docs/ExerciseEvent.md)
 - [ExerciseEventAllOf](docs/ExerciseEventAllOf.md)
 - [ExoticInstrument](docs/ExoticInstrument.md)
 - [ExoticInstrumentAllOf](docs/ExoticInstrumentAllOf.md)
 - [ExpandedGroup](docs/ExpandedGroup.md)
 - [ExpiryEvent](docs/ExpiryEvent.md)
 - [ExpiryEventAllOf](docs/ExpiryEventAllOf.md)
 - [Fee](docs/Fee.md)
 - [FeeAccrual](docs/FeeAccrual.md)
 - [FeeProperties](docs/FeeProperties.md)
 - [FeeRequest](docs/FeeRequest.md)
 - [FeeRule](docs/FeeRule.md)
 - [FeeRuleUpsertRequest](docs/FeeRuleUpsertRequest.md)
 - [FeeRuleUpsertResponse](docs/FeeRuleUpsertResponse.md)
 - [FeeTransactionTemplateSpecification](docs/FeeTransactionTemplateSpecification.md)
 - [FeeType](docs/FeeType.md)
 - [FeeTypeRequest](docs/FeeTypeRequest.md)
 - [FieldDefinition](docs/FieldDefinition.md)
 - [FieldSchema](docs/FieldSchema.md)
 - [FieldValue](docs/FieldValue.md)
 - [FileResponse](docs/FileResponse.md)
 - [FilterPredicateComplianceParameter](docs/FilterPredicateComplianceParameter.md)
 - [FilterPredicateComplianceParameterAllOf](docs/FilterPredicateComplianceParameterAllOf.md)
 - [FilterStep](docs/FilterStep.md)
 - [FilterStepRequest](docs/FilterStepRequest.md)
 - [FixedLeg](docs/FixedLeg.md)
 - [FixedLegAllOf](docs/FixedLegAllOf.md)
 - [FixedLegAllOfOverrides](docs/FixedLegAllOfOverrides.md)
 - [FixedSchedule](docs/FixedSchedule.md)
 - [FixedScheduleAllOf](docs/FixedScheduleAllOf.md)
 - [FlexibleLoan](docs/FlexibleLoan.md)
 - [FlexibleLoanAllOf](docs/FlexibleLoanAllOf.md)
 - [FloatSchedule](docs/FloatSchedule.md)
 - [FloatScheduleAllOf](docs/FloatScheduleAllOf.md)
 - [FloatingLeg](docs/FloatingLeg.md)
 - [FloatingLegAllOf](docs/FloatingLegAllOf.md)
 - [FlowConventionName](docs/FlowConventionName.md)
 - [FlowConventions](docs/FlowConventions.md)
 - [ForwardRateAgreement](docs/ForwardRateAgreement.md)
 - [ForwardRateAgreementAllOf](docs/ForwardRateAgreementAllOf.md)
 - [FromRecipe](docs/FromRecipe.md)
 - [Fund](docs/Fund.md)
 - [FundAmount](docs/FundAmount.md)
 - [FundConfiguration](docs/FundConfiguration.md)
 - [FundConfigurationProperties](docs/FundConfigurationProperties.md)
 - [FundConfigurationRequest](docs/FundConfigurationRequest.md)
 - [FundDetails](docs/FundDetails.md)
 - [FundIdList](docs/FundIdList.md)
 - [FundIdListAllOf](docs/FundIdListAllOf.md)
 - [FundPnlBreakdown](docs/FundPnlBreakdown.md)
 - [FundPreviousNAV](docs/FundPreviousNAV.md)
 - [FundProperties](docs/FundProperties.md)
 - [FundRequest](docs/FundRequest.md)
 - [FundShareClass](docs/FundShareClass.md)
 - [FundShareClassAllOf](docs/FundShareClassAllOf.md)
 - [FundValuationPointData](docs/FundValuationPointData.md)
 - [FundingLeg](docs/FundingLeg.md)
 - [FundingLegAllOf](docs/FundingLegAllOf.md)
 - [FundingLegOptions](docs/FundingLegOptions.md)
 - [FundingLegOptionsAllOf](docs/FundingLegOptionsAllOf.md)
 - [Future](docs/Future.md)
 - [FutureAllOf](docs/FutureAllOf.md)
 - [FutureExpiryEvent](docs/FutureExpiryEvent.md)
 - [FutureExpiryEventAllOf](docs/FutureExpiryEventAllOf.md)
 - [FuturesContractDetails](docs/FuturesContractDetails.md)
 - [FxConventions](docs/FxConventions.md)
 - [FxDependency](docs/FxDependency.md)
 - [FxDependencyAllOf](docs/FxDependencyAllOf.md)
 - [FxForward](docs/FxForward.md)
 - [FxForwardAllOf](docs/FxForwardAllOf.md)
 - [FxForwardCurveByQuoteReference](docs/FxForwardCurveByQuoteReference.md)
 - [FxForwardCurveByQuoteReferenceAllOf](docs/FxForwardCurveByQuoteReferenceAllOf.md)
 - [FxForwardCurveData](docs/FxForwardCurveData.md)
 - [FxForwardCurveDataAllOf](docs/FxForwardCurveDataAllOf.md)
 - [FxForwardModelOptions](docs/FxForwardModelOptions.md)
 - [FxForwardModelOptionsAllOf](docs/FxForwardModelOptionsAllOf.md)
 - [FxForwardPipsCurveData](docs/FxForwardPipsCurveData.md)
 - [FxForwardPipsCurveDataAllOf](docs/FxForwardPipsCurveDataAllOf.md)
 - [FxForwardSettlementEvent](docs/FxForwardSettlementEvent.md)
 - [FxForwardSettlementEventAllOf](docs/FxForwardSettlementEventAllOf.md)
 - [FxForwardTenorCurveData](docs/FxForwardTenorCurveData.md)
 - [FxForwardTenorCurveDataAllOf](docs/FxForwardTenorCurveDataAllOf.md)
 - [FxForwardTenorPipsCurveData](docs/FxForwardTenorPipsCurveData.md)
 - [FxForwardTenorPipsCurveDataAllOf](docs/FxForwardTenorPipsCurveDataAllOf.md)
 - [FxForwardsDependency](docs/FxForwardsDependency.md)
 - [FxForwardsDependencyAllOf](docs/FxForwardsDependencyAllOf.md)
 - [FxLinkedNotionalSchedule](docs/FxLinkedNotionalSchedule.md)
 - [FxLinkedNotionalScheduleAllOf](docs/FxLinkedNotionalScheduleAllOf.md)
 - [FxOption](docs/FxOption.md)
 - [FxOptionAllOf](docs/FxOptionAllOf.md)
 - [FxRateSchedule](docs/FxRateSchedule.md)
 - [FxRateScheduleAllOf](docs/FxRateScheduleAllOf.md)
 - [FxSwap](docs/FxSwap.md)
 - [FxSwapAllOf](docs/FxSwapAllOf.md)
 - [FxTenorConvention](docs/FxTenorConvention.md)
 - [FxVolDependency](docs/FxVolDependency.md)
 - [FxVolDependencyAllOf](docs/FxVolDependencyAllOf.md)
 - [FxVolSurfaceData](docs/FxVolSurfaceData.md)
 - [GeneralLedgerProfileMapping](docs/GeneralLedgerProfileMapping.md)
 - [GeneralLedgerProfileRequest](docs/GeneralLedgerProfileRequest.md)
 - [GeneralLedgerProfileResponse](docs/GeneralLedgerProfileResponse.md)
 - [GeneratedEventDiagnostics](docs/GeneratedEventDiagnostics.md)
 - [GetCdsFlowConventionsResponse](docs/GetCdsFlowConventionsResponse.md)
 - [GetComplexMarketDataResponse](docs/GetComplexMarketDataResponse.md)
 - [GetCounterpartyAgreementResponse](docs/GetCounterpartyAgreementResponse.md)
 - [GetCreditSupportAnnexResponse](docs/GetCreditSupportAnnexResponse.md)
 - [GetDataMapResponse](docs/GetDataMapResponse.md)
 - [GetFlowConventionsResponse](docs/GetFlowConventionsResponse.md)
 - [GetIndexConventionResponse](docs/GetIndexConventionResponse.md)
 - [GetInstrumentsResponse](docs/GetInstrumentsResponse.md)
 - [GetQuotesResponse](docs/GetQuotesResponse.md)
 - [GetRecipeComposerResponse](docs/GetRecipeComposerResponse.md)
 - [GetRecipeResponse](docs/GetRecipeResponse.md)
 - [GetReferencePortfolioConstituentsResponse](docs/GetReferencePortfolioConstituentsResponse.md)
 - [GetStructuredResultDataResponse](docs/GetStructuredResultDataResponse.md)
 - [GetVirtualDocumentResponse](docs/GetVirtualDocumentResponse.md)
 - [GroupBySelectorComplianceParameter](docs/GroupBySelectorComplianceParameter.md)
 - [GroupByStep](docs/GroupByStep.md)
 - [GroupByStepRequest](docs/GroupByStepRequest.md)
 - [GroupCalculationComplianceParameter](docs/GroupCalculationComplianceParameter.md)
 - [GroupFilterPredicateComplianceParameter](docs/GroupFilterPredicateComplianceParameter.md)
 - [GroupFilterStep](docs/GroupFilterStep.md)
 - [GroupFilterStepAllOf](docs/GroupFilterStepAllOf.md)
 - [GroupFilterStepRequest](docs/GroupFilterStepRequest.md)
 - [GroupOfMarketDataKeyRules](docs/GroupOfMarketDataKeyRules.md)
 - [GroupReconciliationAggregateAttributeRule](docs/GroupReconciliationAggregateAttributeRule.md)
 - [GroupReconciliationAggregateAttributeValues](docs/GroupReconciliationAggregateAttributeValues.md)
 - [GroupReconciliationAggregateComparisonRuleOperand](docs/GroupReconciliationAggregateComparisonRuleOperand.md)
 - [GroupReconciliationComparisonResult](docs/GroupReconciliationComparisonResult.md)
 - [GroupReconciliationComparisonRuleStringValueMap](docs/GroupReconciliationComparisonRuleStringValueMap.md)
 - [GroupReconciliationComparisonRuleTolerance](docs/GroupReconciliationComparisonRuleTolerance.md)
 - [GroupReconciliationComparisonRuleset](docs/GroupReconciliationComparisonRuleset.md)
 - [GroupReconciliationCoreAttributeRule](docs/GroupReconciliationCoreAttributeRule.md)
 - [GroupReconciliationCoreAttributeValues](docs/GroupReconciliationCoreAttributeValues.md)
 - [GroupReconciliationCoreComparisonRuleOperand](docs/GroupReconciliationCoreComparisonRuleOperand.md)
 - [GroupReconciliationDatePair](docs/GroupReconciliationDatePair.md)
 - [GroupReconciliationDates](docs/GroupReconciliationDates.md)
 - [GroupReconciliationDefinition](docs/GroupReconciliationDefinition.md)
 - [GroupReconciliationDefinitionComparisonRulesetIds](docs/GroupReconciliationDefinitionComparisonRulesetIds.md)
 - [GroupReconciliationDefinitionCurrencies](docs/GroupReconciliationDefinitionCurrencies.md)
 - [GroupReconciliationDefinitionPortfolioEntityIds](docs/GroupReconciliationDefinitionPortfolioEntityIds.md)
 - [GroupReconciliationDefinitionRecipeIds](docs/GroupReconciliationDefinitionRecipeIds.md)
 - [GroupReconciliationInstanceId](docs/GroupReconciliationInstanceId.md)
 - [GroupReconciliationResultStatuses](docs/GroupReconciliationResultStatuses.md)
 - [GroupReconciliationResultTypes](docs/GroupReconciliationResultTypes.md)
 - [GroupReconciliationReviewStatuses](docs/GroupReconciliationReviewStatuses.md)
 - [GroupReconciliationRunDetails](docs/GroupReconciliationRunDetails.md)
 - [GroupReconciliationRunRequest](docs/GroupReconciliationRunRequest.md)
 - [GroupReconciliationRunResponse](docs/GroupReconciliationRunResponse.md)
 - [GroupReconciliationSummary](docs/GroupReconciliationSummary.md)
 - [GroupReconciliationUserReview](docs/GroupReconciliationUserReview.md)
 - [GroupReconciliationUserReviewBreakCode](docs/GroupReconciliationUserReviewBreakCode.md)
 - [GroupReconciliationUserReviewComment](docs/GroupReconciliationUserReviewComment.md)
 - [GroupReconciliationUserReviewMatchKey](docs/GroupReconciliationUserReviewMatchKey.md)
 - [GroupedResultOfAddressKey](docs/GroupedResultOfAddressKey.md)
 - [HoldingAdjustment](docs/HoldingAdjustment.md)
 - [HoldingAdjustmentWithDate](docs/HoldingAdjustmentWithDate.md)
 - [HoldingContext](docs/HoldingContext.md)
 - [HoldingContributor](docs/HoldingContributor.md)
 - [HoldingIdsRequest](docs/HoldingIdsRequest.md)
 - [HoldingPricingInfo](docs/HoldingPricingInfo.md)
 - [HoldingsAdjustment](docs/HoldingsAdjustment.md)
 - [HoldingsAdjustmentHeader](docs/HoldingsAdjustmentHeader.md)
 - [IUnitDefinitionDto](docs/IUnitDefinitionDto.md)
 - [IdSelectorDefinition](docs/IdSelectorDefinition.md)
 - [IdentifierPartSchema](docs/IdentifierPartSchema.md)
 - [IndexConvention](docs/IndexConvention.md)
 - [IndexModelOptions](docs/IndexModelOptions.md)
 - [IndexModelOptionsAllOf](docs/IndexModelOptionsAllOf.md)
 - [IndexProjectionDependency](docs/IndexProjectionDependency.md)
 - [IndexProjectionDependencyAllOf](docs/IndexProjectionDependencyAllOf.md)
 - [IndustryClassifier](docs/IndustryClassifier.md)
 - [InflationFixingDependency](docs/InflationFixingDependency.md)
 - [InflationFixingDependencyAllOf](docs/InflationFixingDependencyAllOf.md)
 - [InflationIndexConventions](docs/InflationIndexConventions.md)
 - [InflationLeg](docs/InflationLeg.md)
 - [InflationLegAllOf](docs/InflationLegAllOf.md)
 - [InflationLinkedBond](docs/InflationLinkedBond.md)
 - [InflationLinkedBondAllOf](docs/InflationLinkedBondAllOf.md)
 - [InflationSwap](docs/InflationSwap.md)
 - [InflationSwapAllOf](docs/InflationSwapAllOf.md)
 - [InformationalErrorEvent](docs/InformationalErrorEvent.md)
 - [InformationalErrorEventAllOf](docs/InformationalErrorEventAllOf.md)
 - [InformationalEvent](docs/InformationalEvent.md)
 - [InformationalEventAllOf](docs/InformationalEventAllOf.md)
 - [InlineValuationRequest](docs/InlineValuationRequest.md)
 - [InlineValuationsReconciliationRequest](docs/InlineValuationsReconciliationRequest.md)
 - [InputTransition](docs/InputTransition.md)
 - [Instrument](docs/Instrument.md)
 - [InstrumentCapabilities](docs/InstrumentCapabilities.md)
 - [InstrumentCashFlow](docs/InstrumentCashFlow.md)
 - [InstrumentDefinition](docs/InstrumentDefinition.md)
 - [InstrumentDefinitionFormat](docs/InstrumentDefinitionFormat.md)
 - [InstrumentDeleteModes](docs/InstrumentDeleteModes.md)
 - [InstrumentEntity](docs/InstrumentEntity.md)
 - [InstrumentEvent](docs/InstrumentEvent.md)
 - [InstrumentEventConfiguration](docs/InstrumentEventConfiguration.md)
 - [InstrumentEventHolder](docs/InstrumentEventHolder.md)
 - [InstrumentEventInstruction](docs/InstrumentEventInstruction.md)
 - [InstrumentEventInstructionRequest](docs/InstrumentEventInstructionRequest.md)
 - [InstrumentEventInstructionsResponse](docs/InstrumentEventInstructionsResponse.md)
 - [InstrumentEventType](docs/InstrumentEventType.md)
 - [InstrumentIdTypeDescriptor](docs/InstrumentIdTypeDescriptor.md)
 - [InstrumentIdValue](docs/InstrumentIdValue.md)
 - [InstrumentLeg](docs/InstrumentLeg.md)
 - [InstrumentLegAllOf](docs/InstrumentLegAllOf.md)
 - [InstrumentList](docs/InstrumentList.md)
 - [InstrumentListAllOf](docs/InstrumentListAllOf.md)
 - [InstrumentListComplianceParameter](docs/InstrumentListComplianceParameter.md)
 - [InstrumentMatch](docs/InstrumentMatch.md)
 - [InstrumentModels](docs/InstrumentModels.md)
 - [InstrumentPaymentDiary](docs/InstrumentPaymentDiary.md)
 - [InstrumentPaymentDiaryLeg](docs/InstrumentPaymentDiaryLeg.md)
 - [InstrumentPaymentDiaryRow](docs/InstrumentPaymentDiaryRow.md)
 - [InstrumentProperties](docs/InstrumentProperties.md)
 - [InstrumentResolutionDetail](docs/InstrumentResolutionDetail.md)
 - [InstrumentSearchProperty](docs/InstrumentSearchProperty.md)
 - [InstrumentType](docs/InstrumentType.md)
 - [InterestRateSwap](docs/InterestRateSwap.md)
 - [InterestRateSwapAllOf](docs/InterestRateSwapAllOf.md)
 - [InterestRateSwaption](docs/InterestRateSwaption.md)
 - [InterestRateSwaptionAllOf](docs/InterestRateSwaptionAllOf.md)
 - [IntermediateComplianceStep](docs/IntermediateComplianceStep.md)
 - [IntermediateComplianceStepAllOf](docs/IntermediateComplianceStepAllOf.md)
 - [IntermediateComplianceStepRequest](docs/IntermediateComplianceStepRequest.md)
 - [IntermediateSecuritiesDistributionEvent](docs/IntermediateSecuritiesDistributionEvent.md)
 - [IntermediateSecuritiesDistributionEventAllOf](docs/IntermediateSecuritiesDistributionEventAllOf.md)
 - [IrVolCubeData](docs/IrVolCubeData.md)
 - [IrVolCubeDataAllOf](docs/IrVolCubeDataAllOf.md)
 - [IrVolDependency](docs/IrVolDependency.md)
 - [IrVolDependencyAllOf](docs/IrVolDependencyAllOf.md)
 - [IsBusinessDayResponse](docs/IsBusinessDayResponse.md)
 - [JournalEntryLine](docs/JournalEntryLine.md)
 - [JournalEntryLinesQueryParameters](docs/JournalEntryLinesQueryParameters.md)
 - [LabelValueSet](docs/LabelValueSet.md)
 - [LapseElection](docs/LapseElection.md)
 - [LegDefinition](docs/LegDefinition.md)
 - [LegalEntity](docs/LegalEntity.md)
 - [LevelStep](docs/LevelStep.md)
 - [LifeCycleEventLineage](docs/LifeCycleEventLineage.md)
 - [LifeCycleEventValue](docs/LifeCycleEventValue.md)
 - [LifeCycleEventValueAllOf](docs/LifeCycleEventValueAllOf.md)
 - [LineageMember](docs/LineageMember.md)
 - [Link](docs/Link.md)
 - [ListAggregationReconciliation](docs/ListAggregationReconciliation.md)
 - [ListAggregationResponse](docs/ListAggregationResponse.md)
 - [ListComplexMarketDataWithMetaDataResponse](docs/ListComplexMarketDataWithMetaDataResponse.md)
 - [LoanFacility](docs/LoanFacility.md)
 - [LoanFacilityAllOf](docs/LoanFacilityAllOf.md)
 - [LoanPeriod](docs/LoanPeriod.md)
 - [LockPeriodDiaryEntryRequest](docs/LockPeriodDiaryEntryRequest.md)
 - [LusidInstrument](docs/LusidInstrument.md)
 - [LusidProblemDetails](docs/LusidProblemDetails.md)
 - [LusidTradeTicket](docs/LusidTradeTicket.md)
 - [LusidUniqueId](docs/LusidUniqueId.md)
 - [LusidValidationProblemDetails](docs/LusidValidationProblemDetails.md)
 - [MappedString](docs/MappedString.md)
 - [Mapping](docs/Mapping.md)
 - [MappingRule](docs/MappingRule.md)
 - [MarketContext](docs/MarketContext.md)
 - [MarketContextSuppliers](docs/MarketContextSuppliers.md)
 - [MarketDataKeyRule](docs/MarketDataKeyRule.md)
 - [MarketDataOptions](docs/MarketDataOptions.md)
 - [MarketDataOptionsType](docs/MarketDataOptionsType.md)
 - [MarketDataOverrides](docs/MarketDataOverrides.md)
 - [MarketDataSpecificRule](docs/MarketDataSpecificRule.md)
 - [MarketDataType](docs/MarketDataType.md)
 - [MarketObservableType](docs/MarketObservableType.md)
 - [MarketOptions](docs/MarketOptions.md)
 - [MarketQuote](docs/MarketQuote.md)
 - [MasteredInstrument](docs/MasteredInstrument.md)
 - [MasteredInstrumentAllOf](docs/MasteredInstrumentAllOf.md)
 - [MatchCriterion](docs/MatchCriterion.md)
 - [MaturityEvent](docs/MaturityEvent.md)
 - [MaturityEventAllOf](docs/MaturityEventAllOf.md)
 - [MbsCouponEvent](docs/MbsCouponEvent.md)
 - [MbsCouponEventAllOf](docs/MbsCouponEventAllOf.md)
 - [MbsInterestDeferralEvent](docs/MbsInterestDeferralEvent.md)
 - [MbsInterestDeferralEventAllOf](docs/MbsInterestDeferralEventAllOf.md)
 - [MbsInterestShortfallEvent](docs/MbsInterestShortfallEvent.md)
 - [MbsInterestShortfallEventAllOf](docs/MbsInterestShortfallEventAllOf.md)
 - [MbsPrincipalEvent](docs/MbsPrincipalEvent.md)
 - [MbsPrincipalEventAllOf](docs/MbsPrincipalEventAllOf.md)
 - [MbsPrincipalWriteOffEvent](docs/MbsPrincipalWriteOffEvent.md)
 - [MbsPrincipalWriteOffEventAllOf](docs/MbsPrincipalWriteOffEventAllOf.md)
 - [MergerEvent](docs/MergerEvent.md)
 - [MergerEventAllOf](docs/MergerEventAllOf.md)
 - [MetricValue](docs/MetricValue.md)
 - [ModelClient](docs/ModelClient.md)
 - [ModelOptions](docs/ModelOptions.md)
 - [ModelOptionsType](docs/ModelOptionsType.md)
 - [ModelSelection](docs/ModelSelection.md)
 - [ModelVersion](docs/ModelVersion.md)
 - [MoveOrdersToDifferentBlocksRequest](docs/MoveOrdersToDifferentBlocksRequest.md)
 - [MovedOrderToDifferentBlockResponse](docs/MovedOrderToDifferentBlockResponse.md)
 - [MovementType](docs/MovementType.md)
 - [MultiCurrencyAmounts](docs/MultiCurrencyAmounts.md)
 - [NewInstrument](docs/NewInstrument.md)
 - [NextValueInSequenceResponse](docs/NextValueInSequenceResponse.md)
 - [NumericComparisonType](docs/NumericComparisonType.md)
 - [OpaqueDependency](docs/OpaqueDependency.md)
 - [OpaqueDependencyAllOf](docs/OpaqueDependencyAllOf.md)
 - [OpaqueMarketData](docs/OpaqueMarketData.md)
 - [OpaqueMarketDataAllOf](docs/OpaqueMarketDataAllOf.md)
 - [OpaqueModelOptions](docs/OpaqueModelOptions.md)
 - [OpaqueModelOptionsAllOf](docs/OpaqueModelOptionsAllOf.md)
 - [OpenEvent](docs/OpenEvent.md)
 - [OpenEventAllOf](docs/OpenEventAllOf.md)
 - [OperandType](docs/OperandType.md)
 - [Operation](docs/Operation.md)
 - [OperationType](docs/OperationType.md)
 - [Operator](docs/Operator.md)
 - [OptionEntry](docs/OptionEntry.md)
 - [OptionExerciseElection](docs/OptionExerciseElection.md)
 - [OptionExercisePhysicalEvent](docs/OptionExercisePhysicalEvent.md)
 - [OptionExercisePhysicalEventAllOf](docs/OptionExercisePhysicalEventAllOf.md)
 - [OptionalitySchedule](docs/OptionalitySchedule.md)
 - [OptionalityScheduleAllOf](docs/OptionalityScheduleAllOf.md)
 - [Order](docs/Order.md)
 - [OrderBySpec](docs/OrderBySpec.md)
 - [OrderFlowConfiguration](docs/OrderFlowConfiguration.md)
 - [OrderGraphBlock](docs/OrderGraphBlock.md)
 - [OrderGraphBlockAllocationDetail](docs/OrderGraphBlockAllocationDetail.md)
 - [OrderGraphBlockAllocationSynopsis](docs/OrderGraphBlockAllocationSynopsis.md)
 - [OrderGraphBlockExecutionDetail](docs/OrderGraphBlockExecutionDetail.md)
 - [OrderGraphBlockExecutionSynopsis](docs/OrderGraphBlockExecutionSynopsis.md)
 - [OrderGraphBlockOrderDetail](docs/OrderGraphBlockOrderDetail.md)
 - [OrderGraphBlockOrderSynopsis](docs/OrderGraphBlockOrderSynopsis.md)
 - [OrderGraphBlockPlacementDetail](docs/OrderGraphBlockPlacementDetail.md)
 - [OrderGraphBlockPlacementSynopsis](docs/OrderGraphBlockPlacementSynopsis.md)
 - [OrderGraphBlockTransactionDetail](docs/OrderGraphBlockTransactionDetail.md)
 - [OrderGraphBlockTransactionSynopsis](docs/OrderGraphBlockTransactionSynopsis.md)
 - [OrderGraphPlacement](docs/OrderGraphPlacement.md)
 - [OrderGraphPlacementAllocationDetail](docs/OrderGraphPlacementAllocationDetail.md)
 - [OrderGraphPlacementAllocationSynopsis](docs/OrderGraphPlacementAllocationSynopsis.md)
 - [OrderGraphPlacementChildPlacementDetail](docs/OrderGraphPlacementChildPlacementDetail.md)
 - [OrderGraphPlacementExecutionDetail](docs/OrderGraphPlacementExecutionDetail.md)
 - [OrderGraphPlacementExecutionSynopsis](docs/OrderGraphPlacementExecutionSynopsis.md)
 - [OrderGraphPlacementOrderDetail](docs/OrderGraphPlacementOrderDetail.md)
 - [OrderGraphPlacementOrderSynopsis](docs/OrderGraphPlacementOrderSynopsis.md)
 - [OrderGraphPlacementPlacementSynopsis](docs/OrderGraphPlacementPlacementSynopsis.md)
 - [OrderInstruction](docs/OrderInstruction.md)
 - [OrderInstructionRequest](docs/OrderInstructionRequest.md)
 - [OrderInstructionSetRequest](docs/OrderInstructionSetRequest.md)
 - [OrderRequest](docs/OrderRequest.md)
 - [OrderSetRequest](docs/OrderSetRequest.md)
 - [OrderUpdateRequest](docs/OrderUpdateRequest.md)
 - [OtcConfirmation](docs/OtcConfirmation.md)
 - [OutputTransaction](docs/OutputTransaction.md)
 - [OutputTransition](docs/OutputTransition.md)
 - [Package](docs/Package.md)
 - [PackageRequest](docs/PackageRequest.md)
 - [PackageSetRequest](docs/PackageSetRequest.md)
 - [PagedResourceListOfAbor](docs/PagedResourceListOfAbor.md)
 - [PagedResourceListOfAborConfiguration](docs/PagedResourceListOfAborConfiguration.md)
 - [PagedResourceListOfAccount](docs/PagedResourceListOfAccount.md)
 - [PagedResourceListOfAddressKeyDefinition](docs/PagedResourceListOfAddressKeyDefinition.md)
 - [PagedResourceListOfAllocation](docs/PagedResourceListOfAllocation.md)
 - [PagedResourceListOfAmortisationRuleSet](docs/PagedResourceListOfAmortisationRuleSet.md)
 - [PagedResourceListOfBlock](docs/PagedResourceListOfBlock.md)
 - [PagedResourceListOfCalendar](docs/PagedResourceListOfCalendar.md)
 - [PagedResourceListOfChartOfAccounts](docs/PagedResourceListOfChartOfAccounts.md)
 - [PagedResourceListOfCleardownModuleResponse](docs/PagedResourceListOfCleardownModuleResponse.md)
 - [PagedResourceListOfCleardownModuleRule](docs/PagedResourceListOfCleardownModuleRule.md)
 - [PagedResourceListOfComplianceRuleResponse](docs/PagedResourceListOfComplianceRuleResponse.md)
 - [PagedResourceListOfComplianceRunInfoV2](docs/PagedResourceListOfComplianceRunInfoV2.md)
 - [PagedResourceListOfComplianceTemplate](docs/PagedResourceListOfComplianceTemplate.md)
 - [PagedResourceListOfCorporateActionSource](docs/PagedResourceListOfCorporateActionSource.md)
 - [PagedResourceListOfCustodianAccount](docs/PagedResourceListOfCustodianAccount.md)
 - [PagedResourceListOfCustomEntityDefinition](docs/PagedResourceListOfCustomEntityDefinition.md)
 - [PagedResourceListOfCustomEntityResponse](docs/PagedResourceListOfCustomEntityResponse.md)
 - [PagedResourceListOfCustomEntityType](docs/PagedResourceListOfCustomEntityType.md)
 - [PagedResourceListOfCutLabelDefinition](docs/PagedResourceListOfCutLabelDefinition.md)
 - [PagedResourceListOfDataTypeSummary](docs/PagedResourceListOfDataTypeSummary.md)
 - [PagedResourceListOfDialectId](docs/PagedResourceListOfDialectId.md)
 - [PagedResourceListOfDiaryEntry](docs/PagedResourceListOfDiaryEntry.md)
 - [PagedResourceListOfExecution](docs/PagedResourceListOfExecution.md)
 - [PagedResourceListOfFee](docs/PagedResourceListOfFee.md)
 - [PagedResourceListOfFeeType](docs/PagedResourceListOfFeeType.md)
 - [PagedResourceListOfFund](docs/PagedResourceListOfFund.md)
 - [PagedResourceListOfFundConfiguration](docs/PagedResourceListOfFundConfiguration.md)
 - [PagedResourceListOfGeneralLedgerProfileResponse](docs/PagedResourceListOfGeneralLedgerProfileResponse.md)
 - [PagedResourceListOfGroupReconciliationComparisonResult](docs/PagedResourceListOfGroupReconciliationComparisonResult.md)
 - [PagedResourceListOfGroupReconciliationComparisonRuleset](docs/PagedResourceListOfGroupReconciliationComparisonRuleset.md)
 - [PagedResourceListOfGroupReconciliationDefinition](docs/PagedResourceListOfGroupReconciliationDefinition.md)
 - [PagedResourceListOfInstrument](docs/PagedResourceListOfInstrument.md)
 - [PagedResourceListOfInstrumentEventHolder](docs/PagedResourceListOfInstrumentEventHolder.md)
 - [PagedResourceListOfInstrumentEventInstruction](docs/PagedResourceListOfInstrumentEventInstruction.md)
 - [PagedResourceListOfLegalEntity](docs/PagedResourceListOfLegalEntity.md)
 - [PagedResourceListOfOrder](docs/PagedResourceListOfOrder.md)
 - [PagedResourceListOfOrderGraphBlock](docs/PagedResourceListOfOrderGraphBlock.md)
 - [PagedResourceListOfOrderGraphPlacement](docs/PagedResourceListOfOrderGraphPlacement.md)
 - [PagedResourceListOfOrderInstruction](docs/PagedResourceListOfOrderInstruction.md)
 - [PagedResourceListOfPackage](docs/PagedResourceListOfPackage.md)
 - [PagedResourceListOfParticipation](docs/PagedResourceListOfParticipation.md)
 - [PagedResourceListOfPerson](docs/PagedResourceListOfPerson.md)
 - [PagedResourceListOfPlacement](docs/PagedResourceListOfPlacement.md)
 - [PagedResourceListOfPortfolioGroup](docs/PagedResourceListOfPortfolioGroup.md)
 - [PagedResourceListOfPortfolioGroupSearchResult](docs/PagedResourceListOfPortfolioGroupSearchResult.md)
 - [PagedResourceListOfPortfolioSearchResult](docs/PagedResourceListOfPortfolioSearchResult.md)
 - [PagedResourceListOfPostingModuleResponse](docs/PagedResourceListOfPostingModuleResponse.md)
 - [PagedResourceListOfPostingModuleRule](docs/PagedResourceListOfPostingModuleRule.md)
 - [PagedResourceListOfPropertyDefinition](docs/PagedResourceListOfPropertyDefinition.md)
 - [PagedResourceListOfPropertyDefinitionSearchResult](docs/PagedResourceListOfPropertyDefinitionSearchResult.md)
 - [PagedResourceListOfReconciliation](docs/PagedResourceListOfReconciliation.md)
 - [PagedResourceListOfReferenceListResponse](docs/PagedResourceListOfReferenceListResponse.md)
 - [PagedResourceListOfRelationshipDefinition](docs/PagedResourceListOfRelationshipDefinition.md)
 - [PagedResourceListOfSequenceDefinition](docs/PagedResourceListOfSequenceDefinition.md)
 - [PagedResourceListOfStagedModification](docs/PagedResourceListOfStagedModification.md)
 - [PagedResourceListOfStagedModificationsRequestedChangeInterval](docs/PagedResourceListOfStagedModificationsRequestedChangeInterval.md)
 - [PagedResourceListOfStagingRuleSet](docs/PagedResourceListOfStagingRuleSet.md)
 - [PagedResourceListOfTransactionTemplate](docs/PagedResourceListOfTransactionTemplate.md)
 - [PagedResourceListOfTransactionTemplateSpecification](docs/PagedResourceListOfTransactionTemplateSpecification.md)
 - [PagedResourceListOfTranslationScriptId](docs/PagedResourceListOfTranslationScriptId.md)
 - [PagedResourceListOfValuationPointOverview](docs/PagedResourceListOfValuationPointOverview.md)
 - [PagedResourceListOfVirtualRow](docs/PagedResourceListOfVirtualRow.md)
 - [PagedResourceListOfWorkspace](docs/PagedResourceListOfWorkspace.md)
 - [PagedResourceListOfWorkspaceItem](docs/PagedResourceListOfWorkspaceItem.md)
 - [Participation](docs/Participation.md)
 - [ParticipationRequest](docs/ParticipationRequest.md)
 - [ParticipationSetRequest](docs/ParticipationSetRequest.md)
 - [PercentCheckStep](docs/PercentCheckStep.md)
 - [PercentCheckStepRequest](docs/PercentCheckStepRequest.md)
 - [PerformanceReturn](docs/PerformanceReturn.md)
 - [PerformanceReturnsMetric](docs/PerformanceReturnsMetric.md)
 - [PeriodDiaryEntriesReopenedResponse](docs/PeriodDiaryEntriesReopenedResponse.md)
 - [PeriodType](docs/PeriodType.md)
 - [PerpetualEntityState](docs/PerpetualEntityState.md)
 - [PerpetualProperty](docs/PerpetualProperty.md)
 - [Person](docs/Person.md)
 - [PlaceBlocksRequest](docs/PlaceBlocksRequest.md)
 - [Placement](docs/Placement.md)
 - [PlacementRequest](docs/PlacementRequest.md)
 - [PlacementSetRequest](docs/PlacementSetRequest.md)
 - [PlacementUpdateRequest](docs/PlacementUpdateRequest.md)
 - [Portfolio](docs/Portfolio.md)
 - [PortfolioCashFlow](docs/PortfolioCashFlow.md)
 - [PortfolioCashLadder](docs/PortfolioCashLadder.md)
 - [PortfolioDetails](docs/PortfolioDetails.md)
 - [PortfolioEntity](docs/PortfolioEntity.md)
 - [PortfolioEntityId](docs/PortfolioEntityId.md)
 - [PortfolioGroup](docs/PortfolioGroup.md)
 - [PortfolioGroupIdComplianceParameter](docs/PortfolioGroupIdComplianceParameter.md)
 - [PortfolioGroupIdList](docs/PortfolioGroupIdList.md)
 - [PortfolioGroupIdListComplianceParameter](docs/PortfolioGroupIdListComplianceParameter.md)
 - [PortfolioGroupProperties](docs/PortfolioGroupProperties.md)
 - [PortfolioGroupSearchResult](docs/PortfolioGroupSearchResult.md)
 - [PortfolioHolding](docs/PortfolioHolding.md)
 - [PortfolioIdComplianceParameter](docs/PortfolioIdComplianceParameter.md)
 - [PortfolioIdList](docs/PortfolioIdList.md)
 - [PortfolioIdListComplianceParameter](docs/PortfolioIdListComplianceParameter.md)
 - [PortfolioProperties](docs/PortfolioProperties.md)
 - [PortfolioReconciliationRequest](docs/PortfolioReconciliationRequest.md)
 - [PortfolioResultDataKeyRule](docs/PortfolioResultDataKeyRule.md)
 - [PortfolioResultDataKeyRuleAllOf](docs/PortfolioResultDataKeyRuleAllOf.md)
 - [PortfolioReturnBreakdown](docs/PortfolioReturnBreakdown.md)
 - [PortfolioSearchResult](docs/PortfolioSearchResult.md)
 - [PortfolioTradeTicket](docs/PortfolioTradeTicket.md)
 - [PortfolioType](docs/PortfolioType.md)
 - [PortfolioWithoutHref](docs/PortfolioWithoutHref.md)
 - [PortfoliosReconciliationRequest](docs/PortfoliosReconciliationRequest.md)
 - [PostingModuleDetails](docs/PostingModuleDetails.md)
 - [PostingModuleRequest](docs/PostingModuleRequest.md)
 - [PostingModuleResponse](docs/PostingModuleResponse.md)
 - [PostingModuleRule](docs/PostingModuleRule.md)
 - [PostingModuleRulesUpdatedResponse](docs/PostingModuleRulesUpdatedResponse.md)
 - [PreTradeConfiguration](docs/PreTradeConfiguration.md)
 - [Premium](docs/Premium.md)
 - [PreviousFundValuationPointData](docs/PreviousFundValuationPointData.md)
 - [PreviousNAV](docs/PreviousNAV.md)
 - [PreviousShareClassBreakdown](docs/PreviousShareClassBreakdown.md)
 - [PricingContext](docs/PricingContext.md)
 - [PricingModel](docs/PricingModel.md)
 - [PricingOptions](docs/PricingOptions.md)
 - [ProcessedCommand](docs/ProcessedCommand.md)
 - [Property](docs/Property.md)
 - [PropertyDefinition](docs/PropertyDefinition.md)
 - [PropertyDefinitionEntity](docs/PropertyDefinitionEntity.md)
 - [PropertyDefinitionSearchResult](docs/PropertyDefinitionSearchResult.md)
 - [PropertyDefinitionType](docs/PropertyDefinitionType.md)
 - [PropertyDomain](docs/PropertyDomain.md)
 - [PropertyFilter](docs/PropertyFilter.md)
 - [PropertyInterval](docs/PropertyInterval.md)
 - [PropertyKeyComplianceParameter](docs/PropertyKeyComplianceParameter.md)
 - [PropertyKeyComplianceParameterAllOf](docs/PropertyKeyComplianceParameterAllOf.md)
 - [PropertyKeyListComplianceParameter](docs/PropertyKeyListComplianceParameter.md)
 - [PropertyLifeTime](docs/PropertyLifeTime.md)
 - [PropertyList](docs/PropertyList.md)
 - [PropertyListAllOf](docs/PropertyListAllOf.md)
 - [PropertyListComplianceParameter](docs/PropertyListComplianceParameter.md)
 - [PropertySchema](docs/PropertySchema.md)
 - [PropertyType](docs/PropertyType.md)
 - [PropertyValue](docs/PropertyValue.md)
 - [PropertyValueEquals](docs/PropertyValueEquals.md)
 - [PropertyValueEqualsAllOf](docs/PropertyValueEqualsAllOf.md)
 - [PropertyValueIn](docs/PropertyValueIn.md)
 - [PropertyValueInAllOf](docs/PropertyValueInAllOf.md)
 - [ProtectionPayoutCashFlowEvent](docs/ProtectionPayoutCashFlowEvent.md)
 - [QueryApplicableInstrumentEventsRequest](docs/QueryApplicableInstrumentEventsRequest.md)
 - [QueryBucketedCashFlowsRequest](docs/QueryBucketedCashFlowsRequest.md)
 - [QueryCashFlowsRequest](docs/QueryCashFlowsRequest.md)
 - [QueryInstrumentEventsRequest](docs/QueryInstrumentEventsRequest.md)
 - [QueryTradeTicketsRequest](docs/QueryTradeTicketsRequest.md)
 - [QueryableKey](docs/QueryableKey.md)
 - [Quote](docs/Quote.md)
 - [QuoteAccessMetadataRule](docs/QuoteAccessMetadataRule.md)
 - [QuoteAccessMetadataRuleId](docs/QuoteAccessMetadataRuleId.md)
 - [QuoteDependency](docs/QuoteDependency.md)
 - [QuoteDependencyAllOf](docs/QuoteDependencyAllOf.md)
 - [QuoteId](docs/QuoteId.md)
 - [QuoteInstrumentIdType](docs/QuoteInstrumentIdType.md)
 - [QuoteSeriesId](docs/QuoteSeriesId.md)
 - [QuoteType](docs/QuoteType.md)
 - [RawVendorEvent](docs/RawVendorEvent.md)
 - [RawVendorEventAllOf](docs/RawVendorEventAllOf.md)
 - [ReOpenPeriodDiaryEntryRequest](docs/ReOpenPeriodDiaryEntryRequest.md)
 - [RealisedGainLoss](docs/RealisedGainLoss.md)
 - [RecipeBlock](docs/RecipeBlock.md)
 - [RecipeComposer](docs/RecipeComposer.md)
 - [RecipeValue](docs/RecipeValue.md)
 - [RecombineStep](docs/RecombineStep.md)
 - [ReconcileDateTimeRule](docs/ReconcileDateTimeRule.md)
 - [ReconcileDateTimeRuleAllOf](docs/ReconcileDateTimeRuleAllOf.md)
 - [ReconcileNumericRule](docs/ReconcileNumericRule.md)
 - [ReconcileNumericRuleAllOf](docs/ReconcileNumericRuleAllOf.md)
 - [ReconcileStringRule](docs/ReconcileStringRule.md)
 - [ReconcileStringRuleAllOf](docs/ReconcileStringRuleAllOf.md)
 - [ReconciledTransaction](docs/ReconciledTransaction.md)
 - [Reconciliation](docs/Reconciliation.md)
 - [ReconciliationBreak](docs/ReconciliationBreak.md)
 - [ReconciliationConfiguration](docs/ReconciliationConfiguration.md)
 - [ReconciliationId](docs/ReconciliationId.md)
 - [ReconciliationLeftRightAddressKeyPair](docs/ReconciliationLeftRightAddressKeyPair.md)
 - [ReconciliationLine](docs/ReconciliationLine.md)
 - [ReconciliationRequest](docs/ReconciliationRequest.md)
 - [ReconciliationResponse](docs/ReconciliationResponse.md)
 - [ReconciliationRule](docs/ReconciliationRule.md)
 - [ReconciliationRuleType](docs/ReconciliationRuleType.md)
 - [ReconciliationSideConfiguration](docs/ReconciliationSideConfiguration.md)
 - [ReconciliationTransactions](docs/ReconciliationTransactions.md)
 - [ReferenceData](docs/ReferenceData.md)
 - [ReferenceInstrument](docs/ReferenceInstrument.md)
 - [ReferenceInstrumentAllOf](docs/ReferenceInstrumentAllOf.md)
 - [ReferenceList](docs/ReferenceList.md)
 - [ReferenceListRequest](docs/ReferenceListRequest.md)
 - [ReferenceListResponse](docs/ReferenceListResponse.md)
 - [ReferenceListType](docs/ReferenceListType.md)
 - [ReferencePortfolioConstituent](docs/ReferencePortfolioConstituent.md)
 - [ReferencePortfolioConstituentRequest](docs/ReferencePortfolioConstituentRequest.md)
 - [ReferencePortfolioWeightType](docs/ReferencePortfolioWeightType.md)
 - [RelatedEntity](docs/RelatedEntity.md)
 - [Relation](docs/Relation.md)
 - [RelationDefinition](docs/RelationDefinition.md)
 - [Relationship](docs/Relationship.md)
 - [RelationshipDefinition](docs/RelationshipDefinition.md)
 - [RelativeDateOffset](docs/RelativeDateOffset.md)
 - [Repo](docs/Repo.md)
 - [RepoAllOf](docs/RepoAllOf.md)
 - [RequestedChanges](docs/RequestedChanges.md)
 - [ResetEvent](docs/ResetEvent.md)
 - [ResetEventAllOf](docs/ResetEventAllOf.md)
 - [ResourceId](docs/ResourceId.md)
 - [ResourceListOfAccessControlledResource](docs/ResourceListOfAccessControlledResource.md)
 - [ResourceListOfAccessMetadataValueOf](docs/ResourceListOfAccessMetadataValueOf.md)
 - [ResourceListOfAddressKeyDefinition](docs/ResourceListOfAddressKeyDefinition.md)
 - [ResourceListOfAggregatedReturn](docs/ResourceListOfAggregatedReturn.md)
 - [ResourceListOfAggregationQuery](docs/ResourceListOfAggregationQuery.md)
 - [ResourceListOfAllocation](docs/ResourceListOfAllocation.md)
 - [ResourceListOfApplicableInstrumentEvent](docs/ResourceListOfApplicableInstrumentEvent.md)
 - [ResourceListOfBlock](docs/ResourceListOfBlock.md)
 - [ResourceListOfBlockAndOrders](docs/ResourceListOfBlockAndOrders.md)
 - [ResourceListOfCalendarDate](docs/ResourceListOfCalendarDate.md)
 - [ResourceListOfChange](docs/ResourceListOfChange.md)
 - [ResourceListOfChangeHistory](docs/ResourceListOfChangeHistory.md)
 - [ResourceListOfChangeInterval](docs/ResourceListOfChangeInterval.md)
 - [ResourceListOfChangeIntervalWithOrderManagementDetail](docs/ResourceListOfChangeIntervalWithOrderManagementDetail.md)
 - [ResourceListOfComplianceBreachedOrderInfo](docs/ResourceListOfComplianceBreachedOrderInfo.md)
 - [ResourceListOfComplianceRule](docs/ResourceListOfComplianceRule.md)
 - [ResourceListOfComplianceRuleResult](docs/ResourceListOfComplianceRuleResult.md)
 - [ResourceListOfComplianceRunInfo](docs/ResourceListOfComplianceRunInfo.md)
 - [ResourceListOfConstituentsAdjustmentHeader](docs/ResourceListOfConstituentsAdjustmentHeader.md)
 - [ResourceListOfCorporateAction](docs/ResourceListOfCorporateAction.md)
 - [ResourceListOfDataType](docs/ResourceListOfDataType.md)
 - [ResourceListOfExecution](docs/ResourceListOfExecution.md)
 - [ResourceListOfFeeRule](docs/ResourceListOfFeeRule.md)
 - [ResourceListOfGetCdsFlowConventionsResponse](docs/ResourceListOfGetCdsFlowConventionsResponse.md)
 - [ResourceListOfGetCounterpartyAgreementResponse](docs/ResourceListOfGetCounterpartyAgreementResponse.md)
 - [ResourceListOfGetCreditSupportAnnexResponse](docs/ResourceListOfGetCreditSupportAnnexResponse.md)
 - [ResourceListOfGetFlowConventionsResponse](docs/ResourceListOfGetFlowConventionsResponse.md)
 - [ResourceListOfGetIndexConventionResponse](docs/ResourceListOfGetIndexConventionResponse.md)
 - [ResourceListOfGetRecipeComposerResponse](docs/ResourceListOfGetRecipeComposerResponse.md)
 - [ResourceListOfGetRecipeResponse](docs/ResourceListOfGetRecipeResponse.md)
 - [ResourceListOfHoldingsAdjustmentHeader](docs/ResourceListOfHoldingsAdjustmentHeader.md)
 - [ResourceListOfIUnitDefinitionDto](docs/ResourceListOfIUnitDefinitionDto.md)
 - [ResourceListOfInstrumentCashFlow](docs/ResourceListOfInstrumentCashFlow.md)
 - [ResourceListOfInstrumentEventHolder](docs/ResourceListOfInstrumentEventHolder.md)
 - [ResourceListOfInstrumentIdTypeDescriptor](docs/ResourceListOfInstrumentIdTypeDescriptor.md)
 - [ResourceListOfLegalEntity](docs/ResourceListOfLegalEntity.md)
 - [ResourceListOfListComplexMarketDataWithMetaDataResponse](docs/ResourceListOfListComplexMarketDataWithMetaDataResponse.md)
 - [ResourceListOfMapping](docs/ResourceListOfMapping.md)
 - [ResourceListOfMovedOrderToDifferentBlockResponse](docs/ResourceListOfMovedOrderToDifferentBlockResponse.md)
 - [ResourceListOfOrder](docs/ResourceListOfOrder.md)
 - [ResourceListOfOrderInstruction](docs/ResourceListOfOrderInstruction.md)
 - [ResourceListOfOutputTransaction](docs/ResourceListOfOutputTransaction.md)
 - [ResourceListOfPackage](docs/ResourceListOfPackage.md)
 - [ResourceListOfParticipation](docs/ResourceListOfParticipation.md)
 - [ResourceListOfPerformanceReturn](docs/ResourceListOfPerformanceReturn.md)
 - [ResourceListOfPerson](docs/ResourceListOfPerson.md)
 - [ResourceListOfPlacement](docs/ResourceListOfPlacement.md)
 - [ResourceListOfPortfolio](docs/ResourceListOfPortfolio.md)
 - [ResourceListOfPortfolioCashFlow](docs/ResourceListOfPortfolioCashFlow.md)
 - [ResourceListOfPortfolioCashLadder](docs/ResourceListOfPortfolioCashLadder.md)
 - [ResourceListOfPortfolioTradeTicket](docs/ResourceListOfPortfolioTradeTicket.md)
 - [ResourceListOfProcessedCommand](docs/ResourceListOfProcessedCommand.md)
 - [ResourceListOfProperty](docs/ResourceListOfProperty.md)
 - [ResourceListOfPropertyDefinition](docs/ResourceListOfPropertyDefinition.md)
 - [ResourceListOfPropertyInterval](docs/ResourceListOfPropertyInterval.md)
 - [ResourceListOfQueryableKey](docs/ResourceListOfQueryableKey.md)
 - [ResourceListOfQuote](docs/ResourceListOfQuote.md)
 - [ResourceListOfQuoteAccessMetadataRule](docs/ResourceListOfQuoteAccessMetadataRule.md)
 - [ResourceListOfReconciliationBreak](docs/ResourceListOfReconciliationBreak.md)
 - [ResourceListOfRelation](docs/ResourceListOfRelation.md)
 - [ResourceListOfRelationship](docs/ResourceListOfRelationship.md)
 - [ResourceListOfScopeDefinition](docs/ResourceListOfScopeDefinition.md)
 - [ResourceListOfSideDefinition](docs/ResourceListOfSideDefinition.md)
 - [ResourceListOfString](docs/ResourceListOfString.md)
 - [ResourceListOfTaxRuleSet](docs/ResourceListOfTaxRuleSet.md)
 - [ResourceListOfTransaction](docs/ResourceListOfTransaction.md)
 - [ResourceListOfTransactionType](docs/ResourceListOfTransactionType.md)
 - [ResourceListOfValueType](docs/ResourceListOfValueType.md)
 - [ResponseMetaData](docs/ResponseMetaData.md)
 - [ResultDataKeyRule](docs/ResultDataKeyRule.md)
 - [ResultDataKeyRuleAllOf](docs/ResultDataKeyRuleAllOf.md)
 - [ResultDataSchema](docs/ResultDataSchema.md)
 - [ResultKeyRule](docs/ResultKeyRule.md)
 - [ResultKeyRuleType](docs/ResultKeyRuleType.md)
 - [ResultValue](docs/ResultValue.md)
 - [ResultValue0D](docs/ResultValue0D.md)
 - [ResultValue0DAllOf](docs/ResultValue0DAllOf.md)
 - [ResultValueBool](docs/ResultValueBool.md)
 - [ResultValueBoolAllOf](docs/ResultValueBoolAllOf.md)
 - [ResultValueCurrency](docs/ResultValueCurrency.md)
 - [ResultValueCurrencyAllOf](docs/ResultValueCurrencyAllOf.md)
 - [ResultValueDateTimeOffset](docs/ResultValueDateTimeOffset.md)
 - [ResultValueDateTimeOffsetAllOf](docs/ResultValueDateTimeOffsetAllOf.md)
 - [ResultValueDecimal](docs/ResultValueDecimal.md)
 - [ResultValueDecimalAllOf](docs/ResultValueDecimalAllOf.md)
 - [ResultValueDictionary](docs/ResultValueDictionary.md)
 - [ResultValueDictionaryAllOf](docs/ResultValueDictionaryAllOf.md)
 - [ResultValueInt](docs/ResultValueInt.md)
 - [ResultValueIntAllOf](docs/ResultValueIntAllOf.md)
 - [ResultValueString](docs/ResultValueString.md)
 - [ResultValueStringAllOf](docs/ResultValueStringAllOf.md)
 - [ResultValueType](docs/ResultValueType.md)
 - [ReverseStockSplitEvent](docs/ReverseStockSplitEvent.md)
 - [ReverseStockSplitEventAllOf](docs/ReverseStockSplitEventAllOf.md)
 - [RoundingConfiguration](docs/RoundingConfiguration.md)
 - [RoundingConfigurationComponent](docs/RoundingConfigurationComponent.md)
 - [RoundingConvention](docs/RoundingConvention.md)
 - [RulesInterval](docs/RulesInterval.md)
 - [ScalingMethodology](docs/ScalingMethodology.md)
 - [Schedule](docs/Schedule.md)
 - [ScheduleType](docs/ScheduleType.md)
 - [Schema](docs/Schema.md)
 - [ScopeDefinition](docs/ScopeDefinition.md)
 - [ScripDividendEvent](docs/ScripDividendEvent.md)
 - [ScripDividendEventAllOf](docs/ScripDividendEventAllOf.md)
 - [ScriptMapReference](docs/ScriptMapReference.md)
 - [SecurityElection](docs/SecurityElection.md)
 - [SecurityOfferElection](docs/SecurityOfferElection.md)
 - [SequenceDefinition](docs/SequenceDefinition.md)
 - [SetAmortisationRulesRequest](docs/SetAmortisationRulesRequest.md)
 - [SetLegalEntityIdentifiersRequest](docs/SetLegalEntityIdentifiersRequest.md)
 - [SetLegalEntityPropertiesRequest](docs/SetLegalEntityPropertiesRequest.md)
 - [SetPersonIdentifiersRequest](docs/SetPersonIdentifiersRequest.md)
 - [SetPersonPropertiesRequest](docs/SetPersonPropertiesRequest.md)
 - [SetShareClassInstrumentsRequest](docs/SetShareClassInstrumentsRequest.md)
 - [SetTransactionConfigurationAlias](docs/SetTransactionConfigurationAlias.md)
 - [SetTransactionConfigurationSourceRequest](docs/SetTransactionConfigurationSourceRequest.md)
 - [SettlementCycle](docs/SettlementCycle.md)
 - [SettlementSchedule](docs/SettlementSchedule.md)
 - [ShareClassAmount](docs/ShareClassAmount.md)
 - [ShareClassBreakdown](docs/ShareClassBreakdown.md)
 - [ShareClassData](docs/ShareClassData.md)
 - [ShareClassDealingBreakdown](docs/ShareClassDealingBreakdown.md)
 - [ShareClassDetails](docs/ShareClassDetails.md)
 - [ShareClassPnlBreakdown](docs/ShareClassPnlBreakdown.md)
 - [SideConfigurationData](docs/SideConfigurationData.md)
 - [SideConfigurationDataRequest](docs/SideConfigurationDataRequest.md)
 - [SideDefinition](docs/SideDefinition.md)
 - [SideDefinitionRequest](docs/SideDefinitionRequest.md)
 - [SidesDefinitionRequest](docs/SidesDefinitionRequest.md)
 - [SimpleCashFlowLoan](docs/SimpleCashFlowLoan.md)
 - [SimpleCashFlowLoanAllOf](docs/SimpleCashFlowLoanAllOf.md)
 - [SimpleInstrument](docs/SimpleInstrument.md)
 - [SimpleInstrumentAllOf](docs/SimpleInstrumentAllOf.md)
 - [SimpleRoundingConvention](docs/SimpleRoundingConvention.md)
 - [SortOrder](docs/SortOrder.md)
 - [SpecificHoldingPricingInfo](docs/SpecificHoldingPricingInfo.md)
 - [SpinOffEvent](docs/SpinOffEvent.md)
 - [StagedModification](docs/StagedModification.md)
 - [StagedModificationDecision](docs/StagedModificationDecision.md)
 - [StagedModificationDecisionRequest](docs/StagedModificationDecisionRequest.md)
 - [StagedModificationEffectiveRange](docs/StagedModificationEffectiveRange.md)
 - [StagedModificationStagingRule](docs/StagedModificationStagingRule.md)
 - [StagedModificationsEntityHrefs](docs/StagedModificationsEntityHrefs.md)
 - [StagedModificationsInfo](docs/StagedModificationsInfo.md)
 - [StagedModificationsRequestedChangeInterval](docs/StagedModificationsRequestedChangeInterval.md)
 - [StagingRule](docs/StagingRule.md)
 - [StagingRuleApprovalCriteria](docs/StagingRuleApprovalCriteria.md)
 - [StagingRuleMatchCriteria](docs/StagingRuleMatchCriteria.md)
 - [StagingRuleSet](docs/StagingRuleSet.md)
 - [StepSchedule](docs/StepSchedule.md)
 - [StepScheduleAllOf](docs/StepScheduleAllOf.md)
 - [StockDividendEvent](docs/StockDividendEvent.md)
 - [StockDividendEventAllOf](docs/StockDividendEventAllOf.md)
 - [StockSplitEvent](docs/StockSplitEvent.md)
 - [StockSplitEventAllOf](docs/StockSplitEventAllOf.md)
 - [Stream](docs/Stream.md)
 - [StringComparisonType](docs/StringComparisonType.md)
 - [StringComplianceParameter](docs/StringComplianceParameter.md)
 - [StringList](docs/StringList.md)
 - [StringListComplianceParameter](docs/StringListComplianceParameter.md)
 - [StructuredResultData](docs/StructuredResultData.md)
 - [StructuredResultDataId](docs/StructuredResultDataId.md)
 - [SubHoldingKeyValueEquals](docs/SubHoldingKeyValueEquals.md)
 - [SubHoldingKeyValueEqualsAllOf](docs/SubHoldingKeyValueEqualsAllOf.md)
 - [SwapCashFlowEvent](docs/SwapCashFlowEvent.md)
 - [SwapCashFlowEventAllOf](docs/SwapCashFlowEventAllOf.md)
 - [SwapPrincipalEvent](docs/SwapPrincipalEvent.md)
 - [SwapPrincipalEventAllOf](docs/SwapPrincipalEventAllOf.md)
 - [TargetTaxLot](docs/TargetTaxLot.md)
 - [TargetTaxLotRequest](docs/TargetTaxLotRequest.md)
 - [TaxRule](docs/TaxRule.md)
 - [TaxRuleSet](docs/TaxRuleSet.md)
 - [TemplateField](docs/TemplateField.md)
 - [TenderEvent](docs/TenderEvent.md)
 - [TenderEventAllOf](docs/TenderEventAllOf.md)
 - [TermDeposit](docs/TermDeposit.md)
 - [TermDepositAllOf](docs/TermDepositAllOf.md)
 - [TotalReturnSwap](docs/TotalReturnSwap.md)
 - [TotalReturnSwapAllOf](docs/TotalReturnSwapAllOf.md)
 - [Touch](docs/Touch.md)
 - [TradeTicket](docs/TradeTicket.md)
 - [TradeTicketType](docs/TradeTicketType.md)
 - [Transaction](docs/Transaction.md)
 - [TransactionConfigurationData](docs/TransactionConfigurationData.md)
 - [TransactionConfigurationDataRequest](docs/TransactionConfigurationDataRequest.md)
 - [TransactionConfigurationMovementData](docs/TransactionConfigurationMovementData.md)
 - [TransactionConfigurationMovementDataRequest](docs/TransactionConfigurationMovementDataRequest.md)
 - [TransactionConfigurationTypeAlias](docs/TransactionConfigurationTypeAlias.md)
 - [TransactionCurrencyAndAmount](docs/TransactionCurrencyAndAmount.md)
 - [TransactionDateWindows](docs/TransactionDateWindows.md)
 - [TransactionDiagnostics](docs/TransactionDiagnostics.md)
 - [TransactionFieldMap](docs/TransactionFieldMap.md)
 - [TransactionPrice](docs/TransactionPrice.md)
 - [TransactionPriceAndType](docs/TransactionPriceAndType.md)
 - [TransactionPriceType](docs/TransactionPriceType.md)
 - [TransactionPropertyMap](docs/TransactionPropertyMap.md)
 - [TransactionPropertyMapping](docs/TransactionPropertyMapping.md)
 - [TransactionPropertyMappingRequest](docs/TransactionPropertyMappingRequest.md)
 - [TransactionQueryMode](docs/TransactionQueryMode.md)
 - [TransactionQueryParameters](docs/TransactionQueryParameters.md)
 - [TransactionReconciliationRequest](docs/TransactionReconciliationRequest.md)
 - [TransactionReconciliationRequestV2](docs/TransactionReconciliationRequestV2.md)
 - [TransactionRequest](docs/TransactionRequest.md)
 - [TransactionRoles](docs/TransactionRoles.md)
 - [TransactionSetConfigurationData](docs/TransactionSetConfigurationData.md)
 - [TransactionSetConfigurationDataRequest](docs/TransactionSetConfigurationDataRequest.md)
 - [TransactionStatus](docs/TransactionStatus.md)
 - [TransactionTemplate](docs/TransactionTemplate.md)
 - [TransactionTemplateRequest](docs/TransactionTemplateRequest.md)
 - [TransactionTemplateSpecification](docs/TransactionTemplateSpecification.md)
 - [TransactionType](docs/TransactionType.md)
 - [TransactionTypeAlias](docs/TransactionTypeAlias.md)
 - [TransactionTypeCalculation](docs/TransactionTypeCalculation.md)
 - [TransactionTypeMovement](docs/TransactionTypeMovement.md)
 - [TransactionTypePropertyMapping](docs/TransactionTypePropertyMapping.md)
 - [TransactionTypeRequest](docs/TransactionTypeRequest.md)
 - [TransactionsReconciliationsResponse](docs/TransactionsReconciliationsResponse.md)
 - [TransitionEvent](docs/TransitionEvent.md)
 - [TransitionEventAllOf](docs/TransitionEventAllOf.md)
 - [TranslateEntitiesInlinedRequest](docs/TranslateEntitiesInlinedRequest.md)
 - [TranslateEntitiesRequest](docs/TranslateEntitiesRequest.md)
 - [TranslateEntitiesResponse](docs/TranslateEntitiesResponse.md)
 - [TranslateInstrumentDefinitionsRequest](docs/TranslateInstrumentDefinitionsRequest.md)
 - [TranslateInstrumentDefinitionsResponse](docs/TranslateInstrumentDefinitionsResponse.md)
 - [TranslateTradeTicketRequest](docs/TranslateTradeTicketRequest.md)
 - [TranslateTradeTicketsResponse](docs/TranslateTradeTicketsResponse.md)
 - [TranslationContext](docs/TranslationContext.md)
 - [TranslationInput](docs/TranslationInput.md)
 - [TranslationResult](docs/TranslationResult.md)
 - [TranslationScript](docs/TranslationScript.md)
 - [TranslationScriptId](docs/TranslationScriptId.md)
 - [TrialBalance](docs/TrialBalance.md)
 - [TrialBalanceQueryParameters](docs/TrialBalanceQueryParameters.md)
 - [TriggerEvent](docs/TriggerEvent.md)
 - [TriggerEventAllOf](docs/TriggerEventAllOf.md)
 - [TypedResourceId](docs/TypedResourceId.md)
 - [UnitSchema](docs/UnitSchema.md)
 - [UnitisationData](docs/UnitisationData.md)
 - [UnitsRatio](docs/UnitsRatio.md)
 - [UnmatchedHoldingMethod](docs/UnmatchedHoldingMethod.md)
 - [UpdateAmortisationRuleSetDetailsRequest](docs/UpdateAmortisationRuleSetDetailsRequest.md)
 - [UpdateCalendarRequest](docs/UpdateCalendarRequest.md)
 - [UpdateComplianceTemplateRequest](docs/UpdateComplianceTemplateRequest.md)
 - [UpdateCustomEntityDefinitionRequest](docs/UpdateCustomEntityDefinitionRequest.md)
 - [UpdateCustomEntityTypeRequest](docs/UpdateCustomEntityTypeRequest.md)
 - [UpdateCutLabelDefinitionRequest](docs/UpdateCutLabelDefinitionRequest.md)
 - [UpdateDataTypeRequest](docs/UpdateDataTypeRequest.md)
 - [UpdateDerivedPropertyDefinitionRequest](docs/UpdateDerivedPropertyDefinitionRequest.md)
 - [UpdateFeeTypeRequest](docs/UpdateFeeTypeRequest.md)
 - [UpdateGroupReconciliationComparisonRulesetRequest](docs/UpdateGroupReconciliationComparisonRulesetRequest.md)
 - [UpdateGroupReconciliationDefinitionRequest](docs/UpdateGroupReconciliationDefinitionRequest.md)
 - [UpdateInstrumentIdentifierRequest](docs/UpdateInstrumentIdentifierRequest.md)
 - [UpdateOrdersResponse](docs/UpdateOrdersResponse.md)
 - [UpdatePlacementsResponse](docs/UpdatePlacementsResponse.md)
 - [UpdatePortfolioGroupRequest](docs/UpdatePortfolioGroupRequest.md)
 - [UpdatePortfolioRequest](docs/UpdatePortfolioRequest.md)
 - [UpdatePropertyDefinitionRequest](docs/UpdatePropertyDefinitionRequest.md)
 - [UpdateReconciliationRequest](docs/UpdateReconciliationRequest.md)
 - [UpdateReferenceDataRequest](docs/UpdateReferenceDataRequest.md)
 - [UpdateRelationshipDefinitionRequest](docs/UpdateRelationshipDefinitionRequest.md)
 - [UpdateStagingRuleSetRequest](docs/UpdateStagingRuleSetRequest.md)
 - [UpdateTaxRuleSetRequest](docs/UpdateTaxRuleSetRequest.md)
 - [UpdateUnitRequest](docs/UpdateUnitRequest.md)
 - [UpsertCdsFlowConventionsRequest](docs/UpsertCdsFlowConventionsRequest.md)
 - [UpsertComplexMarketDataRequest](docs/UpsertComplexMarketDataRequest.md)
 - [UpsertComplianceRuleRequest](docs/UpsertComplianceRuleRequest.md)
 - [UpsertComplianceRunSummaryRequest](docs/UpsertComplianceRunSummaryRequest.md)
 - [UpsertComplianceRunSummaryResult](docs/UpsertComplianceRunSummaryResult.md)
 - [UpsertCorporateActionRequest](docs/UpsertCorporateActionRequest.md)
 - [UpsertCorporateActionsResponse](docs/UpsertCorporateActionsResponse.md)
 - [UpsertCounterpartyAgreementRequest](docs/UpsertCounterpartyAgreementRequest.md)
 - [UpsertCreditSupportAnnexRequest](docs/UpsertCreditSupportAnnexRequest.md)
 - [UpsertCustomEntitiesResponse](docs/UpsertCustomEntitiesResponse.md)
 - [UpsertCustomEntityAccessMetadataRequest](docs/UpsertCustomEntityAccessMetadataRequest.md)
 - [UpsertDialectRequest](docs/UpsertDialectRequest.md)
 - [UpsertFlowConventionsRequest](docs/UpsertFlowConventionsRequest.md)
 - [UpsertIndexConventionRequest](docs/UpsertIndexConventionRequest.md)
 - [UpsertInstrumentEventRequest](docs/UpsertInstrumentEventRequest.md)
 - [UpsertInstrumentEventsResponse](docs/UpsertInstrumentEventsResponse.md)
 - [UpsertInstrumentPropertiesResponse](docs/UpsertInstrumentPropertiesResponse.md)
 - [UpsertInstrumentPropertyRequest](docs/UpsertInstrumentPropertyRequest.md)
 - [UpsertInstrumentsResponse](docs/UpsertInstrumentsResponse.md)
 - [UpsertLegalEntitiesResponse](docs/UpsertLegalEntitiesResponse.md)
 - [UpsertLegalEntityAccessMetadataRequest](docs/UpsertLegalEntityAccessMetadataRequest.md)
 - [UpsertLegalEntityRequest](docs/UpsertLegalEntityRequest.md)
 - [UpsertPersonAccessMetadataRequest](docs/UpsertPersonAccessMetadataRequest.md)
 - [UpsertPersonRequest](docs/UpsertPersonRequest.md)
 - [UpsertPersonsResponse](docs/UpsertPersonsResponse.md)
 - [UpsertPortfolioAccessMetadataRequest](docs/UpsertPortfolioAccessMetadataRequest.md)
 - [UpsertPortfolioGroupAccessMetadataRequest](docs/UpsertPortfolioGroupAccessMetadataRequest.md)
 - [UpsertPortfolioTransactionsResponse](docs/UpsertPortfolioTransactionsResponse.md)
 - [UpsertQuoteAccessMetadataRuleRequest](docs/UpsertQuoteAccessMetadataRuleRequest.md)
 - [UpsertQuoteRequest](docs/UpsertQuoteRequest.md)
 - [UpsertQuotesResponse](docs/UpsertQuotesResponse.md)
 - [UpsertRecipeComposerRequest](docs/UpsertRecipeComposerRequest.md)
 - [UpsertRecipeRequest](docs/UpsertRecipeRequest.md)
 - [UpsertReferencePortfolioConstituentPropertiesRequest](docs/UpsertReferencePortfolioConstituentPropertiesRequest.md)
 - [UpsertReferencePortfolioConstituentPropertiesResponse](docs/UpsertReferencePortfolioConstituentPropertiesResponse.md)
 - [UpsertReferencePortfolioConstituentsRequest](docs/UpsertReferencePortfolioConstituentsRequest.md)
 - [UpsertReferencePortfolioConstituentsResponse](docs/UpsertReferencePortfolioConstituentsResponse.md)
 - [UpsertResultValuesDataRequest](docs/UpsertResultValuesDataRequest.md)
 - [UpsertReturnsResponse](docs/UpsertReturnsResponse.md)
 - [UpsertSingleStructuredDataResponse](docs/UpsertSingleStructuredDataResponse.md)
 - [UpsertStructuredDataResponse](docs/UpsertStructuredDataResponse.md)
 - [UpsertStructuredResultDataRequest](docs/UpsertStructuredResultDataRequest.md)
 - [UpsertTransactionPropertiesResponse](docs/UpsertTransactionPropertiesResponse.md)
 - [UpsertTranslationScriptRequest](docs/UpsertTranslationScriptRequest.md)
 - [UpsertValuationPointRequest](docs/UpsertValuationPointRequest.md)
 - [User](docs/User.md)
 - [ValuationPointDataQueryParameters](docs/ValuationPointDataQueryParameters.md)
 - [ValuationPointDataRequest](docs/ValuationPointDataRequest.md)
 - [ValuationPointDataResponse](docs/ValuationPointDataResponse.md)
 - [ValuationPointOverview](docs/ValuationPointOverview.md)
 - [ValuationRequest](docs/ValuationRequest.md)
 - [ValuationSchedule](docs/ValuationSchedule.md)
 - [ValuationsReconciliationRequest](docs/ValuationsReconciliationRequest.md)
 - [ValueType](docs/ValueType.md)
 - [VendorDependency](docs/VendorDependency.md)
 - [VendorDependencyAllOf](docs/VendorDependencyAllOf.md)
 - [VendorLibrary](docs/VendorLibrary.md)
 - [VendorModelRule](docs/VendorModelRule.md)
 - [VersionSummaryDto](docs/VersionSummaryDto.md)
 - [VersionedResourceListOfA2BDataRecord](docs/VersionedResourceListOfA2BDataRecord.md)
 - [VersionedResourceListOfA2BMovementRecord](docs/VersionedResourceListOfA2BMovementRecord.md)
 - [VersionedResourceListOfHoldingContributor](docs/VersionedResourceListOfHoldingContributor.md)
 - [VersionedResourceListOfJournalEntryLine](docs/VersionedResourceListOfJournalEntryLine.md)
 - [VersionedResourceListOfOutputTransaction](docs/VersionedResourceListOfOutputTransaction.md)
 - [VersionedResourceListOfPortfolioHolding](docs/VersionedResourceListOfPortfolioHolding.md)
 - [VersionedResourceListOfTransaction](docs/VersionedResourceListOfTransaction.md)
 - [VersionedResourceListOfTrialBalance](docs/VersionedResourceListOfTrialBalance.md)
 - [VersionedResourceListWithWarningsOfPortfolioHolding](docs/VersionedResourceListWithWarningsOfPortfolioHolding.md)
 - [VirtualDocument](docs/VirtualDocument.md)
 - [VirtualDocumentRow](docs/VirtualDocumentRow.md)
 - [VirtualRow](docs/VirtualRow.md)
 - [Warning](docs/Warning.md)
 - [WeekendMask](docs/WeekendMask.md)
 - [WeightedInstrument](docs/WeightedInstrument.md)
 - [WeightedInstrumentInLineLookupIdentifiers](docs/WeightedInstrumentInLineLookupIdentifiers.md)
 - [WeightedInstruments](docs/WeightedInstruments.md)
 - [Workspace](docs/Workspace.md)
 - [WorkspaceCreationRequest](docs/WorkspaceCreationRequest.md)
 - [WorkspaceItem](docs/WorkspaceItem.md)
 - [WorkspaceItemCreationRequest](docs/WorkspaceItemCreationRequest.md)
 - [WorkspaceItemUpdateRequest](docs/WorkspaceItemUpdateRequest.md)
 - [WorkspaceUpdateRequest](docs/WorkspaceUpdateRequest.md)
 - [YieldCurveData](docs/YieldCurveData.md)
 - [YieldCurveDataAllOf](docs/YieldCurveDataAllOf.md)

