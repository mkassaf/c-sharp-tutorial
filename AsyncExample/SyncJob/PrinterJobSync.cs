using AsyncExample.Job;

namespace AsyncExample.SyncJob
{
    public class PrinterJobSync : PrinterJob
    {
        public PrinterJobSync(string name): base(name)
        {

        }
        protected override bool Initialize() {
            Console.WriteLine($"{this.GetName()}: Start {this.GetType()}.Initialize [Thread Id: {Thread.CurrentThread.ManagedThreadId}]");
            Thread.Sleep(200);
            Console.WriteLine($"{this.GetName()}: Finish {this.GetType()}.Initialize [Thread Id: {Thread.CurrentThread.ManagedThreadId}]");
            return true;
        }

        protected override bool CheckInk(){
            Console.WriteLine($"{this.GetName()}: Start {this.GetType()}.CheckInk [Thread Id: {Thread.CurrentThread.ManagedThreadId}]");
            Thread.Sleep(1000);
            Console.WriteLine($"{this.GetName()}: Finish {this.GetType()}.CheckInk [Thread Id: {Thread.CurrentThread.ManagedThreadId}]");
            return true;
        }

        protected override bool CheckPaper(){
            Console.WriteLine($"{this.GetName()}: Start {this.GetType()}.CheckPaper [Thread Id: {Thread.CurrentThread.ManagedThreadId}]");
            Thread.Sleep(500);
            Console.WriteLine($"{this.GetName()}: Finish {this.GetType()}.CheckPaper [Thread Id: {Thread.CurrentThread.ManagedThreadId}]");
            return true;
        }
        public  override Task<bool> PowerOnAsync(){
            throw new NotImplementedException("This operation is not supported");
        }
    }
}