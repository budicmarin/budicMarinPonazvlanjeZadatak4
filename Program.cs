using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicMarinPonazvlanjeZadatak4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši cijenu sa bez PDV-om");
           double bezPDV = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cijena sa PDV-om "+(bezPDV+bezPDV*0.25));

            Console.WriteLine("Upsisi cijenu sa PDV-om");
            
            double PDV = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cijena bez PDV-a"+PDV*0.8);
                 Console.ReadKey();
        }
    }
}
