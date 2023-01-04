using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.ObjectType
{
    public class Person
    {
        public String Name { get; set; }
        public Int32 Age { get; set; }

        public Person(String name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
