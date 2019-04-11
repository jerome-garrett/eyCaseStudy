using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EYCaseStudy.API.Core;
using EYCaseStudy.API.Dtos;
using Newtonsoft.Json;

namespace EYCaseStudy.API.Persistance
{
    public class LegalEntityRepository : ILegalEntityRepository
    {
        private readonly DataContext context;

        public LegalEntityRepository(DataContext context)
        {
            this.context = context;
        }
        public IEnumerable<PivotTableDTO> GetPivotTable(int id)
        {
             var result =  context.Sales.Where(x => x.LegalEntityId == id)
                .GroupBy( s => new {s.Product, s.ProductLine, s.BusinessUnit, s.LegalEntity.Name})
                .Select(g => new {
                    Header = g.Key,
                    PeriodOne = g.Where(c => c.Period.StartDate.Month == 1).Sum(c => c.TotalPrice),
                    PeriodTwo = g.Where(c => c.Period.StartDate.Month == 4).Sum(c => c.TotalPrice),
                    PeriodThree = g.Where(c => c.Period.StartDate.Month == 7).Sum(c => c.TotalPrice),
                    PeriodFour = g.Where(c => c.Period.StartDate.Month == 10).Sum(c => c.TotalPrice),
                });

                var data = result.Select( x => new PivotTableDTO {
                    Header = new HeaderDTO(x.Header.Product, x.Header.ProductLine, x.Header.BusinessUnit, x.Header.Name),
                    PeriodOne = x.PeriodOne,
                    PeriodTwo = x.PeriodTwo,
                    PeriodThree = x.PeriodThree,
                    PeriodFour = x.PeriodFour
                }).AsEnumerable();

            return data;
        }
    }
}