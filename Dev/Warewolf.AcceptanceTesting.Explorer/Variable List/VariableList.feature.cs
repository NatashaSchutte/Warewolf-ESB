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
namespace Warewolf.AcceptanceTesting.Explorer.VariableList
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class VariableListFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "VariableList.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "VariableList", "In order to manage my variables\r\nAs a Warewolf user\r\nI want to be told shown all " +
                    "variables in my workflow service", ProgrammingLanguage.CSharp, new string[] {
                        "VariableList"});
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "VariableList")))
            {
                Warewolf.AcceptanceTesting.Explorer.VariableList.VariableListFeature.FeatureSetup(null);
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Variables adding in variable list")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "VariableList")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("VariableList")]
        public virtual void VariablesAddingInVariableList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Variables adding in variable list", ((string[])(null)));
#line 32
this.ScenarioSetup(scenarioInfo);
#line 33
 testRunner.Given("I open workflow \"VariableTest1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable",
                        "Note",
                        "Inputs",
                        "Outputs",
                        "Unassigned"});
            table1.AddRow(new string[] {
                        "[[rec().a]]",
                        "This is recordset",
                        "",
                        "",
                        ""});
            table1.AddRow(new string[] {
                        "[[rec().a]]",
                        "This is recordset",
                        "",
                        "",
                        ""});
            table1.AddRow(new string[] {
                        "[[mr().a]]",
                        "",
                        "",
                        "",
                        ""});
            table1.AddRow(new string[] {
                        "[[mr().a]]",
                        "",
                        "",
                        "",
                        ""});
            table1.AddRow(new string[] {
                        "[[Var]]",
                        "",
                        "",
                        "",
                        ""});
            table1.AddRow(new string[] {
                        "[[a]]",
                        "",
                        "",
                        "",
                        "Yes"});
            table1.AddRow(new string[] {
                        "[[lr().a]]",
                        "",
                        "",
                        "",
                        "Yes"});
#line 34
 testRunner.And("workflow \"VariableTest1\" contains", ((string)(null)), table1, "And ");
#line 43
 testRunner.Then("Variables box is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
 testRunner.And("variables filter box is \"Visible\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.And("Filter Clear button is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("Delete  unassigned variables button is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.And("Sort variables order button is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Delete Visible",
                        "Note Visible",
                        "Note Highlighted",
                        "Input",
                        "Output"});
            table2.AddRow(new string[] {
                        "Var",
                        "NO",
                        "Yes",
                        "No",
                        "",
                        ""});
            table2.AddRow(new string[] {
                        "",
                        "NO",
                        "NO",
                        "NO",
                        "",
                        ""});
#line 48
 testRunner.And("the Variables Names look like", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Recordset Name",
                        "Delete Visible",
                        "Note Visible",
                        "Note Highlighted",
                        "Input",
                        "Output"});
            table3.AddRow(new string[] {
                        "rec()",
                        "NO",
                        "Yes",
                        "Yes",
                        "",
                        ""});
            table3.AddRow(new string[] {
                        "rec().a",
                        "NO",
                        "Yes",
                        "Yes",
                        "",
                        ""});
            table3.AddRow(new string[] {
                        "mr()",
                        "NO",
                        "Yes",
                        "",
                        "",
                        ""});
            table3.AddRow(new string[] {
                        "mr().a",
                        "NO",
                        "Yes",
                        "",
                        "",
                        ""});
            table3.AddRow(new string[] {
                        "",
                        "No",
                        "No",
                        "",
                        "",
                        ""});
#line 52
 testRunner.And("the Recordset Name look like", ((string)(null)), table3, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deleting Unassigned Variables on variable list")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "VariableList")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("VariableList")]
        public virtual void DeletingUnassignedVariablesOnVariableList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deleting Unassigned Variables on variable list", ((string[])(null)));
#line 62
this.ScenarioSetup(scenarioInfo);
#line 63
 testRunner.Given("I open workflow \"VariableTest2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable",
                        "Note",
                        "Inputs",
                        "Outputs",
                        "Unassigned"});
            table4.AddRow(new string[] {
                        "[[rec().a]]",
                        "This is recordset",
                        "",
                        "",
                        ""});
            table4.AddRow(new string[] {
                        "[[rec().a]]",
                        "This is recordset",
                        "",
                        "",
                        ""});
            table4.AddRow(new string[] {
                        "[[mr().a]]",
                        "",
                        "",
                        "",
                        ""});
            table4.AddRow(new string[] {
                        "[[mr().a]]",
                        "",
                        "",
                        "",
                        ""});
            table4.AddRow(new string[] {
                        "[[Var]]",
                        "",
                        "",
                        "",
                        ""});
            table4.AddRow(new string[] {
                        "[[a]]",
                        "",
                        "",
                        "",
                        "Yes"});
            table4.AddRow(new string[] {
                        "[[lr().a]]",
                        "",
                        "",
                        "",
                        "Yes"});
