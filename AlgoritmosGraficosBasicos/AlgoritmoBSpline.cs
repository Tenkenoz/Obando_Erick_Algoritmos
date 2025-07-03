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
    internal class AlgoritmoBSpline
    {
        private List<PointF> puntosControl;

        public void SetControlPoints(List<PointF> puntos)
        {
            puntosControl = puntos;
        }

        public void DibujarCurvaBSpline(PictureBox picCanvas, Pen pen, double precision, int grado)
        {
            if (puntosControl == null || puntosControl.Count < grado + 1)
            {
                // Mostrar mensaje de puntos insuficientes
                Bitmap bmpMensaje = new Bitmap(picCanvas.Width, picCanvas.Height);
                using (Graphics g = Graphics.FromImage(bmpMensaje))
                {
                    g.Clear(Color.White);
                    g.DrawString($"Se necesitan al menos {grado + 1} puntos",
                                new Font("Arial", 10),
                                Brushes.Red,
                                10, 10);
                }
                picCanvas.Image = bmpMensaje;
                return;
            }

            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
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
                if (puntosControl.Count > 1)
                {
                    g.DrawLines(Pens.LightGray, puntosControl.ToArray());
                }

                // Calcular y dibujar curva B-spline
                List<PointF> curva = CalcularCurvaBSpline(precision, grado);
                if (curva.Count > 1)
                {
                    g.DrawLines(pen, curva.ToArray());
                }
            }

            picCanvas.Image = bmp;
        }

        private List<PointF> CalcularCurvaBSpline(double precision, int grado)
        {
            List<PointF> puntosCurva = new List<PointF>();
            int n = puntosControl.Count - 1;

            // Calcular vector de nodos uniforme
            int numNodos = n + grado + 2;
            double[] knots = new double[numNodos];
            for (int i = 0; i < numNodos; i++)
            {
                knots[i] = i;
            }

            // Calcular puntos de la curva
            double tMin = grado;
            double tMax = n;

            for (double t = tMin; t <= tMax; t += precision)
            {
                PointF p = CalcularPunto(t, grado, knots);
                puntosCurva.Add(p);
            }

            return puntosCurva;
        }

        private PointF CalcularPunto(double t, int grado, double[] knots)
        {
            PointF resultado = new PointF(0, 0);
            double sumaPesos = 0;

            for (int i = 0; i < puntosControl.Count; i++)
            {
                double peso = FuncionBaseBSpline(i, grado, t, knots);
                sumaPesos += peso;
                resultado.X += (float)(peso * puntosControl[i].X);
                resultado.Y += (float)(peso * puntosControl[i].Y);
            }

            // Normalizar si es necesario
            if (sumaPesos > 0)
            {
                resultado.X /= (float)sumaPesos;
                resultado.Y /= (float)sumaPesos;
            }

            return resultado;
        }

        private double FuncionBaseBSpline(int i, int k, double t, double[] knots)
        {
            // Algoritmo recursivo de Cox-de Boor
            if (k == 0)
            {
                return (knots[i] <= t && t < knots[i + 1]) ? 1.0 : 0.0;
            }

            double numerador1 = t - knots[i];
            double denominador1 = knots[i + k] - knots[i];
            double termino1 = 0;

            if (denominador1 != 0)
            {
                termino1 = numerador1 / denominador1 * FuncionBaseBSpline(i, k - 1, t, knots);
            }

            double numerador2 = knots[i + k + 1] - t;
            double denominador2 = knots[i + k + 1] - knots[i + 1];
            double termino2 = 0;

            if (denominador2 != 0)
            {
                termino2 = numerador2 / denominador2 * FuncionBaseBSpline(i + 1, k - 1, t, knots);
            }

            return termino1 + termino2;
        }
    }
}
