using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2_SIM.Distribuciones;

namespace TP2_SIM
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            btn_generar.Hide();

            rbUniforme.Checked = false;
            rbNormal.Checked = false;
            rbExponencialNegativa.Checked = false;

            DeshabilitarElementos();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            if (rbUniforme.Checked == false && rbNormal.Checked == false && rbExponencialNegativa.Checked == false)
            {
                MessageBox.Show("Error: Debe seleccionar una de las distribuciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ComenzarEjecucion();
            }
        }

        public void ComenzarEjecucion()
        {

            if (rbExponencialNegativa.Checked == true)
            {
                ExponencialNegativa exponencialNegativa = new ExponencialNegativa();

                exponencialNegativa.CantidadMuestra = Convert.ToInt32(numMuestraExponencial.Text.Trim());
                exponencialNegativa.CantidadIntervalos = Convert.ToInt32(numIntervalosExponencial.Text.Trim());
                exponencialNegativa.Lambda = (double)numLambdaExponencial.Value;
                exponencialNegativa.Lista = listaVariablesAleatorias;
                exponencialNegativa.Grafico = chartDistribucion;

                exponencialNegativa.Grilla = dgvDatos;

                if (exponencialNegativa.CantidadMuestra > 0)
                {
                    exponencialNegativa.GenerarDistribucion(exponencialNegativa);
                    HabilitarElementos();
                }
                else
                {
                    MessageBox.Show("Error: La muestra no puede ser 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void rbExponencialNegativa_CheckedChanged(object sender, EventArgs e)
        {
            DeshabilitarElementos();
            btn_generar.Show();

            gbNormal.Visible = false;
            gbUniforme.Visible = false;
            gbExponencial.Visible = true;

        }

        private void DeshabilitarElementos()
        {
            listaVariablesAleatorias.Visible = false;
            dgvDatos.Visible = false;
            chartDistribucion.Visible = false;
        }

        private void HabilitarElementos()
        {
            listaVariablesAleatorias.Visible = true;
            dgvDatos.Visible = true;
            chartDistribucion.Visible = true;
        }
    }
}
