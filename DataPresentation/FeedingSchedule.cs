namespace DataPresentation
{
    /// <summary>
    /// Класс для представления данных о расписании кормления
    /// </summary>
    public class FeedingSchedule
    {
        public int id { get; set; } // первичный ключ

        public int CowId { get; set; }
        public string FeedType { get; set; } = string.Empty;
        public DateTime Time { get; set; }
        public double Amount { get; set; }
        public string Unit { get; set; } = string.Empty;
    }
}
