using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Obando_Erick_Algoritmos
{
    public partial class FrmCurvasBézier : Form
    {
        private static FrmCurvasBézier instance;
        public static FrmCurvasBézier Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmCurvasBézier();
                }
                return instance;
            }
        }
        private int numPuntos;
        private List<PointF> puntosControl = new List<PointF>();
        private bool recopilandoPuntos = false;
        private Pen pen = new Pen(Color.Blue, 2f);
        private AlgoritmoCurvaBezier algoritmo = new AlgoritmoCurvaBezier();
        private int puntoSeleccionado = -1;
        private bool arrastrando = false;

        public FrmCurvasBézier()
        {
            InitializeComponent();

            // Configurar TrackBar
            trackBarPrecision.Minimum = 1;
            trackBarPrecision.Maximum = 100;
            trackBarPrecision.Value = 50;
            trackBarPrecision.TickFrequency = 10;
            lblPrecision.Text = $"Precisión: {(trackBarPrecision.Value / 100.0):0.00}";
            trackBarPrecision.ValueChanged += trackBarPrecision_ValueChanged;

            // Configurar eventos manualmente
            picCanvas.MouseDown += picCanvas_MouseDown;
            picCanvas.MouseMove += picCanvas_MouseMove;
            picCanvas.MouseUp += picCanvas_MouseUp;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void trackBarPrecision_ValueChanged(object sender, EventArgs e)
        {
            lblPrecision.Text = $"Precisión: {(trackBarPrecision.Value / 100.0):0.00}";
            if (puntosControl.Count >= 2)
                DibujarCurva();
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (recopilandoPuntos && e.Button == MouseButtons.Left)
            {
                // Agregar puntos de control al primer clic
                puntosControl.Add(e.Location);
                algoritmo.SetControlPoints(puntosControl);
                DibujarCurva();

                if (puntosControl.Count == numPuntos)
                {
                    recopilandoPuntos = false;
                    lblEstado.Text = "Arrastre los puntos para modificar la curva";
                }
                return;
            }

            // Seleccionar para arrastrar
            if (!recopilandoPuntos && puntosControl.Count > 0 && e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < puntosControl.Count; i++)
                {
                    if (Distancia(e.Location, puntosControl[i]) <= 8f)
                    {
                        puntoSeleccionado = i;
                        arrastrando = true;
                        break;
                    }
                }
            }
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastrando && puntoSeleccionado >= 0)
            {
                puntosControl[puntoSeleccionado] = e.Location;
                algoritmo.SetControlPoints(puntosControl);
                DibujarCurva();
            }
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrando = false;
            puntoSeleccionado = -1;
        }

        private float Distancia(PointF p1, PointF p2)
        {
            return (float)Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        private void LimpiarCanvas()
        {
            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
            }
            picCanvas.Image = bmp;
            picCanvas.Invalidate();
        }

        private void DibujarCurva()
        {
            double precision = trackBarPrecision.Value / 100.0;
            algoritmo.DibujarCurvaBezier(picCanvas, pen, precision);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }

    
}
