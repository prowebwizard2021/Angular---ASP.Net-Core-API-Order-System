namespace API.DTO
{
    public class MarkupDTO
    {
        public string Type {get;set;}
        public decimal Markup {get;set;}
        public ShortDTO Currency {get;set;}
        public decimal ExchangeRate {get;set;}
    }
}