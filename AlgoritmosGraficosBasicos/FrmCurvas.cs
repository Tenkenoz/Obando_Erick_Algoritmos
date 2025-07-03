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
    public partial class FrmCurvas : Form
    {
        private static FrmCurvas _instance;
        int SF = 10;
        AlgoritmoCirculoBresenham algoritmoCirculoBresenham = new AlgoritmoCirculoBresenham();
        AlgoritmoBresenhamElipse algoritmoBrasenhamElipse = new AlgoritmoBresenhamElipse();
        public static FrmCurvas Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FrmCurvas();
                }
                return _instance;
            }
        }
        public FrmCurvas()
        {
            InitializeComponent();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDibujar2_Click(object sender, EventArgs e)
        {
            picCanvas2.Refresh();
            int xc = picCanvas.Width / 2;
            int yc = picCanvas.Height / 2;
            int SemiEjeMayor = Convert.ToInt32(txtSMayor.Text) * SF;
            int SemiEjeMenor = Convert.ToInt32(txtSMenor.Text) * SF;
            algoritmoBrasenhamElipse.CalcularCurva(picCanvas, xc, SemiEjeMayor, SemiEjeMenor, yc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picCanvas2.Refresh();
            int xc = picCanvas2.Width / 2;
            int yc = picCanvas2.Height / 2;
            int r = Convert.ToInt32(txtRadio.Text) * SF;
            algoritmoCirculoBresenham.CalcularCurva(picCanvas2, xc, yc, r);
        }
    }
}
