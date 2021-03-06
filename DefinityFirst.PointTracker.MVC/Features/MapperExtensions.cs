﻿using System.Linq;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using DelegateDecompiler.EntityFramework;
using X.PagedList;

namespace DefinityFirst.PointTracker.MVC.Features
{
    public static class MapperExtensions
    {
        public static Task<IPagedList<TDestination>> ProjectToPagedListAsync<TDestination>(this IQueryable queryable, int pageNumber, int pageSize)
        {
            return queryable.ProjectTo<TDestination>()
                .DecompileAsync()
                .ToPagedListAsync(pageNumber, pageSize);
        }
    }
}
