// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB.Mapping;
using System;

#pragma warning disable 1573, 1591
#nullable enable

namespace DMAutoTests
{
	[Table("DRILL_GAUGE_LIMIT")]
	public class DrillGaugeLimit
	{
		[Column("ID"           , IsPrimaryKey = true)] public int       Id          { get; set; } // int
		[Column("UNIT_ID"                           )] public int?      UnitId      { get; set; } // int
		[Column("GAUGE_TYPE_ID"                     )] public int?      GaugeTypeId { get; set; } // int
		[Column("LOW_LOW"                           )] public double?   LowLow      { get; set; } // float
		[Column("LOW"                               )] public double?   Low         { get; set; } // float
		[Column("HIGH"                              )] public double?   High        { get; set; } // float
		[Column("HIGH_HIGH"                         )] public double?   HighHigh    { get; set; } // float
		[Column("TIMESTAMP"                         )] public DateTime? Timestamp   { get; set; } // datetime
	}
}
