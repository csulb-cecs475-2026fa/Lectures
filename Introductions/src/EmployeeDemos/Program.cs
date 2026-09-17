namespace Cecs475.Employees {
	internal class Program {
		static void Main(string[] args) {
			Employee e1 = new CommissionEmployee(1, "Neal", "Terrell", DateTime.Today,
				1000, 0.1m, 100_000);
			Employee e2 = new HourlyEmployee(1, "Claus", "Jurgensen", DateTime.Today,
				25.0m, 100m);
			Employee e3 = new Employee(1, "Shannon", "Cleary", new DateTime(2015, 1, 31));

			Console.WriteLine(e1.FullName);
			Console.WriteLine(e1.GetMonthlyWage());
			Console.WriteLine(e2.FullName);
			Console.WriteLine(e2.GetMonthlyWage());
			Console.WriteLine(e3.FullName);
			Console.WriteLine(e3.GetMonthlyWage());
		}
	}
}
