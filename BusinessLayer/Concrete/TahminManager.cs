
using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class TahminManager : ITahminService
    {
       
        // değişkenler
        int sayi, tahminSayi, dongu, sayac = 3;
        string cevap;

        public void RandomNumber(Gamer gamer)
        {

            Random random = new Random(); // Random sınıfını rastgele sayılar üretmek için çağırdık.
            sayi = random.Next(1, 10); // 1-10 arasında rastgele sayı oluşturulmasını sağladık.
            Console.WriteLine(sayac + " Hakkınız var. ");
            Console.WriteLine();


            dongu = sayac; // dongu değişkenini sayac değişkenine eşitlememin sebebi for döngüsünde sayac'ı 1 azalttığım için
            // hak tamamlanmadan döngü bitmiş oluyor ve program sonlanıyordu. Bunun önüne geçebilmek için dongu değişkenini 
            //for döngüsünde kullandık.

            for (int i = 0; i < dongu; i++)
            {
                Console.Write("1-10 arasında bir sayı tahmin edin: ");
                tahminSayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == tahminSayi) // Kullanıcı rastgele üretilen sayıyı tahmin ederse aşağıdaki işlemleri yap
                {

                    Console.WriteLine("Tebrikler bildiniz!!! ");
                    Console.Write("Tekrar oynamak ister misiniz? e/h :");
                    cevap = Console.ReadLine();
                    if (cevap == "e") // Kullanıcı tekrar kullanmak isterse RandomNumber() methodunu tekrar çalıştır dedik.
                    {
                        sayac = 3;
                        RandomNumber(gamer);

                    }
                    else if (cevap == "h")
                    {
                        Console.WriteLine("İyi günler. Yine bekleriz.");
                        break;
                    }
                }
                else
                {
                    sayac--; // başlangıçta 3 hak verdik. Her yanlış tahminde 1 azalttık.
                    Console.WriteLine(sayac + " Hakkınız kaldı.");
                    SalesManager salesManager = new SalesManager(new SalesDal());

                    if (sayac == 0) // hak biterse kullanıcı kampanyalara yönlendirmek için aşağıdaki işlemleri yap dedik.
                    {
                        Console.Write("Hakkınız bitti. Hak satın almak ister misiniz? e/h :");
                        cevap = Console.ReadLine();
                        if (cevap == "e")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Standart hak için 1'e basın");
                            Console.WriteLine("Vip   hak için 2'ye basın");
                            Console.WriteLine("Premium  hak için 3'e basın");
                            Console.Write("Seçiminiz ? ");
                            cevap = Console.ReadLine();

                            // SalesManager daki kampanyalara ulaşmak için
                            //instance çıkardık.

                            //Foreach döngüsü ile GetCampaigns() methodundaki kampanyaları sale değişkenine aktardık.
                            foreach (var sale in salesManager.GetCampaigns())
                            {

                                if (cevap == "1" && sale.CampaignName.Contains("Standart"))// Aslında bu şekilde yapmak doğru mu? bilmiyorum
                                                                                           // yaparken de pek içime sindiği söylenemez ama başka çözüm bulamadım :) Yeni bir kampanya eklemek istersek araya bir else if bloğu daha
                                                                                           // koyarak çözeriz. Kodda Eğer cevap 1 ve CampaignName içinde Standart kelimesi varsa
                                                                                           // sayacı 4 yap ve randomnumber methodunu çalıştır dedik. Benzer işlemleri diğer ifler için uyguladk.
                                {
                                    sayac = 4;
                                    gamer.CampaignName = sale.CampaignName;
                                    Console.WriteLine("Sayın " + gamer.FirstName + ", " + sale.CampaignName + " kampanyası ile devam ediyorsunuz.");
                                    RandomNumber(gamer);
                                }
                                else if (cevap == "2" && sale.CampaignName.Contains("Vip"))
                                {
                                    sayac = 5;
                                    gamer.CampaignName = sale.CampaignName;
                                    Console.WriteLine("Sayın " + gamer.FirstName + ", " + sale.CampaignName + " kampanyası ile devam ediyorsunuz.");

                                    RandomNumber(gamer);

                                }
                                else if (cevap == "3" && sale.CampaignName.Contains("Premium"))
                                {
                                    sayac = 7;
                                    gamer.CampaignName = sale.CampaignName;
                                    Console.WriteLine("Sayın " + gamer.FirstName + ", " + sale.CampaignName + " kampanyası ile devam ediyorsunuz.");
                                    RandomNumber(gamer);
                                }

                            }

                        }
                        else if (cevap == "h")
                        {
                            Console.WriteLine("İyi günler. Yine bekleriz.");
                            break;
                        }
                    }
                    

                }
            }

        }
          
    }
}
