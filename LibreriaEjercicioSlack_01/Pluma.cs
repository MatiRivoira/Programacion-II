using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEjercicioSlack_01
{
    class Pluma{

        private string marca;
        private Tinta tinta;
        private int cantidad;

        public Pluma() {
            this.marca = "Sin Marca";
            this.tinta = null;
            this.cantidad = 1;
        }

        public Pluma(string marca) : this() {
            this.marca = marca;
        }

        public Pluma(string marca, Tinta tinta) : this(marca){
            this.tinta = tinta;
        }

        public Pluma(string marca, Tinta tinta, int cantidad) : this(marca, tinta){
            this.cantidad = cantidad;
        }

        private string Motrar() {
            return $"La marca es: {this.marca} \n La tinta es: {(string)tinta} \n La cantidad es: {this.cantidad}";
        }

        public static bool operator ==(Pluma pluma, Tinta tinta) {
            return pluma.tinta == tinta;
        }
        public static bool operator !=(Pluma pluma, Tinta tinta){
            return !(pluma == tinta);
        }

        public static Pluma operator +(Pluma pluma, Tinta tinta) {
            if (pluma == tinta){
                pluma.cantidad++;
            }
            return pluma;
        }

        public static Pluma operator -(Pluma pluma, Tinta tinta){
            if (pluma == tinta){
                pluma.cantidad--;
            }
            return pluma;
        }

        public static implicit operator string(Pluma pluma) {
            return pluma.Motrar();
        }
    }
}
