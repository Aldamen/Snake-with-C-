using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesSnake
{
    class Cola:Snake
    {
        Cola Seguidor;
        public Cola(int x, int y)
        {
            this.x = x;
            this.y = y;
            Seguidor = null;
        }
        public void dibujar(Graphics g)
        {
            if (Seguidor != null)
            {
                Seguidor.dibujar(g);
            }
            g.FillRectangle(new SolidBrush(Color.Black), this.x, this.y, this.ancho, this.ancho);
        }
        public void movimientoxy(int x, int y)
        {
            if (Seguidor != null)
            {
                Seguidor.movimientoxy(this.x, this.y);
            }
            this.x = x;
            this.y = y;
        }
        public void agregar()
        {
            if (Seguidor == null)
            {
                Seguidor = new Cola(this.x, this.y);
            }
            else
            {
                Seguidor.agregar();
            }
        }
        public int posicionx()
        {
            return this.x;
        }
        public int posiciony()
        {
            return this.y;
        }
        public Cola Next()
        {
            return Seguidor;
        }

    }
}
