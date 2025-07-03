using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obando_Erick_Algoritmos
{
    public partial class FrmRellenos : Form
    {
        private static FrmRellenos _instance;
        int tamaño = 1; 
        
        AlgoritmoRelleno algoritmoRelleno = new AlgoritmoRelleno(); // Instanciamos el algoritmo de relleno
        AlgoritmoScanline AlgoritmoScanline = new AlgoritmoScanline(); // Instanciamos el algoritmo de Scanline

        public static FrmRellenos Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FrmRellenos();
                }
                return _instance;
            }
        }

        public FrmRellenos()
        {
            InitializeComponent();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {

        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLados_Click(object sender, EventArgs e)
        {
            Poligonos poligonos = new Poligonos();
            picCanvas.Refresh();

            if (int.Parse(txtLados.Text) < 3)
            {
                MessageBox.Show("Se requiere al menos un polígono con 3 lados.");
                return;
            }
            else
            {
                poligonos.ReadData(tamaño, txtLados);
                poligonos.GraficarPoligono(picCanvas, picCanvas.Width / 2, picCanvas.Height / 2);
                algoritmoRelleno.RellenarFigura(picCanvas, picCanvas.Width / 2, picCanvas.Height / 2, poligonos.ObtenerCoordenadas());
            }

        }

        private void btnLados2_Click(object sender, EventArgs e)
        {
            Poligonos poligonos = new Poligonos();
            picCanvas2.Refresh();
            if (int.Parse(txtLados2.Text) < 3)
            {
                MessageBox.Show("Se requiere al menos un polígono con 3 lados.");
                return;
            }
            else
            {
               
                poligonos.ReadData(tamaño, txtLados2);
                poligonos.GraficarPoligono(picCanvas2, picCanvas2.Width / 2, picCanvas2.Height / 2);
                AlgoritmoScanline.RellenarScanline(picCanvas2, poligonos.ObtenerCoordenadas());
            }
        }
    }
}
