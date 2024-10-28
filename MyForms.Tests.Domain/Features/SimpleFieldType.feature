Feature: FieldType<T>

The most basic form field type. All other field types are built from it.

@FieldTypes
Scenario: Create a FieldType
	Given the generic type is <genericType>
	When a field type is created of that type generic type
	Then the value of the field type must be of type <genericType>
Examples:
	| genericType       |
	| "System.Int32"    |			
	| "System.Double"   |
	| "System.String"   |
	| "System.Boolean"  |
	| "System.DateTime" |
	| "System.Byte[]"   |

Scenario: Create a FieldType with an unpermitted primitive type
	Given the generic type is <genericType>
	When a field type is created of that type generic type
	Then the value of the error message 'The provided base field type is not allowed.' is thrown
Examples:
	| genericType   |
	| "System.Char" |
	