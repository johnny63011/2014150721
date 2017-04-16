using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150721
{
    class BaseDatos
    {
        private Cuenta _Cuenta;

        public ATM ATM
        {
            get;
            set;
        }

        public BaseDatos()
        {
            _Cuenta = new Cuenta();
        }

        public BaseDatos(ATM atm)
        {
            ATM = atm;
        }







        public bool AutenticarUsuario(int numeroCuenta, int pin)
        {
            if (_Cuenta.NumeroCuenta == numeroCuenta && _Cuenta.Pin == pin)
            {
                return true;
            }
            return false;

        }


        public decimal ObtenerSaldoDisponible(int numeroCuenta)
        {
            if (_Cuenta.NumeroCuenta == numeroCuenta)
            {
                return _Cuenta.Monto;
            }
            else
            {
                return 0;
            }
        }

        public decimal ObtenerSaldoTotal(int numeroCuenta)
        {
            if (_Cuenta.NumeroCuenta == numeroCuenta)
            {
                return _Cuenta.Monto;
            }
            else
            {
                return 0;
            }
        }


        public void Debitar(int numeroCuenta, decimal monto)
        {
            if (_Cuenta.NumeroCuenta == numeroCuenta)
                _Cuenta.Monto -= monto;
        }

        public void Acreditar(int numeroCuenta, decimal monto)
        {
            if (_Cuenta.NumeroCuenta == numeroCuenta)
                _Cuenta.Monto += monto;

        }
      


    }
}
