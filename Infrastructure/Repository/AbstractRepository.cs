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

        public abstract Task AddInstanceAsync(T obj);

        public abstract Task<bool> Delete(List<T> obj);

        public abstract Task<IEnumerable<T>> GetIEnumerableAsync();
        public abstract Task<List<T>> GetListAsync();
        //public abstract Task<List<T>> GetListAsync();

        public abstract Task<T> GetInstanceAsync(Guid Id);

    }
}
