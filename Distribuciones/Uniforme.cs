using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace TP2_SIM.Distribuciones
{
    internal class Uniforme
    {
        public int CantidadMuestra { get; set; }
        public double Minimo { get; set; }
        public double Maximo { get; set; }
        public int CantidadIntervalos { get; set; }
        public ListBox Lista { get; set; }
        public Chart Grafico { get; set; }
        public DataGridView Grilla { get; set; }

        private List<double> Datos = new List<double>();

        private Random rnd = new Random();

        public double GenerarAleatorio()
        {
            return rnd.NextDouble();
        }

        public void GenerarDistribucion(Object uniforme)
        {

            if (Minimo < Maximo)
            {
                Lista.Items.Clear();

                Lista.BeginUpdate();
                for (int i = 0; i < CantidadMuestra; i++)
                {
                    double random = GenerarAleatorio();
                    double variableAleatoria = Minimo + (random * (Maximo - Minimo));
                    double variableAleatoriaTruncada = Math.Truncate(variableAleatoria * 10000) / 10000;


                    /*
                     * Se añaden los valores para mostrar a una lista de WinForms.
                     * También genera una lista para poder tomar los datos para generar el histograma.
                     * Trunca cada dato a 4 decimales.
                     */

                    Lista.Items.Add(variableAleatoriaTruncada);
                    Datos.Add(variableAleatoriaTruncada);

                }
                Lista.EndUpdate();


                GenerarHistograma();

            }
            else
            {
                MessageBox.Show("Error: El mínimo debe ser menor que el máximo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void GenerarHistograma()
        {

            Grafico.Series.Clear();
            Grilla.Rows.Clear();

            double limiteInferior = 0;
            double limiteSuperior = 0;

            double valorMaximo = Datos.Max();
            double valorMinimo = Datos.Min();
            double precision = 0.0001;

            double ancho_intervalo = ((valorMaximo - valorMinimo) / CantidadIntervalos) + precision;

            int frecuenciaObservada = 0;
            double frecuenciaEsperada = 0;
            double frecuenciaObservadaAcumulada = 0;
            double frecuenciaEsperadaAcumulada = 0;
            double marcaClase = 0;

            double chiCuadrado = 0;
            double chiCuadradoAcumulado = 0;


            for (int i = 0; i < CantidadIntervalos; i++)
            {

                /*
                 * Determinar el primer intervalo del histograma y determinar cuantos valores entran en el.
                 */

                if (i == 0)
                {
                    limiteInferior = valorMinimo;
                    limiteSuperior = valorMinimo + ancho_intervalo;
                    marcaClase = (limiteInferior + limiteSuperior) / 2;

                    frecuenciaObservada = DeterminarFrecuenciaObservada(Datos, limiteInferior, limiteSuperior);
                    frecuenciaObservadaAcumulada = frecuenciaObservada;
                    frecuenciaEsperada = CalcularFrecuenciaEsperada();
                    frecuenciaEsperadaAcumulada = frecuenciaEsperada;

                    chiCuadrado = Math.Pow(frecuenciaObservada - frecuenciaEsperada, 2) / frecuenciaEsperada;
                    chiCuadradoAcumulado += chiCuadrado;

                    AgregarFillaGrilla(limiteInferior, limiteSuperior, marcaClase, frecuenciaObservada, frecuenciaEsperada, frecuenciaObservadaAcumulada, frecuenciaEsperadaAcumulada);
                }

                /*
                 * Determinar el resto de intervalos del histograma y determinar cuantos valores entran en ellos.
                 */

                else
                {
                    limiteInferior = limiteSuperior;
                    limiteSuperior = limiteSuperior + ancho_intervalo;
                    marcaClase = (limiteInferior + limiteSuperior) / 2;

                    frecuenciaObservada = DeterminarFrecuenciaObservada(Datos, limiteInferior, limiteSuperior);
                    frecuenciaObservadaAcumulada += frecuenciaObservada;
                    frecuenciaEsperada = CalcularFrecuenciaEsperada();
                    frecuenciaEsperadaAcumulada += frecuenciaEsperada;

                    chiCuadrado = Math.Pow(frecuenciaObservada - frecuenciaEsperada, 2) / frecuenciaEsperada;
                    chiCuadradoAcumulado += chiCuadrado;

                    AgregarFillaGrilla(limiteInferior, limiteSuperior, marcaClase, frecuenciaObservada, frecuenciaEsperada, frecuenciaObservadaAcumulada, frecuenciaEsperadaAcumulada);

                }

                /*
                 * Generar la etiqueta del mínimo y máximo de cada intervalo y lo agrega a la serie de intervalos del histograma.
                 * Los valores se truncan a 4 decimales.
                 */

                string etiquetaInferiorIntervalo = (Math.Truncate(limiteInferior * 10000) / 10000).ToString();
                string etiquetaSuperiorIntervalo = (Math.Truncate(limiteSuperior * 10000) / 10000).ToString();
                string etiquetaIntervalo = etiquetaInferiorIntervalo + " - " + etiquetaSuperiorIntervalo;

                Series serie = Grafico.Series.Add(etiquetaIntervalo);
                serie.Points.AddXY("Intervalos", frecuenciaObservada);

            }

        }

        public int DeterminarFrecuenciaObservada(List<double> ListaDatos, double limite_inferior, double limite_superior)
        {

            int frecuenciaObservada = 0;

            foreach (double valor in ListaDatos)
            {
                if (limite_inferior <= valor && valor <= limite_superior)
                {
                    frecuenciaObservada++;
                }
            }

            return frecuenciaObservada;
        }

        public double CalcularFrecuenciaEsperada()
        {
            return CantidadMuestra / CantidadIntervalos;
        }


        public void AgregarFillaGrilla(double limiteInferior, double limiteSuperior, double marcaClase, double frecuenciaObservada,
            double frecuenciaEsperada, double frecuenciaObservadaAcumulada, double frecuenciaEsperadaAcumulada)
        {
            limiteInferior = Math.Truncate(limiteInferior * 10000) / 10000;
            limiteSuperior = Math.Truncate(limiteSuperior * 10000) / 10000;
            marcaClase = Math.Truncate(marcaClase * 10000) / 10000;
            frecuenciaObservada = Math.Truncate(frecuenciaObservada * 10000) / 10000;
            frecuenciaEsperada = Math.Truncate(frecuenciaEsperada * 10000) / 10000;
            frecuenciaObservadaAcumulada = Math.Truncate(frecuenciaObservadaAcumulada * 10000) / 10000;
            frecuenciaEsperadaAcumulada = Math.Truncate(frecuenciaEsperadaAcumulada * 10000) / 10000;

            Grilla.Rows.Add(limiteInferior, limiteSuperior, marcaClase, frecuenciaObservada, frecuenciaEsperada,
                frecuenciaObservadaAcumulada, frecuenciaEsperadaAcumulada);

        }
    }
}
