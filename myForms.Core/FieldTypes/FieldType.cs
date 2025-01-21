using MyForms.Domain.Constants;
using System;
using System.Linq;

namespace MyForms.Domain.FieldTypes;

public record FieldType<T> 
{
    public T Value;
    public FieldType(T value)
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
    => DomainConstants.SimpleDataTypes.Contains(t);

    public static FieldType<T> Create<T>(T value)
    {
        return new FieldType<T>(value);
    }
}

