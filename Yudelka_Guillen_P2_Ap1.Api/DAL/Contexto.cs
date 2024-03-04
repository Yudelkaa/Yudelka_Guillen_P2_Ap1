using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace Yudelka_Guillen_P2_Ap1.Api.DAL;

public class Contexto : DbContext
{
	public Contexto(DbContextOptions<Contexto> options) : base(options) { }
	public DbSet<Vehiculo> Vehiculo { get; set; }
	public DbSet<VehiculoDetalle> VehiculoDetalle { get; set; }

}
