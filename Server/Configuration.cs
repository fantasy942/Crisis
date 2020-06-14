using System;

namespace Crisis
{
    public static class Configuration
    {
        public static int Port { get; private set; } = 4242;
        public static string DatabasePath { get; private set; } = @"Data\CrisisDatabase.db";
        public static TimeSpan SaveInterval { get; private set; } = TimeSpan.FromMinutes(1);
    }
}
