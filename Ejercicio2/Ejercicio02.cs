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

            double valor = 0;
            int contador=0;
            int verificador = 0;
            double subtotal=0;
            double descuento =1;
            double total = 0;

            if (n1 == 1)
            {
                valor = 28.50;
                if( n2 < 61 && n2 > 0)
                {
                    while(contador <= n2)
                    {
                        verificador = contador%5;
                        if( verificador == 0)
                        {
                            Console.WriteLine($"Llevamos {contador}");
                            verificador = contador;
                        }
                        contador++;
                    }
                    Console.WriteLine($"se an llenado los {n2} de combustible");
                    subtotal = n1*n2; 

                    if (subtotal > 1500)
                    {
                        descuento = 0.95;
                    }
                    else if(subtotal > 1000)
                    {
                        descuento = 0.97;
                    }

                    Console.WriteLine($"los litros puestos son: {n2}");
                    Console.WriteLine($"El subtotal es de: {subtotal}");
                    Console.WriteLine($"El descueto aplicado es de: {(descuento-1)*-100}%");
                    Console.WriteLine($"El total a pagar es de: {(subtotal*descuento):F2} L");
                }
            }
            else if (n1 == 2)
            {
                valor = 32.00;
                if( n2 < 61 && n2 > 0)
                {
                    while(contador <= n2)
                    {
                        verificador = contador%5;
                        if( verificador == 0)
                        {
                            Console.WriteLine($"Llevamos {contador}");
                            verificador = contador;
                        }
                        contador++;
                    }
                    Console.WriteLine($"se an llenado los {n2} de combustible");
                    subtotal = n1*n2; 

                    if (subtotal > 1500)
                    {
                        descuento = 0.95;
                    }
                    else if(subtotal > 1000)
                    {
                        descuento = 0.97;
                    }

                    Console.WriteLine($"los litros puestos son: {n2}");
                    Console.WriteLine($"El subtotal es de: {subtotal}");
                    Console.WriteLine($"El descueto aplicado es de: {(descuento-1)*-100}%");
                    Console.WriteLine($"El total a pagar es de: {(subtotal*descuento):F2} L");
                }
            }
            else if (n1 == 3)
            {
                valor = 26.75;
                if( n2 < 61 && n2 > 0)
                {
                    while(contador <= n2)
                    {
                        verificador = contador%5;
                        if( verificador == 0)
                        {
                            Console.WriteLine($"Llevamos {contador}");
                            verificador = contador;
                        }
                        contador++;
                    }
                    Console.WriteLine($"se an llenado los {n2} de combustible");
                    subtotal = n1*n2; 

                    if (subtotal > 1500)
                    {
                        descuento = 0.95;
                    }
                    else if(subtotal > 1000)
                    {
                        descuento = 0.97;
                    }

                    Console.WriteLine($"los litros puestos son: {n2}");
                    Console.WriteLine($"El subtotal es de: {subtotal}");
                    Console.WriteLine($"El descueto aplicado es de: {(descuento-1)*-100}%");
                    Console.WriteLine($"El total a pagar es de: {(subtotal*descuento):F2} L");
                }
            }
            else
            {
                Console.WriteLine("Valor no valido");
            }
            
        }
    }
}