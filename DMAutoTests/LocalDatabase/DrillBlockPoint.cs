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
	[Table("DRILL_BLOCK_POINTS")]
	public class DrillBlockPoint
	{
		[Column("DRILL_BLOCK_ID" , IsPrimaryKey = true, PrimaryKeyOrder = 0)] public int       DrillBlockId   { get; set; } // int
		[Column("SEQUENCE"       , IsPrimaryKey = true, PrimaryKeyOrder = 1)] public int       Sequence       { get; set; } // int
		[Column("X"                                                        )] public double?   X              { get; set; } // float
		[Column("Y"                                                        )] public double?   Y              { get; set; } // float
		[Column("Z"                                                        )] public double?   Z              { get; set; } // float
		[Column("TIMESTAMP"                                                )] public DateTime? Timestamp      { get; set; } // datetime
		[Column("END_TIMESTAMP"                                            )] public DateTime? EndTimestamp   { get; set; } // datetime
		[Column("START_TIMESTAMP"                                          )] public DateTime? StartTimestamp { get; set; } // datetime
	}
}
