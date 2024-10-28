using System;
using System.Collections.Generic;

namespace MyForms.Domain;

public class ListField : Field
{
    public ICollection<ListFieldValue> Values { get; set; }
}
