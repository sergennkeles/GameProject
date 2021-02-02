using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete
{
   public class InMemoryService
    {
        public void Answer(Gamer gamer)
        {
            // Konsolda kullanıcıdan bilgileri alıp Gamer classındaki propertylere aktardık.
            Console.Write("Adınızı giriniz: ");
            gamer.FirstName = Console.ReadLine();

            Console.Write("Soyadınızı giriniz: ");
            gamer.LastName = Console.ReadLine();

            Console.Write("Tc No giriniz: ");
            gamer.TcNo =Convert.ToInt64(Console.ReadLine());

            Console.Write("Doğum tarihi giriniz: ");
            gamer.Birthday = Convert.ToDateTime(Console.ReadLine());
        }
    }
}
