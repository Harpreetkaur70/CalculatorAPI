using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Math : IMath
    {
        /// <summary>
        /// Calculator method to perform addition opertion on two integers
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public int Addition(int i, int j)
        {
            return i + j;
        }

        /// <summary>
        /// Calculator method to perform substraction opertion on two integers
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public int Subtraction(int i, int j)
        {
            return i - j;
        }

        /// <summary>
        /// Calculator method to perform multiplication opertion on two integers
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public int Multiplication(int i, int j)
        {
            return i * j;
        }

        /// <summary>
        /// Calculator method to perform division opertion on two integers
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public int Division(int i, int j)
        {
            return i / j;
        }
    }
}
