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
	[Table("BLAST_ZONE")]
	public class BlastZone
	{
		[Column("ID"                                             )] public int?   Id     { get; set; } // int
		[Column("UNIT_ID"                                        )] public int    UnitId { get; set; } // int
		[Column("AREA_ID"                                        )] public int?   AreaId { get; set; } // int
		[Column("GUID"   , CanBeNull = false, IsPrimaryKey = true)] public string Guid   { get; set; } = null!; // nvarchar(64)
	}
}
