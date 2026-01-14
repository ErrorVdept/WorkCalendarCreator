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

    public List<ExportFormat> ExportFormats { get; set; } = new()
    {
        new ExportFormat(){ NameKey = "JSON", Example="{\r\n  \"year\":2026,\r\n  \"weekends\":[\r\n    \"value\",\r\n    \"value\"  \r\n  ],\r\n  \"holidays\":[\r\n    \"value\",\r\n    \"value\"  \r\n  ]\r\n}" },
        new ExportFormat(){ NameKey = "XML" , Example="<ResultCalendarModel xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Year>2026</Year>\r\n  <Weekends>\r\n    <string>01.01.2026 00:00:00</string>\r\n  </Weekends>\r\n  <Holidays>\r\n    <string>01.01.2026 00:00:00</string>\r\n  <Holidays>\r\n</ResultCalendarModel>"},
        new ExportFormat(){ NameKey = "CSV", Example="Weekends,Holidays\r\nvalue,value\r\nvalue,value"}
    };

    public List<TimeZoneVariant> TimeZoneVariants { get; set; } = new()
    {
        new TimeZoneVariant(){ Name = "UTC-11", Value="-11:00" },
        new TimeZoneVariant(){ Name = "UTC-10", Value="-10:00" },
        new TimeZoneVariant(){ Name = "UTC-9", Value="-9:00" },
        new TimeZoneVariant(){ Name = "UTC-8", Value="-8:00" },
        new TimeZoneVariant(){ Name = "UTC-7", Value="-7:00" },
        new TimeZoneVariant(){ Name = "UTC-6", Value="-6:00" },
        new TimeZoneVariant(){ Name = "UTC-5", Value="-5:00" },
        new TimeZoneVariant(){ Name = "UTC-4", Value="-4:00" },
        new TimeZoneVariant(){ Name = "UTC-3", Value="-3:00" },
        new TimeZoneVariant(){ Name = "UTC-2", Value="-2:00" },
        new TimeZoneVariant(){ Name = "UTC-1", Value="-1:00" },
        new TimeZoneVariant(){ Name = "UTC", Value="Z" },
        new TimeZoneVariant(){ Name = "UTC+1", Value="+1:00" },
        new TimeZoneVariant(){ Name = "UTC+2", Value="+2:00" },
        new TimeZoneVariant(){ Name = "UTC+3", Value="+3:00" },
        new TimeZoneVariant(){ Name = "UTC+4", Value="+4:00" },
        new TimeZoneVariant(){ Name = "UTC+5", Value="+5:00" },
        new TimeZoneVariant(){ Name = "UTC+6", Value="+6:00" },
        new TimeZoneVariant(){ Name = "UTC+7", Value="+7:00" },
        new TimeZoneVariant(){ Name = "UTC+8", Value="+8:00" },
        new TimeZoneVariant(){ Name = "UTC+9", Value="+9:00" },
        new TimeZoneVariant(){ Name = "UTC+10", Value="+10:00" },
        new TimeZoneVariant(){ Name = "UTC+11", Value="+11:00" },
        new TimeZoneVariant(){ Name = "UTC+12", Value="+12:00" },
    };

    
}
