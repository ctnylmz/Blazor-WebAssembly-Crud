namespace WebApp.Areas.Admin.Models
{
    public class ProductViewModel
    {
        public int id { get; set; }
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public string imageUrl { get; set; }
        public Boolean status { get; set; }
        public List<CategoryViewModel>? Categories { get; set; }
    }
}