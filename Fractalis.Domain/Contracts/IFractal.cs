using System.Drawing;

namespace Fractalis.Domain.Contracts
{
    internal interface IFractal {

        bool Render(Bitmap image);
        Bitmap Image { get; }
    }
}
