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

            // Clave primaria compuesta
            modelBuilder.Entity<DiscoVenta>()
                .HasKey(dv => new { dv.VentaId, dv.DiscoId });

            modelBuilder.Entity<DiscoVenta>()
                .HasOne(dv => dv.Venta)
                .WithMany() // sin ICollection en Venta
                .HasForeignKey(dv => dv.VentaId);

            modelBuilder.Entity<DiscoVenta>()
                .HasOne(dv => dv.Disco)
                .WithMany()
                .HasForeignKey(dv => dv.DiscoId);

            //Cargamos datos iniciales de artistas de musica
            modelBuilder.Entity<Artista>().HasData(
                new Artista { Id = 1, Nombre = "The Beatles" },
                new Artista { Id = 2, Nombre = "Michael Jackson" },
                new Artista { Id = 3, Nombre = "Madonna" }
            );

            //Cargamos datos iniciales de generos musicales
            modelBuilder.Entity<Genero>().HasData(
                new Genero { Id = 1, Nombre = "Rock" },
                new Genero { Id = 2, Nombre = "Pop" },
                new Genero { Id = 3, Nombre = "Jazz" }
            );

            //Cargamos datos iniciales de discos
            modelBuilder.Entity<Disco>().HasData(
                new Disco { Id = 1, Titulo = "Abbey Road", ArtistaId = 1, GeneroId = 1 },
                new Disco { Id = 2, Titulo = "Thriller", ArtistaId = 2, GeneroId = 2 },
                new Disco { Id = 3, Titulo = "Like a Virgin", ArtistaId = 3, GeneroId = 2 }
            );

            //Cargamos datos iniciales de canciones
            modelBuilder.Entity<Cancion>().HasData(
                new Cancion { Id = 1, Titulo = "Come Together", Duracion = 4.20M, DiscoId = 1 },
                new Cancion { Id = 2, Titulo = "Billie Jean", Duracion = 4.54M, DiscoId = 2 },
                new Cancion { Id = 3, Titulo = "Material Girl", Duracion = 4.00M, DiscoId = 3 }
            );

            //Cargamos datos iniciales de clientes
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { Id = 1, Nombre = "Juan Perez", Email = "perezJuan@gmail.com" },
                new Cliente { Id = 2, Nombre = "Maria Gomez", Email = "gomezMaria@gmail.com" },
                new Cliente { Id = 3, Nombre = "Carlos Sanchez", Email = "sanchezCarlos@gmail.com" }
            );

            //Cargamos datos iniciales de ventas
            modelBuilder.Entity<Venta>().HasData(
                new Venta { Id = 1, Fecha = DateTime.Now, Precio = 19.99M, ClienteId = 1, UsuarioId = 1, DiscoId = 1, Cantidad = 1 },
                new Venta { Id = 2, Fecha = DateTime.Now, Precio = 9.99M, ClienteId = 2, UsuarioId = 1, DiscoId = 2,  Cantidad = 1 },
                new Venta { Id = 3, Fecha = DateTime.Now, Precio = 14.99M, ClienteId = 3, UsuarioId = 1, DiscoId = 3,  Cantidad = 1 }
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
