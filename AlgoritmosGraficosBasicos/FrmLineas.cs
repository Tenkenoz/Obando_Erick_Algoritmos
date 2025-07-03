using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obando_Erick_Algoritmos
{
    public partial class FrmLineas : Form
    {
        private static FrmLineas _instance;
        Graphics g;
        Pen pen = new Pen(Color.Black, 2);
        DibujarLinea objdibujarLinea;
        private List<Point> puntosClick1 = new List<Point>();
        private List<Point> puntosClick2 = new List<Point>();
        public static FrmLineas Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FrmLineas();
                }
                return _instance;
            }
        }
        public FrmLineas()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            objdibujarLinea = new AlgoritmoDDA();
            puntosClick1.Add(new Point(e.X, e.Y));
            g = picCanvas.CreateGraphics();
            g.DrawRectangle(pen, e.X, e.Y, 1, 1);
            MessageBox.Show($"Punto agregado: {e.X}, {e.Y}");

            if (puntosClick1.Count == 2)
            {

                objdibujarLinea.ObtenerPuntos(puntosClick1[0].X, puntosClick1[0].Y, puntosClick1[1].X, puntosClick1[1].Y);
                objdibujarLinea.CalcularPuntos(picCanvas, pen);
                puntosClick1.Clear();

            }
           
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }

        private void picCanvas2_MouseClick(object sender, MouseEventArgs e)
        {
            objdibujarLinea = new AlgortimoBresenham();
            puntosClick2.Add(new Point(e.X, e.Y));
            g = picCanvas2.CreateGraphics();
            g.DrawRectangle(pen, e.X, e.Y, 1, 1);
            MessageBox.Show($"Punto agregado: {e.X}, {e.Y}");
            if (puntosClick2.Count == 2)
            {

                objdibujarLinea.ObtenerPuntos(puntosClick2[0].X, puntosClick2[0].Y, puntosClick2[1].X, puntosClick2[1].Y);
                objdibujarLinea.CalcularPuntos(picCanvas2, pen );
                puntosClick2.Clear();

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmLineas_Load(object sender, EventArgs e)
        {

        }
    }


}