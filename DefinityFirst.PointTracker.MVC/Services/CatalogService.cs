using System.Collections.Generic;
using System.Threading.Tasks;
using DefinityFirst.PointTracker.MVC.Features.Point;

namespace DefinityFirst.PointTracker.MVC.Services
{
    public class CatalogService : ICatalogService
    {
        public Task<List<Index.Model>> GetPointTypes()
        {
            return Task.FromResult(new List<Index.Model>()
            {
                new Index.Model
                {
                    Amount = 5,
                    Enabled = true,
                    Id = 1,
                    Name = "Test23",
                    Type = 2,
                    VisibleForEmployees = true
                },
                new Index.Model
                {
                    Amount = 3,
                    Enabled = true,
                    Id = 1,
                    Name = "Test",
                    Type = 2,
                    VisibleForEmployees = true
                },
                new Index.Model
                {
                    Amount = 4,
                    Enabled = true,
                    Id = 1,
                    Name = "Test",
                    Type = 2,
                    VisibleForEmployees = true
                }
            });
        }
    }
}