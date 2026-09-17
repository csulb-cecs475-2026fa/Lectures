using CompositionEmployees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionEmployees {
	public class Employee {
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName => FirstName + " " + LastName;
		public DateTime StartDate {get; set;}
		
		public ICompensation Compensation { get; set; } = new TenureCompensation();

		public Employee(int id, string first, string last, DateTime startDate) {
			Id = id;
			FirstName = first;
			LastName = last;
			StartDate = startDate;
		}
		
		public decimal GetMonthlyWage() {
			return Compensation.GetWages(this);
		}
	}
}
