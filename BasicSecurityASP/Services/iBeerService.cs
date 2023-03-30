using BasicSecurityASP.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BasicSecurityASP.Services
{
    public interface iBeerService
    {
        public Task<List<Beer>> Get(); 
    }
}
