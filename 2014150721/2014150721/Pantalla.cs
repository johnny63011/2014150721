using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150721
{
    class Pantalla
    {
        private int _NumeroCuenta;
        private int _Pin;

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


    }
}
