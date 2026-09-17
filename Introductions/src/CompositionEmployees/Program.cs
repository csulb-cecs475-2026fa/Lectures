namespace CompositionEmployees {
	internal class Program {
		static void Main(string[] args) {
			Employee e = new Employee(1, "Neal", "Terrell", DateTime.Today) {
				Compensation = new HourlyCompensation(20, 30)
			};
			Console.WriteLine(e.GetMonthlyWage());

			// later on, e gets promoted.
			e.Compensation = new CommissionCompensation(0.1m, 100_000, 10_000);
			Console.WriteLine(e.GetMonthlyWage());
		}
	}
}
