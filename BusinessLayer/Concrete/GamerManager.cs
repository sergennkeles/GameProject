using BusinessLayer.Abstract;
using BusinessLayer.Adapters;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class GamerManager :MernisAdapterService, IGamerService
    {
        IGamerDal _gamerDal; // InMemoryDal a verilerimizi kaydetmek için kullandığımız interface implementasyonunu yaptık.
      // SalesManager'a kampanyalarımızı kaydetmen için kullandığımız interface  implementasyonu.
        // Aslında Business katmanı üzerinden SalesManager'a  kayıt işlemi yapmak pek doğru değil sanırım. İlerde refactor ederiz. 


        public GamerManager(IGamerDal gamerDal)
        {
            _gamerDal = gamerDal; // constructor içinde _gamerDal ve _campaignDal dan gelen verilerimizi eklettik.
        }

        public void Add(Gamer gamer)
        {
            _gamerDal.Add(gamer);
         
        }

        public List<Gamer> GetAllGamer()
        {
          return _gamerDal.GetAllGamer();
        }

    }
}
