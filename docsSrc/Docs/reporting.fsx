(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use 
// it to define helpers that you do not want to show in the documentation.
#I "../../src/canopy/bin/Debug/netstandard2.0"
#I "../../packages/Selenium.WebDriver/lib/netstandard2.0"
#r "canopy.dll"
#r "WebDriver.dll"
#if !FAKE
#r "netstandard"
#endif

open canopy
open canopy.configuration
open canopy.types
open System

(**
Reporting
=========

Console Reporter
----------------
The default reporter. Prints results to console.
<img src="img/console.png" alt="Console Reporter" style="display: inherit;"/>

Live HTML Reporter
------------------
Prints results to an html page. Support images. Screenshots on error.
*)
open configuration
open reporters
reporter <- new reporters.LiveHtmlReporter(BrowserStartMode.Chrome, "driver path") :> IReporter

// Live HTML Reporter requires a context
context "Default test context"

(**
<img src="img/livehtmlreport.png" alt="Live HTML Reporter" style="display: inherit;"/>

TeamCity Reporter
-----------------
Prints special outputs that are compatible with team city.
*)

open configuration
open reporters
reporter <- new TeamCityReporter() :> IReporter

//screenshot is TODO

(**
JUnit Reporter
-----------------
Produces test results in basic JUnit format. Compatible with CircleCI. 
*)

open configuration
open reporters
reporter <- new JUnitReporter("./TestResults.xml") :> IReporter
