namespace EYCaseStudy.API.Dtos
{
    public class SaleDTO
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public string ProductLine { get; set; }
        public string BusinessUnit { get; set; }
        public int QuantitySold { get; set; }
        public decimal UnitPrice { get; set; }
        public int LegalEntityId { get; set; }  
        public int PeriodId { get; set; }
    }
}