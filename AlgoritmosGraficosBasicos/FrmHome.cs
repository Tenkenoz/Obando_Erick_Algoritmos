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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void lineasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void dDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLineas aux = FrmLineas.Instance;
            aux.MdiParent = this;
            aux.Show();

        }


        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void poligonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRellenos frmPoligonos = FrmRellenos.Instance;
            frmPoligonos.MdiParent = this;
            frmPoligonos.Show();
        }

        private void recorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRecorteDeLíneas frmRecorte = FrmRecorteDeLíneas.Instance;
            frmRecorte.MdiParent = this;
            frmRecorte.Show();
        }

        private void dePolígonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRecortePoligono frmRecortePoligono = FrmRecortePoligono.Instance;
            frmRecortePoligono.MdiParent = this;
            frmRecortePoligono.Show();
        }

        private void curvasDeBézierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCurvasBézier frmCurvasBézier = FrmCurvasBézier.Instance;
            frmCurvasBézier.MdiParent = this;
            frmCurvasBézier.Show();
        }

        private void bsplinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBSplines frmBSplines = FrmBSplines.Instance;
            frmBSplines.MdiParent = this;
            frmBSplines.Show();

        }

        private void curvasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCurvas frmCirculo = FrmCurvas.Instance;
            frmCirculo.MdiParent = this;
            frmCirculo.Show();
        }
    }
}
