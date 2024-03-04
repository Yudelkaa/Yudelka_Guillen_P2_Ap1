﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
	public class VehiculoDetalle
	{
		public int Id { get; set; }
		[ForeignKey("Vehiculo")]
		public int VehicukoId { get; set; }
		public int AccesorioId { get; set; }
		[Required(ErrorMessage = "Es requerido")]
		public double Valor { get; set; }

	}
}




