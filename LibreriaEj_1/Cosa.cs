using System;
using System.Text;

namespace LibreriaEj_1{
    public class Cosa{
        private int entero;
        private string cadena;
        private DateTime fecha;

        public Cosa() {
            this.entero = 10;
            this.cadena = "SIN VALOR";
            this.fecha = DateTime.Now;
        }

        public Cosa(string cadena) : this(){ 
            this.cadena = cadena;
        }

        public Cosa(int entero, string cadena) : this(cadena){
            this.entero = entero;
        }

        public Cosa(DateTime fecha, int entero, string cadena) : this(entero, cadena){
            this.fecha = fecha;
        }

        public void EstablecerValor(int entero) {
            this.entero = entero;
        }

        public void EstablecerValor(string cadena){
            this.cadena = cadena;
        }

        public void EstablecerValor(DateTime fecha){
            this.fecha = fecha;
        }

        private string Mostrar() {
            StringBuilder muestra = new StringBuilder();
            muestra.AppendLine($"El entero es: {this.entero}");
            muestra.AppendLine($"La cadena es: {this.cadena}");
            muestra.AppendLine($"La fecha es: {this.fecha.ToShortDateString()}");
            return muestra.ToString();
        }

        public static string Mostrar(Cosa cosa) {
            return cosa.Mostrar();
        }


    }
}
