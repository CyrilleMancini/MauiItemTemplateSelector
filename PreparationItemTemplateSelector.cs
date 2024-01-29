namespace MauiItemTemplateSelector
{
    public class PreparationItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate OrderHeaderTemplate { get; set; }
        public DataTemplate OrderLineTemplate { get; set; }



        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {

            switch (item)
            {
                case OrderHeaderItemList header:
                    return OrderHeaderTemplate;
                case OrderLineItemList Oline:
                    return OrderLineTemplate;
                default:
                    return OrderHeaderTemplate;
            }

        }
    }


}
