using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
   public interface ICheckGamerService
    {
        // Kimlik doğrulamasını kontrol etmemizi sağlayan methodumuzu tanımladık ve MernisAdapterServis class'ına inherit ettik.
        bool CheckGamer(Gamer gamer);
    }
}
