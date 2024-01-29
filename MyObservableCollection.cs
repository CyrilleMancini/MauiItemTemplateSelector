using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace MauiItemTemplateSelector
{
    public class MyObservableCollection<T> : ObservableCollection<T>
    {

        public void AddRange(IEnumerable<T> items)
        {
            CheckReentrancy();
            foreach (var item in items)
                Items.Add(item);
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }
    }


}
