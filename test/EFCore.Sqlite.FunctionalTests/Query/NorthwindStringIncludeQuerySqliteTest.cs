﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Sqlite.Internal;
using Microsoft.EntityFrameworkCore.TestUtilities;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.EntityFrameworkCore.Query
{
    public class NorthwindStringIncludeQuerySqliteTest : NorthwindStringIncludeQueryTestBase<NorthwindQuerySqliteFixture<NoopModelCustomizer>>
    {
        public NorthwindStringIncludeQuerySqliteTest(NorthwindQuerySqliteFixture<NoopModelCustomizer> fixture, ITestOutputHelper testOutputHelper)
            : base(fixture)
        {
            //TestSqlLoggerFactory.CaptureOutput(testOutputHelper);
        }

        public override async Task Include_collection_with_cross_apply_with_filter(bool async)
            => Assert.Equal(
                SqliteStrings.ApplyNotSupported,
                (await Assert.ThrowsAsync<InvalidOperationException>(
                    () => base.Include_collection_with_cross_apply_with_filter(async))).Message);

        public override async Task Include_collection_with_outer_apply_with_filter(bool async)
            => Assert.Equal(
                SqliteStrings.ApplyNotSupported,
                (await Assert.ThrowsAsync<InvalidOperationException>(
                    () => base.Include_collection_with_outer_apply_with_filter(async))).Message);

        public override async Task Include_collection_with_outer_apply_with_filter_non_equality(bool async)
            => Assert.Equal(
                SqliteStrings.ApplyNotSupported,
                (await Assert.ThrowsAsync<InvalidOperationException>(
                    () => base.Include_collection_with_outer_apply_with_filter_non_equality(async))).Message);
    }
}
