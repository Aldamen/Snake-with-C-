using System;
using SNAKE;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesSnake
{
    class Comida : Snake
    {
        public Comida()
        {
            this.x = Generador(60);
            this.y = Generador(30);
        }
        public void dibujar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Red), this.x, this.y, this.ancho, this.ancho);
        }
        public void colocar()
        {
            this.x = Generador(60);
            this.y = Generador(30);
        }
        public int Generador(int n)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, n) * 20;
            return num;
        }
    }
}
