using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORGates_Perceptron
{
    public class PerceptronProgram
    {
        public bool running = true;
        public void Run()
        {
            try
            {
                while (this.running)
                {
                    var pt = new PerceptronTraining();
                    var pc = new PerceptronCalculation();
                    Console.WriteLine();
                    Console.WriteLine("Logical OR Gates Perceptron && Input -1 to End Program");
                    Console.Write("Input Value 1: ");
                    double val1 = Convert.ToDouble(Console.ReadLine());
                    if (Check(val1) == false) { 
                        if(val1 == -1) running = false;
                        else
                            Error(); 
                        break; 
                    }
                    Console.Write("Input Value 2: ");
                    double val2 = Convert.ToDouble(Console.ReadLine());
                    if (Check(val2) == false)
                    {
                        if (val2 == -1) running = false;
                        else
                            Error();
                        break;
                    }
                    double[] inputValue = { val1, val2 };
                    double output = pc.Calculate(inputValue, pt.weights, pt.bias);
                    Console.WriteLine("Input Value: [{0}, {1}]\nOutput: {2}\n", inputValue[0], inputValue[1], output);
                    Console.WriteLine();
                    Console.WriteLine("===============================================");
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Thank You!!!");
                Console.WriteLine();
                Console.WriteLine();
            }
            catch(Exception ex)
            {
                Error();
            }
        }

        public void Error()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Error Try Again!!!");
            Console.WriteLine();
            Console.WriteLine();
            Run();
        }


        public bool Check(double val)
        {
            if (val == 1 || val == 0)
                return true;
            else
            {
                return false;
            }
            
        }
    }
}
