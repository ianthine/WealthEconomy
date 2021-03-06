### Changelog

**0.61.0**

* New contributor: eliza

**0.60.0**

* New contributor: coni2k
* New contributor: ianthine

**0.59.0**

* Contributors page
https://github.com/forCrowd/WealthEconomy/issues/69
* Sticky footer
* Disqus minor fix
* Menu minor layout fix
* npm jshint package missing fix
* Smtp settings initial port value fix
* DatabaseConfig InitializeDatabase fix

**0.58.0**

* Description field for resource pool
https://github.com/forCrowd/WealthEconomy/issues/68
* Is Main Element bug fix
https://github.com/forCrowd/WealthEconomy/issues/67
* Project notes were moved to wiki page
https://github.com/forCrowd/WealthEconomy/wiki
* package updates
 * breezejs was updated to 1.5.7 and odata adapter's manually fixed version was removed
 * angular was replaced with fixed 1.5.4: there is a problem with 1.5.5+ packages, it installs 1.5.7 instead
 * jquery was replaced with fixed 2.2.2: there is a problem with 2.2.3+ packages, it installs 3.0.0 instead
 * bootstrap-social package was removed

**0.57.0**

* Search page instead of list
https://github.com/forCrowd/WealthEconomy/issues/65
* Fix mobile navigation menu
https://github.com/forCrowd/WealthEconomy/issues/66
* glyphicon icons were replaced with font awesome

**0.56.0**

* resourcePoolManage - Field rating edit
https://github.com/forCrowd/WealthEconomy/issues/64
* Find keep alive service
https://github.com/forCrowd/WealthEconomy/issues/63
* Async action was removed from dataContext.js currentUser(): it was already keeping it as a local variable, now its returns that, which makes this function much easier to use.
* resourcePool and its child entities related functions were moved from dataContext.js to resourcePoolFactory.js

**0.55.1**

* resourcePoolEditor.js - getResourcePoolExpanded - resourcePool undefined check was added

**0.55.0**

* Auto register with guest account
https://github.com/forCrowd/WealthEconomy/issues/61
 * login.html & register.html was updated accordingly
 * registerLogin.html was removed
* Allow login with email address
https://github.com/forCrowd/WealthEconomy/issues/62
* Both Profile (/[username]) and New CMRP (/[username]/new) routes now correctly check 'username' for both against local (currentUser) & remote
* README.md updates
* favicon.ico update
* New css definitions

**0.54.0**

* Ignore 'anonymous users' in 'Reset Password' case
* Email address updates

**0.53.0**

* Navigate away confirmation in 'Unsaved changes' case
https://github.com/forCrowd/WealthEconomy/issues/60
 * isEditing property was removed
 * ResourcePool.isTemp property was removed
 * dataContext - _createEntitySuppressAuthValidation variable was removed
 * UPO & Basics CMRPs were moved from client-side to server-side (again)
* Register - Username and email inputs were disabled for anonymous user case
* 'Register / login modal is not displayed when a new anonymous user interacts after logout' bug fix
* Logo update
* appSettings minor update

**0.52.0**

* Send an exception to server in 404 case
https://github.com/forCrowd/WealthEconomy/issues/53
* Post correct binding models to server
https://github.com/forCrowd/WealthEconomy/issues/54
* Use breeze's z-validate directive for entity validation errors
https://github.com/forCrowd/WealthEconomy/issues/55
* OData controller error - No HTTP resource was found that matches the request URI
https://github.com/forCrowd/WealthEconomy/issues/56
* Create validate model filter
https://github.com/forCrowd/WealthEconomy/issues/58
* Improve OData validation
https://github.com/forCrowd/WealthEconomy/issues/59
* angular dependencies alphabetical order
* Todo.md cleanup

**0.51.2**

* ResourcePoolListController.js - $location is not defined
https://github.com/forCrowd/WealthEconomy/issues/57

**0.51.1**

* OData controller error - No HTTP resource was found that matches the request URI
https://github.com/forCrowd/WealthEconomy/issues/56
* Fixes for initial setup
 * -ExecutionPolicy Unrestricted was added for WebApiWarmup.ps1 call in post build
 * WebApi targets path fix
* Sketch.pptx file

**0.51.0**

* Add username to account
https://github.com/forCrowd/WealthEconomy/issues/20
* New regular account shows 'Add password' instead of 'Change password'
https://github.com/forCrowd/WealthEconomy/issues/22
* moment + angular moment.js libs were added
* Twitter badge on README
* BusinessObjects clean-up: Display(Name), DisplayOnEditView, DisplayOnListView etc.

**0.50.0**

