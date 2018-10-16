using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverter.Business
{
    public class TempCalculator
    {
        public int ConvertToF(int TempC)
        {
            return ((9 / 5) * TempC) + 32;
        }

        public int ConvertToC(int TempF)
        {
            return (TempF - 32) * 5/9;
        }
    }
}
