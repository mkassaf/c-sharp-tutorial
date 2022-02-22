using System;
using AsyncExample.Job;
using AsyncExample.SyncJob;

namespace AsyncExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrinterJob printerJob = new PrinterJobSync();
            printerJob.PowerOn();
        }
    }
}