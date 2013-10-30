using System;
using System.Linq.Expressions;

namespace MyDotNetBin.Utils
{
    /// <summary>
    /// A class of utility methods that are too small to have classes of their own
    /// </summary>
    public static class Utility
    {
        /// <summary>
        /// Get the name of a varaible as a string
        /// </summary>
        /// <param name="f">A lambda expression that passes the variable</param>
        /// <returns>The name of the variable</returns>
        public static string GetVariableName(Expression<Func<string, object>> f)
        {
            return ((f.Body as MemberExpression).Member.Name);
        }
    }
}
