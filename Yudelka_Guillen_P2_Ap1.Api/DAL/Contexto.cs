using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Shared.Models;
using System.Reflection.Emit;
using Yudelka_Guillen_P2_Ap1.Api.DAL;

namespace Yudelka_Guillen_P2_Ap1.Api.DAL;

public class Contexto : DbContext
{
	public Contexto(DbContextOptions<Contexto> options) : base(options) { }
	public DbSet<Vehiculo> Tickets { get; set; }
	public DbSet<VehiculoDetalle> TicketsDetalles { get; set; }
}
	
	

