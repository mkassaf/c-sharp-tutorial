using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TodoItemApp.Model;

namespace TodoItemApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        public void CompleteCheckboxChanged(System.Object sender, Xamarin.Forms.CheckedChangedEventArgs e)
        {
            var cb = (CheckBox)sender;
            var updatedTodoIteam = (TodoItem)cb.BindingContext;

            Console.WriteLine($" Complete {updatedTodoIteam.Complete}");

            App.Database.UpdateTodoIteamAsync(updatedTodoIteam);

        }

        public void NewTodoListChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            todoInput.Text = String.Empty;
        }

    }


}
