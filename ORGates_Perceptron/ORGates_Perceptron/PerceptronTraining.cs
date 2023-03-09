using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;


namespace ORGates_Perceptron
{
    public class PerceptronTraining
    {
        public PerceptronCalculation pc;
        // Define the training data for the logical OR function
        public double[][] inputs = {
            new double[] {0, 0},
            new double[] {0, 1},
            new double[] {1, 0},
            new double[] {1, 1}
        };
        public double[] targets = { 0, 1, 1, 1 };
        // Define the learning rate and the number of epochs to train for
        public double learningRate;
        public int epochs;
        // Initialize the weights and bias to random values
        public double bias;
        public double[] weights;

        public PerceptronTraining()
        {
            pc = new PerceptronCalculation();
            Random rand = new Random();
            // Define the learning rate and the number of epochs to train for
            epochs = 10;
            learningRate = 0.1;
            // Initialize the weights and bias to random values
            weights = new double[] { rand.NextDouble(), rand.NextDouble() };
            bias = rand.NextDouble();
            Train();
        }

        public void Train()
        {
            // Train the perceptron using the training data
            for (int epoch = 0; epoch < epochs; epoch++)
            {
                for (int i = 0; i < inputs.Length; i++)
                {
                    double output = pc.Calculate(inputs[i], weights, bias);
                    double error = targets[i] - output;

                    // Update the weights and bias based on the error
                    weights[0] += learningRate * error * inputs[i][0];
                    weights[1] += learningRate * error * inputs[i][1];
                    bias += learningRate * error;
                }
            }
        }
    }
}