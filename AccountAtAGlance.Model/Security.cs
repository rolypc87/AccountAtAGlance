using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountAtAGlance.Model
{
	public  abstract class Security
	{
		// Primitive Properties
		public int Id { get; set; }
		public decimal Change { get; set; }
		public decimal PercentageChange { get; set; }
		public decimal Last { get; set; }
		public decimal Shares { get; set; }
		public DateTime RetrivalDateTime { get; set; }
		public string Company { get; set; }

		//Additional Properties, not in DB
		public List<DataPoint> DataPoints { get; set; }
	}
}
