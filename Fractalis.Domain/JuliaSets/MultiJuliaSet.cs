using Fractalis.Domain.Base;
using Fractalis.Domain.Contracts;
using System.Drawing;

namespace Fractalis.Domain
{
    public class MultiJuliaSet : IFractal 
    {
        private readonly IApplication _application;

        private Bitmap _image;
        private int _iteration;
        private int _maximumIterations = 255;
        private BaseComplex z;

        // R => escape radius  # choose R > 0 such that R**2 - R >= sqrt(cx**2 + cy**2) R = R ^ 2 - R;
        private int _R = 2;

        // cX => 
        double _cX = -0.7;

        // cY => 
        double _cY = 0.27015;
        
        private Color[] _colorPalette = (from c in Enumerable.Range(0, 256)
                                         select Color.FromArgb((c >> 5) * 36, (c >> 3 & 7) * 36, (c & 3) * 85)).ToArray();

        public MultiJuliaSet(IApplication application) {

            _application = application;
              
        }

        public bool Render(Bitmap image, int zoom, int movex, int movey, bool inverse)       
        {
            _image = image;

            return Iterate(zoom, movex, movey, inverse);
        }

        private bool Iterate(int zoom, int moveX, int moveY, bool colorInversion) {

            // f(z) => z² + c

            int x, y;
            
            BaseComplex n = new BaseComplex();
            n.Real = 1;
            n.Imaginary = 1;
            z = new BaseComplex();                       

            for (x = 0; x <= _image.Width-1; x++) {

                for (y = 0; y <= _image.Height-1; y++) {
                    
                    // zx represents the real part of z. Scaled x coordinate of pixel # (scale to be between -R and R)
                    z.Real = 1.5 * (x - _image.Width / 2) / (0.5 * zoom * _image.Width) + moveX;

                    // zy represents the imaginary part of z. Scaled y coordinate of pixel # (scale to be between -R and R)
                    z.Imaginary = 1.0 * (y - _image.Height / 2) / (0.5 * zoom * _image.Height) + moveY;
               
                    _iteration = 0;                    

                    while (Math.Pow(z.Real, 2) + Math.Pow(z.Imaginary, 2) < Math.Pow(_R, 2) && _iteration < _maximumIterations) {
                        
                        var temporaryRealPart = Math.Pow(Math.Pow(z.Real, 2) + Math.Pow(z.Imaginary, 2), (n.Real/2)) * Math.Cos(n.Real * Math.Atan2(z.Imaginary, z.Real)) + _cX;
                        z.Imaginary = Math.Pow(Math.Pow(z.Real, 2) + Math.Pow(z.Imaginary, 2), (n.Imaginary/2)) * Math.Sin(n.Imaginary * Math.Atan2(z.Imaginary, z.Real)) + _cY;
                        z.Real = temporaryRealPart;

                        n.Imaginary = z.Imaginary;
                        n.Real = z.Real;

                        _iteration++;
                    }

                    var colorNumber = colorInversion ? _maximumIterations - _iteration : _iteration;

                    _image.SetPixel(x, y, _colorPalette[colorNumber]);
                    
                }
            }

            return true;
        }

        public bool Save()
        {
            string[] files = Directory.GetFiles(_application.StartupPath, "julia-set*.png");

            string fileName = files.Count() > 0 ? "julia-set" + (files.Count() + 1) + ".png" : "julia-set1.png";
            
            _image.Save(fileName);

            return true;
        }

        public Bitmap Image { get => _image; }
        public int MaximumIterations { get => _maximumIterations; set => _maximumIterations = value; }
        public int R { get => _R; set => _R = value; }
        public double cX { get => _cX; set => _cX = value; }
        public double cY { get => _cY; set => _cY = value; }
        public Color[] ColorPalette { get => _colorPalette; set => _colorPalette = value; }
    }
}