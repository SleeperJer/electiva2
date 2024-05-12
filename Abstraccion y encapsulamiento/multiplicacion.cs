using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Practica1
{
    public class multiplicacion
    {
        private int result;
        private int no1,no2;

        public int Result { get => result; set => result = value; }
        public int No1 { get => no1; set => no1 = value; }
        public int No2 { get => no2; set => no2 = value; }
        public int operacion(int value1, int value2)
        {
            result = value1 * value2;
            return result;
        }
        public int operacion() 
        {
            this.result = this.No1 * this.No2;
            return this.Result;
        }
    }
}
//La abstraccion la realice al decir lo atributos que pose que son resultado y numeros
//El encasulamiento lo realice declarando la variables como privada y con ayuda del vs