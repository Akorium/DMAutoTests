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
	[Table("AREA_POINTS")]
	public class AreaPoint
	{
		[Column("ID"         , IsPrimaryKey = true)] public int       Id         { get; set; } // int
		[Column("AREA_ID"                         )] public int?      AreaId     { get; set; } // int
		[Column("SEQUENCE"                        )] public int?      Sequence   { get; set; } // int
		[Column("LAT"                             )] public double?   Lat        { get; set; } // float
		[Column("LNG"                             )] public double?   Lng        { get; set; } // float
		[Column("UPDATE_DATE"                     )] public DateTime? UpdateDate { get; set; } // datetime
	}
}
