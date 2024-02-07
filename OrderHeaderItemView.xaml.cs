namespace MauiItemTemplateSelector;

public partial class OrderHeaderItemView : ContentView
{


    public OrderHeaderItemList HeaderItem
    {
        get { return (OrderHeaderItemList)GetValue(HeaderItemProperty); }
        set { SetValue(HeaderItemProperty, value); }
    }

    public static void HeaderItemChangedChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (newValue != oldValue && newValue != null)
            bindable.BindingContext = newValue;
    }

    public Color ColorConverter => HeaderItem.ColorConverter;

    public static readonly BindableProperty HeaderItemProperty =
        BindableProperty.Create(nameof(HeaderItem), typeof(OrderHeaderItemList), typeof(OrderHeaderItemView), null, BindingMode.Default, null, HeaderItemChangedChanged);

    public OrderHeaderItemView()
    {
        InitializeComponent();
    }
}