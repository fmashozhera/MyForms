using MyForms.Domain.FieldTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyForms.Domain;

public class FormSection
{
    public string Name { get; set; }
    public int Index { get; set; }
    public Guid FormId { get; set; }
    public ICollection<TextField> Fields { get; set; }
}
