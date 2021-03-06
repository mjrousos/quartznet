﻿namespace Quartz.Tests.Integration
{
    public static class TestConstants
    {
#if NETCORE
        public const string DefaultSerializerType = "json";
#else
        public const string DefaultSerializerType = "binary";
#endif

#if NETSTANDARD15_DBPROVIDERS
        public const string DefaultSqlServerProvider = "SqlServer-41";
#else
        public const string DefaultSqlServerProvider = "SqlServer-20";
#endif
    }
}