﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyForms.Data;

namespace MyForms.Data.Migrations;

[DbContext(typeof(MyFormsDbContext))]
partial class MyFormsDbContextModelSnapshot : ModelSnapshot
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("ProductVersion", "3.1.3")
            .HasAnnotation("Relational:MaxIdentifierLength", 128)
            .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

        modelBuilder.Entity("MyForms.Domain.Field", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<int>("DataType")
                    .HasColumnType("int");

                b.Property<string>("Discriminator")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<Guid>("FormSectionId")
                    .HasColumnType("uniqueidentifier");

                b.Property<int>("Index")
                    .HasColumnType("int");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("FormSectionId");

                b.ToTable("Fields");

                b.HasDiscriminator<string>("Discriminator").HasValue("Field");
            });

        modelBuilder.Entity("MyForms.Domain.FieldConstraint", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("Discriminator")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<Guid>("FieldId")
                    .HasColumnType("uniqueidentifier");

                b.Property<bool>("IsValid")
                    .HasColumnType("bit");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("FieldId");

                b.ToTable("FieldConstraint");

                b.HasDiscriminator<string>("Discriminator").HasValue("FieldConstraint");
            });

        modelBuilder.Entity("MyForms.Domain.FieldInstance", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("Discriminator")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<Guid>("FieldId")
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("FormSectionInstanceId")
                    .HasColumnType("uniqueidentifier");

                b.HasKey("Id");

                b.HasIndex("FieldId");

                b.HasIndex("FormSectionInstanceId");

                b.ToTable("FieldInstances");

                b.HasDiscriminator<string>("Discriminator").HasValue("FieldInstance");
            });

        modelBuilder.Entity("MyForms.Domain.FormTemplate", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("Discriminator")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Forms");

                b.HasDiscriminator<string>("Discriminator").HasValue("FormTemplate");
            });

        modelBuilder.Entity("MyForms.Domain.FormInstance", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("FormId")
                    .HasColumnType("uniqueidentifier");

                b.HasKey("Id");

                b.HasIndex("FormId");

                b.ToTable("FormInstances");
            });

        modelBuilder.Entity("MyForms.Domain.FormSection", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("FormId")
                    .HasColumnType("uniqueidentifier");

                b.Property<int>("Index")
                    .HasColumnType("int");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("FormId");

                b.ToTable("FormSections");
            });

        modelBuilder.Entity("MyForms.Domain.FormSectionInstance", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("FormInstanceId")
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("FormSectionId")
                    .HasColumnType("uniqueidentifier");

                b.HasKey("Id");

                b.HasIndex("FormInstanceId");

                b.HasIndex("FormSectionId");

                b.ToTable("FormSectionInstances");
            });

        modelBuilder.Entity("MyForms.Domain.ListFieldValue", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("ListFieldId")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("DataType")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("ListFieldId");

                b.ToTable("ListFieldValues");
            });

        modelBuilder.Entity("MyForms.Domain.ListFieldValueInstance", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("FieldInstanceId")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("DataType")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("FieldInstanceId");

                b.ToTable("ListFieldValueInstances");
            });

        modelBuilder.Entity("MyForms.Domain.MultiSelectValue", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("MultiSelectFieldId")
                    .HasColumnType("uniqueidentifier");

                b.Property<bool>("Selected")
                    .HasColumnType("bit");

                b.Property<string>("DataType")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("MultiSelectFieldId");

                b.ToTable("MultiSelectValue");
            });

        modelBuilder.Entity("MyForms.Domain.MultiSelectValueInstance", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("FieldInstanceId")
                    .HasColumnType("uniqueidentifier");

                b.Property<bool>("Selected")
                    .HasColumnType("bit");

                b.Property<string>("DataType")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("FieldInstanceId");

                b.ToTable("MultiSelectValueInstances");
            });

        modelBuilder.Entity("MyForms.Domain.ListField", b =>
            {
                b.HasBaseType("MyForms.Domain.Field");

                b.HasDiscriminator().HasValue("ListField");
            });

        modelBuilder.Entity("MyForms.Domain.MultiSelectField", b =>
            {
                b.HasBaseType("MyForms.Domain.Field");

                b.Property<bool>("AllowMultipleValues")
                    .HasColumnType("bit");

                b.HasDiscriminator().HasValue("MultiSelectField");
            });

        modelBuilder.Entity("MyForms.Domain.SimpleFieldType", b =>
            {
                b.HasBaseType("MyForms.Domain.Field");

                b.Property<string>("DataType")
                    .HasColumnType("nvarchar(max)");

                b.HasDiscriminator().HasValue("SimpleFieldType");
            });

        modelBuilder.Entity("MyForms.Domain.DateRangeConstraint", b =>
            {
                b.HasBaseType("MyForms.Domain.FieldConstraint");

                b.Property<DateTime>("Maximum")
                    .HasColumnType("datetime2");

                b.Property<DateTime>("Minimum")
                    .HasColumnType("datetime2");

                b.HasDiscriminator().HasValue("DateRangeConstraint");
            });

        modelBuilder.Entity("MyForms.Domain.FieldNumericConstraint", b =>
            {
                b.HasBaseType("MyForms.Domain.FieldConstraint");

                b.Property<int>("NumericBound")
                    .HasColumnType("int");

                b.Property<int>("DataType")
                    .HasColumnType("int");

                b.HasDiscriminator().HasValue("FieldNumericConstraint");
            });

        modelBuilder.Entity("MyForms.Domain.StringRegularExpressionConstraint", b =>
            {
                b.HasBaseType("MyForms.Domain.FieldConstraint");

                b.Property<string>("Regex")
                    .HasColumnType("nvarchar(max)");

                b.HasDiscriminator().HasValue("StringRegularExpressionConstraint");
            });

        modelBuilder.Entity("MyForms.Domain.ListFieldInstance", b =>
            {
                b.HasBaseType("MyForms.Domain.FieldInstance");

                b.HasDiscriminator().HasValue("ListFieldInstance");
            });

        modelBuilder.Entity("MyForms.Domain.MultiSelectFieldInstance", b =>
            {
                b.HasBaseType("MyForms.Domain.FieldInstance");

                b.HasDiscriminator().HasValue("MultiSelectFieldInstance");
            });

        modelBuilder.Entity("MyForms.Domain.SimpleFieldInstance", b =>
            {
                b.HasBaseType("MyForms.Domain.FieldInstance");

                b.Property<string>("DataType")
                    .HasColumnType("nvarchar(max)");

                b.HasDiscriminator().HasValue("SimpleFieldInstance");
            });

        modelBuilder.Entity("MyForms.Domain.ComplexForm", b =>
            {
                b.HasBaseType("MyForms.Domain.FormTemplate");

                b.HasDiscriminator().HasValue("ComplexForm");
            });

        modelBuilder.Entity("MyForms.Domain.SubForm", b =>
            {
                b.HasBaseType("MyForms.Domain.FormTemplate");

                b.Property<Guid>("ComplexFormId")
                    .HasColumnType("uniqueidentifier");

                b.HasIndex("ComplexFormId");

                b.HasDiscriminator().HasValue("SubForm");
            });

        modelBuilder.Entity("MyForms.Domain.Field", b =>
            {
                b.HasOne("MyForms.Domain.FormSection", "FormSection")
                    .WithMany("Fields")
                    .HasForeignKey("FormSectionId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("MyForms.Domain.FieldConstraint", b =>
            {
                b.HasOne("MyForms.Domain.Field", "Field")
                    .WithMany("FieldConstraints")
                    .HasForeignKey("FieldId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("MyForms.Domain.FieldInstance", b =>
            {
                b.HasOne("MyForms.Domain.Field", "Field")
                    .WithMany("FieldInstances")
                    .HasForeignKey("FieldId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("MyForms.Domain.FormSectionInstance", "FormSectionInstance")
                    .WithMany("Fields")
                    .HasForeignKey("FormSectionInstanceId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("MyForms.Domain.FormInstance", b =>
            {
                b.HasOne("MyForms.Domain.FormTemplate", "FormTemplate")
                    .WithMany("FormInstances")
                    .HasForeignKey("FormId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("MyForms.Domain.FormSection", b =>
            {
                b.HasOne("MyForms.Domain.FormTemplate", "FormTemplate")
                    .WithMany("FormSections")
                    .HasForeignKey("FormId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("MyForms.Domain.FormSectionInstance", b =>
            {
                b.HasOne("MyForms.Domain.FormInstance", "FormInstance")
                    .WithMany("Sections")
                    .HasForeignKey("FormInstanceId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("MyForms.Domain.FormSection", "FormSection")
                    .WithMany("FormSectionInstances")
                    .HasForeignKey("FormSectionId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("MyForms.Domain.ListFieldValue", b =>
            {
                b.HasOne("MyForms.Domain.ListField", "ListField")
                    .WithMany("Values")
                    .HasForeignKey("ListFieldId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("MyForms.Domain.ListFieldValueInstance", b =>
            {
                b.HasOne("MyForms.Domain.ListFieldInstance", "FieldInstance")
                    .WithMany("Values")
                    .HasForeignKey("FieldInstanceId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("MyForms.Domain.MultiSelectValue", b =>
            {
                b.HasOne("MyForms.Domain.MultiSelectField", "MultiSelectField")
                    .WithMany("Values")
                    .HasForeignKey("MultiSelectFieldId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("MyForms.Domain.MultiSelectValueInstance", b =>
            {
                b.HasOne("MyForms.Domain.MultiSelectFieldInstance", "FieldInstance")
                    .WithMany("Values")
                    .HasForeignKey("FieldInstanceId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("MyForms.Domain.SubForm", b =>
            {
                b.HasOne("MyForms.Domain.ComplexForm", "ComplexForm")
                    .WithMany("SubForms")
                    .HasForeignKey("ComplexFormId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });
#pragma warning restore 612, 618
    }
}
