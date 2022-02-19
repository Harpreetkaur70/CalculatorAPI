using System;

namespace Calculator
{
    public interface IMath
    {
        public int Addition(int i, int j);
        public int Subtraction(int i, int j);
        public int Multiplication(int i, int j);
        public int Division(int i, int j);
    }
}
