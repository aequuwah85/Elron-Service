using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ElronService.KimlikDogrulama;
using System.Web.Script.Serialization;


namespace ElronService
{
    public class Service1 : IService1
    {      
        public string getFirmaInfoByVergiNo(string vergiKimlikNumarasi)
        {
            //Zorunlu yapılması gereken sorgu ve işlemler BAŞLANGIÇ
            DisKullaniciKimlik yeniDisKullanici = new DisKullaniciKimlik();
            yeniDisKullanici.KimlikNO = "47371530088";
            yeniDisKullanici.KimlikNOTipi = KimlikNOTipi.TCKN;
            yeniDisKullanici.DisKullaniciTipi = DisKullaniciTipi.MaliMusavir;
            yeniDisKullanici.Sifre = "musti330";
            long headerDeger;
            Zaman time = new Zaman()
            {
                Ay = 8,
                Dakika = 50,
                Gun = 25,
                Saat = 11,
                Saniye = 22,
                Yil = 2021
            };

            ServiceSoapClient KimlikDogrula = new ServiceSoapClient();
            KimlikDogrula.DisKullaniciKimlikDogrula(yeniDisKullanici, NPSIslemTipi.DefterOnayi, DateTime.Now, out headerDeger);
            //Zorunlu yapılması gereken sorgu ve işlemler BİTİŞ

            GIBB.MerkezBilgiSorguSonuc _sonuc = new GIBB.MerkezBilgiSorguSonuc();
            GIBB.BilgiServisHeader newHeader = new GIBB.BilgiServisHeader()
            {
                NPSBelgeNO = headerDeger,
                IslemTipi = GIBB.NPSIslemTipi.DefterOnayi,
                Sifre = "",
                Program = GIBB.ProgramAdi.Belirtilmemis
            };
            GIBB.NoterlikKimlikHeader noterHeader = new GIBB.NoterlikKimlikHeader();
            GIBB.GIBBilgiServisiSoapClient veriGoruntule = new GIBB.GIBBilgiServisiSoapClient();
            veriGoruntule.TuzelSahisMukellefMerkezBilgiSorgu(newHeader, noterHeader,vergiKimlikNumarasi, out _sonuc);
            string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(_sonuc);

            return jsonString;

        }

        public string getFirmaInfoByTCKNo(string TCKNumarasi)
        {
            //Zorunlu yapılması gereken sorgu ve işlemler BAŞLANGIÇ
            DisKullaniciKimlik yeniDisKullanici = new DisKullaniciKimlik();
            yeniDisKullanici.KimlikNO = "47371530088";
            yeniDisKullanici.KimlikNOTipi = KimlikNOTipi.TCKN;
            yeniDisKullanici.DisKullaniciTipi = DisKullaniciTipi.MaliMusavir;
            yeniDisKullanici.Sifre = "musti330";
            long headerDeger;
            Zaman time = new Zaman()
            {
                Ay = 8,
                Dakika = 50,
                Gun = 25,
                Saat = 11,
                Saniye = 22,
                Yil = 2021
            };

            ServiceSoapClient KimlikDogrula = new ServiceSoapClient();
            KimlikDogrula.DisKullaniciKimlikDogrula(yeniDisKullanici, NPSIslemTipi.DefterOnayi, DateTime.Now, out headerDeger);
            //Zorunlu yapılması gereken sorgu ve işlemler BİTİŞ

            GIBB.MerkezBilgiSorguSonuc _sonuc = new GIBB.MerkezBilgiSorguSonuc();
            GIBB.BilgiServisHeader newHeader = new GIBB.BilgiServisHeader()
            {
                NPSBelgeNO = headerDeger,
                IslemTipi = GIBB.NPSIslemTipi.DefterOnayi,
                Sifre = "",
                Program = GIBB.ProgramAdi.Belirtilmemis
            };
            GIBB.NoterlikKimlikHeader noterHeader = new GIBB.NoterlikKimlikHeader();
            GIBB.GIBBilgiServisiSoapClient veriGoruntule = new GIBB.GIBBilgiServisiSoapClient();
            veriGoruntule.GercekSahisMukellefMerkezBilgiSorgu(newHeader, noterHeader,Convert.ToInt64(TCKNumarasi), out _sonuc);
            
            string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(_sonuc);

            return jsonString;


        }

    }
}
