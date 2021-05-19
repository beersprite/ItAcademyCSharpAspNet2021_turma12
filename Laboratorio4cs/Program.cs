using System;
using System.Drawing;

namespace Laboratorio4cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Color slateBlue = Color.FromName("SlateBlue");

            Circulo c1 = new Circulo();
            Console.WriteLine(c1.ToString());
            Circulo c2 = new Circulo(1, 2, 3);
            Console.WriteLine(c2.ToString());
            Circulo c3 = new CirculoColorido(1, 2, 3, "branco");
            Console.WriteLine(c3.ToString());
            Circulo c4 = new CirculoColoridoPreenchido(1, 2, 3, "branco", slateBlue);
            Console.WriteLine(c4.ToString());

            Circulo[] listaCirculos = { c1, c2, c3, c4 };

            Array.ForEach(listaCirculos, Console.WriteLine);
        }
    }
}
