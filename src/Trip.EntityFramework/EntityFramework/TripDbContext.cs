﻿using System.Data.Common;
using Abp.Zero.EntityFramework;
using Trip.Authorization.Roles;
using Trip.Authorization.Users;
using Trip.MultiTenancy;

namespace Trip.EntityFramework
{
    public class TripDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public TripDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in TripDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of TripDbContext since ABP automatically handles it.
         */
        public TripDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public TripDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public TripDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
