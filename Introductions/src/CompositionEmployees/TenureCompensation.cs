using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionEmployees {
	public class TenureCompensation : ICompensation {
		public decimal GetWages(Employee e) {
			decimal baseValue = 50_000;
			decimal yearsOfService = (decimal)(5_000 * (DateTime.Today - e.StartDate).TotalDays / 365);
			return baseValue + yearsOfService;
		}
	}
}
