﻿using System;

namespace Toolbox.DataAccess.Options
{
    public class EntityContextOptions
    {
        public ConnectionString ConnectionString { get; set; } = new ConnectionString();

        public bool LazyLoadingEnabled { get; set; } = Defaults.EntityContextOptions.LazyLoadingEnabled;

        public bool PluralizeTableNames { get; set; } = Defaults.EntityContextOptions.PluralizeTableNames;

        public string DefaultSchema { get; set; } = Defaults.EntityContextOptions.DefaultSchema;

        public bool DisableCascadingDeletes { get; set; } = Defaults.EntityContextOptions.DisableCascadingDeletes;

        public bool ForceLowercase { get; set; } = Defaults.EntityContextOptions.UseLowercaseOnTablesAndFields;


        
    }
}
