
namespace AsyncExample.Job
{
    public abstract class PrinterJob
    {
        private string _name;

        public PrinterJob(string name){
            this._name = name;
        }

        public String GetName(){
            return _name;
        }
        protected abstract bool Initialize();

        protected abstract bool CheckInk();

        protected abstract bool CheckPaper();


        public virtual bool PowerOn(){
            if(CheckInk() && CheckPaper()){
                return Initialize();
            }
            return false;
        }

        public abstract Task<bool> PowerOnAsync();

         
    }
}