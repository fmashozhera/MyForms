using System;

namespace MyForms.Domain.FieldTypes;
internal record TextFieldType : FieldType<String>
{
    protected TextFieldType(string original) : base(original)
    {
    }
}
