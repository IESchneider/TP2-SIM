using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_SIM
{
    internal class Logica
    {
        private Random rnd = new Random();

        public double GenerarAleatorio()
        {
            return rnd.NextDouble();
        }

        public double FrecuenciaExponencial(double x, double lambda)
        {
            MathNet.Numerics.Distributions.Exponential resultado = new MathNet.Numerics.Distributions.Exponential(lambda);
            return resultado.CumulativeDistribution(x);
        }

        public double FrecuenciaNormal(double x, double mu, double sigma)
        {
            MathNet.Numerics.Distributions.Normal resultado = new MathNet.Numerics.Distributions.Normal(mu, sigma);
            return resultado.CumulativeDistribution(x);
        }

        public double FrecuenciaPoisson(int x, double lambda)
        {
            MathNet.Numerics.Distributions.Poisson resultado = new MathNet.Numerics.Distributions.Poisson(lambda);
            return resultado.CumulativeDistribution(x);

        }
    }
}
