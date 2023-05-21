using AutoMapper;
using Domain.Models;
using Services.DTOs.Account;
using Services.DTOs.City;
using Services.DTOs.Country;
using Services.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<EmployeeCreateDto, Employee>();
            CreateMap<EmployeeUpdateDto, Employee>();


            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<CountryCreateDto, Country>();
            CreateMap<CountryUpdateDto, Employee>();


            CreateMap<RegisterDto, AppUser>();



            CreateMap<City,CityDto>().ReverseMap();
            CreateMap<CityCreateDto, Employee>();
            CreateMap<CityUpdateDto, Employee>();

        }
    }
}
