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
	[Table("DRILL_GEO_GAUGE_VALUE_TYPE")]
	public class DrillGeoGaugeValueType
	{
		[Column("ID"        , IsPrimaryKey = true)] public int     Id        { get; set; } // int
		[Column("VALUE_NAME"                     )] public string? ValueName { get; set; } // nvarchar(32)
	}
}
