﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Entities;

namespace Tienda.DataAccess
{
    public class TiendaDBContext: DbContext
    {
        //install-package EntityFramework

        public TiendaDBContext(): base("name=connx") { }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
