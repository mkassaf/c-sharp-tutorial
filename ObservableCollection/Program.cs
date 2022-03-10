using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ObservableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<string> list = new ObservableCollection<string>();

            list.CollectionChanged += CollectionAddChanged;

            list.CollectionChanged += CollectionRemoveChanged;

            list.Add("Sami");

            list.Add("Rami");

            list.Add("Omar");


            list.Remove("Rami");

            //list.Move()
            //list. repalce

            list.Clear();


        }

        private static void CollectionAddChanged(object sender, NotifyCollectionChangedEventArgs e)
        {

            if (e.Action.Equals(NotifyCollectionChangedAction.Add))
            {


                ObservableCollection<string> list = (ObservableCollection<string>)sender;

                Console.WriteLine($" The new element is {e.NewItems[0]}");
                Console.WriteLine($"Total count now after add:  {list.Count }");
            }
        }

        private static void CollectionRemoveChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
           

            if (e.Action.Equals(NotifyCollectionChangedAction.Remove))
            {

                ObservableCollection<string> list = (ObservableCollection<string>)sender;

                Console.WriteLine($"Removed element is:  {e.OldItems.Count }");
                Console.WriteLine($"Total count now after add:  {list.Count }");
            }
            else if (e.Action.Equals(NotifyCollectionChangedAction.Reset))
            {
                Console.WriteLine($"Cleared element");
            }


        }
    }
}
