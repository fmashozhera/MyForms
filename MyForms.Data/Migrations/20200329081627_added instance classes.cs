using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyForms.Data.Migrations;

public partial class addedinstanceclasses : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "FormInstances",
            columns: table => new
            {
                Id = table.Column<Guid>(nullable: false),
                FormId = table.Column<Guid>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_FormInstances", x => x.Id);
                table.ForeignKey(
                    name: "FK_FormInstances_Forms_FormId",
                    column: x => x.FormId,
                    principalTable: "Forms",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "FormSectionInstances",
            columns: table => new
            {
                Id = table.Column<Guid>(nullable: false),
                FormInstanceId = table.Column<Guid>(nullable: false),
                FormSectionId = table.Column<Guid>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_FormSectionInstances", x => x.Id);
                table.ForeignKey(
                    name: "FK_FormSectionInstances_FormInstances_FormInstanceId",
                    column: x => x.FormInstanceId,
                    principalTable: "FormInstances",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.NoAction);
                table.ForeignKey(
                    name: "FK_FormSectionInstances_FormSections_FormSectionId",
                    column: x => x.FormSectionId,
                    principalTable: "FormSections",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "FieldInstances",
            columns: table => new
            {
                Id = table.Column<Guid>(nullable: false),
                FormSectionInstanceId = table.Column<Guid>(nullable: false),
                FieldId = table.Column<Guid>(nullable: false),
                Discriminator = table.Column<string>(nullable: false),
                Value = table.Column<string>(nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_FieldInstances", x => x.Id);
                table.ForeignKey(
                    name: "FK_FieldInstances_Fields_FieldId",
                    column: x => x.FieldId,
                    principalTable: "Fields",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_FieldInstances_FormSectionInstances_FormSectionInstanceId",
                    column: x => x.FormSectionInstanceId,
                    principalTable: "FormSectionInstances",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.NoAction);
            });

        migrationBuilder.CreateTable(
            name: "ListFieldValueInstances",
            columns: table => new
            {
                Id = table.Column<Guid>(nullable: false),
                Value = table.Column<string>(nullable: true),
                FieldInstanceId = table.Column<Guid>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_ListFieldValueInstances", x => x.Id);
                table.ForeignKey(
                    name: "FK_ListFieldValueInstances_FieldInstances_FieldInstanceId",
                    column: x => x.FieldInstanceId,
                    principalTable: "FieldInstances",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "MultiSelectValueInstances",
            columns: table => new
            {
                Id = table.Column<Guid>(nullable: false),
                Value = table.Column<string>(nullable: true),
                Selected = table.Column<bool>(nullable: false),
                FieldInstanceId = table.Column<Guid>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_MultiSelectValueInstances", x => x.Id);
                table.ForeignKey(
                    name: "FK_MultiSelectValueInstances_FieldInstances_FieldInstanceId",
                    column: x => x.FieldInstanceId,
                    principalTable: "FieldInstances",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_FieldInstances_FieldId",
            table: "FieldInstances",
            column: "FieldId");

        migrationBuilder.CreateIndex(
            name: "IX_FieldInstances_FormSectionInstanceId",
            table: "FieldInstances",
            column: "FormSectionInstanceId");

        migrationBuilder.CreateIndex(
            name: "IX_FormInstances_FormId",
            table: "FormInstances",
            column: "FormId");

        migrationBuilder.CreateIndex(
            name: "IX_FormSectionInstances_FormInstanceId",
            table: "FormSectionInstances",
            column: "FormInstanceId");

        migrationBuilder.CreateIndex(
            name: "IX_FormSectionInstances_FormSectionId",
            table: "FormSectionInstances",
            column: "FormSectionId");

        migrationBuilder.CreateIndex(
            name: "IX_ListFieldValueInstances_FieldInstanceId",
            table: "ListFieldValueInstances",
            column: "FieldInstanceId");

        migrationBuilder.CreateIndex(
            name: "IX_MultiSelectValueInstances_FieldInstanceId",
            table: "MultiSelectValueInstances",
            column: "FieldInstanceId");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "ListFieldValueInstances");

        migrationBuilder.DropTable(
            name: "MultiSelectValueInstances");

        migrationBuilder.DropTable(
            name: "FieldInstances");

        migrationBuilder.DropTable(
            name: "FormSectionInstances");

        migrationBuilder.DropTable(
            name: "FormInstances");
    }
}
