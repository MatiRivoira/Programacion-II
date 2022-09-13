using System;
using System.Text;

namespace Estudiante{
    public class Estudiante{

        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        public double CalcularNotaFinal() {
            double retorno = -1;
            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4) {
                retorno = random.Next(6, 11);
            }
            return retorno;
        }

        private float CalcularPromedio() {
            return (float)(this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

        static Estudiante() {
            Estudiante.random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public string Mostrar() {
            StringBuilder retorno = new StringBuilder();
            double notaFinal = this.CalcularNotaFinal();

            retorno.AppendLine(this.nombre + ", " + this.apellido + " legajo: " + this.legajo);
            retorno.AppendLine("Nota primer parcial: " + this.notaPrimerParcial.ToString());
            retorno.AppendLine("Nota segundo parcial: " + this.notaSegundoParcial.ToString());
            retorno.AppendLine("Promedio: " + this.CalcularPromedio().ToString());

            if (notaFinal != -1){
                retorno.AppendLine("Nota final: " + notaFinal.ToString());
            }
            else {
                retorno.AppendLine("Alumno desaprobado");
            }

            return retorno.ToString();
        }

        public void SetNotaPrimerParcial(int nota) {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundorParcial(int nota){
            this.notaSegundoParcial = nota;
        }

    }
}
