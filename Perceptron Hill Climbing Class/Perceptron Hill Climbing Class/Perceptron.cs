using System;
using System.Collections.Generic;
using System.Text;

namespace Perceptron_Hill_Climbing_Class
{
    class Perceptron
    {
        double[] weights;
        double bias;
        double mutationAmount;
        Random random;
        Func<double, double, double> errorFunc;

        public Perceptron(double[] initialWeightValues, double initialBiasValue, double mutationAmount, Random random, Func<double, double, double> errorFunc)
        {
            /*initializes the perceptron*/
            weights = initialWeightValues;
            bias = initialBiasValue;
            this.mutationAmount = mutationAmount;
            this.random = random;
            this.errorFunc = errorFunc;
        }

        public Perceptron(int amountOfInputs, double mutationAmount, Random random, Func<double, double, double> errorFunc)
        {
            /*Initializes the weights array given the amount of inputs*/
            this.mutationAmount = mutationAmount;
            this.random = random;
            this.errorFunc = errorFunc;

            weights = new double[amountOfInputs];
        }

        public void Randomize(Random random, double min, double max)
        {
            /*Randomly generates values for every weight including the bias*/

            for (int i = 0; i < weights.Length; i++)
            {
                weights[i] = random.NextDouble(min, max);
            }

            bias = random.NextDouble(min, max);
        }

        public double Compute(double[] inputs)
        {
            double result = 0;
            /*computes the output with given input*/
            return result;

            //Cannot do anything with this yet because it is project specific.
        }

        public double[] Compute(double[][] inputs)
        {
            double[] result = null;
            return result;
            /*computes the output for each row of inputs*/ 

            //Cannot do anything with this yet because it is project specific.
        }

        public double GetError(double[][] inputs, double[] desiredOutputs)
        {
            double result = 0;
            return result;
            /*computes the output using the inputs returns the average error between each output row and each desired output row using errorFunc*/ 
        }

        public double TrainWithHillClimbing(double[][] inputs, double[] desiredOutputs, double currentError)
        {
            return 0; 
        }
    }
}
