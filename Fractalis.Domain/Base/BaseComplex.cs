using Fractalis.Domain.Contracts;

namespace Fractalis.Domain.Base
{
    public class BaseComplex : IComplex
    {
        public BaseComplex() { }
        public BaseComplex(double real, double imaginary) {
            Real = real;
            Imaginary = imaginary;
        }

        public double Real { get; set; }
        public double Imaginary { get; set; }
    }
}
