using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DapperASPNetCore.Entities;

public class Payback
	{
		public int BrokerId { get; set; }
		public string BrokerName { get; set; }
		public int ProjectId { get; set; }
		public Decimal InversionInicial { get; set; }
		public Decimal SumaFlujos { get; set; }
		public int CantidadPeridos { get; set; }
		public Decimal FlujoCajaAñosAntesRecuperar { get; set; }
		public Decimal payback { get; set; }

	}