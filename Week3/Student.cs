using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Taller3DSemana1.Week3
{
    internal class Student : Person
    {
        protected float finalGrade;

        public Student(string name, int age, float finalGrade) : base(name, age)
        {
            this.finalGrade = finalGrade;
        }

        public override string GetData()
        {
            return $"Nombre: {name}, edad: {age}, Nota Final: {finalGrade}";
        }
    }
}
