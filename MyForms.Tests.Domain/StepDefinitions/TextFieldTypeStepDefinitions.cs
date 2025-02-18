using System;
using MyForms.Domain.FieldTypes;
using NUnit.Framework;
using Reqnroll;

namespace MyForms.Tests.Domain.StepDefinitions
{
    [Binding]
    public class TextFieldTypeStepDefinitions
    {
        private int index;
        private string label;
        private TextField textField;

        [Given("the index is {int}")]
        public void GivenTheIndexIs(int index)
        {
            this.index = index;
        }

        [Given("the label is {string}")]
        public void GivenTheLabelIs(string label)
        {
            this.label = label;
        }

        [When("the TextField.Create method is call with these arguments")]
        public void WhenTheTextField_CreateMethodIsCallWithTheseArguments()
        {
            var result = TextField.Create(label, index);
            if(result.IsSuccess) { textField = result.Value; }
        }


        [Then("a Text field should be created with  {int}, {string},  {int},  {int},  {string}, {string}")]
        public void ThenATextFieldShouldBeCreatedWith(int index, string label, int minimumLength, int maximumLength, string @false, string validationRegex)
        {
            Assert.AreEqual(index, textField.Index);
            Assert.AreEqual(label, textField.Label);
            Assert.AreEqual(minimumLength, textField.MinimumLength);
            Assert.AreEqual(maximumLength, textField.MaximumLength);
            Assert.AreEqual(bool.Parse(@false), textField.IsRequired);
            Assert.AreEqual(validationRegex, textField.ValidationRegex);
        }



    }
}
