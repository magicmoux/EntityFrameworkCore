﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Design;

namespace Microsoft.EntityFrameworkCore.Scaffolding
{
    /// <summary>
    ///     A service typically implemented by database providers to generate code fragments
    ///     for reverse engineering.
    /// </summary>
    public interface IProviderCodeGenerator
    {
        /// <summary>
        ///     Generates a code fragment like <c>.UseSqlServer("Database=Foo")</c> which can be used in
        ///     the <see cref="DbContext.OnConfiguring" /> method of the generated DbContext.
        /// </summary>
        /// <param name="connectionString"> The connection string to include in the code fragment. </param>
        /// <returns> The code fragment. </returns>
        MethodCallCodeFragment GenerateUseProvider([NotNull] string connectionString);
    }
}
