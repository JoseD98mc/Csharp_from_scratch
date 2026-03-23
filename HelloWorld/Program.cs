
/*Console.WriteLine("Hello, World!");
Console.ReadLine();
*/
using System.Drawing;

namespace Helloworld
{
    class Program
    {

        static void Main()
        {
            DateOnly dateConverted = new DateOnly();
            string nameimput;
            string birthdayinput;
            Console.WriteLine("Hola, Bienvenido al calculador de años");
            Console.WriteLine("Escribe tu nombre:");
            nameimput = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"Es un gusto conocerte {nameimput}");
            Console.WriteLine("\nEscribe tu fecha de nacimiento en formato DD/MM/YY");
            birthdayinput = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(birthdayinput, out dateConverted);
            if (isDateValid == false)
            {
                Console.WriteLine($"La fecha de nacimiento es invalida. Dato erróneo {birthdayinput}");
            }
            var person = new Person
            {
                Name = nameimput,
                Birthday = dateConverted,
                Age = DateTime.Now.Year - dateConverted.Year
            };
            Console.WriteLine($"Tu nombre es:  {person.Name}");
            Console.WriteLine($"Tu fecha de nacimiento es:  {person.Birthday}");
            Console.WriteLine($"Tu edad es:  {person.Age} años");



            Console.ReadLine();
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }
    }

}