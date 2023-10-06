using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesNegocio
{
    public sealed class TelefonoDeJuguete : Celular
    {
        private string sonidos;
        private string material;
        private bool haceSonido;

        public TelefonoDeJuguete(string sonidos, string material, bool haceSonido)
        {
            this.Sonidos = sonidos;
            this.Material = material;
            this.HaceSonido = haceSonido;
        }
        /*
         * Se generao un constructor 
         * para cada uno de las instancias
         * Ademans el base hace su laburo
         * el precio es de 5 dolares
         * ademas tienen un pito en elorto
         * 
         */
        public string Sonidos { get => sonidos; set => sonidos = value; }
        public string Material { get => material; set => material = value; }
        public bool HaceSonido { get => haceSonido; set => haceSonido = value; }
    }
}
