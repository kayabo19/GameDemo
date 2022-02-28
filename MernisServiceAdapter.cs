using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    internal class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Player player)
        {
            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(player.TCNo,player.Ad.ToUpper(),player.Soyad.ToUpper(),player.DogumYili);
        }
    }
}
