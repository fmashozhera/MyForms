using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MyForms.Domain.FieldTypes;

public record SimpleFieldType<T> : FieldType 
{
    public T Value;
    public SimpleFieldType(T value)
    {
        if (IsSimpleDataType(value.GetType()))
        {
            Value = value;
        }
        else
        {
            throw new ArgumentException("The provided base field type is not allowed.");
        }
    }
    private bool IsSimpleDataType(Type t)
    => _simpleDataTypes.Contains(t);
}

