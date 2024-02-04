using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.AppCore.DTO;
using WeatherApp.AppCore.Models;
using WeatherApp.Infrastructure.Data;

namespace WeatherApp.Infrastructure.Repository
{
    public class CharacteristicsType_Repository : AbstractRepository<CharacteristicTypeDTO>
    {

        public CharacteristicsType_Repository(Context context, IMapper mapper) : base(context, mapper) { }

        public override Task AddInstanceAsync(CharacteristicTypeDTO obj)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> Delete(List<CharacteristicTypeDTO> obj)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<CharacteristicTypeDTO>> GetIEnumerableAsync()
        {
            throw new NotImplementedException();
        }

        public override Task<CharacteristicTypeDTO> GetInstanceAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public override async Task<List<CharacteristicTypeDTO>> GetListAsync()
        {
            List<CharacteristicType> types = await _context.CharacteristicType.ToListAsync();
            List<CharacteristicTypeDTO> dto = _mapper.Map<List<CharacteristicTypeDTO>>(types);
            return dto;
        }
    }
}
