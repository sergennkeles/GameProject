using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
   public interface IGamerDal
    {

        // Methodlarımızı InMemoryDal class'ına inherit ettik.
        List<Gamer> GetAllGamer();

        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
