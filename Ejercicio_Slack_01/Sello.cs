using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Slack_01{
    class Sello{
        public static string mensaje;

        public static ConsoleColor color;

        /// <summary>
        /// Retorna mensaje
        /// </summary>
        /// <returns></returns>
        public static string Imprimir() {
            return ArmarFormatoMensaje();
        }

        /// <summary>
        /// Deja en blanco mensaje
        /// </summary>
        public static void Borrar() {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor() {
            Console.ForegroundColor = color;
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor();
        }

        private static string ArmarFormatoMensaje() {
            string formatoMensaje = "";
            for (int i = 0; i < Sello.mensaje.Length + 2; i++) {
                formatoMensaje += "*";
            }
            return formatoMensaje + "\n*" + Sello.mensaje + "*\n" + formatoMensaje;
        }
    }
}