* Anonymous account
https://github.com/forCrowd/WealthEconomy/issues/24
* Reset password & external login callback links fix
https://github.com/forCrowd/WealthEconomy/issues/23
* TempToken was renamed to SingleUseToken
* SimpleUseToken and HasPassword were moved from Claims to User table

**0.49.1**

* .gitignore _system folder fix
* 404 for fontawesome-webfont.woff2
https://github.com/forCrowd/WealthEconomy/issues/21

**0.49.0**

* ngClient - _system folder
https://github.com/forCrowd/WealthEconomy/issues/18

**0.48.0**

* Reset / Forgot Password
https://github.com/forCrowd/WealthEconomy/issues/5
* Remember me
https://github.com/forCrowd/WealthEconomy/issues/7
* Use Request.Form to send custom data to web api token endpoint
https://github.com/forCrowd/WealthEconomy/issues/17
* Store web api token itself in localStorage
https://github.com/forCrowd/WealthEconomy/issues/13
* 'Anonymous user warning remove' login page fix
* Update element cell multiplier buttons / functions (but hidden for now)
* Package updates

**0.47.2**

* Basics New Model 'Importance' index was renamed to 'Employee Satisfaction'

**0.47.1**

* Total Cost Index example cmrp id fix
* Sql - getResourcePoolRatingCount function fix
* Description update
* Database scripts update

**0.47.0**

* isEditing property was added to all entities: dataContext.createEntity return the object in isEditing state by default and In edit pages, until operation entity stays in isEditing state.
dataContext.saveChanges function ignores entities that are in isEditing state
* Data from Priority & Knowledge Index examples will be copied to 'All in One' until the user starts playing with that example
* UPO & Basics CMRPs were moved from server-side to client-side
* RatingCount instead of displayRatingMode() for handling Rating switch
* ResourcePool _init function was extended with setComputedFields block
* ResourcePool + ElementCell bug fix:
Even if resource pool belongs to current user, resourcePoolRateCount, resourcePoolRateTotal, numericValueCount, numericValueTotal functions were still using other users' data in FixedValue cases
* ResourcePoolEditor layout updates (text to right etc.)
* Content updates

**0.46.0**

* Disqus was enabled on all routes that has 'enableDisqus: true'
 * Original angular-utils-disqus wasn't loading the related disqus comments on route changes. Forked, fixed & replaced
 * https://github.com/michaelbromley/angularUtils/pull/296
* Total Cost Index - Both CMRPs update each other sales number
* Closing Notes was removed & icons section was moved to default page, only visible on home

**0.45.0**

* Content updates
 * Sector Index was renamed to Priority
 * Fair Share was removed
 * All in One was added
 * Total Cost Index, Implementation, Reason, Closing Notes updates

**0.44.0**

* Local, Test, Live environment types in AppSettings
* Exclude *.min files so they won't show up in "Find" operations in VS
* Add excluded *.min files into deploy package through .pubxml file
http://www.asp.net/mvc/overview/deployment/visual-studio-web-deployment/deploying-extra-files
* Exclude unnecessary *.js & *.css files from deploy package
* Return url for external login case
* login & externalLogin pages merge
* Anonymous user + New CMRP + Login with an existing account bug fix
* route.js - Authenticated & Unauthenticated user cases through route - resolve: If the user not logged in, can't access to 'authentication required' page and vice versa
* LocationHistory.js - previousItem() function with excludeAccessType parameter: To avoid login page return to 'unauthenticated required' type, accessType parameter will be used
* userFactory - currentUserChanged event instead of userLoggedIn & userLoggedOut events
* userFactory - getCurrentUser usage improvements
* Better implementation for 'anonymous user warning': Instead of creating a new entity, it displays it when dataContext.saveChanges() called
* generic error message for exceptions
* Login fail case double error toastr fix
* Email address & database for test server
* Release Notes.md was moved & renamed to CHANGELOG.md

**0.43.5**

* 'Retrieving data from user level tables are failing with "Unauthenticated access" exception' fix
Exact cause is unknown but registering Compression message handler after than 'config.SuppressDefaultHostAuthentication' fixed the issue
* User level controller's 'Exists function fails due to multiple keys' fix
Exists parts were replaced with SingleOrDefault()
* 'Missing glyphicons fonts' fix
* ngClient - LoginController - returnUrl fix for newly loaded app
* WealthEconomyContext - Don't add deleted items addition
* WebApi - Startup.cs + WebApiConfig merge
* WebApi - default.aspx version text was added
* gulpfile updates
* Package updates

**0.43.4**

* ResourcePoolManageController - remove resource pool fix:
Controllers in openRemoveResourcePoolModal, openCopyModal functions were not using array syntax for their dependencies.

**0.43.3**

