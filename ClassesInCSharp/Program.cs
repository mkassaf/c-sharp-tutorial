using System;
using System.Collections.Generic;
using Users;


using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace ClassesInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new AdminUser();

            user.Name = "A";
            user.Age = 5;

            ((AdminUser)user).Level = "Admin";

            user.PrintData();

            
            Light light = new Light();

            Control(light);

            TV tv = new TV();

            Control(tv);


            Device lamp = new Lamp();

            Device pc = new Laptop();


            lamp.Shutdown();
            pc.Shutdown();

            CallUser(new User());
            CallUser(new AdminUser()) ;

        }

        static  void Control(Switchable device)
        {
            device.PowerOn();

            device.PowerOff();
        }

        static void CallUser(User user)
        {

        }

    }

    class User
    {
        public string Name { get; set; }
        public long Age { get; set; }

        public virtual void PrintData()
        {
            Console.WriteLine($" {Name} , {Age}");
        }

    }

    class AdminUser : User
    {
        public string Level { get; set; }

        public void PrintData()
        {
            base.PrintData();
            Console.WriteLine($"{Level}");
        }
    }

    class Light : Switchable
    {
        public  void PowerOn()
        {
            Console.WriteLine($" {this.GetType()} Power on");
        }
        public void PowerOff()
        {
            Console.WriteLine($" {this.GetType()} Power off");
        }
    }

    class TV : Switchable
    {
        public void PowerOn()
        {
            Console.WriteLine($" {this.GetType()} Power on");
        }
        public void PowerOff()
        {
            Console.WriteLine($" {this.GetType()}  Power off");
        }
    }

    interface Switchable
    {
        public void PowerOn();
        public void PowerOff();
    }

    abstract class Device
    {
        public void Shutdown()
        {
            Console.WriteLine("Shutdown the device..");
            /**
             * 
             * 
             * 
             * 
             * */
            OnShutdown();
        }

        protected abstract void OnShutdown();
    }

    class Lamp : Device
    {
        protected override void OnShutdown()
        {
            Console.WriteLine("Lamp .. ");
        }
    }

    class Laptop : Device
    {
        protected override void OnShutdown()
        {
            Console.WriteLine("LAptop ... .. ");
        }
    }


    sealed class MyFinalClass
    {
        public String MyProperty { get; set; }
    }

    


}


