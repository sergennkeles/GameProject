using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface ITahminService
    {
        // Rastgele sayı üreten ve genel akışı kontrol ettiğimiz methodumuzu içeren ITahminServis intarface'ini 
        // TahminManager'a inherit ettik.
        void RandomNumber();
    }
}
