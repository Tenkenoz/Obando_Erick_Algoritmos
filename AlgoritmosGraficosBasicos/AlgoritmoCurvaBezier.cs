using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obando_Erick_Algoritmos
{
    internal class AlgoritmoCurvaBezier
    {
        private List<PointF> puntosControl;

        public void SetControlPoints(List<PointF> puntos)
        {
            puntosControl = new List<PointF>(puntos);
        }

        public void DibujarCurvaBezier(PictureBox picCanvas, Pen pen, double precision)
        {
            if (puntosControl == null || puntosControl.Count < 2)
                return;

            Bitmap bmp = picCanvas.Image as Bitmap ?? new Bitmap(picCanvas.Width, picCanvas.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.White);

                // Dibujar puntos de control
                foreach (var punto in puntosControl)
                {
                    g.FillEllipse(Brushes.Red, punto.X - 5, punto.Y - 5, 10, 10);
                    g.DrawEllipse(Pens.Black, punto.X - 5, punto.Y - 5, 10, 10);
                }

                // Dibujar líneas de control
                g.DrawLines(Pens.LightGray, puntosControl.ToArray());

                // Calcular y dibujar curva Bézier
                var curva = CalcularCurvaBezier(precision);
                if (curva.Count > 1)
                    g.DrawLines(pen, curva.ToArray());
            }

            picCanvas.Image = bmp;
        }

        private List<PointF> CalcularCurvaBezier(double precision)
        {
            var puntosCurva = new List<PointF>();
            double paso = precision;
            if (paso <= 0) paso = 0.01;

            for (double t = 0; t <= 1; t += paso)
                puntosCurva.Add(CalcularPunto(t));

            return puntosCurva;
        }

        private PointF CalcularPunto(double t)
        {
            int n = puntosControl.Count - 1;
            double x = 0, y = 0;

            for (int i = 0; i <= n; i++)
            {
                double coef = CoeficienteBinomial(n, i) * Math.Pow(1 - t, n - i) * Math.Pow(t, i);
                x += coef * puntosControl[i].X;
                y += coef * puntosControl[i].Y;
            }
            return new PointF((float)x, (float)y);
        }

        private double CoeficienteBinomial(int n, int k)
        {
            if (k < 0 || k > n) return 0;
            if (k == 0 || k == n) return 1;
            if (k == 1 || k == n - 1) return n;
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

        private double Factorial(int n)
        {
            if (n <= 1) return 1;
            double res = 1;
            for (int i = 2; i <= n; i++) res *= i;
            return res;
        }
    }
}
