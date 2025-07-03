using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obando_Erick_Algoritmos
{
    internal abstract class CurvaConica: TablaPuntos
    {
        public abstract void DrawSymmetricPoints(PictureBox picCanvas, int xc, int yc, int x, int y);
    }
}
