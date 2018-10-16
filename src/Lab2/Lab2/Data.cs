using System.ComponentModel;
using Lab2.Models;

namespace Lab2
{
    static class Data
    {
        public static BindingList<Studio> Studios { get; set; }

        public static void Init()
        {
            Studios = new BindingList<Studio>
            {
                new Studio("First Studio", "First Address", 50, 45, 20,
                    new BindingList<Employee>
                    {
                        new Employee("First Employee", "First Employee", 1000),
                        new Employee("Second Employee", "Second Employee", 1000),
                        new Employee("Third Employee", "Third Employee", 1000)
                    },
                    new BindingList<Room>
                    {
                        new Room(0, 2),
                        new Room(1, 2),
                        new Room(2, 3)
                    }),
                new Studio("Second Studio", "Second Address", 150, 90, 40,
                    new BindingList<Employee>
                    {
                        new Employee("First Employee", "First Employee", 1000),
                        new Employee("Second Employee", "Second Employee", 1000),
                        new Employee("Third Employee", "Third Employee", 1000)
                    },
                    new BindingList<Room>
                    {
                        new Room(0, 2),
                        new Room(1, 2),
                        new Room(2, 3)
                    }),
                new Studio("Third Studio", "Third Address", 200, 55, 25,
                    new BindingList<Employee>
                    {
                        new Employee("First Employee", "First Employee", 1000),
                        new Employee("Second Employee", "Second Employee", 1000),
                        new Employee("Third Employee", "Third Employee", 1000)
                    },
                    new BindingList<Room>
                    {
                        new Room(0, 2),
                        new Room(1, 2),
                        new Room(2, 3)
                    })
            };

            Studios.AllowNew = true;
            Studios.AllowRemove = true;
            Studios.AllowEdit = true;

        }
    }
}
