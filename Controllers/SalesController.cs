using System.Threading.Tasks;
using AutoMapper;
using EYCaseStudy.API.Core;
using EYCaseStudy.API.Dtos;
using EYCaseStudy.API.Models;
using EYCaseStudy.API.Persistance;
using Microsoft.AspNetCore.Mvc;

namespace EYCaseStudy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly ISaleRepository repo;
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public SalesController(ISaleRepository repo, IUnitOfWork uow, IMapper mapper)
        {
            this.repo = repo;
            this.uow = uow;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSale(SaleDTO saleDTO)
        {
            if (!ModelState.IsValid) 
                return BadRequest("Invalid ModelState");

            var sale = mapper.Map<SaleDTO, Sale>(saleDTO);
            repo.Add(sale);
            await uow.CompleteAsync();
            return Ok();
        }


    }
}