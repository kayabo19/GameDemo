using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    internal class PlayerManager : IPlayerManager
    {
        private IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;   
        }

        public void KayıtOl(Player player)
        {
            
            if (_playerCheckService.CheckIfRealPlayer(player))
            {
                
                Console.WriteLine("Kayıt oldu:"+" "+player.Ad);

            }

            else
            {
                Console.WriteLine("Hatalı Giriş");
            }
            



        }

        
        

    
        

        public void Guncelle(Player player)
        {
            Console.WriteLine("Kayıt güncellendi:" + " " + player.Ad);
        }

        public void KayıtSil(Player player)
        {
            Console.WriteLine("Kayıt silindi:" + " " + player.Ad);
        }

        

        public bool CheckIfRealPlayer(Player player)
        {
            return true;
        }
    }
}
