using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_SIM.Distribuciones
{
    internal class Exponencial
    {
        public int CantidadMuestra { get; set; }
        public int CantidadIntervalos { get; set; }
        public double Lambda { get; set; }


        readonly Logica log = new Logica();

    }
}
