using System;
using Estudiante;

namespace Ejercicio_3{
    class Program{
        static void Main(string[] args){
            string nombre;
            string apellido;
            string legajo;

            Estudiante.Estudiante alumno;
            Estudiante.Estudiante alumno2;
            Estudiante.Estudiante alumno3;

            for (int i = 0; i < 3; i++) {
                Console.WriteLine("Ingrese el nombre: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el apellido: ");
                apellido = Console.ReadLine();

                Console.WriteLine("Ingrese el legajo: ");
                legajo = Console.ReadLine();

                switch (i) {
                    case 0:
                        alumno = new Estudiante.Estudiante(nombre, apellido, legajo);
                        alumno.SetNotaPrimerParcial(8);
                        alumno.SetNotaSegundorParcial(9);

                        Console.WriteLine(alumno.Mostrar());
                        break;
                    case 1:
                        alumno2 = new Estudiante.Estudiante(nombre, apellido, legajo); 
                        alumno2.SetNotaPrimerParcial(6);
                        alumno2.SetNotaSegundorParcial(7);

                        Console.WriteLine(alumno2.Mostrar());
                        break;
                    case 2:
                        alumno3 = new Estudiante.Estudiante(nombre, apellido, legajo);
                        alumno3.SetNotaPrimerParcial(2);
                        alumno3.SetNotaSegundorParcial(3);

                        Console.WriteLine(alumno3.Mostrar());
                        break;
                }
            }
        }
    }
}
