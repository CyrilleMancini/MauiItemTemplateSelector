using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiItemTemplateSelector
{
    public partial class OrderLineItemList : ObservableObject
    {
        [ObservableProperty]
        string line;

        public bool IsOdd => line.Length % 2 == 0;

        [ObservableProperty]
        string billOfMaterial = "";

        public OrderLineItemList(string line, string bill)
        {
            this.line = line;
            if (bill == null) return;

        }

        string Id => Line + ".Ean";

        object Item => Line;

        string Col1 => $"{Line}.Position";

        string Col2 => $"{Line}.Designation_1 {Line}.Designation_2";

        string Col3 => $"{Line}.RemainingQuantity".PadLeft(3, ' ');

     public   Color colorConverter => DateTime.Now.Millisecond % 2 == 0 ? Colors.LightGreen : 1 == 0 ? Colors.Red : Colors.Orange;

        public const string Col1Header = "Emplacement";

        public const string Col2Header = "Référence";

        public const string Col3Header = "Quantité";

        public override string ToString()
        {
            return Col2.Substring(0, Math.Min(Col2.Length, 25)) + " " + Col3;
        }
    }


}
