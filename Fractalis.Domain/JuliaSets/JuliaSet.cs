using Fractalis.Domain.Base;
using Fractalis.Domain.Contracts;
using System.Drawing;
using System.Numerics;

namespace Fractalis.Domain
{
    public class JuliaSet : IFractal 
    {
        private Bitmap _image;
        private int _iteration;
        private int _maximumIterations = 255;

        public JuliaSet(Bitmap image) {
            
            _image = image;
        }

        public bool Render(Bitmap image)       
        {
            _image = image;

            return Iterate();
        }

        private bool Iterate() {

            // R => escape radius  # choose R > 0 such that R**2 - R >= sqrt(cx**2 + cy**2) R = R ^ 2 - R;
            int R = 4;

            int x, y, zoom = 1, MoveX = 0, MoveY = 0;
            double cx = -0.7, cy = 0.27015;
            BaseComplex z = new BaseComplex();
            
            var colors = (from c in Enumerable.Range(0, 256)
                          select Color.FromArgb((c >> 5) * 36, (c >> 3 & 7) * 36, (c & 3) * 85)).ToArray();

            for (x = 0; x <= _image.Width-1; x++) {

                for (y = 0; y <= _image.Height-1; y++) {
                    
                    // zx represents the real part of z. Scaled x coordinate of pixel # (scale to be between -R and R)
                    z.Real = 1.5 * (x - _image.Width / 2) / (0.5 * zoom * _image.Width) + MoveX;

                    // zy represents the imaginary part of z.Scaled y coordinate of pixel # (scale to be between -R and R)
                    z.Imaginary = 1.0 * (y - _image.Height / 2) / (0.5 * zoom * _image.Height) + MoveY;
               
                    _iteration = 0;                    

                    while (z.Real * z.Real + z.Imaginary * z.Imaginary < Math.Pow(R, 2) && _iteration < _maximumIterations) {
                        
                        var tempReal = z.Real * z.Real - z.Imaginary * z.Imaginary + cx;
                        z.Imaginary = 2.0 * z.Real * z.Imaginary + cy;
                        z.Real = tempReal;

                        _iteration++;
                    }
                  
                    _image.SetPixel(x, y, colors[_iteration]);                    
                                        
                }
            }

            return true;
        }

        public Bitmap Image { get => _image; }
    }
}