using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SportsCar myCar = new SportsCar();
            myCar. PetName = "My beat up Sienna";
            Console.WriteLine("My car: {0},\t{1}", myCar.getPetName(), myCar.PetName);
        }
    }
}