* Compression was enabled on WebApi / OData responses by using 'Microsoft.AspNet.WebApi.MessageHandlers.Compression'
https://www.nuget.org/packages/Microsoft.AspNet.WebApi.MessageHandlers.Compression/

**0.43.2**

* Sourcemap generation was added to gulp minifying
* angular exceptionHandling was modified to handle sourcemapped stacktrace
* breeze.base.debug.js + necessary adapters as main breeze setup, instead of breeze.debug.js
 * Also breeze.dataService.odata.js fix: https://github.com/Breeze/breeze.js/pull/128
* External libraries minified & bundled as well: lib.js, lib.min.js, lib.css, lib.min.css
* .tt files and most of the generated files were remove from ngClient
* gulpfile errorHandler was added for uglify
* ngClient folder structure update
* bower packages were updated
* ngClient.Tests project was updated
* Renames: main.all.js -> app.js, main.min.js -> app.min.js, site.all.css -> app.css, site.min.css -> app.min.css, MainController -> DefaultController
* "Loading..." text for initial load of resource pool editor
* lib.css was missing bootstrap-social package fix
* app.min.css fix

**0.43.1**

* One "settings.js" file for ngClient settings
* locationHistory factory instead of LocationItem object
* location.path() was replaced with location.url() in most cases to clear the search params, instead of search('x', null)

**0.43.0**

* gulp: auto jshint check, bundling, minifying for js & css files
* "angular-google-analytics" for google analytics
* "angular-utils-disqus" for disqus
* jshint fixes
* ResourcePoolEdit(Controller) was renamed to ResourcePoolManage(Controller) to fix the conflict with generated one

**0.42.2**

* gitignore cleanup
* ngClient reference cleanup
* ngClient tests Commons.js path fix
* Separate ngClient.Tests project
* Setup\elmah.errorMail.config initial values fix
* SSLEnabled false for WebApi project
* README.md update

**0.42.1**

* Multiple TempToken bug fix
* 'User get stuck on WebApi in case of an exception in AccountController - ExternalLoginCallback' fix
* Default documents were changed to ".aspx" files again:
In case of an update in the page, browsers automatically get the latest default.aspx file, but not default.html file
(always serves from the cache, even with cache busting attempt in web.config / default document / default.html?v=0.42)

**0.42.0**

* Separation of Web client (ngClient) & WebApi
 * Cors was enabled on WebApi
 * client related files were removed from WebApi
 * bower was installed to ngClient and all client packages were installed through bower
 * Mvc, Web pages and other unnecessary packages were removed
 * RequireHttps flag for WebApi
 * CustomErrors for WebApi
* Global.asax functional was moved to Startup.cs
 * Http to Https rule handling was moved to web.config
* "test.forcrowd.org" domain was created for tests before production

**0.41.4**

* nuget package updates were installed

**0.41.3**

* updateAnonymousChanges fix: When rejectChanges is called, the entity was getting removed from the array during the loop. slice() used to prevent it.
* external / local login anonymous user fix: detaching anonymous user in external case login was affecting normal login case.
Now both cases call updateAnonymousChanges method which handles this case correctly.
* userFactory getCurrentUser + isAuthentication functions were merged

**0.41.2**

* angular entity update - 'RowVersion field out of sync' fix
 * Json formatter reference loop handling was set to 'Ignore'
* Social login - 'userFactory getCurrentUser leaves a temp user in the context' fix
* UserManager ChangeEmailAsync function was replaced with existing SetEmailAsync
* Client side error handling improvements

**0.41.1**

* Add password option for new social logins case
* Send notification email to admin in social login case
* Update elmah config to use existing smtp settings

**0.41.0**

* Social logins: Facebook, Google, Microsoft
 * Social Buttons for Bootstrap: http://lipis.github.io/bootstrap-social/
 * FontAwesome: http://fortawesome.github.io/Font-Awesome/
* Registration email address info moved to appSettings
* Elmah settings moved to Configs folder
* RequireHttps attribute for WebApi
* Redirect http requests to https for live

**0.40.0**

* Email confirmation has implemented
* Survey.docx: A simple survey about the content.
* logger.js minor improvements
* forEach, some, filter functions instead of 'for' loops for arrays
* angular brackets "{{ }}"" were replaced with "data-ng-bind"
* Javascript clean-up

**0.39.0**

* Elmah angular exception logging: angular exceptionHandler was extended to post the exception to server side
On server side, ExceptionController was created to handle & log the incoming exceptions

**0.38.5**

* ElementField.js - DataType property: When the type changes, first it removes the old values and then sets the default ones to the related cells
* Element type will be only be shown if there are more than one element in the resource pool

**0.38.4**

* Updating anonymous entities to logged user, existing user case fix: Now it merges anonymous & existing user data

