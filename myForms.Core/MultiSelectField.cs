using System.Collections.Generic;

namespace MyForms.Domain;

public class MultiSelectField : Field
{
    public ICollection<MultiSelectValue> Values { get; set; }
    public bool AllowMultipleValues { get; set; }

}
