using System;

namespace Ejercicio_07{
    class Program{
        static void Main(string[] args){

            int valorHora;
            string name;
            int antiguedad;
            int cantidadHorasTrabajadas;
            float total;
            float importeCobrar;
            int respuesta;

            do {
                Console.WriteLine("Ingrese el valor de la hora: ");
                while (!(int.TryParse(Console.ReadLine(), out valorHora)))
                {
                    Console.WriteLine("Error, Ingrese nuevamente la hora: ");
                }

                Console.WriteLine("Ingrese el nombre: ");
                name = Console.ReadLine();

                Console.WriteLine("Ingrese la antiguedad en años: ");
                while (!(int.TryParse(Console.ReadLine(), out antiguedad)))
                {
                    Console.WriteLine("Error, Ingrese nuevamente la antiguedad en años: ");
                }

                Console.WriteLine("Ingrese la cantidad de horas trabajadas en el mes: ");
                while (!(int.TryParse(Console.ReadLine(), out cantidadHorasTrabajadas)))
                {
                    Console.WriteLine("Error, Ingrese nuevamente la cantidad de horas trabajadas en el mes: ");
                }

                total = (valorHora * cantidadHorasTrabajadas) + (antiguedad * 150);
                importeCobrar = total - (total * 13 / 100);

                Console.WriteLine("\n\n\n\n " +
                                  "-------------------------------------\n" +
                                  " NOMBRE: {0}                         \n" +
                                  " ANTIGUEDAD: {1}                     \n" +
                                  " VALOR DE HORA: {2}                  \n" +
                                  " TOTAL BRUTO: {3}                    \n" +
                                  " TOTAL NETO: {4}                     \n" +
                                  "-------------------------------------", name, antiguedad, valorHora, total, importeCobrar);

                Console.WriteLine("¿Desea ingresar otro trabajador?  " +
                                  "1- SEGUIR INGRESADONDO TRAAJADORES" +
                                  "2- SALIR                          ");
                while (!(int.TryParse(Console.ReadLine(), out respuesta))){
                    Console.WriteLine("Error, ¿Desea ingresar otro trabajador?  " +
                                      "1- SEGUIR INGRESADONDO TRAAJADORES     \n" +
                                      "2- SALIR                                 ");
                }
            } while (respuesta != 2);

           


        }
    }
}
