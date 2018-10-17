using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Person> personList = new LinkedList<Person>(10);
            personList.Add(new Person("Dima"));
            personList.Add(new Person("Vadim"));
            personList.Add(new Person("Kirill"));
            personList.Add(new Person("Anton"));
            personList.Add(new Person("Sergei"));
            personList.Add(new Person("Alesha"));
            personList.Add(new Person("Vlad"));
            Console.WriteLine("Raw list: \n" + personList.ToString());
            personList.Remove(new Person("Vadim"));
            Console.WriteLine("\nAfter removing: \n" + personList.ToString());
            personList.Insert(4, new Person("Iosif"));
            Console.WriteLine("\nAfter inserting in index 4: \n" + personList.ToString());
            personList.RemoveAt(3);
            Console.WriteLine("\nAfter removing at 3: \n" + personList.ToString());
            Console.WriteLine("\nGet index of 'Alesha': \n" + personList.IndexOf(new Person("Alesha")));
            Console.WriteLine("\nCheck contains 'Artur': \n" + personList.Contains(new Person("Artur")));
            Console.WriteLine("\nCheck contains 'Dima': \n" + personList.Contains(new Person("Dima")));
        }
    }
}
