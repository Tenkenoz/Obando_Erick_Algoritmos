using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Obando_Erick_Algoritmos
{
    public partial class FrmBSplines : Form
    {
        private static FrmBSplines instance;
        public static FrmBSplines Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmBSplines();
                }
                return instance;
            }
        }
        private int numPuntos;
        private List<PointF> puntosControl = new List<PointF>();
        private bool recopilandoPuntos = false;
        private Pen pen = new Pen(Color.Blue, 2f);
        private AlgoritmoBSpline algoritmo = new AlgoritmoBSpline();
        private int puntoSeleccionado = -1;
        private bool arrastrando = false;
        private Bitmap canvasBitmap;
        private int grado = 3; // Grado de la curva B-Spline (cúbica por defecto)

        public FrmBSplines()
        {
            InitializeComponent();

            // Configurar TrackBar de precisión
            trackBarPrecision.Minimum = 1;
            trackBarPrecision.Maximum = 100;
            trackBarPrecision.Value = 50;
            trackBarPrecision.TickFrequency = 10;
            lblPrecision.Text = $"Precisión: {(trackBarPrecision.Value / 1000.0):0.000}";

            // Configurar TrackBar de grado
            trackBarGrado.Minimum = 1;
            trackBarGrado.Maximum = 5;
            trackBarGrado.Value = 3;
            trackBarGrado.TickFrequency = 1;
            lblGrado.Text = $"Grado: {trackBarGrado.Value}";

            // Crear bitmap para el lienzo
            canvasBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(canvasBitmap))
            {
                g.Clear(Color.White);
            }
            picCanvas.Image = canvasBitmap;

            // Configurar título del formulario
            this.Text = "Curvas B-Spline";
        }

        private void btnCrearCurva_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPuntos.Text, out numPuntos) && numPuntos >= 2)
            {
                puntosControl.Clear();
                recopilandoPuntos = true;
                arrastrando = false;
                puntoSeleccionado = -1;
                LimpiarCanvas();
                lblEstado.Text = $"Haga clic en {numPuntos} puntos en el lienzo";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido de puntos (mínimo 2).");
            }
        }

        private void trackBarPrecision_Scroll(object sender, EventArgs e)
        {
            lblPrecision.Text = $"Precisión: {(trackBarPrecision.Value / 1000.0):0.000}";
            if (puntosControl.Count >= grado + 1)
            {
                DibujarCurva();
            }
        }

        private void trackBarGrado_Scroll(object sender, EventArgs e)
        {
            grado = trackBarGrado.Value;
            lblGrado.Text = $"Grado: {grado}";
            if (puntosControl.Count >= grado + 1)
            {
                DibujarCurva();
            }
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
      
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private float Distancia(PointF p1, PointF p2)
        {
            return (float)Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        private void LimpiarCanvas()
        {
            using (Graphics g = Graphics.FromImage(canvasBitmap))
            {
                g.Clear(Color.White);
            }
            picCanvas.Image = canvasBitmap;
            picCanvas.Invalidate();
        }

        private void DibujarCurva()
        {
            double precision = trackBarPrecision.Value / 1000.0;
            algoritmo.DibujarCurvaBSpline(picCanvas, pen, precision, grado);
            canvasBitmap = (Bitmap)picCanvas.Image; // Mantener sincronizado
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            puntosControl.Clear();
            recopilandoPuntos = false;
            arrastrando = false;
            puntoSeleccionado = -1;
            LimpiarCanvas();
            lblEstado.Text = "Listo para crear una nueva curva";
        }

        private void picCanvas_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (recopilandoPuntos)
            {
                puntosControl.Add(e.Location);
                algoritmo.SetControlPoints(puntosControl);
                DibujarCurva();

                if (puntosControl.Count == numPuntos)
                {
                    recopilandoPuntos = false;
                    lblEstado.Text = "Arrastre los puntos para modificar la curva";
                }
                else
                {
                    lblEstado.Text = $"Puntos: {puntosControl.Count}/{numPuntos}";
                }
            }
        }

        private void picCanvas_MouseUp_1(object sender, MouseEventArgs e)
        {
            arrastrando = false;
            puntoSeleccionado = -1;
        }

        private void picCanvas_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (arrastrando && puntoSeleccionado >= 0)
            {
                puntosControl[puntoSeleccionado] = e.Location;
                algoritmo.SetControlPoints(puntosControl);
                DibujarCurva();
            }
        }

        private void picCanvas_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (!recopilandoPuntos && puntosControl.Count > 0)
            {
                for (int i = 0; i < puntosControl.Count; i++)
                {
                    float distancia = Distancia(e.Location, puntosControl[i]);
                    if (distancia <= 10)
                    {
                        puntoSeleccionado = i;
                        arrastrando = true;
                        break;
                    }
                }
            }
        }
    }

    
}