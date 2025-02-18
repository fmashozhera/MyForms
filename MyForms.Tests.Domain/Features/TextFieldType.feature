Feature: TextFieldType

Simple text input fields

@FieldTypes
Scenario: Create a TextField by providing minimum required information.
	Given the index is <index>
	And the label is <label>
	When the TextField.Create method is called with these arguments
	Then a Text field should be created with  <index>, <label>,  minimumLenth>,  <maximumLength>,  <isRequired>, <validationRegex>
Examples:
	| index | label              | minimumLenth | maximumLength | isRequired | validationRegex |
	| 1     | "Text Field Label" | 1            | 2147483647    | true      | ""              |
	


	