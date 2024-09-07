using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Taller3DSemana1.Week3
{
    internal class MenuStudent : MenuParent
    {
        private List<Person> people = new List<Person>();
        public override void Execute()
        {
            people.Add(new Person("Pedro", 10));
            people.Add(new Student("Pablo", 15, 16.5f));
            people.Add(new Person("Betty", 20));
            people.Add(new Student("Vilma", 25, 19.1f));

            foreach(Person person in people)
            {
                Console.WriteLine(person.GetData());
            }
        }

    }
}