**0.38.3**

* userFactory.js - updateX functions detached entity bug fix

**0.38.2**

* CMRP Edit - New element field uses resourcePoolFactory.createElementField now
* New element cells don't get saved fix
updateCache function was using accept changes only if the elementcell wasn't modified earlier, which was causing a problem if element cell was in isAdded state.
Now that's changed into only if element cell was previously in unchanged state.

**0.38.1**

* CMRP Edit - New element field Index Enabled change doesn't set related properties fix
* CMRP Edit - New element field DirectIncome data type will always be UseFixedValue true
* CMRP Edit - New element field Multiplier data type will always be UseFixedValue false (fixed)

**0.38.0**

* Anonymous CMRP create / edit
LocationItem object was created to hold the newly created resource pools, so it can navigate back to correct Id that's been retrieved from the server
* Anonymous user login fix
If the user logs in after interacting as an 'anonymous user', changes will be saved as that logged in user's
* Element.IsMainElement instead of ResourcePool MainElement (back to previous method)
* ResourcePool.CurrentElement property was replaced with selectedElement function
* Server-side properties were added to javascript objects, except Navigation Properties (due to breezejs error)

**0.37.0**

* Resource Pool create / edit feature was added
* ElementField - ElementFieldType was renamed to DataType, IndexType was renamed to IndexCalculationType, IndexRatingSortType was renamed to IndexSortType
* Adding a default 'Name' field approach was removed
* enumKey angular filter was added: Probably this enum operations can be done in a better way
but right now this is the easiest way to save the day.
* dataContext.js createEntity() was updated to a synchronous function again
Creating entities was too difficult & complex with async. function
metadataReady() function is now called under initializeStore() and it doesn't wait for the result.
To fix this issue permanently;
https://github.com/angular/angular.js/issues/4003
* (An empty) robots.txt was created
* File & folder / url structure updates
* highcharts updates
* angular-ui-bootstrap updates for deprecated directives
* New / edit entity view bug fix

**0.36.2**

* ElementItem name was updated to 250 chars
* Content updates

**0.36.1**

* angular-numberSymbol filter
* OtherUsers' values calculation bug fix
* Content updates

**0.36.0**

* Billion Dollar Question
* ElementField - IndexType property was added
There are two types; Aggressive (existing) & Passive
Passive case covers CMRPs that only use Initial value (like Billion Dollar Question)
* Content updates

**0.35.2**

* Content updates

**0.35.1**

* Upgraded to Visual Studio 2015 & .NET Framework 4.6
* nuget package updates were installed
* SolutionItems/Notes folder was renamed to Documents
* ResourcePoolEditor - label as badge toggle color fix
* Setup instructions were updated

**0.35.0**

* Performance Update: Most of the calculations (numericValue, passiveRating, aggressiveRating, indexIncome etc. functions) are cached
and they only calculated when there is an actually change in one of the related values.
All in One example increase multiplier action was reduced under a second from 7 seconds.
* Further with javascript tests & entities cleanup
* resourcePool, elementField, elementCell - other users' average properties were merged with other users' total
* element.js - parents() was renamed to familyTree() & parent() returns null if there is no actual parent (instead of self)
* Javascript tests array fix; initial push() lines were replaced with assignments (.array = [object])
* ResourcePool - ResourcePoolRate was renamed to ResourcePoolRateTotal
* ElementField - IndexRating was renamed to IndexRatingTotal
* ElementCell - NumericValue was renamed to NumericValueTotal

**0.34.1**

* ResourcePoolRate calculation fix
* Minor updates

**0.34.0**

* Hosting plan upgrade
* New javascript tests

**0.33.0**

* Cache breaker value update (033 -> 0.33)
* Other users' properties calculation fixes (again)

**0.32.0**

* angular unit testing: Node.js, Chutzpah, Jasmine
* Other users' properties calculation fixes
* BusinessObjects cleanup

**0.31.0**

* https://github.com/forCrowd/WealthEconomy/issues/50
* https://github.com/forCrowd/WealthEconomy/issues/25
* Label as on / off badge was created

**0.30.0**

* Tooltips for resource pool editor
* ResourcePool EnableResourcePoolAddition was renamed to UseFixedResourcePoolRate
* ResourcePool EnableSubtotals field was removed
* angular-ui-bootstrap instead of bootstrap.js
* Content updates

**0.29.2**

* https://github.com/forCrowd/WealthEconomy/issues/8
* Logo was added to footer

**0.29.1**

* Minor content updates

**0.29.0**

