using System;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Xml.Serialization;
using WorkCalendarCreator.Models;

namespace WorkCalendarCreator.Services
{
    public class CalendarGenerator
    {
        public CalendarGenerator() 
        {
        
        }
        public async Task<string> GenerateCalendar(ConstructorSettings settings, HashSet<DateTime> weekends, HashSet<DateTime> holidays)
        {

            ResultCalendarModel result = new ResultCalendarModel();
            result.Year = settings.Year;

            foreach (var weekend in weekends.OrderBy(d => d).ToList())
            {
                string resultData = String.Empty;

                switch (settings.DateFormat.NameKey)
                {
                    case "TimestampS":
                        resultData = ConvertToTimeStampS(weekend);
                        break;
                    case "TimestampMS":
                        resultData = ConvertToTimeStampMS(weekend);
                        break;
                    case "ISO8601":
                        resultData = ConvertToTimeStampISO8601(weekend,settings.TimeZone);
                        break;
                    default:
                        resultData = CalculateOtherFormats(weekend, settings.DateFormat.Value);
                        break;
                }
                result.Weekends.Add(resultData);
            }
            foreach (var holiday in holidays.OrderBy(d => d).ToList())
            {
                string resultData = String.Empty;

                switch (settings.DateFormat.NameKey)
                {
                    case "TimestampS":
                        resultData = ConvertToTimeStampS(holiday);
                        break;
                    case "TimestampMS":
                        resultData = ConvertToTimeStampMS(holiday);
                        break;
                    case "ISO8601":
                        resultData = ConvertToTimeStampISO8601(holiday, settings.TimeZone);
                        break;
                    default:
                        resultData = CalculateOtherFormats(holiday, settings.DateFormat.Value);
                        break;
                }
                result.Holidays.Add(resultData);
            }
            return FormatSerializer(result, settings.ExportFormat);
        }
        private string CalculateOtherFormats(DateTime date, string format)
        {
            return date.ToString(format);
        }
        private string ConvertToTimeStampS(DateTime date)
        {
            var offset = new DateTimeOffset(date);
            long timestampS = offset.ToUnixTimeSeconds();
            return timestampS.ToString();
        }
        private string ConvertToTimeStampMS(DateTime date)
        {
            var offset = new DateTimeOffset(date);
            long timestampMS = offset.ToUnixTimeSeconds() * 1000 + offset.Millisecond;
            return timestampMS.ToString();
        }
        private string ConvertToTimeStampISO8601(DateTime date, TimeZoneVariant timeZoneVariant)
        {
            return date.ToString("yyyy-MM-ddTHH:mm:ss") + timeZoneVariant.Value;
        }

        private string FormatSerializer(ResultCalendarModel result, ExportFormat exportFormat)
        {
            var data = String.Empty;
            if (exportFormat.NameKey == "JSON")
            {
                var options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping, 
                    WriteIndented = true
                };
                data = JsonSerializer.Serialize(result, options);
            }
            if (exportFormat.NameKey == "XML")
            {
                var serializer = new XmlSerializer(typeof(ResultCalendarModel));
                using (var stringWriter = new StringWriter())
                {
                    serializer.Serialize(stringWriter, result);
                    data = stringWriter.ToString();
                }
                
            }
            if (exportFormat.NameKey == "CSV")
            {
                int maxCount = Math.Max(result.Weekends.Count, result.Holidays.Count);

                var lines = new List<string>
                {
                    "Weekends,Holidays"
                };

                for (int i = 0; i < maxCount; i++)
                {
                    string weekend = i < result.Weekends.Count ? result.Weekends[i]: "";
                    string holiday = i < result.Holidays.Count ? result.Holidays[i]: "";
                    lines.Add($"{weekend},{holiday}");
                }

                data = string.Join(Environment.NewLine, lines);
            }
            return data;
        }
        
    }
}
