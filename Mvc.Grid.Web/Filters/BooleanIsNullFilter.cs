using NonFactors.Mvc.Grid;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Mvc.Grid.Web.Filters
{
    public class BooleanIsNullFilter<T> : BaseGridFilter<T>
    {
        public override IQueryable<T> Process(IQueryable<T> items)
        {
            Expression equalsNull = Expression.Equal(FilteredExpression.Body, Expression.Constant(null));

            return items.Where(Expression.Lambda<Func<T, Boolean>>(equalsNull, FilteredExpression.Parameters[0]));
        }
    }
}
