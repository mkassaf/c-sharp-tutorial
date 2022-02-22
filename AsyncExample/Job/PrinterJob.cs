
namespace AsyncExample.Job
{
    public abstract class PrinterJob
    {
        protected abstract bool Initialize();

        protected abstract bool CheckInk();

        protected abstract bool CheckPaper();


        public virtual bool PowerOn(){
            if(CheckInk() && CheckPaper()){
                return Initialize();
            }
            return false;
        }

         
    }
}