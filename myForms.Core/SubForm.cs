using System;

namespace MyForms.Domain;

public class SubForm : FormTemplate
{
    public ComplexForm ComplexForm { get; set; }
    public Guid ComplexFormId { get; set; }
}
