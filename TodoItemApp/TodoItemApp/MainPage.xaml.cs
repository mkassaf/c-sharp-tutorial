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


        public async void CompleteCheckboxChanged(System.Object sender, Xamarin.Forms.CheckedChangedEventArgs e)
        {
            var cb = (CheckBox)sender;
            var newTodoIteam = (TodoItem)cb.BindingContext;

            Console.WriteLine($" Complete {newTodoIteam.Complete}");

        }

        public void NewTodoListChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            todoInput.Text = String.Empty;
        }

        void NewTodoListChanged(Object sender, EventArgs e)
        {
            
        }

        void todoInput_BindingContextChanged(System.Object sender, System.EventArgs e)
        {
            todoInput.Text = String.Empty;
        }
    }


}
