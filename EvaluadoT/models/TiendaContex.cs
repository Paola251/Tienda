using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluadoT.models
{
    public class TiendaContex:DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Ruta automatizada hacia tu archivo MDF local
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string dbPath = Path.Combine(baseDir, "TiendaDB.mdf");

            optionsBuilder.UseSqlServer($@"Data
            Source=(Loca1DB)\MSSQLLoca1DB;AttachDbFilename={dbPath} ; Integrated
            Security-True; TrustServerCertiticate-True");
        }
    }
}
