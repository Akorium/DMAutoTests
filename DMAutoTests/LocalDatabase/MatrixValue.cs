// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB.Mapping;

#pragma warning disable 1573, 1591
#nullable enable

namespace DMAutoTests
{
	[Table("MATRIX_VALUE")]
	public class MatrixValue
	{
		[Column("MATRIX_ID"    , IsPrimaryKey = true, PrimaryKeyOrder = 0)] public int     MatrixId     { get; set; } // int
		[Column("ROW_NUMBER"   , IsPrimaryKey = true, PrimaryKeyOrder = 1)] public int     RowNumber    { get; set; } // int
		[Column("COLUMN_NUMBER", IsPrimaryKey = true, PrimaryKeyOrder = 2)] public int     ColumnNumber { get; set; } // int
		[Column("CELL_VALUE"                                             )] public double? CellValue    { get; set; } // float
	}
}
