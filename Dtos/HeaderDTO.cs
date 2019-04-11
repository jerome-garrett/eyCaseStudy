namespace EYCaseStudy.API.Dtos
{
    public class HeaderDTO
    {
        public string Product { get; set; }
        public string ProductLine { get; set; }
        public string BusinessUnit { get; set; }
        public string Name { get; set; }

        public HeaderDTO(string product, string productLine, string businessUnit, string name)
        {
            Product = product;
            ProductLine = productLine;
            BusinessUnit = businessUnit;
            Name = name;

        }
    }
}