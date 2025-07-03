using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obando_Erick_Algoritmos
{
    internal class AlgoritmoSutherlandHodgman : AlgoritmoCohenSutherland
    {
        public static List<Point> RecortarPoligono(List<Point> puntos,
                                                int xmax, int ymax,
                                                int xmin, int ymin)
        {
            var resultado = new List<Point>();
            var recortador = new AlgoritmoSutherlandHodgman();

            // Recortar cada segmento del polígono
            for (int i = 0; i < puntos.Count - 1; i++)
            {
                int x1 = puntos[i].X;
                int y1 = puntos[i].Y;
                int x2 = puntos[i + 1].X;
                int y2 = puntos[i + 1].Y;

                // Aplicar el algoritmo Cohen-Sutherland a cada línea
                Point[] segmento = recortador.DibujarLineaCohen(x1, y1, x2, y2, xmax, ymax, xmin, ymin);

                // Si el segmento no es null y contiene puntos válidos, agrégalo al resultado
                if (segmento != null && segmento.Length == 2)
                {
                    Point pInicio = segmento[0];
                    Point pFin = segmento[1];

                    // Asegurarse de que no agregamos duplicados
                    if (resultado.Count == 0 || !resultado.Last().Equals(pInicio))
                        resultado.Add(pInicio);

                    resultado.Add(pFin);
                }
            }

            return resultado;
        }

        public void DibujarPoligonoRecortado(PictureBox picCanvas, List<Point> puntos,
                                             int xmax, int ymax,
                                             int xmin, int ymin)
        {
            if (puntos == null || puntos.Count < 3)
            {
                MessageBox.Show("Se requiere al menos un polígono con 3 vértices.");
                return;
            }

            List<Point> puntosRecortados = RecortarPoligono(puntos, xmax, ymax, xmin, ymin);
            foreach (var punto in puntosRecortados)
            {
                GraficarPixelR(picCanvas, punto.X, punto.Y);
                EscribirCoordenadas(punto.X, punto.Y);
            }
        }

    }
}
