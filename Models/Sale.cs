namespace EYCaseStudy.API.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public string ProductLine { get; set; }
        public string BusinessUnit { get; set; }
        public int QuantitySold { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; private set; }
        public int LegalEntityId { get; set; }  
        public LegalEntity LegalEntity { get; set; }
        public int PeriodId { get; set; }
        public Period Period { get; set; }

    }
}