using Fractalis.Domain.Contracts;

namespace Fractalis.Domain.Base
{
    public class BaseComplex : IComplex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
    }
}
