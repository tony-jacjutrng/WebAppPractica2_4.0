using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPractica2_4._0.Models;

namespace WebAppPractica2_4._0.Context
{
    public class bdContext : DbContext
    {


        public bdContext(DbContextOptions<bdContext> options) :
          base(options)
        { 

        }

        public DbSet<Ruta> rutas { get; set; }
        public DbSet<menu> menus { get; set; }


    }
}
