using AutoMapper;
using Domain.Models;
using Repository.Repositories.Interfaces;
using Services.DTOs.City;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CityService : ICityService
    {

        private readonly ICityRepository _cityRepo;
        private readonly IMapper _mapper;



        public CityService(ICityRepository cityRepo, IMapper mapper)
        {
            _cityRepo = cityRepo;
            _mapper = mapper;
        }


        public async Task CreateAsync(CityCreateDto city)=> await _cityRepo.CreateAsync(_mapper.Map<City>(city));
    
        
             

        public Task DeleteAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CityDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CityDto> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CityDto>> SearchAsync(string? searchText)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int? id, CityUpdateDto city)
        {
            throw new NotImplementedException();
        }
    }
}
