using System;

namespace MyMinimalApiProject
{
    public interface IMathService
    {
        double Pow(int baseNum, int pow);
        double Sqrt(long baseNum);
    }

    public class MathService : IMathService
    {
        public double Pow(int baseNum, int pow)
        {
            return Math.Pow(baseNum, pow);
        }

        public double Sqrt(long baseNum)
        {
            return Math.Sqrt(baseNum);
        }
    }

}
