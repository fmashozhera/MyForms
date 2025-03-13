using FluentResults;

namespace MyForms.Domain.FieldTypes;
public record TextField
{
    public int Id { get; set; }
    public bool IsRequired { get; private set; }
    public int MinimumLength { get; private set; }
    public int MaximumLength { get; private set; }
    public string ValidationRegex { get; set; }
    public string Label { get; set; }
    public int Index { get; set; }
    private TextField(
        string label,
        int index,
        bool isRequired = false,
        int minimumLength = 1,
        int maximumLength = int.MaxValue,        
        string validationRegex = "")
    {
        Label = label;
        Index = index;
        IsRequired = isRequired;
        MinimumLength = minimumLength;
        MaximumLength = maximumLength;   
        ValidationRegex = validationRegex;
    }

    public static Result<TextField> Create(
        string label,
        int index,
        bool isRequired = false,
        int minimumLength = 1,
        int maximumLength = int.MaxValue,
        string validationRegex = "")
    {
        var result = new Result<TextField>();
        if (string.IsNullOrEmpty(label))
            result.WithError("Field label is required");

        if (index < 1)
            result.WithError("Field index cannot be less than 1");

        if(minimumLength > maximumLength)
            result.WithError($"Minum length cannot be greater than maximum length");

        if (minimumLength < 1)
            result.WithError("Minimum length cannot be less than 1");

        if (result.Errors.Count > 0)
            return result;

        return new TextField(label, index, isRequired, minimumLength, maximumLength, validationRegex);

    }
}
