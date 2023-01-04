using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    internal class CalculateService 
    {
        public   string SumNumbers(int num1, int num2, string operation)
        {
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    return result.ToString();

                    case "-":
                    result = num2 - num1;
                    return result.ToString();
                    case "*":
                    result = num1 * num2;
                    return result.ToString();
                    case "/":
                    result = num2 / num1;
                    return result.ToString();

                default:

                return    "add operation";

                    



            }

            
        }

        
    }
}
