using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace Yudelka_Guillen_P2_Ap1.Api.DAL;

public class Contexto : DbContext
{
	public Contexto(DbContextOptions<Contexto> options) : base(options) { }
	public DbSet<Vehiculo> Vehiculo { get; set; }
	public DbSet<Accesorios> Acesorios { get; set; }
	public DbSet<VehiculoDetalle> VehiculoDetalle { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		
		base.OnModelCreating(modelBuilder);
		modelBuilder.Entity<Accesorios>().HasData(
			new Accesorios { AccesoriosId = 1, Descripcion = "Camara Trasera" },
			new Accesorios { AccesoriosId = 2, Descripcion = "Pantalla Interior" },
			new Accesorios { AccesoriosId = 3, Descripcion = "Interior en Piel" },
			new Accesorios { AccesoriosId = 4, Descripcion = "Sun Roof" },
			new Accesorios { AccesoriosId = 5, Descripcion = "Aros de Lujo" }
		);
	}
}


