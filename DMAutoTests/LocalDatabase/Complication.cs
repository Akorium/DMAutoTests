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
	[Table("COMPLICATION")]
	public class Complication
	{
		[Column("ID"   , IsPrimaryKey = true)] public int     Id    { get; set; } // int
		[Column("NAME"                      )] public string? Name  { get; set; } // nvarchar(200)
		[Column("ALIAS"                     )] public string? Alias { get; set; } // nvarchar(16)
	}
}
