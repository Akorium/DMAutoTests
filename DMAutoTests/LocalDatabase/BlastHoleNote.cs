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
	[Table("BLAST_HOLE_NOTE")]
	public class BlastHoleNote
	{
		[Column("AREA_ID"           )] public int?      AreaId           { get; set; } // int
		[Column("BLAST_BLOCK_ID"    )] public int?      BlastBlockId     { get; set; } // int
		[Column("HOLE_NAME"         )] public string?   HoleName         { get; set; } // nvarchar(32)
		[Column("NOTE"              )] public string?   Note             { get; set; } // nvarchar(2048)
		[Column("OPERATOR_ID"       )] public int?      OperatorId       { get; set; } // int
		[Column("OFFICE_OPERATOR_ID")] public int?      OfficeOperatorId { get; set; } // int
		[Column("UNIT_ID"           )] public int?      UnitId           { get; set; } // int
		[Column("TIMESTAMP"         )] public DateTime? Timestamp        { get; set; } // datetime
	}
}
