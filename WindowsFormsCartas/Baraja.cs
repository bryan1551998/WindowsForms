using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCartas
{
    class Baraja
    {
        List<Cartas> listaCartas = new List<Cartas>();

        public Baraja()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    Cartas card = new Cartas(j, i);
                    ListaCartas.Add(card);
                }
            }
        }

        internal List<Cartas> ListaCartas { get => listaCartas; set => listaCartas = value; }

        public int NumeroCartas()
        {
            return this.listaCartas.Count();
        }

        public Cartas RobaCarta()
        {
            Cartas c = this.listaCartas[0];
            Console.WriteLine(this.listaCartas[0].CrearCarta());
            this.listaCartas.RemoveAt(0);
            return c;
        }

        public Cartas CogeCarta(int numCarta)
        {
            Cartas c = this.listaCartas[numCarta];
            this.listaCartas.RemoveAt(numCarta);
            return c;
        }

        public Cartas CogeCartaAlAzar()
        {
            Console.WriteLine("Carta a lazar");
            Random rnd = new Random();
            int numCarta = rnd.Next(0, this.listaCartas.Count());
            Cartas c = this.listaCartas[numCarta];
            this.listaCartas.RemoveAt(numCarta);
            return c;
        }

        public List<Cartas> Barajar()
        {
            Cartas c;
            List<Cartas> listaCartasNew = new List<Cartas>();
            Random rnd = new Random();
            int numCarta;

            while (this.listaCartas.Count() > 0)
            {
                numCarta = rnd.Next(0, this.listaCartas.Count());
                c = this.listaCartas[numCarta];
                listaCartasNew.Add(c);
                this.listaCartas.RemoveAt(numCarta);
            }
            return listaCartasNew;
        }
    }
}
