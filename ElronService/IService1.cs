using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ElronService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]     
        string getFirmaInfoByVergiNo(string vergiKimlikNumarasi);

        [OperationContract]
        string getFirmaInfoByTCKNo(string TCKNumarasi);
        // TODO: Add your service operations here
       
        
    }     
}


/*     
            DisKullaniciKimlik yeniDisKullanici = new DisKullaniciKimlik();
            yeniDisKullanici.KimlikNO = "47371530088";
            yeniDisKullanici.KimlikNOTipi = KimlikNOTipi.TCKN;
            yeniDisKullanici.DisKullaniciTipi = DisKullaniciTipi.MaliMusavir;
            yeniDisKullanici.Sifre = "musti330";
            long deger;
            Zaman time = new Zaman()
            {
                Ay = 8,
                Dakika = 50,
                Gun = 25,
                Saat = 11,
                Saniye = 22,
                Yil = 2021
            };


            KimlikDogrulamaServisi.ServiceSoapClient KimlikDogrula = new KimlikDogrulamaServisi.ServiceSoapClient();
            KimlikDogrula.DisKullaniciKimlikDogrula(yeniDisKullanici, NPSIslemTipi.DefterOnayi, DateTime.Now, out deger);
            MessageBox.Show("" + deger);


            string vergiKNO = "0120011224";

            GIBBilgiService.MerkezBilgiSorguSonuc _sonuc = new GIBBilgiService.MerkezBilgiSorguSonuc();
            GIBBilgiService.BilgiServisHeader newHeader = new GIBBilgiService.BilgiServisHeader();

            newHeader.NPSBelgeNO = deger;
            newHeader.IslemTipi = GIBBilgiService.NPSIslemTipi.DefterOnayi;
            newHeader.Sifre = "";
            newHeader.Program = GIBBilgiService.ProgramAdi.Belirtilmemis;

            GIBBilgiService.NoterlikKimlikHeader noterHeader = new GIBBilgiService.NoterlikKimlikHeader();
            GIBBilgiService.GIBBilgiServisiSoapClient veriGoruntule = new GIBBilgiService.GIBBilgiServisiSoapClient();
            veriGoruntule.TuzelSahisMukellefMerkezBilgiSorgu(newHeader, noterHeader, vergiKNO, out _sonuc);
            MessageBox.Show("" + _sonuc.Adi);
*/