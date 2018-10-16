using System;
using System.ComponentModel;

namespace Lab2.Models
{
    public class Room: ICloneable
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

        public object Clone()
        {
            return new Room(RoomNumber, InstrumentCount);
        }
    }
}