#line 64
 testRunner.And("\"VariableTest\" variable contains", ((string)(null)), table4, "And ");
#line 73
 testRunner.Then("Variables box is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 74
 testRunner.And("variables filter box is \"Visible\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.And("Filter Clear button is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.And("Delete  unassigned variables button is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.And("Sort variables order button is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Delete Visible",
                        "Note Visible",
                        "Note Highlighted",
                        "Input",
                        "Output"});
            table5.AddRow(new string[] {
                        "Var",
                        "NO",
                        "Yes",
                        "No",
                        "",
                        ""});
            table5.AddRow(new string[] {
                        "[[a]]",
                        "Yes",
                        "NO",
                        "NO",
                        "",
                        ""});
#line 78
 testRunner.And("the Variables Names look like", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Recordset Name",
                        "Delete Visible",
                        "Note Visible",
                        "Note Highlighted",
                        "Input",
                        "Output"});
            table6.AddRow(new string[] {
                        "rec()",
                        "NO",
                        "Yes",
                        "Yes",
                        "",
                        ""});
            table6.AddRow(new string[] {
                        "rec().a",
                        "NO",
                        "Yes",
                        "Yes",
                        "",
                        ""});
            table6.AddRow(new string[] {
                        "mr()",
                        "NO",
                        "Yes",
                        "No",
                        "",
                        ""});
            table6.AddRow(new string[] {
                        "mr().a",
                        "NO",
                        "Yes",
                        "No",
                        "",
                        ""});
            table6.AddRow(new string[] {
                        "[[lr().a]]",
                        "Yes",
                        "NO",
                        "No",
                        "",
                        ""});
#line 82
 testRunner.And("the Recordset Name look like", ((string)(null)), table6, "And ");
#line 89
 testRunner.When("I delete unassigned variables", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Delete Visible",
                        "Note Visible",
                        "Note Highlighted",
                        "Input",
                        "Output"});
            table7.AddRow(new string[] {
                        "Var",
                        "Yes",
                        "Yes",
                        "No",
                        "",
                        ""});
#line 90
 testRunner.Then("the Variable Names look like", ((string)(null)), table7, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Recordset Name",
                        "Delete Visible",
                        "Note Visible",
                        "Note Highlighted",
                        "Input",
                        "Output"});
            table8.AddRow(new string[] {
                        "rec()",
                        "Yes",
                        "Yes",
                        "No",
                        "",
                        ""});
            table8.AddRow(new string[] {
                        "rec().a",
                        "Yes",
                        "Yes",
                        "Yes",
                        "",
                        ""});
            table8.AddRow(new string[] {
                        "mr()",
                        "Yes",
                        "Yes",
                        "No",
                        "",
                        ""});
            table8.AddRow(new string[] {
                        "mr().a",
                        "Yes",
                        "Yes",
                        "No",
                        "",
                        ""});
#line 93
 testRunner.And("the Recordset Name look like", ((string)(null)), table8, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Searching Variables in Variable list")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "VariableList")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("VariableList")]
        public virtual void SearchingVariablesInVariableList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Searching Variables in Variable list", ((string[])(null)));
#line 102
this.ScenarioSetup(scenarioInfo);
#line 103
 testRunner.Given("I open workflow \"VariableTest1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable",
                        "Note",
                        "Inputs",
                        "Outputs",
                        "Unassigned"});
            table9.AddRow(new string[] {
                        "[[rec().a]]",
                        "This is recordset",
                        "",
                        "",
                        ""});
            table9.AddRow(new string[] {
                        "[[rec().a]]",
                        "This is recordset",
                        "",
                        "",
                        ""});
            table9.AddRow(new string[] {
                        "[[mr().a]]",
                        "",
                        "",
                        "",
                        ""});
            table9.AddRow(new string[] {
                        "[[mr().a]]",
                        "",
                        "",
                        "",
                        ""});
            table9.AddRow(new string[] {
                        "[[Var]]",
                        "",
                        "",
                        "",
                        ""});
            table9.AddRow(new string[] {
                        "[[a]]",
                        "",
                        "",
                        "",
                        "Yes"});
            table9.AddRow(new string[] {
                        "[[lr().a]]",
                        "",
                        "",
                        "",
                        "Yes"});
#line 104
 testRunner.And("\"VariableTest\" variable contains", ((string)(null)), table9, "And ");
