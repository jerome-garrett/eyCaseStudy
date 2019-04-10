namespace EYCaseStudy.API.Dtos
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductLine { get; set; }
        public string BusinessUnit { get; set; }
        public int QuantitySold { get; set; }
        public decimal UnitPrice { get; set; }
        public int LegalEntityId { get; set; }  
        public int PeriodId { get; set; }
    }
}