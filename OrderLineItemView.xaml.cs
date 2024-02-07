namespace MauiItemTemplateSelector;

public partial class OrderLineItemView : ContentView
{
    public OrderLineItemList LineItem
    {
        get { return (OrderLineItemList)GetValue(LineItemProperty); }
        set { SetValue(LineItemProperty, value); }
    }

    public static void HeaderItemChangedChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (newValue != oldValue && newValue != null)
            bindable.BindingContext = newValue;
    }

    public static readonly BindableProperty LineItemProperty =
        BindableProperty.Create(nameof(LineItem), typeof(OrderLineItemList), typeof(OrderLineItemView), null, BindingMode.Default, null, HeaderItemChangedChanged);

    public OrderLineItemView()
	{
		InitializeComponent();
	}
}