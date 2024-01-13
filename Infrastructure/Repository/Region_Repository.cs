﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WeatherApp.AppCore.DTO;
using WeatherApp.AppCore.Models;
using WeatherApp.Infrastructure.Data;

namespace WeatherApp.Infrastructure.Repository
{
    public class Region_Repository : AbstractRepository<RegionDTO>
    {
        public Region_Repository(Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override async Task<RegionDTO> AddInstanceAsync(RegionDTO regDTO)
        {
            Region region = new();
            region = _mapper.Map<Region>(regDTO);   
            _context.Region.Add(region);
            await _context.SaveChangesAsync();
            return regDTO;

        }

        public override async Task<RegionDTO> GetInstanceAsync(Guid Id)
        {
            Region instance = await _context.Region.FirstOrDefaultAsync(e => e.Reg_Id == Id);
            RegionDTO dto = _mapper.Map<RegionDTO>(instance);
            return dto;
        }

        public override async Task<IEnumerable<RegionDTO>> GetIEnumerableAsync()
        {
            List<Region> regions = await _context.Region.ToListAsync();
            List<RegionDTO> dto = _mapper.Map<List<RegionDTO>>(regions);
            return dto;
        }

        public override async Task<List<RegionDTO>> GetListAsync()
        {
            List<Region> regions = await _context.Region.ToListAsync();
            List<RegionDTO> dto = _mapper.Map<List<RegionDTO>>(regions);
            return dto;
        }
    }
}