* https://github.com/forCrowd/WealthEconomy/issues/15
* https://github.com/forCrowd/WealthEconomy/issues/48
* https://github.com/forCrowd/WealthEconomy/issues/49
* https://github.com/forCrowd/WealthEconomy/issues/12
* https://github.com/forCrowd/WealthEconomy/issues/14

**0.28.0**

* https://github.com/forCrowd/WealthEconomy/issues/27

**0.27.1**

* https://github.com/forCrowd/WealthEconomy/issues/46
* https://github.com/forCrowd/WealthEconomy/issues/47

**0.27.0**

* https://github.com/forCrowd/WealthEconomy/issues/40
* https://github.com/forCrowd/WealthEconomy/issues/26
* https://github.com/forCrowd/WealthEconomy/issues/39
* https://github.com/forCrowd/WealthEconomy/issues/41
* https://github.com/forCrowd/WealthEconomy/issues/16
* https://github.com/forCrowd/WealthEconomy/issues/42
* https://github.com/forCrowd/WealthEconomy/issues/43
* https://github.com/forCrowd/WealthEconomy/issues/44
* https://github.com/forCrowd/WealthEconomy/issues/45
* https://github.com/forCrowd/WealthEconomy/issues/6

**0.26.0**

* https://github.com/forCrowd/WealthEconomy/issues/37
* https://github.com/forCrowd/WealthEconomy/issues/38

**0.25.0**

* https://github.com/forCrowd/WealthEconomy/issues/34
* https://github.com/forCrowd/WealthEconomy/issues/35
* https://github.com/forCrowd/WealthEconomy/issues/36

**0.24.0**

* Reset cases of user level data was improved
* Composite keys were used in User level tables, Id fields were removed
* Initial_Manual migration drop function fix
* Package updates

**0.23.0**

* ResourcePool MainElement instead of Element.IsMainElement
* All projects were upgraded to .NET 4.5.1
* Todo cleanup & moving items to GitHub "Issues"

**0.22.3**

* fetched fix for user logged out case

**0.22.2**

* Change password fix
* SeedInitialData method updates & fixes

**0.22.1**

* introductionController increaseMultiplier timer definition before resourcePool fix

**0.22.0**

* Registration alert email
* AppSettings.cs to Framework

**0.21.0**

* Invalid CMRP Id case

**0.20.0**

* MVC clean-up
* Improvements for Error, 404 cases

**0.19.1**

* finally block was used in getUserInfo() method of controllers to prevent loading resource pools before determining whether there is a user or not
* Social media etc. cleanup

**0.19.0**

* Cache breaking attempt
* BundleConfig.cs scripts, styles were moved to layout.cshtml

**0.18.1**

* resourcePoolService expanded methods can now query local as well
* basicsController & introductionController invalid service method call fix
* basicsController timer fix
* Other timer adjustments

**0.18.0**

* Delayed save feature was added. resourcePoolEditor actions will be saved after a second.
* Web - External components (gratipay, flattr, twitter etc.) was moved to js files and also disabled in case of localhost

**0.17.2**

* Multitenancy: It raises an exception if the request is not authenticated
* Copying sample user's data as the initial values will not be used anymore, angular objects will handle it.
* Web loginController.js $rootScope fix
* Content updates
* Code cleanup

**0.17.1**

* Multitenancy: "Sequence contains more than one element" temporary fix for User level tables

**0.17.0**

* ResourcePoolEditor isAuthenticated check for buttons
* routeRun() & locationHistory array was added to remember and navigate back after register & login operations

**0.16.1**

* IsAuthenticated fix for ResourcePool - UserResourcePool property
* Total Cost Index Id fix
* elementItem multiplierValue default value 0 doesn't work for Index Income field, which is an issue but will be fixed later. For now default value is 1 again
* Hid "Save failed" log messages

**0.16.0**

* ResourcePool examples could be retrieved without authorization now
* CopySampleDataAsync in UserStore also copies sample field index values
* createEntity cases implemented for userResourcePool, userElementCell and userElementFieldIndex entities
* Paypal logo update

**0.15.0**

* Twitter, Facebook, GitHub, LinkedIn, Google Plus, Youtube Channel, Disqus, Flattr, Gratipay accounts were created
* MIT License was added
* It's Open Source & Encourage Us contents were updated / added
* Google Analytics was added

**0.14.18**

* Content updates etc.

**0.14.17**

* Transferred to forCrowd

**0.14.16**

* bootstrap panel for resourcePoolEditor
* Content updates
* summary.html, contribute.html, feedback.html were added

**0.14.15**

* Bug fixes

**0.14.14**

* One item in the element index income fix
* Text updates

**0.14.13**

* Index income calculation fixes
* Text and example updates
* ResourcePoolEditor currentElement fullSize property to determine the place of chart (on top or left side of the items)

**0.14.12**

