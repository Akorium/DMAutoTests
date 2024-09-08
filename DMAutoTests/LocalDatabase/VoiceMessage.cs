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
	[Table("VOICE_MESSAGE")]
	public class VoiceMessage
	{
		[Column("ID"                  , IsPrimaryKey = true)] public Guid      Id                { get; set; } // uniqueidentifier
		[Column("FROM_UNIT_ID"                             )] public int?      FromUnitId        { get; set; } // int
		[Column("TO_UNIT_ID"                               )] public int?      ToUnitId          { get; set; } // int
		[Column("IS_READ"                                  )] public bool?     IsRead            { get; set; } // bit
		[Column("MESSAGE"                                  )] public byte[]?   Message           { get; set; } // image
		[Column("TIMESTAMP"                                )] public DateTime? Timestamp         { get; set; } // datetime
		[Column("FROM_STAFF_OFFICE_ID"                     )] public int?      FromStaffOfficeId { get; set; } // int
		[Column("TO_STAFF_OFFICE_ID"                       )] public int?      ToStaffOfficeId   { get; set; } // int
	}
}
