﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MyForms.Tests.Domain.Features
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SingleSelectFieldType")]
    public partial class SingleSelectFieldTypeFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "SingleSelectFieldType.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual async System.Threading.Tasks.Task FeatureSetupAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(null, NUnit.Framework.TestContext.CurrentContext.WorkerId);
            global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "SingleSelectFieldType", "The base functionality for single select field type.", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
            await testRunner.OnFeatureStartAsync(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
            await testRunner.OnFeatureEndAsync();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a valid single select field type")]
        [NUnit.Framework.CategoryAttribute("FieldTypes")]
        public async System.Threading.Tasks.Task CreateAValidSingleSelectFieldType()
        {
            string[] tagsOfScenario = new string[] {
                    "FieldTypes"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Create a valid single select field type", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                global::Reqnroll.Table table1 = new global::Reqnroll.Table(new string[] {
                            "options"});
                table1.AddRow(new string[] {
                            "Christian"});
                table1.AddRow(new string[] {
                            "Muslim"});
                table1.AddRow(new string[] {
                            "Bhudhist"});
                table1.AddRow(new string[] {
                            "Rasta"});
#line 7
 await testRunner.GivenAsync("The following options list for a string single select field", ((string)(null)), table1, "Given ");
#line hidden
#line 13
 await testRunner.WhenAsync("When a single select field type is created", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 14
 await testRunner.ThenAsync("The created field must have only the values in the options list", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Set a selected value")]
        [NUnit.Framework.TestCaseAttribute("Christian", null)]
        [NUnit.Framework.TestCaseAttribute("Muslim", null)]
        [NUnit.Framework.TestCaseAttribute("Bhudhist", null)]
        [NUnit.Framework.TestCaseAttribute("Rasta", null)]
        public async System.Threading.Tasks.Task SetASelectedValue(string selectedValue, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("selectedValue", selectedValue);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Set a selected value", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 16
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                global::Reqnroll.Table table2 = new global::Reqnroll.Table(new string[] {
                            "options"});
                table2.AddRow(new string[] {
                            "Christian"});
                table2.AddRow(new string[] {
                            "Muslim"});
                table2.AddRow(new string[] {
                            "Bhudhist"});
                table2.AddRow(new string[] {
                            "Rasta"});
#line 17
 await testRunner.GivenAsync("The following options list for a string single select field", ((string)(null)), table2, "Given ");
#line hidden
#line 23
 await testRunner.WhenAsync("When a single select field type is created", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 24
 await testRunner.AndAsync(string.Format("The selected value is set as \'{0}\'", selectedValue), ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 25
 await testRunner.ThenAsync(string.Format("The created field must have a selecected value of \'{0}\'", selectedValue), ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Set an invalid selected value")]
        [NUnit.Framework.TestCaseAttribute("Christian_", null)]
        [NUnit.Framework.TestCaseAttribute("Muslim_", null)]
        public async System.Threading.Tasks.Task SetAnInvalidSelectedValue(string selectedValue, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("selectedValue", selectedValue);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Set an invalid selected value", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 33
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                global::Reqnroll.Table table3 = new global::Reqnroll.Table(new string[] {
                            "options"});
                table3.AddRow(new string[] {
                            "Christian"});
                table3.AddRow(new string[] {
                            "Muslim"});
                table3.AddRow(new string[] {
                            "Bhudhist"});
                table3.AddRow(new string[] {
                            "Rasta"});
#line 34
 await testRunner.GivenAsync("The following options list for a string single select field", ((string)(null)), table3, "Given ");
#line hidden
#line 40
 await testRunner.WhenAsync("When a single select field type is created", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 41
 await testRunner.AndAsync(string.Format("The selected value is set as \'{0}\'", selectedValue), ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 42
 await testRunner.ThenAsync("Then an error must be thrown with message \'Invalid selection. Select a value from" +
                        " the provided list.\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
