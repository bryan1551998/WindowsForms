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
            this.pictureCard.Image = Properties.Resources.carta_al_reves_Búsqueda_de_Google;
        }

        private void botonCrearCartas_Click(object sender, EventArgs e)
        {
            imprimiBaraja();
            this.pictureCard.Image = Properties.Resources.carta_al_reves_Búsqueda_de_Google;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textoCuantasCartas.Text = this.baraja.NumeroCartas().ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cartas carta = this.baraja.RobaCarta();
            if (carta != null)
            {
                this.textoCuantasCartas.Text = this.baraja.NumeroCartas().ToString();
                imprimiBaraja();
                this.textCogerCarta.Text = carta.CrearCarta();
                this.pictureCard.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(carta.CrearCarta());
            }
            else {
                this.textCogerCarta.Text = "NO HAY MAS CARTAS";
                this.pictureCard.Image = Properties.Resources.carta_al_reves_Búsqueda_de_Google;
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCogerCarta_Click(object sender, EventArgs e)
        {
            int numberCarta;
            bool success = int.TryParse(this.cogerCartaInput.Text, out numberCarta);

            if (success)
            {
                String c = this.cogerCartaInput.Text;
                Cartas carta = this.baraja.CogeCarta(numberCarta - 1);
                this.textoCuantasCartas.Text = this.baraja.NumeroCartas().ToString();
                imprimiBaraja();
                this.textCogerCarta.Text = carta.CrearCarta();
                this.cogerCartaInput.Text = "";
                this.pictureCard.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(carta.CrearCarta());
            }
            else
            {
                this.cogerCartaInput.Text = "";
                MessageBox.Show("Introuce un numero");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cartas carta = this.baraja.CogeCartaAlAzar();
            this.textoCuantasCartas.Text = this.baraja.NumeroCartas().ToString();
            imprimiBaraja();
            this.textCogerCarta.Text = carta.CrearCarta();
            this.pictureCard.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(carta.CrearCarta());
        }

        private void barajarCartas_Click(object sender, EventArgs e)
        {
            baraja.ListaCartas = this.baraja.Barajar();
            this.listaBaraja.Items.Clear();
            imprimiBaraja();
        }

        public void imprimiBaraja()
        {
            this.listaBaraja.Items.Clear();

            for (int i = 0; i < this.baraja.ListaCartas.Count(); i++)
            {
                this.listaBaraja.Items.Add(baraja.ListaCartas[i].CrearCarta());
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textoCuantasCartas_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
