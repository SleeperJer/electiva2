using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Herencia
            Console.WriteLine("HERENCIA");
            Console.WriteLine("Registros que le mando al secretario");
            Secretario herencia = new Secretario();
            herencia.InfoNuevos();
            herencia.InfoActualizacion();
            Console.ReadKey();

            //Polimorfismo
            Console.WriteLine("Polimorfismo");
            oper1 rectangulo = new oper1();
            rectangulo.resultArea(5, 5);

            oper2 triangulo = new oper2();
            triangulo.resultArea(5, 5 / 2);
            Console.ReadKey();


            //Abstracion y encapsulamiento
            Console.WriteLine("Abstraccion, Encapsulamiento");
            multiplicacion objMp = new multiplicacion();
            Console.WriteLine("5 * 2 = " + objMp.operacion(5, 9));
            Console.ReadLine();
        }
    }
}
