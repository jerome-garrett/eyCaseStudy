using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EYCaseStudy.API.Core;
using EYCaseStudy.API.Dtos;
using EYCaseStudy.API.Persistance;
using Microsoft.AspNetCore.Mvc;

namespace EYCaseStudy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LegalEntityController : ControllerBase
    {
        private readonly ILegalEntityRepository repo;

        public LegalEntityController(ILegalEntityRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet("{id}")]
        public IEnumerable<PivotTableDTO> GetData(int id)
        {
           var result =  repo.GetPivotTable(id);
           return result;
        }
    }
}