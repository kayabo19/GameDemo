using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    internal class SaleManager:ISaleManager
    {
        public void SatınAl(Player player, Game game, Kampanya kampanya)
        {
            Console.WriteLine(player.ID+" "+ "Satın Aldı:"+" "+game.OyunAdi+" "+"("+ kampanya.KampanyaAdı+ ")");

        }
    }
}
