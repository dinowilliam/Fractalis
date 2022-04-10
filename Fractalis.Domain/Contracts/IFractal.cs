using Fractalis.Domain.Base;
using System.Drawing;

namespace Fractalis.Domain.Contracts
{
    public interface IFractal {

        bool Render(Bitmap image, int zoom, int movex, int movey, bool inverse);
        bool Save();
        bool IsMultiFractal { get; }
        Bitmap Image { get; }
        public int MaximumIterations { get; set; }
        public int R { get; set; }
        public int N { get; set; }
        public BaseComplex c { get; set; }
        public Color[] ColorPalette { get; set; }
    }
}
