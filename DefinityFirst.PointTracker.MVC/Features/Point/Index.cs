using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using DefinityFirst.PointTracker.MVC.Services;

namespace DefinityFirst.PointTracker.MVC.Features.Point
{
    public class Index
    {
        public class Query : IRequest<List<Model>>
        {
        }

        public class Model
        {
            public string Name { get; set; }

            public int Amount { get; set; }

            public int Type { get; set; }

            public int Id { get; set; }

            public bool Enabled { get; set; }

            public bool VisibleForEmployees { get; set; }
        }

        public class QueryHandler : IAsyncRequestHandler<Query, List<Model>>
        {
            private readonly ICatalogService _catalogService;

            public QueryHandler(ICatalogService catalogService)
            {
                _catalogService = catalogService;
            }

            public async Task<List<Model>> Handle(Query message)
            {
                return await _catalogService.GetPointTypes();
            }
        }
    }
}