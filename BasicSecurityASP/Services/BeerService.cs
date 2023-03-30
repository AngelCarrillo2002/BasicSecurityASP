using BasicSecurityASP.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace BasicSecurityASP.Services
{
    public class BeerService: iBeerService
    {
        string path = "C:\\Users\\a892976\\source\\repos\\BasicSecurityASP\\BasicSecurityASP\beers.json";
    
        public async Task<List<Beer>> Get()
        {
            string content = await File.ReadAllTextAsync(path);
            var beers = JsonSerializer.Deserialize<List<Beer>>(content);
            return beers;
        }
            
    }
}
