using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Enums;

namespace Models
{

    
    public class ConvertType
    {

        public Currency type { get; set; }
        public double Converter(Currency type, double azn )
        {
            switch (type)
            {
                case Currency.Usd:
                    azn *= 1.7;
                    break;
                case Currency.Eur:
                    azn *=1.86;
                    break;
                case Currency.Rub:
                    azn *= 48.87;
                    break;
                case Currency.Try:
                    azn *= 8.67;
                    break;
                default:
                    Console.WriteLine("wrong input");
                    break;
            }
            return azn;
        }
    }
}
