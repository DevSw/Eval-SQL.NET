﻿// Description: Evaluate C# code and expression in T-SQL stored procedure, function and trigger.
// Website & Documentation: https://github.com/zzzprojects/Eval-SQL.NET
// Forum: https://zzzprojects.uservoice.com/forums/328452-eval-sql-net
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;

namespace Z.Expressions
{
    public partial class EvalContext
    {
        /// <summary>Unregisters specified types using Type.Name and Type.FullName as alias.</summary>
        /// <param name="types">A variable-length parameters list containing types to unregister.</param>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext UnregisterType(params Type[] types)
        {
            foreach (var type in types)
            {
                Type outType;

                AliasTypes.TryRemove(type.Name, out outType);
                AliasTypes.TryRemove(type.FullName, out outType);
            }
            return this;
        }
    }
}