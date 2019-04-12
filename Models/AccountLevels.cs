namespace EYCaseStudy.API.Models
{
    public class AccountLevels
    {
        public string Name { get; set; }
        public AccountLevels Child { get; set; }
    }
}