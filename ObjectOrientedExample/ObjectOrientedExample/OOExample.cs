using System;
namespace ObjectOrientedExample
{
    public class OOExample
    {
        //2- Car - model (Base[Color, Engine, SerialNumber], SportCar[Color, Engine, Extra Engine, SerialNumber, Turbo])- drive, stop

        public OOExample()
        {
        }

        static void Main2(string[] args)
        {


            /*
            ICar car2 = new SprotCar();
            


            ICar car4 = new BaseCar();


            SprotCar sprotCar = new SprotCar();
            BaseCar baseCar = new BaseCar();
            Car car3 = new SprotCar();
            Car car5 = new BaseCar();

            sprotCar.Print();//sportCAR
            baseCar.Print();// base car
            car3.Print(); // Print Car , sportCAR
            car5.Print(); // Print Car , base car

            sprotCar.CAll2();

            DriveCar(sprotCar);
            DriveCar(baseCar);
            */



        }


        static void DriveCar(ICar baseCar)
        {
            baseCar.Drive();//Base or Sport
        }
    }





    class Engine { }

    interface ICar
    {
        public void Stop();
        public void Drive();
    }
    class Car
    {
        public String Color { get; set; }
        public String Engine { get; set; }
        public String SerialNumber { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("Print Car");
        }
    }

    class BaseCar : Car, ICar
    {
        public void Drive()
        {
            //
        }

        public void Stop()
        {
            //
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Print BaseCar");
        }

    }

    class SprotCar : Car, ICar
    {
        public String ExtraEngine { get; set; }

        public SprotCar()
        {

        }
        public void CAll2()
        {

        }
        public void CAll2(int x)
        {

        }

        public void Drive()
        {
            //
        }

        public void Stop()
        {
            //
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Print SprotCar");
        }
    }






















    class Address
    {
        public String County { get; set; }
        public String City { get; set; }
        public String PostalCode { get; set; }
    }

    class House
    {
        public String HouseId { get; set; }
        public Address Address { get; set; }

    }

    class User
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public long Age { get; set; }

        public Address Address { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"{Id}");
        }

    }

    class AdminUser : User
    {
        public String Role { get; set; }
    }
}
