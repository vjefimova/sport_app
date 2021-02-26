using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace sport_app
{
    public class grouping<K, T> : ObservableCollection<T>
    {
        public K Name { get; private set; }
        public grouping(K name, IEnumerable<T> items)
        {
            Name = name;
            foreach (T item in items)
                Items.Add(item);
        }
    }
}
