using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNAKE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btsonido_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btplay_Click(object sender, EventArgs e)
        {
            Form2 Jueg = new Form2();
            Jueg.Show();
            this.Hide();
        }
        bool mostrar = false;
        private void info_Click(object sender, EventArgs e)
        {
            if (mostrar == true)
            {
                creadores.Visible = false;
                mostrar = false;
            }
            else
            {
                creadores.Visible = true;
                mostrar = true;
            }
        }

        private void creadores_Click(object sender, EventArgs e)
        {

        }
        SoundPlayer sonido;

        private void sonidoon_Click(object sender, EventArgs e)
        {
            sonido = new SoundPlayer(Application.StartupPath + @"\son\xd.wav");
            sonido.Play();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                sonido = new SoundPlayer(Application.StartupPath + @"\son\xd.wav");
                //sonido.Play();
                sonido.PlayLooping();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error:" + error);
            }
        }

        private void sonidooff_Click(object sender, EventArgs e)
        {
            sonido = new SoundPlayer();
            sonido.Stop();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
