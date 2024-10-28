namespace MyForms.Domain;

public class FieldNumericConstraint : FieldConstraint
{
    public int Value { get; set; }
    public NumericBound  NumericBound{ get; set; }
}
