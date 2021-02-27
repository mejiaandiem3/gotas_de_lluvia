using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gotas_de_lluvia
{
    public partial class Form1 : Form
    {

        public Graphics papel;
        public Random numeroAleatorio = new Random();

        public Form1()
        {
            InitializeComponent();
            papel = pictureBox1.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //iniciar
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //detener
            timer1.Stop();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //borrar
            papel.Clear(Color.Black);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x, y, tam;
            SolidBrush brocha = new SolidBrush(Color.White);
            x = numeroAleatorio.Next(0, pictureBox1.Width);
            y = numeroAleatorio.Next(0, pictureBox1.Height);
            tam = numeroAleatorio.Next(1, 15);
            papel.FillEllipse(brocha,x,y,tam,tam);
        }
    }
}
