using Microsoft.EntityFrameworkCore;
using MyForms.Domain;

namespace MyForms.Data;

public class MyFormsDbContext : DbContext
{
    public MyFormsDbContext()
    {

    }
    public MyFormsDbContext(DbContextOptions<MyFormsDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {            
        optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=FormMash;User Id=sa;password=p@55w0rd");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Field>()
            .HasOne<FormSection>(t => t.FormSection)
            .WithMany(t => t.Fields)
            .HasForeignKey(t => t.FormSectionId);

        modelBuilder.Entity<FieldConstraint>()
            .HasOne<Field>(t => t.Field)
            .WithMany(t => t.FieldConstraints)
            .HasForeignKey(t => t.FieldId);

        modelBuilder.Entity<ComplexForm>()
            .HasMany<SubForm>(t => t.SubForms)
            .WithOne(t => t.ComplexForm)
            .HasForeignKey(t => t.ComplexFormId);

        modelBuilder.Entity<FormSection>()
            .HasOne(t => t.Form)
            .WithMany(t => t.FormSections)
            .HasForeignKey(t => t.FormId);

        modelBuilder.Entity<FormSection>()
            .HasMany(t => t.FormSectionInstances)
            .WithOne(t => t.FormSection)
            .HasForeignKey(t => t.FormSectionId);

        modelBuilder.Entity<FormInstance>()
            .HasOne(t => t.Form)
            .WithMany(t => t.FormInstances)
            .HasForeignKey(t=>t.FormId);

        modelBuilder.Entity<MultiSelectField>()
            .HasMany<MultiSelectValue>(t => t.Values)
            .WithOne(t => t.MultiSelectField)
            .HasForeignKey(t => t.MultiSelectFieldId);

        modelBuilder.Entity<ListField>()
            .HasMany<ListFieldValue>(t => t.Values)
            .WithOne(t => t.ListField)
            .HasForeignKey(t => t.ListFieldId);

        modelBuilder.Entity<FormInstance>()
            .HasMany(t => t.Sections)
            .WithOne(t => t.FormInstance)
            .HasForeignKey(t => t.FormInstanceId);

        modelBuilder.Entity<FormSectionInstance>()
            .HasMany(t => t.Fields)
            .WithOne(t => t.FormSectionInstance)
            .HasForeignKey(t => t.FormSectionInstanceId);

        modelBuilder.Entity<ListFieldInstance>()
            .HasMany(t => t.Values)
            .WithOne(t => t.FieldInstance)
            .HasForeignKey(t => t.FieldInstanceId);

        modelBuilder.Entity<MultiSelectFieldInstance>()
            .HasMany(t => t.Values)
            .WithOne(t => t.FieldInstance)
            .HasForeignKey(t => t.FieldInstanceId);

        modelBuilder.Entity<FieldInstance>()
            .HasOne(t => t.Field)
            .WithMany(t => t.FieldInstances)
            .HasForeignKey(t => t.FieldId);
    }

    public DbSet<ComplexForm> ComplexForms { get; set; }
    public DbSet<DateRangeConstraint> DateRangeConstraints { get; set; }
    public DbSet<Field> Fields { get; set; }
    public DbSet<FieldNumericConstraint> FieldNumericConstraints { get; set; }
    public DbSet<FormTemplate> Forms { get; set; }
    public DbSet<FormSection> FormSections { get; set; }
    public DbSet<ListField> ListFields { get; set; }
    public DbSet<ListFieldValue> ListFieldValues { get; set; }
    public DbSet<MultiSelectField> MultiSelectFields { get; set; }
    public DbSet<SimpleField> SimpleFields { get; set; }
    public DbSet<StringRegularExpressionConstraint> StringRegularExpressionConstraints { get; set; }
    public DbSet<FormInstance> FormInstances { get; set; }
    public DbSet<FormSectionInstance> FormSectionInstances { get; set; }
    public DbSet<FieldInstance> FieldInstances { get; set; }
    public DbSet<ListFieldInstance> ListFieldInstances { get; set; }
    public DbSet<ListFieldValueInstance> ListFieldValueInstances { get; set; }
    public DbSet<SimpleFieldInstance> SimpleFieldInstances { get; set; }
    public DbSet<MultiSelectFieldInstance> MultiSelectFieldInstances { get; set; }
    public DbSet<MultiSelectValueInstance> MultiSelectValueInstances { get; set; }


}
