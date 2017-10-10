

using DefinityFirst.PointTracker.MVC.Features.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefinityFirst.PointTracker.MVC.Services
{
    public interface ICatalogService
    {
        Task<List<Index.Model>> GetPointTypes();


    }
}
