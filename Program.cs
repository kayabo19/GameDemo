using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Ad = "Bora";
            player1.Soyad = "Kaya";
            player1.TCNo = "2222222222";
            player1.ID = "042132151665";

            Game game1 = new Game();
            game1.OyunAdi = "Elden Ring";
            game1.Fiyat = 500;
            SaleManager saleManager = new SaleManager();

            Kampanya yaz = new Kampanya();
            yaz.KampanyaAdı = "Yaz Kampanyası";

            Kampanya kis = new Kampanya();
            kis.KampanyaAdı = "Kış Kampanyası";

            Kampanya ilkbahar = new Kampanya();
            ilkbahar.KampanyaAdı = "İlkbahar Kampanyası";

            Kampanya sonbahar = new Kampanya();
            sonbahar.KampanyaAdı = "Sonbahar Kampanyası";

            KampanyaService kampanyaService = new KampanyaService();    



            PlayerManager playerManager = new PlayerManager();

            playerManager.KayıtOl(player1);
            playerManager.Guncelle(player1);
            kampanyaService.KampanyaEkle(yaz);
            kampanyaService.KampanyaSil(ilkbahar);
            saleManager.SatınAl(player1, game1,yaz);
            








            Console.ReadKey();
            
        }
    }
}
