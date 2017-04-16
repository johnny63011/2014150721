using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150721
{
    class Cuenta
    {

        private int _NumeroCuenta;
        private int _Pin;
        private decimal _Monto;

        public int NumeroCuenta
        {
            get
            {
                return _NumeroCuenta;
            }
            set
            {
                if (value > 0)
                    _NumeroCuenta = value;
            }

        }

        public int Pin
        {
            get
            {
                return _Pin;
            }
            set
            {
                if (value > 0)
                    _Pin = value;
            }
        }


        public decimal Monto
        {
            get
            {
                return _Monto;
            }
            set
            {
                if (value > 0)
                    _Monto = value;
            }
        }


        public Cuenta()
        {
        }

    }
}
