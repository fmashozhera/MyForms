using System;

namespace myForms.Core
{
    public class DateRangeConstraint : FieldConstraint
    {
        public DateTime Minimum { get; set; } = DateTime.MinValue;
        public DateTime Maximum { get; set; } = DateTime.MaxValue;
    }
}
