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

            if (rbNormal.Checked == true)
            {
                Distribuciones.Normal normal = new Distribuciones.Normal();

                normal.CantidadMuestra = Convert.ToInt32(numMuestraNormal.Text.Trim());
                normal.Desviacion = Convert.ToDouble(numDesviacionNormal.Text.Trim());
                normal.Media = Convert.ToDouble(numMediaNormal.Text.Trim());
                normal.CantidadIntervalos = Convert.ToInt32(numIntervalosNormal.Text.Trim());
                normal.Lista = listaVariablesAleatorias;

                normal.Grafico = chartDistribucion;

                normal.Grilla = dgvDatos;

                if (normal.CantidadMuestra == 0 || normal.CantidadIntervalos == 0)
                {
                    MessageBox.Show("Error: La cantidad de muestra o la cantidad de intervalos no pueden ser 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    normal.GenerarDistribucion(normal);
                    HabilitarElementos();
                }
            }

            if (rbUniforme.Checked == true)
            {

                Uniforme uniforme = new Uniforme();

                uniforme.CantidadMuestra = Convert.ToInt32(numMuestraUniforme.Text.Trim());
                uniforme.Minimo = Convert.ToDouble(numMinimoUniforme.Text.Trim());
                uniforme.Maximo = Convert.ToDouble(numMaximoUniforme.Text.Trim());
                uniforme.CantidadIntervalos = Convert.ToInt32(numIntervalosUniforme.Text.Trim());
                uniforme.Lista = listaVariablesAleatorias;
                uniforme.Grafico = chartDistribucion;
                uniforme.Grilla = dgvDatos;


                if (uniforme.Maximo == 0 || uniforme.CantidadMuestra == 0 || uniforme.CantidadIntervalos == 0)
                {
                    MessageBox.Show("Error: El máximo, la cantidad de muestra o la cantidad de intervalos no puede ser 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    uniforme.GenerarDistribucion(uniforme);
                    HabilitarElementos();
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

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            DeshabilitarElementos();
            btn_generar.Show();

            gbExponencial.Visible = false;
            gbUniforme.Visible = false;
            gbNormal.Visible = true;

        }

        private void rbUniforme_CheckedChanged(object sender, EventArgs e)
        {
            DeshabilitarElementos();
            btn_generar.Show();

            gbNormal.Visible = false;
            gbExponencial.Visible = false;
            gbUniforme.Visible = true;
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
