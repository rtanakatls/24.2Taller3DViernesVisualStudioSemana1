using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Taller3DSemana1
{
    internal class Menu
    {
        public void Execute()
        {
            string name;
            int age;
            bool continueFlag;
            Console.WriteLine("Introduce tu nombre:");
            name = Console.ReadLine();
            Console.WriteLine($"Hola {name}!");
            continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce tu edad:");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine($"Tienes {age} años.");
                if (age < 0)
                {
                    Console.WriteLine("No puedes tener edad negativa");
                }
                else if (age < 18)
                {
                    continueFlag = false;
                    Console.WriteLine("Eres menor de edad.");
                }
                else
                {
                    continueFlag = false;
                    Console.WriteLine("Eres Mayor de edad.");
                }
            }
        }

    }
}
