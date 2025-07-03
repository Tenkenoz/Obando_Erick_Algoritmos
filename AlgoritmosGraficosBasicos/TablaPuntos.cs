using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Obando_Erick_Algoritmos
{
    internal abstract class TablaPuntos
    {
        public Pen pen = new Pen(Color.Black, 4);
        public Pen penR = new Pen(Color.Red, 1);
        public Graphics graphics;

        public List<(int x, int y)> coordenadas = new List<(int x, int y)>();
        private readonly object lockCoordenadas = new object();


        public List<(int x, int y)> ObtenerCoordenadas()
        {
            return coordenadas;
        }

        public void EscribirCoordenadas(int x, int y)
        {
            lock (lockCoordenadas)
            {
                coordenadas.Add((x, y));
            }
        }
        public void BorrarCoordenadas()
        {
            lock (lockCoordenadas)
            {
                coordenadas.Clear();
            }
        }
        public void GraficarPixel(PictureBox picCanvas, int x, int y,Pen pen) {
            graphics = picCanvas.CreateGraphics();
            graphics.DrawRectangle(pen, x, y, 1, 1);
        }
        public void GraficarPixelR(PictureBox picCanvas, int x, int y)
        {
            graphics = picCanvas.CreateGraphics();
            graphics.DrawRectangle(penR, x, y, 1, 1);
        }

    }
}
