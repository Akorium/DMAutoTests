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
	[Table("SEGMENT")]
	public class Segment
	{
		[Column("ID"       )] public int?    Id       { get; set; } // int
		[Column("NAME"     )] public string? Name     { get; set; } // nvarchar(32)
		[Column("AREA_ID"  )] public int?    AreaId   { get; set; } // int
		[Column("MIN_SPEED")] public double? MinSpeed { get; set; } // float
		[Column("MAX_SPEED")] public double? MaxSpeed { get; set; } // float
		[Column("ACTIVE"   )] public bool?   Active   { get; set; } // bit
		[Column("QUALITY"  )] public byte?   Quality  { get; set; } // tinyint
	}
}
