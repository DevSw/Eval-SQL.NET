// Description: Evaluate C# code and expression in T-SQL stored procedure, function and trigger.
// Website & Documentation: https://github.com/zzzprojects/Eval-SQL.NET
// Forum: https://zzzprojects.uservoice.com/forums/328452-eval-sql-net
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;

namespace Z.Expressions.SqlServer.Eval
{
    public partial struct SQLNET
    {
        /// <summary>Gets the small int value associated with the specified key.</summary>
        /// <param name="key">The key of the value to get.</param>
        /// <returns>The small int value associated with the specified key.</returns>
        public short? GetValueSmallInt(string key)
        {
            var value = GetValue(key);
            return value == DBNull.Value ? (short?) null : Convert.ToInt16(value);
        }
    }
}