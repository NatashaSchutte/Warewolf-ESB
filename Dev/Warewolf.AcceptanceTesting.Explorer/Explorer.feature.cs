﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Warewolf.AcceptanceTesting.Explorer
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ExplorerFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Explorer.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Explorer", "In order to manage my service\nAs a Warewolf User\nI want explorer view of my resou" +
                    "rces with management options", ProgrammingLanguage.CSharp, new string[] {
                        "Explorer"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Explorer")))
            {
                Warewolf.AcceptanceTesting.Explorer.ExplorerFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Connected to localhost server")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Explorer")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Explorer")]
        public virtual void ConnectedToLocalhostServer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Connected to localhost server", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("the explorer is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("I open \"localhost\" server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("I should see \"5\" folders", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Expand a folder")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Explorer")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Explorer")]
        public virtual void ExpandAFolder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Expand a folder", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line 13
 testRunner.Given("the explorer is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
 testRunner.And("I open \"localhost\" server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.When("I open \"Folder 2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("I should see \"18\" children for \"Folder 2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Rename folder")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Explorer")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Explorer")]
        public virtual void RenameFolder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Rename folder", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
 testRunner.Given("the explorer is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
 testRunner.And("I open \"localhost\" server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.When("I rename \"Folder 2\" to \"Folder New\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("I should see \"18\" children for \"Folder New\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.And("I should not see \"Folder 2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Search explorer")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Explorer")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Explorer")]
        public virtual void SearchExplorer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search explorer", ((string[])(null)));
#line 25
this.ScenarioSetup(scenarioInfo);
#line 26
 testRunner.Given("the explorer is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
 testRunner.And("I open \"localhost\" server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.When("I search for \"Folder 3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("I should see \"Folder 3\" only", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.And("I should not see \"Folder 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("I should not see \"Folder 2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("I should not see \"Folder 4\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("I should not see \"Folder 5\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion