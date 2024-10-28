using System;
using System.Collections.Generic;
using System.Text;

namespace MyForms.Domain;

public class ListFieldInstance : FieldInstance
{
    public ICollection<ListFieldValueInstance> Values { get; set; }
}
