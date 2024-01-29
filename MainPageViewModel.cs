using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiItemTemplateSelector
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<object> itemsList = new ObservableCollection<object>();

        Random random = new Random();
        public MainPageViewModel()
        {
        }

        [RelayCommand]
        private void FillWithHeaders()
        {
            ItemsList.Clear();
            List<OrderHeaderItemList> liste = new List<OrderHeaderItemList>();
            for (int i = 0; i < random.Next(20); i++)
            {
                ItemsList.Add(new OrderHeaderItemList($"Order{i}"));
            }
            //ItemsList.AddRange(liste);
        }
        [RelayCommand]
        private void FillWithLines()
        {
            ItemsList.Clear();
            List<OrderLineItemList> liste = new List<OrderLineItemList>();
            for (int i = 0; i < random.Next(20); i++)
            {
                ItemsList.Add(new OrderLineItemList($"OrderLine{i}", $"Bill{i}"));
            }
            //ItemsList.AddRange(liste);
        }
    }
}