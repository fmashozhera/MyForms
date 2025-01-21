using System;
using System.Collections.Generic;
using System.Linq;

namespace MyForms.Domain.FieldTypes;

public record SelectField<T> : OldFieldType
{ 
    protected ICollection<T> _optionsList;
    public IEnumerable<T> OptionsList { get => _optionsList.ToList(); }
    internal SelectField(IEnumerable<T> optionsList)
    {
        InitialiseOptionsList(optionsList);
    }
    private void InitialiseOptionsList(IEnumerable<T> optionsListValues)
    {
        _optionsList = new HashSet<T>();
        foreach (var option in optionsListValues)
        {
            _optionsList.Add(option);
        }
    }    
}