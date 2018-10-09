using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Lab1.Enums;

namespace Lab1
{
    class MobileAccount
    {
        private TariffName _tariffName;

        private double _pricePerMin;

        private double _balance;

        private string _phoneNumber;

        private string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (Regex.IsMatch(value, @"^\d{10}$"))
                    _phoneNumber = value;
            }
        }

        private List<Service> _services;
        private List<string> _callHistory;

        public MobileAccount()
        {
        }

        public MobileAccount(TariffName tariffName, double pricePerMin, int balance, string phoneNumber)
        {
            _tariffName = tariffName;
            _pricePerMin = pricePerMin;
            _balance = balance;
            PhoneNumber = phoneNumber;

            _services = new List<Service>();
            _callHistory = new List<string>();
        }

        public void SetNewTariff(TariffName tariff)
        {
            _tariffName = tariff;
        }

        public double Call(int minuteCount, string phoneNumber)
        {
            double callPrice = 0;

            if (Regex.IsMatch(phoneNumber, @"^\d{10}$") && PhoneNumber != phoneNumber)
                callPrice = _pricePerMin * minuteCount;
            else
                throw new Exception("Call error");

            _balance -= callPrice;
            _callHistory.Add(phoneNumber);
            return callPrice;
        }

        public void AddService(Service service, double servicePrice)
        {
            _services.Add(service);
            _balance -= servicePrice;
        }

        public void RemoveService(Service service)
        {
            _services.Remove(service);
        }

        public void AddMoney(double addedSum)
        {
            if (addedSum > 0) _balance += addedSum;
        }

        public double GetBalance()
        {
            return _balance;
        }

        public List<string> GetCallHistory()
        {
            return _callHistory;
        }

        public void ShowAccountInfo()
        {
            Console.WriteLine(
                "Название Тарифа: {0}\nСтоимость минуты: {1}\nТекущая сумма на счету: {2}\nНомер телефона: {3}\n",
                _tariffName, _pricePerMin, _balance, _phoneNumber);
            Console.WriteLine("Подключенные сервисы:");
            _services.ForEach(service => Console.WriteLine(service));
            Console.WriteLine("История звонков:");
            _callHistory.ForEach(call => Console.WriteLine(call));
        }
    }
}