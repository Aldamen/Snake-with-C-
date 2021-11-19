using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using ClasesSnake;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNAKE
{
    public partial class Form2 : Form
    {
        int punto = 0;
        Cola Cabeza;
        Comida comida;
        Graphics g;
        int direccionx = 0, direcciony = 0;
        Boolean ejex = true, ejey = true;
        int cuadro = 20;
        public Form2()
        {
            InitializeComponent();
            Cabeza = new Cola(20, 20);
            comida = new Comida();
            g = cuadrojuego.CreateGraphics();
        }
        
        public void movimiento()
        {
            Cabeza.movimientoxy(Cabeza.posicionx() + direccionx, Cabeza.posiciony() + direcciony);
        }
        private void timermovimiento_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Cabeza.dibujar(g);
            comida.dibujar(g);
            movimiento();
            choquecuerpo();
            ChoquePared();
            if (Cabeza.interseccion(comida))
            { 
                punto = punto + 12;
                puntaje.Text = Convert.ToString(punto);
                comida.colocar();
                Cabeza.agregar();

            }
        }
        public void gameover()
        {
            
            Form3 Resultados = new Form3();
            this.Hide();
        }
       
        public void choquecuerpo()
        {
            Cola temporal;
            try
            {
                temporal = Cabeza.Next().Next();
            }
            catch(Exception error)
            {
                temporal = null;
            }
            while (temporal != null)
            {
                if (Cabeza.interseccion(temporal))
                {
                    gameover();
                    
                }
                else
                {
                    temporal = temporal.Next();
                }
            }

        }
        private void ChoquePared()
        {
            if (Cabeza.posicionx() < 0||Cabeza.posicionx()>1180||Cabeza.posiciony()<0||Cabeza.posiciony()>580)
            {
                gameover();
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (ejex)
            {
                if (e.KeyCode == Keys.Up)
                {
                    direcciony = -cuadro;
                    direccionx = 0;
                    ejex = false;
                    ejey = true;
                }
                if (e.KeyCode == Keys.Down)
                {
                    direcciony = cuadro;
                    direccionx = 0;
                    ejex = false;
                    ejey = true;
                }
            }
            if (ejey)
            {
                if (e.KeyCode == Keys.Right)
                {
                    direcciony = 0;
                    direccionx = cuadro;
                    ejex = true;
                    ejey = false;
                }
                if (e.KeyCode == Keys.Left)
                {
                    direcciony = 0;
                    direccionx = -cuadro;
                    ejex = true;
                    ejey = false;
                }
            }
        }
    } 
        
}

