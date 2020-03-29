namespace myForms.Core
{
    public class FieldNumericConstraint : FieldConstraint
    {
        public int Value { get; set; }
        public NumericBound  NumericBound{ get; set; }
    }
}
