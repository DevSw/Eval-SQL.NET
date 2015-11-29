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
        /// <summary>Registers an alias for a variable, constant or type name.</summary>
        /// <exception cref="Exception">Thrown an exception if the alias already exists.</exception>
        /// <param name="alias">The alias to register.</param>
        /// <param name="name">The variable, constant or type name to register for the specified alias.</param>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext RegisterAlias(string alias, string name)
        {
            if (!AliasNames.TryAdd(alias, name))
            {
                throw new Exception(string.Format(ExceptionMessage.UnexpectedAliasRegistered, alias));
            }

            return this;
        }
    }
}