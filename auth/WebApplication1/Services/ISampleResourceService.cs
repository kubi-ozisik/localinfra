using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public interface ISampleResourceService
    {
        Task<List<SampleResource>> List();
    }

    public class SampleResourceService : ISampleResourceService
    {
   
        public async Task<List<SampleResource>> List()
        {
            var resources = await Task.FromResult(new List<SampleResource>());
            return resources;
        }
    }
}
