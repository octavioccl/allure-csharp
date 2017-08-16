﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Tests.SpecRun.TestData
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Scenario and Step Bindings", new string[] {
            "data"}, SourceFile="TestData\\Scenario Hooks.feature", SourceLine=1)]
    public partial class ScenarioAndStepBindingsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Scenario Hooks.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Scenario and Step Bindings", null, ProgrammingLanguage.CSharp, new string[] {
                        "data"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
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
        
        [TechTalk.SpecRun.ScenarioAttribute("Should handle BeforeScenario and BeforeStep failure", new string[] {
                "beforescenario",
                "beforestep",
                "failed"}, SourceLine=4)]
        public virtual void ShouldHandleBeforeScenarioAndBeforeStepFailure()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should handle BeforeScenario and BeforeStep failure", new string[] {
                        "beforescenario",
                        "beforestep",
                        "failed"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given("Step is \'passed\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.Given("Step is \'passed\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Should handle BeforeScenario failure", new string[] {
                "beforescenario",
                "failed"}, SourceLine=9)]
        public virtual void ShouldHandleBeforeScenarioFailure()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should handle BeforeScenario failure", new string[] {
                        "beforescenario",
                        "failed"});
#line 10
this.ScenarioSetup(scenarioInfo);
#line 11
 testRunner.Given("Step is \'passed\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
 testRunner.Given("Step is \'passed\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Should handle BeforeStep failure", new string[] {
                "beforestep",
                "failed"}, SourceLine=14)]
        public virtual void ShouldHandleBeforeStepFailure()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should handle BeforeStep failure", new string[] {
                        "beforestep",
                        "failed"});
#line 15
this.ScenarioSetup(scenarioInfo);
#line 16
 testRunner.Given("Step is \'passed\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
 testRunner.Given("Step is \'passed\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
 testRunner.Given("Step is \'passed\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Should handle AfterStep failure", new string[] {
                "afterstep",
                "failed"}, SourceLine=20)]
        public virtual void ShouldHandleAfterStepFailure()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should handle AfterStep failure", new string[] {
                        "afterstep",
                        "failed"});
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
 testRunner.Given("Step is \'passed\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
 testRunner.Given("Step is \'passed\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Should handle AfterScenario failure", new string[] {
                "afterscenario",
                "failed"}, SourceLine=25)]
        public virtual void ShouldHandleAfterScenarioFailure()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should handle AfterScenario failure", new string[] {
                        "afterscenario",
                        "failed"});
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
 testRunner.Given("Step is \'passed\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
 testRunner.Given("Step is \'passed\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion