using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORGates_Perceptron
{
    public class PerceptronCalculation
    {
        public double Calculate(double[] input, double[] weights, double bias)
        {
            double dotProduct = input[0] * weights[0] + input[1] * weights[1];
            return ActivationFunction(dotProduct + bias);
        }

        double ActivationFunction(double input)
        {
            return input >= 0 ? 1 : 0;
        }
    }
}
