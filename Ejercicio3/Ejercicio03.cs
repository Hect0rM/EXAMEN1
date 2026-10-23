using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenPOO.Ejercicio3
{
    public class Ejercicio03
    {
        public void Ejecutar()
        {
            string[] nombres = {"Pedro", "Juan", "Pablo", "Maria", "Mateo", "Magdalena","Pepito","Fernanda","Dulce","Emilio","Zahir"};
            bool[] asistencia = {true,true,false,true,false,false,true,false,true,false,true};
            
            int asistidor = 0;
            int faltador = 0;


            for(int i = 0; i<10; i++)
            {
                if(asistencia[i] == true)
                {
                    asistidor ++;
                }
                else
                {
                    faltador++;
                    Console.WriteLine($"{nombres[i]}");
                }

                
            }
            Console.WriteLine("Ingrese una posision para buscar al estudiante: ");
            int n1 =  int.TryParse(Console.ReadLine(), out int nro) ? nro: 0;

            if(n1<10 && n1>0)
            {
                Console.WriteLine($"{nombres[n1]}");
            }
            else
            {
                Console.WriteLine($"Valor no valido");
            }

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"{nombres[i]}");
            }
        
        }
    }
}