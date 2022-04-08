using Fractalis.Domain.Contracts;

namespace Fractalis.Domain.Base
{
    public class BaseComplex : IComplex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }
    }
}
