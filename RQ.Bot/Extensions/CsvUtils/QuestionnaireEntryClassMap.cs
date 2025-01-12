using CsvHelper.Configuration;
using RQ.DTO;
using RQ.DTO.Enum;

namespace RQ.Bot.Extensions.CsvUtils;

public sealed class QuestionnaireEntryClassMap : ClassMap<QuestionnaireEntry>
{
    public QuestionnaireEntryClassMap()
    {
        Map(p => p.Category);
        Map(p => p.Group).TypeConverter<CustomIntegerConverter>();
        Map(p => p.Text);
        Map(p => p.DuplicateCheck).TypeConverter<CustomByteConverter>();
        Map(p => p.ValidationRegex);
        Map(p => p.AutopassMode).TypeConverter<CustomEnumConverter<AutopassMode>>();
        Map(p => p.IsGroupSwitch).TypeConverter<CustomByteConverter>();
        Map(p => p.Attachment);
    }
}