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
namespace SignUp.EndToEndTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Prospect Sign Up")]
    public partial class ProspectSignUpFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ProspectSignUp.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Prospect Sign Up", "\tAs a prospect interested in the product launch\r\n\tI want to sign up for notificat" +
                    "ions\r\n\tSo that I can be updated with news", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sign Up with Valid Details")]
        [NUnit.Framework.TestCaseAttribute("Prospect", "A", "a.prospect@company.com", "Company, Inc.", "United States", "Decision Maker", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "B", "b.prospect@company.com", "Company, Inc.", "United Kingdom", "Decision Maker", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "C", "c.prospect@company.com", "Company, Inc.", "United States", "Architect", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "D", "d.prospect@company.com", "Company, Inc.", "United Kingdom", "IT Ops", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "E", "e.prospect@company.com", "Company, Inc.", "United States", "Architect", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "F", "f.prospect@other.com", "Other, Inc.", "Sweden", "Decision Maker", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "G", "g.prospect@company.com", "Company, Inc.", "United States", "Engineer", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "H", "h.prospect@company.com", "Company, Inc.", "United States", "Architect", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "I", "i.prospect@company.com", "Company, Inc.", "United Kingdom", "Decision Maker", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "J", "j.prospect@company.com", "Company, Inc.", "United States", "Architect", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "K", "k.prospect@other.com", "Other, Inc.", "Sweden", "Decision Maker", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "L", "l.prospect@company.com", "Company, Inc.", "United Kingdom", "Decision Maker", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "M", "m.prospect@company.com", "Company, Inc.", "Sweden", "Architect", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "N", "n.prospect@company.com", "Company, Inc.", "United Kingdom", "Decision Maker", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "O", "o.prospect@company.com", "Company, Inc.", "United States", "Architect", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "P", "p.prospect@other.com", "Other, Inc.", "Sweden", "Decision Maker", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "Q", "q.prospect@other.com", "Other, Inc.", "Sweden", "Decision Maker", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "R", "r.prospect@company.com", "Company, Inc.", "United Kingdom", "IT Ops", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "S", "s.prospect@company.com", "Company, Inc.", "United States", "Architect", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "T", "t.prospect@company.com", "Company, Inc.", "United Kingdom", "Decision Maker", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "U", "u.prospect@company.com", "Company, Inc.", "United States", "Architect", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "V", "v.prospect@other.com", "Other, Inc.", "Sweden", "Decision Maker", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "W", "w.prospect@company.com", "Company, Inc.", "United States", "Architect", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "X", "x.prospect@company.com", "Company, Inc.", "United Kingdom", "Decision Maker", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "Y", "y.prospect@company.com", "Company, Inc.", "United States", "Architect", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Prospect", "Z", "z.prospect@other.com", "Other, Inc.", "Sweden", "Decision Maker", new string[0])]
        public virtual void SignUpWithValidDetails(string firstName, string lastName, string emailAddress, string companyName, string country, string role, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sign Up with Valid Details", exampleTags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("I browse to the Sign Up Page at \"http://signup-app/SignUp\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And(string.Format("I enter details \'{0}\' \'{1}\' \'{2}\' \'{3}\' \'{4}\' \'{5}\'", firstName, lastName, emailAddress, companyName, country, role), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.When("I press Go", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("I should see the Thank You page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
 testRunner.And("my details should be saved", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
