
namespace WindowsFormsCartas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonCrearCartas = new System.Windows.Forms.Button();
            this.listaBaraja = new System.Windows.Forms.ListBox();
            this.cuantasCartas = new System.Windows.Forms.Label();
            this.btnCuantasCartas = new System.Windows.Forms.Button();
            this.textoCuantasCartas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCogerCarta = new System.Windows.Forms.Button();
            this.cogerCarta = new System.Windows.Forms.Label();
            this.cogerCartaInput = new System.Windows.Forms.TextBox();
            this.btnCogerCartaAlazar = new System.Windows.Forms.Button();
            this.barajarCartas = new System.Windows.Forms.Button();
            this.cartaCoger = new System.Windows.Forms.Label();
            this.textCogerCarta = new System.Windows.Forms.Label();
            this.pictureCard = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCard)).BeginInit();
            this.SuspendLayout();
            // 
            // botonCrearCartas
            // 
            this.botonCrearCartas.Location = new System.Drawing.Point(641, 343);
            this.botonCrearCartas.Name = "botonCrearCartas";
            this.botonCrearCartas.Size = new System.Drawing.Size(126, 61);
            this.botonCrearCartas.TabIndex = 0;
            this.botonCrearCartas.Text = "Mostrar cartas";
            this.botonCrearCartas.UseVisualStyleBackColor = true;
            this.botonCrearCartas.Click += new System.EventHandler(this.botonCrearCartas_Click);
            // 
            // listaBaraja
            // 
            this.listaBaraja.FormattingEnabled = true;
            this.listaBaraja.ItemHeight = 16;
            this.listaBaraja.Location = new System.Drawing.Point(25, 4);
            this.listaBaraja.Name = "listaBaraja";
            this.listaBaraja.Size = new System.Drawing.Size(336, 420);
            this.listaBaraja.TabIndex = 1;
            // 
            // cuantasCartas
            // 
            this.cuantasCartas.AutoSize = true;
            this.cuantasCartas.Location = new System.Drawing.Point(391, 29);
            this.cuantasCartas.Name = "cuantasCartas";
            this.cuantasCartas.Size = new System.Drawing.Size(0, 17);
            this.cuantasCartas.TabIndex = 2;
            // 
            // btnCuantasCartas
            // 
            this.btnCuantasCartas.Location = new System.Drawing.Point(394, 70);
            this.btnCuantasCartas.Name = "btnCuantasCartas";
            this.btnCuantasCartas.Size = new System.Drawing.Size(139, 36);
            this.btnCuantasCartas.TabIndex = 3;
            this.btnCuantasCartas.Text = "Cuantas cartas";
            this.btnCuantasCartas.UseVisualStyleBackColor = true;
            this.btnCuantasCartas.Click += new System.EventHandler(this.button1_Click);
            // 
            // textoCuantasCartas
            // 
            this.textoCuantasCartas.AutoSize = true;
            this.textoCuantasCartas.Location = new System.Drawing.Point(527, 46);
            this.textoCuantasCartas.Name = "textoCuantasCartas";
            this.textoCuantasCartas.Size = new System.Drawing.Size(24, 17);
            this.textoCuantasCartas.TabIndex = 4;
            this.textoCuantasCartas.Text = "48";
            this.textoCuantasCartas.Click += new System.EventHandler(this.textoCuantasCartas_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Robar carta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCogerCarta
            // 
            this.btnCogerCarta.Location = new System.Drawing.Point(394, 234);
            this.btnCogerCarta.Name = "btnCogerCarta";
            this.btnCogerCarta.Size = new System.Drawing.Size(139, 34);
            this.btnCogerCarta.TabIndex = 6;
            this.btnCogerCarta.Text = "Coger carta";
            this.btnCogerCarta.UseVisualStyleBackColor = true;
            this.btnCogerCarta.Click += new System.EventHandler(this.btnCogerCarta_Click);
            // 
            // cogerCarta
            // 
            this.cogerCarta.AutoSize = true;
            this.cogerCarta.Location = new System.Drawing.Point(394, 174);
            this.cogerCarta.Name = "cogerCarta";
            this.cogerCarta.Size = new System.Drawing.Size(127, 17);
            this.cogerCarta.TabIndex = 7;
            this.cogerCarta.Text = "Que carta queres?";
            this.cogerCarta.Click += new System.EventHandler(this.label1_Click);
            // 
            // cogerCartaInput
            // 
            this.cogerCartaInput.Location = new System.Drawing.Point(394, 194);
            this.cogerCartaInput.Name = "cogerCartaInput";
            this.cogerCartaInput.Size = new System.Drawing.Size(139, 22);
            this.cogerCartaInput.TabIndex = 8;
            this.cogerCartaInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCogerCartaAlazar
            // 
            this.btnCogerCartaAlazar.Location = new System.Drawing.Point(394, 289);
            this.btnCogerCartaAlazar.Name = "btnCogerCartaAlazar";
            this.btnCogerCartaAlazar.Size = new System.Drawing.Size(139, 37);
            this.btnCogerCartaAlazar.TabIndex = 9;
            this.btnCogerCartaAlazar.Text = "Coger carta al azar";
            this.btnCogerCartaAlazar.UseVisualStyleBackColor = true;
            this.btnCogerCartaAlazar.Click += new System.EventHandler(this.button2_Click);
            // 
            // barajarCartas
            // 
            this.barajarCartas.Location = new System.Drawing.Point(394, 343);
            this.barajarCartas.Name = "barajarCartas";
            this.barajarCartas.Size = new System.Drawing.Size(139, 32);
            this.barajarCartas.TabIndex = 10;
            this.barajarCartas.Text = "Barajar";
            this.barajarCartas.UseVisualStyleBackColor = true;
            this.barajarCartas.Click += new System.EventHandler(this.barajarCartas_Click);
            // 
            // cartaCoger
            // 
            this.cartaCoger.AutoSize = true;
            this.cartaCoger.Location = new System.Drawing.Point(595, 46);
            this.cartaCoger.Name = "cartaCoger";
            this.cartaCoger.Size = new System.Drawing.Size(172, 17);
            this.cartaCoger.TabIndex = 11;
            this.cartaCoger.Text = "Que carta cogiste/robaste";
            this.cartaCoger.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textCogerCarta
            // 
            this.textCogerCarta.AutoSize = true;
            this.textCogerCarta.Location = new System.Drawing.Point(598, 70);
            this.textCogerCarta.Name = "textCogerCarta";
            this.textCogerCarta.Size = new System.Drawing.Size(0, 17);
            this.textCogerCarta.TabIndex = 12;
            // 
            // pictureCard
            // 
            this.pictureCard.Location = new System.Drawing.Point(598, 101);
            this.pictureCard.Name = "pictureCard";
            this.pictureCard.Size = new System.Drawing.Size(169, 196);
            this.pictureCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCard.TabIndex = 13;
            this.pictureCard.TabStop = false;
            this.pictureCard.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cuantas cartas hay";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureCard);
            this.Controls.Add(this.textCogerCarta);
            this.Controls.Add(this.cartaCoger);
            this.Controls.Add(this.barajarCartas);
            this.Controls.Add(this.btnCogerCartaAlazar);
            this.Controls.Add(this.cogerCartaInput);
            this.Controls.Add(this.cogerCarta);
            this.Controls.Add(this.btnCogerCarta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textoCuantasCartas);
            this.Controls.Add(this.btnCuantasCartas);
            this.Controls.Add(this.cuantasCartas);
            this.Controls.Add(this.listaBaraja);
            this.Controls.Add(this.botonCrearCartas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonCrearCartas;
        private System.Windows.Forms.ListBox listaBaraja;
        private System.Windows.Forms.Label cuantasCartas;
        private System.Windows.Forms.Button btnCuantasCartas;
        private System.Windows.Forms.Label textoCuantasCartas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCogerCarta;
        private System.Windows.Forms.Label cogerCarta;
        private System.Windows.Forms.TextBox cogerCartaInput;
        private System.Windows.Forms.Button btnCogerCartaAlazar;
        private System.Windows.Forms.Button barajarCartas;
        private System.Windows.Forms.Label cartaCoger;
        private System.Windows.Forms.Label textCogerCarta;
        private System.Windows.Forms.PictureBox pictureCard;
        private System.Windows.Forms.Label label1;
    }
}

