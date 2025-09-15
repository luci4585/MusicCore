using Microsoft.EntityFrameworkCore;
using Service.Models;

namespace Backend.DataContext
{
    public class MusicCoreContext : DbContext
    {
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Disco> Discos { get; set; }
        public DbSet<Cancion> Canciones { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DiscoVenta> DiscosVentas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public MusicCoreContext(){ }
        public MusicCoreContext(DbContextOptions<MusicCoreContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Clave primaria compuesta para DiscoVenta
            modelBuilder.Entity<DiscoVenta>()
                .HasKey(dv => new { dv.VentaId, dv.DiscoId });

            modelBuilder.Entity<DiscoVenta>()
                .HasOne(dv => dv.Venta)
                .WithMany(v => v.DiscoVentas)
                .HasForeignKey(dv => dv.VentaId);

            modelBuilder.Entity<DiscoVenta>()
                .HasOne(dv => dv.Disco)
                .WithMany(d => d.DiscoVentas)
                .HasForeignKey(dv => dv.DiscoId);

            //Cargamos datos iniciales de artistas de musica
            modelBuilder.Entity<Artista>().HasData(
                new Artista { ArtistaId = 1, Nombre = "The Beatles" },
                new Artista { ArtistaId = 2, Nombre = "Michael Jackson" },
                new Artista { ArtistaId = 3, Nombre = "Madonna" }
            );

            //Cargamos datos iniciales de generos musicales
            modelBuilder.Entity<Genero>().HasData(
                new Genero { GeneroId = 1, Nombre = "Rock" },
                new Genero { GeneroId = 2, Nombre = "Pop" },
                new Genero { GeneroId = 3, Nombre = "Jazz" }
            );

            //Cargamos datos iniciales de discos
            modelBuilder.Entity<Disco>().HasData(
                new Disco { DiscoId = 1, Titulo = "Abbey Road", ArtistaId = 1, GeneroId = 1 },
                new Disco { DiscoId = 2, Titulo = "Thriller", ArtistaId = 2, GeneroId = 2 },
                new Disco { DiscoId = 3, Titulo = "Like a Virgin", ArtistaId = 3, GeneroId = 2 }
            );

            //Cargamos datos iniciales de canciones
            modelBuilder.Entity<Cancion>().HasData(
                new Cancion { CancionId = 1, Titulo = "Come Together", Duracion = 4.20M, DiscoId = 1 },
                new Cancion { CancionId = 2, Titulo = "Billie Jean", Duracion = 4.54M, DiscoId = 2 },
                new Cancion { CancionId = 3, Titulo = "Material Girl", Duracion = 4.00M, DiscoId = 3 }
            );

            //Cargamos datos iniciales de clientes
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { ClienteId = 1, Nombre = "Juan Perez", Email = "perezJuan@gmail.com" },
                new Cliente { ClienteId = 2, Nombre = "Maria Gomez", Email = "gomezMaria@gmail.com" },
                new Cliente { ClienteId = 3, Nombre = "Carlos Sanchez", Email = "sanchezCarlos@gmail.com" }
            );

            //Cargamos datos iniciales de ventas
            modelBuilder.Entity<Venta>().HasData(
                new Venta { VentaId = 1, Fecha = DateTime.Now, Precio = 95000, Cantidad = 1, ClienteId = 1, DiscoId = 1 },
                new Venta { VentaId = 2, Fecha = DateTime.Now, Precio = 70000, Cantidad = 2, ClienteId = 2, DiscoId = 2 },
                new Venta { VentaId = 3, Fecha = DateTime.Now, Precio = 80000, Cantidad = 1, ClienteId = 3, DiscoId = 3 }
            );


            modelBuilder.Entity<Artista>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Genero>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Disco>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Cancion>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Cliente>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Venta>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<DiscoVenta>().HasQueryFilter(p => !p.IsDeleted);
        }
        public DbSet<Service.Models.DiscoVenta> DiscoVenta { get; set; } = default!;
        public DbSet<Service.Models.Usuario> Usuario { get; set; } = default!;
    }
}
