using EntitiesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesLayer.Concrete
{
   public class Gamer:Campaign,IEntity
    {
        public int Id { get; set; }
        public long TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }



    }
}
