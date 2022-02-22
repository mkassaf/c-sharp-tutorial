using AsyncExample.Job;

namespace AsyncExample.SyncJob
{
    public class PrinterJobSync : PrinterJob
    {
        protected override bool Initialize() {
            Console.WriteLine($"String Initialize [Thread Id: {Thread.CurrentThread.ManagedThreadId}]");
            Thread.Sleep(200);
            Console.WriteLine($"Finish Initialize [Thread Id: {Thread.CurrentThread.ManagedThreadId}]");
            return true;
        }

        protected override bool CheckInk(){
            Console.WriteLine($"String checking ink [Thread Id: {Thread.CurrentThread.ManagedThreadId}]");
            Thread.Sleep(1000);
            Console.WriteLine($"Finish checking ink [Thread Id: {Thread.CurrentThread.ManagedThreadId}]");
            return true;
        }

        protected override bool CheckPaper(){
            Console.WriteLine($"String checking paper [Thread Id: {Thread.CurrentThread.ManagedThreadId}]");
            Thread.Sleep(500);
            Console.WriteLine($"Finish checkibg paper [Thread Id: {Thread.CurrentThread.ManagedThreadId}]");
            return true;
        }
        
    }
}