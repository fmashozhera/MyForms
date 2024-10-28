Feature: TableField

Tests for the table field type. Test the following:
1. You can create a table field and the specified constructor arguments are properly assigned to the properties
2. You can successfully add a column to the table field
3. You cannot add more columns than the specified number of columns
4. You can successfuly create a row
5. you can successfuly add a table cell

@FieldTypes
Scenario: Create a table field header and footer
	Given The user wants to create a table field with header <header>
	And footer <footer>
	And number of columns <numberOfColumns>
	When they create the table
	Then its number of columns must equal <numberOfColumns>
	And its header must be <header>
	And its footer must be <footer>
Examples:
	| header         | footer         | numberOfColumns |
	| 'table header' | 'table footer' | 10              |

	
Scenario: Create a table field with no header
	Given The user wants to create a table field with no header
	And footer <footer>
	And number of columns <numberOfColumns>
	When they create the table
	Then its number of columns must equal <numberOfColumns>
	And its header must be <header>
	And its footer must be <footer>
Examples:
	| header | footer         | numberOfColumns |
	| ""     | 'table footer' | 10              |

Scenario: Create a table field with no footer
	Given The user wants to create a table field with no footer
	And header <header>
	And number of columns <numberOfColumns>
	When they create the table
	Then its number of columns must equal <numberOfColumns>
	And its header must be <header>
	And its footer must be <footer>
Examples:
	| header         | footer | numberOfColumns |
	| 'table header' | ""     | 10              |

Scenario: Create a table field with no footer and no header
	Given The user wants to create a table field with no footer and no header
	And number of columns <numberOfColumns>
	When they create the table
	Then its number of columns must equal <numberOfColumns>
	And its header must be <header>
	And its footer must be <footer>
Examples:
	| header         | footer | numberOfColumns |
	| "" | ""     | 10              |