#line 113
 testRunner.Then("Variables box is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 114
 testRunner.And("variables filter box is \"Visible\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
 testRunner.And("Filter Clear button is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
 testRunner.And("Delete  unassigned variables button is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.And("Sort variables order button is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
 testRunner.When("I search for variable \"[[mr().a]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Delete Visible",
                        "Note Visible",
                        "Note Highlighted",
                        "Input",
                        "Output"});
#line 119
 testRunner.Then("the Variables Names look like", ((string)(null)), table10, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Recordset Name",
                        "Delete Visible",
                        "Note Visible",
                        "Note Highlighted",
                        "Input",
                        "Output"});
            table11.AddRow(new string[] {
                        "mr()",
                        "Yes",
                        "Yes",
                        "No",
                        "",
                        ""});
            table11.AddRow(new string[] {
                        "mr().a",
                        "Yes",
                        "Yes",
                        "No",
                        "",
                        ""});
#line 121
 testRunner.And("the Recordset Name look like", ((string)(null)), table11, "And ");
#line 125
 testRunner.When("I clear the filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Delete Visible",
                        "Note Visible",
                        "Note Highlighted",
                        "Input",
                        "Output"});
            table12.AddRow(new string[] {
                        "Var",
                        "Yes",
                        "Yes",
                        "No",
                        "",
                        ""});
            table12.AddRow(new string[] {
                        "[[a]]",
                        "NO",
                        "NO",
                        "NO",
                        "Not Visible",
                        "Not Visible"});
#line 126
 testRunner.Then("the Variables Names look like", ((string)(null)), table12, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Recordset Name",
                        "Delete Visible",
                        "Note Visible",
                        "Note Highlighted",
                        "Input",
                        "Output"});
            table13.AddRow(new string[] {
                        "rec()",
                        "Yes",
                        "Yes",
                        "No",
                        "",
                        ""});
            table13.AddRow(new string[] {
                        "rec().a",
                        "Yes",
                        "Yes",
                        "Yes",
                        "",
                        ""});
            table13.AddRow(new string[] {
                        "mr()",
                        "Yes",
                        "Yes",
                        "No",
                        "",
                        ""});
            table13.AddRow(new string[] {
                        "mr().a",
                        "Yes",
                        "Yes",
                        "No",
                        "",
                        ""});
            table13.AddRow(new string[] {
                        "[[lr().a]]",
                        "Yes",
                        "No",
                        "No",
                        "Not Visible",
                        "Not Visible"});
#line 130
 testRunner.And("the Recordset Name look like", ((string)(null)), table13, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Sorting Variables in Variable list")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "VariableList")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("VariableList")]
        public virtual void SortingVariablesInVariableList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sorting Variables in Variable list", ((string[])(null)));
#line 140
this.ScenarioSetup(scenarioInfo);
#line 141
 testRunner.Given("I open workflow \"VariableTest1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable",
                        "Note",
                        "Inputs",
                        "Outputs",
                        "Unassigned"});
            table14.AddRow(new string[] {
                        "[[rec().a]]",
                        "This is recordset",
                        "",
                        "",
                        ""});
            table14.AddRow(new string[] {
                        "[[rec().a]]",
                        "This is recordset",
                        "",
                        "",
                        ""});
            table14.AddRow(new string[] {
                        "[[mr().a]]",
                        "",
                        "",
                        "",
                        ""});
            table14.AddRow(new string[] {
                        "[[mr().a]]",
                        "",
                        "",
                        "",
                        ""});
            table14.AddRow(new string[] {
                        "[[Var]]",
                        "",
                        "",
                        "",
                        ""});
            table14.AddRow(new string[] {
                        "[[a]]",
                        "",
                        "",
                        "",
                        "Yes"});
            table14.AddRow(new string[] {
                        "[[lr().a]]",
                        "",
                        "",
                        "",
                        "Yes"});
#line 142
 testRunner.And("\"VariableTest\" variable contains", ((string)(null)), table14, "And ");
