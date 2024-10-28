using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyForms.Data.Migrations;

public partial class InitialSetup : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Forms",
            columns: table => new
            {
                Id = table.Column<Guid>(nullable: false),
                Name = table.Column<string>(nullable: true),
                Discriminator = table.Column<string>(nullable: false),
                ComplexFormId = table.Column<Guid>(nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Forms", x => x.Id);
                table.ForeignKey(
                    name: "FK_Forms_Forms_ComplexFormId",
                    column: x => x.ComplexFormId,
                    principalTable: "Forms",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.NoAction);
            });

        migrationBuilder.CreateTable(
            name: "FormSections",
            columns: table => new
            {
                Id = table.Column<Guid>(nullable: false),
                Name = table.Column<string>(nullable: true),
                Index = table.Column<int>(nullable: false),
                FormId = table.Column<Guid>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_FormSections", x => x.Id);
                table.ForeignKey(
                    name: "FK_FormSections_Forms_FormId",
                    column: x => x.FormId,
                    principalTable: "Forms",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "Fields",
            columns: table => new
            {
                Id = table.Column<Guid>(nullable: false),
                Name = table.Column<string>(nullable: true),
                DataType = table.Column<int>(nullable: false),
                Index = table.Column<int>(nullable: false),
                FormSectionId = table.Column<Guid>(nullable: false),
                Discriminator = table.Column<string>(nullable: false),
                AllowMultipleValues = table.Column<bool>(nullable: true),
                Value = table.Column<string>(nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Fields", x => x.Id);
                table.ForeignKey(
                    name: "FK_Fields_FormSections_FormSectionId",
                    column: x => x.FormSectionId,
                    principalTable: "FormSections",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "FieldConstraint",
            columns: table => new
            {
                Id = table.Column<Guid>(nullable: false),
                Name = table.Column<string>(nullable: true),
                IsValid = table.Column<bool>(nullable: false),
                FieldId = table.Column<Guid>(nullable: false),
                Discriminator = table.Column<string>(nullable: false),
                Minimum = table.Column<DateTime>(nullable: true),
                Maximum = table.Column<DateTime>(nullable: true),
                Value = table.Column<int>(nullable: true),
                NumericBound = table.Column<int>(nullable: true),
                Regex = table.Column<string>(nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_FieldConstraint", x => x.Id);
                table.ForeignKey(
                    name: "FK_FieldConstraint_Fields_FieldId",
                    column: x => x.FieldId,
                    principalTable: "Fields",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "ListFieldValues",
            columns: table => new
            {
                Id = table.Column<Guid>(nullable: false),
                Value = table.Column<string>(nullable: true),
                ListFieldId = table.Column<Guid>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_ListFieldValues", x => x.Id);
                table.ForeignKey(
                    name: "FK_ListFieldValues_Fields_ListFieldId",
                    column: x => x.ListFieldId,
                    principalTable: "Fields",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "MultiSelectValue",
            columns: table => new
            {
                Id = table.Column<Guid>(nullable: false),
                Value = table.Column<string>(nullable: true),
                Selected = table.Column<bool>(nullable: false),
                MultiSelectFieldId = table.Column<Guid>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_MultiSelectValue", x => x.Id);
                table.ForeignKey(
                    name: "FK_MultiSelectValue_Fields_MultiSelectFieldId",
                    column: x => x.MultiSelectFieldId,
                    principalTable: "Fields",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_FieldConstraint_FieldId",
            table: "FieldConstraint",
            column: "FieldId");

        migrationBuilder.CreateIndex(
            name: "IX_Fields_FormSectionId",
            table: "Fields",
            column: "FormSectionId");

        migrationBuilder.CreateIndex(
            name: "IX_Forms_ComplexFormId",
            table: "Forms",
            column: "ComplexFormId");

        migrationBuilder.CreateIndex(
            name: "IX_FormSections_FormId",
            table: "FormSections",
            column: "FormId");

        migrationBuilder.CreateIndex(
            name: "IX_ListFieldValues_ListFieldId",
            table: "ListFieldValues",
            column: "ListFieldId");

        migrationBuilder.CreateIndex(
            name: "IX_MultiSelectValue_MultiSelectFieldId",
            table: "MultiSelectValue",
            column: "MultiSelectFieldId");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "FieldConstraint");

        migrationBuilder.DropTable(
            name: "ListFieldValues");

        migrationBuilder.DropTable(
            name: "MultiSelectValue");

        migrationBuilder.DropTable(
            name: "Fields");

        migrationBuilder.DropTable(
            name: "FormSections");

        migrationBuilder.DropTable(
            name: "Forms");
    }
}
