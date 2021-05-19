using System;
using System.Collections.Generic;

namespace Laboratorio5cs
{
    class Program
    {
        static void Main(string[] args)
        {

            var date1 = new DateTime(2008, 5, 1, 8, 30, 52);

            Console.WriteLine("Criando contas...");

            Conta c1 = new ContaPoupanca("Alphie", 10, date1);
            Conta c2 = new ContaPoupanca("Alisaie", 250, date1);
            Conta c3 = new ContaPoupanca("Y'shtola", 500, date1);
            Conta c4 = new ContaPoupanca("Urianger", 100, date1);

            c1.Depositar(10);
            c2.Depositar(200);
            c3.Depositar(250);
            c4.Depositar(100);
            c4.Sacar(50);
            Console.WriteLine($"Saldo de {c1.Titular} é {c1.Saldo} gil");
            Console.WriteLine($"Saldo de {c2.Titular} é {c2.Saldo} gil");
            Console.WriteLine($"Saldo de {c3.Titular} é {c3.Saldo} gil");
            Console.WriteLine($"Saldo de {c4.Titular} é {c4.Saldo} gil");

            List<Conta> listaDeContas = new List<Conta>() { c1, c2, c3, c4 };

            Console.WriteLine("Numero de contas: {0}", listaDeContas.Count);
            listaDeContas.ForEach(e => Console.WriteLine(e.Titular));

        }
    }
}
