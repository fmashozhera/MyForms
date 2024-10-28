using System;
using System.Collections.Generic;
using System.Text;

namespace MyForms.Domain;

public class MultiSelectFieldInstance : FieldInstance
{
    public ICollection<MultiSelectValueInstance> Values { get; set; }
}
