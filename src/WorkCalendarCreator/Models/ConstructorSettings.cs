namespace WorkCalendarCreator.Models;

//public record ConstructorSettings()
//{
//    public int Year { get; set; } = DateTime.Now.Year;
//    public string? ReadyProjectFilename { get; set; }
//    public DayOfWeek WeekStart { get; set;  } = DayOfWeek.Monday;
//    public ExportFormat ExportFormat { get; set; }
//    public DateFormat DateFormat { get; set; }
//    public TimeZoneVariant? TimeZone { get; set; }

//}
public record ConstructorSettings(
    int Year,
    string? ReadyProjectFilename,
    DayOfWeek WeekStart,
    ExportFormat ExportFormat,
    DateFormat DateFormat,
    TimeZoneVariant? TimeZone
)
{
    // Можно добавить дефолты через фабричный метод
    public static ConstructorSettings CreateDefault() => new(
        Year: DateTime.Now.Year,
        ReadyProjectFilename: null,
        WeekStart: DayOfWeek.Monday,
        ExportFormat: new ExportFormat() { NameKey = "JSON" }, // ← укажите ваш дефолт
        DateFormat: new DateFormat() { NameKey = "ISO8601", Value = "ISO8601" },  // ← укажите ваш дефолт
        TimeZone: new TimeZoneVariant() { Name = "UTC", Value = "Z" }
    );
}