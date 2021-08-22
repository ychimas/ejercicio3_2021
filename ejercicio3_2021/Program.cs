/*Ejercicio 3:
Capturar la información financiera de un cliente, nombre, numero de cuenta y saldo de apertura y permitirle realizar
consignaciones y retiros a la cuenta, finalmente consultar el saldo con el que queda la cuenta.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3_2021
{
    class Program
    {
        static string nombre, numCuenta;
        static double contraseña, saldo, op = 0, consignaciones = 0, retiros = 0;
        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("\n----CAPTURA DE DATOS FINANCIERA----");
                Console.WriteLine("1. INGRESAR: ");
                Console.WriteLine("2. CONSIGNAR: ");
                Console.WriteLine("3. RETIRAR: ");
                Console.WriteLine("4. MOSTRAR: ");
                Console.WriteLine("5. SALIR: ");
                op = Convert.ToDouble(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Ingresar();
                        break;

                    case 2:
                        Consignar();
                        break;

                    case 3:
                        Retirar();
                        break;

                    case 4:
                        Mostrar();
                        break;
                }


            } while (op != 5);

        }
        static void Ingresar()
        {
            Console.WriteLine("NOMBRE: ");
            nombre = Console.ReadLine();
            Console.WriteLine("NUMERO DE CUENTA: ");
            numCuenta = Console.ReadLine();
            Console.WriteLine("CONTRASEÑA: ");
            contraseña = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("SALDO: ");
            saldo = Convert.ToDouble(Console.ReadLine());
        }

        static void Consignar()
        {
            Console.WriteLine("DINERO A CONSIGNAR");
            consignaciones = Convert.ToDouble(Console.ReadLine());
            if (consignaciones > 0)
            {
                saldo = saldo + consignaciones;
            }
            else if (consignaciones < 0)
            {
                Console.WriteLine("ERROR");
            }
            Console.WriteLine("SU SALDO ES: " + saldo);

        }
        static void Retirar()
        {
            Console.WriteLine("DINERO A RETIRAR");
            retiros = Convert.ToDouble(Console.ReadLine());
            if (retiros > 500)
            {
                saldo = saldo - retiros;
                Console.WriteLine("SU SALDO ES: " + saldo);
            }
            else if (retiros < 500)
            {
                Console.WriteLine("VALOR ASIGNADO INSUFICIENTE, MONTO MAYOR A 500");
            }
        }
        static void Mostrar()
        {
            Console.WriteLine("\n----INFORMACION DE LA CUENTA---- ");
            Console.WriteLine("NOMBRE: " + nombre);
            Console.WriteLine("NUMERO DE CUENTA: " + numCuenta);
            Console.WriteLine("CONTRASEÑA: " + contraseña);
            Console.WriteLine("SALDO: " + saldo);

        }
    }
}
