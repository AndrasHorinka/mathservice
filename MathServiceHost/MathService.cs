using System.ServiceModel;
using MathTypes;

namespace MathServiceHost
{
    public class MathService : IMath
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Divide(double x, double y)
        {
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Substract(double x, double y)
        {
            return x / y;
        }
    }
}
