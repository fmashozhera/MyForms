using System;
using System.Collections.Generic;

namespace MyForms.Domain.FieldTypes;

public record MultiSelectField<T> : SelectField<T>
{
    private ICollection<T> _selectedValues = new HashSet<T>();
    public IEnumerable<T> SelectedValues { get => _selectedValues; }
    public MultiSelectField(IEnumerable<T> optionsList) : base(optionsList)
    {
    }
    public void AddSelectedValue(T value)
    {
        if (_optionsList.Contains(value))
        {
            _selectedValues.Add(value);
        }
        else
        {
            throw new ArgumentException("Invalid selection.");
        }
    }
}

