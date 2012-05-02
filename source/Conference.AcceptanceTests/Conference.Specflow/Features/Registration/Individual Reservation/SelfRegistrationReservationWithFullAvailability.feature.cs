﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.261
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Conference.Specflow.Features.Registration.IndividualReservation
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class SelfRegistrantScenariosForMakingAReservationForAConferenceSiteWithAllOrderItemsInitiallyAvailableFeature : Xunit.IUseFixture<SelfRegistrantScenariosForMakingAReservationForAConferenceSiteWithAllOrderItemsInitiallyAvailableFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SelfRegistrationReservationWithFullAvailability.feature"
#line hidden
        
        public SelfRegistrantScenariosForMakingAReservationForAConferenceSiteWithAllOrderItemsInitiallyAvailableFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Self Registrant scenarios for making a Reservation for a Conference site with all" +
                    " Order Items initially available", "In order to reserve Seats for a conference\r\nAs an Attendee\r\nI want to be able to " +
                    "select an Order Item from one or many of the available Order Items and make a Re" +
                    "servation", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 20
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "rate",
                        "quota"});
            table1.AddRow(new string[] {
                        "General admission",
                        "$199",
                        "100"});
            table1.AddRow(new string[] {
                        "CQRS Workshop",
                        "$500",
                        "100"});
            table1.AddRow(new string[] {
                        "Additional cocktail party",
                        "$50",
                        "100"});
#line 21
 testRunner.Given("the list of the available Order Items for the CQRS summit 2012 conference with th" +
                    "e slug code SelfRegFull", ((string)(null)), table1);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table2.AddRow(new string[] {
                        "General admission",
                        "1"});
            table2.AddRow(new string[] {
                        "CQRS Workshop",
                        "1"});
            table2.AddRow(new string[] {
                        "Additional cocktail party",
                        "1"});
#line 26
 testRunner.And("the selected Order Items", ((string)(null)), table2);
#line hidden
        }
        
        public virtual void SetFixture(SelfRegistrantScenariosForMakingAReservationForAConferenceSiteWithAllOrderItemsInitiallyAvailableFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Self Registrant scenarios for making a Reservation for a Conference site with all" +
            " Order Items initially available")]
        [Xunit.TraitAttribute("Description", "All the Order Items are available and all get reserved")]
        public virtual void AllTheOrderItemsAreAvailableAndAllGetReserved()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("All the Order Items are available and all get reserved", ((string[])(null)));
#line 36
this.ScenarioSetup(scenarioInfo);
#line 20
this.FeatureBackground();
#line 37
 testRunner.When("the Registrant proceed to make the Reservation");
#line 38
 testRunner.Then("the Reservation is confirmed for all the selected Order Items");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table3.AddRow(new string[] {
                        "General admission",
                        "1"});
            table3.AddRow(new string[] {
                        "CQRS Workshop",
                        "1"});
            table3.AddRow(new string[] {
                        "Additional cocktail party",
                        "1"});
#line 39
 testRunner.And("these Order Items should be reserved", ((string)(null)), table3);
#line 44
 testRunner.And("the total should read $749");
#line 45
 testRunner.And("the countdown started");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Self Registrant scenarios for making a Reservation for a Conference site with all" +
            " Order Items initially available")]
        [Xunit.TraitAttribute("Description", "All the Order Items are available and all get waitlisted")]
        public virtual void AllTheOrderItemsAreAvailableAndAllGetWaitlisted()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("All the Order Items are available and all get waitlisted", new string[] {
                        "Ignore"});
#line 54
this.ScenarioSetup(scenarioInfo);
#line 20
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type"});
            table4.AddRow(new string[] {
                        "General admission"});
            table4.AddRow(new string[] {
                        "CQRS Workshop"});
            table4.AddRow(new string[] {
                        "Additional cocktail party"});
#line 55
 testRunner.Given("these Seat Types becomes unavailable before the Registrant make the reservation", ((string)(null)), table4);
#line 60
 testRunner.When("the Registrant proceed to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type"});
            table5.AddRow(new string[] {
                        "General admission"});
            table5.AddRow(new string[] {
                        "CQRS Workshop"});
            table5.AddRow(new string[] {
                        "Additional cocktail party"});
#line 61
 testRunner.Then("the Registrant is offered to be waitlisted for these Order Items", ((string)(null)), table5);
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Self Registrant scenarios for making a Reservation for a Conference site with all" +
            " Order Items initially available")]
        [Xunit.TraitAttribute("Description", "All Seat Types are available, one get reserved and two get waitlisted")]
        public virtual void AllSeatTypesAreAvailableOneGetReservedAndTwoGetWaitlisted()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("All Seat Types are available, one get reserved and two get waitlisted", new string[] {
                        "Ignore"});
#line 74
this.ScenarioSetup(scenarioInfo);
#line 20
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type"});
            table6.AddRow(new string[] {
                        "CQRS Workshop"});
            table6.AddRow(new string[] {
                        "Additional cocktail party"});
#line 75
 testRunner.Given("these Seat Types becomes unavailable before the Registrant make the reservation", ((string)(null)), table6);
#line 79
 testRunner.When("the Registrant proceed to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type"});
            table7.AddRow(new string[] {
                        "CQRS Workshop"});
            table7.AddRow(new string[] {
                        "Additional cocktail party"});
#line 80
 testRunner.Then("the Registrant is offered to be waitlisted for these Order Items", ((string)(null)), table7);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table8.AddRow(new string[] {
                        "General admission",
                        "1"});
#line 84
 testRunner.And("these Order Items should be reserved", ((string)(null)), table8);
#line 87
 testRunner.And("the total should read $199");
#line 88
 testRunner.And("the countdown started");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                SelfRegistrantScenariosForMakingAReservationForAConferenceSiteWithAllOrderItemsInitiallyAvailableFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                SelfRegistrantScenariosForMakingAReservationForAConferenceSiteWithAllOrderItemsInitiallyAvailableFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
