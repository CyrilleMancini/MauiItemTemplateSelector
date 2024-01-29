using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace MauiItemTemplateSelector
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count == 0)
                return;
            else if (e.CurrentSelection[0] is OrderHeaderItemList i)
            {

            }
            else if (e.CurrentSelection[0] is OrderLineItemList j)
            { }
        }
    }


}
