using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cecs475.Employees {
	// An employee that is paid based on an hourly wage and the number of hours worked.
	public class HourlyEmployee : Employee {
		public decimal HourlyWage { get; set; }
		public decimal HoursWorked { get; set; }

		public override decimal GetMonthlyWage() {
			return HoursWorked * HourlyWage;
		}

		public HourlyEmployee(int id, string first, string last, DateTime startDate,
			decimal hourlyWage, decimal hoursWorked)
			: base(id, first, last, startDate) {

			HourlyWage = hourlyWage;
			HoursWorked = hoursWorked;
		}
	}
}
