using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PercentCounter;

namespace SalaryCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the country: ");

                CalcFullSalary(Console.ReadLine().ToUpper(), 2000);
            }
        }

      static void CalcFullSalary(string country, int salary)
        {
            int additPercent;
            int mainPercent = Counter.GetPercent(country,out additPercent);
            int additionalMoney = (CalcPercentSum(salary,mainPercent))+(CalcPercentSum(salary,additPercent));
            
            Console.WriteLine("The main percent in this country is " + mainPercent + "% , the additional percent is " + additPercent+"%");
            Console.WriteLine("Standart salary is " + salary + "$ , money needed to pay main tax " + 
                               CalcPercentSum(salary, mainPercent) + "$ , money needed to pay addit. tax " + 
                               CalcPercentSum(salary, additPercent)+"$");

            Console.WriteLine("The full Salary is: " + Convert.ToString(salary + additionalMoney)+"$");
            
        }
      static int CalcPercentSum(int salar, int percent)
      {
          return salar / 100 * percent;
      }
    }
}
