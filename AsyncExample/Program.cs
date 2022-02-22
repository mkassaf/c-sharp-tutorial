using System;
using AsyncExample.Job;
using AsyncExample.SyncJob;
using AsyncExample.AsyncJob;

namespace AsyncExample
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("___________ Start __________________");
            PrinterJob printerJob = new PrinterJobSync("HP Sync");
            printerJob.PowerOn();

            Console.WriteLine("_____________________________________");
            PrinterJob asyncHpPrinter = new PrinterJobAsync("HP Async");

            PrinterJob asyncEpsonPrinter = new PrinterJobAsync("Epson Async");

            Console.WriteLine("_____________________________________");

            var hpResult =   asyncHpPrinter.PowerOnAsync();
            
            Console.WriteLine("_____________________________________");

            var epsonResult =  await asyncEpsonPrinter.PowerOnAsync();

            Console.WriteLine("_____________________________________");

            Task.WaitAll(hpResult);

            Console.WriteLine("_____________________________________");

            Console.WriteLine($"{asyncHpPrinter.GetName()} : {hpResult.GetAwaiter().GetResult()}");
            Console.WriteLine($"{asyncEpsonPrinter.GetName()} : {epsonResult}");
            
            Console.WriteLine("___________ End __________________");

        }
    }
}