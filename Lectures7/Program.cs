using System;

namespace Lectures7
{
    class Program
    {
        /*
         * Code conventions
         * OOP example -> 
         *  Animal -> Cat, Dog and Bird
         *  
         */
        static void Main(string[] args)
        {
            SuperUser superUser1 = new SuperUser();
            //SuperUser superUser2 = new SuperUser();
            //SuperUser superUser3 = new SuperUser();

            SuperUser.SetStatic(20);

            superUser1.CallStatic();

            //SuperUser.StaticFunction();

            //Console.WriteLine(SuperUser.s_id);

        }
    }


    class SuperUser
    {

        private static int s_id;
        public string Name { get; set; }


        private static void StaticFunction()
        {
            Console.WriteLine($"I am static function. {s_id}");
        }

        public static void SetStatic(int id)
        {
            s_id = id;
        }

        public void CallStatic()
        {
            
                
        }




    }
}
