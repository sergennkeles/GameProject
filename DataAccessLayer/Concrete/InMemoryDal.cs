using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Concrete
{
    public class InMemoryDal : IGamerDal
    {
        // Kaydet, Güncelle, Sil methodlarımızın olduğu class

        List<Gamer> _gamer;
        InMemoryService inMemoryService = new InMemoryService();

        public InMemoryDal()
        {
            _gamer = new List<Gamer>(){  }; // _gamer dan gelen verileri kaydettik.
        }

        public void Add(Gamer gamer)
        {
            
            inMemoryService.Answer(gamer);// kullanıcıdan verileri almak için inMemoryService içindeki Answer methoduna yönlendirdik.
            _gamer.Add(gamer); // Kullanıcıdan gelen verileri kaydettik.
        }

        public void Delete(Gamer gamer)
        {
             Gamer isDeleted = _gamer.SingleOrDefault(x => x.Id == gamer.Id);
            _gamer.Remove(isDeleted); // Id ye göre silme işlemi yaptırdık.
        }

        public List<Gamer> GetAllGamer()
        {
            return _gamer; // tüm kullanıcıları listele
        }

        public void Update(Gamer gamer)
        {
            // Id ye göre kullanıcıyı güncelledik. Aslında mernis ile kimlik doğrulaması yaptığımız için güncelleme işlemine pek gerek
            // yoktu diye düşünüyorum ama yinede yaptık :) 
            Gamer isUpdated = _gamer.SingleOrDefault(x => x.Id == gamer.Id);
            isUpdated.FirstName=gamer.FirstName  ;
            isUpdated.LastName = gamer.LastName;
            isUpdated.TcNo = gamer.TcNo;
            isUpdated.Birthday = gamer.Birthday;

        }
    }
}