#line 151
 testRunner.Then("Variables box is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 152
 testRunner.And("variables filter box is \"Visible\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 153
 testRunner.And("Filter Clear button is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 154
 testRunner.And("Delete  unassigned variables button is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 155
 testRunner.And("Sort variables order button is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 156
 testRunner.When("I Sort the variables", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Delete Visible",
                        "Note Visible",
                        "Note Highlighted",
                        "Input",
                        "Output"});
            table15.AddRow(new string[] {
                        "[[a]]",
                        "NO",
                        "NO",
                        "NO",
                        "Not Visible",
                        "Not Visible"});
            table15.AddRow(new string[] {
                        "Var",
                        "Yes",
                        "Yes",
                        "No",
                        "",
                        ""});
#line 157
 testRunner.Then("the Variables Names look like", ((string)(null)), table15, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Recordset Name",
                        "Delete Visible",
                        "Note Visible",
                        "Note Highlighted",
                        "Input",
                        "Output"});
            table16.AddRow(new string[] {
                        "[[lr().a]]",
                        "Yes",
                        "No",
                        "No",
                        "Not Visible",
                        "Not Visible"});
            table16.AddRow(new string[] {
                        "mr()",
                        "Yes",
                        "Yes",
                        "No",
                        "",
                        ""});
            table16.AddRow(new string[] {
                        "mr().a",
                        "Yes",
                        "Yes",
                        "No",
                        "",
                        ""});
            table16.AddRow(new string[] {
                        "rec()",
                        "Yes",
                        "Yes",
                        "No",
                        "",
                        ""});
            table16.AddRow(new string[] {
                        "rec().a",
                        "Yes",
                        "Yes",
                        "Yes",
                        "",
                        ""});
#line 161
 testRunner.And("the Recordset Name look like", ((string)(null)), table16, "And ");
#line 168
 testRunner.When("I Sort the variables", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Delete Visible",
                        "Note Visible",
                        "Note Highlighted",
                        "Input",
                        "Output"});
            table17.AddRow(new string[] {
                        "Var",
                        "Yes",
                        "Yes",
                        "No",
                        "",
                        ""});
            table17.AddRow(new string[] {
                        "[[a]]",
                        "NO",
                        "NO",
                        "NO",
                        "Not Visible",
                        "Not Visible"});
#line 169
 testRunner.Then("the Variables Names look like", ((string)(null)), table17, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Recordset Name",
                        "Delete Visible",
                        "Note Visible",
                        "Note Highlighted",
                        "Input",
                        "Output"});
            table18.AddRow(new string[] {
                        "rec()",
                        "Yes",
                        "Yes",
                        "No",
                        "",
                        ""});
            table18.AddRow(new string[] {
                        "rec().a",
                        "Yes",
                        "Yes",
                        "Yes",
                        "",
                        ""});
            table18.AddRow(new string[] {
                        "mr()",
                        "Yes",
                        "Yes",
                        "No",
                        "",
                        ""});
            table18.AddRow(new string[] {
                        "mr().a",
                        "Yes",
                        "Yes",
                        "No",
                        "",
                        ""});
            table18.AddRow(new string[] {
                        "[[lr().a]]",
                        "Yes",
                        "No",
                        "No",
                        "Not Visible",
                        "Not Visible"});
#line 173
 testRunner.And("the Recordset Name look like", ((string)(null)), table18, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Variablebox is enabled for design surface")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "VariableList")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("VariableList")]
        public virtual void VariableboxIsEnabledForDesignSurface()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Variablebox is enabled for design surface", ((string[])(null)));
#line 183
this.ScenarioSetup(scenarioInfo);
#line 184
 testRunner.Given("I have \"New Workflow Service\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 185
 testRunner.Then("Variables box is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Variablebox is Disabled for Server Source")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "VariableList")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("VariableList")]
        public virtual void VariableboxIsDisabledForServerSource()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Variablebox is Disabled for Server Source", ((string[])(null)));
#line 187
this.ScenarioSetup(scenarioInfo);
#line 188
 testRunner.Given("I have \"Server Source\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 189
 testRunner.Then("Variables box is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Variablebox is Disabled for Database Service")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "VariableList")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("VariableList")]
        public virtual void VariableboxIsDisabledForDatabaseService()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Variablebox is Disabled for Database Service", ((string[])(null)));
#line 191
this.ScenarioSetup(scenarioInfo);
#line 192
 testRunner.Given("I have \"Database Service\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 193
 testRunner.Then("Variables box is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Variablebox is Disabled for Database Source")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "VariableList")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("VariableList")]
        public virtual void VariableboxIsDisabledForDatabaseSource()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Variablebox is Disabled for Database Source", ((string[])(null)));
#line 195
this.ScenarioSetup(scenarioInfo);
#line 196
 testRunner.Given("I have \"Database Source\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 197
 testRunner.Then("Variables box is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Variablebox is Disabled for New Plugin Service")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "VariableList")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("VariableList")]
        public virtual void VariableboxIsDisabledForNewPluginService()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Variablebox is Disabled for New Plugin Service", ((string[])(null)));
#line 200
this.ScenarioSetup(scenarioInfo);
#line 201
 testRunner.Given("I have \"New Plugin Service\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 202
 testRunner.Then("Variables box is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
