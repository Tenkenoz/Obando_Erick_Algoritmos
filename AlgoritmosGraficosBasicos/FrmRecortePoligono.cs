using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Obando_Erick_Algoritmos
{
    public partial class FrmRecortePoligono : Form
    {
        private static FrmRecortePoligono _instance;
        Graphics g;
        private Point[] vertices = new Point[4]; // Array para almacenar los vértices del recuadro de recorte
        Pen pen = new Pen(Color.Black, 3); // Definimos un lápiz para dibujar
        AlgoritmoDDA algoritmoDDA = new AlgoritmoDDA(); // Instanciamos el algoritmo DDA
        private List<Point> clicks = new List<Point>(); // Lista para almacenar los puntos de clics
        AlgoritmoSutherlandHodgman algoritmoSutherlandHodgman = new AlgoritmoSutherlandHodgman(); // Instancia del algoritmo Sutherland-Hodgman
        public static FrmRecortePoligono Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FrmRecortePoligono();
                }
                return _instance;
            }
        }

        public FrmRecortePoligono()
        {
            InitializeComponent();
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            g = picCanvas.CreateGraphics();
            g.DrawRectangle(pen, e.X, e.Y, 1, 1); // Dibuja un punto en el canvas
            clicks.Add(new Point(e.X, e.Y));

        }



        private void btnDibujar_Click(object sender, EventArgs e)
        {
            int centrox = picCanvas.Width / 2;
            int centroy = picCanvas.Height / 2;

            vertices[0] = new Point(centrox - 50, centroy - 50); // Esquina superior izquierda
            vertices[1] = new Point(centrox + 50, centroy - 50); // Esquina superior derecha
            vertices[2] = new Point(centrox + 50, centroy + 50); // Esquina inferior derecha
            vertices[3] = new Point(centrox - 50, centroy + 50); // Esquina inferior izquierda
            algoritmoDDA.ObtenerPuntos(vertices[0].X, vertices[0].Y, vertices[1].X, vertices[1].Y);
            algoritmoDDA.CalcularPuntos(picCanvas, pen);
            algoritmoDDA.ObtenerPuntos(vertices[1].X, vertices[1].Y, vertices[2].X, vertices[2].Y);
            algoritmoDDA.CalcularPuntos(picCanvas, pen);
            algoritmoDDA.ObtenerPuntos(vertices[2].X, vertices[2].Y, vertices[3].X, vertices[3].Y);
            algoritmoDDA.CalcularPuntos(picCanvas, pen);
            algoritmoDDA.ObtenerPuntos(vertices[3].X, vertices[3].Y, vertices[0].X, vertices[0].Y);
            algoritmoDDA.CalcularPuntos(picCanvas, pen);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clicks.Count > 1)
            {
                // Dibujar la línea original (o el polígono original)
                using (Graphics g = picCanvas.CreateGraphics())
                {
                    g.DrawPolygon(new Pen(Color.Blue, 2), clicks.ToArray());
                }

                // Límites del cuadrado para recortar
                int xmin = vertices[0].X;
                int ymin = vertices[0].Y;
                int xmax = vertices[2].X;
                int ymax = vertices[2].Y;

                // Recortar el polígono
                List<Point> puntosRecortados = AlgoritmoSutherlandHodgman.RecortarPoligono(
                    clicks, xmax, ymax, xmin, ymin);

                // Dibujar el polígono recortado
                if (puntosRecortados.Count > 1)
                {
                    using (Graphics g = picCanvas.CreateGraphics())
                    {
                        g.DrawPolygon(new Pen(Color.Red, 2), puntosRecortados.ToArray()); // Dibuja el polígono recortado en rojo
                    }
                }
            }
        }
    }
}
