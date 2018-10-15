using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Lab2.Annotations;

namespace Lab2.Models
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public int InstrumentCount { get; set; }

        public int EmployeesCount
        {
            get { return AssignedEmployees.Count; }   
        }
        public BindingList<Employee> AssignedEmployees { get; set; }
        public bool IsFree { get; set; }

        public Room()
        {
            IsFree = true;
            AssignedEmployees = new BindingList<Employee>();
        }

        public Room(int roomNumber, int instrumentCount) : this()
        {
            RoomNumber = roomNumber;
            InstrumentCount = instrumentCount;
        }
    }
}