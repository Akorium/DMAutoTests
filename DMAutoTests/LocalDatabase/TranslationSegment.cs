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
	[Table("TRANSLATION_SEGMENT")]
	public class TranslationSegment
	{
		[Column("ID"         )] public int?    Id         { get; set; } // int
		[Column("LANGUAGE_ID")] public int?    LanguageId { get; set; } // int
		[Column("TEXT"       )] public string? Text       { get; set; } // nvarchar(2000)
	}
}