* CMRP Rate is back
* CMRP Rate example was added
* Aggressive Rating method was introduced; now the organizations with the lowest rating don't get any share from the pool.
Related issue with 'Total Cost Index - New Model' example was fixed
* Knowledge Index charts fix
* Examples minor updates
* chapter0 content blocks are now separate html files and called from home.html by using ng-include. chapter0 was removed.
* highcharts scripts were copied to local
* resourcePoolEditor layout updates

**0.14.11**

* Indexes Pie
* resourcePoolEditor layout updates
* resourcePoolEditor.css was created and both .css & .html files moved under 'directives' folder
* Web - SecurityConfig, debug auth was disabled due to conflict with Bearer token auth. - Will be checked later

**0.14.10**

* Total Cost Index was updated
* Fair Share Index was added

**0.14.9**

* UserElementCell table has now BooleanValue, IntegerValue, DecimalValue, DateTimeValue like ElementCell. Rating column was dropped
* ResourcePoolIndex was changed to ElementFieldIndex
* Multiplier cell value is now on user level (UserElementCell) instead of a fixed value (ElementCell)
* ElementFieldIndex is now on User level, instead of UserResourcePool
* SortOrder field was added to ElementField
* resourcePoolEditor angular directive
* InitialValue on ResourcePool class
* sessionStorage was replaced with localStorage to keep "access_token"
* Azure websites is back again; http://wealth.azurewebsites.net
* Register for error messages fix
* editView.tt 
 * Both nullable and non-nullable boolean type will be rendered as radio input
 * 'Cancel' type was changed to 'button' type instead of 'submit' and service.cancelChanges() method was removed
* LazyLoading was disabled
* breeze RowVersion property issue was fixed
* Extending the breeze's entities, instead of DTOs from WebApi, WebApi DTOs were removed
* Element drill up & down for ResourcePoolEditor directive
* Web - CustomAuthentication filter with debug user (for OData query tests)
* DataObjects - DropCreateAlways & MigrateToLatest combo db initializer
* DataObjects - Multitenancy;
http://xabikos.com/multitenant/application%20design/software%20as%20a%20service/2014/11/17/create-a-multitenant-application-with-entity-framework-code-first---part-1.html
* Old chapters were removed, chapter0 became home page for now

**0.14.8**

* BusinessObjects.Tests project was created
* Framework.Tests project was created - TypeExtensionsTests & ValidationTests classes were added
* More fluent interface
* Business Objects, constructors with parameters
* TotalCostIndex example fix

**0.14.7**

* Clean-up
 * ElementItemElementField was renamed to ElementCell
 * Long property names were shortened
* Package updates & breeze - Microsoft AspNet WebApi OData 5.3.x conflict fix
* Warm-up script was converted to PowerShell + gitignore was modified for WarmUpResult.txt
* Version number fix; 0.14.6.1 -> 0.14.7
* Exception handling & Elmah
* IdentityUser & User classes merge
* Switched to SQL Server 2014 Express LocalDB
* Cookie authentication was disabled and bearer token is now the only method
* tt files were updated with Identity
* ValidationErrors on client-side
* Mvc general & 404 error handling
* Azure websites; http://wealth.azurewebsites.net
* Local Restore Database sql script (experimental)
* Unit testing improvements
* Bit of fluent interface
* Part of the initial sample data was updated according to the latest updates
* Chapters visible again, although some one the pages still need to be updated

**0.14.6**

* Clean-up; Organization and related parts were removed

**0.14.5**

* Element parent - child structure was partially added

**0.14.4**

* IsMainElement field was added to Element table
* ResourcePool and Multiplier field types were added; Element table was replaced Organization table

**0.14.3**

* ProductionCost field was removed from Organization table

**0.14.2**

* Element Fields feature was added with string, boolean, int32, decimal, datetime types & highest to lowest, lowest to highest sort options
* TotalCostIndex, DynamicOrganizationIndex and DynamicElementIndex types were removed since it's possible to handle them with DynamicFieldIndex now

**0.14.1**

* Clean-up

**0.14.0**

* Elements feature was added
* Knowledge Index & License combo was replaced with Element & ElementItem & DynamicElementIndex
* Sector Index & Sector combo was replaced with Dynamic(Organization)Index
* Web - manageScripts.js + manageMenu.js
* Total Cost + Dynamic Element index tests were added

**0.13.7**

* Clean-up

**0.13.6**

* Sector + Knowledge + Total Cost indexes were moved under ResourcePoolIndex

**0.13.5**

* IndexIncome calculation was modified
* WeightedAverage -> Percentage
* NumberOfSalesPercentage was added

**0.13.4**

