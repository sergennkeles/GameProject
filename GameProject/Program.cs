﻿using BusinessLayer.Adapters;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        { 
            Gamer gamer1 = new Gamer();
            InMemoryDal inMemoryDal = new InMemoryDal();
            SalesDal salesDal = new SalesDal();
            MernisAdapterService mernisAdapterService = new MernisAdapterService();
       
         
            TahminManager tahminManager = new TahminManager();
            inMemoryDal.Add(gamer1);


            GamerManager gamerManager = new GamerManager(inMemoryDal);

            foreach (var gamer in gamerManager.GetAllGamer())
            {
                if (mernisAdapterService.CheckGamer(gamer))
                {
                    Console.WriteLine("Merhaba, " + gamer.FirstName + " Hoşgeldiniz");
                    tahminManager.RandomNumber(gamer);
                }
                else
                {
                    Console.WriteLine("Bilgileriniz yanlış. Lütfen doğru bilgi giriniz.");
                }


            }




        }
    }
}
