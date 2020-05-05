using System;
using System.Linq.Expressions;
using System.Reflection;
using Umbraco.Core;

namespace MGD.Umbraco.Cms.Core.Helpers
{
    public static class Infer
    {
        public static string Property<T>(Expression<Func<T, object>> property)
        {
            var memberExpression = property.Body as MemberExpression ?? ((UnaryExpression)property.Body).Operand as MemberExpression;
            if (memberExpression == null)
                throw new ArgumentException("The lambda expression 'property' should point to a valid Property");

            var propertyInfo = memberExpression.Member as PropertyInfo;
            if (propertyInfo == null)
                throw new ArgumentException("The lambda expression 'property' should point to a valid Property");

            return propertyInfo.Name.ToFirstLower();
        }
    }
}