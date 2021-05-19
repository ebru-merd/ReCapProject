using Business.Concrete;
using DataAccess.Concrete.IMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            carManager carManager1 = new carManager(new IMemoryCarDal());
            foreach (var car in carManager1.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
