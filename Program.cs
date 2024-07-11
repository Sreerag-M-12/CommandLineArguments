using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("The numbers are "+ args[0]+" " + args[1] + " " + args[2] + " " + args[3] + " " + args[4]);
            int[] argument = new int[5];
            int sum = 0;
            for (int i = 0; i < argument.Length; i++)
            {
                argument[i] = Convert.ToInt32(args[i]);
                sum = sum + argument[i];
            }
            int average = sum / 5;
            int max = 0, min = argument[0];
            for (int i = 0; i < argument.Length; i++)
            {
                if (argument[i] > max) 
                    max = argument[i];
                if(argument[i] < min)
                    min = argument[i];        
            }
            Console.WriteLine("SUM of argument series is "+ sum);
            Console.WriteLine("AVG of argument series is " + average);
            Console.WriteLine("MAX number in argument series is " + max);
            Console.WriteLine("MIN number in argument series is " + min);
            Console.WriteLine("Count of arguments "+ args.Length);

        }

    }

}

