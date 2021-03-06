﻿using System;
using Microsoft.AspNet.Identity.Entity;
using Microsoft.Data.Entity;
using Microsoft.Framework.OptionsModel;

namespace MusicStore.Models
{
    public class ApplicationUser : User { }

    public class ApplicationDbContext : IdentitySqlContext<ApplicationUser>
    {
        public ApplicationDbContext(IServiceProvider serviceProvider, IOptionsAccessor<IdentityDbContextOptions> optionsAccessor)
                   : base(serviceProvider, optionsAccessor.Options)
        {
        }
    }

    public class IdentityDbContextOptions : DbContextOptions
    {
        public string DefaultAdminUserName { get; set; }

        public string DefaultAdminPassword { get; set; }
    }
}