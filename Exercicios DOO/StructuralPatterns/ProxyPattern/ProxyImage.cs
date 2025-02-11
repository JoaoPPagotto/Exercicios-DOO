using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_DOO.StructuralPatterns.ProxyPattern
{
    public class ProxyImage : IImage
    {
        private RealImage _realImage;
        private string _filename;

        public ProxyImage(string filename) => _filename = filename;

        public void Display()
        {
            if (_realImage == null)
            {
                _realImage = new RealImage(_filename);
            }
            _realImage.Display();
        }
    }
}
