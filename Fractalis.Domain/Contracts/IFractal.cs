using System.Drawing;

namespace Fractalis.Domain.Contracts
{
    public interface IFractal {

        bool Render(Bitmap image, int zoom, int movex, int movey, bool inverse);
        bool Save();
        Bitmap Image { get; }
    }
}
