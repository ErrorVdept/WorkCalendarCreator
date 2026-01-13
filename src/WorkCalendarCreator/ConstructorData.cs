using WorkCalendarCreator.Models;

namespace WorkCalendarCreator;

public class ConstructorData
{
    public ConstructorData() { }
    public List<DateFormat> DateFormats { get; set; } = new()
    {
        new DateFormat(){ NameKey = "TimestampS", Value="TimestampS" },
        new DateFormat(){ NameKey = "TimestampMS", Value="TimestampMS" },
        new DateFormat(){ NameKey = "yyyy-MM-dd", Value="yyyy-MM-dd" },
        new DateFormat(){ NameKey = "dd/MM/yyyy", Value="dd/MM/yyyy" },
        new DateFormat(){ NameKey = "MM/dd/yyyy", Value="MM/dd/yyyy" },
        new DateFormat(){ NameKey = "dd.MM.yyyy", Value="dd.MM.yyyy" },
        new DateFormat(){ NameKey = "MM.dd.yyyy", Value="MM.dd.yyyy" },
        new DateFormat(){ NameKey = "ISO8601", Value="ISO8601" },
        new DateFormat(){ NameKey = "yyyy.MM.dd HH:mm:ss", Value="yyyy.MM.dd HH:mm:ss" },
        new DateFormat(){ NameKey = "yyyy-MM-dd HH:mm:ss", Value="yyyy-MM-dd HH:mm:ss" },
        new DateFormat(){ NameKey = "dd.MM.yyyy HH:mm:ss", Value="dd.MM.yyyy HH:mm:ss" },
        new DateFormat(){ NameKey = "dd-MM-yyyy HH:mm:ss", Value="dd-MM-yyyy HH:mm:ss" },
        new DateFormat(){ NameKey = "MM.dd.yyyy HH:mm:ss", Value="MM.dd.yyyy HH:mm:ss" },
        new DateFormat(){ NameKey = "MM-dd-yyyy HH:mm:ss", Value="MM-dd-yyyy HH:mm:ss" },
    };
    // F - full
    public List<ExportFormat> ExportFormats { get; set; } = new()
    {
        new ExportFormat(){ NameKey = "JSON" },
        new ExportFormat(){ NameKey = "JSONF" },
        new ExportFormat(){ NameKey = "XML" },
        new ExportFormat(){ NameKey = "XMLF"},
        new ExportFormat(){ NameKey = "CSV"},
        new ExportFormat(){ NameKey = "CSVF"},
        new ExportFormat(){ NameKey = "TXTRow"},
        new ExportFormat(){ NameKey = "TXTComma"}
    };

    public List<TimeZoneVariant> TimeZoneVariants { get; set; } = new()
    {
        new TimeZoneVariant(){ Name = "UTC-11", Value="-11" },
        new TimeZoneVariant(){ Name = "UTC-10", Value="-10" },
        new TimeZoneVariant(){ Name = "UTC-9", Value="-9" },
        new TimeZoneVariant(){ Name = "UTC-8", Value="-8" },
        new TimeZoneVariant(){ Name = "UTC-7", Value="-7" },
        new TimeZoneVariant(){ Name = "UTC-6", Value="-6" },
        new TimeZoneVariant(){ Name = "UTC-5", Value="-5" },
        new TimeZoneVariant(){ Name = "UTC-4", Value="-4" },
        new TimeZoneVariant(){ Name = "UTC-3", Value="-3" },
        new TimeZoneVariant(){ Name = "UTC-2", Value="-2" },
        new TimeZoneVariant(){ Name = "UTC-1", Value="-1" },
        new TimeZoneVariant(){ Name = "UTC", Value="Z" },
        new TimeZoneVariant(){ Name = "UTC+1", Value="+1" },
        new TimeZoneVariant(){ Name = "UTC+2", Value="+2" },
        new TimeZoneVariant(){ Name = "UTC+3", Value="+3" },
        new TimeZoneVariant(){ Name = "UTC+4", Value="+4" },
        new TimeZoneVariant(){ Name = "UTC+5", Value="+5" },
        new TimeZoneVariant(){ Name = "UTC+6", Value="+6" },
        new TimeZoneVariant(){ Name = "UTC+7", Value="+7" },
        new TimeZoneVariant(){ Name = "UTC+8", Value="+8" },
        new TimeZoneVariant(){ Name = "UTC+9", Value="+9" },
        new TimeZoneVariant(){ Name = "UTC+10", Value="+10" },
        new TimeZoneVariant(){ Name = "UTC+11", Value="+11" },
        new TimeZoneVariant(){ Name = "UTC+12", Value="+12" },
    };
}
