using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150721
{
    class RanuraDeposito
    {
        private decimal _Deposito;

        public decimal Deposito
        {
            get
            {
                return _Deposito;
            }
            set
            {
                if (value > 0)
                    _Deposito = value;
            }

        }

        public RanuraDeposito(decimal deposito)
        {
            Deposito = deposito;
        }


    }
}
