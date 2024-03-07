using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
	public class Accesorios
	{
		[Key]
		public int AccesoriosId { get; set; }
		[Required(ErrorMessage = "Es requerido")]
		public string? Descripcion { get; set; }
	}
}
