using System;
using MyBiblioteca;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args){

            string dibujo;

            MyBiblioteca.Boligrafo boli1 = new Boligrafo(100, ConsoleColor.Blue);
            MyBiblioteca.Boligrafo boli2 = new Boligrafo(50, ConsoleColor.Red);

            Console.ForegroundColor = boli1.GetColor();
            boli1.Pintar(101, out dibujo);
            Console.WriteLine(dibujo);
            Console.ResetColor();

            Console.ForegroundColor = boli2.GetColor();
            boli2.Pintar(3, out dibujo);
            Console.WriteLine(dibujo);
            Console.ResetColor();

        }
    }
}
