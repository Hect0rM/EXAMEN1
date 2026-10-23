using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenPOO.Ejercicio2
{
    public class Ejercicio02
    {
        public void Ejecutar()
        {
            Console.WriteLine("Regular = 1 \nPremium = 2\nDiesel = 3\nCada una tiene un coste diferente");
            Console.WriteLine("Ingrese el tipo de combustible: ");
            int n1 =  int.TryParse(Console.ReadLine(), out int nro) ? nro: 0;
            Console.WriteLine("Ingrese los litros:  ");
            double n2 =  double.TryParse(Console.ReadLine(), out double num) ? num: 0;

            
            
        }
    }
}