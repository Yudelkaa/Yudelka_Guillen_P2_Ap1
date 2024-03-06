using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
	public class Vehiculo
	{
		[Key]
		public int VehiculoId { get; set; }
		[Required(ErrorMessage = "Es requerido")]
		public string? Descripcion { get; set; }
		[Required(ErrorMessage = "Es requerido")]
		public DateTime Fecha { get; set; } = DateTime.Now;
		
		[Range(0.1, double.MaxValue, ErrorMessage = "Debe ser mayor a cero")]
		public double Costo { get; set; }
		[Range(0.1, double.MaxValue, ErrorMessage = "Debe ser mayor a cero")]
		public double Gastos { get; set; }

		[ForeignKey("VehiculoId")]
		public ICollection<VehiculoDetalle> VehiculoDetalle { get; set; } = new List<VehiculoDetalle>();
	}
}
