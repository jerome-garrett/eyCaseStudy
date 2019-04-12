namespace EYCaseStudy.API.Models
{
    public class Record
    {
        public string _id { get; set; }
        public string Period { get; set; }
        public double Value { get; set; }
        public string Account { get; set; }
        public AccountLevels AccountLevels { get; set; }
    }
}