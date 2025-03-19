using FluentResults;
using MyForms.Domain.FieldTypes;
using System.Collections.Generic;
using System.Linq;

namespace MyForms.Domain;

public class FormSection
{
    public string Name { get; private set; }
    public int Index { get; private set; }
    public ICollection<TextField> Fields { get => _textFields.ToList(); }

    private ICollection<TextField> _textFields;

    private FormSection(int index, string name)
    {
        Index = index;
        Name = name;
    }

    public static Result<FormSection> Create(int index, string name)
    {
        Result <FormSection> formSectionResult = ValidateFormSectionDetails(index, name);
        if (!formSectionResult.IsSuccess)
            return formSectionResult;

        FormSection formSection = new FormSection(index, name);
        return formSection;
    }

    private static Result<FormSection> ValidateFormSectionDetails(int index,string name)
    {
        Result<FormSection> formSectionResult = new();
        if (string.IsNullOrWhiteSpace(name))
            formSectionResult.WithError("Form section name is required.");

        if (index < 0)
            formSectionResult.WithError("Form section index must be greater than or equal to 0.");

        return formSectionResult;
    }

    public Result<TextField> AddTextField(string label,
                                          int index,
                                          bool isRequired = false,
                                          int minimumLength = 1,
                                          int maximumLength = int.MaxValue,
                                          string validationRegex = "")
    {
        Result<TextField> textFieldResult = new();
        ValidateTextFieldDetails(label, index, textFieldResult);

        if (!textFieldResult.IsSuccess)
            return textFieldResult;

        Result<TextField> textField = TextField.Create(label, index, isRequired, minimumLength, maximumLength, validationRegex);
        return textFieldResult;
    }
    
    public Result RemoveTextField(string label)
    {
        if (!IsFieldOnFormSection(label))
            return Result.Fail("There is no field with the given label.");

        TextField removedField = _textFields.First(t => t.Label == label);
        _textFields.Remove(removedField);
        return Result.Ok();
    }

    private bool IsFieldOnFormSection(string label) => _textFields.Any(t => t.Label == label);
    private void ValidateTextFieldDetails(string label,
                                          int index,
                                          Result<TextField> textFieldResult)
    {
        if (!IsFieldLabelValid(label))
            textFieldResult.WithError("Field label already in use. An existing field has the same label.");

        if (IsIndexValid(index))
            textFieldResult.WithError("Field index already in use. An existing field has the same index.");
    }
    private bool IsIndexValid(int index) => !_textFields.Any(f => f.Index == index);
    private bool IsFieldLabelValid(string label) => !_textFields.Any(f => f.Label == label);
    public Result Update(int index, string name)
    {
        Result<FormSection> formSectionResult = ValidateFormSectionDetails(index, name);
        if (!formSectionResult.IsSuccess)
            return formSectionResult.ToResult();

        Index = index;
        Name = name;
        return Result.Ok();
    }
}
