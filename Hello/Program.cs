using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<string> collection = new ObservableCollection<string>();
            collection.CollectionChanged += CollectionChanged;

            collection.Add("C");
            collection.Add("C++");
            collection.Add("Python");
            collection.Add("C#");
            collection.Add("Java");

            collection.Remove("C++");
            collection.Remove("Python");
        }

        private static void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            ObservableCollection<string> collection = (ObservableCollection<string>)sender;
            Console.WriteLine($"sender {e.Action}");

            if(e.Action.Equals(NotifyCollectionChangedAction.Add))
            {
                Console.WriteLine($"NewItems {e.NewStartingIndex}");
                Console.WriteLine($"Add iteam {collection[e.NewStartingIndex]}");
            }
            else if (e.Action.Equals(NotifyCollectionChangedAction.Remove))
            {
                Console.WriteLine($"REMOVED INDEX {e.OldStartingIndex}");
                Console.WriteLine($"Removed index {e.OldItems[e.OldStartingIndex-1]}");
            }


        }
    }
}
