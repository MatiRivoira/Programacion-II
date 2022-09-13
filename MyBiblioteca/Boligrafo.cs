using System;
using System.Text;

namespace MyBiblioteca
{
    public class Boligrafo{

        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color) {
            this.color = color;
            this.SetTinta(tinta);
        }

        public ConsoleColor GetColor() {
            return this.color;
        }

        public short GetTinta() {
            return this.tinta;
        }

        public bool Pintar(short gasto, out string dibujo) {
            bool retorno = false;
            string cadenaAux = "";

            while (this.tinta > 0 && gasto > 0){
                cadenaAux += "*";
                gasto--;
                this.SetTinta(-1);
                retorno = true;
            }
            dibujo = cadenaAux;

            return retorno;
        }

        public void Recargar() {
            this.tinta = cantidadTintaMaxima;
        }

        private void SetTinta(short tinta) {
            if (this.tinta >= 0 && this.tinta <= Boligrafo.cantidadTintaMaxima) {
                if (tinta < 0) {
                    this.tinta += tinta;
                } else {
                    this.tinta = tinta;
                }
            }
        }
    }
}
