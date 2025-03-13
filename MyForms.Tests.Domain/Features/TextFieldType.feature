Feature: TextFieldType

Simple text input fields

@FieldTypes
Scenario: Create a TextField by providing minimum required information.
	Given the index is <index>
	And the label is <label>
	When the TextField Create method is called with these arguments
	Then a Text field should be created with  <index>, <label>,  <minimumLenth>,  <maximumLength>, <isRequired> , <validationRegex>
Examples:
	| index | label              | minimumLenth | maximumLength | isRequired | validationRegex |
	| 1     | "Text Field Label" | 1            | 2147483647    | "false"    | ""              |
	

@FieldTypes
Scenario: Create a TextField by providing all information.
	Given the index is <index>
	And the label is <label>
	When the TextField Create method is called with arguments additional argunments <minimumLenth>,  <maximumLength>, <isRequired> , <validationRegex>

	Then a Text field should be created with  <index>, <label>,  <minimumLenth>,  <maximumLength>, <isRequired> , <validationRegex>
Examples:
	| index | label              | minimumLenth | maximumLength | isRequired | validationRegex |
	| 1     | "Text Field Label" | 1            | 2147483647    | "false"    | ""              |
	| 1     | "Label"            | 10           | 20            | "true"     | "76y6e9i"       |

@FieldTypes
Scenario: Create a TextField by providing invalid information.
	Given the index is <index>
	And the label is <label>
	When the TextField Create method is called with these arguments
	Then an error message must be returned with message <errorMessage>
Examples:
	| index | label              | errorMessage                                     |
	| -1    | "Text Field Label" | "Field index cannot be less than 1" |
	| 1     | ""                 | "Field label is required"                        |