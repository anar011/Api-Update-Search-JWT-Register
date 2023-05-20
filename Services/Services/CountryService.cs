﻿using AutoMapper;
using Domain.Models;
using Repository.Repositories.Interfaces;
using Services.DTOs.Country;
using Services.DTOs.Employee;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepo;
        private readonly IMapper _mapper;


        public CountryService(ICountryRepository countryRepo, IMapper mapper)
        {
            _countryRepo = countryRepo;
            _mapper = mapper;

        }


        public async Task CreateAsync(CountryCreateDto country)=> await _countryRepo.CreateAsync(_mapper.Map<Country>(country));


        public async Task DeleteAsync(int? id) => await _countryRepo.DeleteAsync(await _countryRepo.GetByIdAsync(id));


        public async Task<IEnumerable<CountryDto>> GetAllAsync() => _mapper.Map<IEnumerable<CountryDto>>(await _countryRepo.FindAllAsync());


        public async Task<CountryDto> GetByIdAsync(int? id) => _mapper.Map<CountryDto>(await _countryRepo.GetByIdAsync(id));

    

      

        public async Task UpdateAsync(int? id, CountryUpdateDto country)
        {
            if (id is null) throw new ArgumentNullException();

            var existCountry = await _countryRepo.GetByIdAsync(id) ?? throw new NullReferenceException();

            _mapper.Map(country, existCountry);

            await _countryRepo.UpdateAsync(existCountry);



        }


        public async Task<IEnumerable<CountryDto>> SearchAsync(string? searchText)
        {
            if (string.IsNullOrEmpty(searchText))
                return _mapper.Map<IEnumerable<CountryDto>>(await _countryRepo.FindAllAsync());

            return _mapper.Map<IEnumerable<CountryDto>>(await _countryRepo.FindAllAsync(m => m.Name.Contains(searchText)));
        }


        public async Task SoftDeleteAsync(int? id)
        {
            await _countryRepo.SoftDeleteAsync(id);
        }

    }

}
