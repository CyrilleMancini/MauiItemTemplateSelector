using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiItemTemplateSelector
{
    public partial class OrderHeaderItemList :ObservableObject
    {
        [ObservableProperty]
        string order;

        public OrderHeaderItemList(string order)
        {
            this.order = order;
        }

        ~OrderHeaderItemList()
        {
//            order = null;
        }

        public Color ColorConverter => DateTime.Now.Millisecond%2 == 0 ? Colors.LightGreen : 1 == 0 ? Colors.Red : Colors.Orange;


        string Id => order + ".Number";
        object Item => order;

        string Col1 => order + ".Number";

        string Col2 => "";

        string Col3 => ($"{order}.Lines.Count lignes.").PadLeft(14, ' ');

        public string RemainingQuantity => ($"{order}.RemainingQuantity UV(s).").PadLeft(14, ' ');
              
        public const string Col1Header = "N° Expédition";

        public const string Col2Header = "";

        public const string Col3Header = "Nb Lignes";


        public override string ToString()
        {
            return Col1;
        }
    }


}
