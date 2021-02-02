using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IGamerService
    {

        List<Gamer> GetAllGamer();

        void Add(Gamer gamer);
      
    }
}
