using System;
using System.Collections.Generic;

namespace MyForms.Domain.FieldTypes;

public record TableField
{
    private ICollection<Column> _columns = new SortedSet<Column>();
    private ICollection<Row> _rows = new SortedSet<Row>();
    public int NumberOfColumns { get; private set; }
    public string Header { get; private set; }
    public string Footer { get; private set; }
    public IEnumerable<Column> Columns => _columns;
    public IEnumerable<Row> Rows => _rows;
    public TableField(int numberOfColumns, string header = null, string footer = null)
    {
        NumberOfColumns = numberOfColumns;
        Header = header??string.Empty;
        Footer = footer??string.Empty;
    }
    public Column<T> AddColumn<T>(string columnLabel, int columnIndex, T fieldType)
    {
        throw new NotImplementedException();
    }

    public Row AddRow(int rowIndex)
    {
        throw new NotImplementedException();
    }
}

public abstract record Column : IComparable<Column>
{
    public int Index { get; set; }
    public string Label { get; private set; }

    public int CompareTo(Column other)
    {
        return this.Index.CompareTo(other.Index);
    }
}

public record Column<T> : Column
{
    public TableCell AddTableCell(int columnIndex, T value)
    {
        throw new NotImplementedException();
    }
}

public record Row
{
    public ICollection<TableCell> Cells { get; set; }
}

public record TableCell
{
    public int ColumnIndex { get; set; }
    public int RowIndex { get; set; }
    FieldType Field { get; set; }
}


