using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Infrastructure.Data;

namespace WeatherApp.Infrastructure.Repository
{
    internal class AbstractRepository
    {
        private readonly Context _context;
        public AbstractRepository(Context context) { 
            _context = context;
        }


    }
}
