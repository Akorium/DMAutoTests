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
	[Table("UNIT_STATUS_UNIT_TYPE")]
	public class UnitStatusUnitType
	{
		[Column("STATUS_ID"   , IsPrimaryKey = true, PrimaryKeyOrder = 0)] public int StatusId   { get; set; } // int
		[Column("UNIT_TYPE_ID", IsPrimaryKey = true, PrimaryKeyOrder = 1)] public int UnitTypeId { get; set; } // int
	}
}
