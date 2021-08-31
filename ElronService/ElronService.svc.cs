using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ElronService.KimlikDogrulama;

namespace ElronService
{
    // NOT: "ElronService" sınıf adını kodda, svc'de ve yapılandırma dosyasında birlikte değiştirmek için "Yeniden Düzenle" menüsündeki "Yeniden Adlandır" komutunu kullanabilirsiniz.
    // NOT: Bu hizmeti test etmek üzere WCF Test İstemcisi'ni başlatmak için lütfen Çözüm Gezgini'nde ElronService.svc veya ElronService.svc.cs öğesini seçin ve hata ayıklamaya başlayın.
    public class ElronService : IElronService
    {
        

        public string getFirmaInfo(string secim)
        {
            //DisKullaniciKimlik Değerlerinin Girilmesi
            DisKullaniciKimlik Kullanici = new DisKullaniciKimlik
            {
                KimlikNOTipi = KimlikNOTipi.VKN,
                ProgramAdi = ProgramAdi.Belirtilmemis,
                KimlikNO = "47371530088",
                NoterlikKodu = "",
                NoterlikKullaniciAdi = "",
                DisKullaniciTipi = DisKullaniciTipi.MaliMusavir,
                Sifre = "musti330"
            };

            //Zaman Class'ının tanımı ---> Önemsiz
            Zaman time = new Zaman()
            {
                Ay = 8,
                Yil = 2021,
                Gun = 27,
                Saat = 16,
                Dakika = 26,
                Saniye = 30
            };
            
            long geriDonusDegeri; //Header içinde kullanacağımız response değeri
            string x="ab";

            ServiceSoapClient kimlikDogrula  = new ServiceSoapClient();
            kimlikDogrula.DisKullaniciKimlikDogrula2(Kullanici, NPSIslemTipi.DefterOnayi, time, out geriDonusDegeri);
            

            return x;
        }
    }
}