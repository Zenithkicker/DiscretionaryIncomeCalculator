namespace DiscretionaryIncomeCalculator;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(RecurringChargeListEdit), typeof(RecurringChargeListEdit));
	}
}
