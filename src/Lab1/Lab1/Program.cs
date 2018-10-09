using System;
using Lab1.Enums;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobileAccount = new MobileAccount(TariffName.FirstTariff, 2.55, 1000, "1234567890");
            mobileAccount.ShowAccountInfo();
            mobileAccount.Call(50, "3548965441");
            mobileAccount.Call(25, "5548765441");
            mobileAccount.AddService(Service.FirstService, 100);
            mobileAccount.AddService(Service.FourthService, 400);
            mobileAccount.ShowAccountInfo();
            Console.Read();
        }
    }
}
