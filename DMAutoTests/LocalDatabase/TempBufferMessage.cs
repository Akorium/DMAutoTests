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
	[Table("TEMP_BUFFER_MESSAGE")]
	public class TempBufferMessage
	{
		[Column("ID"       )] public int?      Id        { get; set; } // int
		[Column("UNIT_ID"  )] public int?      UnitId    { get; set; } // int
		[Column("DATA"     )] public byte[]?   Data      { get; set; } // image
		[Column("TIMESTAMP")] public DateTime? Timestamp { get; set; } // datetime
	}
}
