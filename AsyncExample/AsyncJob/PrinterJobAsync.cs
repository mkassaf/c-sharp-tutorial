using AsyncExample.Job;
using AsyncExample.SyncJob;

namespace AsyncExample.AsyncJob
{
    public class PrinterJobAsync : PrinterJobSync
    {
        public PrinterJobAsync(string name): base(name){

        }
    
        protected override bool Initialize() {
            return base.Initialize();
        }

        protected override bool CheckInk(){
            return base.CheckInk();
        }

        protected override bool CheckPaper(){
            return base.CheckPaper();
        }

        public override bool PowerOn()
        {
            //Queues the specified work to run on the thread pool and returns a Task object that represents that work.
            var checkInkResult = Task.Run(() => 
            {
                return this.CheckInk();
            });
            var checkPapaerResult = Task.Run(() => 
            {
                return this.CheckPaper();
            });

            //Callback function
            checkPapaerResult.GetAwaiter().OnCompleted(() => {
                Console.WriteLine("CheckPaper is completed!");
            });

            Task.WaitAll(checkInkResult, checkPapaerResult);

            if (checkInkResult.GetAwaiter().GetResult() 
                && checkPapaerResult.GetAwaiter().GetResult()){
                var InitializingResult = Task.Run(() => 
                {
                    return this.Initialize();
                });
                Task.WaitAll(InitializingResult);
                return InitializingResult.GetAwaiter().GetResult();
            }
            return false;
        }

        public override async Task<bool> PowerOnAsync(){
            var awitTask = Task.Run(() => 
            {
                return this.PowerOn();
            });
            await awitTask;
            return awitTask.GetAwaiter().GetResult();
        }
    }
}