namespace API.DTO
{
    public class MarkdownDTO
    {
        public string Type {get;set;}
        public decimal Markdown {get;set;}
        public ShortDTO Currency {get;set;}
        public decimal ExchangeRate {get;set;}
    }
}