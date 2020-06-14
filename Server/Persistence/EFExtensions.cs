using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Crisis.Persistence
{
    static class EFExtensions
    {
        /// <summary>
        /// Returns the union of a query made against the server and then against local.
        /// </summary>
        public static IEnumerable<T> IncLocal<T>(this DbSet<T> dbset, Func<IEnumerable<T>, IEnumerable<T>> f) where T : class
        {
            return f(dbset).Union(f(dbset.Local));
        }
    }
}
