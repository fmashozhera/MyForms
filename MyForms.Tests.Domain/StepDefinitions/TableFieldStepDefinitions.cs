using MyForms.Domain.FieldTypes;
using NUnit.Framework;

namespace MyForms.Tests.Domain.StepDefinitions
{
    [Binding]
    public class TableFieldStepDefinitions
    {
        private string? _header;
        private string? _footer;
        int _numberOfColumns;
        private TableField? _tableField;

        [Given("The user wants to create a table field with header {string}, footer {string} and number of columns {int}")]
        public void GivenTheUserWantsToCreateATableFieldWithHeaderFooterAndNumberOfColumns(string header, string footer, int numberOfColumns)
        {
            _header = header;
            _footer = footer;
            _numberOfColumns = numberOfColumns;
        }

        [When("they create the table")]
        public void WhenTheyCreateTheTable()
        {
            if(!String.IsNullOrEmpty(_header) && !String.IsNullOrEmpty(_footer))
            {
                _tableField = new TableField(_numberOfColumns, _header, _footer);
            }
            else if(!String.IsNullOrEmpty(_header) && String.IsNullOrEmpty(_footer))
            {
                _tableField = new TableField(_numberOfColumns, header:_header);
            }
            else if (String.IsNullOrEmpty(_header) && !String.IsNullOrEmpty(_footer))
            {
                _tableField = new TableField(_numberOfColumns, footer:_footer);
            } 
            else if(String.IsNullOrEmpty(_header) && String.IsNullOrEmpty(_footer))
            {
                _tableField = new TableField(_numberOfColumns);
            }
        }

        [Given("The user wants to create a table field with no header")]
        public void GivenTheUserWantsToCreateATableFieldWithNoHeader()
        {
            _header = string.Empty;
        }

        [Given("The user wants to create a table field with no footer")]
        public void GivenTheUserWantsToCreateATableFieldWithNoFooter()
        {
            _footer = string.Empty;
        }

        [Given("The user wants to create a table field with no footer and no header")]
        public void GivenTheUserWantsToCreateATableFieldWithNoFooterAndNoHeader()
        {
            _header = string.Empty;
            _footer = string.Empty;
        }

        [Given("header {string}")]
        public void GivenHeader(string header)
        {
            _header = header;
        }

        [Given("footer {string}")]
        public void GivenFooter(string footer)
        {
            _footer = footer;
        }

        [Given("number of columns {int}")]
        public void GivenNumberOfColumns(int numberOfColumns)
        {
            _numberOfColumns = numberOfColumns;
        }


        [Then("its number of columns must equal {int}")]
        public void ThenItsNumberOfColumnsMustEqual(int numberOfColumns)
        {
            Assert.AreEqual(numberOfColumns, _tableField.NumberOfColumns);
        }

        [Then("its header must be {string}")]
        public void ThenItsHeaderMustBe(string tableHeader)
        {
            Assert.AreEqual(_header, _tableField.Header);
        }

        [Then("its footer must be {string}")]
        public void ThenItsFooterMustBe(string p0)
        {
            Assert.AreEqual(_footer, _tableField.Footer);
        }

        [Then("its header must be ")]
        public void ThenItsHeaderMustBe()
        {
            Assert.IsNull(_tableField.Header);
        }

        [Then("its footer must be ")]
        public void ThenItsFooterMustBe()
        {
            Assert.IsNull(_tableField.Footer);
        }

        [Given("The user wants to create a table field with header {string}")]
        public void GivenTheUserWantsToCreateATableFieldWithHeader(string header)
        {
            _header = header;
        }


    }
}
