using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearRegression
{
    internal class LinearRegression
    {
        double iteration;
        double learningRate;
        double weight;
        double bias;
        bool verbose;
        public LinearRegression(double iteration, double learningRate)
        {
            this.iteration = iteration;
            this.learningRate = learningRate;
            this.verbose = true;
        }

        public LinearRegression(double iteration, double learningRate, bool verbose) : this(iteration, learningRate)
        {
            this.verbose = verbose;
        }

        public void fit(double[] X , double[] Y)
        {
            this.weight = 0;
            this.bias = 0;

            for (int i = 0; i < this.iteration; i++)
            {
                double dw = 0;
                double db = 0;
                double loss = 0;
                for (int j = 0; j < X.Length; j++)
                {
                    double sum = 1d / X.Length;
                    double y_pred = this.predictForFit(X[j]);
                    loss = y_pred - Y[j];
                    dw += sum * loss * X[j];
                    db += sum * loss;

                }
                if (this.verbose)
                {
                    Console.WriteLine("epoch : " + i + " -- loss : " + Math.Abs(loss));
                }
                this.weight -= this.learningRate * dw;
                this.bias -= this.learningRate * db;
                
            }


        }
        private double predictForFit(double x)
        {
            return this.weight * x + this.bias;
        }
        public double predict(double x , Boolean Round)
        {
            if (Round)
                return Math.Round(this.weight * x + this.bias);
            else
                return this.weight * x + this.bias;
        }
        public void printWeights()
        {
            Console.WriteLine("weight : " + this.weight + " -- bias : " + this.bias);
        }
    }
}
