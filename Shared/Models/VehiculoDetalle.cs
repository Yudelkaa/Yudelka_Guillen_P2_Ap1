﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
	public class VehiculoDetalle
	{
		[Key]
		public int Id { get; set; }
		[ForeignKey("Vehiculo")]
		public int VehiculoId { get; set; }
		[ForeignKey("Accesorios")]
		public int AccesorioId { get; set; }
		[Required(ErrorMessage = "Es requerido")]
		public double Valor { get; set; }
	
	}
	
}
