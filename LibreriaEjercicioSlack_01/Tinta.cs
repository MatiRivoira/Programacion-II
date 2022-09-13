using System;

namespace LibreriaEjercicioSlack_01
{
    public class Tinta{

        private ConsoleColor color;
        private ETipoTinta tipo;

        public Tinta() {
            this.color = ConsoleColor.Black;
            this.tipo = ETipoTinta.Comun;
        }

        public Tinta(ConsoleColor color) : this(){
            this.color = color;
        }

        public Tinta(ConsoleColor color, ETipoTinta tipo) : this(color){
            this.tipo = tipo;
        }

        private string Mostrar(){
            return $"El color es {this.color} \n El tipo de tinta es: {this.tipo}";
        }

        public static string Mostrar(Tinta tinta){
            return tinta.Mostrar();
        }

        public static bool operator ==(Tinta tinta1, Tinta tinta2) {
            return tinta1.tipo == tinta2.tipo && tinta1.color == tinta2.color;
        }

        public static bool operator !=(Tinta tinta1, Tinta tinta2){
            return !(tinta1 == tinta2);
        }

        public static explicit operator string (Tinta tinta) {
            return tinta.Mostrar();
        }
    }
}
