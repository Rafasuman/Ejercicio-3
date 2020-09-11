using System;
using System.Collections.Generic;
using System.Text;

namespace practica_1
{
    public class Cuenta
    {
        public string NumeroDeCuenta { get; set; }
        public decimal SaldoDeApertura { get; set; }
        public decimal SaldoActual { get; set; }
        public Cliente Cliente { get; set; }

        public Cuenta (string numeroDeCuenta, decimal saldoDeApertura,Cliente cliente)
        {
            NumeroDeCuenta = numeroDeCuenta;
            SaldoDeApertura = saldoDeApertura;
            SaldoActual = SaldoDeApertura;
            Cliente = cliente;
        }

        public string Consignar(decimal consignaccion )
        {
            SaldoActual = SaldoActual + consignaccion;
            return "La consiganaccion se a realizao con exito¡¡¡";
        }

        public String Retirar(decimal retiro)
        {
            if(retiro > SaldoActual)
            {
                return "La transaccion a fracasado¡¡¡";
            }
            else
            {
                SaldoActual = SaldoActual - retiro;
                return "la transaccion fue un exito¡¡¡";
            }
        }

        public decimal Consultar()
        {
            return SaldoActual;
        }
    }

   
}
