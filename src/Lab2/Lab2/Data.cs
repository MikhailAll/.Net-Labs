using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Models;

namespace Lab2
{
    static class Data
    {
        public static BindingList<Studio> Studios { get; set; }

        public static void Init()
        {
            //Studios = new BindingList<Studio>()
            //{
            //    new Studio("First Name", "First Address", 1, 1, 8),
            //    new Studio("Second Name", "Second Address", 1, 1, 8),
            //    new Studio("Third Name", "Third Address", 1, 1, 8),
            //    new Studio("Fourth Name", "Fourth Address", 1, 1, 8),
            //    new Studio("Fifth Name", "Fifth Address", 1, 1, 8),
            //};

            Studios = new BindingList<Studio>()
            {
                new Studio("sadasdsad", "sadsadsad", 1, 1, 8,
                    new BindingList<Employee>()
                    {
                        new Employee("dfsfds", "sadsadsad", 1)
                    }, 
                    new BindingList<Room>()
                    {
                        new Room(1, 2)
                    }) 
            };

            Studios.AllowNew = true;
            Studios.AllowRemove = true;
            Studios.AllowEdit = true;

        }
    }
}
