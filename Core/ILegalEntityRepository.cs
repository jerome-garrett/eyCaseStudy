using System.Collections.Generic;
using System.Threading.Tasks;
using EYCaseStudy.API.Dtos;

namespace EYCaseStudy.API.Core
{
    public interface ILegalEntityRepository
    {
         IEnumerable<PivotTableDTO> GetPivotTable(int id);
    }
}