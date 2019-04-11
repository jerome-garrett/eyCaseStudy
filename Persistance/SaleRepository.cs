using EYCaseStudy.API.Core;
using EYCaseStudy.API.Models;

namespace EYCaseStudy.API.Persistance
{
    public class SaleRepository : ISaleRepository
    {
        private readonly DataContext context;

        public SaleRepository(DataContext context)
        {
            this.context = context;
        }
        public void Add(Sale sale)
        {
            context.Sales.Add(sale);
        }
    }
}