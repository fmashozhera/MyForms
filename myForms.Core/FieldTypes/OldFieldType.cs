using System;
using System.Collections.Generic;

namespace MyForms.Domain.FieldTypes;

public record OldFieldType
{
    public static FieldType<T> Create<T>(T value)
    {
        return new FieldType<T>(value);
    }

    public static SingleSelectField<T> CreateSingleSelectField<T>(IEnumerable<T> optionsList)
    {
        return new SingleSelectField<T>(optionsList);
    }
}


