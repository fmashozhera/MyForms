using System;
using System.Collections.Generic;
using System.Text;

namespace MyForms.Domain;

public class FormInstance
{
    public Guid Id { get; set; }
    public Guid FormId { get; set; }
    public FormTemplate Form { get; set; }
    public ICollection<FormSectionInstance> Sections { get; set; }       
}
