using System;
using System.Collections.Generic;

namespace MyForms.Domain.FieldTypes;

public record FieldType
{
    protected static Type[] _simpleDataTypes =
    {
        typeof(int),
        typeof(double),
        typeof(string),
        typeof(bool),
        typeof(DateTime),
        typeof(byte[])
    };

    public static SimpleFieldType<T> Create<T>(T value)
    {
        return new SimpleFieldType<T>(value);
    }

    public static SingleSelectField<T> CreateSingleSelectField<T>(IEnumerable<T> optionsList)
    {
        return new SingleSelectField<T>(optionsList);
    }
}


