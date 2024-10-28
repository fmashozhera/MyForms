Feature: SingleSelectFieldType

The base functionality for single select field type.

@FieldTypes
Scenario: Create a valid single select field type
	Given The following options list for a string single select field
		| options   |
		| Christian |
		| Muslim    |
		| Bhudhist  |
		| Rasta     |
	When When a single select field type is created
	Then The created field must have only the values in the options list

Scenario: Set a selected value
	Given The following options list for a string single select field
		| options   |
		| Christian |
		| Muslim    |
		| Bhudhist  |
		| Rasta     |
	When When a single select field type is created
	And The selected value is set as '<selectedValue>'
	Then The created field must have a selecected value of '<selectedValue>'
Examples:
	|selectedValue|
	| Christian |
	| Muslim    |
	| Bhudhist  |
	| Rasta     |

Scenario: Set an invalid selected value
	Given The following options list for a string single select field
		| options   |
		| Christian |
		| Muslim    |
		| Bhudhist  |
		| Rasta     |
	When When a single select field type is created
	And The selected value is set as '<selectedValue>'
	Then Then an error must be thrown with message 'Invalid selection. Select a value from the provided list.'
Examples:
	|selectedValue|
	| Christian_ |
	| Muslim_    |
	


