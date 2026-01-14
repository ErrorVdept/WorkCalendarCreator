namespace WorkCalendarCreator.Models
{
    public class ResultCalendarModel
    {
        public int Year { get; set; }
        public List<string> Weekends { get; set; } = new List<string>();
        public List<string> Holidays { get; set; } = new List<string>();
    }
}
