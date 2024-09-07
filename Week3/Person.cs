using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Taller3DSemana1.Week3
{
    internal class Person
    {
        protected string name;
        protected int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string GetData()
        {
            return $"Nombre: {name}, Edad: {age}";
        }
    }
}