* Quality + Employee + Custom static indexes were removed
* accountEditController - id route parameter was replaced with using userService.getUserInfo
* README.md fine-tuning

**0.13.3**

* Web - UserResourcePool custom list + view

**0.13.2**

* Web - angular route was simplified + folder & file name structure was updated

**0.13.1**

* DistanceIndex field was removed from UserResourcePool
* Nuget auto package restore
* Sample data creation order was changed; Sector, Knowledge, TotalCost, Quality, Employee, Customer
* Chapter4 + Chapter5 fixes
* login error fix

**0.13.0**

* Introduction to Dynamic Indexes
* DistanceIndex was removed in from calculations, field will be removed later on
* IndexShare property calculation bug fixed
* Property naming updates
* SectorChart page was removed

**0.12.4**

* BusinessObjects minor revisions

**0.12.3**

* UserResourcePool unique index on UserId + ResourcePoolId
* appveyor.yml

**0.12.2**

* BusinessObjects and Metadata classes merge

**0.12.1**

* BusinessObjects revisions
* UserResourcePool ResourcePoolType was removed

**0.12.0**

* Chapters - Since it's not good enough, it's hidden in the menu
* TotalCostIndex calculation is now based on Sales Price again, instead of Profit

**0.11.12**

* Text updates

**0.11.11**

* AccountEdit page instead of using the generic user edit, to be able customize it like removing cancel button etc.
* Reset sample data function added

**0.11.10**

* Replace metadata.xml with EdmBuilder CodeFirst output
 * WealthEconomyContext moved under BusinessObjects
* IsSample field to ResourcePool object, SampleUserId to Web\web.config and UserUnitOfWork now uses these parameters to copy the sample data

**0.11.9**

* TotalCostIndex calculation is now based on Profit, instead of Sales Price
* Values of examples were updated (.25 vs .75)
* All in One was re-enabled
* Sample user was created and sample data moved to this account
* UserResourcePool pages subtotals were fixed
* ODataController.tt fine-tuning
* User - AspNetUserId required

**0.11.8**

* UserResurcePoolCustom api controller was created and special methods moved to this controller from OData
* New UserResourcePool save failed issue was fixed

**0.11.7**

* UnitOfWork methods are now saving the changes at the end. Save method is not public any more
* DecreaseNumberOfSales method was implemented
* SectorChart page only shows Sector resource pool related data + negative values fix
* DataObjects.Tests project was removed
* tt output files were removed from Web project's publish output

**0.11.6**

* Cascade delete option enabled
* Sample child records will be added when creating a new ResourcePool, Sector, License, Organization, User ResourcePool entities

**0.11.5**

* Database seed method was updated to add sample records
* UserUnitOfWork insert method was synced with latest updates
* Initial admin password updated

**0.11.4**

* 'Definition controllers are only accessible to admins' rule didn't work, removed. Check this later on.

**0.11.3**

* UserResourcePoolEdit page fix

**0.11.2**

* ResourcePoolId field was removed from Organization table

**0.11.1**

* README.md and Release Notes.txt files merged

**0.11.0**

* HighCharts implementation: SectorChart page

**0.10.9**

* T4 files update to use IdentityContext
 * Dependencies folder was created under Framework - T4 folder, that contains IdentityContext libraries
* EntityFramework.dll + EntityFramework.SqlServer.dll files under  
C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE folder  
were replaced with Entity Framework 6.1 versions.

**0.10.8**

* MSBuild and IISExpress script files were created
* UserAccountType.cs file and its references were removed
* WealthEconomyContext and AspNetIdentityContext were merged
* Initial admin role + user + password

**0.10.7**

* breeze.js - metadataReady method in dataContext

**0.10.6**

* Concurrency check - RowVersion field was added to all entities and in ODataController it does a concurrency check for Patch operation

**0.10.5**

* routing fixes
 * if it's supported, angular html5Mode is on
 * href fixes
 * mvc routing always goes to HomeController, so angular can handle the requests

**0.10.4**

* glimpse nuget package - only for development environment for now
* Thanks to glimpse, <clear /> line was added to connectionstrings section in config files

**0.10.3**

* Nuget package updates

**0.10.2**

* Register + ChangePassword pages

**0.10.1**

* Session state related files + codes were removed
* Password, UserAccountTypeId fields were removed from User table
* Alterations folder was removed from SolutionItems
* Authorization filter was added to all Api controllers, Register action in AccountController was set to AllowAnonymous
* Administrator role was introduced - All definition Controller were put under "Administrator" role except "User" controller
* BaseController was created and ODataController.tt was modified to create BaseEntityControllers
* CodeTemplates folder was removed

**0.10.0**

* Asp.Net Identity

**0.9.2**

