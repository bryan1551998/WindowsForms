using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCartas
{
    public partial class Form1 : Form
    {
        List<Cartas> listaCartasNew = new List<Cartas>();
        Baraja baraja = new Baraja();
         
        public Form1()
        {
            InitializeComponent();
        }

        private void botonCrearCartas_Click(object sender, EventArgs e)
        {
            
            imprimiBaraja();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textoCuantasCartas.Text = this.baraja.NumeroCartas().ToString();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cartas carta = this.baraja.RobaCarta();
            this.textoCuantasCartas.Text = this.baraja.NumeroCartas().ToString();
            imprimiBaraja();
            this.textCogerCarta.Text = carta.CrearCarta();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCogerCarta_Click(object sender, EventArgs e)
        {
            String c = this.cogerCartaInput.Text;
            Cartas carta = this.baraja.CogeCarta(int.Parse(c));
            this.textoCuantasCartas.Text = this.baraja.NumeroCartas().ToString();
            imprimiBaraja();
            this.textCogerCarta.Text = carta.CrearCarta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cartas carta = this.baraja.CogeCartaAlAzar();
            this.textoCuantasCartas.Text = this.baraja.NumeroCartas().ToString();
            imprimiBaraja();
            this.textCogerCarta.Text = carta.CrearCarta();
        }

        private void barajarCartas_Click(object sender, EventArgs e)
        {
            baraja.ListaCartas = this.baraja.Barajar();


            this.listaBaraja.Items.Clear();
            
            imprimiBaraja();
        }
        public  void imprimiBaraja() {

            this.listaBaraja.Items.Clear();

            for (int i = 0; i < this.baraja.ListaCartas.Count(); i++)
            {
                this.listaBaraja.Items.Add(baraja.ListaCartas[i].CrearCarta());
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
