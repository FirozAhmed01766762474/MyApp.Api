﻿namespace MyApp.Core.Options
{
    public class ConnectionStringOptions
    {
        public const string SectionName = "ConnectionStrings";
        public string DefaultConnection { get; set; } = null!;

    }
}
