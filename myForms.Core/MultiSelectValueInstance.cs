using System;
using System.Collections.Generic;
using System.Text;

namespace MyForms.Domain;

public class MultiSelectValueInstance
{
    public Guid Id { get; set; }
    public string Value { get; set; }
    public bool  Selected { get; set; }
    public Guid FieldInstanceId { get; set; }
    public MultiSelectFieldInstance FieldInstance { get; set; }
}
