using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DiscretionaryIncomeCalculator.Model;
using System.Collections.ObjectModel;

namespace DiscretionaryIncomeCalculator.ViewModel
{
    public partial class RecurringChargeListEditViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<RecurringCharge> recurringCharges;

        [ObservableProperty]
        RecurringCharge recurringCharge;

        public RecurringChargeListEditViewModel()
        {
            RecurringCharges = new ObservableCollection<RecurringCharge>();
            RecurringCharge = new RecurringCharge();
        }

        [RelayCommand]
        void AddItem()
        {
            if (null == RecurringCharge || string.IsNullOrWhiteSpace(RecurringCharge.Name))
                return;

            RecurringCharges.Insert(0,RecurringCharge);
            RecurringCharge = new RecurringCharge();
        }

        [RelayCommand]
        void DeleteItem(string s)
        {
            var r = RecurringCharges.FirstOrDefault(x => x.Name.Equals(s, StringComparison.InvariantCultureIgnoreCase));
            if(null != r)
            {
                RecurringCharges.Remove(r);
            }
        }
    }
}
