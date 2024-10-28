using System;

namespace MyForms.Domain;

public class DateRangeConstraint : FieldConstraint
{
    public DateTime Minimum { get; set; } = DateTime.MinValue;
    public DateTime Maximum { get; set; } = DateTime.MaxValue;
}
