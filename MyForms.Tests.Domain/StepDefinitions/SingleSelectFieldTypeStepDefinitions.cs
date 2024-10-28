using MyForms.Domain.FieldTypes;
using NUnit.Framework;

namespace MyForms.Tests.Domain.StepDefinitions
{
    [Binding]
    public class SingleSelectFieldTypeStepDefinitions
    {
        private SingleSelectField<string> _singleSelectField;
        private ICollection<string> _optionsList;
        private string _errorMessage;

        [Given("The following options list for a string single select field")]
        public void GivenTheFollowingOptionsListForAStringSingleSelectField(DataTable dataTable)
        {
            _optionsList = new List<string>();
            foreach (var row in dataTable.Rows)
            {
                var r1 = row[0];
                _optionsList.Add(row[0]);
            }
        }

        [When("When a single select field type is created")]
        public void WhenWhenASingleSelectFieldTypeIsCreated()
        {
            _singleSelectField = FieldType.CreateSingleSelectField(_optionsList);
        }

        [Then("The created field must have only the values in the options list")]
        public void ThenTheCreatedFieldMustHaveOnlyTheValuesInTheOptionsList()
        {
            Assert.IsTrue(_singleSelectField.OptionsList.SequenceEqual(_optionsList));
        }

        [When("The selected value is set as {string}")]
        public void WhenTheSelectedValueIsSetAs(string selectedValue)
        {
            try
            {
                _singleSelectField.SetSelectedValue(selectedValue);
            }
            catch (Exception ex)
            {
                _errorMessage = ex.Message;                
            }
            
        }

        [Then("The created field must have a selecected value of {string}")]
        public void ThenTheCreatedFieldMustHaveASelecectedValueOf(string selectedValue)
        {
            Assert.AreEqual(selectedValue, _singleSelectField.SelectedValue);
        }

        [Then("Then an error must be thrown with message {string}")]
        public void ThenThenAnErrorMustBeThrownWithMessage(string errorMessage)
        {
            Assert.AreEqual(errorMessage, _errorMessage);
        }



    }
}
