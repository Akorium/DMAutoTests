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
	[Table("AUTOSTATUS_CONFIG")]
	public class AutostatusConfig
	{
		[Column("ID"                     , IsPrimaryKey = true)] public int   Id                   { get; set; } // int
		[Column("DOWNTIME_TIMER"                              )] public short DowntimeTimer        { get; set; } // smallint
		[Column("BLOCK_ENABLED_RANGE"                         )] public short BlockEnabledRange    { get; set; } // smallint
		[Column("DISASSEMBLY_RANGE"                           )] public short DisassemblyRange     { get; set; } // smallint
		[Column("MAST_ANGLE_CHANGE"                           )] public short MastAngleChange      { get; set; } // smallint
		[Column("PLAT_ANGLE_CHANGE"                           )] public short PlatAngleChange      { get; set; } // smallint
		[Column("ANTENNA_IN_PLACE"                            )] public short AntennaInPlace       { get; set; } // smallint
		[Column("MAST_ANGLE_CHANGE_TIMER"                     )] public short MastAngleChangeTimer { get; set; } // smallint
		[Column("PLAT_ANGLE_CHANGE_TIMER"                     )] public short PlatAngleChangeTimer { get; set; } // smallint
		[Column("ANTENNA_IN_PLACE_TIMER"                      )] public short AntennaInPlaceTimer  { get; set; } // smallint
	}
}
