namespace WebApp.Areas.Admin.Models
{
    public class BookingViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string mail { get; set; }
        public string personCount { get; set; }
        public DateTime date { get; set; } = DateTime.Now;


    }
}
