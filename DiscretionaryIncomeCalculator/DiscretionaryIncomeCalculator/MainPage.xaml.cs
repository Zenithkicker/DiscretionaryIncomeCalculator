using DiscretionaryIncomeCalculator.ViewModel;

namespace DiscretionaryIncomeCalculator;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	private async void btnAddList_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(RecurringChargeListEdit));
	}
}

