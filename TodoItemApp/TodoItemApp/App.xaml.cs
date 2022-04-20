using System;
using System.IO;
using TodoItemApp.Database;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoItemApp
{
    public partial class App : Application
    {
        private static MyDatabase database;
        private static readonly String DatabasePath = "myDb.assaf";


        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }


        public static MyDatabase Database {
            get {
                if(database == null)
                {
                    database = new MySqlDatabase(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        DatabasePath)
                        );
                    /*
                    database = new SQLiteDatabase(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        DatabasePath)
                        );

                    */
                }
                return database;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
