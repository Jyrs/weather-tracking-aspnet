using WeatherApp.Infrastructure.Data;
using AutoMapper;

namespace WeatherApp.Infrastructure.Repository
{
    public abstract class AbstractRepository<T>
    {
        protected readonly Context _context;
        protected readonly IMapper _mapper;
        public AbstractRepository(Context context, IMapper mapper) { 
            _context = context;
            _mapper = mapper;
        }

        public abstract Task<IEnumerable<T>> GetListAsync();
        //public abstract Task<List<T>> GetListAsync();

        public abstract Task<T> GetInstanceAsync(Guid Id);

    }
}
