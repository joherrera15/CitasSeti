using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DapperASPNetCore.Entities;

public class Van
	{
		public int BrokerId { get; set; }
		public string BrokerName { get; set; }
		public int ProjectId { get; set; }
		public Decimal InversionInicial { get; set; }		
		public Decimal VAN { get; set; }

	}