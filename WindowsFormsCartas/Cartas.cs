using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCartas
{
    class Cartas
    {
        //Atributos 
        int numero;
        int palo;
       

        //Constructor
        public Cartas(int numero, int palo)
        {
            this.numero = numero;
            this.palo = palo;
        }

        //Metodos
        public string CrearCarta()
        {
            String[] palos = { "Corazones", "Diamantes", "Picas", "Treboles" };
            return "_" + this.numero + "_" + palos[palo];

        }

        //Get and Set
        public int Numero
        {
            get; set;
        }
        public int Palo
        {
            get; set;
        }
    }
}
