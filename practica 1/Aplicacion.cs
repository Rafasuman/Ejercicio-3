using System;
using System.Collections.Generic;
using System.Text;

namespace practica_1
{
    public class Aplicacion
    {
        public Aplicacion()
        {
            RecibirLaCuenta();
        }
        public Cuenta CrearCuenta()
        {
            Console.WriteLine("Digite su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Digite su saldo de apertura");
            decimal saldoDeApertura = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite su numero de cuenta");
            string numeroDeCuenta = Console.ReadLine();
            Cliente cliente = new Cliente(nombre);
            Cuenta cuenta = new Cuenta(numeroDeCuenta,saldoDeApertura,cliente);
            Console.WriteLine("Cuenta crada con exito¡¡");
            return cuenta;
        }

        public int ObtenerOpcioneDelUsuario()
        {
            Console.WriteLine("1.Consignar");
            Console.WriteLine("2.Retirar");
            Console.WriteLine("3.Consultar");
            Console.WriteLine("Digite la opcion que desee");
            int opcion = int.Parse(Console.ReadLine());
            return opcion;
        }

        public void EjecutarOpcionDelUsuario(Cuenta cuenta)
        {
            int opcion = ObtenerOpcioneDelUsuario();
            switch(opcion)
            {
                case 1: Consignar(cuenta); break;
                case 2: Retirar(cuenta); break;
                case 3: Consultar(cuenta); break;
            }
        }
        public void RecibirLaCuenta()
        {
            string opcion = "s";
            Cuenta cuenta = CrearCuenta();
            while (opcion.Equals("s"))
            {
                EjecutarOpcionDelUsuario(cuenta);
                Console.WriteLine("digite -> s para continuar haciendo operaciones en la cuenta, sino digite otra letra");
                opcion =Console.ReadLine();
            }
        }

        public void Consignar(Cuenta cuenta)
        {
            Console.WriteLine("Consigner"); 
            Console.WriteLine("Digite la cantidad a consignar");
            decimal consignacion = decimal.Parse(Console.ReadLine());
            string mensaje = cuenta.Consignar(consignacion);
            Console.WriteLine(mensaje);
        }

        public void Retirar(Cuenta cuenta)
        {
            Console.WriteLine("Retirar");
            Console.WriteLine("Digite la cantidad a retirar");
            decimal retiro = decimal.Parse(Console.ReadLine());
            string mensaje = cuenta.Retirar(retiro);
            Console.WriteLine(mensaje);
        }

        public void  Consultar(Cuenta cuenta)
        {
            Console.WriteLine("Consultar");
            Console.WriteLine("Su saldo actual es: ");
            decimal saldo = cuenta.Consultar();
            Console.WriteLine(saldo);
        }
    }
}
