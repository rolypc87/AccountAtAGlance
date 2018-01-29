﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace AccountAtAGlance.Model
{
	public class Position
	{
		//Primitive properties

		public int Id { get; set; }
		public int SecurityId { get; set; }
		public decimal Shares { get; set; }
		public decimal Total { get; set; }
		public int BrokerageAccountId { get; set; }

		//Navigation properties
		public virtual Security Security { get; set; }
	}
}
