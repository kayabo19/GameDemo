using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    internal interface IPlayerManager
    {
         void KayıtOl(Player player);
        void Guncelle(Player player);
        void KayıtSil(Player player);
    }
}
