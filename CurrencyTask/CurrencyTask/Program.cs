using Models;
using System;
using Utilities.Enums;

namespace CurrencyTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertType convertType1 = new ConvertType();
            double aznInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(convertType1.Converter(Currency.Usd, aznInput));
        }
    }
}
