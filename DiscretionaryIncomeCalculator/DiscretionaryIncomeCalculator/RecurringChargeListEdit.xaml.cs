using DiscretionaryIncomeCalculator.ViewModel;

namespace DiscretionaryIncomeCalculator;

public partial class RecurringChargeListEdit : ContentPage
{
	public RecurringChargeListEdit(RecurringChargeListEditViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}