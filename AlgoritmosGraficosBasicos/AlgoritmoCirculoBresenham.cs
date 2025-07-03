using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obando_Erick_Algoritmos
{
    internal class AlgoritmoCirculoBresenham : CurvaConica
    {
        public AlgoritmoCirculoBresenham()
        {
        }

        public void CalcularCurva(PictureBox picCanvas, int xc, int yc, int r)
        {
            int x = 0, y = r;
            int p = 1 - r;
            DrawSymmetricPoints(picCanvas, xc, yc, x, y);
            while (x < y)
            {
                x++;
                if (p < 0)
                {
                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
                DrawSymmetricPoints(picCanvas, xc, yc, x, y);

            }
        }

        public override void DrawSymmetricPoints(PictureBox g, int xc, int yc, int x, int y)
        {

            GraficarPixel(g, xc + x, yc + y,pen);
            EscribirCoordenadas(xc + x, yc + y);
            GraficarPixel(g, xc - x, yc + y, pen);
            EscribirCoordenadas(xc - x, yc + y);
            GraficarPixel(g, xc + x, yc - y, pen);
            EscribirCoordenadas(xc + x, yc - y);
            GraficarPixel(g, xc - x, yc - y, pen);
            EscribirCoordenadas(xc - x, yc - y);
            GraficarPixel(g, xc + y, yc + x, pen);
            EscribirCoordenadas(xc + y, yc + x);
            GraficarPixel(g, xc - y, yc + x, pen);
            EscribirCoordenadas(xc - y, yc + x);
            GraficarPixel(g, xc + y, yc - x, pen);
            EscribirCoordenadas(xc + y, yc - x);
            GraficarPixel(g, xc - y, yc - x, pen);
            EscribirCoordenadas(xc - y, yc - x);

        }


    }

}