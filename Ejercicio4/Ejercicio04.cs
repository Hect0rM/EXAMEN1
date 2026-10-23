using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenPOO.Ejercicio4
{
    public class Ejercicio04
    {

        public void Ejecutar()
        {
            List<string> urgentes = new List<string>();
            List<string> normales = new List<string>();

            int n1 = 0;
            string pro = "";
           
            while(n1 != 4)
            {
                Console.WriteLine($"Ver lista Urgente - 1");
                Console.WriteLine($"Ver lista Normal - 2");
                int n2 =  int.TryParse(Console.ReadLine(), out int nro) ? nro: 0;

                if(n2 == 1)
            {
                urgentes.Add("Maria");
                urgentes.Add("Fernando");
                urgentes.Add("Josefa");
                urgentes.Add("Penelope");
                urgentes.Add("Chepe");

                foreach (string urgente in urgentes)
                {
                    Console.WriteLine(urgente);
                }
                Console.WriteLine($"Desea agregar un paciente, 1- si, 2- no");
                int n3 =  int.TryParse(Console.ReadLine(), out int nro1) ? nro1: 0;

                if(n3 == 1)
                    {
                    pro = Console.ReadLine();
                    urgentes.Add(pro);
                    }

            }

            if(n2 == 2)
            {
                normales.Add("Maria");
                normales.Add("Fernando");
                normales.Add("Josefa");
                normales.Add("Penelope");
                normales.Add("Chepe");

                foreach (string normale in normales)
                {
                    Console.WriteLine(normale);
                }
                Console.WriteLine($"Desea agregar un paciente, 1- si, 2- no");
                int n3 =  int.TryParse(Console.ReadLine(), out int nro1) ? nro1: 0;

                if(n3 == 1)
                    {
                    pro = Console.ReadLine();
                    urgentes.Add(pro);
                    }
            }
            }
            
        }

    }
}