using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = 0;
            int secondValue = 0;
            char sign;
            int result = 0;

            Console.WriteLine("This program is going to take your two numbers and either +, -, * or / the two numbers together");
            Console.WriteLine("Enter a number below");
            firstValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number below");
            secondValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a sign  below");
            sign = Convert.ToChar(Console.ReadLine());

            if (sign == '+')
            {
                result = Add(firstValue, secondValue);
            }
            else if (sign == '-')
            {
                result = Subtract(firstValue, secondValue);
            }
            else if (sign == '*')
            {
                result = Multiply(firstValue, secondValue);
            }
            else if (sign == '/')
            {
                result = Divide(firstValue, secondValue);
            } else
            {
                Console.WriteLine("ERROR = Enter a valid sign. The arithmetic below is incorrect.");
            }

            //COULD USE THIS INSTEAD OF IF/ELSE IF
            //switch (sign)
            //{
            //    case '+':
            //        result = Add(firstValue, secondValue);
            //        break;
            //    case '-':
            //        result = Subtract(firstValue, secondValue);
            //        break;
            //    case '*':
            //        result = Multiply(firstValue, secondValue);
            //        break;
            //    case '/':
            //        result = Divide(firstValue, secondValue);
            //        break;
            //    default:
            //        Console.WriteLine("You didn't enter a valid sign.");
            //        break;
            //}

            Console.WriteLine(firstValue + " " + sign + " " + secondValue + " " + "=" + " " + result);
        }

        static int Add(int firstNum, int secondNum)
        {
            
            int answer = firstNum + secondNum;
            return answer;
        }
        static int Subtract(int firstNum, int secondNum)
        {
            
            int answer = firstNum - secondNum;
            return answer;
        }
        static int Multiply(int firstNum, int secondNum)
        {
            
            int answer = firstNum * secondNum;
            return answer;
        }
        static int Divide(int firstNum, int secondNum)
        {
            
            int answer = firstNum / secondNum;
            return answer;
        }

    }

    }
