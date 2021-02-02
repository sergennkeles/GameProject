using BusinessLayer.Abstract;
using EntitiesLayer.Concrete;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;


namespace BusinessLayer.Adapters
{
    public  class MernisAdapterService : ICheckGamerService
    {
        //Mernis soap bağlantısı
        public bool CheckGamer(Gamer gamer)
        {
            KPSPublicSoapClient kPSPublicSoapClient = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return kPSPublicSoapClient.TCKimlikNoDogrulaAsync(TCKimlikNo: gamer.TcNo, Ad: gamer.FirstName.ToUpper(), Soyad: gamer.LastName.ToUpper(), DogumYili: gamer.Birthday.Year).Result.Body.TCKimlikNoDogrulaResult ;

        }
    }
}
