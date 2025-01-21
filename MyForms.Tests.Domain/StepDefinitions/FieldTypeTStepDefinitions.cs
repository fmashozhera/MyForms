using MyForms.Domain.FieldTypes;
using NUnit.Framework;

namespace MyForms.Tests.Domain.StepDefinitions
{
    [Binding]
    public class FieldTypeTStepDefinitions
    {
        private Type? genericType;
        OldFieldType? constructedType;
        string? errorMessage;
        string? createdValue;
        
        string? genericTypeName;

        private static Dictionary<string, Type> allowedTypes = new()
        {
            ["System.Int32"] = typeof(int),
            ["System.Double"] = typeof(double),
            ["System.String"] = typeof(string),
            ["System.Boolean"] = typeof(bool),
            ["System.Byte[]"] = typeof(byte[]),
            ["System.DateTime"] = typeof(DateTime)
        };

        [Given("the generic type is {string}")]
        public void GivenTheGenericTypeIs(string genericTypeName)
        {
           this.genericTypeName = genericTypeName;
        }        

        private object ConvertToValue()
        {
            return genericTypeName switch
            {
                "System.Int32" => int.MaxValue,
                "System.Double" => Double.MaxValue,
                "System.String" => "Sample String",
                "System.Boolean" => false,
                "System.Byte[]" => new byte[1],
                "System.DateTime" => DateTime.Today,
                _ => new object()
            };
        }
             

        [Then("the value of the error message {string} is thrown")]
        public void ThenTheValueOfTheErrorMessageIsThrown(string errorMessage)
        {
            Assert.AreEqual(this.errorMessage, errorMessage);
        }

        [When("a field type is created of that type generic type")]
        public void WhenAFieldTypeIsCreatedOfThatTypeGenericType()
        {
            try
            {
                constructedType = FieldType.Create(ConvertToValue());
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
        }        

        [Then("the value of the field type must be of type {string}")]
        public void ThenTheValueOfTheFieldTypeMustBeOfType(string p0)
        {
            Assert.IsTrue(constructedType.ToString().Contains("Value"));
            Assert.IsTrue(constructedType.ToString().Contains(ConvertToValue().ToString()));
        }

    }
}
