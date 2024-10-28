using MyForms.Domain.FieldTypes;
using System;
using System.Collections.Generic;

public record SingleSelectField<T> : SelectField<T>
{
    public T SelectedValue { get; private set; }
    public SingleSelectField(IEnumerable<T> optionsList) : base(optionsList)
    {
    }
    public void SetSelectedValue(T value)
    {
        if (_optionsList.Contains(value))
        {
            SelectedValue = value;
        }
        else
        {
            throw new ArgumentException("Invalid selection. Select a value from the provided list.");
        }
    }
}

