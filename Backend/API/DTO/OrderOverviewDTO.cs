namespace API.DTO
{
    public class OrderOverviewDTO
    {
        public string OrderId { get; set; }
        public string Title { get; set; }
        public string Customer { get; set; }
        public string ProductGroup { get; set; }
        public string Season { get; set; }

        public int Id { get; set; }
    }
}