* BusinessObjects
 * Merge generated and custom classes
 * BaseEntity class
 * Clean up + fine-tuning
* Framework - T4 files fixes

**0.9.1**

* BusinessObjects - StringLength attributes

**0.9.0**

* Application
 * Converted to Code First approach from Database First
     * T4 files were updated to read from Code First metadata
     * EF6.Utility.cs was moved to the solution
 * Switched to LocalDb instead of SQL Server 2008 R2
 * T4 include files are now under Framework\T4 folder

**0.8.1**

* Web - Cleaning up the old mvc controllers + views etc.

**0.8.0**

* Database
 * ResourcePool table became the main container for Organization, License and Sector tables
 * UserResourcePoolOrganization was dropped and UserOrganization was introduced

**0.7.0**

* SPA with OData + AngularJS + Breeze.js + toastr.js
* Database - Sector table Id field switched to smallint from byte
* Solution - Refactoring tt files
* Solution - nuget package updates

**0.6.3**

* Web - Overview text update

**0.6.2**

* Web - Overview text update

**0.6.1**

* BusinessObjects - Required attribute for Dto classes

**0.6.0**

* Facade - UnitOfWork fine-tuning
* General - Password for User table + basic authentication
* Web - Controller.tt was created

**0.5.0**

* SolutionItems - Local_UpdateDatabase.sql was updated to remove doktrosizlar db items
* Business + DataObjects
 * To support tables with multiple primary key, IEntity interface Id property was replaced with IsNew
* Web - Controllers fine-tuning

**0.4.2**.2

* General - Missing files were restored - attempt #2

**0.4.2**.1

* General - Missing files were restored

**0.4.2**

* General - github repo merge

**0.4.1**

* General - Release Notes.txt was updated

**0.4.0**

* DataObjects
 * Utility.ttinclude: Common code blocks from t4 files were moved to this file
 * Repositories were updated
* BusinessObjects
 * Metadata.t4 was moved under "Generated" folder and was modified to generated the files for once.
* Facade
 * UnitOfWork classes were created for each entity
* Web
 * Repositories + UnitOfWork updates
* General
 * config files connectionstrings were updated
 * github repository reset

**0.3.0**

* BusinessObjects
 * OrganizationGroupType was renamed to UserResourcePoolType
 * UserDistributionIndexRatingAverage class was merged into UserResourcePool
 * BusinessObjectsDto.t4 was add to be able create Dto classes
 * OrganizationGroupType was renamed to UserResourcePoolType
* Web
 * Number of ratings info was added to CMRP views
 * Create / Edit operations were modified to use Dto classes
* Database + General
 * UserResourcePool table ResourcePoolRate field percentage update - values were divided to 100

**0.2.0**

* Database + General
 * ResourcePool + ResourcePoolOrganization + UserResourcePool + UserResourcePoolOrganization tables were added
 * User table ResourcePoolRate was removed
 * UserDistributionIndexRating table was removed
 * UserOrganizationRating table was removed
* General - Versioning method was updated: Minor version number will be increased in every update

**0.1.9**.1 - 06 Mar '14

* Web + SolutionItems - Minor description text update

**0.1.9** - 06 Mar '14

* SolutionItems - Maintenance scripts
* Database
 * Organization table UserId + NumberOfSales fields were removed
 * UserOrganizationRating table NumberOfSales field was added
 * All tables CreatedOn + ModifiedOn default values
* Web
 * Quality Private + Public views
 * Sector Private + Public views
 * Employee Satisfaction Private + Public views
 * Customer Satisfaction Private + Public views
 * All in One Private + Public views

**0.1.8** - 04 Mar '14

* General - User Notes field
* General - User account type + web menu items visibility based on the type
* Web - ServerMode + DevelopmentModeConfig for auto login
* Web - Knowledge Index Private + Public views

**0.1.6** - 19 Feb '14

* Database - Organization table UserId field: To solve "Increase + Reset Number of Sales" issue, organizations are now under users
* Web - UserController Create method generates sample data for the new user
* Web - ResourcePool views are now listing user's organizations

**0.1.5** - 01 Feb '14

* Web - Distance Index
* Web - Edit user back button fix
* Minor fixes + updates

**0.1.4** - 31 Jan '14

* Database - User table ResourcePoolRate field
* Web - Login + logout + edit user
* Web - All In One view

**0.1.3** - 29 Jan '14

* Web - CMRP Reports
* Web - Menu update

**0.1.2** - 28 Jan '14

* DataObjects - Organization - NumberOfSales field added
* Web - CMRPReport + Total Cost Index calculations
* Web - Home + menu updates

**0.1.1** - 24 Jan '14

* .gittattributes file
* Initial solution commit
* Update README.md
* Initial commit
