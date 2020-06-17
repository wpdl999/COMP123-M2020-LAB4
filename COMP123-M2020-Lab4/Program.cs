using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate object of type Person
            Person tom = new Person(name: "Tom", age: 40);

            // use saysHello method with . accessor
            tom.SaysHello();


            Console.ReadLine();
        }
    }
}
