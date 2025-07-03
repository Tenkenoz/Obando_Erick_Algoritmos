using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obando_Erick_Algoritmos
{
    internal class AlgoritmoBresenhamElipse : CurvaConica
    {
        int a2, b2, fx, fy,p;
        public void CalcularCurva(PictureBox picCanvas, int xc, int a, int b, int yc)
        {
            if (a <= 0 || b <= 0)
            {
                MessageBox.Show("Los semiejes 'a' y 'b' deben ser mayores que cero.", "Error");
                return;
            }

            int x = 0;
            int y = b;
            a2 = a * a;
            b2 = b * b;
            fx = 0;
            fy = 2 * a2 * y;

            // Región 1
             p = (int)(b2 - (a2 * b) + (0.25 * a2));
            while (fx < fy)
            {
                DrawSymmetricPoints(picCanvas, xc, yc, x, y);
                x++;
                fx += 2 * b2;
                if (p < 0)
                {
                    p += b2 * (2 * x + 1);
                }
                else
                {
                    y--;
                    fy -= 2 * a2;
                    p += b2 * (2 * x + 1) - fy;
                }
            }

            // Región 2
            p = (int)(b2 * (x + 0.5) * (x + 0.5) + a2 * (y - 1) * (y - 1) - a2 * b2);
            while (y >= 0)
            {
                DrawSymmetricPoints(picCanvas, xc, yc, x, y);
                y--;
                fy -= 2 * a2;
                if (p > 0)
                {
                    p += a2 * (1 - 2 * y);
                }
                else
                {
                    x++;
                    fx += 2 * b2;
                    p += fx - fy + a2;
                }
            }
        }

        public override void DrawSymmetricPoints(PictureBox picCanvas, int xc, int yc, int x, int y)
        {
            Pen pen = new Pen(Color.Black, 1);
            GraficarPixel(picCanvas, xc + x, yc + y,pen);
            EscribirCoordenadas(xc + x, yc + y);

            GraficarPixel(picCanvas, xc - x, yc + y,pen);
            EscribirCoordenadas(xc - x, yc + y);

            GraficarPixel(picCanvas, xc + x, yc - y,pen);
            EscribirCoordenadas(xc + x, yc - y);

            GraficarPixel(picCanvas, xc - x, yc - y,pen);
            EscribirCoordenadas(xc - x, yc - y);
        }


    }
}
