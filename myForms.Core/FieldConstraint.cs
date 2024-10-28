using System;

namespace MyForms.Domain;

public class FieldConstraint
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool IsValid { get; set; }
    public Field Field { get; set; }
    public Guid FieldId { get; set; }
}
