using System;
using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Data;

public class SpecificationEvaluator<T> where T : BaseEntity
{
    //Applies filtering criteria, Returns modified IQueryable with all specifications applied
    public static IQueryable<T> GetQuery(IQueryable<T> query,
     ISpecification<T> spec){
        if(spec.Criteria != null){
            query = query.Where(spec.Criteria);
        }
        
        if(spec.OrderBy != null){
            query = query.OrderBy(spec.OrderBy);
        }
        if (spec.OrderByDescending != null)
        {
            query = query.OrderByDescending(spec.OrderByDescending);
        }
        return query;
    }
}
