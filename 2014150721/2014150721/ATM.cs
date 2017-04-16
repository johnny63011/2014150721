using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150721
{
    class ATM
    {
        private List<RanuraDeposito> _RanuraDeposito;
        private List<Teclado> _Teclado;


        public BaseDatos BaseDatos
        {
            get;
            set;
        }


        public ATM()
        {
            _RanuraDeposito = new List<RanuraDeposito>();
            _Teclado = new List<Teclado>();
        }





        public void Autenticar()
        {
            bool date = BaseDatos.AutenticarUsuario(1000, 123);
            if (date.Equals(true))
                Console.WriteLine("Número de Cuenta no registrada [{0}]", 1000);
        }



    }
}
