using System;
using System.Collections.Generic;
using Users;


using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClassesInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            AwaitOperator.Main();




        }



        internal void test()
        {

        }
    }
    class File
    {

        private readonly string readOnly = "dddd";
        private string _name; 
        public string Name {
            get
            {
                if (string.IsNullOrWhiteSpace(_name))
                {
                    return "N/A";
                }
                return _name;

            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Value can't be Epmty");
                }
                _name = value;
            }
        }


        public string Path { get; set; }



        public virtual  void SetValues()
        {
            Console.WriteLine("Calling from the super");

        }



    }


    class TextFile : File
    {
        List<int> myList;
        public TextFile()
        {
            Console.WriteLine("Defaul Cont");
            myList = new List<int>();
        }
        public TextFile(int id) : this()
        {
            Console.WriteLine("Param Cont");
        }
        public override void SetValues()
        {
            base.SetValues();

            Console.WriteLine("Calling from child");
        }


    }




}


public class AwaitOperator
{
    public static async Task Main()
    {
        Task<int> downloading = DownloadDocsMainPageAsync();
        Console.WriteLine($"{nameof(Main)}: Launched downloading.");

        int bytesLoaded = 0;
        Console.WriteLine($"{nameof(Main)}: Downloaded {bytesLoaded} bytes.");
    }

    private static async Task<int> DownloadDocsMainPageAsync()
    {
        Console.WriteLine($"{nameof(DownloadDocsMainPageAsync)}: About to start downloading.");

        var client = new HttpClient();
        byte[] content = await client.GetByteArrayAsync("https://docs.microsoft.com/en-us/");

        Console.WriteLine($"{nameof(DownloadDocsMainPageAsync)}: Finished downloading.");
        return content.Length;
    }
}


