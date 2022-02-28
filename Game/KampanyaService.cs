using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    internal class KampanyaService : IKampanyaService
    {
        public void KampanyaEkle(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya Eklendi:" + kampanya.KampanyaAdı);
        }

        public void KampanyaGuncelle(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya Guncellendi:" + kampanya.KampanyaAdı);
        }

        public void KampanyaSil(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya Silindi:" + kampanya.KampanyaAdı);
        }
    }
    }
