using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Math : IMath
    {
        public int Addition(int i, int j)
        {
            return i + j;
        }

        public int Substraction(int i, int j)
        {
            return i - j;
        }

        public int Multiplication(int i, int j)
        {
            return i * j;
        }

        public int Divsion(int i, int j)
        {
            return i / j;
        }
    }
}
