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
	[Table("CONSUMABLE_TYPE")]
	public class ConsumableType
	{
		[Column("ID"     , IsPrimaryKey = true)] public int     Id     { get; set; } // int
		[Column("NAME"                        )] public string? Name   { get; set; } // nvarchar(32)
		[Column("ALIAS"                       )] public string? Alias  { get; set; } // nvarchar(32)
		[Column("ACTIVE"                      )] public bool?   Active { get; set; } // bit
		[Column("AREA_ID"                     )] public int?    AreaId { get; set; } // int
	}
}
