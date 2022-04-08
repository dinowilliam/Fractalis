using Fractalis.Domain.Base;
using Fractalis.Domain.Contracts;
using System.Drawing;
using System.Numerics;

namespace Fractalis.Domain
{
    public class JuliaSet : IFractal 
    {
        private Bitmap _image;
        private int _iteration = 0;
        private int _maximumIterations = 1000000;

        public JuliaSet(Bitmap image) {
            
            _image = image;
        }

        public bool Render(Bitmap image)       
        {
            _image = image;

            return Iterate();
        }

        private bool Iterate() {

            int x, y, R = 2, cy, cx; ;
            BaseComplex z = new BaseComplex();

            //R = R ^ 2 - R;

            for (x = 0; x <= _image.Width-1; x++) {

                for (y = 0; y <= _image.Height-1; y++) {

                    Color color;
                    //var color = _image.GetPixel(x, y);

                    cx = x;
                    cy = y;

                    // escape radius  # choose R > 0 such that R**2 - R >= sqrt(cx**2 + cy**2)


                    //var complex = Complex.Sqrt(Complex.Pow(cx,2) + Complex.Pow(cy ,2));

                    // zx represents the real part of z.
                    // scaled x coordinate of pixel # (scale to be between -R and R)
                    z.Real = cx * cx;

                    // zy represents the imaginary part of z.
                    // scaled y coordinate of pixel # (scale to be between -R and R)
                    z.Imaginary = cy * cy;
               
                    _iteration = 0;                    

                    while (z.Real * z.Real + z.Imaginary * z.Imaginary < (R ^ 2) && _iteration < _maximumIterations) {
                        
                        z.Imaginary = 2 * z.Real * z.Imaginary + cy;
                        z.Real = (z.Real * z.Real) - (z.Imaginary * z.Imaginary) + cx;

                        _iteration = _iteration + 1;
                    }

                    if (_iteration == _maximumIterations) {
                        color = Color.Black;
                    }
                    else {
                        color = Color.FromArgb(_iteration, 0, _iteration, 0);                      
                    }

                    _image.SetPixel(x, y, color);                    
                }
            }

            return true;
        }

        public Bitmap Image { get => _image; }
    }
}