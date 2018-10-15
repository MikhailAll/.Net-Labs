using System.Collections.Generic;
using System.ComponentModel;

namespace Lab2.Models
{
    public class Studio
    {
        public string StudioName { get; set; }
        public string StudioAddress { get; set; }
        public double PricePerTrack { get; set; }
        public double TimePerTrack { get; set; }
        public int InstrumentCount { get; set; }
        public double StudioCash { get; set; }

        public double StudioSalary
        {
            get { 
                double salary = 0;
                foreach (var employee in Employees)
                {
                    salary += employee.Salary;
                }
                return salary;
            }
        }

        public int EmployeeCount
        {
            get { return Employees.Count; }
        }

        public BindingList<Employee> Employees { get; set; }
        public BindingList<Room> Rooms { get; set; } 

        public Studio()
        {    
            Employees = new BindingList<Employee>();
            Rooms = new BindingList<Room>();
        }

        public Studio(string studioName, string studioAddress, double pricePerTrack, double timePerTrack,
            int instrumentCount) :this()
        {
            StudioName = studioName;
            StudioAddress = studioAddress;
            PricePerTrack = pricePerTrack;
            TimePerTrack = timePerTrack;
            InstrumentCount = instrumentCount;
        }

        public Studio(string studioName, string studioAddress, double pricePerTrack, double timePerTrack,
            int instrumentCount, BindingList<Employee> employees, BindingList<Room> rooms) : this(studioName, studioAddress,
            pricePerTrack, timePerTrack, instrumentCount)
        {
            Employees = employees;
            Rooms = rooms as BindingList<Room>;
        }
    }
}