using AutoMapper;
using EYCaseStudy.API.Dtos;
using EYCaseStudy.API.Models;

namespace EYCaseStudy.API.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // domain to api
            CreateMap<Sale, SaleDTO>();

            // api to domain
            CreateMap<SaleDTO, Sale>();
        }
    }
}