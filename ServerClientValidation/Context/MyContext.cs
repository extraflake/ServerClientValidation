﻿using ServerClientValidation.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServerClientValidation.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyConnection")
        {

        }

        public DbSet<Supplier> Suppliers { get; set; }
    }
}