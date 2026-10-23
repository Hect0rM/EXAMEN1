using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenPOO.Ejercisio1
{
    public class Ejercicio01
    {
        public void Ejecutar()
        {
            Console.WriteLine("Las Zonas (local) = 1 \nLa Zona (departamental) = 2\nLa Zona (Nacional) = 3\nCada una tiene un coste diferente");
            Console.WriteLine("Estandar = 1 \nExpress = 2\nMismo dia = 3\nCada una tiene un coste diferente");
            Console.WriteLine("Ingrese la Zona de destino: ");
            int n1 =  int.TryParse(Console.ReadLine(), out int nro) ? nro: 0;
            Console.WriteLine("Ingrese el peso del paquete:  ");
            double n2 =  double.TryParse(Console.ReadLine(), out double num) ? num: 0;
            Console.WriteLine("Ingrese la prioridad del paquete:  ");
            int n3 =  int.TryParse(Console.ReadLine(), out int num1) ? num1: 0;
            Console.WriteLine("Ingrese la prioridad del paquete:  ");
            int n4 =  int.TryParse(Console.ReadLine(), out int num2) ? num2: 0;

            double subtotal;
            double zona = 0;
            double recargo = 0;
            double servicio = 0;
            double declarado =1;
            double descuento = 1;

            if ( n1 == 1 )
            {
                zona = 60;
                if (n2 < 5 && n2 > 1)
                {
                    recargo = 40;
                }
                if(n2 < 10 && n2 > 5)
                {
                    recargo = 80;
                }
                if(n2 > 10)
                {
                    recargo = 140;
                }
                else
                {
                    Console.WriteLine("Valor del peso no valido");
                }

                if(n3 == 1)
                {
                    servicio = 1;
                }
                if(n3 == 2)
                {
                    servicio = 1.25;
                }
                if(n3 == 3)
                {
                    servicio = 1.50;
                }
                else
                {
                    Console.WriteLine("La prioridad selecionada no es valida");
                }
                if(n4 > 5000)
                {
                    declarado = 1.02;
                }

                subtotal = ((zona+recargo)*servicio)*declarado;
                if(subtotal>700)
                {
                    descuento = 0.95;
                }

                Console.WriteLine($"El Cargo por zona fue de: {zona}");
                Console.WriteLine($"El recargo por peso fue de: {recargo}");
                Console.WriteLine($"El cargo por servicio fue de: {(servicio-1)*100}%");
                Console.WriteLine($"El cargo por declarar fue de: {(declarado-1)*100}");
                Console.WriteLine($"El subtotal a pagar es de: {subtotal}");
                Console.WriteLine($"El descuento por subtotal es de {(descuento-1)*-100}");
                Console.WriteLine($"El total a pagar es de: {subtotal*descuento}");


            }
            else if ( n1 == 2 )
            {
                zona = 100;
                if (n2 < 5 && n2 > 1)
                {
                    recargo = 40;
                }
                if(n2 < 10 && n2 > 5)
                {
                    recargo = 80;
                }
                if(n2 > 10)
                {
                    recargo = 140;
                }
                else
                {
                    Console.WriteLine("Valor del peso no valido");
                }

                if(n3 == 1)
                {
                    servicio = 1;
                }
                if(n3 == 2)
                {
                    servicio = 1.25;
                }
                if(n3 == 3)
                {
                    servicio = 1.50;
                }
                else
                {
                    Console.WriteLine("La prioridad selecionada no es valida");
                }
                if(n4 > 5000)
                {
                    declarado = 1.02;
                }

                subtotal = ((zona+recargo)*servicio)*declarado;
                if(subtotal>700)
                {
                    descuento = 0.95;
                }

                Console.WriteLine($"El Cargo por zona fue de: {zona}");
                Console.WriteLine($"El recargo por peso fue de: {recargo}");
                Console.WriteLine($"El cargo por servicio fue de: {(servicio-1)*100}%");
                Console.WriteLine($"El cargo por declarar fue de: {(declarado-1)*100}");
                Console.WriteLine($"El subtotal a pagar es de: {subtotal}");
                Console.WriteLine($"El descuento por subtotal es de {(descuento-1)*-100}");
                Console.WriteLine($"El total a pagar es de: {subtotal*descuento}");


            }
            else if ( n1 == 3 )
            {
                zona = 150;
                if (n2 < 5 && n2 > 1)
                {
                    recargo = 40;
                }
                if(n2 < 10 && n2 > 5)
                {
                    recargo = 80;
                }
                if(n2 > 10)
                {
                    recargo = 140;
                }
                else
                {
                    Console.WriteLine("Valor del peso no valido");
                }

                if(n3 == 1)
                {
                    servicio = 1;
                }
                if(n3 == 2)
                {
                    servicio = 1.25;
                }
                if(n3 == 3)
                {
                    servicio = 1.50;
                }
                else
                {
                    Console.WriteLine("La prioridad selecionada no es valida");
                }
                if(n4 > 5000)
                {
                    declarado = 1.02;
                }

                subtotal = ((zona+recargo)*servicio)*declarado;
                if(subtotal>700)
                {
                    descuento = 0.95;
                }

                Console.WriteLine($"El Cargo por zona fue de: {zona}");
                Console.WriteLine($"El recargo por peso fue de: {recargo}");
                Console.WriteLine($"El cargo por servicio fue de: {(servicio-1)*100}%");
                Console.WriteLine($"El cargo por declarar fue de: {(declarado-1)*100}");
                Console.WriteLine($"El subtotal a pagar es de: {subtotal}");
                Console.WriteLine($"El descuento por subtotal es de {(descuento-1)*-100}");
                Console.WriteLine($"El total a pagar es de: {(subtotal*descuento):F2} L");


            }
            else
            {
                Console.WriteLine("Valor no valido");
            }


        }
    }
}