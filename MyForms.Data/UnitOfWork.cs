using MyForms.Domain;
using MyForms.Data.Interfaces;
using System;
using System.Threading.Tasks;

namespace MyForms.Data;

public class UnitOfWork : IUnitOfWork
{
    public IRepository<ComplexForm> ComplexForms { get; }
    public IRepository<DateRangeConstraint> DateRangeConstraints { get; }
    public IRepository<Field> Fields { get; }
    public IRepository<FieldNumericConstraint> FieldNumericConstraints { get; }
    public IRepository<FormTemplate> Forms { get; }
    public IRepository<FormSection> FormSections { get; }
    public IRepository<ListField> ListFields { get; }
    public IRepository<ListFieldValue> ListFieldValues { get; }
    public IRepository<MultiSelectField> MultiSelectFields { get; }
    public IRepository<SimpleField> SimpleFields { get; }
    public IRepository<StringRegularExpressionConstraint> StringRegularExpressionConstraints { get; }
    public IRepository<FormInstance> FormInstances { get; }
    public IRepository<FormSectionInstance> FormSectionInstances { get; }
    public IRepository<FieldInstance> FieldInstances { get; }
    public IRepository<ListFieldInstance> ListFieldInstances { get; }
    public IRepository<ListFieldValueInstance> ListFieldValueInstances { get; }
    public IRepository<SimpleFieldInstance> SimpleFieldInstances { get; }
    public IRepository<MultiSelectFieldInstance> MultiSelectFieldInstances { get; }
    public IRepository<MultiSelectValueInstance> MultiSelectValueInstances { get; }

    private MyFormsDbContext _context;
    public UnitOfWork(MyFormsDbContext context,
            IRepository<ComplexForm> ComplexForms,
            IRepository<DateRangeConstraint> DateRangeConstraints,
            IRepository<Field> Fields,
            IRepository<FieldNumericConstraint> FieldNumericConstraints,
            IRepository<FormTemplate> Forms,
            IRepository<FormSection> FormSections,
            IRepository<ListField> ListFields,
            IRepository<ListFieldValue> ListFieldValues,
            IRepository<MultiSelectField> MultiSelectFields,
            IRepository<SimpleField> SimpleFields,
            IRepository<StringRegularExpressionConstraint> StringRegularExpressionConstraints,
            IRepository<FormInstance> FormInstances,
            IRepository<FormSectionInstance> FormSectionInstances,
            IRepository<FieldInstance> FieldInstances,
            IRepository<ListFieldInstance> ListFieldInstances,
            IRepository<ListFieldValueInstance> ListFieldValueInstances,
            IRepository<SimpleFieldInstance> SimpleFieldInstances,
            IRepository<MultiSelectFieldInstance> MultiSelectFieldInstances,
            IRepository<MultiSelectValueInstance> MultiSelectValueInstances)
    {
        _context = context;
        this.ComplexForms = ComplexForms;
        this.DateRangeConstraints = DateRangeConstraints;
        this.Fields = Fields;
        this.FieldNumericConstraints = FieldNumericConstraints;
        this.Forms = Forms;
        this.FormSections = FormSections;
        this.ListFields = ListFields;
        this.ListFieldValues = ListFieldValues;
        this.MultiSelectFields = MultiSelectFields;
        this.SimpleFields = SimpleFields;
        this.StringRegularExpressionConstraints = StringRegularExpressionConstraints;
        this.FormInstances = FormInstances;
        this.FormSectionInstances = FormSectionInstances;
        this.FieldInstances = FieldInstances;
        this.ListFieldInstances = ListFieldInstances;
        this.ListFieldValueInstances = ListFieldValueInstances;
        this.SimpleFieldInstances = SimpleFieldInstances;
        this.MultiSelectFieldInstances = MultiSelectFieldInstances;
        this.MultiSelectValueInstances = MultiSelectValueInstances;
    }
    public async Task<int> Complete()
    {
        return await _context.SaveChangesAsync();
    }
}
