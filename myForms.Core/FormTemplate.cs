using System;
using System.Collections.Generic;
using System.Text;

namespace MyForms.Domain;

public class FormTemplate
{
    public string Name { get; set; }
    public int Id { get; set; }
    public ICollection<FormSection> FormSections { get; set; }
    public ICollection<FormInstance> FormInstances { get; set; }
}
